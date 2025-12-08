using System;
using System.Collections;
using UnityEngine;

public class LineUIManager : MonoBehaviour
{   
    public Color hoverColor;

    private float normalAlpha = 0.0f;
    private float hoverAlpha = 1.0f;

    float currentTime = 0;
    float currentTime2 = 0;
    float fadeTime = 2;

    private SpriteRenderer line;

    private void Awake()
    {
    
     
        line = GetComponent<SpriteRenderer>();
        
        hoverColor = line.color;

    }

    private void OnEnable()
    {
        StopAllCoroutines();
        StartCoroutine(StartLines());
    }

  
    IEnumerator StartLines()
    {
        // 변수 초기화
        currentTime = 0;
        currentTime2 = 0;

        Color color = hoverColor;
        bool colorcheck = false;

        do
        {
            currentTime += Time.deltaTime / fadeTime;
            color.a = Mathf.Lerp(0, 1, currentTime);
            line.color = color;
            yield return null;
        }
        while (color.a < 1 && colorcheck == false);



        colorcheck = true;

        do
        {
            currentTime2 += Time.deltaTime / fadeTime;
            color.a = Mathf.Lerp(1, 0, currentTime2);
            line.color = color;
            yield return null;


        }
        while (color.a > 0 && colorcheck == true);

        

    }
}
