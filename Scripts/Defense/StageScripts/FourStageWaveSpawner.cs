using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FourStageWaveSpawner : OneStageWaveSpawner
{
    public GameObject LineUI2;
    // stage 4용 적 프리팹


    public Transform enemyPrefabFourstage1;
    public Transform enemyPrefabFourstage1ver2;
    public Transform enemyPrefabFourstage2;
    public Transform enemyPrefabFourstage3;

    // stage 4 스폰2포인트 적 프리팹

    public Transform anoenemyPrefabFourstage1;
    public Transform anoenemyPrefabFourstage1ver2;
    public Transform anoenemyPrefabFourstage2;
    public Transform anoenemyPrefabFourstage3;

    // stage 4 스폰3포인트 적 프리팹

    public Transform ano3enemyPrefabFourstage1;
    public Transform ano3enemyPrefabFourstage1ver2;
    public Transform ano3enemyPrefabFourstage2;
    public Transform ano3enemyPrefabFourstage3;

    public Transform spawnPoint2;
    public Transform spawnPoint3;

    public static bool FourStageOpen { get; set; } = false;
    public GameObject startFourStage;


    //3-1 11명, 3-2 13명+13명, 3-3 18명+18명

    private void Awake()
    {
        SirenLight.SetActive(false);
        gameOverCount = 3;
        FourStageOpen = false;
        fixTime = false;
        OneStageWaveSpawner.dragnow = false;
        OneStageWaveSpawner.startTimedragnow = false;
        fixIconOn = false;
        timeBetweenWaves = 0;

        waveIndex = 35; // 1번 구역 20, 2번 구역 15
        waveIndex2 = 45; // 1번 구역 25, 2번 구역 20
        waveIndex3 = 42; // 1번 구역 18, 2번 구역 15, 3번 구역 9
    }

    public override void Update()
    {

        GameOverCount.text = gameOverCount.ToString();

        // 게임 오버 카운트가 0이 될 시
        if (gameOverCount <= 0)
        {
            // 게임 오버 처리
            SceneChanger.FourStage = false;
            Money.money = 13; // 디펜스 머니 초기화
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


        // 4-1 웨이브

        if (waveIndex == 35 && stopCount == false) //웨이브가 끝나기 전, 카운트가 처음일 때
        {
            SirenLight.SetActive(true);
            StageWaveCount.text = "4 - 1";
            stageString.text = "스테이지 4 - 1";
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

        if (countdown <= 0f && stopCount == false && waveIndex == 35)
        {
            SirenLight.SetActive(false);
            stageString.text = "스테이지 4 - 1";
            WaveCountDownSlider.SetActive(false);
            EnemyCount.text = 35.ToString(); //적 수만큼 유아이 표시
            StageWaveCount.text = "4 - 1";
            StartCoroutine(SpawnWave01());

        }



        //4-2 웨이브

        if (waveIndex2 == 45 && waveIndex == 36 && stopCount == false) //2 웨이브가 끝나기 전, 카운트가 처음일 때
        {
            SirenLight.SetActive(true);
            StageWaveCount.text = "4 - 2";
            stageString.text = "스테이지 4 - 2";
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

        if (countdown <= 0f && stopCount == false && waveIndex == 36) //카운트가 끝났고, 2-1 웨이브도 끝났을 때
        {
            SirenLight.SetActive(false);
            stageString.text = "스테이지 4 - 2";
            WaveCountDownSlider.SetActive(false);
            EnemyCount.text = 45.ToString();
            StageWaveCount.text = "4 - 2";
            StartCoroutine(SpawnWave02());

        }


        //4-3 웨이브

        if (waveIndex3 == 42 && waveIndex2 == 46 && stopCount == false)
        {
            SirenLight.SetActive(true);
            StageWaveCount.text = "4 - 3";
            stageString.text = "스테이지 4 - 3";
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

        if (countdown <= 0f && stopCount == false && waveIndex2 == 46)
        {
            SirenLight.SetActive(false);
            stageString.text = "스테이지 4 - 3";
            WaveCountDownSlider.SetActive(false);
            EnemyCount.text = 42.ToString();
            StageWaveCount.text = "4 - 3";
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
        totalEnemyCount = 35;




        for (int i = 0; i < 4; i++)  // 1번 구역 20, 2번 구역 15
        {

            SpawnEnemy();
            SpawnEnemyAnoPoint();
            yield return new WaitForSeconds(1f);
            SpawnEnemyVerTwo();
            SpawnEnemyAnoPointVerTwo();
            yield return new WaitForSeconds(1f);

        }
        // 2번 포인트 8명 끝
        yield return new WaitForSeconds(1f);
        SpawnEnemy();
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemyVerTwo(); // 1번 포인트 10명 끝
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo(); // 1번 포인트 2번 적 시작
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo(); // 2번 포인트 5명 끝
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointThree(); // 2번 포인트 3번 적 시작
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointThree(); // 2번 포인트 끝
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo(); //7명 끝
        yield return new WaitForSeconds(1f);
        SpawnEnemythree();
        yield return new WaitForSeconds(1f);
        SpawnEnemythree();
        yield return new WaitForSeconds(1f);
        SpawnEnemythree(); //3명 끝


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

    //두 번째 웨이브    // 1번 구역 25, 2번 구역 20
    public override IEnumerator SpawnWave02()
    {
        LineUI.SetActive(false);
        stopCount = true;
        totalEnemyCount = 45;

        for (int i = 0; i < 5; i++)
        {
            SpawnEnemy();
            SpawnEnemyAnoPoint();
            yield return new WaitForSeconds(1f);
            SpawnEnemyVerTwo();
            SpawnEnemyAnoPointVerTwo();
            yield return new WaitForSeconds(1f);

        } // 2번 포인트 10명 끝
        SpawnEnemy();
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemyVerTwo(); //1번 포인트 12명 끝
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo(); // 1번 포인트 8명 시작
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo(); // 2번 포인트 7명 끝
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointThree(); //2번 포인트 적 3 3명 시작
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointThree();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo(); //1번 포인트 적 2, 8명 끝
        SpawnEnemyAnoPointThree(); //2 번 포인트 종료
        yield return new WaitForSeconds(1f);
        SpawnEnemythree(); // 1번 포인트 적 3, 5명 시작
        yield return new WaitForSeconds(1f);
        SpawnEnemythree();
        yield return new WaitForSeconds(1f);
        SpawnEnemythree();
        yield return new WaitForSeconds(1f);
        SpawnEnemythree();
        yield return new WaitForSeconds(1f);
        SpawnEnemythree();



        // 적의 수가 0 이하가 될 때까지 대기
        yield return new WaitUntil(() => totalEnemyCount <= 0);

        fixIconOn = true;
        timeBetweenWaves = 10f;
        // 4 스테이지 3번 구역 오픈
        FourStageOpen = true;
        startFourStage.SetActive(true);
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
        totalEnemyCount = 42;// 1번 구역 18, 2번 구역 15, 3번 구역 9

        for (int i = 0; i < 3; i++)
        {
            SpawnEnemy();
            SpawnEnemyAnoPoint();
            ThreeSpawnEnemyVerOne();
            yield return new WaitForSeconds(1f);
            SpawnEnemyVerTwo();
            SpawnEnemyAnoPointVerTwo();
            ThreeSpawnEnemyVerTwo();
        

        } // 3번 구역 적 1, 6명 종료

        SpawnEnemy();
        SpawnEnemyAnoPoint();
        ThreeSpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemyVerTwo();
        SpawnEnemyAnoPointVerTwo(); // 2번 구역 적 1, 8명 종료
        ThreeSpawnEnemyAnoPointTwo(); // 3번 구역 적 2, 2명 종료
        yield return new WaitForSeconds(1f);
        SpawnEnemy();
        SpawnEnemyAnoPointTwo(); // 2번 구역 적 2, 5명 시작
        ThreeSpawnEnemyAnoPointThree(); // 3번 구역 종료 
        yield return new WaitForSeconds(1f);
        SpawnEnemyVerTwo(); // 1번 구역 적 1, 10명 종료
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointThree(); // 2번 구역 적 3 시작
        yield return new WaitForSeconds(1f);
        SpawnEnemytwo(); // 1번 구역 적 2, 5명 종료
        SpawnEnemyAnoPointThree();
        yield return new WaitForSeconds(1f);
        SpawnEnemythree();
        yield return new WaitForSeconds(1f);
        SpawnEnemythree();
        yield return new WaitForSeconds(1f);
        SpawnEnemythree(); // 1번 구역 적 3, 3명 종료





        // 적의 수가 0 이하가 될 때까지 대기
        yield return new WaitUntil(() => totalEnemyCount <= 0);
        wavesEnd = true;
        Money.Upbringingmoney += 4500; // 클리어 보상 
        Money.money = 33; // 디펜스 머니 초기화
        stageClear.SetActive(true);
        yield return new WaitForSecondsRealtime(5f);
        Time.timeScale = 1;
        SceneManager.LoadScene("Upbringing");

        stopCount = false;
        countdown = 15;
        waveIndex3++;
        WaveCountDownSlider.SetActive(true);



    }

    // 1번 구역
    public override void SpawnEnemy()
    {
        Instantiate(enemyPrefabFourstage1, spawnPoint.position, spawnPoint.rotation);


    }

    public void SpawnEnemyVerTwo()
    {
        Instantiate(enemyPrefabFourstage1ver2, spawnPoint.position, spawnPoint.rotation);
    }

    public override void SpawnEnemytwo()
    {
        Instantiate(enemyPrefabFourstage2, spawnPoint.position, spawnPoint.rotation);

    }


    void SpawnEnemythree()
    {
        Instantiate(enemyPrefabFourstage3, spawnPoint.position, spawnPoint.rotation);

    }


    //2번 구역
    void SpawnEnemyAnoPoint()
    {
        Instantiate(anoenemyPrefabFourstage1, spawnPoint2.position, spawnPoint2.rotation);
    }


    void SpawnEnemyAnoPointVerTwo()
    {
        Instantiate(anoenemyPrefabFourstage1ver2, spawnPoint2.position, spawnPoint2.rotation);
    }


    void SpawnEnemyAnoPointTwo()
    {
        Instantiate(anoenemyPrefabFourstage2, spawnPoint2.position, spawnPoint2.rotation);
    }


    void SpawnEnemyAnoPointThree()
    {
        Instantiate(anoenemyPrefabFourstage3, spawnPoint2.position, spawnPoint2.rotation);
    }

    //3번 구역
    void ThreeSpawnEnemyVerOne()
    {
        Instantiate(ano3enemyPrefabFourstage1, spawnPoint3.position, spawnPoint2.rotation);
    }


    void ThreeSpawnEnemyVerTwo()
    {
        Instantiate(ano3enemyPrefabFourstage1ver2, spawnPoint3.position, spawnPoint2.rotation);
    }


    void ThreeSpawnEnemyAnoPointTwo()
    {
        Instantiate(ano3enemyPrefabFourstage2, spawnPoint3.position, spawnPoint2.rotation);
    }


    void ThreeSpawnEnemyAnoPointThree()
    {
        Instantiate(ano3enemyPrefabFourstage3, spawnPoint3.position, spawnPoint2.rotation);
    }
}
