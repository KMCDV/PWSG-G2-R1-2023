using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PostProcessDotween : MonoBehaviour
{
    public float value;
    public VolumeProfile profile;

    // Start is called before the first frame update
    void Start()
    {
        DOVirtual.Float(-180, 180, 1f, UpdateValue).SetLoops(-1, LoopType.Restart);
    }

    private void UpdateValue(float newValue)
    {
        value = newValue;
        if(profile.TryGet(out ColorAdjustments colorAdjustments))
        {
            colorAdjustments.hueShift.Override(value);
        }
    }

}
