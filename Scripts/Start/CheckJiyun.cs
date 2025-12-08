using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckJiyun : MonoBehaviour
{
    public TutorialBringing tutorial;
    public GameObject button;
    public DialogSystem dialog;

    private void Update()
    {
        if (tutorial.seyeongTalk == true)
        {
            button.SetActive(true);
            dialog.text[0] = "전투하기를 누르면 전투가 시작돼!";
            dialog.text[1] = "전투하기를 누르면 전투가 시작돼!";
        }
    }
}
