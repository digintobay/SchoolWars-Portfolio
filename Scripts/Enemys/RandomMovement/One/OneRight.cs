using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneRight : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        // Transform 컴포넌트를 가져옴
        Transform otherTransform = other.GetComponent<Transform>();

        if (otherTransform != null && other.CompareTag("RandomOne"))
        {
            //현재 회전에 추가로 -90도 회전
            StartCoroutine(SmoothRotate(otherTransform, Quaternion.Euler(0, 90, 0), 1f));
        }
    }

    // 코루틴으로 부드럽게 회전
    private IEnumerator SmoothRotate(Transform target, Quaternion targetRotation, float duration)
    {
        Quaternion initialRotation = target.rotation; // 시작 회전 값
        float elapsed = 0f;

        while (elapsed < duration)
        {
            // 경과 시간 비율 계산
            elapsed += Time.deltaTime;
            float t = elapsed / duration;

            // 선형 보간으로 회전값을 계산 (천천히 회전)
            target.rotation = Quaternion.Lerp(initialRotation, targetRotation, t);

            yield return null; // 다음 프레임까지 대기
        }

        // 최종 회전값 설정
        target.rotation = targetRotation;
    }
}
