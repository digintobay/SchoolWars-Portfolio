using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillLevelUp : MonoBehaviour
{
    
    public AudioClip levelUpSFX;

    public void SominSkill()
    {
        if (SkillManager.sominskillLevel == 1 && Money.Upbringingmoney >= 145)
        {
            Money.Upbringingmoney -= 145;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SominSkillTwoLevel();
        }

        else if (SkillManager.sominskillLevel == 2 && Money.Upbringingmoney >= 150)
        {
            Money.Upbringingmoney -= 150;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SominSkillThreeLevel();
        }

        else if (SkillManager.sominskillLevel == 3 && Money.Upbringingmoney >= 170)
        {
            Money.Upbringingmoney -= 170;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SominSkillFourLevel();
        }

        else if (SkillManager.sominskillLevel == 4 && Money.Upbringingmoney >= 200)
        {
            Money.Upbringingmoney -= 200;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SominSkillFiveLevel();
        }

        else if (SkillManager.sominskillLevel == 5 && Money.Upbringingmoney >= 250)
        {
            Money.Upbringingmoney -= 250;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SominSkillSixLevel();
        }

        else if (SkillManager.sominskillLevel == 6 && Money.Upbringingmoney >= 300)
        {
            Money.Upbringingmoney -= 300;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SominSkillSevenLevel();
        }
        else
        {
            return;
        }
    }

    public void JihyeSkill()
    {
        if (SkillManager.jihyeskillLevel == 1 && Money.Upbringingmoney >= 145)
        {
            Money.Upbringingmoney -= 145;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JihyeSkillTwoLevel();
        }

        else if (SkillManager.jihyeskillLevel == 2 && Money.Upbringingmoney >= 150)
        {
            Money.Upbringingmoney -= 150;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JihyeSkillThreeLevel();
        }

        else if (SkillManager.jihyeskillLevel == 3 && Money.Upbringingmoney >= 170)
        {
            Money.Upbringingmoney -= 170;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JihyeSkillFourLevel();
        }

        else if (SkillManager.jihyeskillLevel == 4 && Money.Upbringingmoney >= 200)
        {
            Money.Upbringingmoney -= 200;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JihyeSkillFiveLevel();
        }

        else if (SkillManager.jihyeskillLevel == 5 && Money.Upbringingmoney >= 250)
        {
            Money.Upbringingmoney -= 250;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JihyeSkillSixLevel();
        }

        else if (SkillManager.jihyeskillLevel == 6 && Money.Upbringingmoney >= 300)
        {
            Money.Upbringingmoney -= 300;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JihyeSkillSevenLevel();
        }
        else
        {
            return;
        }

    }

    //하늘 스킬
    public void HaneulSkill()
    {
        if (SkillManager.haneulskillLevel == 1 && Money.Upbringingmoney >= 145)
        {
            Money.Upbringingmoney -= 145;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.HaneulSkillTwoLevel();
        }

        else if (SkillManager.haneulskillLevel == 2 && Money.Upbringingmoney >= 150)
        {
            Money.Upbringingmoney -= 150;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.HaneulSkillThreeLevel();
        }

        else if (SkillManager.haneulskillLevel == 3 && Money.Upbringingmoney >= 170)
        {
            Money.Upbringingmoney -= 170;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.HaneulSkillFourLevel();
        }

        else if (SkillManager.haneulskillLevel == 4 && Money.Upbringingmoney >= 200)
        {
            Money.Upbringingmoney -= 200;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.HaneulSkillFiveLevel();
        }

        else if (SkillManager.haneulskillLevel == 5 && Money.Upbringingmoney >= 250)
        {
            Money.Upbringingmoney -= 250;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.HaneulSkillSixLevel();
        }

        else if (SkillManager.haneulskillLevel == 6 && Money.Upbringingmoney >= 300)
        {
            Money.Upbringingmoney -= 300;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.HaneulSkillSevenLevel();
        }
        else
        {
            return;
        }

    }


    //지윤 스킬
    public void JiyunSkill()
    {
        if (SkillManager.jiyunskillLevel == 1 && Money.Upbringingmoney >= 145)
        {
            Money.Upbringingmoney -= 145;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JiyunSkillTwoLevel();
        }

        else if (SkillManager.jiyunskillLevel == 2 && Money.Upbringingmoney >= 150)
        {
            Money.Upbringingmoney -= 150;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JiyunSkillThreeLevel();
        }

        else if (SkillManager.jiyunskillLevel == 3 && Money.Upbringingmoney >= 170)
        {
            Money.Upbringingmoney -= 170;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JiyunSkillFourLevel();
        }

        else if (SkillManager.jiyunskillLevel == 4 && Money.Upbringingmoney >= 200)
        {
            Money.Upbringingmoney -= 200;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JiyunSkillFiveLevel();
        }

        else if (SkillManager.jiyunskillLevel == 5 && Money.Upbringingmoney >= 250)
        {
            Money.Upbringingmoney -= 250;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JiyunSkillSixLevel();
        }

        else if (SkillManager.jiyunskillLevel == 6 && Money.Upbringingmoney >= 300)
        {
            Money.Upbringingmoney -= 300;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.JiyunSkillSevenLevel();
        }
        else
        {
            return;
        }

    }

    //세영 스킬
    public void SeyeongSkill()
    {
        if (SkillManager.seyeongskillLevel == 1 && Money.Upbringingmoney >= 145)
        {
            Money.Upbringingmoney -= 145;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SeyeongSkillTwoLevel();
        }

        else if (SkillManager.seyeongskillLevel == 2 && Money.Upbringingmoney >= 150)
        {
            Money.Upbringingmoney -= 150;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SeyeongSkillThreeLevel();
        }

        else if (SkillManager.seyeongskillLevel == 3 && Money.Upbringingmoney >= 170)
        {
            Money.Upbringingmoney -= 170;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SeyeongSkillFourLevel();
        }

        else if (SkillManager.seyeongskillLevel == 4 && Money.Upbringingmoney >= 200)
        {
            Money.Upbringingmoney -= 200;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SeyeongSkillFiveLevel();
        }

        else if (SkillManager.seyeongskillLevel == 5 && Money.Upbringingmoney >= 250)
        {
            Money.Upbringingmoney -= 250;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SeyeongSkillSixLevel();
        }

        else if (SkillManager.seyeongskillLevel == 6 && Money.Upbringingmoney >= 300)
        {
            Money.Upbringingmoney -= 300;
            SoundManager.instance.SFXPlay("SkillUp", levelUpSFX);
            SkillManager.SeyeongSkillSevenLevel();
        }
        else
        {
            return;
        }

    }
}
