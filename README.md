# 7주차 개인 과제 <ItemExpoler>

## ⏰개발기간
- 기획 기간 :: 23.12.27 게임의 전체 기획
- 1차 개발 기간 :: 23.12.28 게임의 기본 시스템 구현
- 2차 개발 기간 :: 23.12.29 게임의 틀 재정립으로 재구현 (*바꾸면서 볼륨 예상 불가로 미완성)

## ✨게임 디자인
### 이 세계에 뭔가 이상한 것이 있습니다. 이상한 물건을 찾아주세요. 물건의 이미지와 설명이 맞지 않는 물건을 찾아야 합니다.
- 오브젝트에 상호작용을 하고, 그중 이상한 점을 찾아 인벤토리에 넣어 골인 지점에 들어가는 게임
- 도트 그래픽
- 시간 내에 얼마나 많은 아이템을 찾아 넣는지에 따라 결정
- 정답 아이템은 랜덤으로 등장

## 📌주요 기능
- 게임 시작, 게임 플레이화면, 결과창 총 3개의 씬으로 구분
- 캐릭터를 좌우상하 키보드 입력으로 이동 (wasd,화살표 방향키)
- 캐릭터가 움직임에 따라 스프라이트 변경
- 나무 프리팹에 출력할 랜덤 ID 값 부여
  
## 🛠구현할 목록
- 나무 프리팹 랜덤 배치
- ID마다 세팅값 지정
- 정답 오브젝트 갯수 제한 (ex) 한개의 나무에 정답 ID가 배정되면 다른 프리팹에는 해당 아이디 배정 불가
- 점수 계산법
- GameManager 추가

