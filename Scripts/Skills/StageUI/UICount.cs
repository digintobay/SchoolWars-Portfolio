using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UICount : MonoBehaviour
{
    float count = 5;
    public TextMeshProUGUI countUIText;


    private void OnEnable()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        count-=Time.unscaledDeltaTime;
        countUIText.text = Mathf.Round(count).ToString();
    }

  
}
