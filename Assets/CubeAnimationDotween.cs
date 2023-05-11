using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeAnimationDotween : MonoBehaviour
{
    public AnimationCurve animationCurve;
    private MeshRenderer meshRenderer;
    private Vector3 originalPosition;
    private float time;
    public Gradient gradient;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.DOGradientColor(gradient, 5f).SetLoops(-1, LoopType.Restart);
        originalPosition = transform.position;
        //RandomNewPositionAndMove();
        //transform.DOScale(transform.localScale.x * 2f, 2f).SetLoops(-1, LoopType.Yoyo);
        //transform.DORotate(new Vector3(0, 360, 0), 2f, RotateMode.LocalAxisAdd).SetLoops(-1);
    }

    private void RandomNewPositionAndMove()
    {
        Vector3 newPosition = originalPosition + new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));
        transform.DOMove(newPosition, 2f).SetEase(Ease.InOutElastic).OnComplete(RandomNewPositionAndMove);
    }

    private void Update()
    {
        //time += Time.deltaTime;
        //transform.position = Vector3.LerpUnclamped(originalPosition, originalPosition + Vector3.up * 10, animationCurve.Evaluate(time));
    
    }
}
