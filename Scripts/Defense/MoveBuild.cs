using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBuild : MonoBehaviour
{
    private bool isMoving = false; // 이동용 변수
    private Camera mainCamera;
    private GameObject targetObject;  // 드래그한 오브젝트를 놓을 대상 오브젝트
    private Vector3 offset;

    private Vector3 basePosition;

    public LayerMask targetLayerMask; //레이어마스크
    private LayerMask otherLayerMask;

    public GameObject possibleAttackRangeCollider2; // 공격 범위 감지
    private OneStageWaveSpawner oneStage;
    
    private void Awake()
    {
        oneStage = GameObject.Find("GameMaster").GetComponent<OneStageWaveSpawner>();
    }

    void Start()
    {
        //기존 위치 가져오기
        basePosition = transform.position;

        targetLayerMask = LayerMask.GetMask("Node"); // 노드 레이어만 감지
        mainCamera = Camera.main;
    }



    void Update()
    {
        if (oneStage.fixTime == false)
        { possibleAttackRangeCollider2.SetActive(false); }


        else if (oneStage.fixTime == true)
        { possibleAttackRangeCollider2.SetActive(true); }
      
        
       
       

        if (Input.GetMouseButtonDown(0) && !OneStageWaveSpawner.dragnow) //정비 시간일 때만
        {   
          
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // 클릭된 오브젝트가 현재 무빙 오브젝트일 경우
                if (hit.transform == transform)
                {
                    isMoving = true;
                    offset = transform.position - hit.point; // 오브젝트와 마우스 위치 간 오프셋 계산
                }
            }
        }
        
        // 마우스 클릭 끝날 때 드래그 중지
        if (Input.GetMouseButtonUp(0) && isMoving)
        {
            isMoving = false;

            // 대상 오브젝트 위쪽 중앙에 오브젝트 놓기
            if (FindTargetObjectUnderMouse())
            {
                PlaceObjectOnTarget();
                // 이동 성공 후 포지션을 베이스 포지션에 저장
                basePosition = transform.position;
            }
            else if (!FindTargetObjectUnderMouse()) // 노드에 올리지 않았을 시 기존 위치로 재이동
            {
                MoveBaseTransfom();
            }
        }

        // 드래그 중이면 마우스 위치로 오브젝트 이동
        if (isMoving)
        {
            MoveObjectToMouse();
        }
    }

    // 마우스 위치로 오브젝트 이동
    void MoveObjectToMouse()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, transform.position); // 오브젝트가 위치할 평면 (Y축 기준)

        float distance;

        if (plane.Raycast(ray, out distance))
        {   
            // 월드 좌표로 변환한 마우스 위치로 오브젝트 이동
            Vector3 worldPosition = ray.GetPoint(distance);
            transform.position = worldPosition + offset;

    
        }
    }

    // 설치 불가 시 기존 위치로 오브젝트 이동
    void MoveBaseTransfom()
    {
        transform.position = basePosition;
    }

    // 특정 레이어의 오브젝트 위쪽 중앙에 오브젝트 놓기
    void PlaceObjectOnTarget()
    {
        // 대상 오브젝트의 Collider를 사용해 크기와 중앙 위치 계산
        Collider targetCollider = targetObject.GetComponent<Collider>();

        if (targetCollider != null)
        {
            // 대상 오브젝트의 중앙 위치
            Vector3 targetCenter = targetCollider.bounds.center;

            // 대상 오브젝트의 위쪽 면 (Y축 상단)
            float targetTop = targetCollider.bounds.max.y;

            // 이동할 위치 계산: 대상의 중앙 위쪽에 놓기
            Vector3 newPosition = new Vector3(targetCenter.x, targetTop, targetCenter.z);

            // 드래그한 오브젝트를 그 위치로 이동
            transform.position = newPosition;
        }
    }

    // 마우스 아래에 있는 대상 레이어의 오브젝트 찾기
    bool FindTargetObjectUnderMouse()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
  

        // 레이어 마스크를 사용해 특정 레이어에 속한 오브젝트만 감지
        if (!Physics.Raycast(ray, out hit, Mathf.Infinity, targetLayerMask))
        {
            return false; // 타겟이 없으면 false 반환
        }
        else if (Physics.Raycast(ray, out hit, Mathf.Infinity, targetLayerMask))
        {
            targetObject = hit.collider.gameObject;
            return true;

        }
       

        return false; // 타겟이 없으면 false 반환
    }
}
