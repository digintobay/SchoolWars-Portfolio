using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_CooldownSkills : CooldownSkills
{
    public static bool HaneulOn { get; private set; } = false;

    public override void Awake()
    {
        blackIcon.SetActive(true);
        skillImage.fillAmount = 1;
        HaneulOn = false;

        if (Node.buildhaneul == false)
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

        if (isCooldown == true || Node.buildhaneul == false) //지혜가 설치되어 있지 않을 시 리턴
        {
            return;
        }
        HaneulOn = false;
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
        HaneulOn = true;

        SetCooldownIs(false);
    }

    public override IEnumerator OnCooldownTime(float maxCooldownTime)
    {
        currentCooldownTime = maxCooldownTime;

        SetCooldownIs(true);
        Haneul.haneulSkill = true;
        while (currentCooldownTime > 0)
        {
            currentCooldownTime -= Time.deltaTime;
            skillImage.fillAmount = currentCooldownTime / maxCooldownTime;

            yield return null;
        }
        yield return new WaitUntil(() => currentCooldownTime <= 0);
        HaneulOn = true;

        SetCooldownIs(false);
    }
}
