using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectCollision : MonoBehaviour
{
    public float effectTime;

    private void OnEnable()
    {
        StartCoroutine("AutoDisable");
    }

    private IEnumerator AutoDisable()
    {
        yield return new WaitForSeconds(effectTime);

        gameObject.SetActive(false);
    }
}
