using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private SkinnedMeshRenderer meshRenderer;
    private Color[] originColors; // 컬러 배열
    private EnemyCheckCollider triggerHandler;


    [SerializeField]
    public int enemyHealth;

    private float maxHealth;   // 최대 체력
    private float currentHealth; // 현재 체력 복사본
    private GameObject healthBarInstance; // 체력바 인스턴스

    public GameObject healthBarPrefab;   // 체력바 프리팹
    private Transform Canvas;   // 체력바가 붙을 월드 캔버스

    private void Awake()
    {
       
        meshRenderer = GetComponent<SkinnedMeshRenderer>();

        // 모든 메터리얼의 원래 색상을 저장
        originColors = new Color[meshRenderer.materials.Length];
        for (int i = 0; i < meshRenderer.materials.Length; i++)
        {
            originColors[i] = meshRenderer.materials[i].GetColor("_BaseColor");
        }

    }

    public virtual void CountHealth()
    {
        enemyHealth = 0;
    }

    public void Start()
    {
        CountHealth();
        maxHealth = enemyHealth;
        currentHealth=enemyHealth;
        // 월드 캔버스 찾기
        Canvas = GameObject.Find("WorldCan").transform;

        // 체력바 생성
        if (healthBarPrefab != null && Canvas != null)
        {
            healthBarInstance = Instantiate(healthBarPrefab, Canvas);
            var healthBarController = healthBarInstance.GetComponent<HealthBarUI>();
            healthBarController.target = transform;
            healthBarController.offset = new Vector3(0, 8, 0); // 적 머리 위에 표시
        }
    }

    public virtual void Update()
    {
        if (enemyHealth <= 0)
        {   
            // 트리거 핸들러에 트리거 종료를 알림
            if (triggerHandler != null)
            {
                triggerHandler.HandleEnemyExit(GetComponent<Collider>());
            }
            Money.money += 1;
            // 스테이지별 점수 넣어 주기
            Destroy(gameObject);
        }

    }

    public virtual void OnTriggerEnter(Collider other)
    {
        // 적이 부딪힌 오브젝트가 트리거 핸들러를 가지고 있는지 확인
        if (other.TryGetComponent<EnemyCheckCollider>(out EnemyCheckCollider foundHandler))
        {
            triggerHandler = foundHandler;
        }

      
    }


    public void TakeDamage(int  damage)
    {
        Debug.Log(damage + "의 체력이 감소");
        enemyHealth-= damage;
        currentHealth-=damage;
        StartCoroutine(OnHitColor());

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        // 체력바 업데이트
        if (healthBarInstance != null)
        {
            Debug.Log("체력바 업데이트");
            var healthBarController = healthBarInstance.GetComponent<HealthBarUI>();
            healthBarController.SetHealth(currentHealth, maxHealth);
        }

    }

    private IEnumerator OnHitColor()
    {

        // 모든 메터리얼의 색상을 빨간색으로 변경
        foreach (var material in meshRenderer.materials)
        {
            material.SetColor("_BaseColor", Color.red);
        }

        yield return new WaitForSeconds(0.2f);

        // 모든 메터리얼의 색상을 원래 색상으로 복구
        for (int i = 0; i < meshRenderer.materials.Length; i++)
        {
            meshRenderer.materials[i].SetColor("_BaseColor", originColors[i]);
        }
    }

    void OnDestroy()
    {
        // 적이 제거될 때 체력바도 제거
        if (healthBarInstance != null)
        {
            Destroy(healthBarInstance);
        }
    }
}



