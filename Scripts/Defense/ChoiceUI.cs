using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChoiceUI : MonoBehaviour
{
    public GameObject UIicon;

    public void IconOn()
    {
        UIicon.SetActive(true);
    }

    public void IconOff()
    {
        UIicon.SetActive(false);
    }


}
