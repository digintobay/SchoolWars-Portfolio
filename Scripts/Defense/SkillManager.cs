using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public static SkillManager Instance = null;

    private void Awake()
    {
        turretDamage = 30;
        bombDamage = 100;

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
         
        }
        else
        {
            Destroy(gameObject);
        }

 
    }

    [Header("설치물 데미지")]
    public static int turretDamage { get; set; }
    public static int bombDamage { get; set; }


    [Header("기본 공격")]
    [Header("공속")]

    public static float sominAttackSpeed { get; set; } = 1;
    public static float jihyeAttackSpeed { get; set; } = 1;
    public static float haneulAttackSpeed { get; set; } = 1;
    public static float jiyunAttackSpeed { get; set; } = 1;
    public static float seyeongAttackSpeed { get; set; } = 1;

    [Header("공격력")]

    public static int sominAttackDamage { get; set; } = 125;
    public static int jihyeAttackDamage { get; set; } = 65;
    public static int haneulAttackDamage { get; set; } = 250;
    public static int jiyunAttackDamage { get; set; } = 120;
    public static int seyeongAttackDamage { get; set; } = 95;


    [Header("보유 스킬 공격력 관리")]

    public static int sominSkillDamage { get; set; } = 235;
    public static int jihyeSkillDamage { get; set; } = 250;
    public static int haneulSkillDamage { get; set; } = 250;
    public static int jiyunSkillDamage { get; set; } = 225;
    public static int seyeongSkillDamage { get; set; }=200;

    [Header("소민 레벨 체크용 변수")]
    public static int sominattackLevel { get; set; } = 1;
    public static int sominskillLevel { get; set; } = 1;

    [Header("지혜 레벨 체크용 변수")]
    public static int jihyeattackLevel { get; set; } = 1;
    public static int jihyeskillLevel { get; set; } = 1;

    [Header("하늘 레벨 체크용 변수")]
    public static int haneulattackLevel { get; set; } = 1;
    public static int haneulskillLevel { get; set; } = 1;

    [Header("지윤 레벨 체크용 변수")]
    public static int jiyunattackLevel { get; set; } = 1;
    public static int jiyunskillLevel { get; set; } = 1;

    [Header("세영 레벨 체크용 변수")]
    public static int seyeongattackLevel { get; set; } = 1;
    public static int seyeongskillLevel { get; set; } = 1;



    // 소민 어택 레벨

    public static void SominTwoLevel()
    {
        sominattackLevel = 2;
        sominAttackSpeed = 1.1f;
        sominAttackDamage = 140;

    }
    public static void SominThreeLevel()
    {
        sominattackLevel = 3;
        sominAttackSpeed = 1.2f;
        sominAttackDamage = 160;
    }
    public static void SominFourLevel()
    {
        sominattackLevel = 4;
        sominAttackSpeed = 1.3f;
        sominAttackDamage = 190;
    }
    public static void SominFiveLevel()
    {
        sominattackLevel = 5;
        sominAttackSpeed = 1.4f;
        sominAttackDamage = 235;
    }
    public static void SominSixLevel()
    {
        sominattackLevel = 6;
        sominAttackSpeed = 1.5f;
        sominAttackDamage = 300;
    }
    public static void SominSevenLevel()
    {
        sominattackLevel = 7;
        sominAttackSpeed = 1.6f;
        sominAttackDamage = 390;
    }

    //소민 스킬 레벨
    public static void SominSkillTwoLevel()
    {
        sominskillLevel = 2;
        sominSkillDamage = 290;
    }

    public static void SominSkillThreeLevel()
    {
        sominskillLevel = 3;
        sominSkillDamage = 375;
    }

    public static void SominSkillFourLevel()
    {
        sominskillLevel = 4;
        sominSkillDamage = 470;
    }
    public static void SominSkillFiveLevel()
    {
        sominskillLevel = 5;
        sominSkillDamage = 600;
    }
    public static void SominSkillSixLevel()
    {
        sominskillLevel = 6;
        sominSkillDamage = 805;
    }
    public static void SominSkillSevenLevel()
    {
        sominskillLevel = 7;
        sominSkillDamage = 1045;
    }

    // 지혜

    public static void JihyeTwoLevel()
    {
        jihyeattackLevel = 2;
        jihyeAttackSpeed = 1.1f;
        jihyeAttackDamage = 150;

    }
    public static void JihyeThreeLevel()
    {
        jihyeattackLevel = 3;
        jihyeAttackSpeed = 1.2f;
        jihyeAttackDamage = 175;
    }
    public static void JihyeFourLevel()
    {
        jihyeattackLevel = 4;
        jihyeAttackSpeed = 1.3f;
        jihyeAttackDamage = 210;
    }
    public static void JihyeFiveLevel()
    {
        jihyeattackLevel = 5;
        jihyeAttackSpeed = 1.4f;
        jihyeAttackDamage = 250;
    }
    public static void JihyeSixLevel()
    {
        jihyeattackLevel = 6;
        jihyeAttackSpeed = 1.5f;
        jihyeAttackDamage = 320;
    }
    public static void JihyeSevenLevel()
    {
        jihyeattackLevel = 7;
        jihyeAttackSpeed = 1.6f;
        jihyeAttackDamage = 410;
    }

    //지혜 스킬 레벨
    public static void JihyeSkillTwoLevel()
    {
        jihyeskillLevel = 2;
        jihyeSkillDamage = 310;
    }

    public static void JihyeSkillThreeLevel()
    {
        jihyeskillLevel = 3;
        jihyeSkillDamage = 410;
    }

    public static void JihyeSkillFourLevel()
    {
        jihyeskillLevel = 4;
        jihyeSkillDamage = 520;
    }
    public static void JihyeSkillFiveLevel()
    {
        jihyeskillLevel = 5;
        jihyeSkillDamage = 650;
    }
    public static void JihyeSkillSixLevel()
    {
        jihyeskillLevel = 6;
        jihyeSkillDamage = 870;
    }
    public static void JihyeSkillSevenLevel()
    {
        jihyeskillLevel = 7;
        jihyeSkillDamage = 1210;
    }


    // 하늘

    public static void HaneulTwoLevel()
    {
        haneulattackLevel = 2;
        haneulAttackSpeed = 1.1f;
        haneulAttackDamage = 280;

    }
    public static void HaneulThreeLevel()
    {
        haneulattackLevel = 3;
        haneulAttackSpeed = 1.2f;
        haneulAttackDamage = 320;
    }
    public static void HaneulFourLevel()
    {
        haneulattackLevel = 4;
        haneulAttackSpeed = 1.3f;
        haneulAttackDamage = 370;
    }
    public static void HaneulFiveLevel()
    {
        haneulattackLevel = 5;
        haneulAttackSpeed = 1.4f;
        haneulAttackDamage = 430;
    }
    public static void HaneulSixLevel()
    {
        haneulattackLevel = 6;
        haneulAttackSpeed = 1.5f;
        haneulAttackDamage = 600;
    }
    public static void HaneulSevenLevel()
    {
        haneulattackLevel = 7;
        haneulAttackSpeed = 1.6f;
        haneulAttackDamage = 680;
    }


    //하늘 스킬 레벨
    public static void HaneulSkillTwoLevel()
    {
        haneulskillLevel = 2;
        haneulSkillDamage = 390;
    }

    public static void HaneulSkillThreeLevel()
    {
        haneulskillLevel = 3;
        haneulSkillDamage = 510;
    }

    public static void HaneulSkillFourLevel()
    {
        haneulskillLevel = 4;
        haneulSkillDamage = 720;
    }
    public static void HaneulSkillFiveLevel()
    {
        haneulskillLevel = 5;
        haneulSkillDamage = 980;
    }
    public static void HaneulSkillSixLevel()
    {
        haneulskillLevel = 6;
        haneulSkillDamage = 1200;
    }
    public static void HaneulSkillSevenLevel()
    {
        haneulskillLevel = 7;
        haneulSkillDamage = 1500;
    }



    // 지윤

    public static void JiyunTwoLevel()
    {
        jiyunattackLevel = 2;
        jiyunAttackSpeed = 1.1f;
        jiyunAttackDamage = 145;

    }
    public static void JiyunThreeLevel()
    {
        jiyunattackLevel = 3;
        jiyunAttackSpeed = 1.2f;
        jiyunAttackDamage = 170;
    }
    public static void JiyunFourLevel()
    {
        jiyunattackLevel = 4;
        jiyunAttackSpeed = 1.3f;
        jiyunAttackDamage = 200;
    }
    public static void JiyunFiveLevel()
    {
        jiyunattackLevel = 5;
        jiyunAttackSpeed = 1.4f;
        jiyunAttackDamage = 245;
    }
    public static void JiyunSixLevel()
    {
        jiyunattackLevel = 6;
        jiyunAttackSpeed = 1.5f;
        jiyunAttackDamage = 310;
    }
    public static void JiyunSevenLevel()
    {
        jiyunattackLevel = 7;
        jiyunAttackSpeed = 1.6f;
        jiyunAttackDamage = 400;
    }

    //지윤 스킬 레벨
    public static void JiyunSkillTwoLevel()
    {
        jiyunskillLevel = 2;
        jiyunSkillDamage = 280;
    }

    public static void JiyunSkillThreeLevel()
    {
        jiyunskillLevel = 3;
        jiyunSkillDamage = 360;
    }

    public static void JiyunSkillFourLevel()
    {
        jiyunskillLevel = 4;
        jiyunSkillDamage = 485;
    }
    public static void JiyunSkillFiveLevel()
    {
        jiyunskillLevel = 5;
        jiyunSkillDamage = 575;
    }
    public static void JiyunSkillSixLevel()
    {
        jiyunskillLevel = 6;
        jiyunSkillDamage = 850;
    }
    public static void JiyunSkillSevenLevel()
    {
        jiyunskillLevel = 7;
        jiyunSkillDamage = 1000;
    }



    // 세영

    public static void SeyeongTwoLevel()
    {
        seyeongattackLevel = 2;
        seyeongAttackSpeed = 1.1f;
        seyeongAttackDamage = 145;

    }
    public static void SeyeongThreeLevel()
    {
        seyeongattackLevel = 3;
        seyeongAttackSpeed = 1.2f;
        seyeongAttackDamage = 170;
    }
    public static void SeyeongFourLevel()
    {
        seyeongattackLevel = 4;
        seyeongAttackSpeed = 1.3f;
        seyeongAttackDamage = 200;
    }
    public static void SeyeongFiveLevel()
    {
        seyeongattackLevel = 5;
        seyeongAttackSpeed = 1.4f;
        seyeongAttackDamage = 245;
    }
    public static void SeyeongSixLevel()
    {
        seyeongattackLevel = 6;
        seyeongAttackSpeed = 1.5f;
        seyeongAttackDamage = 310;
    }
    public static void SeyeongSevenLevel()
    {
        seyeongattackLevel = 7;
        seyeongAttackSpeed = 1.6f;
        seyeongAttackDamage = 400;
    }

    //세영 스킬 레벨
    public static void SeyeongSkillTwoLevel()
    {
        seyeongskillLevel = 2;
        seyeongSkillDamage = 250;
    }

    public static void SeyeongSkillThreeLevel()
    {
        seyeongskillLevel = 3;
        seyeongSkillDamage = 310;
    }

    public static void SeyeongSkillFourLevel()
    {
        seyeongskillLevel = 4;
        seyeongSkillDamage = 390;
    }
    public static void SeyeongSkillFiveLevel()
    {
        seyeongskillLevel = 5;
        seyeongSkillDamage = 490;
    }
    public static void SeyeongSkillSixLevel()
    {
        seyeongskillLevel = 6;
        seyeongSkillDamage = 630;
    }
    public static void SeyeongSkillSevenLevel()
    {
        seyeongskillLevel = 7;
        seyeongSkillDamage = 810;
    }


}
