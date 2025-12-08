using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JiyunSkillUIManager : MonoBehaviour
{
    [Header("ÁöÀ± ½ºÅ³ °ø°Ý ·¹º§ À¯¾ÆÀÌ °ü¸®")]
    public TextMeshProUGUI LevelText;
    public TextMeshProUGUI LevelNextText;
    public TextMeshProUGUI BasicText;
    public TextMeshProUGUI BasicNextText;
    public TextMeshProUGUI LevelUpMoneyText;

    void Update()
    {
        if (SkillManager.jiyunskillLevel == 1)
        {

            //¼³Á¤ °ü¸®ÇØ ÁÖ±â
            LevelText.text = "LV.1";
            LevelNextText.text = "LV.2";
            BasicText.text = "ÃÑÀ» ´¯Èù ÈÄ °¡·Î·Î ³Ð°Ô °ø°ÝÇÑ´Ù\r\n°ø°Ý·Â ><color=#4693C6> 225 </color>";
            BasicNextText.text = "ÃÑÀ» ´¯Èù ÈÄ °¡·Î·Î ³Ð°Ô °ø°ÝÇÑ´Ù\r\n°ø°Ý·Â ><color=#FF9E9E> 280 </color>";
            LevelUpMoneyText.text = "145";

        }

        if (SkillManager.jiyunskillLevel == 2)
        {
            LevelText.text = "LV.2";
            LevelNextText.text = "LV.3";
            BasicText.text = "ÃÑÀ» ´¯Èù ÈÄ °¡·Î·Î ³Ð°Ô °ø°ÝÇÑ´Ù\r\n°ø°Ý·Â ><color=#4693C6> 280 </color>";
            BasicNextText.text = "ÃÑÀ» ´¯Èù ÈÄ °¡·Î·Î ³Ð°Ô °ø°ÝÇÑ´Ù\r\n°ø°Ý·Â ><color=#FF9E9E> 360 </color>";
            LevelUpMoneyText.text = "150";

        }

        if (SkillManager.jiyunskillLevel == 3)
        {

            LevelText.text = "LV.3";
            LevelNextText.text = "LV.4";
            BasicText.text = "ÃÑÀ» ´¯Èù ÈÄ °¡·Î·Î ³Ð°Ô °ø°ÝÇÑ´Ù\r\n°ø°Ý·Â ><color=#4693C6> 360 </color>";
            BasicNextText.text = "ÃÑÀ» ´¯Èù ÈÄ °¡·Î·Î ³Ð°Ô °ø°ÝÇÑ´Ù\r\n°ø°Ý·Â ><color=#FF9E9E> 485 </color>";
            LevelUpMoneyText.text = "170";


        }

        if (SkillManager.jiyunskillLevel == 4)
        {
            LevelText.text = "LV.4";
            LevelNextText.text = "LV.5";
            BasicText.text = "ÃÑÀ» ´¯Èù ÈÄ °¡·Î·Î ³Ð°Ô °ø°ÝÇÑ´Ù\r\n°ø°Ý·Â ><color=#4693C6> 485 </color>";
            BasicNextText.text = "ÃÑÀ» ´¯Èù ÈÄ °¡·Î·Î ³Ð°Ô °ø°ÝÇÑ´Ù\r\n°ø°Ý·Â ><color=#FF9E9E> 575 </color>";
            LevelUpMoneyText.text = "200";


        }


        if (SkillManager.jiyunskillLevel == 5)
        {
            LevelText.text = "LV.5";
            LevelNextText.text = "LV.6";
            BasicText.text = "ÃÑÀ» ´¯Èù ÈÄ °¡·Î·Î ³Ð°Ô °ø°ÝÇÑ´Ù\r\n°ø°Ý·Â ><color=#4693C6> 575 </color>";
            BasicNextText.text = "ÃÑÀ» ´¯Èù ÈÄ °¡·Î·Î ³Ð°Ô °ø°ÝÇÑ´Ù\r\n°ø°Ý·Â ><color=#FF9E9E> 850 </color>";
            LevelUpMoneyText.text = "250";


        }

        if (SkillManager.jiyunskillLevel == 6)
        {
            LevelText.text = "LV.6";
            LevelNextText.text = "LV.7";
            BasicText.text = "ÃÑÀ» ´¯Èù ÈÄ °¡·Î·Î ³Ð°Ô °ø°ÝÇÑ´Ù\r\n°ø°Ý·Â ><color=#4693C6> 850 </color>";
            BasicNextText.text = "ÃÑÀ» ´¯Èù ÈÄ °¡·Î·Î ³Ð°Ô °ø°ÝÇÑ´Ù\r\n°ø°Ý·Â ><color=#FF9E9E> 1000 </color>";
            LevelUpMoneyText.text = "300";


        }

        if (SkillManager.jiyunskillLevel == 7)
        {
            //¼³Á¤ °ü¸®ÇØ ÁÖ±â
            LevelText.text = "LV.7";
            LevelNextText.text = "Max";
            BasicText.text = "ÃÑÀ» ´¯Èù ÈÄ °¡·Î·Î ³Ð°Ô °ø°ÝÇÑ´Ù\r\n°ø°Ý·Â ><color=#FF9E9E> 1000 </color>";
            BasicNextText.text = "¸Æ½º  ·¹º§¿¡ µµ´ÞÇß½À´Ï´Ù ";
            LevelUpMoneyText.text = "MAX";


        }

    }
}
