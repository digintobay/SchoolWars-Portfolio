using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret0405 : MonoBehaviour
{
    private Transform target;

    [Header("Attributes")]

    public float range = 15f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;

    [Header("Unity Setup Fields")]

    public string enemyTag = "Enemy";

    public Transform partToRotate;
    public float turnSpeed = 10f;

    public GameObject bulletPrefab;
    public Transform firePoint;


    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        float shortesDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemey in enemies)
        {
            float distanceToEnemey = Vector3.Distance(transform.position, enemey.transform.position);

            if (distanceToEnemey < shortesDistance)
            {
                shortesDistance = distanceToEnemey;
                nearestEnemy = enemey;
            }

        }

        if (nearestEnemy != null && shortesDistance <= range)
        {

            target = nearestEnemy.transform;

        }
        else
        {
            target = null;
        }



    }

    void Update()
    {

        if (target == null)
        { return; }

        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }

    void Shoot()
    {
        GameObject bulletGo = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        BulletStage0405 bullet = bulletGo.GetComponent<BulletStage0405>();

        if (bullet != null)
        {
            bullet.Seek(target);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }


}
