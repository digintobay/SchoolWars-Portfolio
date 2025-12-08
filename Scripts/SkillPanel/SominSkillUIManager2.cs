using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SominSkillUIManager2 : MonoBehaviour
{
    [Header("소민 스킬 공격 레벨 유아이 관리")]
    public TextMeshProUGUI sominLevelText;
    public TextMeshProUGUI sominLevelNextText;
    public TextMeshProUGUI sominBasicText;
    public TextMeshProUGUI sominBasicNextText;
    public TextMeshProUGUI sominLevelUpMoneyText;

    void Update()
    {
        if (SkillManager.sominskillLevel == 1)
        {

            //설정 관리해 주기
            sominLevelText.text = "LV.1";
            sominLevelNextText.text = "LV.2";
            sominBasicText.text = "연속적으로 두 번 공격합니다\r\n대검을 크게 휘두른 후 바닥으로 내리친다\r\n공격력 ><color=#4693C6> 235 </color>";
            sominBasicNextText.text = "연속적으로 두 번 공격합니다\r\n대검을 크게 휘두른 후 바닥으로 내리친다\r\n공격력 ><color=#FF9E9E> 290 </color>";
            sominLevelUpMoneyText.text = "145";

        }

        if (SkillManager.sominskillLevel == 2)
        {
            sominLevelText.text = "LV.2";
            sominLevelNextText.text = "LV.3";
            sominBasicText.text = "연속적으로 두 번 공격합니다\r\n대검을 크게 휘두른 후 바닥으로 내리친다\r\n공격력 ><color=#4693C6> 290 </color>";
            sominBasicNextText.text = "연속적으로 두 번 공격합니다\r\n대검을 크게 휘두른 후 바닥으로 내리친다\r\n공격력 ><color=#FF9E9E> 375 </color>";
            sominLevelUpMoneyText.text = "150";

        }

        if (SkillManager.sominskillLevel == 3)
        {

            sominLevelText.text = "LV.3";
            sominLevelNextText.text = "LV.4";
            sominBasicText.text = "연속적으로 두 번 공격합니다\r\n대검을 크게 휘두른 후 바닥으로 내리친다\r\n공격력 ><color=#4693C6> 375 </color>";
            sominBasicNextText.text = "연속적으로 두 번 공격합니다\r\n대검을 크게 휘두른 후 바닥으로 내리친다\r\n공격력 ><color=#FF9E9E> 470 </color>";
            sominLevelUpMoneyText.text = "170";


        }

        if (SkillManager.sominskillLevel == 4)
        {
            sominLevelText.text = "LV.4";
            sominLevelNextText.text = "LV.5";
            sominBasicText.text = "연속적으로 두 번 공격합니다\r\n대검을 크게 휘두른 후 바닥으로 내리친다\r\n공격력 ><color=#4693C6> 470 </color>";
            sominBasicNextText.text = "연속적으로 두 번 공격합니다\r\n대검을 크게 휘두른 후 바닥으로 내리친다\r\n공격력 ><color=#FF9E9E> 600 </color>";
            sominLevelUpMoneyText.text = "200";


        }


        if (SkillManager.sominskillLevel == 5)
        {
            sominLevelText.text = "LV.5";
            sominLevelNextText.text = "LV.6";
            sominBasicText.text = "연속적으로 두 번 공격합니다\r\n대검을 크게 휘두른 후 바닥으로 내리친다\r\n공격력 ><color=#4693C6> 600 </color>";
            sominBasicNextText.text = "연속적으로 두 번 공격합니다\r\n대검을 크게 휘두른 후 바닥으로 내리친다\r\n공격력 ><color=#FF9E9E> 805 </color>";
            sominLevelUpMoneyText.text = "250";


        }

        if (SkillManager.sominskillLevel == 6)
        {
            sominLevelText.text = "LV.6";
            sominLevelNextText.text = "LV.7";
            sominBasicText.text = "연속적으로 두 번 공격합니다\r\n대검을 크게 휘두른 후 바닥으로 내리친다\r\n공격력 ><color=#4693C6> 805 </color>";
            sominBasicNextText.text = "연속적으로 두 번 공격합니다\r\n대검을 크게 휘두른 후 바닥으로 내리친다\r\n공격력 ><color=#FF9E9E> 1045 </color>";
            sominLevelUpMoneyText.text = "300";


        }

        if (SkillManager.sominskillLevel == 7)
        {
            //설정 관리해 주기
            sominLevelText.text = "LV.7";
            sominLevelNextText.text = "Max";
            sominBasicText.text = "연속적으로 두 번 공격합니다\r\n대검을 크게 휘두른 후 바닥으로 내리친다\r\n공격력 ><color=#FF9E9E> 1045 </color>";
            sominBasicNextText.text = "맥스  레벨에 도달했습니다 ";
            sominLevelUpMoneyText.text = "MAX";


        }

    }
}
