using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeyeongSkillAttackCollision : SkillAttackCollision
{
    public override void Awake()
    {
        // 세영 스킬 공격 데미지 가져오기
        skilldamage = SkillManager.seyeongSkillDamage;
    }
}
