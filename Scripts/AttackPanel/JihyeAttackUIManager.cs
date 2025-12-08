using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JihyeAttackUIManager : MonoBehaviour
{
    [Header("지혜 기본 공격 레벨 유아이 관리")]
    public TextMeshProUGUI LevelText;
    public TextMeshProUGUI LevelNextText;
    public TextMeshProUGUI BasicText;
    public TextMeshProUGUI BasicNextText;
    public TextMeshProUGUI LevelUpMoneyText;

    public void Update()
    {



        if (SkillManager.jihyeattackLevel == 1)
        {

            //설정 관리해 주기
            LevelText.text = "LV.1";
            LevelNextText.text = "LV.2";
            BasicText.text = "단검을 빠르게 2번 휘두른다\r\n공격력 > <color=#4693C6>130 </color>\r\n공격 속도 ><color=#4693C6> 1 </color>";
            BasicNextText.text = "단검을 빠르게 2번 휘두른다\r\n공격력 > <color=#FF9E9E>150 </color>\r\n공격 속도 ><color=#FF9E9E> 1.1 </color>";
            LevelUpMoneyText.text = "130";

        }

        if (SkillManager.jihyeattackLevel == 2)
        {
            //설정 관리해 주기
            LevelText.text = "LV.2";
            LevelNextText.text = "LV.3";
            BasicText.text = "단검을 빠르게 2번 휘두른다\r\n공격력 > <color=#4693C6>150 </color>\r\n공격 속도 ><color=#4693C6> 1.1 </color>";
            BasicNextText.text = "단검을 빠르게 2번 휘두른다\r\n공격력 > <color=#FF9E9E>175 </color>\r\n공격 속도 ><color=#FF9E9E> 1.2 </color>";
            LevelUpMoneyText.text = "135";


        }

        if (SkillManager.jihyeattackLevel == 3)
        {
            //설정 관리해 주기
            LevelText.text = "LV.3";
            LevelNextText.text = "LV.4";
            BasicText.text = "단검을 빠르게 2번 휘두른다\r\n공격력 > <color=#4693C6>175 </color>\r\n공격 속도 ><color=#4693C6> 1.2 </color>";
            BasicNextText.text = "단검을 빠르게 2번 휘두른다\r\n공격력 > <color=#FF9E9E>210 </color>\r\n공격 속도 ><color=#FF9E9E> 1.3 </color>";
            LevelUpMoneyText.text = "140";


        }

        if (SkillManager.jihyeattackLevel == 4)
        {
            //설정 관리해 주기
            LevelText.text = "LV.4";
            LevelNextText.text = "LV.5";
            BasicText.text = "단검을 빠르게 2번 휘두른다\r\n공격력 > <color=#4693C6>210 </color>\r\n공격 속도 ><color=#4693C6> 1.3 </color>";
            BasicNextText.text = "단검을 빠르게 2번 휘두른다\r\n공격력 > <color=#FF9E9E>250 </color>\r\n공격 속도 ><color=#FF9E9E> 1.4 </color>";
            LevelUpMoneyText.text = "150";


        }


        if (SkillManager.jihyeattackLevel == 5)
        {
            //설정 관리해 주기
            LevelText.text = "LV.5";
            LevelNextText.text = "LV.6";
            BasicText.text = "단검을 빠르게 2번 휘두른다\r\n공격력 > <color=#4693C6>250 </color>\r\n공격 속도 ><color=#4693C6> 1.4 </color>";
            BasicNextText.text = "단검을 빠르게 2번 휘두른다\r\n공격력 > <color=#FF9E9E>320 </color>\r\n공격 속도 ><color=#FF9E9E> 1.5 </color>";
            LevelUpMoneyText.text = "170";


        }

        if (SkillManager.jihyeattackLevel == 6)
        {
            //설정 관리해 주기
            LevelText.text = "LV.6";
            LevelNextText.text = "LV.7";
            BasicText.text = "단검을 빠르게 2번 휘두른다\r\n공격력 > <color=#4693C6>320 </color>\r\n공격 속도 ><color=#4693C6> 1.5 </color>";
            BasicNextText.text = "단검을 빠르게 2번 휘두른다\r\n공격력 > <color=#FF9E9E>410 </color>\r\n공격 속도 ><color=#FF9E9E> 1.6 </color>";
            LevelUpMoneyText.text = "200";


        }

        if (SkillManager.jihyeattackLevel == 7)
        {
            //설정 관리해 주기
            LevelText.text = "LV.7";
            LevelNextText.text = "Max";
            BasicText.text = "단검을 빠르게 2번 휘두른다\r\n공격력 > <color=#4693C6>410 </color>\r\n공격 속도 ><color=#4693C6> 1.6 </color>";
            BasicNextText.text = "맥스  레벨에 도달했습니다 ";
            LevelUpMoneyText.text = "MAX";


        }

    }
}
