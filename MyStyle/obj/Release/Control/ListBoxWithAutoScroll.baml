   M S B A M L   `   `   `  ���� I  EMyStyle, Version=1.0.6578.23344, Culture=neutral, PublicKeyToken=null1clr-namespace:MyStyle.ControlMyStyle.Control  1clr-namespace:MyStyle.CommandMyStyle.Command  +    %MyStyle.Control.ListBoxWithAutoScroll   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:MyStyle.Control     1commandclr-namespace:MyStyle.Command       � 	Resources     ScrollBarLineButton �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius+   %MyStyle.Command.MyCurrentStyleManager   BrushEvenTriggerLevel1   BrushWindowForeground �� Path	 �� RelativeSource
 J� Opacity �� Triggers P� Property P� Value �� 
TargetName  ScrollBarPageButton  ScrollBarThumb  CustomListBoxItem �� Padding J� SnapsToDevicePixels �� ElementName  ListBoxWithAutoScroll ��Name ��Name �� Orientation �� HorizontalOffset � Value �� ScrollableWidth � Maximum �� ViewportWidth �� ViewportSize, �� %ComputedHorizontalScrollBarVisibility ]�Name ]� DecreaseRepeatButton ]� IncreaseRepeatButton ]� Thumb  �Name! � ColumnDefinitions" ��Name# �� LineLeftCommand$ �� 	ClickMode% �� LineRightCommand& ]� 
Conditions' �� Property( �� Value) �� 
SourceName* N� EnterActions+ �� 
TargetName, �� TargetProperty	- W� To. g� Duration/ N� ExitActions0 $� Orientation��%�
  &	        &	 �    &	 �    &	 2    &	 +    7  7  7  7  7   7   �� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � |� .  ��  � �� �� " ��.R��� $��Border��$ 4��#��Z 
������ ._�F� $��Center=�$��Center=�#��Z ���� $ Content�	 �� *TemplatedParent+
 �� $ Opacity�	 �� *TemplatedParent+ P�  � �� . . ��� $ Border�� �@J�Opacity$	 0.5Q�P�  � {� .  . ���  �@J�Opacity$	 0.5Q��� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � �� .  ��  � |� .  ��  � �� �� " ��.R��� 
������ �� " n�.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � �� .  ��  � |� .  ��  � �� �� " n�.R��� $ 2���� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � �� �� " ��.R��� $��Border��$ 0q�$��0q�$ 4��
������ $��0q� . ���� *Height+$ ListBoxWithAutoScroll��._��� �� ListBoxWithAutoScroll��" ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � ��$
 Auto=���  � ��$
 Auto=���  � �� . ��  � ��
 ���� ��  � ��8   ��  � �� �� .R�� .+��� $ scrollviewer������ " ��.R�� .+��� $ PART_HorizontalScrollBar��$ 
Horizontal=�# z # z # z #y�z ���� *Height+$ Panel������ .R�]� $ 
PART_Track�� �� $��ScrollBar.PageLeftCommand��8��  �� $ ��ScrollBar.PageRightCommand��8��  n� 8�� 
������ $
��0,-1q��� $	��0,2q�$
��Auto��$��Center=�.���� � $  Panel��$	��0,2q�! �� $
��Auto ��� $��* ��� $
��Auto �.+��� $" LineLeftButton��$��0��$��20��$
 0Q�$y�	Collapsed=�8�� $��M 8 0 L 8 32 L 0 16 Z��#��Z# $$ Hover=����� $ scrollviewer���� $" LineRightButton��$��2��$��20��$
 0Q�$y�	Collapsed=�8�� $��M 0 0 L 8 16 L 0 32 Z��#��Z% $$ Hover=����� $ scrollviewer�� ]� & �� ' �@J�IsMouseOver( . �� $) scrollviewer��-' �@��%ComputedHorizontalScrollBarVisibility$( Visible=�/��� $ LineLeftButton�� � y�$ Visible=��� $ LineRightButton�� � y�$ Visible=�* �� .���� .��W� $+ LineLeftButton��$, Opacity�$	- 0.8X�$. 0:0:0.25D�W� $+ LineRightButton��$, Opacity�$	- 0.8X�$. 0:0:0.25D�/ �� .���� .��W� $+ LineLeftButton��$, Opacity�$- 0X�$. 0:0:0.25D�W� $+ LineRightButton��$, Opacity�$- 0X�$. 0:0:0.25D���  � �� �� .R�$� $0 
Horizontal=�