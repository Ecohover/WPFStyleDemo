   M S B A M L   `   `   `  ����I  EMyStyle, Version=1.0.6578.23650, Culture=neutral, PublicKeyToken=null!clr-namespace:MyStyleMyStyle  5   	   1clr-namespace:MyStyle.ControlMyStyle.Control  5   	   a ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes 5	   	       MyStyle.DemoPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MyStyle     5   	   e aActiproSoftware.Editors.Wpf, Version=15.1.621.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9Ceditors5http://schemas.actiprosoftware.com/winfx/xaml/editors  5   	   +controlclr-namespace:MyStyle.Control  5   	   WThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero  5	   	   e aActiproSoftware.Docking.Wpf, Version=15.1.621.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9Cdocking5http://schemas.actiprosoftware.com/winfx/xaml/docking  5   	   -   5          �Name$  windows��5   	    � Title$ DemoPage��5   	   $��800.333��6   $	��820��6+    � 
ResizeMode$ NoResize=�5       � 	Resources 5      ��%    5      .��5      � .+�5   
   �� $��13,227,493.667,320q�6   .@�5      �� $��TabItem1��6   .��5      �� $��Test1��6   5      �� 5      $��TabItem2��6   .��5      �� $��Test2��6   5      �� 5      $��TabItem3��6   .��5      �� $��Test3��6   5      �� 5      $��TabItem4��6   .��5      �� $��Test4��6   5       �� 5!      $��TabItem5��6   .��5"      �� $��Test5��6   5#      �� 5$      $��TabItem6��6   .��5%      �� $��Test6��6   $��0,0,0,-0.667q�6)   5&      �� 5'      $��TabItem7��6   .��5(      �� $��Test7��6   5)      �� 5*      $��TabItem8��6   .��5+      �� $��Test8��6   5,      �� 5-      $��TabItem9��6   .��5.      �� $��Test9��6   5/      �� 50      $��	TabItem10��6   .��51      �� $��Test10��6   52      53      #   MyStyle.Control.OldTabControl  54   
   $��11,457,495.667,122q�6       	StyleName 6<   �� *	StyleName+ �� ElementName$ windows�� �� Mode$ OneWay=�&   System.Windows.Controls.DataGrid  56   
   -   5          Name$ gridtest��56   '      RowHeaderWidth$ 30Q�6   $��
584,12,0,0q�69   	   AutoGenerateColumns	 .  $
��Left=�6i   $	��211��6�   $	��147��6�   $	��Top=�6�   
   Columns
 58      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn   Header$ C1��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *C1+   ClipboardContentBinding 6S   Z�   5:      $ C2��6%   $ 60 61    6<   �� *C2+ 6S   Z�   5;      $ C3��6%   $ 60 61    6<   �� *C3+ 6S   Z� 4  .System.Windows.Controls.DataGridTemplateColumn  5=      $ C4��6)   $ 60 65      ClipboardContentBinding 6@   Z�    CellTemplate 5>      �� 5?      .R�5@      � $��Center=�6#   .+�5A   "   ��  d� 	IsChecked 6+   �� *C4+5B      5C      5E      5G      �� 5H   
   -   5        $��C001-按鈕��5H      $
��Left=�6#   $��	11,10,0,0q�6>   $	��Top=�6Q   $��94��6i   $��1��6�   �� 5I   
   $��C002-多选��6   $
��Left=�6%   $��	13,84,0,0q�6@   $	��Top=�6S   $��3��6k   �� 5J   
   $��C002-多选��6   $
��Left=�6%   $��
13,104,0,0q�6@   $	��Top=�6T   $
 TrueY�6l   $��4��6}   	� 5K   
   $��C003-单选��6   $
��Left=�6(   $��
100,86,0,0q�6C   $	��Top=�6W   $��7��6o   	� 5L   
   $��C003-单选��6   $
��Left=�6(   $��100,106,0,0q�6C   $	��Top=�6X   $��8��6p   �� 5M   
   -   5         ��Name$ cbStyleName��5M      $
��Left=�6(   $��216,107,0,0q�6C   $	��Top=�6X   $	��149��6p    �� SelectedValuePath$	 Key��6�    �� DisplayMemberPath$ Value��6�    �� SelectedIndex$ 0��6�   $��18��6�   ��6|   �� *PageStyleList+6�   �� 5N   
   $��C002-多选��6   $
��Left=�6%   $��
13,124,0,0q�6@   $	��Top=�6T   {�.  $��5��6~   	� 5O   
   $��C003-单选��6   $
��Left=�6(   $��100,125,0,0q�6C   $	��Top=�6X   {�.  $��9��6�   �� 5P   
   $��C002-多选��6   $
��Left=�6%   $��
13,144,0,0q�6@   $	��Top=�6T   {�.  $
 TrueY�6~   $��6��6�   	� 5Q   
   $��C003-单选��6   $
��Left=�6(   $��100,144,0,0q�6C   $	��Top=�6X   {�.  $
 TrueY�6�   $��10��6�   �� 5R   
   -   5         ��Name$ tbSearch��5R      $��C001-按鈕-1��6#   $
��Left=�67   $��	13,35,0,0q�6R   $	��Top=�6e   $��92��6}   $��34��6�   $��2��6�   {�.  6�   �� 5S   
   -   5        $
��Left=�5S      $��23��6-   $��
220,47,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $	��120��6y   $	��111��6�   $��12��6�   �� 5T   
   $
��Left=�6   $��23��6-   $��
220,75,0,0q�69   $
 Wrap=�6M   $��TextBox��6a   $	��Top=�6p   $	��120��6�   {�.  $��13��6�   #   MyStyle.Control.SearchTextBox  5U   
   -   5          Name$ stb01��5U       $��23��6/   $��
355,48,0,0q�6;   $	��Top=�6O   $	��120��6g   $
��Left=�6�   $��13��6�      	StyleName 6s   �� *	StyleName+$ windows��$ OneWay=�6�     5V   
   -   5        $ stb02��5V       $��23��6/   $��
355,76,0,0q�6;   $	��Top=�6O   $	��120��6g   {�.  $
��Left=�6�   $��14��6�    6�   �� *	StyleName+$ windows��$ OneWay=�6�   �� 5W   
   -	   5        $ cbStyleName2��5W      $
��Left=�6)   $��381,106,0,0q�6D   $	��Top=�6Y   $	��149��6q   $	 Key��6�   $ Value��6�   $ 0��6�    �� 
IsEditable . $��18��6�   ��6}   �� *PageStyleList+6�   �� 5X   
   -
   5        $ cbStyleName3��5X      $
��Left=�6)   $��216,137,0,0q�6D   $	��Top=�6Y   $	��149��6q   $	 Key��6�   $ Value��6�   $ 0��6�   {�.  $��18��6�   ��6}   �� *PageStyleList+6�   �� 5Y   
   -   5        $ cbStyleName4��5Y      $
��Left=�6)   $��381,137,0,0q�6D   $	��Top=�6Y   $	��149��6q   $	 Key��6�   $ Value��6�   $ 0��6�    . {�.  $��18��6  ��6}   �� *PageStyleList+6  �� 5Z   
   $
��Left=�6   $��	549,9,0,0q�6/   $	��Top=�6B   $	��150��6Z   $��17��6g   �� 5[   
   $
��Left=�6   $��
230,10,0,0q�6/   $	��Top=�6C   $��20��6[   $	��314��6g    �� Orientation$ 
Horizontal=�6s   ;	  5ActiproSoftware.Windows.Controls.Editors.Int32EditBox	  5]   
   -   5         	 Name$ updOrderVolume��5]      �
  �ActiproSoftware.Windows.Controls.Editors.Primitives.TypeSpecificEditBoxBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]] 
  Value$ 1X�67   �  �ActiproSoftware.Windows.Controls.Editors.Primitives.RangeTypeSpecificEditBoxBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Minimum$ 0X�5^         Maximum$	 999X�6+   :  4ActiproSoftware.Windows.Controls.Editors.PartEditBox    SpinnerVisibility$  Visible=�5_      M  GActiproSoftware.Windows.Controls.Editors.Primitives.SlottedItemsControl$!   CenterSlotHorizontalAlignment$! Right=�5`      $��30,186,684.667,547q�5a          MyStyle.Control.RedButton  5b   
   -   5        "  Name$" 
TestButton��5b         MyStyle.Control.RedButton#   Click$# RedButton_Click��5d   ?   $��Button��5b   0   $
��Left=�5c      $��155,182,0,0q�67   $	��Top=�5d      $��75��64   6?       MyStyle.Control.BlueButton  5e   
   $��Button��6   $
��Left=�6.   $��235,182,0,0q�6I   $	��Top=�6^   $��75��6v   !   MyStyle.Control.GreenButton  5f   
   $��Button��6   $
��Left=�6/   $��320,182,0,0q�6J   $	��Top=�6_   $��75��6w   9� 5g   
   $��Expander��6   $
��Left=�6%   $	��100��6@   $��341,227,0,0q�6M   $	��Top=�6b   $	��359��6z   .��5h      � 
������ .+�5i      +   %MyStyle.Control.ListBoxWithAutoScroll  -   5        $  Name$$ Listboxtemp��5i   0   6H   5j      5k      I  CActiproSoftware.Windows.Controls.Docking.Primitives.NonTopmostPopup  5l   
   -   5        %  Name$% popupFlashToolSetting��5l   "   ��5m      �� *IsDropDownOpen+& �� RelativeSource& �� *TemplatedParent+.��5n      � $	��124��6   $	��126��6!   
�������.+�5o      �� $��1q�6   ���	#AA666666._�5p      � $��10q�6   
�������$��Stretch=�6A   $��Stretch=�6_   5r      5s      5t      5u      c� 5v   
   $
��Left=�6   $��58��6-   $��355,327,0,0q�69   $	��Top=�6N   $	��425��6f   .@�5w        -   5        $ 
stb01_Copy��5w   $   $��23��68   $��5q�6D   $	��Top=�6O   $	��120��6g   $
��Left=�6�   $��13��6�    6s   �� *	StyleName+$ windows��$ OneWay=�6�   �� 5x      -   5        $��C001-按鈕��5x      $
��Left=�6'   $��0,5,0,0q�6B   $	��Top=�6S   $��94��6k   $��1��6�   $��28��6�   �� 5y      -   5        $ cbStyleName_Copy��5y      $
��Left=�61   $��5q�6L   $	��Top=�6W   $	��149��6o   $	 Key��6�   $ Value��6�   $ 0��6�   $��18��6�   ��6{   �� *PageStyleList+6�   �� 5z      -   5        $��C001-按鈕��5z      $
��Left=�6'   $	��Top=�6B   $��5q�6[   $��94��6f   $��1��6�   $��33��6�   �� 5{      -   5        $ cbStyleName_Copy1��5{      $
��Left=�62   $��5q�6N   $	��Top=�6Y   $	��149��6q   $	 Key��6�   $ Value��6�   $ 0��6�   $��18��6�   ��6}   �� *PageStyleList+6�   �� 5|      -   5        $��C001-按鈕��5|      $
��Left=�6'   $	��Top=�6B   $��5q�6Z   $��94��6e   $��1��6�   $��33��6�   �� 5}      -   5        $ cbStyleName_Copy2��5}      $
��Left=�62   $��5q�6O   $	��Top=�6Z   $	��149��6r   $	 Key��6�   $ Value��6�   $ 0��6�   $��18��6�   ��6~   �� *PageStyleList+6�   �� 5~      -   5        $��C001-按鈕��5~      $
��Left=�6'   $	��Top=�6B   $��5q�6Z   $��94��6e   $��1��6�   $��33��6�   �� 5      -   5        $ cbStyleName_Copy3��5      $
��Left=�62   $��5q�6N   $	��Top=�6Y   $	��149��6q   $	 Key��6�   $ Value��6�   $ 0��6�   $��18��6�   ��6}   �� *PageStyleList+6�   5�      5�      5�      