using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeBuild : MonoBehaviour
{
  
    public static bool Kimsomin { get; set; }
    public static bool Parkjihye { get; set; }
    public static bool LeeHaneul { get; set; }
    public static bool Hanjiyun { get; set; }
    public static bool Anseyeong { get; set; }


    public static bool Turret { get; set; }
    public static bool Bomb { get; set; }

    public void Awake()
    {
        Kimsomin = false;
        Parkjihye = false;
        LeeHaneul = false;
        Hanjiyun = false;
        Anseyeong = false;
        Turret = false;
        Bomb = false;

    }


    public void AllOff()
    {
        Kimsomin = false;
        Parkjihye = false;
        LeeHaneul = false;
        Hanjiyun = false;
        Anseyeong = false;
        Turret = false;
        Bomb = false;
    }

    public void KimsominOn()
    {
        AllOff();
        Kimsomin = true;
    }

    public void ParkjihyeOn()
    {
        AllOff();
        Parkjihye = true;
    }

    public void LeeHaneulOn()
    {
        AllOff();
        LeeHaneul = true;
    }

    public void HanjiyunOn()
    {
        AllOff();
        Hanjiyun = true;

    }

    public void Anseyeong0n()
    {
        AllOff();
        Anseyeong = true;
    }

    public void BombOn()
    {
        AllOff();
        Bomb = true;
    }

    public void Turret0n()
    {
        AllOff();
        Turret = true;
    }




}
