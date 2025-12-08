using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BringingMoneyText : MonoBehaviour
{
    TextMeshProUGUI bringingmoneyText;

    private void Awake()
    {
        bringingmoneyText=GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        bringingmoneyText.text = Money.Upbringingmoney.ToString();
    }
   
}
