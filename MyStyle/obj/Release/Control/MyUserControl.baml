   M S B A M L   `   `   `  ���� I  EMyStyle, Version=1.0.6578.23344, Culture=neutral, PublicKeyToken=null1clr-namespace:MyStyle.ControlMyStyle.Control  a ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes #    MyStyle.Control.MyUserControl   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1controlclr-namespace:MyStyle.Control     ]ThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero     -     >�Name$  usercontrol��.��� $��0,0,0,0q�.+��� $��30,196,476.333,185.333q�.@��� $��TabItem1��.���� $��Test1���� $��TabItem2��.���� $��Test2���� $��TabItem3��.���� $��Test3���� $��TabItem4��.���� $��Test4���� $��TabItem5��.���� $��Test5���� $��TabItem6��.���� $��Test6���� $��TabItem7��.���� $��Test7���� $��TabItem8��.���� $��Test8���� $��TabItem9��.���� $��Test9���� $��	TabItem10��.���� $��Test10��#   MyStyle.Control.OldTabControl  $��413,196,93,185q�   	StyleName �� *	StyleName+ �� ElementName$ usercontrol�� �� Mode$ OneWay=�&   System.Windows.Controls.DataGrid  -     Name$ gridtest��$��
590,12,0,0q�   AutoGenerateColumns .  $
��Left=�$	��211��$	��147��$	��Top=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ C1��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *C1+
   ClipboardContentBinding
 Z�   $ C2��$ 60 	 �� *C2+
 Z�   $ C3��$ 60 	 �� *C3+
 Z� 4  .System.Windows.Controls.DataGridTemplateColumn  $ C4��$ 60    ClipboardContentBinding Z�    CellTemplate �� .R�� $��Center=�.+���  d� 	IsChecked �� *C4+�� -   $��C001-按鈕��$
��Left=�$��	11,10,0,0q�$	��Top=�$��94��$��1���� $��C002-多选��$
��Left=�$��	13,84,0,0q�$	��Top=�$��3���� $��C002-多选��$
��Left=�$��
13,104,0,0q�$	��Top=�$
 TrueY�$��4��	� $��C003-单选��$
��Left=�$��
100,86,0,0q�$	��Top=�$��7��	� $��C003-单选��$
��Left=�$��100,106,0,0q�$	��Top=�$��8���� -    ��Name$ cbStyleName��$
��Left=�$��216,107,0,0q�$	��Top=�$	��149�� �� SelectedValuePath$	 Key�� �� DisplayMemberPath$ Value�� �� SelectedIndex$ 0��$��18������ *PageStyleList+�� $��C002-多选��$
��Left=�$��
13,124,0,0q�$	��Top=�{�.  $��5��	� $��C003-单选��$
��Left=�$��100,125,0,0q�$	��Top=�{�.  $��9���� $��C002-多选��$
��Left=�$��
13,144,0,0q�$	��Top=�{�.  $
 TrueY�$��6��	� $��C003-单选��$
��Left=�$��100,144,0,0q�$	��Top=�{�.  $
 TrueY�$��10���� -    ��Name$ tbSearch��$��C001-按鈕-1��$
��Left=�$��	13,35,0,0q�$	��Top=�$��92��$��34��$��2��{�.  �� -   $
��Left=�$��23��$��
220,47,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��$	��111��$��12���� $
��Left=�$��23��$��
220,75,0,0q�$
 Wrap=�$��TextBox��$	��Top=�$	��120��{�.  $��13��#   MyStyle.Control.SearchTextBox  -     Name$ stb01��$��23��$��
355,48,0,0q�$	��Top=�$	��120��$
��Left=�$��13��   	StyleName �� *	StyleName+$ usercontrol��$ OneWay=�  -   $ stb02��$��23��$��
355,76,0,0q�$	��Top=�$	��120��{�.  $
��Left=�$��14�� �� *	StyleName+$ usercontrol��$ OneWay=��� -	   $ cbStyleName2��$
��Left=�$��381,106,0,0q�$	��Top=�$	��149��$	 Key��$ Value��$ 0�� �� 
IsEditable . $��18������ *PageStyleList+�� -
   $ cbStyleName3��$
��Left=�$��216,137,0,0q�$	��Top=�$	��149��$	 Key��$ Value��$ 0��{�.  $��18������ *PageStyleList+�� -   $ cbStyleName4��$
��Left=�$��381,137,0,0q�$	��Top=�$	��149��$	 Key��$ Value��$ 0�� . {�.  $��18������ *PageStyleList+�� $
��Left=�$��	549,9,0,0q�$	��Top=�$	��150��$��17���� $
��Left=�$��
230,10,0,0q�$	��Top=�$��20��$	��314�� �� Orientation$ 
Horizontal=�