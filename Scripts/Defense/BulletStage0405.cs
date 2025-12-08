using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStage0405 : MonoBehaviour
{
    private Transform target;

    private int basicDamage = 450;

    public float speed = 70f;
    public GameObject impactEffect;


    public void Seek(Transform _target)
    {
        target = _target;
    }

    private void Update()
    {

        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);

    }

    void HitTarget()
    {
        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 1.5f);

        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyHealth>().TakeDamage(basicDamage);
            Destroy(gameObject);

        }
    }
}
