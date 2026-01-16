using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UICheck : MonoBehaviour
{
    [SerializeField]
    private GameObject[] blackUI = new GameObject[5];


    
    private void OnEnable()
    {
        if (Node.buildsomin==true)
        {
            blackUI[0].SetActive(false);
        }
        if (Node.buildjihye==true)
        {
            blackUI[1].SetActive(false);
        }
        if (Node.buildhaneul==true)
        {
            blackUI[2].SetActive(false);
        }
        if (Node.buildjiyun==true)
        {
            blackUI[3].SetActive(false);
        }
        if(Node.buildseyeong==true)
        {
            blackUI[4].SetActive(false);
        }
    }

}
