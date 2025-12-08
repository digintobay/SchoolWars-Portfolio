using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeOut : MonoBehaviour
{
    public Image fadeObject;


    public float currentTime = 0;
    public float fadeTime = 2;

    public void Awake()
    {
        StartCoroutine(Fade());
    }


    IEnumerator Fade()
    {
        Debug.Log("ÀÛµ¿");
        Color alpha = fadeObject.color;

        while (alpha.a > 0)
        {
            currentTime += Time.deltaTime / fadeTime;
            alpha.a = Mathf.Lerp(1, 0, currentTime);
            fadeObject.color = alpha;
            yield return null;
        }
    }
}
