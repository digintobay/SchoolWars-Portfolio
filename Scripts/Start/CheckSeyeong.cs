using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckSeyeong : MonoBehaviour
{
    public TutorialBringing tutorial;
    public DialogSystem dialog;

    public bool check = false;

    private void Update()
    {
        if (tutorial.startPR == true)
        {
         
            dialog.text[0] = "임원들이랑 자기소개 잘 했어? 어떤 거 같아. 다들 좋은 사람들이지?";
            dialog.text[1] = "지원금을 많이 확보하기 전까지는 다른 학교와의 전투를 주로 활동하게 될거야.";
            dialog.text[2] = "지윤이와 대화를 통해 다른 학교와 전투할 수 있고 승리해서 얻은 지원금으로 학생회 임원들을 성장시킬 수 있어.";
            dialog.text[3] = "현재는 지원금이 넉넉하지 못해 성장시킬 수 없으니 전투를 먼저 진행해보자";
            dialog.text[4] = "다시 지윤이한테 가서 다른 학교와의 전투하겠다고 말해봐";

            if (check == false)
            {
                tutorial.seyeongTalk = true;
                check= true;    

            }
        }
    }
}
