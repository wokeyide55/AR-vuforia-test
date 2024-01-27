using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
{
    public Collider objA;
    // 定义一个胜利音效
    public AudioSource  victorysound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //处理两个物体之间的碰撞逻辑
    //当sphere碰到plane的时候就掉进这个plane，二者吸附上
    //测试关
    //当发现A被投放到plane位置，播放胜利动画，通关。
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
            Debug.Log("请拖入胜利音效");
        }
    }
}
