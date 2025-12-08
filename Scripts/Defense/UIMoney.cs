using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMoney : MonoBehaviour
{
    TextMeshProUGUI moneyText;

    public void Awake()
    {
        moneyText = GetComponent<TextMeshProUGUI>();
    }

    public void Update()
    {
        moneyText.text = Money.money.ToString();
    }
}
