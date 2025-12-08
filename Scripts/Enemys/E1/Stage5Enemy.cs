using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage5Enemy : EnemyHealth
{
    public override void Update()
    {
        base.Update();

        if (enemyHealth <= 0)
        {
            Debug.Log("제거 카운트 ++");
            OneStageWaveSpawner.totalEnemyCount--;
        }
    }

    public override void CountHealth()
    {
        enemyHealth = 850;
    }

    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        if (other.CompareTag("Finish"))
        {
     
            OneStageWaveSpawner.gameOverCount--;
            OneStageWaveSpawner.totalEnemyCount--;
            Destroy(gameObject);
        }
    }
}
