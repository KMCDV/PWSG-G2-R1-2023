using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
   public void ShakeCamera()
    {
        transform.DOShakePosition(1f);
    }
}
