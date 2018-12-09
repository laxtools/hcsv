# 페졸드 WPF

읽으면서 정리한다. 일일이 해보기에는 양이 너무 많다. 중요 개념을 정리한다. 



# 2장. 브러시 

RGB, ScRgb 

```
Object
	DispatcherObject 
		DependencyObject
			Freezable
				Animatable
					Brush
						GradientBrush
							LinearGradientBrush
							RadialGradientBrush
                      	SolidColorBrush
                      	TileBrush
                      		DrawingBrush
                      		ImageBrush
                      		VisualBrush
```

상속계층으로 속성과 행동을 구조화한다. 이는 고정된 개념과 관계를 형성하는 경우 유용한 설계이다. 

```c#
Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
```

SolidColorBrush.Color 속성으로 색상을 변경할 수 있다. 

LinearGradientBrush

- StartPoint / EndPoint
- GradientStop



System.Windows.Threading.DispatcherTimer



## 연습 

RotateTheGradientOrigin.cs

RadialGradientBrush에 애니메이션을 주는 프로그램이다. 



# 3장. 컨텐트

Window.Content Property

```
Control
	ContentControl
		Window
```



- FontFamily
- FontSize



ContentControl.Content 속성에는 거의 모든 것을 지정할 수 있다. (윈도우만 제외된다). 

```
Object
	DispatcherObject
		DependencyObject
			Visual 
				UIElement
					FrameworkElement
						Image
```

UIElement는 키보드, 마우스 등 입력 처리와 OnRender 함수를 갖는다. 



```
UIElement
	FrameworkElement
		Shape
			Ellipse
			Line
			Path
			Polygon
			Polyline
```



Stroke 개념. Brush로 지정한다. 

WPF의 View-Model

```
DependencyObject
	ContentELement
		FrameworkContentELement
		TextElement
		Inline
			Run
			Span
				Bold
				Hyperlink
				Italic
				Underline
```

거의 그려질 수 있는 정보를 포함하지만 그리는 기능은 분리한다.

텍스트 처리에서 Run과 Span은 흥미로운 개념이다. 



## 연습

텍스트 출력. TextBlock을 통해 다양한 폰트와 색상을 갖는 문자열을 출력한다. 

가능하면 텍스트 파일 reader를 만든다. 



# 4장. 버튼과 콘트롤

```
UIElement
	FrameworkElement
		Control
```

Button

```
Control
	ContentControl
		ButtonBase
			Button
		Window
```



```C#
btn.Focus();
btn.IsDefault = true;
btn.IsCancel = true;
```

- ClickMode
- Margin
- HorizontalContentAlignment
- VerticalContentAlignment
- Padding
- Width
- Height
- SizeToContent
- FontSize
- FontFamily
- Background
- Foreground
- BorderBrush



Content로 TextBlock을 지정하는 예이다. 

```c#
Button btn = new Button(); 
...
TextBlock txtblk = new TextBlock();
txtblk.FontSize = 24; 
txtblk.TextAlignment = TextAlighnment.Center;

txtblk.Inlines.Add(new Italic(new Run("Click"))); 
txtblk.Inlines.Add(" the ");
txtblk.Inlines.Add(runButton = new Run("button"));
// ...

```

Run으로 버튼이 실제 추가되는 지 확인이 필요하다. 



Commands:

- ApplicationCommands
- ComponentCommands
- MediaCommands
- NavigationCommands
- EditingCommands
- RoutedUICommand



UIElement는 CommandBindings란 속성이 있다.

```C#
CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, PasteOnExecute, PasteCanExecute));
```



```
ButtonBase
	Button
		GridViewColumnHeader
		RepeatButton
		ToggleButton
			CheckBox
			RadioButton
```

Checkbox가 SetBinding을 통해 지정될 수 있다.  View와 데이터를 연결하는 방법이다. 표시가 없더라도 이런 연결은 패턴으로 많이 나온다. 

```
Control
	TextBoxBase 
		TextBox
		RichTextBox
```













































