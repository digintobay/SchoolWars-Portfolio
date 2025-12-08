using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyCheckCollider : MonoBehaviour
{

    public bool ColliderCheck;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            ColliderCheck = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            Debug.Log("적 종료");
            ColliderCheck = false;
        }
    }

    // 적이 파괴될 때 호출할 메서드 추가
    public void HandleEnemyExit(Collider enemy)
    {
        if (enemy.CompareTag("Enemy"))
        {
            Debug.Log("적 종료 (Destroy에 의해)");
            ColliderCheck = false;
        }
    }

}
