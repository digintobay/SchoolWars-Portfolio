using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectFourStage : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        // 3-1 정비 시간 때 열림
        if (FourStageWaveSpawner.FourStageOpen == true)
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, target.transform.position, 0.01f);
        }
    }
}
