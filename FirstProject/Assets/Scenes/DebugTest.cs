using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    // Awake 함수는 실행 초기 한번만 동작
    private void Awake(){
        Debug.Log("Awake function call!!");     
    }

    // Start 함수는 컴포넌트가 활성화 되있을 때 실행
    private void Start(){
        Debug.Log("start function call");
    }

    // OnEnable 함수는 컴포넌트가 비활성화 => 활성화 될 때 실행
    private void OnEnable(){
        Debug.Log("OnEnable function call");
    }

    // update 함수 호출 순서 : Update() => LateUpdate()
    // 플레이어와 카메라 두가지 오브젝트가 존재할 때
    // 플레이어를 따라가는 카메라 구현 
    // => 플레이어를 Update로 동작한 후 LateUpdate()를 이용해 플레이어 위치기반으로 카메라가 따라가도록.

    // Update
    private void Update(){
        Debug.Log("update call");
    }
    // LateUpdate
    private void LateUpdate(){
        Debug.Log("Lateupdate call");
    }

    // OnDestroy : 

    // OnApplicationQuit : 종료시 한번 실행
    private void OnApplicationQuit(){
        Debug.Log("OnApplicationQuit call");
    }

    // OnDisable : 컴포넌트가 활성화 => 비활성화 될 때 마다 1회 호출. OnEnable 반대
    private void OnDisable(){
        Debug.Log("OnDisable call");
    }
}
