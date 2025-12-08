using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaneulSkillAttackCollision : SkillAttackCollision
{
    public override void Awake()
    {
        // 하늘 스킬 공격 데미지 가져오기
        skilldamage = SkillManager.haneulSkillDamage;
    }
}
