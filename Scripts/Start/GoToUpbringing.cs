using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToUpbringing : MonoBehaviour
{
    public static bool tutorialCheck = false;
    public GameObject fadeImage;
    public AudioClip clickSFX;

    private void Awake()
    {
        fadeImage.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SoundManager.instance.SFXPlay("ClickSound", clickSFX);
        }

        if (Input.anyKeyDown && !Input.GetMouseButtonDown(0))
        {
            SoundManager.instance.SFXPlay("ClickSound", clickSFX);
            fadeImage.SetActive(true);
      

                
            if (tutorialCheck==true)
            {
                StartCoroutine(YourAnyKeySound());

            }
            else if (tutorialCheck==false)
            {
                StartCoroutine(TutoYourAnyKeySound());
            }
          
        }
    }

    IEnumerator YourAnyKeySound()
    {
        yield return new WaitForSeconds(1F);
        SceneManager.LoadScene("UpBringing");
    }


    IEnumerator TutoYourAnyKeySound()
    {
        yield return new WaitForSeconds(1F);
        SceneManager.LoadScene("Tutorial");
    }
}

