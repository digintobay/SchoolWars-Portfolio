using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CooldownSkills : CooldownSkills
{
    public static bool SeyeongOn { get; private set; } = false;

    public override void Awake()
    {
        blackIcon.SetActive(true);
        skillImage.fillAmount = 1;
        SeyeongOn =false;

        if (Node.buildseyeong == false)
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

        if (isCooldown == true || Node.buildseyeong == false) //지윤이 설치되어 있지 않을 시 리턴
        {
            return;
        }
        SeyeongOn = false;
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
        SeyeongOn = true;

        SetCooldownIs(false);
    }


    public override IEnumerator OnCooldownTime(float maxCooldownTime)
    {
        currentCooldownTime = maxCooldownTime;

        SetCooldownIs(true);
        Seyeong.seyeongSkill = true;
        while (currentCooldownTime > 0)
        {
            currentCooldownTime -= Time.deltaTime;
            skillImage.fillAmount = currentCooldownTime / maxCooldownTime;

            yield return null;
        }
        yield return new WaitUntil(() => currentCooldownTime <= 0);
        SeyeongOn = true;

        SetCooldownIs(false);
    }
}
