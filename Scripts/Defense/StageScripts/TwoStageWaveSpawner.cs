using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class TwoStageWaveSpawner : OneStageWaveSpawner
{
    public GameObject LineUI2;

    public Transform enemyPrefabTwostage1;
    public Transform enemyPrefabTwostage2;

    [Header("적 2")]
    public Transform enemy2PrefabTwostage1;
    public Transform enemy2PrefabTwostage2;

    [Header("적 3")]
    public Transform enemy3PrefabTwostage1;
    public Transform enemy3PrefabTwostage2;

    public Transform spawnPoint2;

    int waveIndex4 = 8;

    public static bool TwoStageOpen { get; set; } = false;
    public GameObject startTwoStage;

    private void Awake()
    {
        gameOverCount = 3;
        TwoStageOpen = false;
        fixTime = false;
        OneStageWaveSpawner.dragnow = false;
        OneStageWaveSpawner.startTimedragnow = false;
        fixIconOn = false;
        timeBetweenWaves = 0;

        waveIndex = 7;
        waveIndex2 = 11;

        //2-3 등장 적
        waveIndex3 = 9;
        waveIndex4 = 8;
    }

    public override void Update()
    {
        GameOverCount.text = gameOverCount.ToString();

        // 게임 오버 카운트가 0이 될 시
        if (gameOverCount <= 0)
        {
            // 게임 오버 처리
            SceneChanger.TwoStage = false;
            Money.money = 5; // 디펜스 머니 초기화
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


        //2-1 웨이브

        if (waveIndex == 7 && stopCount == false) //웨이브가 끝나기 전, 카운트가 처음일 때
        {
            StageWaveCount.text = "2 - 1";
            stageString.text = "스테이지 2 - 2";
            SirenLight.SetActive(true);
            LineUI.SetActive(true);
            countdown -= Time.deltaTime;

            if (!wavesEnd)
            {

                if (countdown <= 0)
                {
                    WaveCountDownSlider.SetActive(false);
                }



            }

        }

        if (countdown <= 0f && stopCount == false && waveIndex == 7)
        {
            SirenLight.SetActive(false);
            stageString.text = "스테이지 2 - 1";
            WaveCountDownSlider.SetActive(false);
            EnemyCount.text = waveIndex.ToString(); //적 수만큼 유아이 표시
            StageWaveCount.text = "2 - 1";
            StartCoroutine(SpawnWave01());

        }


        //2-2 웨이브

        if (waveIndex2 == 11 && waveIndex == 8 && stopCount == false) //2 웨이브가 끝나기 전, 카운트가 처음일 때
        {
            StageWaveCount.text = "2 - 2";
            stageString.text = "스테이지 2 - 2";
            SirenLight.SetActive(true);
            LineUI.SetActive(true);
            countdown -= Time.deltaTime;

            if (!wavesEnd)
            {

                if (countdown <= 0)
                {
                    WaveCountDownSlider.SetActive(false);
                }



            }

        }

        if (countdown <= 0f && stopCount == false && waveIndex == 8) //카운트가 끝났고, 2-1 웨이브도 끝났을 때
        {
            SirenLight.SetActive(false);
            stageString.text = "스테이지 2 - 2";
            WaveCountDownSlider.SetActive(false);
            EnemyCount.text = waveIndex2.ToString();
            StageWaveCount.text = "2 - 2";
            StartCoroutine(SpawnWave02());

        }


        //2-3 웨이브

        if (waveIndex3 == 9 && waveIndex2 == 12 && stopCount == false)
        {
            StageWaveCount.text = "2 - 3";
            stageString.text = "스테이지 2 - 3";
            SirenLight.SetActive(true);
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

        if (countdown <= 0f && stopCount == false && waveIndex2 == 12)
        {
            SirenLight.SetActive(false);
            stageString.text = "스테이지 2 - 3";
            WaveCountDownSlider.SetActive(false);
            EnemyCount.text = (waveIndex3 + waveIndex4).ToString();
            StageWaveCount.text = "2 - 3";
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
        totalEnemyCount = 7;
        for (int i = 0; i < 1; i++)
        {

            SpawnEnemy();
            yield return new WaitForSeconds(1f);
            SpawnEnemytwo();
            yield return new WaitForSeconds(1f);
            SpawnEnemy();
            yield return new WaitForSeconds(1f);
            SpawnEnemytwo();
            yield return new WaitForSeconds(1f);
            SpawnEnemy();
            yield return new WaitForSeconds(1f);
            SpawnTwoEnemy();
            yield return new WaitForSeconds(1f);
            SpawnTwoEnemy();
            yield return new WaitForSeconds(1f);
        }

        // 적의 수가 0 이하가 될 때까지 대기
        yield return new WaitUntil(() => totalEnemyCount <= 0);

        fixIconOn = true;
        timeBetweenWaves = 10f;
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
        LineUI.SetActive(false);
        stopCount = true;
        totalEnemyCount = 11;
        for (int i = 0; i < 4; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(1f);
            SpawnEnemytwo();
            yield return new WaitForSeconds(1f);
        }
        SpawnTwoEnemy();
        yield return new WaitForSeconds(1f);
        SpawnTwoEnemy();
        yield return new WaitForSeconds(1f);
        SpawnTwoEnemy();

        // 적의 수가 0 이하가 될 때까지 대기
        yield return new WaitUntil(() => totalEnemyCount <= 0);

        fixIconOn = true;
        timeBetweenWaves = 10f;

        TwoStageOpen = true;
        startTwoStage.SetActive(true);
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
        totalEnemyCount = 17;


        for (int i = 0; i < 2; i++)
        {
            SpawnEnemy();
            SpawnEnemythree();
            yield return new WaitForSeconds(1f);
            SpawnEnemytwo();
            SpawnEnemyFour();
            yield return new WaitForSeconds(1f);

        }
        SpawnEnemytwo();
        SpawnEnemyFour();
        yield return new WaitForSeconds(1f); //2번 구역 1적 종료, 5명
        SpawnEnemy();
        SpawnTwoEnemyAnoPoint(); //2번 구역 1적 시작, 3명
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnTwoEnemyAnoPoint();
        yield return new WaitForSeconds(1f); //1번 구역 1적 종료, 7명
        SpawnThreeEnemyFirstPoint();
        SpawnTwoEnemyAnoPoint(); ;
        yield return new WaitForSeconds(1f);
        SpawnThreeEnemyFirstPoint();
        yield return new WaitForSeconds(1f); //1번 구역 3적 종료, 2명


        // 적의 수가 0 이하가 될 때까지 대기
        yield return new WaitUntil(() => totalEnemyCount <= 0);
        wavesEnd = true;
        Money.Upbringingmoney += 3200; // 클리어 보상 
        Money.money = 5; // 디펜스 머니 초기화
        stageClear.SetActive(true);
        yield return new WaitForSecondsRealtime(4f);
        Time.timeScale = 1;
        SceneManager.LoadScene("Upbringing");

        stopCount = false;
        countdown = 15;
        waveIndex3++;
        WaveCountDownSlider.SetActive(true);



    }

    public override void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);


    }

    public override void SpawnEnemytwo()
    {
        Instantiate(enemyPrefab2, spawnPoint.position, spawnPoint.rotation);

    }

    void SpawnEnemythree()
    {
        Instantiate(enemyPrefabTwostage1, spawnPoint2.position, spawnPoint2.rotation);
    }

    void SpawnEnemyFour()
    {
        Instantiate(enemyPrefabTwostage2, spawnPoint2.position, spawnPoint2.rotation);
    }



    void SpawnTwoEnemy()
    {
        Instantiate(enemy2PrefabTwostage1, spawnPoint.position, spawnPoint.rotation);


    }

    void SpawnTwoEnemyAnoPoint()
    {
        Instantiate(enemy2PrefabTwostage2, spawnPoint2.position, spawnPoint.rotation);

    }

    void SpawnThreeEnemyFirstPoint()
    {
        Instantiate(enemy3PrefabTwostage1, spawnPoint.position, spawnPoint.rotation);
    }
}
