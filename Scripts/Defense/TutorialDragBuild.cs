using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialDragBuild : MonoBehaviour
{
    private Vector3 dragStartPos;
    private Vector3 dragEndPos;
    private bool isDragging = false;
    private bool isSelected = false;

    public GameObject possibleAttackRangeCollider;
    public bool canRotate { get; set; } = false; // 회전용 변수
    public bool fiveVercanRotate { get; set; } = false;


    void Start()
    {
        // 스크립트가 켜진 후 5초 동안만 회전 가능
        StartCoroutine(EnableRotationForLimitedTime(5.0f));



    }


    void Update()
    {
        // 마우스 클릭 시작
        if (Input.GetMouseButtonDown(0) && OneStageWaveSpawner.dragnow) //정비 시간이 아닐 때만
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Raycast로 마우스 클릭된 오브젝트가 있는지 확인
            if (Physics.Raycast(ray, out hit))
            {
                // 클릭된 오브젝트가 현재 프리팹일 경우만 동작
                if (hit.transform == transform)
                {
                    isSelected = true;
                    dragStartPos = Input.mousePosition;
                    isDragging = true;
                }
            }
        }

        // 마우스 클릭 끝
        if (Input.GetMouseButtonUp(0) && isDragging && isSelected)
        {
            dragEndPos = Input.mousePosition;
            RotateCharacter();  // 현재 선택된 프리팹만 회전
            isDragging = false;
            isSelected = false; // 드래그가 끝나면 선택 해제
        }

        // 드래그 가능 시간에는 회전 가능
        if (OneStageWaveSpawner.startTimedragnow)
        {
            canRotate = true;
            possibleAttackRangeCollider.SetActive(true);
        }
        else if (OneStageWaveSpawner.startTimedragnow == false)
        {
            canRotate = false;
            possibleAttackRangeCollider.SetActive(false);
        }



    }



    IEnumerator EnableRotationForLimitedTime(float duration)
    {
        fiveVercanRotate = true;  // 회전 가능하게 설정
        possibleAttackRangeCollider.SetActive(true);
        yield return new WaitForSeconds(duration);  // 5초 대기
        fiveVercanRotate = false; // 5초 후 회전 불가능하게 설정
        possibleAttackRangeCollider.SetActive(false);
    }


    // RotateCharacter 함수: 5초 제한에 따라 실행 여부 결정

    void RotateCharacter()
    {
        if (!canRotate && !fiveVercanRotate) return;

        Vector3 dragVector = dragEndPos - dragStartPos;

        if (OneStageWaveSpawner.dragnow == true)
        {
            if (Mathf.Abs(dragVector.x) > Mathf.Abs(dragVector.y))
            {
                // 좌우 드래그
                if (dragVector.x > 0)
                {
                    // 오른쪽으로 드래그
                    transform.Rotate(0, -90, 0);
                }
                else
                {
                    // 왼쪽으로 드래그
                    transform.Rotate(0, 90, 0);
                }
            }
        }
    }

}