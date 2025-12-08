using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AttackLevelUp : MonoBehaviour
{

    public AudioClip levelUpSFX;

    //¼Ò¹Î
    public void Somin()
    {
        if (SkillManager.sominattackLevel == 1 && Money.Upbringingmoney >=130 )
        {
            Money.Upbringingmoney -= 130;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SominTwoLevel();
        }

        else if (SkillManager.sominattackLevel == 2 && Money.Upbringingmoney >= 135)
        {
            Money.Upbringingmoney -= 135;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SominThreeLevel();
        }

       else if (SkillManager.sominattackLevel == 3 && Money.Upbringingmoney >= 140)
        {
            Money.Upbringingmoney -= 140;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SominFourLevel();
        }

       else if (SkillManager.sominattackLevel == 4 && Money.Upbringingmoney >= 150)
        {
            Money.Upbringingmoney -= 150;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SominFiveLevel();
        }

       else if (SkillManager.sominattackLevel == 5 && Money.Upbringingmoney >= 170)
        {
            Money.Upbringingmoney -= 170;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SominSixLevel();
        }

       else if (SkillManager.sominattackLevel == 6 && Money.Upbringingmoney >= 200)
        {
            Money.Upbringingmoney -= 200;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SominSevenLevel();
        }
        else
        {
            return;
        }
    }

    //ÁöÇý
    public void Jihye()
    {
        if (SkillManager.jihyeattackLevel == 1 && Money.Upbringingmoney >= 130)
        {
            Money.Upbringingmoney -= 130;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JihyeTwoLevel();
        }

        else if (SkillManager.jihyeattackLevel == 2 && Money.Upbringingmoney >= 135)
        {
            Money.Upbringingmoney -= 135;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JihyeThreeLevel();
        }

        else if (SkillManager.jihyeattackLevel == 3 && Money.Upbringingmoney >= 140)
        {
            Money.Upbringingmoney -= 140;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JihyeFourLevel();
        }

        else if (SkillManager.jihyeattackLevel == 4 && Money.Upbringingmoney >= 150)
        {
            Money.Upbringingmoney -= 150;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JihyeFiveLevel();
        }

        else if (SkillManager.jihyeattackLevel == 5 && Money.Upbringingmoney >= 170)
        {
            Money.Upbringingmoney -= 170;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JihyeSixLevel();
        }

        else if (SkillManager.jihyeattackLevel == 6 && Money.Upbringingmoney >= 200)
        {
            Money.Upbringingmoney -= 200;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JihyeSevenLevel();
        }
        else
        {
            return;
        }
    }

    //ÇÏ´Ã
    public void Haneul()
    {
        if (SkillManager.haneulattackLevel == 1 && Money.Upbringingmoney >= 130)
        {
            Money.Upbringingmoney -= 130;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.HaneulTwoLevel();
        }

        else if (SkillManager.haneulattackLevel == 2 && Money.Upbringingmoney >= 135)
        {
            Money.Upbringingmoney -= 135;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.HaneulThreeLevel();
        }

        else if (SkillManager.haneulattackLevel == 3 && Money.Upbringingmoney >= 140)
        {
            Money.Upbringingmoney -= 140;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.HaneulFourLevel();
        }

        else if (SkillManager.haneulattackLevel == 4 && Money.Upbringingmoney >= 150)
        {
            Money.Upbringingmoney -= 150;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.HaneulFiveLevel();
        }

        else if (SkillManager.haneulattackLevel == 5 && Money.Upbringingmoney >= 170)
        {
            Money.Upbringingmoney -= 170;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.HaneulSixLevel();
        }

        else if (SkillManager.haneulattackLevel == 6 && Money.Upbringingmoney >= 200)
        {
            Money.Upbringingmoney -= 200;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.HaneulSevenLevel();
        }
        else
        {
            return;
        }
    }

    //ÁöÀ±

    public void Jiyun()
    {
        if (SkillManager.jiyunattackLevel == 1 && Money.Upbringingmoney >= 130)
        {
            Money.Upbringingmoney -= 130;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JiyunTwoLevel();
        }

        else if (SkillManager.jiyunattackLevel == 2 && Money.Upbringingmoney >= 135)
        {
            Money.Upbringingmoney -= 135;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JiyunThreeLevel();
        }

        else if (SkillManager.jiyunattackLevel == 3 && Money.Upbringingmoney >= 140)
        {
            Money.Upbringingmoney -= 140;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JiyunFourLevel();
        }

        else if (SkillManager.jiyunattackLevel == 4 && Money.Upbringingmoney >= 150)
        {
            Money.Upbringingmoney -= 150;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JiyunFiveLevel();
        }

        else if (SkillManager.jiyunattackLevel == 5 && Money.Upbringingmoney >= 170)
        {
            Money.Upbringingmoney -= 170;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JiyunSixLevel();
        }

        else if (SkillManager.jiyunattackLevel == 6 && Money.Upbringingmoney >= 200)
        {
            Money.Upbringingmoney -= 200;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JiyunSevenLevel();
        }
        else
        {
            return;
        }
    }

    //¼¼¿µ

    public void Seyeong()
    {
        if (SkillManager.seyeongattackLevel == 1 && Money.Upbringingmoney >= 130)
        {
            Money.Upbringingmoney -= 130;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SeyeongTwoLevel();
        }

        else if (SkillManager.seyeongattackLevel == 2 && Money.Upbringingmoney >= 135)
        {
            Money.Upbringingmoney -= 135;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SeyeongThreeLevel();
        }

        else if (SkillManager.seyeongattackLevel == 3 && Money.Upbringingmoney >= 140)
        {
            Money.Upbringingmoney -= 140;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SeyeongFourLevel();
        }

        else if (SkillManager.seyeongattackLevel == 4 && Money.Upbringingmoney >= 150)
        {
            Money.Upbringingmoney -= 150;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SeyeongFiveLevel();
        }

        else if (SkillManager.seyeongattackLevel == 5 && Money.Upbringingmoney >= 170)
        {
            Money.Upbringingmoney -= 170;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SeyeongSixLevel();
        }

        else if (SkillManager.seyeongattackLevel == 6 && Money.Upbringingmoney >= 200)
        {
            Money.Upbringingmoney -= 200;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SeyeongSevenLevel();
        }
        else
        {
            return;
        }
    }


}
