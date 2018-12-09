# ReoGrid

엑셀 호환 라이브러리이다. 분석이 쉽지는 않겠으나 많은 사람들이 활발하게 보고 있어 도전한다. WPF, WinForm, Android 모두 지원한다. 대단하다. 



# 목표 

- Excel like HCSV editing
- each cell can be a sheet
  - inplace popup editing
  - display as array or sheet

나머지는 에디터가 동작하면 차근차근 해나가면 된다. 



# 빌드 

실행 분석이 안 되면 파악하기 어렵다. 

https://reogrid.net/editor/

빌드가 잘 안 되어 코드를 살펴본다. 어떻게 접근해야 할 지 생각한다. 데모를 보면 대단히 훌륭한 기능이 많다. 스크립트 언어까지 만들었으니 매우 잘 하는 사람이다. 코드를 보는 것만으로도 많이 배울 수 있어 보인다. 



# 분류

- Android
- Chart
- Common
  - ActionManager
    - 동작 실행
    - IAction / ActionBehavior (Do / Undo / Redo)
    - undo / redo
  - win32.cs
    - 많은 API wrapping
    - 일본인의 정성
  - Logger
  - ResourcePoolManager
    - 재사용 가능한 자원 풀
    - 캐시에서 돌려주는데 반환 기능은 안 보인다.
    - 그냥 쌓이는 구조면 문제가 될 수도 있지만 실제로는 괜찮은가 보다. 
- Control 
  - ReoGridControl의 ControlShare.cs
    - 1485 라인. 
  - Interfaces
    - 많은 인터페이스를 포함
    - IActionControl
    - IScrollableWorksheetContainer
    - 인터페이스만을 대상으로 시스템을 구조화하기 어려울텐데,
  - 
- Core
- Data
- Drawing
- Formula
- Graphics
- Interaction
- IO
- iOS
- Print
- Rendering
- Resources
- Script
- Test
- Utility 
- Views
- WinForm
- WPF
- Zip



좋긴한데 좀 크다. 서버 프로그래머에서 GUI를 사용하는 프로그래머로 바뀌고 빠르게 뭔가를 만들려면 다른 훈련이 필요하다. 





















