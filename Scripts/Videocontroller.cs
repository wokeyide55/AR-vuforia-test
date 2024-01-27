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
    //ʶ����ʱ
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
        //��ȡ�������VideoPlayer ʹ��Ƶ����
        GetComponentInChildren<VideoPlayer>().Play();
    }

    //ʶ��ʧʱ
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
        //��ȡ�������VideoPlayer ʹ��Ƶ��ͣ
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
