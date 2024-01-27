using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Video;
using UnityEngine.UI;

public class Videocontroller : DefaultAreaTargetEventHandler
{
    public Button playbutton;
    public Button pausebutton;

    private void Start()
    {
        playbutton.onClick.AddListener(PlayVideo);
        pausebutton.onClick.AddListener(PauseVideo);
    }
    private void Update()
    {
        
    }
    //识别到了时
    protected override void OnTrackingFound()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Enable rendering:
        foreach (var component in rendererComponents)
            component.enabled = true;

        // Enable colliders:
        foreach (var component in colliderComponents)
            component.enabled = true;

        // Enable canvas':
        foreach (var component in canvasComponents)
            component.enabled = true;

        //playbutton.gameObject.SetActive(true);
        //获取子物体的VideoPlayer 使视频播放
        GetComponentInChildren<VideoPlayer>().Play();
    }

    //识别丢失时
    protected override void OnTrackingLost()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Disable rendering:
        foreach (var component in rendererComponents)
            component.enabled = false;

        // Disable colliders:
        foreach (var component in colliderComponents)
            component.enabled = false;

        // Disable canvas':
        foreach (var component in canvasComponents)
            component.enabled = false;

        //playbutton.gameObject.SetActive(false);
        //获取子物体的VideoPlayer 使视频暂停
        GetComponentInChildren<VideoPlayer>().Pause();
    }
    private void PlayVideo()
    {
        GetComponentInChildren<VideoPlayer>().Play();
    }
    private void PauseVideo()
    {
        GetComponentInChildren<VideoPlayer>().Pause();
    }
}
