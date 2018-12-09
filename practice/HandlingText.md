# handling text



## console

콘솔처럼 텍스트를 출력한다.  폰트 지정, 컬러 설정을 할 수 있다. 이런 것들을 GUI로 한다. 명령어를 입력하면 결과를 창에 출력한다. 스크롤 된다. 확대 / 축소가 가능하다. 



### 방법 1. TextBlock을 사용하는 방법 

https://www.dotnetperls.com/textblock-wpf

WPF는 어마어마 하다. 기능이 대단히 많다. 라이브 시각적 트리. 이런 기능도 있다. 디버깅 하면서 시각적 트리 구성을 볼 수 있다. 이런 기능을 활용하여 서버를 자세히 들여다 볼 수 있도록 한다. 

### 방법 2. RichTextBox

```xaml
<Window x:Class="HandlingText.Console"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:HandlingText"
        mc:Ignorable="d"
        Title="Console" Height="372" Width="594">
    <Grid>
        <RichTextBox Margin="10">
            <FlowDocument>
                <Paragraph FontSize="12">Hello, world!</Paragraph>
            </FlowDocument>
        </RichTextBox>
    </Grid>
</Window>
```

그냥 바로 된다. 훌륭하다.  FlowDocument, Paragrah로 편집도 가능하다. 

## reogrid

https://reogrid.net

이쪽에도 또 위대한 분들이 계시다. excel과 거의 호환되는 수준의 에디터 컴포넌트이다. 소스가 있으니 파헤쳐서 본다. 

##  spreadsheetlight 

http://spreadsheetlight.com/

빌드 프로젝트가 없긴 하지만 XLSX 파일 편집이 가능한 라이브러리이다. 







































