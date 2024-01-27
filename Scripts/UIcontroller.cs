using UnityEngine;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour
{
    public GameObject popupPanel; // 弹框UI的引用

    private void Start()
    {
        // 在启动时将弹框UI设置为不可见
        popupPanel.SetActive(false);
    }

    public void ShowPopup()
    {
        // 当按钮被点击时，显示弹框UI
        popupPanel.SetActive(true);
    }

    public void HidePopup()
    {
        // 当关闭按钮或其他关闭方法被触发时，隐藏弹框UI
        popupPanel.SetActive(false);
    }
}
