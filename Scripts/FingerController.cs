using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
/// <summary>
/// ͨ�����ƿ���ģ�͵���ת
/// </summary>
public enum FingerIE
{
    zero,
    OneFinger,
    TwoFinger,
}
public class FingerController : MonoBehaviour
{

    public Vector3 initialRot;
    public Vector3 initialSca;
    public static FingerController instance;
    IEnumerator ie;
    FingerIE finger_num = FingerIE.zero;
    void Awake()
    {
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount == 0)
        {
            if (finger_num != FingerIE.zero)
            {
                StopCoroutine(ie);
                ie = null;
                finger_num = FingerIE.zero;
            }
        }
        else if (Input.touchCount == 1)
        {
            if (finger_num != FingerIE.OneFinger)
            {
                if (ie != null)
                {
                    StopCoroutine(ie);
                }
                ie = IMonitorMouseOneFinger();
                StartCoroutine(ie);
                finger_num = FingerIE.OneFinger;
            }
        }
        else if (Input.touchCount == 2)
        {
            if (finger_num != FingerIE.TwoFinger)
            {
                if (ie != null)
                {
                    StopCoroutine(ie);
                }
                ie = IIMonitorMouseTwoFinger();
                StartCoroutine(ie);
                finger_num = FingerIE.TwoFinger;
            }
        }

    }
    /// <summary>
    /// һ����ָ����ת��
    /// </summary>
    /// <returns></returns>
    IEnumerator IMonitorMouseOneFinger()
    {
        while (true)
        {
            if (Input.touchCount == 1)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    Vector2 deltaPos = touch.deltaPosition;
                    transform.Rotate(Vector3.up, -deltaPos.x * 0.2f, Space.World);
                    transform.Rotate(Vector3.right, deltaPos.y * 0.2f, Space.World);
                }
            }
            yield return null;
        }
    }
    /// <summary>
    /// ������ָ��������
    /// </summary>
    /// <returns></returns>
    IEnumerator IIMonitorMouseTwoFinger()
    {
        while (true)
        {
            if (Input.touchCount == 2)
            {
                Touch touchOne = Input.GetTouch(0);
                Touch touchTwo = Input.GetTouch(1);

                if (touchOne.phase == TouchPhase.Moved || touchTwo.phase == TouchPhase.Moved)
                {
                    Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;
                    Vector2 touchTwoPrevPos = touchTwo.position - touchTwo.deltaPosition;

                    float prevMagnitude = (touchOnePrevPos - touchTwoPrevPos).magnitude;
                    float currentMagnitude = (touchOne.position - touchTwo.position).magnitude;

                    float difference = currentMagnitude - prevMagnitude;

                    // �����µ��������Ӳ�Ӧ������
                    float scaleFactor = transform.localScale.x + difference * 0.01f;
                    scaleFactor = Mathf.Clamp(scaleFactor, 0.1f, 5f); // ������С���������ֵ

                    // Ӧ���µ����ű���
                    transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
                }
            }
            yield return null;
        }
    }
    /// <summary>
    /// ��λ
    /// </summary>
    public void ResetRot()
    {
        this.transform.localEulerAngles = initialRot;
        this.transform.localScale = initialSca;
    }
}
