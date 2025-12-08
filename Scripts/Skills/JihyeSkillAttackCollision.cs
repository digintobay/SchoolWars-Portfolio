using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JihyeSkillAttackCollision : SkillAttackCollision
{
    public override void Awake()
    {
        // 지혜 스킬 공격 데미지 가져오기
        skilldamage = SkillManager.jihyeSkillDamage;
    }
}
