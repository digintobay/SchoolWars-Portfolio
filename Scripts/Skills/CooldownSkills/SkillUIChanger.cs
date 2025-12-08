using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillUIChanger : MonoBehaviour
{
    [Header("변경 ui 이미지")]
    public Sprite changeImage;
    public Image thisImage;
    public Sprite currentImage;

    private Sprite saveTemp;
    public bool checkTime = false;
    public AudioClip skillOnSFX;

    private void Awake()
    {
        saveTemp = thisImage.sprite;
        thisImage.sprite = saveTemp; 

        thisImage =GetComponent<Image>();
       
        currentImage = thisImage.sprite;
     
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if(CooldownSkills.Somin0n==true)
        {
            thisImage.sprite = changeImage;

            if (checkTime==false)
            {
                SoundManager.instance.SFXPlay("SkillUIOnSound", skillOnSFX);
                checkTime = true;
            }
        }
        else if (CooldownSkills.Somin0n == false)
        {
            checkTime = false;
            thisImage.sprite = currentImage;

        }


    }

    
}
