using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ModelController :DefaultAreaTargetEventHandler
{
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        // ����ģ��
        FingerController.instance.gameObject.SetActive(true);
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        // ����ģ��
        FingerController.instance.gameObject.SetActive(false);
    }
}

