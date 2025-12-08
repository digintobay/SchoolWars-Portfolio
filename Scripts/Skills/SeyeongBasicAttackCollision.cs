using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeyeongBasicAttackCollision : AttackCollision
{
    public override void Awake()
    {
        // 세영 공격 데미지 가져오기
        basicdamage = SkillManager.seyeongAttackDamage;
    }
}
