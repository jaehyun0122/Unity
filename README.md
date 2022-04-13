# Unity 학습

출처 : 고박사 https://www.inflearn.com/course/%EA%B3%A0%EB%B0%95%EC%82%AC-%EC%9C%A0%EB%8B%88%ED%8B%B0-%EA%B8%B0%EC%B4%88/lecture/48468?tab=curriculum&q=298061

## 1. Material을 객체에 적용하기

![Materials설정을 객체에 적용](C:\Users\multicampus\Desktop\github\Unity\Asset\Materials설정을 객체에 적용.PNG)



## 2. CharacterController

![CharacterController_slope_step](C:\Users\multicampus\Desktop\github\Unity\Asset\CharacterController_slope_step.PNG)

위 두가지 변수를 활용해 경사면이나 계단을 올라갈 때 특정값 초과는 이동 불가능하게 할 수 있다.



## 3. 3D Model

1. Rigging

모델의 뼈대를 만들거나 할당

모델이 애니메이션 될 수 있는 상태로 만듬



2. Animation Type

- None : 애니메이션이 없을 때(지형, 건물, 아이템 등)
- Legacy : Unity 3.x 이전 버전에서 사용(Animation Component)
- Generic : 정점 애니메이션
- Humanoid : 본 애니메이션



![상태전이](C:\Users\multicampus\Desktop\github\Unity\Asset\상태전이.PNG)

#### Parameters : 해당 Animator Controller에 귀속된 변수들

상태전이의 Conditions List에 등록해 애니메이션 전환을 위한 조건으로 사용

- float
- int
- bool
- Trigger : on/off (on 상태에서 1회 실행되면 자동으로 off됨)

![conditions](C:\Users\multicampus\Desktop\github\Unity\Asset\conditions.PNG)
=> conditions설정을 통해 해당 값 greater or less로 값에 따라 전환

![condition전이](C:\Users\multicampus\Desktop\github\Unity\Asset\condition전이.gif)

## 4. Animation Layer, Blend Tree

weight : 가중치를 설정해 합성하는 정도 선택

mask : 현재 레이어에서 사용할 Avatar mask

blending : 앞 순서의 애니메이션 계산에 덮어쓸 것인지 가산할 것인지

sync : 다른 레이어와의 동기화 설정

ik pass : ik 애니메이션 사용여부



#### 운동학

- 순방향 : 몸안쪽에서 바깥으로(몸->어깨->팔->손)
- 역방향 : 몸바깥에서 안쪽(손->팔->어깨->몸)