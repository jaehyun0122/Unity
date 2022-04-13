using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float rotateSpeedX = 3;
    private float rotateSpeedY = 5;
    private float limitMinX = -80;
    private float limitMaxX = 50;
    private float eulerAngleX;
    private float eulerAngleY;


    public void RotateTo(float mouseX, float mouseY)
    {
        // 마우스를 좌우로 움직이는 mouseX 값을 y축에 대입하는 이유
        // 마우스를 좌우로 움직일 때 카메라도 좌우를 보려면 카메라 객체의 y축이 회전되야하므로
        eulerAngleY += mouseX* rotateSpeedX;
        eulerAngleY -= mouseY * rotateSpeedY; // 여기서 -인 이유는 마우스의 이동은 아래가 양수, 위가 음수 이므로

        eulerAngleX = ClampAngle(eulerAngleX, limitMinX, limitMaxX);
        
        // 실제 객체의 쿼터니온 회전에 적용
        transform.rotation = Quaternion.Euler(eulerAngleX, eulerAngleY,0);
    }

    private float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;
        
        // Mathf.Clamp()를 이용해 angle이 min <= angle <= max를 유지
        return Mathf.Clamp(angle, min, max);
    }
}
