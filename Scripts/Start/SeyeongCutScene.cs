using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using RichTextSubstringHelper;

public class SeyeongCutScene : MonoBehaviour
{
    [Multiline]
    [SerializeField]
    public List<string> text;
    [SerializeField]
    public List<string> skip;
    [SerializeField]
    TextMeshProUGUI uiText;

    public GameObject dskip;

    public GameObject fadeImage;
    public AudioClip clickSFX;


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
        if ((Input.GetMouseButtonDown(0)))
        {
            SoundManager.instance.SFXPlay("ClickSound", clickSFX);
            Skip();
        }

        if (state == State.Completed)
        {
            StartCoroutine(ChangePart());
        }

    }

    void Awake()
    {
        Invoke("Dskip", 3f);
    }

    void Dskip()
    {
        dskip.SetActive(true);
    }

    IEnumerator ChangePart()
    {
        dskip.SetActive(false);
        fadeImage.SetActive(true);
        yield return new WaitForSeconds(4F);
        SceneManager.LoadScene("TutorialBringing");
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
            yield return new WaitForSeconds(0.1f);
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

    public void Skip()
    {
        state = State.PlayingSkipping;
    }

    public IEnumerator WaitForComplete()
    {
        while (state != State.Completed)
        {
            yield return null;
        }
    }
}
