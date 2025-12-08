using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TalkSystem : MonoBehaviour
{

    public GameObject choice0;
    public GameObject choice1;
    public GameObject choice2;

    public void EnterChoice0()
    {
        choice0.SetActive(true);
    }

    public void ExitChoice0()
    {
        choice0.SetActive(false);
    }

    public void EnterChoice1()
    {
        choice1.SetActive(true);
    }

    public void ExitChoice1()
    {
        choice1.SetActive(false);
    }

    public void EnterChoice2()
    {
        choice2.SetActive(true);
    }

    public void ExitChoice2()
    {
        choice2.SetActive(false); 
    }


}
