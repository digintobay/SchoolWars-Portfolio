using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class SkillInput : MonoBehaviour
{
    [SerializeField]
    private GraphicRaycaster graphicRaycaster;
    [SerializeField]
    private CooldownSkills[] cooldownSkills;

    private List<RaycastResult> raycastResults;
    private PointerEventData pointerEventData;

    [SerializeField]
    private bool[] skillcheck;

    private void Awake()
    {
        skillcheck = new bool[5];

        // 모든 값을 false로 초기화 (기본값).
        for (int i = 0; i < skillcheck.Length; i++)
        {
            skillcheck[i] = false;
        }

        raycastResults = new List<RaycastResult>();
        pointerEventData = new PointerEventData(null);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            raycastResults.Clear();

            pointerEventData.position = Input.mousePosition;
            graphicRaycaster.Raycast(pointerEventData, raycastResults);

            if (raycastResults.Count > 0)
            {
                CooldownSkills cool = raycastResults[0].gameObject.GetComponent<CooldownSkills>() as CooldownSkills;
                if (cool != null)
                {
                    cool.StartCooldownTime();
                }
            }

        }

        if (Node.buildsomin == true && skillcheck[0] ==false) // 소민이 설치된 후
        {
            skillcheck[0] = true;
            CooldownSkills cool = cooldownSkills[0];

            if (cool != null)
            {
                cool.FirstCooldownTime();
            }
        }

        if (Node.buildjihye == true && skillcheck[1] == false) // 지혜가 설치된 후
        {
            skillcheck[1] = true;
            CooldownSkills cool = cooldownSkills[1];

            if (cool != null)
            {
                cool.FirstCooldownTime();
            }
        }

        if (Node.buildhaneul == true && skillcheck[2] == false) // 하늘이 설치된 후
        {
            skillcheck[2] = true;
            CooldownSkills cool = cooldownSkills[2];

            if (cool != null)
            {
                cool.FirstCooldownTime();
            }
        }

        if (Node.buildjiyun == true && skillcheck[3] == false) // 지윤이 설치된 후
        {
            skillcheck[3] = true;
            CooldownSkills cool = cooldownSkills[3];

            if (cool != null)
            {
                cool.FirstCooldownTime();
            }
        }

        if (Node.buildseyeong == true && skillcheck[4] == false) // 세영이 설치된 후
        {
            skillcheck[4] = true;
            CooldownSkills cool = cooldownSkills[4];

            if (cool != null)
            {
                cool.FirstCooldownTime();
            }
        }

    }
}
