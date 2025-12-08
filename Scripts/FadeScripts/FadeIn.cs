using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{

    public Image fadeObject;

    public float currentTime = 0;
    public float fadeTime =2;

    public void Start()
    {
        StartCoroutine(Fade());
    }


    IEnumerator Fade()
    {
        fadeObject.gameObject.SetActive(true);
        Color alpha = fadeObject.color;

        while (alpha.a < 1)
        {
            currentTime += Time.deltaTime / fadeTime;
            alpha.a = Mathf.Lerp(0, 1, currentTime);
            fadeObject.color = alpha;
            yield return null;
        }

    }





}
