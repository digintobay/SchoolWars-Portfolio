using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb2 : MonoBehaviour
{
    private int basicdamage =400;
    public GameObject Effect;
    public GameObject parents;

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            StartCoroutine(HandleCollision(other));
        }
    }

    IEnumerator HandleCollision(Collider other)
    {
  
        Effect.SetActive(true);

        // 1√  ¥Î±‚
        yield return new WaitForSeconds(1f);

        if (other != null && other.GetComponent<EnemyHealth>() != null)
        {
            other.GetComponent<EnemyHealth>().TakeDamage(basicdamage);
        }

        yield return new WaitForSeconds(0.1f);
        Destroy(parents);
    }
}
