   M S B A M L   `   `   `  ���� I  EMyStyle, Version=1.0.6578.23344, Culture=neutral, PublicKeyToken=nullW0clr-namespace:WpfStyleableWindow.StyleableWindow"WpfStyleableWindow.StyleableWindow  1clr-namespace:MyStyle.CommandMyStyle.Command  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089>    8WpfStyleableWindow.StyleableWindow.WindowMinimizeCommand   MinimizeCommand>   8WpfStyleableWindow.StyleableWindow.WindowMaximizeCommand  MaximizeCommand;   5WpfStyleableWindow.StyleableWindow.WindowCloseCommand  CloseCommand  WindowTemplate  �� 
TargetType+   %MyStyle.Command.MyCurrentStyleManager   BrushWindowGridBorder � RowDefinitions!   BrushWindowTitleBackground � ColumnDefinitions   ImageLidericon?   9WpfStyleableWindow.StyleableWindow.ShowSystemMenuBehavior   TargetWindow �� RelativeSource �� Mode	 �� AncestorType
   LeftButtonShowAt �� ElementName � Title   BrushWindowForegroundC   =WpfStyleableWindow.StyleableWindow.ControlDoubleClickBehavior   ExecuteCommand   RightButtonShow;   5WpfStyleableWindow.StyleableWindow.WindowDragBehavior   LeftMouseButtonDrag   ExecuteCommandParameter ��Name ��Name   BrushWindowBackground ��Name ��Name n�Name � Cursor J� Opacity=   7WpfStyleableWindow.StyleableWindow.WindowResizeBehavior   	TopResize   TopLeftResize   BottomResize   TopRightResize   RightResize   BottomRightResize    
LeftResize!   BottomLeftResize" �� Triggers# ]� 
Conditions$ �� Property% �� Value& �� 
TargetName' �� Property( �� Value) P� Property* P� Value  NoneWindowTemplate+ �� 
TargetType 
 Window  
NoneWindow�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     7sw0clr-namespace:WpfStyleableWindow.StyleableWindow  )commandclr-namespace:MyStyle.Command  %k  &	        &	      &	 
     &	      7  7   7  7  &	 �
    '�     7  &	 �    7  &	 i    7         �� "  �.R��� #��Z $��1q�._�� .+��  �� $��25 ��� $��* �.+�� $��0��$��0,0,0,0q�#��Z  �� $��25 ��� $��* ��� $��95 �.+��� $��0��$��16��#��Z $��Center=�$��Center=� ��  �� $ FindAncestor=�"	 �
 �� $ WindowContent���� $��1��$
��Left=�#��z $��0,0,0,0q�$��5,0,0,0q�$
��Left=�$��Center=�$��Stretch=�$��Stretch=�#��Z $��14(�8    .  ��  �� $ FindAncestor=�"	 � ��  �� $ FindAncestor=�"	 � ��  �� $ FindAncestor=�"	 �� $��2��$��Right=� �� $ 
btnMiniCol��$��30 ��� $ 	btnMaxCol��$��30 ��� $ btnCloseCol��$��30 �.+��� $ btnMini��$��0��$��28��$��0q�8�� #��Z ����  �� $ FindAncestor=�"	 �.���� $A��;pack://application:,,,/MyStyle;component/Image/Win_Mini.png��$��Uniform=�$��7q��� $ btnMax��$��1��$��28��$��0q�8�� #��Z ����  �� $ FindAncestor=�"	 �.���� $@��:pack://application:,,,/MyStyle;component/Image/Win_Max.png��$��Uniform=�$��6q��� $ btnClose��$��2��$��28��$��0q�8�� #��Z ����  �� $ FindAncestor=�"	 �.���� $B��<pack://application:,,,/MyStyle;component/Image/Win_Close.png��$��Uniform=�$��6q��� $��1��#��z��#��z��#��Z ._�� .+��� .u��� $ WindowContent���� $ WindowResizeGrip��$��Right=�$��Bottom=���.  $y�	Collapsed=�n� $ ThumbTop��$��6��$
��14,0q�$	��Top=�$ SizeNS��$ 0Q� ��  �� $ FindAncestor=�"	 �n� $ ThumbTopLeft��$��6��$��6��$	��Top=�$
��Left=�$ SizeNWSE��$ 0Q� ��  �� $ FindAncestor=�"	 �n� $ ThumbBottom��$��6��$
��14,0q�$��Bottom=�$ SizeNS��$ 0Q� ��  �� $ FindAncestor=�"	 �n� $ ThumbTopRight��$��6��$��6��$	��Top=�$��Right=�$ SizeNESW��$ 0Q� ��  �� $ FindAncestor=�"	 �n� $ 
ThumbRight��$��Right=�$
��0,14q�$��6��$ SizeWE��$ 0Q� ��  �� $ FindAncestor=�"	 �n� $ ThumbBottomRight��$��6��$��6��$��Bottom=�$��Right=�$ SizeNWSE��$ 0Q� ��  �� $ FindAncestor=�"	 �n� $ 	ThumbLeft��$
��Left=�$
��0,14q�$��6��$ SizeWE��$ 0Q�  ��  �� $ FindAncestor=�"	 �n� $ ThumbBottomLeft��$��6��$��6��$��Bottom=�$
��Left=�$ SizeNESW��$ 0Q�! ��  �� $ FindAncestor=�"	 �" ]� # �� $ �@�
ResizeMode$% CanResizeWithGrip=��� $ �@�WindowState$% Normal=�./��� $& WindowResizeGrip��' � y�$( Visible=�P� ) �@�
ResizeMode$* NoResize=�. ��� $& WindowResizeGrip��' � y�$( 	Collapsed=��� $& WindowResizeGrip��' � {�( .  �� $& 	btnMaxCol��' � ��$( 0 ��� $& 
btnMiniCol��' � ��$( 0 ��� "  �.R�� 
������ .+��� $ WindowContent���� "+ �.��� ' �@�WindowStyle$
( None=��� ' �@�AllowsTransparency( . �� ' � ��$	( 100���� ' � ��$	( 100���� ' � ��#( Z �� ' � ��8(   �� "+ �.��� ' �@�WindowStyle$
( None=��� ' �@�AllowsTransparency( . �� ' � ��$	( 100���� ' � ��$	( 100���� ' � ��#( Z �� ' � ��8(   �� "+ �.��� ' �@�WindowStyle$
( None=��� ' �@�AllowsTransparency( . �� ' � ��
( ���� �� ' � ��#( Z �� ' � ��8(   