using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillAttackCollision : MonoBehaviour
{
    public int skilldamage;

    public virtual void Awake()
    {
        // 소민 스킬 공격 데미지 가져오기
        skilldamage = SkillManager.sominSkillDamage;
    }

    private void OnEnable()
    {
        StartCoroutine("AutoDisable");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyHealth>().TakeDamage(skilldamage);

        }
    }

    private IEnumerator AutoDisable()
    {
        yield return new WaitForSeconds(0.1f);

        gameObject.SetActive(false);
    }
}
