using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AttackCheckNode : MonoBehaviour
{

    public Color hoverColor;
    private Color startColor;
    public Vector3 positionOffset;

    private GameObject turret;



    private Renderer rend;

    private float normalAlpha = 0.0f;
    private float hoverAlpha = 1.0f;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }




    private void OnTriggerStay(Collider other)
    {
        

        //학생회장의 공격 콜라이더에 닿을 경우
        if (other.CompareTag("SominAttackCollider"))
        {
            rend.material.color = hoverColor;
            ChangeAlpha(hoverAlpha);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //학생회장의 공격 콜라이더가 꺼질 경우
        if (other.CompareTag("SominAttackCollider"))
        {
            rend.material.color = startColor;
            ChangeAlpha(normalAlpha);
        }

    }



    // 공격 콜라이더가 꺼질 경우를 체크하는 이벤트 핸들러
    public void HandleAttackRangeExit(Collider other)
    {
        if (other.CompareTag("SominAttackCollider"))
        {
            Debug.Log("꺼집니더");
            rend.material.color = startColor;
            ChangeAlpha(normalAlpha);
        }
    }


    void ChangeAlpha(float alpha)
    {
        Color color = rend.material.color;
        color.a = alpha;
        rend.material.color = color;
    }
}
