using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JihyeSkillUIManager : MonoBehaviour
{

    [Header("지혜 스킬 공격 레벨 유아이 관리")]
    public TextMeshProUGUI LevelText;
    public TextMeshProUGUI LevelNextText;
    public TextMeshProUGUI BasicText;
    public TextMeshProUGUI BasicNextText;
    public TextMeshProUGUI LevelUpMoneyText;

    void Update()
    {
        if (SkillManager.jihyeskillLevel == 1)
        {

            //설정 관리해 주기
            LevelText.text = "LV.1";
            LevelNextText.text = "LV.2";
            BasicText.text = "단검을 x 자로 크로스하여 빠르게 2번 공격한다\r\n공격력 ><color=#4693C6> 250 </color>";
            BasicNextText.text = "단검을 x 자로 크로스하여 빠르게 2번 공격한다\r\n공격력 ><color=#FF9E9E> 310 </color>";
            LevelUpMoneyText.text = "145";

        }

        if (SkillManager.jihyeskillLevel == 2)
        {
            LevelText.text = "LV.2";
            LevelNextText.text = "LV.3";
            BasicText.text = "단검을 x 자로 크로스하여 빠르게 2번 공격한다\r\n공격력 ><color=#4693C6> 310 </color>";
            BasicNextText.text = "단검을 x 자로 크로스하여 빠르게 2번 공격한다\r\n공격력 ><color=#FF9E9E> 410 </color>";
            LevelUpMoneyText.text = "150";

        }

        if (SkillManager.jihyeskillLevel == 3)
        {

            LevelText.text = "LV.3";
            LevelNextText.text = "LV.4";
            BasicText.text = "단검을 x 자로 크로스하여 빠르게 2번 공격한다\r\n공격력 ><color=#4693C6> 410 </color>";
            BasicNextText.text = "단검을 x 자로 크로스하여 빠르게 2번 공격한다\r\n공격력 ><color=#FF9E9E> 520 </color>";
            LevelUpMoneyText.text = "170";


        }

        if (SkillManager.jihyeskillLevel == 4)
        {
            LevelText.text = "LV.4";
            LevelNextText.text = "LV.5";
            BasicText.text = "단검을 x 자로 크로스하여 빠르게 2번 공격한다\r\n공격력 ><color=#4693C6> 520 </color>";
            BasicNextText.text = "단검을 x 자로 크로스하여 빠르게 2번 공격한다\r\n공격력 ><color=#FF9E9E> 650 </color>";
            LevelUpMoneyText.text = "200";


        }


        if (SkillManager.jihyeskillLevel == 5)
        {
            LevelText.text = "LV.5";
            LevelNextText.text = "LV.6";
            BasicText.text = "단검을 x 자로 크로스하여 빠르게 2번 공격한다\r\n공격력 ><color=#4693C6> 650 </color>";
            BasicNextText.text = "단검을 x 자로 크로스하여 빠르게 2번 공격한다\r\n공격력 ><color=#FF9E9E> 870 </color>";
            LevelUpMoneyText.text = "250";


        }

        if (SkillManager.jihyeskillLevel == 6)
        {
            LevelText.text = "LV.6";
            LevelNextText.text = "LV.7";
            BasicText.text = "단검을 x 자로 크로스하여 빠르게 2번 공격한다\r\n공격력 ><color=#4693C6> 870 </color>";
            BasicNextText.text = "단검을 x 자로 크로스하여 빠르게 2번 공격한다\r\n공격력 ><color=#FF9E9E> 1210 </color>";
            LevelUpMoneyText.text = "300";


        }

        if (SkillManager.jihyeskillLevel == 7)
        {
            //설정 관리해 주기
            LevelText.text = "LV.7";
            LevelNextText.text = "Max";
            BasicText.text = "단검을 x 자로 크로스하여 빠르게 2번 공격한다\r\n공격력 ><color=#FF9E9E> 1210 </color>";
            BasicNextText.text = "맥스  레벨에 도달했습니다 ";
            LevelUpMoneyText.text = "MAX";


        }

    }
}
