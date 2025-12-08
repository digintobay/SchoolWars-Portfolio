using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class J_CooldownSkills : CooldownSkills
{
    public static bool jihyeOn { get; private set; } =false;

    public override void Awake()
    {
        blackIcon.SetActive(true);
        skillImage.fillAmount = 1;
        jihyeOn = false;

        if (Node.buildjihye == false)
        {
            isCooldown = false;
            return;
        }
        else
        {
            SetCooldownIs(false);
        }

    }

  
    public override void StartCooldownTime()
    {

        if (isCooldown == true || Node.buildjihye == false) //지혜가 설치되어 있지 않을 시 리턴
        {
            return;
        }
        jihyeOn = false;
        StartCoroutine("OnCooldownTime", maxCooldownTime);
    }

    public override IEnumerator FirstSkillCool(float maxCooldownTime)
    {
        currentCooldownTime = maxCooldownTime;

        SetCooldownIs(true);

        while (currentCooldownTime > 0)
        {
            currentCooldownTime -= Time.deltaTime;
            skillImage.fillAmount = currentCooldownTime / maxCooldownTime;

            yield return null;
        }
        yield return new WaitUntil(() => currentCooldownTime <= 0);
        jihyeOn = true;

        SetCooldownIs(false);
    }

    public override IEnumerator OnCooldownTime(float maxCooldownTime)
    {
        currentCooldownTime = maxCooldownTime;

        SetCooldownIs(true);
        Jihye.jihyeSkill = true;
        while (currentCooldownTime > 0)
        {
            currentCooldownTime -= Time.deltaTime;
            skillImage.fillAmount = currentCooldownTime / maxCooldownTime;

            yield return null;
        }
        yield return new WaitUntil(() => currentCooldownTime <= 0);
        jihyeOn = true;

        SetCooldownIs(false);
    }

   
    
}
