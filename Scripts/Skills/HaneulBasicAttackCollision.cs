using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaneulBasicAttackCollision : AttackCollision
{
    public override void Awake()
    {
        // 하늘 공격 데미지 가져오기
        basicdamage = SkillManager.haneulAttackDamage;
    }
}
