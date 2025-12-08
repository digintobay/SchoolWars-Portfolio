using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public static Money Instance = null;


    //public static int money =5;
    public static int money = 5;
    public static int Upbringingmoney =99999; // 시작 자금 기획에게 문의


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            Destroy(gameObject);
        }

       /* money = 5;
        //임시
        money += 3000;
        Upbringingmoney = 17000;*/
    }

}
