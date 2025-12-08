using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMaster : MonoBehaviour
{

    public static BuildMaster Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("씬에 빌드마스터가 없습니다");
            return;
        }
        Instance = this;
    }


    [Header("중복 설치 가능 - 기물")]
    public GameObject BombPrefab;
    public GameObject TurretPrefab;

    [Header("중복 설치 불가능 - 플레이어")]
    public GameObject KimsominPrefab;
    public GameObject ParkJihyePrefab;
    public GameObject LeehaneulPrefab;
    public GameObject HanjiyunPrefab;
    public GameObject AnseyeongPrefab;


    private void Update()
    {
        if (ChangeBuild.Bomb == true)
        {
            turretToBuild = BombPrefab;
        }
        else if (ChangeBuild.Turret == true)
        {
            turretToBuild = TurretPrefab;
        }
        else if (ChangeBuild.Kimsomin == true)
        {
            turretToBuild = KimsominPrefab;
        }
        else if (ChangeBuild.Parkjihye == true)
        {
            turretToBuild = ParkJihyePrefab;
        }
        else if (ChangeBuild.LeeHaneul ==true)
        {
            turretToBuild = LeehaneulPrefab;
        }
        else if (ChangeBuild.Hanjiyun == true)
        {
            turretToBuild = HanjiyunPrefab;
        }
        else if (ChangeBuild.Anseyeong == true)
        {
            turretToBuild = AnseyeongPrefab;
        }

    }


    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

}
