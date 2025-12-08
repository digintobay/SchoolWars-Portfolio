using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JiyunBasicAttackCollision : AttackCollision
{

    public override void Awake()
    {
        // 지윤 공격 데미지 가져오기
        basicdamage = SkillManager.jiyunAttackDamage;
    }

   
}
