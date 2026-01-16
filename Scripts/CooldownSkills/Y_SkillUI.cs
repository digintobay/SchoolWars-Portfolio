using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y_SkillUI : SkillUIChanger
{
    public override void Update()
    {

        if (Y_CooldownSkills.JiyunOn == true)
        {
            thisImage.sprite = changeImage;

            if (checkTime == false)
            {
                SoundManager.instance.SFXPlay("SkillUIOnSound", skillOnSFX);
                checkTime = true;
            }
        }
        else if (Y_CooldownSkills.JiyunOn == false)
        {
            checkTime = false;
            thisImage.sprite = currentImage;

        }

    }
}
