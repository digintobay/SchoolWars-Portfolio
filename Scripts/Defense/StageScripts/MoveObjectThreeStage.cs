using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectThreeStage : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        // 3-1 정비 시간 때 열림
        if (ThreeStageWaveSpawner.ThreeStageOpen == true)
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, target.transform.position, 0.01f);
        }
    }
}
