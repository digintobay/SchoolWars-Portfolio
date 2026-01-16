using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class ThreeStageWaveSpawner : OneStageWaveSpawner
{
    public GameObject LineUI2;
    // stage 3용 적 프리팹


    public Transform enemyPrefabThreestage1;
    public Transform enemyPrefabThreestage1ver2;
    public Transform enemyPrefabThreestage2;
    public Transform enemyPrefabThreestage3;

    // stage 3 스폰2포인트 적 프리팹

    public Transform anoenemyPrefabThreestage1;
    public Transform anoenemyPrefabThreestage1ver2;
    public Transform anoenemyPrefabThreestage2;
    public Transform anoenemyPrefabThreestage3;

    public Transform spawnPoint2;

    public static bool ThreeStageOpen { get; set; } = false;
    public GameObject startThreeStage;


    //3-1 11명, 3-2 13명+13명, 3-3 18명+18명

    private void Awake()
    {
        SirenLight.SetActive(false);
        gameOverCount = 3;
        ThreeStageOpen = false;
        fixTime = false;
        OneStageWaveSpawner.dragnow = false;
        OneStageWaveSpawner.startTimedragnow = false;
        fixIconOn = false;
        timeBetweenWaves = 0;

        waveIndex = 11;
        waveIndex2 = 26;
        waveIndex3 = 36;
    }

    public override void Update()
    {
    
        GameOverCount.text = gameOverCount.ToString();

        // 게임 오버 카운트가 0이 될 시
        if (gameOverCount <= 0)
        {
            // 게임 오버 처리
            SceneChanger.ThreeStage = false;
            Money.money = 8; // 디펜스 머니 초기화
            StartCoroutine(Faild());
        }

        if (timeBetweenWaves <= 10 && timeBetweenWaves >= 1) // 정비 시간 10초 내에는 드래그 불가
        {
            StageWaveCount.text = "정비 시간";
            fixTime = true;
            dragnow = false;
        }
        else if (timeBetweenWaves <= 0)
        {
            dragnow = true;
            fixTime = false;
        }

        if (countdown >= 0 && stopCount == false)
        {
            startTimedragnow = true;

        }
        else startTimedragnow = false;


        // 3-1 웨이브

        if (waveIndex == 11 && stopCount == false) //웨이브가 끝나기 전, 카운트가 처음일 때
        {
            StageWaveCount.text = "3 - 1";
            stageString.text = "스테이지 3 - 1";
            LineUI.SetActive(true);
            SirenLight.SetActive(true);
            countdown -= Time.deltaTime;

            if (!wavesEnd)
            {

                if (countdown <= 0)
                {
                    WaveCountDownSlider.SetActive(false);
                }



            }

        }

        if (countdown <= 0f && stopCount == false && waveIndex == 11)
        {
            SirenLight.SetActive(false);
            stageString.text = "스테이지 3 - 1";
            WaveCountDownSlider.SetActive(false);
            EnemyCount.text = waveIndex.ToString(); //적 수만큼 유아이 표시
            StageWaveCount.text = "3 - 1";
            StartCoroutine(SpawnWave01());

        }


        //3-2 웨이브

        if (waveIndex2 == 26 && waveIndex == 12 && stopCount == false) //2 웨이브가 끝나기 전, 카운트가 처음일 때
        {
            SirenLight.SetActive(true);
            StageWaveCount.text = "3 - 2";
            stageString.text = "스테이지 3 - 2";
            LineUI2.SetActive(true);
            countdown -= Time.deltaTime;


            if (!wavesEnd)
            {

                if (countdown <= 0)
                {
                    WaveCountDownSlider.SetActive(false);
                }



            }

        }

        if (countdown <= 0f && stopCount == false && waveIndex == 12) //카운트가 끝났고, 2-1 웨이브도 끝났을 때
        {
            SirenLight.SetActive(false);
            stageString.text = "스테이지 3 - 2";
            WaveCountDownSlider.SetActive(false);
            EnemyCount.text = waveIndex2.ToString();
            StageWaveCount.text = "3 - 2";
            StartCoroutine(SpawnWave02());

        }


        //3-3 웨이브

        if (waveIndex3 == 36 && waveIndex2 == 27 && stopCount == false)
        {
            SirenLight.SetActive(true);
            StageWaveCount.text = "3 - 3";
            stageString.text = "스테이지 3 - 3";
            LineUI2.SetActive(true);
            countdown -= Time.deltaTime;

            if (!wavesEnd)
            {

                if (countdown <= 0)
                {
                    WaveCountDownSlider.SetActive(false);
                }



            }

        }

        if (countdown <= 0f && stopCount == false && waveIndex2 == 27)
        {
            SirenLight.SetActive(false);
            stageString.text = "스테이지 3 - 3";
            WaveCountDownSlider.SetActive(false);
            EnemyCount.text = waveIndex3.ToString();
            StageWaveCount.text = "3 - 3";
            StartCoroutine(SpawnWave03());

        }




        //정비 시간 조정
        if (fixIconOn == true)
        {

            FixTimeSlider.SetActive(true);
            timeBetweenWaves -= Time.deltaTime;

        }
        else FixTimeSlider.SetActive(false);


    }


    //첫 번째 웨이브
    public override IEnumerator SpawnWave01()
    {
        LineUI.SetActive(false);
        stopCount = true;
        totalEnemyCount = 11;
        for (int i = 0; i < 3; i++) // 1번 적 일곱 명
        {

            SpawnEnemy();
            yield return new WaitForSeconds(1f);
            SpawnEnemyVerTwo();
            yield return new WaitForSeconds(1f);


        }
        SpawnEnemy();
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < 3; i++)
        {
            SpawnEnemytwo();
            yield return new WaitForSeconds(1f);
        }
        SpawnEnemythree();

        // 적의 수가 0 이하가 될 때까지 대기
        yield return new WaitUntil(() => totalEnemyCount <= 0);

        fixIconOn = true;
        timeBetweenWaves = 10f;
        // 3 스테이지 2번 구역 오픈
        ThreeStageOpen = true;
        startThreeStage.SetActive(true);
        yield return new WaitForSeconds(10f);
        fixIconOn = false;
        stopCount = false;
        countdown = 5;
        waveIndex++;
        WaveCountDownSlider.SetActive(true);


    }

    //두 번째 웨이브
    public override IEnumerator SpawnWave02()
    {
        LineUI2.SetActive(false);
        stopCount = true;
        totalEnemyCount = 26;
        for (int i = 0; i < 3; i++)
        {
            SpawnEnemy();
            SpawnEnemyAnoPoint();
            yield return new WaitForSeconds(1f);
            SpawnEnemyVerTwo();
            SpawnEnemyAnoPointVerTwo();
            yield return new WaitForSeconds(1f);


        }
        SpawnEnemy();
        SpawnEnemyAnoPoint(); //7 끝
        yield return new WaitForSeconds(1f);
        SpawnEnemyVerTwo();
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemy();
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemyVerTwo(); //10 끝
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointThree();
        yield return new WaitForSeconds(1f);
        SpawnEnemythree();
        SpawnEnemyAnoPointThree();


        // 적의 수가 0 이하가 될 때까지 대기
        yield return new WaitUntil(() => totalEnemyCount <= 0);

        fixIconOn = true;
        timeBetweenWaves = 10f;
        yield return new WaitForSeconds(10f);
        fixIconOn = false;
        stopCount = false;
        countdown = 5;
        waveIndex2++;
        WaveCountDownSlider.SetActive(true);

    }



    //세 번째 웨이브
    public override IEnumerator SpawnWave03()
    {
        LineUI2.SetActive(false);
        stopCount = true;
        totalEnemyCount = 36;
        for (int i = 0; i < 5; i++)
        {
            SpawnEnemy();
            SpawnEnemyAnoPoint();
            yield return new WaitForSeconds(1f);
            SpawnEnemyVerTwo();
            SpawnEnemyAnoPointVerTwo();
            yield return new WaitForSeconds(1f);

        }
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPoint();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointVerTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPoint();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemythree();
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemythree();
        SpawnEnemyAnoPointThree();
        yield return new WaitForSeconds(1f);
        SpawnEnemythree();
        SpawnEnemyAnoPointThree();


        // 적의 수가 0 이하가 될 때까지 대기
        yield return new WaitUntil(() => totalEnemyCount <= 0);
        wavesEnd = true;
        Money.Upbringingmoney += 3800; // 클리어 보상 
        Money.money = 13; // 디펜스 머니 초기화
        stageClear.SetActive(true);
        yield return new WaitForSecondsRealtime(5f);
        Time.timeScale = 1;
        SceneManager.LoadScene("Upbringing");

        stopCount = false;
        countdown = 15;
        waveIndex3++;
        WaveCountDownSlider.SetActive(true);



    }

    public override void SpawnEnemy()
    {
        Instantiate(enemyPrefabThreestage1, spawnPoint.position, spawnPoint.rotation);


    }

    public void SpawnEnemyVerTwo()
    {
        Instantiate(enemyPrefabThreestage1ver2, spawnPoint.position, spawnPoint.rotation);
    }

    public override void SpawnEnemytwo()
    {
        Instantiate(enemyPrefabThreestage2, spawnPoint.position, spawnPoint.rotation);

    }


    void SpawnEnemythree()
    {
        Instantiate(enemyPrefabThreestage3, spawnPoint.position, spawnPoint.rotation);

    }

    void SpawnEnemyAnoPoint()
    {
        Instantiate(anoenemyPrefabThreestage1, spawnPoint2.position, spawnPoint2.rotation);
    }


    void SpawnEnemyAnoPointVerTwo()
    {
        Instantiate(anoenemyPrefabThreestage1ver2, spawnPoint2.position, spawnPoint2.rotation);
    }


    void SpawnEnemyAnoPointTwo()
    {
        Instantiate(anoenemyPrefabThreestage2, spawnPoint2.position, spawnPoint2.rotation);
    }


    void SpawnEnemyAnoPointThree()
    {
        Instantiate(anoenemyPrefabThreestage3, spawnPoint2.position, spawnPoint2.rotation);
    }



}
