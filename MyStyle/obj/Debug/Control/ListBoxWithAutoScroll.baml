   M S B A M L   `   `   `  ����I  EMyStyle, Version=1.0.6578.23650, Culture=neutral, PublicKeyToken=null1clr-namespace:MyStyle.ControlMyStyle.Control  5   
   1clr-namespace:MyStyle.CommandMyStyle.Command  5   
   +    %MyStyle.Control.ListBoxWithAutoScroll   5   
   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   
   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   
   @d2http://schemas.microsoft.com/expression/blend/2008     5   
   /localclr-namespace:MyStyle.Control     5   
   1commandclr-namespace:MyStyle.Command     5   
     � 	Resources  5	         ScrollBarLineButton �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius+   %MyStyle.Command.MyCurrentStyleManager   BrushEvenTriggerLevel1   BrushWindowForeground �� Path	 �� RelativeSource
 J� Opacity �� Triggers P� Property P� Value �� 
TargetName  ScrollBarPageButton  ScrollBarThumb  CustomListBoxItem �� Padding J� SnapsToDevicePixels �� ElementName  ListBoxWithAutoScroll ��Name ��Name �� Orientation �� HorizontalOffset � Value �� ScrollableWidth � Maximum �� ViewportWidth �� ViewportSize, �� %ComputedHorizontalScrollBarVisibility ]�Name ]� DecreaseRepeatButton ]� IncreaseRepeatButton ]� Thumb  �Name! � ColumnDefinitions" ��Name# �� LineLeftCommand$ �� 	ClickMode% �� LineRightCommand& ]� 
Conditions' �� Property( �� Value) �� 
SourceName* N� EnterActions+ �� 
TargetName, �� TargetProperty	- W� To. g� Duration/ N� ExitActions0 $� Orientation��%�  &	        &	 �    &	     &	 `    &	     7  7  7  7  7   7   �� 5
   
   " ��6,   .�5      ��  �@J�SnapsToDevicePixels . 64   �� 5       �@�OverridesDefaultStyle . 66   �� 5       � |� .  6*   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��Border��6!   $ 4��6/   #��Z 5   !   
������ ._�5      F� $��Center=�6#   $��Center=�6@   #��Z 6[   ��5   #   �� $ Content�	 �� *TemplatedParent+
 5   #   �� $ Opacity�	 �� *TemplatedParent+5       5      P� 5       � �� . . �5   "   �� $ Border��6)    �@J�Opacity$	 0.5Q�6P   5      P� 5       � {� .  . �5   "   ��  �@J�Opacity$	 0.5Q�6<   5      5       5"      5#      �� 5%   
   " ��6,   .�5&      ��  �@J�SnapsToDevicePixels . 64   �� 5'       �@�OverridesDefaultStyle . 66   �� 5(       � �� .  6*   �� 5)       � |� .  6*   �� 5*       � �� 5+      �� 5,      " ��6&   .R�5-      �� 
������ 6!   5.      50      51      �� 53   
   " n�6'   .�54      ��  �@J�SnapsToDevicePixels . 64   �� 55       �@�OverridesDefaultStyle . 66   �� 56       � �� .  6*   �� 57       � |� .  6*   �� 58       � �� 59      �� 5:      " n�6&   .R�5;      �� $ 2��6!   5<      5>      5?      �� 5A   
   " ��6*   .�5B      ��  �@J�SnapsToDevicePixels . 64   �� 5C       �@�OverridesDefaultStyle . 66   �� 5D       � �� 5E      �� 5F      " ��6&   .R�5G      �� $��Border��6!   $ 0q�5H   !   $��0q�5I   !   $ 4��5J   !   
������ $��0q�5M   !    . ��5K   !   �� *Height+$ ListBoxWithAutoScroll��._�5O      �� 5P      5Q      5S      5T      �� 5X   
   ListBoxWithAutoScroll��" ��6M   .�5Y      ��  �@J�SnapsToDevicePixels . 64   �� 5Z       �@�OverridesDefaultStyle . 66   �� 5[       � ��$
 Auto=�6K   �� 5\       � ��$
 Auto=�6I   �� 5]       � �� . 6>   �� 5^       � ��
 ���� 6+   �� 5_       � ��8   63   �� 5`       � �� 5a      �� 5b      .R�5c      � .+�5d      �� $ scrollviewer��6+   ��5e   "   �� 5f   &   " ��66   .R�5g   *   � .+�5h   .   �� $ PART_HorizontalScrollBar��68   $ 
Horizontal=�6Z   # z 5i   8   # z 5j   8   # z 5k   8   #y�z 5l   8   ��5m   8   �� *Height+$ Panel����5n   2   �� 5o   6   .R�5p   :   ]� $ 
PART_Track��6@    5q   >   �� 5r   B   $��ScrollBar.PageLeftCommand��6O   8�� 5s   ;    5u   >   �� 5v   B   $ ��ScrollBar.PageRightCommand��6O   8�� 5w   ;    5y   >   n� 5z   B   8�� 
������ $
��0,-1q�5{   c   5}   ;   5~   7   5�   /   �� 5�   .   $	��0,2q�6E   $
��Auto��6R   $��Center=�6`   5�   +   5�   '   .��5�   "   �� 5�      � 5�      $  Panel��6#   $	��0,2q�62   ! 5�   "   �� 5�   &   $
��Auto �67   �� 5�   &   $��* �67   �� 5�   &   $
��Auto �67   .+�5�   "   �� $" LineLeftButton��6/   $��0��6G   $��20��6W   $
 0Q�6b   $y�	Collapsed=�6n   8�� $��M 8 0 L 8 32 L 0 16 Z��5�   '   #��Z# 5�   '   $$ Hover=�5�   '   ��5�   '   �� $ scrollviewer��5�   '   �� 5�   "   $" LineRightButton��6/   $��2��6H   $��20��6X   $
 0Q�6c   $y�	Collapsed=�6o   8�� $��M 0 0 L 8 16 L 0 32 Z��5�   '   #��Z% 5�   '   $$ Hover=�5�   '   ��5�   '   �� $ scrollviewer��5�   '   5�      5�       5�      ]� 5�      & 5�   "   �� 5�   &   ' �@J�IsMouseOver( . 6G   �� 5�   &   $) scrollviewer��6a   -' �@��%ComputedHorizontalScrollBarVisibility$( Visible=�6{   /�5�   "   �� 5�   &   $ LineLeftButton��6-    � y�$ Visible=�6_   �� 5�   &   $ LineRightButton��6-    � y�$ Visible=�6`   * 5�   "   �� 5�   &   .��5�   *   �� .��5�   .   W� $+ LineLeftButton��6>   $, Opacity�5�   >   $	- 0.8X�6b   $. 0:0:0.25D�6k   W� 5�   .   $+ LineRightButton��6>   $, Opacity�5�   >   $	- 0.8X�6b   $. 0:0:0.25D�6k   5�   +   5�   '   / 5�   "   �� 5�   &   .��5�   *   �� .��5�   .   W� $+ LineLeftButton��6>   $, Opacity�5�   >   $- 0X�6b   $. 0:0:0.25D�6i   W� 5�   .   $+ LineRightButton��6>   $, Opacity�5�   >   $- 0X�6b   $. 0:0:0.25D�6i   5�   +   5�   '   5�      5�      5�      �� 5�       � �� 5�      �� 5�      .R�5�      $� $0 
Horizontal=�61   5�      5�      5�      5�      5�      