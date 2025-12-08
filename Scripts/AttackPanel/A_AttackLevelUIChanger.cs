using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class A_AttackLevelUIChanger : MonoBehaviour
{

    private List<Image> childImages = new List<Image>();
    private Color upcolor = Color.white;

    public void Awake()
    {
        GetChildImages();
    }

    public void Update()
    {



        if (SkillManager.seyeongattackLevel == 2)
        {
            childImages[0].color = upcolor;

        }

        if (SkillManager.seyeongattackLevel == 3)
        {
            childImages[0].color = upcolor;
            childImages[1].color = upcolor;

        }

        if (SkillManager.seyeongattackLevel == 4)
        {
            childImages[0].color = upcolor;
            childImages[1].color = upcolor;
            childImages[2].color = upcolor;

        }

        if (SkillManager.seyeongattackLevel == 5)
        {
            childImages[0].color = upcolor;
            childImages[1].color = upcolor;
            childImages[2].color = upcolor;
            childImages[3].color = upcolor;

        }

        if (SkillManager.seyeongattackLevel == 6)
        {
            childImages[0].color = upcolor;
            childImages[1].color = upcolor;
            childImages[2].color = upcolor;
            childImages[3].color = upcolor;
            childImages[4].color = upcolor;

        }

        if (SkillManager.seyeongattackLevel == 7)
        {
            childImages[0].color = upcolor;
            childImages[1].color = upcolor;
            childImages[2].color = upcolor;
            childImages[3].color = upcolor;
            childImages[4].color = upcolor;
            childImages[5].color = upcolor;

        }

    }


    public void GetChildImages()
    {
       
        int childCount = transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            
            Transform child = transform.GetChild(i);

            
            Image imageComponent = child.GetComponent<Image>();

            if (imageComponent != null)
            {
                Debug.Log("Image component found in child at index " + i);

                
                childImages.Add(imageComponent);
            }
            else
            {
                Debug.Log("No Image component found in child at index " + i);
            }
        }
    }
}
