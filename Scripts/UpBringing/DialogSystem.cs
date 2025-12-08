using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;
using RichTextSubstringHelper;
using UnityEngine.SceneManagement;


public class DialogSystem : MonoBehaviour
{
  
    [Multiline]
    [Header("기본 대사")]
    [SerializeField]
    public List<string> text;

    [Header("대화하기 시 출력 대사")]
    [SerializeField]
    public List<string> talkRandom;

    [SerializeField]
    TextMeshProUGUI uiText;

    private int talkTime = 0;

    private State state = State.NotInitialized;

    enum State
    {
        NotInitialized,
        Playing,
        Completed,
    }

    public void OnEnable()
    {
        uiText.text = " ";
        StartCoroutine(BaseTalk());
    }



    IEnumerator BaseTalk()
    {
        
        state = State.Playing;
  

        for (int i = 0; i < text.Count; i += 1)
        {
            yield return PlayLine(text[i]);
          
        }
        state = State.Completed;

     
    }

    public void ClickTalk()
    {
        if(talkTime==0)
        {
            talkTime = 1;
            StartCoroutine(Talk());
            
        }
        
     

    }

  
    IEnumerator Talk()
    {
        state = State.Playing;
      

        for (int i = 0; i < 1; i += 1) // 한 번만 실행
        {
            int random = Random.Range (0, talkRandom.Count); //토크 랜덤 개수만큼 랜덤한 변수 생성

            if (random == 0)
            {
                yield return PlayLine(talkRandom[0]);

            }
            else if (random == 1)
            {
                yield return PlayLine(talkRandom[1]);
            }
            else if (random == 2)
            {
                yield return PlayLine(talkRandom[2]);
            }
            else if (random == 3)
            {
                yield return PlayLine(talkRandom[3]);
            }
            else if (random == 4)
            {
                yield return PlayLine(talkRandom[4]);
            }

        
        }
        state = State.Completed;

    }

    IEnumerator PlayLine(string text)
    {
       
        for (int i = 0; i < text.RichTextLength() + 1; i += 1)
        {
            yield return new WaitForSeconds(0.05f);
         
            uiText.text = text.RichTextSubString(i);
        }

        talkTime = 0;

        yield return new WaitForSeconds(0.5f);

        for (int i = 0; i < 25; i += 1)
        {
            yield return new WaitForSeconds(0.1f);
         
        }
    }

    public IEnumerator WaitForComplete()
    {
        while (state != State.Completed)
        {
            yield return null;
        }
    }

}
