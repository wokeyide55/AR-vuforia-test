using UnityEngine;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour
{
    public GameObject popupPanel; // ����UI������

    private void Start()
    {
        // ������ʱ������UI����Ϊ���ɼ�
        popupPanel.SetActive(false);
    }

    public void ShowPopup()
    {
        // ����ť�����ʱ����ʾ����UI
        popupPanel.SetActive(true);
    }

    public void HidePopup()
    {
        // ���رհ�ť�������رշ���������ʱ�����ص���UI
        popupPanel.SetActive(false);
    }
}
