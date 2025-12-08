using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2_Stage5Enemy : EnemyHealth
{
    public override void Update()
    {
        base.Update();

        if (enemyHealth <= 0)
        {
          
            OneStageWaveSpawner.totalEnemyCount--;
        }
    }

    public override void CountHealth()
    {
        enemyHealth = 1140;
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
