using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
{
    public Collider objA;
    // ����һ��ʤ����Ч
    public AudioSource  victorysound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //������������֮�����ײ�߼�
    //��sphere����plane��ʱ��͵������plane������������
    //���Թ�
    //������A��Ͷ�ŵ�planeλ�ã�����ʤ��������ͨ�ء�
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("home") || collision.collider == objA)
        {
            Destroy(objA);
            playaudio();
        }
    }
    void playaudio()
    {
        if(victorysound != null)
        {
            victorysound.Play();
        }
        else
        {
            Debug.Log("������ʤ����Ч");
        }
    }
}
