using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Movement3D movement3D;

    [SerializeField] 
    private CameraController cameraController;

    private KeyCode jumpKeyCode = KeyCode.Space;
    
    private void Awake(){
        movement3D = GetComponent<Movement3D>();
    }

    private void Update(){
        // x,y 방향 이동
        float x = Input.GetAxisRaw("Horizontal"); // 방향키 좌/우 움직임
        float z = Input.GetAxisRaw("Vertical"); // 방향키 위/아래 움직임

        movement3D.MoveTo(new Vector3(x,0,z));

        // spacebar key로 점프
        if (Input.GetKey(jumpKeyCode))
        {
            movement3D.JumTo();
        }

        float mouseX = Input.GetAxis("Mouse X"); // 마우스 좌우 움직임. 좌 : -1 대기 : 0 우 : 1
        float mouseY = Input.GetAxis("Mouse Y"); // 마우스 위아래 움직임. 아래 : -1 대기 0 위 : 1
        
        cameraController.RotateTo(mouseX, mouseY);
    }
}
