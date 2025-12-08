using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_SkillUI : SkillUIChanger
{
    public override void Update()
    {
        if (J_CooldownSkills.jihyeOn == true)
        {
            thisImage.sprite = changeImage;

            if (checkTime == false)
            {
                SoundManager.instance.SFXPlay("SkillUIOnSound", skillOnSFX);
                checkTime = true;
            }
        }
        else if (J_CooldownSkills.jihyeOn == false)
        {
            checkTime = false;
            thisImage.sprite = currentImage;

        }

    }
}
