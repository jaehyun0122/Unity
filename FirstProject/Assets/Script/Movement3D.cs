using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3D : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5.0f; // 이동속도
    private Vector3 moveDirection; // 이동방향
    private float gravity = -9.81f; // 중력 계수
    private float jumpForce = 3.0f;

    [SerializeField] 
    private Transform cameraTransform;
    private CharacterController characterController;

    private void Awake(){
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (characterController.isGrounded == false) // 그라운드에서 떠있을때
        {
            moveDirection.y += gravity * Time.deltaTime;
        }
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }

    public void MoveTo(Vector3 direction){
        // moveDirection = direction;
        // 중력작용하기 위해 x,z 값은 사용하고 y값은 Update함수의 중력에 의해 변하는 값 사용
        Vector3 movedis = cameraTransform.rotation * direction;
        moveDirection = new Vector3(movedis.x, moveDirection.y, movedis.z);
    }

    public void JumTo()
    {
        if (characterController.isGrounded == true)
        {
            moveDirection.y = jumpForce;
        }
    }
}
