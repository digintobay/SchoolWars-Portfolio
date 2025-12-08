using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllSky : MonoBehaviour
{
    private void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time*3f);
    }
}
