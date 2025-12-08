using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_SkillUI : SkillUIChanger
{
    public override void Update()
    {
        if (S_CooldownSkills.SeyeongOn == true)
        {
            thisImage.sprite = changeImage;

            if (checkTime == false)
            {
                SoundManager.instance.SFXPlay("SkillUIOnSound", skillOnSFX);
                checkTime = true;
            }
        }
        else if (S_CooldownSkills.SeyeongOn == false)
        {
            checkTime = false;
            thisImage.sprite = currentImage;

        }
    }
}
