using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    public Transform target; // 적 위치를 따라다니기 위한 타겟
    public Vector3 offset;   // 체력바와 적 사이의 위치 오프셋
    public Slider healthSlider; // 체력바 슬라이더

  
    void Update()
    {
        // 체력바가 적을 따라다니도록 위치 업데이트
        if (target != null)
        {
            transform.position = target.position + offset;
        }
    }

    public void SetHealth(float currentHealth, float maxHealth)
    {
         healthSlider.value = currentHealth / maxHealth;
        Debug.Log("셋헬스 적용 완료");
    }
}
