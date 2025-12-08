using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LookAtPlayer : MonoBehaviour
{
    // 플레이어의 Transform을 참조합니다.
    public Transform player;

    Vector3 currentEulerAngles;


    private void Awake()
    {
        currentEulerAngles = transform.eulerAngles;
    }

    void Update()
    {
        if (MovementCharacterController.allowcontroll && player != null)
        {

            // 플레이어 방향을 계산
            Vector3 direction = player.position - transform.position;
            direction.y = 0; // Y축 회전을 제한 (필요에 따라 다른 축 제한 가능)

            // 회전 설정
            transform.rotation = Quaternion.LookRotation(direction);
        }
        else if (!MovementCharacterController.allowcontroll)
        {
            transform.eulerAngles = currentEulerAngles;
        }

    }
}
