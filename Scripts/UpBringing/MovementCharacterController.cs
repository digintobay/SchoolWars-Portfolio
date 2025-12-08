using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class MovementCharacterController : MonoBehaviour
{
    public static bool allowcontroll { get; set; }
    public GameObject CameraController;

  
    [SerializeField]
    private float walkSpeed = 2.0f; //걷기 속도
    [SerializeField]
    private float runSpeed = 5.0f; //뛰기 속도

    [SerializeField]
    public float moveSpeed = 5.0f; //이속
    [SerializeField]
    private float gravity = -9.81f; //중력 계수
    [SerializeField]
    private float jumpForce = 3.0f; // 점프 힘
    private Vector3 moveDirection = Vector3.zero; //이동 방향

    [SerializeField]
    private Transform mainCamera;
    private CharacterController characterController;
    private Animator animator;

    public AudioClip walkSound;
    public AudioClip walkSound2;

    private void Awake()
    {
        allowcontroll = true;
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (allowcontroll == true)
        {   
            Cursor.visible = false;
            //x, y축 이동
            Movement();

            // y축 이동 (중력, 점프) 
            GravityAndJump();


            characterController.Move(moveDirection * moveSpeed * Time.deltaTime);

            //카메라 전방 방향 설정
            transform.rotation = Quaternion.Euler(0, mainCamera.eulerAngles.y, 0);

        }
        else
        {
            Cursor.visible = true;
            animator.SetFloat("moveSpeed", 0);
            return;
        }

      

        if (Input.GetButton("Sprint"))
        {
            animator.SetFloat("motionSpeed", 2f);
        }
        else
        {
            animator.SetFloat("motionSpeed", 1);
        }

    }

    /* private void Attack()
    {
        if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject()) return;
        if(Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("onAttack");
        }
    }*/

    private void Movement()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        if (x != 0 || z != 0)
        {
            animator.SetFloat("moveSpeed", 1);
        }
        else animator.SetFloat("moveSpeed", 0);

        //오브젝트 이동 속도 설정
        moveSpeed = Mathf.Lerp(walkSpeed, runSpeed, Input.GetAxis("Sprint"));


        //Shift키를 누르지 않으면 0.5, 누르면 
        float offset = 0.5f + Input.GetAxis("Sprint") * 0.5f;



        //moveDirection = new Vector3(x, moveDirection.y, z);
        Vector3 dir = mainCamera.rotation * new Vector3(x, 0, z);
        moveDirection = new Vector3(dir.x, moveDirection.y, dir.z);


    }

    public void WalkSound()
    {
        SoundManager.instance.SFXPlay("Walk", walkSound);
    }

    public void WalkSoundTwo()
    {
        SoundManager.instance.SFXPlay("Walk2", walkSound2);
    }

    private void GravityAndJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && characterController.isGrounded == true)
        {
          
            moveDirection.y = jumpForce;
        }

        //플레이어가 땅을 밟고 있지 않으면 (점프 시)
        //y축 방향 중력 변수에 시간을 곱한다
        if (characterController.isGrounded == false)
        {
            moveDirection.y += gravity * Time.deltaTime;
        }

    }

 
}
