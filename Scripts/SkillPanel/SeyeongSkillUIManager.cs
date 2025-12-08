using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SeyeongSkillUIManager : MonoBehaviour
{
    [Header("세영 스킬 공격 레벨 유아이 관리")]
    public TextMeshProUGUI LevelText;
    public TextMeshProUGUI LevelNextText;
    public TextMeshProUGUI BasicText;
    public TextMeshProUGUI BasicNextText;
    public TextMeshProUGUI LevelUpMoneyText;

    void Update()
    {
        if (SkillManager.seyeongskillLevel == 1)
        {

            //설정 관리해 주기
            LevelText.text = "LV.1";
            LevelNextText.text = "LV.2";
            BasicText.text = "자세를 고쳐 잡은 후 넓은 범위에 크게 1발 가격한다\r\n공격력 ><color=#4693C6> 200 </color>";
            BasicNextText.text = "자세를 고쳐 잡은 후 넓은 범위에 크게 1발 가격한다\r\n공격력 ><color=#FF9E9E> 250 </color>";
            LevelUpMoneyText.text = "145";

        }

        if (SkillManager.seyeongskillLevel == 2)
        {
            LevelText.text = "LV.2";
            LevelNextText.text = "LV.3";
            BasicText.text = "자세를 고쳐 잡은 후 넓은 범위에 크게 1발 가격한다\r\n공격력 ><color=#4693C6> 250 </color>";
            BasicNextText.text = "자세를 고쳐 잡은 후 넓은 범위에 크게 1발 가격한다\r\n공격력 ><color=#FF9E9E> 310 </color>";
            LevelUpMoneyText.text = "150";

        }

        if (SkillManager.seyeongskillLevel == 3)
        {

            LevelText.text = "LV.3";
            LevelNextText.text = "LV.4";
            BasicText.text = "자세를 고쳐 잡은 후 넓은 범위에 크게 1발 가격한다\r\n공격력 ><color=#4693C6> 310 </color>";
            BasicNextText.text = "자세를 고쳐 잡은 후 넓은 범위에 크게 1발 가격한다\r\n공격력 ><color=#FF9E9E> 390 </color>";
            LevelUpMoneyText.text = "170";


        }

        if (SkillManager.seyeongskillLevel == 4)
        {
            LevelText.text = "LV.4";
            LevelNextText.text = "LV.5";
            BasicText.text = "자세를 고쳐 잡은 후 넓은 범위에 크게 1발 가격한다\r\n공격력 ><color=#4693C6> 390 </color>";
            BasicNextText.text = "자세를 고쳐 잡은 후 넓은 범위에 크게 1발 가격한다\r\n공격력 ><color=#FF9E9E> 490 </color>";
            LevelUpMoneyText.text = "200";


        }


        if (SkillManager.seyeongskillLevel == 5)
        {
            LevelText.text = "LV.5";
            LevelNextText.text = "LV.6";
            BasicText.text = "자세를 고쳐 잡은 후 넓은 범위에 크게 1발 가격한다\r\n공격력 ><color=#4693C6> 490 </color>";
            BasicNextText.text = "자세를 고쳐 잡은 후 넓은 범위에 크게 1발 가격한다\r\n공격력 ><color=#FF9E9E> 630 </color>";
            LevelUpMoneyText.text = "250";


        }

        if (SkillManager.seyeongskillLevel == 6)
        {
            LevelText.text = "LV.6";
            LevelNextText.text = "LV.7";
            BasicText.text = "자세를 고쳐 잡은 후 넓은 범위에 크게 1발 가격한다\r\n공격력 ><color=#4693C6> 630 </color>";
            BasicNextText.text = "자세를 고쳐 잡은 후 넓은 범위에 크게 1발 가격한다\r\n공격력 ><color=#FF9E9E> 810 </color>";
            LevelUpMoneyText.text = "300";


        }

        if (SkillManager.seyeongskillLevel == 7)
        {
            //설정 관리해 주기
            LevelText.text = "LV.7";
            LevelNextText.text = "Max";
            BasicText.text = "자세를 고쳐 잡은 후 넓은 범위에 크게 1발 가격한다\r\n공격력 ><color=#FF9E9E> 810 </color>";
            BasicNextText.text = "맥스  레벨에 도달했습니다 ";
            LevelUpMoneyText.text = "MAX";


        }

    }
}
