   M S B A M L   `   `   `  ����I  EMyStyle, Version=1.0.6578.23650, Culture=neutral, PublicKeyToken=nullW0clr-namespace:WpfStyleableWindow.StyleableWindow"WpfStyleableWindow.StyleableWindow  5      1clr-namespace:MyStyle.CommandMyStyle.Command  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089>    8WpfStyleableWindow.StyleableWindow.WindowMinimizeCommand   MinimizeCommand>   8WpfStyleableWindow.StyleableWindow.WindowMaximizeCommand  MaximizeCommand;   5WpfStyleableWindow.StyleableWindow.WindowCloseCommand  CloseCommand  WindowTemplate  �� 
TargetType+   %MyStyle.Command.MyCurrentStyleManager   BrushWindowGridBorder � RowDefinitions!   BrushWindowTitleBackground � ColumnDefinitions   ImageLidericon?   9WpfStyleableWindow.StyleableWindow.ShowSystemMenuBehavior   TargetWindow �� RelativeSource �� Mode	 �� AncestorType
   LeftButtonShowAt �� ElementName � Title   BrushWindowForegroundC   =WpfStyleableWindow.StyleableWindow.ControlDoubleClickBehavior   ExecuteCommand   RightButtonShow;   5WpfStyleableWindow.StyleableWindow.WindowDragBehavior   LeftMouseButtonDrag   ExecuteCommandParameter ��Name ��Name   BrushWindowBackground ��Name ��Name n�Name � Cursor J� Opacity=   7WpfStyleableWindow.StyleableWindow.WindowResizeBehavior   	TopResize   TopLeftResize   BottomResize   TopRightResize   RightResize   BottomRightResize    
LeftResize!   BottomLeftResize" �� Triggers# ]� 
Conditions$ �� Property% �� Value& �� 
TargetName' �� Property( �� Value) P� Property* P� Value  NoneWindowTemplate+ �� 
TargetType 
 Window  
NoneWindow�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      7sw0clr-namespace:WpfStyleableWindow.StyleableWindow  5      )commandclr-namespace:MyStyle.Command  5      %�  &	        &	      &	 &     &	 9     7  7   7  7  &	 �    '�     7  &	     7  &	 5    7     5      6     5      6     5      6   �� 5      "  �6-   .R�5   
   �� #��Z 6   $��1q�6^   ._�5      � .+�5      �  5      �� 5      $��25 �6(   �� 5      $��* �6(   .+�5      � $��0��6   $��0,0,0,0q�6(   #��Z 5       5      �� 5      $��25 �6/   �� 5      $��* �6/   �� 5      $��95 �6/   .+�5      �� $��0��6    $��16��60   #��Z 5       $��Center=�5       $��Center=�6;    5       ��  �� $ FindAncestor=�"	 �
 5       �� $ WindowContent���� 5      $��1��6    $
��Left=�60   #��z 6F   $��0,0,0,0q�5        $��5,0,0,0q�63   $
��Left=�5!       $��Center=�6B   $��Stretch=�5"       $��Stretch=�6>   #��Z 5#       $��14(�5$       8    .  5%       ��  �� $ FindAncestor=�"	 � 5'       ��  �� $ FindAncestor=�"	 � 5(       ��  �� $ FindAncestor=�"	 �5*      � 5+      $��2��6   $��Right=�6/    5,      �� 5-   "   $ 
btnMiniCol��63   $��30 �6G   �� 5.   "   $ 	btnMaxCol��63   $��30 �6F   �� 5/   "   $ btnCloseCol��63   $��30 �6H   .+�51      �� $ btnMini��6%   $��0��66   $��28��52   %   $��0q�60   8�� #��Z 54   %   ��55   %   ��  �� $ FindAncestor=�"	 �.��56   "   �� $A��;pack://application:,,,/MyStyle;component/Image/Win_Mini.png��6(   $��Uniform=�6m   $��7q�6   57      �� 58      $ btnMax��6%   $��1��65   $��28��59   %   $��0q�60   8�� #��Z 5;   %   ��5<   %   ��  �� $ FindAncestor=�"	 �.��5=   "   �� $@��:pack://application:,,,/MyStyle;component/Image/Win_Max.png��6(   $��Uniform=�6l   $��6q�6~   5>      �� 5?      $ btnClose��6%   $��2��67   $��28��5@   %   $��0q�60   8�� #��Z 5B   %   ��5C   %   ��  �� $ FindAncestor=�"	 �.��5D   "   �� $B��<pack://application:,,,/MyStyle;component/Image/Win_Close.png��6(   $��Uniform=�6n   $��6q�6�   5E      5F      5G      �� 5H      $��1��6   #��z��5I      #��z��5J      #��Z 5K      ._�5L      � .+�5M      �� .u�5N   "   �� $ WindowContent��63   5O      �� 5P      $ WindowResizeGrip��6*   $��Right=�5Q   &   $��Bottom=�6C   ��.  $y�	Collapsed=�5R   8   5S      5T      5U      n� 5V      $ ThumbTop��6   $��6��6*   $
��14,0q�65   $	��Top=�6C   $ SizeNS��6[   $ 0Q�6l    6x   ��  �� $ FindAncestor=�"	 �n� 5W      $ ThumbTopLeft��6   $��6��6.   $��6��69   $	��Top=�6C   $
��Left=�6[   $ SizeNWSE��6v   $ 0Q�6�    6�   ��  �� $ FindAncestor=�"	 �n� 5X      $ ThumbBottom��6   $��6��6-   $
��14,0q�68   $��Bottom=�6F   $ SizeNS��6a   $ 0Q�6q    6}   ��  �� $ FindAncestor=�"	 �n� 5Y      $ ThumbTopRight��6   $��6��6/   $��6��6:   $	��Top=�6D   $��Right=�6\   $ SizeNESW��6x   $ 0Q�6�    6�   ��  �� $ FindAncestor=�"	 �n� 5Z      $ 
ThumbRight��6   $��Right=�6,   $
��0,14q�6H   $��6��6V   $ SizeWE��6`   $ 0Q�6q    6}   ��  �� $ FindAncestor=�"	 �n� 5[      $ ThumbBottomRight��6   $��6��62   $��6��6=   $��Bottom=�6G   $��Right=�6b   $ SizeNWSE��6~   $ 0Q�6�    6�   ��  �� $ FindAncestor=�"	 �n� 5\      $ 	ThumbLeft��6   $
��Left=�6+   $
��0,14q�6F   $��6��6T   $ SizeWE��6^   $ 0Q�6o     6{   ��  �� $ FindAncestor=�"	 �n� 5]      $ ThumbBottomLeft��6   $��6��61   $��6��6<   $��Bottom=�6F   $
��Left=�6a   $ SizeNESW��6|   $ 0Q�6�   ! 6�   ��  �� $ FindAncestor=�"	 �5^      5_      " 5`   
   ]� 5a      # 5b      �� 5c      $ �@�
ResizeMode$% CanResizeWithGrip=�66   �� 5d      $ �@�WindowState$% Normal=�67   ./�5f      �� $& WindowResizeGrip��6/   ' � y�$( Visible=�6M   5g      P� 5h      ) �@�
ResizeMode$* NoResize=�6,   . �5i      �� $& WindowResizeGrip��6/   ' � y�$( 	Collapsed=�6M   �� 5j      $& WindowResizeGrip��6.   ' � {�( .  6L   �� 5k      $& 	btnMaxCol��6*   ' � ��$( 0 �6A   �� 5l      $& 
btnMiniCol��6*   ' � ��$( 0 �6B   5m      5o      �� 5q      "  �61   .R�5r   
   � 
������ .+�5s      �� $ WindowContent��6   5t      5u      �� 5w      "+ �6$   .�5x   
   �� ' �@�WindowStyle$
( None=�6(   �� 5y   
   ' �@�AllowsTransparency( . 6/   �� 5z   
   ' � ��$	( 100��6%   �� 5{   
   ' � ��$	( 100��6&   �� 5|   
   ' � ��#( Z 6'   �� 5}   
   ' � ��8(   6%   5~      �� 5�      "+ �6   .�5�   
   �� ' �@�WindowStyle$
( None=�6(   �� 5�   
   ' �@�AllowsTransparency( . 6/   �� 5�   
   ' � ��$	( 100��6%   �� 5�   
   ' � ��$	( 100��6&   �� 5�   
   ' � ��#( Z 6'   �� 5�   
   ' � ��8(   6%   5�      �� 5�      "+ �6   .�5�   
   �� ' �@�WindowStyle$
( None=�6(   �� 5�   
   ' �@�AllowsTransparency( . 6/   �� 5�   
   ' � ��
( ���� 6'   �� 5�   
   ' � ��#( Z 6'   �� 5�   
   ' � ��8(   6%   5�      5�      