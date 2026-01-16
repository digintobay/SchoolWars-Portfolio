using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class OneStageWaveSpawner : MonoBehaviour
{
    public GameObject Siren;
    public GameObject SirenLight;
    public GameObject LineUI;
    //적 두 종류 
    public Transform enemyPrefab;
    public Transform enemyPrefab2;
    public Transform enemyPrefab3;

    // 적 관리 리스트
    public static int totalEnemyCount { get; set; } = 1;

    public Transform spawnPoint;


    public float countdown = 5f; //시작 시간

    public float timeBetweenWaves { get; set; } //정비 시간 
    public static bool dragnow { get; set; } // 정비 시간 드래그 관할
    public static bool startTimedragnow { get; set; } //시작 시간 드래그 관할
    public bool fixTime { get; set; }


    public TextMeshProUGUI stageString; //스테이지 텍스트

    public GameObject FixTimeSlider; //정비 슬라이더
    public GameObject WaveCountDownSlider; //카운트다운 슬라이더

    public TextMeshProUGUI StageWaveCount; //1-1 등 스테이지 카운트
    public TextMeshProUGUI EnemyCount; // 적 수 카운트
    public TextMeshProUGUI GameOverCount; // 게임오버 카운트, 시작 시 늘 3


    //첫 번째 웨이브
    public int waveIndex = 5;
    //두 번째 웨이브
    public int waveIndex2 = 9;
    //세 번째 웨이브
    public int waveIndex3 = 15;

    public bool stopCount = false;
    public static bool fixIconOn { get; set; }

    public bool wavesEnd = false;
    public string gameOver = "Wave End";
    public string start = "스타트!";

    public static int gameOverCount { get; set; } = 3;

    [Header("스테이지 UI")]
    public GameObject stageClear;
    public GameObject stageFaild;

    private void Awake()
    {
        countdown = 5f;
        gameOverCount = 3;
        fixTime = false;
        dragnow = false;
        fixIconOn = false;
        timeBetweenWaves = 0;
    }

    public virtual void Update()
    {
        GameOverCount.text = gameOverCount.ToString();

        // 게임 오버 카운트가 0이 될 시
        if (gameOverCount <= 0)
        {
            // 게임 오버 처리
            SceneChanger.OneStage = false;
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


        //1-1 웨이브

        if (waveIndex == 5 && stopCount == false) //웨이브가 끝나기 전, 카운트가 처음일 때
        {
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

        if (countdown <= 0f && stopCount == false && waveIndex == 5)
        {
            SirenLight.SetActive(false);
            stageString.text = "스테이지 1 - 1";
            WaveCountDownSlider.SetActive(false);
            EnemyCount.text = waveIndex.ToString(); //적 수만큼 유아이 표시
            StageWaveCount.text = "1 - 1";
            StartCoroutine(SpawnWave01());

        }


        //1-2 웨이브

        if (waveIndex2 == 9 && waveIndex == 6 && stopCount == false) //2 웨이브가 끝나기 전, 카운트가 처음일 때
        {
            StageWaveCount.text = "1 - 2";
            stageString.text = "스테이지 1 - 2";
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

        if (countdown <= 0f && stopCount == false && waveIndex == 6) //카운트가 끝났고, 1-1 웨이브도 끝났을 때
        {
            SirenLight.SetActive(false);
            stageString.text = "스테이지 1 - 2";
            WaveCountDownSlider.SetActive(false);
            EnemyCount.text = waveIndex2.ToString();
            StageWaveCount.text = "1 - 2";
            StartCoroutine(SpawnWave02());

        }


        //1-3 웨이브

        if (waveIndex3 == 15 && waveIndex2 == 10 && stopCount == false)
        {
            StageWaveCount.text = "1 - 3";
            stageString.text = "스테이지 1 - 3";
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

        if (countdown <= 0f && stopCount == false && waveIndex2 == 10)
        {
            SirenLight.SetActive(false);
            stageString.text = "스테이지 1 - 3";
            WaveCountDownSlider.SetActive(false);
            EnemyCount.text = waveIndex3.ToString();
            StageWaveCount.text = "1 - 3";
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


    //스테이지 실패 코루틴
    public IEnumerator Faild()
    {
        stageFaild.SetActive(true);
        yield return new WaitForSecondsRealtime(5f);
        Time.timeScale = 1;
        SceneManager.LoadScene("Upbringing");

    }

    //첫 번째 웨이브
    public virtual IEnumerator SpawnWave01()
    {
        LineUI.SetActive(false);
        stopCount = true;
        totalEnemyCount = 5;
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
        }

        // 적의 수가 0 이하가 될 때까지 대기
        yield return new WaitUntil(() => totalEnemyCount <= 0);

        fixIconOn = true;
        timeBetweenWaves = 10f;
        LineUI.SetActive(true);
        yield return new WaitForSeconds(10f);
        fixIconOn = false;
        stopCount = false;
        countdown = 5;
        waveIndex++;
        WaveCountDownSlider.SetActive(true);


    }

    //두 번째 웨이브
    public virtual IEnumerator SpawnWave02()
    {
        LineUI.SetActive(false);
        stopCount = true;
        totalEnemyCount = 9;
        for (int i = 0; i < waveIndex2 / 2; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(1f);
            SpawnEnemytwo();
            yield return new WaitForSeconds(1f);
        }
        SpawnEnemy();

        // 적의 수가 0 이하가 될 때까지 대기
        yield return new WaitUntil(() => totalEnemyCount <= 0);

        fixIconOn = true;
        timeBetweenWaves = 10f;
        LineUI.SetActive(true);
        yield return new WaitForSeconds(10f);
        fixIconOn = false;
        stopCount = false;
        countdown = 5;
        waveIndex2++;
        WaveCountDownSlider.SetActive(true);

    }

    //세 번째 웨이브
    public virtual IEnumerator SpawnWave03()
    {
        LineUI.SetActive(false);
        stopCount = true;
        totalEnemyCount = 15;
        for (int i = 0; i < (int)13 / 2; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(1f);
            SpawnEnemytwo();
            yield return new WaitForSeconds(1f);
        }
        SpawnEnemy();
        yield return new WaitForSeconds(1f);
        SpawnEnemyThree();
        yield return new WaitForSeconds(1f);
        SpawnEnemyThree();

        // 적의 수가 0 이하가 될 때까지 대기
        yield return new WaitUntil(() => totalEnemyCount <= 0);

        wavesEnd = true;


        Money.Upbringingmoney += 3000; // 클리어 보상
        Money.money = 5; // 디펜스 머니 초기화
        stageClear.SetActive(true );
        yield return new WaitForSecondsRealtime(5f);
        Time.timeScale = 1;
        SceneManager.LoadScene("Upbringing");

        stopCount = false;
        countdown = 15;
        waveIndex3++;
        WaveCountDownSlider.SetActive(true);



    }

    public virtual void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);


    }

    public virtual void SpawnEnemytwo()
    {
        Instantiate(enemyPrefab2, spawnPoint.position, spawnPoint.rotation);

    }

    private void SpawnEnemyThree()
    {
        Instantiate(enemyPrefab3, spawnPoint.position, spawnPoint.rotation);
    }
}
