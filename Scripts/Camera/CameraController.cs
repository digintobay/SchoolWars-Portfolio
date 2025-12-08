using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float xAxisSpeed = 150;
    [SerializeField]
    private float yAxisSpeed = 300;
 
   
    private float distance;
    private float xAxisLimitMin = -5;
    private float xAxisLimitMax = 30;
    private float x, y;

    private Vector3 motionPosition = new Vector3(0.55f, 1.26f, 0.29f);
    private Vector3 motionRotation = new Vector3(-30.5f, 6.311f, 1f);

    public Vector3 minBounds; // 카메라 이동 최소값
    public Vector3 maxBounds; // 카메라 이동 최대값

    [SerializeField] private LayerMask collisionMask; // 충돌 감지 레이어
    [SerializeField] private float minDistance = 1.0f; // 카메라 최소 거리
    [SerializeField] private float smoothSpeed = 10.0f; // 부드러운 이동 속도

    private void Awake()
    {
        distance = Vector3.Distance(transform.position, target.position);

        Vector3 angles = transform.eulerAngles;
        x = angles.x;
        y = angles.y;
    }

    private void Update()
    {
       
            UpdateRotate();
       
   
    }

    private void LateUpdate()
    {
        if (target == null) return;

        transform.position = target.position + transform.rotation * new Vector3(0, 0, -distance);
    }

    private void UpdateRotate()
    {
        x -= Input.GetAxis("Mouse Y") * xAxisSpeed * Time.deltaTime;
        y += Input.GetAxis("Mouse X") * yAxisSpeed * Time.deltaTime;

        x = ClampAngle(x, xAxisLimitMin, xAxisLimitMax);
  

        transform.rotation = Quaternion.Euler(x, y, 0);
    }

    private float ClampAngle(float angle,float min, float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }

 
    public void MotionCamera()
    {
        transform.position += motionPosition;
        transform.rotation *= Quaternion.Euler(motionRotation);
    }

}
