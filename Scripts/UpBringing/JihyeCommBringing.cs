using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JihyeCommBringing : MonoBehaviour
{
    public GameObject UpbringingManager;
    public GameObject JihyeFogEffect;
    public GameObject JihyePanel;

    [Header("어택 및 스킬 패널")]
    public GameObject JihyeAttackPanel;
    public GameObject JihyeSkillPanel;

    public void JihyeAttackPanelEvent()
    {
        JihyeAttackPanel.SetActive(true);
        JihyeSkillPanel.SetActive(false);
        JihyePanel.SetActive(false);


    }


    public void JihyeSkillPanelEvent()
    {
        JihyeAttackPanel.SetActive(false);
        JihyeSkillPanel.SetActive(true);

    }


    public void OffJihyePanel()
    {

        JihyeAttackPanel.SetActive(false);
        JihyeSkillPanel.SetActive(false);
        JihyePanel.SetActive(true);
    }

    public void BackPanel()
    {
        JihyePanel.SetActive(false);
        UpbringingManager.GetComponent<CameraChange>().JihyeFinishedEvent();
        MovementCharacterController.allowcontroll = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            MovementCharacterController.allowcontroll = false;
            Debug.Log("시작");
            JihyePanel.SetActive(true);
            JihyeFogEffect.SetActive(true);
            UpbringingManager.GetComponent<CameraChange>().JihyeEvent();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("종료");
            JihyePanel.SetActive(false);
            JihyeFogEffect.SetActive(false);
            UpbringingManager.GetComponent<CameraChange>().JihyeFinishedEvent();
        }
    }

}
