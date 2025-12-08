using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FiveStageWaveSpawner : OneStageWaveSpawner
{
    public GameObject start3;

    public GameObject LineUI2;
    public GameObject LineUI3;
    public Transform spawnPoint2;
    public Transform spawnPoint3;

    [Header("적 프리팹 1, 2, 3 구역")]

    // stage 5용 적 프리팹

    public Transform enemyPrefabFivestage1;
    public Transform enemyPrefabFivetage1ver2;
    public Transform enemyPrefabFivestage2;
    public Transform enemyPrefabFivestage3;

    // stage 5 스폰2포인트 적 프리팹

    public Transform anoenemyPrefabFivestage1;
    public Transform anoenemyPrefabFivestage1ver2;
    public Transform anoenemyPrefabFivestage2;
    public Transform anoenemyPrefabFivestage3;

    // stage 5 스폰3포인트 적 프리팹

    public Transform ano3enemyPrefabFivestage1;
    public Transform ano3enemyPrefabFivestage1ver2;
    public Transform ano3enemyPrefabFivestage2;
    public Transform ano3enemyPrefabFivestage3;

    [Header("랜덤 포인트 적 프리팹 1, 2, 3 구역")]

    public Transform random1enemyPrefabFivestage1;
    public Transform random1enemyPrefabFivestage1ver2;
    public Transform random1enemyPrefabFivestage2;
    public Transform random1enemyPrefabFivestage3;

    public Transform random2enemyPrefabFivestage1;
    public Transform random2enemyPrefabFivestage1ver2;
    public Transform random2enemyPrefabFivestage2;
    public Transform random2enemyPrefabFivestage3;

    public Transform random3enemyPrefabFivestage1;
    public Transform random3enemyPrefabFivestage1ver2;
    public Transform random3enemyPrefabFivestage2;
    public Transform random3enemyPrefabFivestage3;



    public static bool FiveStageOpen { get; set; } = false;
    public GameObject startFiveStage;


    //3-1 11명, 3-2 13명+13명, 3-3 18명+18명

    private void Awake()
    {  
        //3번 구역 빛 꺼 주기
        start3.SetActive(false);


        SirenLight.SetActive(false);
        gameOverCount = 3;
        FiveStageOpen = false;
        fixTime = false;
        OneStageWaveSpawner.dragnow = false;
        OneStageWaveSpawner.startTimedragnow = false;
        fixIconOn = false;
        timeBetweenWaves = 0;

        waveIndex = 49; // 1번 구역 15, 2번 구역 15, 3번 구역 19
        waveIndex2 = 61; // 1번 구역 17, 2번 구역 17, 3번 구역27
        waveIndex3 = 75; // 1번 구역 25, 2번 구역 22, 3번 구역 28
    }

    public override void Update()
    {

        GameOverCount.text = gameOverCount.ToString();

        // 게임 오버 카운트가 0이 될 시
        if (gameOverCount <= 0)
        {
            
            // 게임 오버 처리
            SceneChanger.FiveStage = false;
            Money.money = 33; // 디펜스 머니 초기화
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


        // 5-1 웨이브

        if (waveIndex == 49 && stopCount == false) //웨이브가 끝나기 전, 카운트가 처음일 때
        {
            //3번 구역 빛 꺼 주기
            start3.SetActive(false);
            SirenLight.SetActive(true);
            StageWaveCount.text = "5 - 1";
            stageString.text = "스테이지 5 - 1";
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

        if (countdown <= 0f && stopCount == false && waveIndex == 49)
        {  
            //3번 구역 빛 켜 주기
            start3.SetActive(true);
            SirenLight.SetActive(false);
            stageString.text = "스테이지 5 - 1";
            WaveCountDownSlider.SetActive(false);
            EnemyCount.text = 3.ToString(); //적 수만큼 유아이 표시
            StageWaveCount.text = "5 - 1";
            StartCoroutine(SpawnWave01());

        }

   
        //5-2 웨이브

        if (waveIndex2 == 61 && waveIndex == 50 && stopCount == false) //2 웨이브가 끝나기 전, 카운트가 처음일 때
        {
            SirenLight.SetActive(true);
            StageWaveCount.text = "5 - 2";
            stageString.text = "스테이지 5 - 2";
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

        if (countdown <= 0f && stopCount == false && waveIndex == 50) //카운트가 끝났고, 2-1 웨이브도 끝났을 때
        {
            SirenLight.SetActive(false);
            stageString.text = "스테이지 5 - 2";
            WaveCountDownSlider.SetActive(false);
            EnemyCount.text = 61.ToString();
            StageWaveCount.text = "5 - 2";
            StartCoroutine(SpawnWave02());

        }


        //5-3 웨이브

        if (waveIndex3 == 75  && waveIndex2 == 62 && stopCount == false)
        {
            SirenLight.SetActive(true);
            StageWaveCount.text = "5 - 3";
            stageString.text = "스테이지 5 - 3";
            LineUI3.SetActive(true);
            countdown -= Time.deltaTime;

            if (!wavesEnd)
            {

                if (countdown <= 0)
                {
                    WaveCountDownSlider.SetActive(false);
                }

            }
        }

        if (countdown <= 0f && stopCount == false && waveIndex2 == 62)
        {
            SirenLight.SetActive(false);
            stageString.text = "스테이지 5 - 3";
            WaveCountDownSlider.SetActive(false);
            EnemyCount.text = 75.ToString();
            StageWaveCount.text = "5 - 3";
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
        totalEnemyCount = 30;
  


        for (int i = 0; i < 3; i++) 
        {

            SpawnEnemy();
            SpawnEnemyAnoPoint();
         
            yield return new WaitForSeconds(2f);
            SpawnEnemyVerTwo();
            SpawnEnemyAnoPointVerTwo();
        
            yield return new WaitForSeconds(2f);

        }
        SpawnEnemy();
        SpawnEnemyAnoPoint(); // 2번 구역 7명 종료
     
        yield return new WaitForSeconds(2f);
        SpawnEnemyVerTwo(); //1번 구역 8명 종료
        SpawnEnemyAnoPointTwo(); //2번 구역 5명 시작
     
        yield return new WaitForSeconds(2f);
        SpawnEnemytwo(); //1번 구역 2번 적 시작
        SpawnEnemyAnoPointTwo();
      
        yield return new WaitForSeconds(2f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo();
     //3번 구역 10명 종료
        yield return new WaitForSeconds(2f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo();
         //3번 구역 7명 시작
        yield return new WaitForSeconds(2f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo();
        
        yield return new WaitForSeconds(2f);
        SpawnEnemytwo(); 
        SpawnEnemyAnoPointThree();
        
        yield return new WaitForSeconds(2f);
        SpawnEnemythree();
        SpawnEnemyAnoPointThree();
        
        yield return new WaitForSeconds(2f);
        SpawnEnemythree(); //1번 구역 종료
        SpawnEnemyAnoPointThree(); //2번 구역 종료
        
     
    


        yield return new WaitForSeconds(2f);
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
        LineUI2.SetActive(false);
        stopCount = true;
        totalEnemyCount = 61; // 1번 구역 17, 2번 구역 17, 3번 구역27

        for (int i = 0; i < 4; i++)
        {
            SpawnEnemy();
            SpawnEnemyAnoPoint();
            ThreeSpawnEnemyVerOne();
            yield return new WaitForSeconds(2f);
            SpawnEnemyVerTwo();
            SpawnEnemyAnoPointVerTwo();
            ThreeSpawnEnemyVerTwo();
            yield return new WaitForSeconds(2f);

        }  // 2번 구역 1번 적 8명 종료
        SpawnEnemy();
        SpawnEnemyAnoPointTwo();
        ThreeSpawnEnemyVerOne();
        yield return new WaitForSeconds(2f);
        SpawnEnemyVerTwo(); //1번 구역 적 10명 종료
        SpawnEnemyAnoPointTwo();
        ThreeSpawnEnemyVerTwo(); 
        yield return new WaitForSeconds(2f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo();
        ThreeSpawnEnemyVerOne();
        yield return new WaitForSeconds(2f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo();
        ThreeSpawnEnemyVerTwo(); //3번 구역 적 12명 종료
        yield return new WaitForSeconds(2f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointTwo(); //2번 구역 적 2 5명 종료
        ThreeSpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(2f);
        SpawnEnemytwo();
        SpawnEnemyAnoPointThree();
        ThreeSpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(2f);
        SpawnEnemytwo(); //1번 구역 적2 5명 종료
        SpawnEnemyAnoPointThree();
        ThreeSpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(2f);
        SpawnEnemythree();
        SpawnEnemyAnoPointThree();
        ThreeSpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(2f);
        SpawnEnemythree();
        SpawnEnemyAnoPointThree(); //2번 구역 적 3 4명 종료
        ThreeSpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(2f);
        ThreeSpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(2f);
        ThreeSpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(2f);
        ThreeSpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(2f);
        ThreeSpawnEnemyAnoPointTwo();
        yield return new WaitForSeconds(2f);
        ThreeSpawnEnemyAnoPointTwo(); //3번 구역 적 2 10명 종료
        yield return new WaitForSeconds(2f);
        ThreeSpawnEnemyAnoPointThree();
        yield return new WaitForSeconds(2f);
        ThreeSpawnEnemyAnoPointThree();
        yield return new WaitForSeconds(2f);
        ThreeSpawnEnemyAnoPointThree();
        yield return new WaitForSeconds(2f);
        ThreeSpawnEnemyAnoPointThree();
        yield return new WaitForSeconds(2f);
        ThreeSpawnEnemyAnoPointThree(); //3번 구역 적 3 5명 종료

        // 적의 수가 0 이하가 될 때까지 대기
        yield return new WaitUntil(() => totalEnemyCount <= 0);
        // 5 스테이지 나가는 길 2 오픈
        FiveStageOpen = true;
        startFiveStage.SetActive(true);
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
        LineUI3.SetActive(false);
        stopCount = true;
        totalEnemyCount = 75;// 1번 구역 25, 2번 구역 22, 3번 구역 28 

        for (int i = 0; i < 5; i++)
        {
            OneSpawnEnemyRandomPoint();
            TwoSpawnEnemyRandomPoint();
            ThreeSpawnEnemyRandomPoint();
            yield return new WaitForSeconds(2f);
            OneSpawnEnemyRandomPointVer2();
            TwoSpawnEnemyRandomPointVer2();
            ThreeSpawnEnemyRandomPointVer2();

        } // 2 , 10 end 

        OneSpawnEnemyRandomPoint();
        TwoSpawnEnemy2RandomPoint();
        ThreeSpawnEnemyRandomPoint();
        yield return new WaitForSeconds(2f);
        OneSpawnEnemyRandomPointVer2(); //1, 12 end
        TwoSpawnEnemy2RandomPoint();
        ThreeSpawnEnemyRandomPointVer2();
        yield return new WaitForSeconds(2f);
        OneSpawnEnemy2RandomPoint();
        TwoSpawnEnemy2RandomPoint();
        ThreeSpawnEnemyRandomPoint();
        yield return new WaitForSeconds(2f);
        OneSpawnEnemy2RandomPoint();
        TwoSpawnEnemy2RandomPoint();
        ThreeSpawnEnemyRandomPointVer2();
        yield return new WaitForSeconds(2f);
        OneSpawnEnemy2RandomPoint();
        TwoSpawnEnemy2RandomPoint();
        ThreeSpawnEnemyRandomPoint(); // 3, 15 end
        yield return new WaitForSeconds(2f);
        OneSpawnEnemy2RandomPoint();
        TwoSpawnEnemy2RandomPoint();
        ThreeSpawnEnemy2RandomPoint();
        yield return new WaitForSeconds(2f);
        OneSpawnEnemy2RandomPoint();
        TwoSpawnEnemy2RandomPoint(); //2, 7 end
        ThreeSpawnEnemy2RandomPoint();
        yield return new WaitForSeconds(2f);
        OneSpawnEnemy2RandomPoint();
        TwoSpawnEnemy3RandomPoint();
        ThreeSpawnEnemy2RandomPoint();
        yield return new WaitForSeconds(2f);
        OneSpawnEnemy2RandomPoint();
        TwoSpawnEnemy3RandomPoint();
        ThreeSpawnEnemy2RandomPoint();
        yield return new WaitForSeconds(2f);
        OneSpawnEnemy2RandomPoint(); //1, 8 end
        TwoSpawnEnemy3RandomPoint();
        ThreeSpawnEnemy2RandomPoint();
        yield return new WaitForSeconds(2f);
        OneSpawnEnemy3RandomPoint();
        TwoSpawnEnemy3RandomPoint();
        ThreeSpawnEnemy2RandomPoint();
        yield return new WaitForSeconds(2f);
        OneSpawnEnemy3RandomPoint();
        TwoSpawnEnemy3RandomPoint(); //2, 5 end
        ThreeSpawnEnemy2RandomPoint();
        yield return new WaitForSeconds(2f);
        OneSpawnEnemy3RandomPoint();

        ThreeSpawnEnemy2RandomPoint();
        yield return new WaitForSeconds(2f);
        OneSpawnEnemy3RandomPoint();

        ThreeSpawnEnemy2RandomPoint();
        yield return new WaitForSeconds(2f);
        OneSpawnEnemy3RandomPoint(); //1, 5 end

        ThreeSpawnEnemy2RandomPoint(); //3, 10 end
        yield return new WaitForSeconds(2f);

        for (int i=0; i<3; i++)
        {
            ThreeSpawnEnemy3RandomPoint();
            yield return new WaitForSeconds(2f);
        }
       


        // 적의 수가 0 이하가 될 때까지 대기
        yield return new WaitUntil(() => totalEnemyCount <= 0);
        wavesEnd = true;
        stageClear.SetActive(true);
        yield return new WaitForSecondsRealtime(5f);
        Time.timeScale = 1;
        //엔딩 씬 연결하기
        SceneManager.LoadScene("Ending");
        stopCount = false;
        countdown = 15;
        waveIndex3++;
        WaveCountDownSlider.SetActive(true);



    }

    // 1번 구역
    public override void SpawnEnemy()
    {
        Instantiate(enemyPrefabFivestage1, spawnPoint.position, spawnPoint.rotation);


    }

    public void SpawnEnemyVerTwo()
    {
        Instantiate(enemyPrefabFivetage1ver2, spawnPoint.position, spawnPoint.rotation);
    }

    public override void SpawnEnemytwo()
    {
        Instantiate(enemyPrefabFivestage2, spawnPoint.position, spawnPoint.rotation);

    }


    void SpawnEnemythree()
    {
        Instantiate(enemyPrefabFivestage3, spawnPoint.position, spawnPoint.rotation);

    }


    //2번 구역
    void SpawnEnemyAnoPoint()
    {
        Instantiate(anoenemyPrefabFivestage1, spawnPoint2.position, spawnPoint2.rotation);
    }


    void SpawnEnemyAnoPointVerTwo()
    {
        Instantiate(anoenemyPrefabFivestage1ver2, spawnPoint2.position, spawnPoint2.rotation);
    }


    void SpawnEnemyAnoPointTwo()
    {
        Instantiate(anoenemyPrefabFivestage2, spawnPoint2.position, spawnPoint2.rotation);
    }


    void SpawnEnemyAnoPointThree()
    {
        Instantiate(anoenemyPrefabFivestage3, spawnPoint2.position, spawnPoint2.rotation);
    }

    //3번 구역
    void ThreeSpawnEnemyVerOne()
    {
        Instantiate(ano3enemyPrefabFivestage1, spawnPoint3.position, spawnPoint3.rotation);
    }


    void ThreeSpawnEnemyVerTwo()
    {
        Instantiate(ano3enemyPrefabFivestage1ver2, spawnPoint3.position, spawnPoint3.rotation);
    }


    void ThreeSpawnEnemyAnoPointTwo()
    {
        Instantiate(ano3enemyPrefabFivestage2, spawnPoint3.position, spawnPoint3.rotation);
    }


    void ThreeSpawnEnemyAnoPointThree()
    {
        Instantiate(ano3enemyPrefabFivestage3, spawnPoint3.position, spawnPoint3.rotation);
    }


    void OneSpawnEnemyRandomPoint() //1 구역 1번 적
    {
        int random = Random.Range(0, 2);
        Debug.Log(random);
        if(random == 0)
        {
            Instantiate(enemyPrefabFivestage1, spawnPoint.position, spawnPoint.rotation);
        }
        else if(random == 1)
        {
            Instantiate(random1enemyPrefabFivestage1, spawnPoint.position, spawnPoint.rotation);
        }
    }

    void OneSpawnEnemyRandomPointVer2() //1 구역 1-2
    {
        int random = Random.Range(0, 2);

        if (random == 0)
        {
            Instantiate(enemyPrefabFivetage1ver2, spawnPoint.position, spawnPoint.rotation);
        }
        else if (random == 1)
        {
            Instantiate(random1enemyPrefabFivestage1ver2, spawnPoint.position, spawnPoint.rotation);
        }
    }

    void OneSpawnEnemy2RandomPoint() //1 구역 2번 적
    {
        int random = Random.Range(0, 2);

        if (random == 0)
        {
            Instantiate(enemyPrefabFivestage2, spawnPoint.position, spawnPoint.rotation);
        }
        else if (random == 1)
        {
            Instantiate(random1enemyPrefabFivestage2, spawnPoint.position, spawnPoint.rotation);
        }

    }


    void OneSpawnEnemy3RandomPoint() //1 구역 3번 적
    {
        int random = Random.Range(0, 2);

        if (random == 0)
        {
            Instantiate(enemyPrefabFivestage3, spawnPoint.position, spawnPoint.rotation);
        }
        else if (random == 1)
        {
            Instantiate(random1enemyPrefabFivestage3, spawnPoint.position, spawnPoint.rotation);
        }

    }

    void TwoSpawnEnemyRandomPoint() //2 구역 1번 적
    { 

    int random = Random.Range(0, 2);

        if (random == 0)
        {
            Instantiate(anoenemyPrefabFivestage1, spawnPoint2.position, spawnPoint2.rotation);
        }
        else if (random == 1)
        {
            Instantiate(random2enemyPrefabFivestage1, spawnPoint2.position, spawnPoint2.rotation);
        }

    }
    void TwoSpawnEnemyRandomPointVer2() //2 구역 1-2
    {

        int random = Random.Range(0, 2);

        if (random == 0)
        {
            Instantiate(anoenemyPrefabFivestage1ver2, spawnPoint2.position, spawnPoint2.rotation);
        }
        else if (random == 1)
        {
            Instantiate(random2enemyPrefabFivestage1ver2, spawnPoint2.position, spawnPoint2.rotation);
        }

    }
    void TwoSpawnEnemy2RandomPoint() //2 구역 2번 적
    {

        int random = Random.Range(0, 2);

        if (random == 0)
        {
            Instantiate(anoenemyPrefabFivestage2, spawnPoint2.position, spawnPoint2.rotation);
        }
        else if (random == 1)
        {
            Instantiate(random2enemyPrefabFivestage2, spawnPoint2.position, spawnPoint2.rotation);
        }

    }


    void TwoSpawnEnemy3RandomPoint() //2 구역 3번 적
    {

        int random = Random.Range(0, 2);

        if (random == 0)
        {
            Instantiate(anoenemyPrefabFivestage3, spawnPoint2.position, spawnPoint2.rotation);
        }
        else if (random == 1)
        {
            Instantiate(random2enemyPrefabFivestage3, spawnPoint2.position, spawnPoint2.rotation);
        }

    }


    void ThreeSpawnEnemyRandomPoint() //3 구역 1번 적
    {

        int random = Random.Range(0, 2);

        if (random == 0)
        {
            Instantiate(ano3enemyPrefabFivestage1, spawnPoint3.position, spawnPoint3.rotation);
        }
        else if (random == 1)
        {
            Instantiate(random3enemyPrefabFivestage1, spawnPoint3.position, spawnPoint3.rotation);
        }

    }

    void ThreeSpawnEnemyRandomPointVer2() //3 구역 1-2
    {

        int random = Random.Range(0, 2);

        if (random == 0)
        {
            Instantiate(ano3enemyPrefabFivestage1ver2, spawnPoint3.position, spawnPoint3.rotation);
        }
        else if (random == 1)
        {
            Instantiate(random3enemyPrefabFivestage1ver2, spawnPoint3.position, spawnPoint3.rotation);
        }

    }

    void ThreeSpawnEnemy2RandomPoint() //3 구역 2번 적
    {

        int random = Random.Range(0, 2);

        if (random == 0)
        {
            Instantiate(ano3enemyPrefabFivestage2, spawnPoint3.position, spawnPoint3.rotation);
        }
        else if (random == 1)
        {
            Instantiate(random3enemyPrefabFivestage2, spawnPoint3.position, spawnPoint3.rotation);
        }

    }

    void ThreeSpawnEnemy3RandomPoint() //3 구역 3번 적
    {

        int random = Random.Range(0, 2);

        if (random == 0)
        {
            Instantiate(ano3enemyPrefabFivestage3, spawnPoint3.position, spawnPoint3.rotation);
        }
        else if (random == 1)
        {
            Instantiate(random3enemyPrefabFivestage3, spawnPoint3.position, spawnPoint3.rotation);
        }

    }


}
