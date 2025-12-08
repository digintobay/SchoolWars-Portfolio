using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SominCommBringing : MonoBehaviour
{
    public GameObject UpbringingManager;

    public GameObject SominPanel;
    public GameObject SominSkillPanel;
    public GameObject HaneulPanel;


    public void SominEventStart()
    {
        HaneulPanel.SetActive(false);
        SominPanel.SetActive(true);
        UpbringingManager.GetComponent<CameraChange>().SominEvent();
    }


   public void SominEventFinished()
    {
        SominSkillPanel.SetActive(false);
        SominPanel.SetActive(false);
        UpbringingManager.GetComponent<CameraChange>().SominFinishedEvent();
        MovementCharacterController.allowcontroll = true;

    }

    public void SominBasicAttackPanel()
    {
        SominPanel.SetActive(true);
        SominSkillPanel.SetActive(false) ;
    }

    public void SominSkillPanelOn()
    {
        SominSkillPanel.SetActive(true);
        SominPanel.SetActive(false);
    }

    public void OffSominPanel()
    {
     
        SominPanel.SetActive(false);
    }

}
