using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class TutorialStageWaveSpawner : OneStageWaveSpawner
{
    public GameObject tutorialPad;
    public TextMeshProUGUI tutorialText;

    public bool tutoOne = false;
    public bool tutoTwo = false;
    public bool tutoThree = false;
    public bool tutoCheck = false;

    public override void Update()
    {
        GameOverCount.text = gameOverCount.ToString();

        // 게임 오버 카운트가 0이 될 시
        if (gameOverCount <= 0)
        {
            // 게임 오버 처리
            SceneChanger.OneStage = false;
            Money.money = 5; // 디펜스 머니 초기화
            StartCoroutine(ThisFaild());


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

        if (waveIndex == 5 && stopCount == false ) //웨이브가 끝나기 전, 카운트가 처음일 때
        {
            SirenLight.SetActive(true);
            LineUI.SetActive(true);

            if (tutoOne==false && tutoCheck == false)
            {
                tutoCheck = true;
                //튜토리얼 시작
                StartCoroutine(TutorialEnemyLine());

            }
       

            if (tutoOne == true)
            {
                countdown -= Time.deltaTime;
            }

            if (tutoThree == true)
            {
                countdown -= Time.deltaTime;
            }



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

        if (countdown <= 0f && stopCount == false && waveIndex == 6) //카운트가 끝났고, 1-2 웨이브도 끝났을 때
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
        if (fixIconOn == true && tutoThree==true)
        {

            FixTimeSlider.SetActive(true);
            timeBetweenWaves -= Time.deltaTime;

        }
        else FixTimeSlider.SetActive(false);


    }


    //스테이지 실패 코루틴
    public IEnumerator ThisFaild()
    {
        stageFaild.SetActive(true);
        yield return new WaitForSecondsRealtime(5f);
        Time.timeScale = 1;
        SceneManager.LoadScene("TutorialStage");

    }

    public IEnumerator TutorialEnemyLine()
    {
        tutorialPad.SetActive(true);
        tutorialText.text = "다른 학교와의 전투 전, 학생 들의 동선을 먼저 확인 할 수 있어.";
        yield return new WaitForSeconds(2.5f);
        tutorialText.text = "<color=red>붉은</color> 지역이 학생들이 들어오는 입구이고, \r\n<color=blue>푸른</color> 지역이 우리 학교와 이어지는 통로라고 생각하면 돼.";
        yield return new WaitForSeconds(3f);
        tutorialText.text = "학생들이 우리 학교에 들어오지 못하도록 막고, 쫓아내야 해.";
        yield return new WaitForSeconds(2.5f);
        tutorialText.text = "<color=red>3</color>명 이상의 학생이 우리 학교로 들어가게 되면 \r\n우리가 전투에서 패배하여 지원금을 뺏기게 되니까 조심하자.";
        yield return new WaitForSeconds(3f);
        StartCoroutine(TutorialCharacterBuild());


    }

    public IEnumerator TutorialCharacterBuild()
    {
        tutorialPad.SetActive(true);
        tutorialText.text = "곧 몰려올 학생들을 막기 위해 우리 학생회 임원들을 배치해보자.\r\n모든 임원은 한 명씩만 배치 가능해.";
        yield return new WaitForSeconds(3f);
        tutorialText.text = "우측 하단 V 버튼에 마우스를 올리면 배치 가능한 학생회 임원들이 보일거야.";
        yield return new WaitForSeconds(4f);
        tutorialText.text = "각 임원들을 배치하려면 재화가 필요해. 다른 학교 학생들을 처치하면 재화를 얻을 수 있어.";
        yield return new WaitForSeconds(2.5f);
        tutorialText.text = "일단, 기본 재화가 주어지니까 김소민을 클릭해 배치해보자.";
        yield return new WaitForSeconds(4f);
        tutorialText.text = "설치 시 앞에 보이는 노란색의 타일은 해당 임원의 공격 범위야. ";
        yield return new WaitForSeconds(3f);
        tutorialText.text = "배치 후 5초 동안 임원을 회전시켜 공격하고자 하는 방향을 정할 수 있어.";
        yield return new WaitForSeconds(2.5f);
        tutorialText.text = "참! 재화만 있다면, 게임 플레이 중에도 임원 배치가 가능해.";
        yield return new WaitForSeconds(2.5f);

        tutorialPad.SetActive(false);
        tutoOne = true;
        tutoTwo = true;

        StartCoroutine(SpawnWave01());
    }

    public IEnumerator TutorialFixTime()
    {
        tutorialPad.SetActive(true);
        tutorialText.text = "축하해, 안전하게 학교를 지켰네.";
        yield return new WaitForSeconds(2.5f);
        tutorialText.text = "한 학교와의 전투는 총 3번 이루어져, 뒤로 갈수록 더 많은 학생들이 몰려오니까 대비하자.";
        yield return new WaitForSeconds(2.5f);
        tutorialText.text = "한 번의 전투가 끝날 때 10초 정도의 정비 시간을 주고 있어";
        yield return new WaitForSeconds(2.5f);
        tutorialText.text = "정비 시간에는 새로운 임원을 배치할 수 없어.";
        yield return new WaitForSeconds(2.5f);
        tutorialText.text = "현재 배치되어 있는 임원을 클릭하고, 새로운 입구 주변에 배치해보자.";
        yield return new WaitForSeconds(4f);
        tutorialText.text = "이렇게 임원들의 위치를 바꿔 새롭게 전략을 짜서 막을 수 있다는 걸 기억해 둬";
        yield return new WaitForSeconds(2.5f);
        tutorialText.text = "학생들이 몰려오기 5초 전에는\r\n<color=red>모든 임원이 회전</color>할 수 있어!";
        yield return new WaitForSeconds(3f);
        WaveCountDownSlider.SetActive(false);
        tutorialPad.SetActive(false);
        tutoThree = true;
        fixIconOn = true;
        timeBetweenWaves = 10f;
        yield return new WaitForSeconds(10f);
        LineUI.SetActive(true);
        waveIndex++;
        fixIconOn = false;
        stopCount = false;
        countdown = 5;
        WaveCountDownSlider.SetActive(true);
    }



    //첫 번째 웨이브
    public override IEnumerator SpawnWave01()
    {   
        //튜토 2까지 대기
        yield return new WaitUntil(() => tutoTwo == true);
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
        StartCoroutine(TutorialFixTime()); // 픽스타임 튜토리얼 시작



    }

    //두 번째 웨이브
    public override IEnumerator SpawnWave02()
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
    public override IEnumerator SpawnWave03()
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
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);


    }

    public override void SpawnEnemytwo()
    {
        Instantiate(enemyPrefab2, spawnPoint.position, spawnPoint.rotation);

    }
    private void SpawnEnemyThree()
    {
        Instantiate(enemyPrefab3, spawnPoint.position, spawnPoint.rotation);
    }
}
