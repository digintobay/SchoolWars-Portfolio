using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeRangeCheck : MonoBehaviour
{
    
    private List<AttackCheckNode> triggerHandler = new List<AttackCheckNode>();

    public void OnTriggerEnter(Collider other)
    {
        // 다른 오브젝트가 AttackCheckNode를 가지고 있는지 확인
        if (other.TryGetComponent<AttackCheckNode>(out AttackCheckNode foundHandler))
        {
            // 이미 리스트에 있는지 확인하여 중복 추가 방지
            if (!triggerHandler.Contains(foundHandler))
            {
                triggerHandler.Add(foundHandler);
                Debug.Log("triggerHandler가 할당되었습니다: " + foundHandler.name);
            }
        }
        else
        {
            Debug.Log("triggerHandler가 할당되지 않았습니다.");
        }


    }

    void OnDisable()
    {


        foreach (var handler in triggerHandler)
        {
            if (handler != null)
            {
                Debug.Log("OnDisable이 호출되었습니다: " + handler.name);
                handler.HandleAttackRangeExit(GetComponent<Collider>());
            }
        }
        // 이벤트 발생 후 리스트 초기화 
        triggerHandler.Clear();
    }




}
