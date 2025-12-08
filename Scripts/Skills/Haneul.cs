using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haneul : MonoBehaviour
{
    [SerializeField]
    private GameObject basicAttackCollision;
    [SerializeField]
    private GameObject skillDamageCollision;
    private Animator anim;


    [Header("사운드")]
    public AudioClip attackSFX;
    public AudioClip skillSFX;

    [SerializeField]
    private GameObject enemycheckCollider;

    [Header("AttackEffectPrefabs")]
    public GameObject attackEffect;
    public GameObject attackEffect2;
    public GameObject attackEffect3;
    public GameObject skillAttackEffect;
    public GameObject skillAttackEffect2;
    public GameObject skillAttackEffect3;
    public GameObject skillAttackEffect4;


    [Header("UIObject")]
    [SerializeField] private GameObject imagePrefab; // UI 이미지 프리팹
    private GameObject canvas; // Canvas 객체를 동적으로 검색

    [SerializeField]
    public static bool haneulSkill { get; set; } = false;

    public void Awake()
    {

        anim = GetComponent<Animator>();

        // 하늘 어택 스피드 가져오기
        anim.SetFloat("AttackSpeed", SkillManager.haneulAttackSpeed);

        canvas = GameObject.Find("SkillCanvas");

    }


    private void Update()
    {
        if (enemycheckCollider.GetComponent<EnemyCheckCollider>().ColliderCheck == false)
        {
            StopAllCoroutines();
        }
        else if (enemycheckCollider.GetComponent<EnemyCheckCollider>().ColliderCheck == true)
        {

            StartCoroutine(AttackLoofTime());
        }

        if (haneulSkill == true)
        {
            StartCoroutine(SkillTime());
        }
    }

    public void AttackSound()
    {
        SoundManager.instance.SFXPlay("attackSFX", attackSFX);
    }

    public void SkillSound()
    {
        SoundManager.instance.SFXPlay("skillSFX", skillSFX);
    }

    IEnumerator SkillTime()
    {
        // 스킬 사용 상태 초기화
        haneulSkill = false;

        if (canvas == null)
        {
            Debug.LogWarning("Canvas 객체가 없습니다. UI를 표시할 수 없습니다.");
            yield break;
        }


        // UI 이미지 프리팹 인스턴스 생성 및 Canvas에 추가
        GameObject uiInstance = Instantiate(imagePrefab, canvas.transform);

        // 스킬 애니메이션 트리거
        anim.SetTrigger("SkillAttack");


    }

    IEnumerator AttackLoofTime()
    {

        anim.SetTrigger("Attack");
        yield return new WaitForSeconds(1f);


    }

    public void OnBasicAttackCollision()
    {
        basicAttackCollision.SetActive(true);
    }

    public void OnBasicAttackEffectOn()
    {
        attackEffect.SetActive(true);
    }
    public void OnBasicAttackEffectOn2()
    {
        attackEffect2.SetActive(true);
    }
    public void OnBasicAttackEffectOn3()
    {
        attackEffect3.SetActive(true);
    }




    public void OnSkillAttackCollision()
    {
        skillDamageCollision.SetActive(true);
    }


    public void OnSkillAttackEffectOn()
    {
        skillAttackEffect.SetActive(true);
    }
    public void OnSkillAttackEffectOn2()
    {
        skillAttackEffect2.SetActive(true);
    }
    public void OnSkillAttackEffectOn3()
    {
        skillAttackEffect3.SetActive(true);
    }
    public void OnSkillAttackEffectOn4()
    {
        skillAttackEffect4.SetActive(true);
    }

}
