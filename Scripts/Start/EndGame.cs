using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using RichTextSubstringHelper;

public class EndGame : MonoBehaviour
{
    public GameObject fadeImage;
    public AudioClip clickSFX;

    [Multiline]
    [SerializeField]
    public List<string> text;
    [SerializeField]
    public List<string> skip;
    [SerializeField]
    TextMeshProUGUI uiText;

    private void Awake()
    {
        fadeImage.SetActive(false);
    }

    private State state = State.NotInitialized;

    enum State
    {
        NotInitialized,
        Playing,
        PlayingSkipping,
        Completed,
    }

    private void Update()
    {

        if (state == State.Completed)
        {
            StartCoroutine(YourAnyKeySound());
        }

    }

    IEnumerator Start()
    {

        state = State.Playing;
        yield return new WaitForSeconds(1.2f);


        for (int i = 0; i < text.Count; i += 1)
        {
            yield return PlayLine(text[i]);

        }
        state = State.Completed;


    }

    IEnumerator PlayLine(string text)
    {

        for (int i = 0; i < text.RichTextLength() + 1; i += 1)
        {
            yield return new WaitForSeconds(0.05f);
            if (state == State.PlayingSkipping)
            {
                uiText.text = text;
                state = State.Playing;
                break;
            }
            uiText.text = text.RichTextSubString(i);
        }

        yield return new WaitForSeconds(0.5f);

        for (int i = 0; i < 25; i += 1)
        {
            yield return new WaitForSeconds(0.1f);
            if (state == State.PlayingSkipping)
            {
                state = State.Playing;
                break;
            }
        }
    }


    IEnumerator YourAnyKeySound()
    {

        fadeImage.SetActive(true);
        yield return new WaitForSeconds(5F);
        SceneManager.LoadScene("Start");
    }



}
