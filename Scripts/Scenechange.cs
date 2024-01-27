using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void scenechange1()
    {
        SceneManager.LoadScene(1);
    }
    public void scenechange2()
    {
        SceneManager.LoadScene(2);
    }
    public void scenechange3()
    {
        SceneManager.LoadScene(3);
    }
    public void Exitscene()
    {
        //关闭程序
        Application.Quit();
        // 如果是编辑器模式，停止播放
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

}
