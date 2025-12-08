using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JiyunCommBringing : MonoBehaviour
{
    public GameObject UpbringingManager;
    public GameObject JiyunFogEffect;
    public GameObject JiyunPanel;


    [Header("어택 및 스킬 패널")]
    public GameObject JiyunAttackPanel;
    public GameObject JiyunSkillPanel;

    public void JiyunAttackPanelEvent()
    {
        JiyunAttackPanel.SetActive(true);
        JiyunSkillPanel.SetActive(false);
        JiyunPanel.SetActive(false);


    }


    public void JiyunSkillPanelEvent()
    {
        JiyunAttackPanel.SetActive(false);
        JiyunSkillPanel.SetActive(true);

    }


    public void OffJiyunPanel()
    {

        JiyunAttackPanel.SetActive(false);
        JiyunSkillPanel.SetActive(false);
        JiyunPanel.SetActive(true);
    }

    public void BackPanel()
    {
        JiyunPanel.SetActive(false);
        UpbringingManager.GetComponent<CameraChange>().JiyunFinishedEvent();
        MovementCharacterController.allowcontroll = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("시작");
            JiyunPanel.SetActive(true);
            JiyunFogEffect.SetActive(true);
            MovementCharacterController.allowcontroll = false;
            UpbringingManager.GetComponent<CameraChange>().JiyunEvent();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("종료");
            JiyunPanel.SetActive(false);
            JiyunFogEffect.SetActive(false);
            UpbringingManager.GetComponent<CameraChange>().JiyunFinishedEvent();
        }
    }


  
}
