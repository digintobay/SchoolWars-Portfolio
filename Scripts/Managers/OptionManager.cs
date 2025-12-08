using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionManager : MonoBehaviour
{
    public GameObject optionPanel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            optionPanel.SetActive(!optionPanel.activeSelf);

            if (optionPanel.activeSelf)
            { Time.timeScale = 0; }
            
            if (!optionPanel.activeSelf)
            {
                Time.timeScale = 1;
            }

        }
    }
}
