using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_SkillUI : SkillUIChanger
{
    public override void Update()
    {
        if (H_CooldownSkills.HaneulOn == true)
        {
            thisImage.sprite = changeImage;

            if (checkTime == false)
            {
                SoundManager.instance.SFXPlay("SkillUIOnSound", skillOnSFX);
                checkTime = true;
            }
        }
        else if (H_CooldownSkills.HaneulOn == false)
        {
            checkTime = false;
            thisImage.sprite = currentImage;

        }

    }
}
