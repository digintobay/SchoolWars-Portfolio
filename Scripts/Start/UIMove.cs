using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMove : MonoBehaviour
{
    private RectTransform rectTransform;
    private float speed = 15;
    bool goUp = false;
    bool goDown = false;


    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Start()
    {
        StartCoroutine(Move());

    }

    private void Update()
    {
        if (goUp)
        { rectTransform.Translate(Vector3.up * Time.deltaTime * speed); }

        if (goDown)
        {
            rectTransform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }




    IEnumerator Move()
    {
        goUp = true;
        yield return new WaitForSeconds(1f);
        goUp = false;
        goDown = true;
        yield return new WaitForSeconds(1f);
        goDown = false;
        StartCoroutine(Move());

    }

}
