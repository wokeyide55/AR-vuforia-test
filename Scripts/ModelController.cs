using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ModelController :DefaultAreaTargetEventHandler
{
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        // 启用模型
        FingerController.instance.gameObject.SetActive(true);
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        // 禁用模型
        FingerController.instance.gameObject.SetActive(false);
    }
}

