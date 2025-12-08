using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillUITime : MonoBehaviour
{
    public float skillTime;

    private void OnEnable()
    {
        StartCoroutine("AutoDisable");
    }

    private IEnumerator AutoDisable()
    {
        Time.timeScale = 0;

        yield return new WaitForSecondsRealtime(skillTime);

        Time.timeScale = 1;

        Destroy(gameObject);
    }
}
