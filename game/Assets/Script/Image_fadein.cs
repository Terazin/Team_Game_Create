using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_fadein : MonoBehaviour
{
    public Ease Ease_Type;
    // Start is called before the first frame update
    void Start()
    {
        var fadeImage = GetComponent<Image>();
        fadeImage.enabled = true;
        var c = fadeImage.color;
        c.a = 1.0f;
        fadeImage.color = c;

        DOTween.ToAlpha
            (
            () => fadeImage.color,
            color => fadeImage.color = color,
            0f,
            1f
            )
            .SetLoops(-1, LoopType.Yoyo);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
