using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommBringing : MonoBehaviour
{
    public GameObject UpbringingManager;
    public GameObject HanuelFogEffect;
    public GameObject HanuelPanel;
    public GameObject SominAttackPanel;
    public GameObject SominSkillPanel;

    [Header("어택 및 스킬 패널")]
    public GameObject HaneulAttackPanel;
    public GameObject HaneulSkillPanel;


    public void HaneulAttackPanelEvent()
    {
        HaneulAttackPanel.SetActive(true);
        HaneulSkillPanel.SetActive(false);
        HanuelPanel.SetActive(false);


    }


    public void HaneulSkillPanelEvent()
    {
        HaneulAttackPanel.SetActive(false);
        HaneulSkillPanel.SetActive(true);

    }


    public void OffHaneulPanel()
    {

        HaneulAttackPanel.SetActive(false);
        HaneulSkillPanel.SetActive(false);
        HanuelPanel.SetActive(true);
    }

    public void BackPanel()
    {
        HanuelPanel.SetActive(false);
        UpbringingManager.GetComponent<CameraChange>().HaneulFinishedEvent();
        MovementCharacterController.allowcontroll = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("시작");
            MovementCharacterController.allowcontroll = false;
            HanuelFogEffect.SetActive(true);
            HanuelPanel.SetActive(true);
            UpbringingManager.GetComponent<CameraChange>().HaneulEvent();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("종료");
            HanuelFogEffect.SetActive(false);
            HanuelPanel.SetActive(false);
            SominAttackPanel.SetActive(false);
            SominSkillPanel.SetActive(false);
            UpbringingManager.GetComponent<CameraChange>().HaneulFinishedEvent();
        }
    }


  
}
