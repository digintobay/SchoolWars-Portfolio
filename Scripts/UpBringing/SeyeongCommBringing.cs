using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeyeongCommBringing : MonoBehaviour
{
    public GameObject UpbringingManager;
    public GameObject SeyeongFogEffect;
    public GameObject SeyeongPanel;


    [Header("어택 및 스킬 패널")]
    public GameObject SeyeongAttackPanel;
    public GameObject SeyeongSkillPanel;

    public void SeyeongAttackPanelEvent()
    {
        SeyeongAttackPanel.SetActive(true);
        SeyeongSkillPanel.SetActive(false);
        SeyeongPanel.SetActive(false);


    }


    public void SeyeongSkillPanelEvent()
    {
        SeyeongAttackPanel.SetActive(false);
        SeyeongSkillPanel.SetActive(true);

    }


    public void OffSeyeongPanel()
    {

        SeyeongAttackPanel.SetActive(false);
        SeyeongSkillPanel.SetActive(false);
        SeyeongPanel.SetActive(true);
    }

    public void BackPanel()
    {
        SeyeongPanel.SetActive(false);
        UpbringingManager.GetComponent<CameraChange>().SeyeongFinishedEvent();
        MovementCharacterController.allowcontroll = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("시작");
            MovementCharacterController.allowcontroll = false;
            SeyeongPanel.SetActive(true);
            SeyeongFogEffect.SetActive(true);
            UpbringingManager.GetComponent<CameraChange>().SeyeongEvent();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("종료");
            SeyeongPanel.SetActive(false);
            SeyeongFogEffect.SetActive(false);
            UpbringingManager.GetComponent<CameraChange>().SeyeongFinishedEvent();
        }
    }

}

