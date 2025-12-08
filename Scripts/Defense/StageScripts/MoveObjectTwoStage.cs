using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoveObjectTwoStage : MonoBehaviour
{

   public Transform target;

    private void Update()
    {
        // 2-2 정비 시간 때 열림
        if (TwoStageWaveSpawner.TwoStageOpen==true) 
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, target.transform.position, 0.01f);
        }
    }
}
