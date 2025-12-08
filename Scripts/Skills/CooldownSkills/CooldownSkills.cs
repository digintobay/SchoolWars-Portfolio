using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CooldownSkills : MonoBehaviour
{
    public GameObject blackIcon;

    [SerializeField]
    public Image skillImage;
    [SerializeField]
    public float maxCooldownTime;
    [SerializeField]
    public int coolSkillNumber;

    public float currentCooldownTime;
    public bool isCooldown;

    public static bool Somin0n { get; private set; } = false;

    public virtual void Awake()
    {
        blackIcon.SetActive(true);
        skillImage.fillAmount = 1;

         Somin0n = false;

        if (Node.buildsomin==false)
        {
            isCooldown = false;
            return;
        }
        else
        {
            SetCooldownIs(false);
        }
     
    }

  
    public virtual void StartCooldownTime()
    {
        

        if (isCooldown == true || Node.buildsomin==false) //소민이 설치되어 있지 않을 시 리턴
        {
            return;
        }

        Somin0n = false;
        StartCoroutine("OnCooldownTime", maxCooldownTime);
    }
    

    public void FirstCooldownTime()
    {
        StartCoroutine("FirstSkillCool", maxCooldownTime);
    }

    public virtual IEnumerator FirstSkillCool(float maxCooldownTime)
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
        Somin0n = true;

        SetCooldownIs(false);
    }


    public virtual IEnumerator OnCooldownTime(float maxCooldownTime)
    {
        currentCooldownTime = maxCooldownTime;

        SetCooldownIs(true);
        Somin.sominSkill = true;
        while (currentCooldownTime >0)
        {
            currentCooldownTime -= Time.deltaTime;
            skillImage.fillAmount = currentCooldownTime/maxCooldownTime;

            yield return null;
        }
        yield return new WaitUntil(() => currentCooldownTime <= 0);
        Somin0n = true;

        SetCooldownIs(false);
    }

    public void SetCooldownIs(bool boolean)
    {
        isCooldown = boolean;
        skillImage.enabled = boolean;

    }


}
