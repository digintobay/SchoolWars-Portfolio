using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static bool TutorialStage { get; set; } = false;
    public static bool OneStage { get; set; } = false;
    public static bool TwoStage { get; set; } = false;
    public static bool ThreeStage { get; set; } = false;
    public static bool FourStage { get; set; } = false;
    public static bool FiveStage { get; set; } = false;

    public static bool anoStart = false;

   public void StartDefense()
    {
        if(OneStage==false)
        {
            SceneManager.LoadScene("TutorialStage");
            OneStage = true;
        }
        else if(OneStage ==true && TwoStage==false )
        {
            SceneManager.LoadScene("DefenseStage02");
       
            TwoStage = true;
        }
        else if (TwoStage ==true && ThreeStage==false)
        {
            SceneManager.LoadScene("DefenseStage03");
            ThreeStage = true;
        }
        else if (ThreeStage ==true && FourStage== false)
        {
            SceneManager.LoadScene("DefenseStage04");
            FourStage = true;
        }
        else if (FourStage ==true && FiveStage== false)
        {
            SceneManager.LoadScene("DefenseStage05");
            FiveStage = true;
        }
    }
}
