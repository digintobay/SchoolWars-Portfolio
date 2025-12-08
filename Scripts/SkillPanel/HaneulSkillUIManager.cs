using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HaneulSkillUIManager : MonoBehaviour
{
    [Header("하늘 스킬 공격 레벨 유아이 관리")]
    public TextMeshProUGUI LevelText;
    public TextMeshProUGUI LevelNextText;
    public TextMeshProUGUI BasicText;
    public TextMeshProUGUI BasicNextText;
    public TextMeshProUGUI LevelUpMoneyText;

    void Update()
    {
        if (SkillManager.haneulskillLevel == 1)
        {

            //설정 관리해 주기
            LevelText.text = "LV.1";
            LevelNextText.text = "LV.2";
            BasicText.text = "점프하며 상단으로 1번 공격한 후 바닥을 향해 1번 내리친다\r\n공격력 ><color=#4693C6> 300 </color>";
            BasicNextText.text = "점프하며 상단으로 1번 공격한 후 바닥을 향해 1번 내리친다\r\n공격력 ><color=#FF9E9E> 390 </color>";
            LevelUpMoneyText.text = "145";

        }

        if (SkillManager.haneulskillLevel == 2)
        {
            LevelText.text = "LV.2";
            LevelNextText.text = "LV.3";
            BasicText.text = "점프하며 상단으로 1번 공격한 후 바닥을 향해 1번 내리친다\r\n공격력 ><color=#4693C6> 390 </color>";
            BasicNextText.text = "점프하며 상단으로 1번 공격한 후 바닥을 향해 1번 내리친다\r\n공격력 ><color=#FF9E9E> 510 </color>";
            LevelUpMoneyText.text = "150";

        }

        if (SkillManager.haneulskillLevel == 3)
        {

            LevelText.text = "LV.3";
            LevelNextText.text = "LV.4";
            BasicText.text = "점프하며 상단으로 1번 공격한 후 바닥을 향해 1번 내리친다\r\n공격력 ><color=#4693C6> 510 </color>";
            BasicNextText.text = "점프하며 상단으로 1번 공격한 후 바닥을 향해 1번 내리친다\r\n공격력 ><color=#FF9E9E> 720 </color>";
            LevelUpMoneyText.text = "170";


        }

        if (SkillManager.haneulskillLevel == 4)
        {
            LevelText.text = "LV.4";
            LevelNextText.text = "LV.5";
            BasicText.text = "점프하며 상단으로 1번 공격한 후 바닥을 향해 1번 내리친다\r\n공격력 ><color=#4693C6> 720 </color>";
            BasicNextText.text = "점프하며 상단으로 1번 공격한 후 바닥을 향해 1번 내리친다\r\n공격력 ><color=#FF9E9E> 980 </color>";
            LevelUpMoneyText.text = "200";


        }


        if (SkillManager.haneulskillLevel == 5)
        {
            LevelText.text = "LV.5";
            LevelNextText.text = "LV.6";
            BasicText.text = "점프하며 상단으로 1번 공격한 후 바닥을 향해 1번 내리친다\r\n공격력 ><color=#4693C6> 980 </color>";
            BasicNextText.text = "점프하며 상단으로 1번 공격한 후 바닥을 향해 1번 내리친다\r\n공격력 ><color=#FF9E9E> 1200 </color>";
            LevelUpMoneyText.text = "250";


        }

        if (SkillManager.haneulskillLevel == 6)
        {
            LevelText.text = "LV.6";
            LevelNextText.text = "LV.7";
            BasicText.text = "점프하며 상단으로 1번 공격한 후 바닥을 향해 1번 내리친다\r\n공격력 ><color=#4693C6> 1200 </color>";
            BasicNextText.text = "점프하며 상단으로 1번 공격한 후 바닥을 향해 1번 내리친다\r\n공격력 ><color=#FF9E9E> 1500 </color>";
            LevelUpMoneyText.text = "300";


        }

        if (SkillManager.haneulskillLevel == 7)
        {
            //설정 관리해 주기
            LevelText.text = "LV.7";
            LevelNextText.text = "Max";
            BasicText.text = "점프하며 상단으로 1번 공격한 후 바닥을 향해 1번 내리친다\r\n공격력 ><color=#FF9E9E> 1500 </color>";
            BasicNextText.text = "맥스  레벨에 도달했습니다 ";
            LevelUpMoneyText.text = "MAX";


        }

    }
}
