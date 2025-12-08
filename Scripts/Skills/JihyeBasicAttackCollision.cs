using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JihyeBasicAttackCollision : AttackCollision
{
    public override void Awake()
    {
        // 지혜 공격 데미지 가져오기
        basicdamage = SkillManager.jihyeAttackDamage;
    }
}
