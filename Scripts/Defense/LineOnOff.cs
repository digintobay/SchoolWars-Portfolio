using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOnOff : MonoBehaviour
{
     private Material[] materials;
        private float fadeDuration = 1f; // 페이드 인/아웃에 걸리는 시간

        private void Start()
        {
            // 모든 자식 오브젝트의 메터리얼 배열 가져오기
            Renderer[] renderers = GetComponentsInChildren<Renderer>();
            materials = new Material[renderers.Length];

            for (int i = 0; i < renderers.Length; i++)
            {
                // 각 렌더러의 메터리얼 참조 가져오기
                materials[i] = renderers[i].material;
            }

            // 초기 알파값 설정 (완전히 투명)
            SetAlpha(0f);

            // 코루틴 시작
            StartCoroutine(FadeInOut());
        }

        private IEnumerator FadeInOut()
        {
            // 1초 동안 페이드 인
            yield return StartCoroutine(Fade(0f, 1f, fadeDuration));

            // 1초 대기
            yield return new WaitForSeconds(1f);

            // 1초 동안 페이드 아웃
            yield return StartCoroutine(Fade(1f, 0f, fadeDuration));
        }

        private IEnumerator Fade(float startAlpha, float endAlpha, float duration)
        {
            float elapsed = 0f;
            while (elapsed < duration)
            {
                elapsed += Time.deltaTime;
                float alpha = Mathf.Lerp(startAlpha, endAlpha, elapsed / duration);
                SetAlpha(alpha);
                yield return null; // 다음 프레임까지 대기
            }
            SetAlpha(endAlpha); // 마지막 알파값 보정
        }

        private void SetAlpha(float alpha)
        {
            foreach (Material mat in materials)
            {
                if (mat != null)
                {
                    // 메인 컬러를 가져와 알파값 수정 후 다시 설정
                    Color color = mat.color;
                    color.a = alpha;
                    mat.SetColor("_Color", color); // 알파값 적용
                }
            }
        }
    }
