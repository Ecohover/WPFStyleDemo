   M S B A M L   `   `   `  ����I  EMyStyle, Version=1.0.6578.23650, Culture=neutral, PublicKeyToken=null1clr-namespace:MyStyle.ControlMyStyle.Control  5      a ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes 5      #    MyStyle.Control.MyUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1controlclr-namespace:MyStyle.Control     5      ]ThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero     5      -   5          >�Name$  usercontrol��5	      .��5      � $��0,0,0,0q�6   .+�5   
   �� $��30,196,476.333,185.333q�6   .@�5      �� $��TabItem1��6   .��5      �� $��Test1��6   5      �� 5      $��TabItem2��6   .��5      �� $��Test2��6   5      �� 5      $��TabItem3��6   .��5      �� $��Test3��6   5      �� 5      $��TabItem4��6   .��5      �� $��Test4��6   5      �� 5      $��TabItem5��6   .��5      �� $��Test5��6   5      �� 5      $��TabItem6��6   .��5      �� $��Test6��6   5      �� 5       $��TabItem7��6   .��5!      �� $��Test7��6   5"      �� 5#      $��TabItem8��6   .��5$      �� $��Test8��6   5%      �� 5&      $��TabItem9��6   .��5'      �� $��Test9��6   5(      �� 5)      $��	TabItem10��6   .��5*      �� $��Test10��6   5+      5,      #   MyStyle.Control.OldTabControl  5-   
   $��413,196,93,185q�6       	StyleName 68   �� *	StyleName+ �� ElementName$ usercontrol�� �� Mode$ OneWay=�&   System.Windows.Controls.DataGrid  5/   
   -   5          Name$ gridtest��5/      $��
590,12,0,0q�6%      AutoGenerateColumns .  $
��Left=�6U   $	��211��6p   $	��147��6|   $	��Top=�6�      Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ C1��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6<   �� *C1+
   ClipboardContentBinding
 6S   Z�   53      $ C2��6%   $ 60 61   	 6<   �� *C2+
 6S   Z�   54      $ C3��6%   $ 60 61   	 6<   �� *C3+
 6S   Z� 4  .System.Windows.Controls.DataGridTemplateColumn  56      $ C4��6)   $ 60 65      ClipboardContentBinding 6@   Z�    CellTemplate 57      �� 58      .R�59      � $��Center=�6#   .+�5:   "   ��  d� 	IsChecked 6+   �� *C4+5;      5<      5>      5@      �� 5A   
   -   5        $��C001-按鈕��5A      $
��Left=�6#   $��	11,10,0,0q�6>   $	��Top=�6Q   $��94��6i   $��1��6�   �� 5B   
   $��C002-多选��6   $
��Left=�6%   $��	13,84,0,0q�6@   $	��Top=�6S   $��3��6k   �� 5C   
   $��C002-多选��6   $
��Left=�6%   $��
13,104,0,0q�6@   $	��Top=�6T   $
 TrueY�6l   $��4��6}   	� 5D   
   $��C003-单选��6   $
��Left=�6(   $��
100,86,0,0q�6C   $	��Top=�6W   $��7��6o   	� 5E   
   $��C003-单选��6   $
��Left=�6(   $��100,106,0,0q�6C   $	��Top=�6X   $��8��6p   �� 5F   
   -   5         ��Name$ cbStyleName��5F      $
��Left=�6(   $��216,107,0,0q�6C   $	��Top=�6X   $	��149��6p    �� SelectedValuePath$	 Key��6�    �� DisplayMemberPath$ Value��6�    �� SelectedIndex$ 0��6�   $��18��6�   ��6|   �� *PageStyleList+6�   �� 5G   
   $��C002-多选��6   $
��Left=�6%   $��
13,124,0,0q�6@   $	��Top=�6T   {�.  $��5��6~   	� 5H   
   $��C003-单选��6   $
��Left=�6(   $��100,125,0,0q�6C   $	��Top=�6X   {�.  $��9��6�   �� 5I   
   $��C002-多选��6   $
��Left=�6%   $��
13,144,0,0q�6@   $	��Top=�6T   {�.  $
 TrueY�6~   $��6��6�   	� 5J   
   $��C003-单选��6   $
��Left=�6(   $��100,144,0,0q�6C   $	��Top=�6X   {�.  $
 TrueY�6�   $��10��6�   �� 5K   
   -   5         ��Name$ tbSearch��5K      $��C001-按鈕-1��6#   $
��Left=�67   $��	13,35,0,0q�6R   $	��Top=�6e   $��92��6}   $��34��6�   $��2��6�   {�.  6�   �� 5L   
   -   5        $
��Left=�5L      $��23��6-   $��
220,47,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $	��120��6y   $	��111��6�   $��12��6�   �� 5M   
   $
��Left=�6   $��23��6-   $��
220,75,0,0q�69   $
 Wrap=�6M   $��TextBox��6a   $	��Top=�6p   $	��120��6�   {�.  $��13��6�   #   MyStyle.Control.SearchTextBox  5N   
   -   5          Name$ stb01��5N       $��23��6/   $��
355,48,0,0q�6;   $	��Top=�6O   $	��120��6g   $
��Left=�6�   $��13��6�      	StyleName 6s   �� *	StyleName+$ usercontrol��$ OneWay=�6�     5O   
   -   5        $ stb02��5O       $��23��6/   $��
355,76,0,0q�6;   $	��Top=�6O   $	��120��6g   {�.  $
��Left=�6�   $��14��6�    6�   �� *	StyleName+$ usercontrol��$ OneWay=�6�   �� 5P   
   -	   5        $ cbStyleName2��5P      $
��Left=�6)   $��381,106,0,0q�6D   $	��Top=�6Y   $	��149��6q   $	 Key��6�   $ Value��6�   $ 0��6�    �� 
IsEditable . $��18��6�   ��6}   �� *PageStyleList+6�   �� 5Q   
   -
   5        $ cbStyleName3��5Q      $
��Left=�6)   $��216,137,0,0q�6D   $	��Top=�6Y   $	��149��6q   $	 Key��6�   $ Value��6�   $ 0��6�   {�.  $��18��6�   ��6}   �� *PageStyleList+6�   �� 5R   
   -   5        $ cbStyleName4��5R      $
��Left=�6)   $��381,137,0,0q�6D   $	��Top=�6Y   $	��149��6q   $	 Key��6�   $ Value��6�   $ 0��6�    . {�.  $��18��6  ��6}   �� *PageStyleList+6  �� 5S   
   $
��Left=�6   $��	549,9,0,0q�6/   $	��Top=�6B   $	��150��6Z   $��17��6g   �� 5T   
   $
��Left=�6   $��
230,10,0,0q�6/   $	��Top=�6C   $��20��6[   $	��314��6g    �� Orientation$ 
Horizontal=�6s   5V      5W      