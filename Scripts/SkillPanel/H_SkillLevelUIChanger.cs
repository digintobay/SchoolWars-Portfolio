using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_SkillLevelUIChanger : MonoBehaviour
{
    private List<Image> childImages = new List<Image>();
    private Color upcolor = Color.white;

    public void Awake()
    {
        GetChildImages();
    }

    public void Update()
    {



        if (SkillManager.haneulskillLevel == 2)
        {
            childImages[0].color = upcolor;

        }

        if (SkillManager.haneulskillLevel == 3)
        {
            childImages[0].color = upcolor;
            childImages[1].color = upcolor;

        }

        if (SkillManager.haneulskillLevel == 4)
        {
            childImages[0].color = upcolor;
            childImages[1].color = upcolor;
            childImages[2].color = upcolor;

        }

        if (SkillManager.haneulskillLevel == 5)
        {
            childImages[0].color = upcolor;
            childImages[1].color = upcolor;
            childImages[2].color = upcolor;
            childImages[3].color = upcolor;

        }

        if (SkillManager.haneulskillLevel == 6)
        {
            childImages[0].color = upcolor;
            childImages[1].color = upcolor;
            childImages[2].color = upcolor;
            childImages[3].color = upcolor;
            childImages[4].color = upcolor;

        }

        if (SkillManager.haneulskillLevel == 7)
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
        // 자식 오브젝트의 수를 가져옵니다.
        int childCount = transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            // 인덱스에 해당하는 자식 오브젝트를 가져옵니다.
            Transform child = transform.GetChild(i);

            // 자식 오브젝트에서 Image 컴포넌트를 찾습니다.
            Image imageComponent = child.GetComponent<Image>();

            if (imageComponent != null)
            {
                Debug.Log("Image component found in child at index " + i);

                // 리스트에 Image 컴포넌트를 저장합니다.
                childImages.Add(imageComponent);
            }
            else
            {
                Debug.Log("No Image component found in child at index " + i);
            }
        }
    }
}
