using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;

public class SominSkillUIManager : MonoBehaviour
{
    [Header("소민 기본 공격 레벨 유아이 관리")]
    public TextMeshProUGUI sominLevelText;
    public TextMeshProUGUI sominLevelNextText;
    public TextMeshProUGUI sominBasicText;
    public TextMeshProUGUI sominBasicNextText;
    public TextMeshProUGUI sominLevelUpMoneyText;




    public void Update()
    {
     


        if (SkillManager.sominattackLevel == 1)
        {
    
            //설정 관리해 주기
            sominLevelText.text = "LV.1";
            sominLevelNextText.text = "LV.2";
            sominBasicText.text = "정면 방향으로 대검을 크게 휘두른다\r\n공격력 > <color=#4693C6>125 </color>\r\n공격 속도 ><color=#4693C6> 1 </color>";
            sominBasicNextText.text = "정면 방향으로 대검을 크게 휘두른다\r\n공격력 > <color=#FF9E9E>140 </color>\r\n공격 속도 ><color=#FF9E9E> 1.1 </color>";
            sominLevelUpMoneyText.text = "130";
    
        }

        if (SkillManager.sominattackLevel ==2)
        {  
            //설정 관리해 주기
            sominLevelText.text = "LV.2";
            sominLevelNextText.text = "LV.3";
            sominBasicText.text = "정면 방향으로 대검을 크게 휘두른다\r\n공격력 > <color=#4693C6>140 </color>\r\n공격 속도 ><color=#4693C6> 1.1 </color>";
            sominBasicNextText.text = "정면 방향으로 대검을 크게 휘두른다\r\n공격력 > <color=#FF9E9E>160 </color>\r\n공격 속도 ><color=#FF9E9E> 1.2 </color>";
            sominLevelUpMoneyText.text = "135";


        }

        if (SkillManager.sominattackLevel == 3)
        {
            //설정 관리해 주기
            sominLevelText.text = "LV.3";
            sominLevelNextText.text = "LV.4";
            sominBasicText.text = "정면 방향으로 대검을 크게 휘두른다\r\n공격력 > <color=#4693C6>160 </color>\r\n공격 속도 ><color=#4693C6> 1.2 </color>";
            sominBasicNextText.text = "정면 방향으로 대검을 크게 휘두른다\r\n공격력 > <color=#FF9E9E>190 </color>\r\n공격 속도 ><color=#FF9E9E> 1.3 </color>";
            sominLevelUpMoneyText.text = "140";


        }

        if (SkillManager.sominattackLevel == 4)
        {
            //설정 관리해 주기
            sominLevelText.text = "LV.4";
            sominLevelNextText.text = "LV.5";
            sominBasicText.text = "정면 방향으로 대검을 크게 휘두른다\r\n공격력 > <color=#4693C6>190 </color>\r\n공격 속도 ><color=#4693C6> 1.3 </color>";
            sominBasicNextText.text = "정면 방향으로 대검을 크게 휘두른다\r\n공격력 > <color=#FF9E9E>235 </color>\r\n공격 속도 ><color=#FF9E9E> 1.4 </color>";
            sominLevelUpMoneyText.text = "150";


        }


        if (SkillManager.sominattackLevel == 5)
        {
            //설정 관리해 주기
            sominLevelText.text = "LV.5";
            sominLevelNextText.text = "LV.6";
            sominBasicText.text = "정면 방향으로 대검을 크게 휘두른다\r\n공격력 > <color=#4693C6>235 </color>\r\n공격 속도 ><color=#4693C6> 1.4 </color>";
            sominBasicNextText.text = "정면 방향으로 대검을 크게 휘두른다\r\n공격력 > <color=#FF9E9E>300 </color>\r\n공격 속도 ><color=#FF9E9E> 1.5 </color>";
            sominLevelUpMoneyText.text = "170";


        }

        if (SkillManager.sominattackLevel == 6)
        {
            //설정 관리해 주기
            sominLevelText.text = "LV.6";
            sominLevelNextText.text = "LV.7";
            sominBasicText.text = "정면 방향으로 대검을 크게 휘두른다\r\n공격력 > <color=#4693C6>300 </color>\r\n공격 속도 ><color=#4693C6> 1.5 </color>";
            sominBasicNextText.text = "정면 방향으로 대검을 크게 휘두른다\r\n공격력 > <color=#FF9E9E>390 </color>\r\n공격 속도 ><color=#FF9E9E> 1.6 </color>";
            sominLevelUpMoneyText.text = "200";


        }

        if (SkillManager.sominattackLevel == 7)
        {
            //설정 관리해 주기
            sominLevelText.text = "LV.7";
            sominLevelNextText.text = "Max";
            sominBasicText.text = "정면 방향으로 대검을 크게 휘두른다\r\n공격력 > <color=#4693C6>390 </color>\r\n공격 속도 ><color=#4693C6> 1.6 </color>";
            sominBasicNextText.text = "맥스  레벨에 도달했습니다 ";
            sominLevelUpMoneyText.text = "MAX";


        }

    }
}
