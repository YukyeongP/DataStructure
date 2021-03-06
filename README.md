# DataStructure
Stack
- 순서가 보존되는 선형 데이터 구조 유형
- LIFO: 가장 마지막 요소부터 처리 ex) 쌓여있는 접시 더미
- 시간복잡도: 값가져오기 O(n) + 추가하기 O(1) + 삭제하기 O(1)
- 장점: 동적인 메모리 크기, 데이터 받는 순서대로 정렬, 빠른 런타임
- 단점: 가장 최신 요소만 가져옴, 한번에 하나의 데이터만 처리 가능
- 사용: 가장 마지막으로 입력된 것을 순차적으로 바로 처리하고 싶을 때,
브라우저의 뒤로가기, 실행 취소, 재귀
- Push, Pop

Queue
- 스택과 비슷
- FIFO: 가장 먼저 입력된 요소부터 처리 ex) 놀이공원 대기라인
- 시간복잡도: 값가져오기 O(n) + 추가하기 O(1) + 삭제하기 O(1)
- 장점: 동적인 메모리 크기, 데이터 받는 순서대로 정렬, 빠른 런타임
- 단점: 가장 오래된 요소만 가져옴, 한번에 하나의 데이터만 처리 가능
- 사용: 반복적이고 자주 받는 데이터를 비동기적으로 처리할 때 효율적,
순서에 민감한 데이터 처리, 프린터 대기열, 캐시구현
- Enqueue, Dequeue, Back, Front
