   M S B A M L   `   `   `  ���� I  EMyStyle, Version=1.0.6578.23344, Culture=neutral, PublicKeyToken=null!clr-namespace:MyStyleMyStyle  1clr-namespace:MyStyle.ControlMyStyle.Control  a ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes     MyStyle.DemoPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:MyStyle     e aActiproSoftware.Editors.Wpf, Version=15.1.621.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9Ceditors5http://schemas.actiprosoftware.com/winfx/xaml/editors  +controlclr-namespace:MyStyle.Control  WThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero  e aActiproSoftware.Docking.Wpf, Version=15.1.621.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9Cdocking5http://schemas.actiprosoftware.com/winfx/xaml/docking  -     �Name$  windows�� � Title$ DemoPage��$��800.333��$	��820�� � 
ResizeMode$ NoResize=� � 	Resources ��%    .��� .+��� $��13,227,493.667,320q�.@��� $��TabItem1��.���� $��Test1���� $��TabItem2��.���� $��Test2���� $��TabItem3��.���� $��Test3���� $��TabItem4��.���� $��Test4���� $��TabItem5��.���� $��Test5���� $��TabItem6��.���� $��Test6��$��0,0,0,-0.667q��� $��TabItem7��.���� $��Test7���� $��TabItem8��.���� $��Test8���� $��TabItem9��.���� $��Test9���� $��	TabItem10��.���� $��Test10��#   MyStyle.Control.OldTabControl  $��11,457,495.667,122q�   	StyleName �� *	StyleName+ �� ElementName$ windows�� �� Mode$ OneWay=�&   System.Windows.Controls.DataGrid  -     Name$ gridtest��   RowHeaderWidth$ 30Q�$��
584,12,0,0q�	   AutoGenerateColumns	 .  $
��Left=�$	��211��$	��147��$	��Top=�
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ C1��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *C1+   ClipboardContentBinding Z�   $ C2��$ 60  �� *C2+ Z�   $ C3��$ 60  �� *C3+ Z� 4  .System.Windows.Controls.DataGridTemplateColumn  $ C4��$ 60    ClipboardContentBinding Z�    CellTemplate �� .R�� $��Center=�.+���  d� 	IsChecked �� *C4+�� -   $��C001-按鈕��$
��Left=�$��	11,10,0,0q�$	��Top=�$��94��$��1���� $��C002-多选��$
��Left=�$��	13,84,0,0q�$	��Top=�$��3���� $��C002-多选��$
��Left=�$��
13,104,0,0q�$	��Top=�$
 TrueY�$��4��	� $��C003-单选��$
��Left=�$��
100,86,0,0q�$	��Top=�$��7��	� $��C003-单选��$
��Left=�$��100,106,0,0q�$	��Top=�$��8���� -    ��Name$ cbStyleName��$
��Left=�$��216,107,0,0q�$	��Top=�$	��149�� �� SelectedValuePath$	 Key�� �� DisplayMemberPath$ Value�� �� SelectedIndex$ 0��$��18������ *PageStyleList+�� $��C002-多选��$
��Left=�$��
13,124,0,0q�$	��Top=�{�.  $��5��	� $��C003-单选��$
��Left=�$��100,125,0,0q�$	��Top=�{�.  $��9���� $��C002-多选��$
��Left=�$��
13,144,0,0q�$	��Top=�{�.  $
 TrueY�$��6��	� $��C003-单选��$
��Left=�$��100,144,0,0q�$	��Top=�{�.  $
 TrueY�$��10���� -    ��Name$ tbSearch��$��C001-按鈕-1��$
��Left=�$��	13,35,0,0q�$	��Top=�$��92��$��34��$��2��{�.  �� -   $
��Left=�$��23��$��
220,47,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��$	��111��$��12���� $
��Left=�$��23��$��
220,75,0,0q�$
 Wrap=�$��TextBox��$	��Top=�$	��120��{�.  $��13��#   MyStyle.Control.SearchTextBox  -     Name$ stb01��$��23��$��
355,48,0,0q�$	��Top=�$	��120��$
��Left=�$��13��   	StyleName �� *	StyleName+$ windows��$ OneWay=�  -   $ stb02��$��23��$��
355,76,0,0q�$	��Top=�$	��120��{�.  $
��Left=�$��14�� �� *	StyleName+$ windows��$ OneWay=��� -	   $ cbStyleName2��$
��Left=�$��381,106,0,0q�$	��Top=�$	��149��$	 Key��$ Value��$ 0�� �� 
IsEditable . $��18������ *PageStyleList+�� -
   $ cbStyleName3��$
��Left=�$��216,137,0,0q�$	��Top=�$	��149��$	 Key��$ Value��$ 0��{�.  $��18������ *PageStyleList+�� -   $ cbStyleName4��$
��Left=�$��381,137,0,0q�$	��Top=�$	��149��$	 Key��$ Value��$ 0�� . {�.  $��18������ *PageStyleList+�� $
��Left=�$��	549,9,0,0q�$	��Top=�$	��150��$��17���� $
��Left=�$��
230,10,0,0q�$	��Top=�$��20��$	��314�� �� Orientation$ 
Horizontal=�;	  5ActiproSoftware.Windows.Controls.Editors.Int32EditBox	  -    	 Name$ updOrderVolume���
  �ActiproSoftware.Windows.Controls.Editors.Primitives.TypeSpecificEditBoxBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]] 
  Value$ 1X��  �ActiproSoftware.Windows.Controls.Editors.Primitives.RangeTypeSpecificEditBoxBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Minimum$ 0X�   Maximum$	 999X�:  4ActiproSoftware.Windows.Controls.Editors.PartEditBox    SpinnerVisibility$  Visible=�M  GActiproSoftware.Windows.Controls.Editors.Primitives.SlottedItemsControl$!   CenterSlotHorizontalAlignment$! Right=�$��30,186,684.667,547q�   MyStyle.Control.RedButton  -   "  Name$" 
TestButton��   MyStyle.Control.RedButton#   Click$# RedButton_Click��$��Button��$
��Left=�$��155,182,0,0q�$	��Top=�$��75��    MyStyle.Control.BlueButton  $��Button��$
��Left=�$��235,182,0,0q�$	��Top=�$��75��!   MyStyle.Control.GreenButton  $��Button��$
��Left=�$��320,182,0,0q�$	��Top=�$��75��9� $��Expander��$
��Left=�$	��100��$��341,227,0,0q�$	��Top=�$	��359��.��� 
������ .+�+   %MyStyle.Control.ListBoxWithAutoScroll  -   $  Name$$ Listboxtemp��I  CActiproSoftware.Windows.Controls.Docking.Primitives.NonTopmostPopup  -   %  Name$% popupFlashToolSetting������ *IsDropDownOpen+& �� RelativeSource& �� *TemplatedParent+.��� $	��124��$	��126��
�������.+��� $��1q����	#AA666666._�� $��10q�
�������$��Stretch=�$��Stretch=�c� $
��Left=�$��58��$��355,327,0,0q�$	��Top=�$	��425��.@�  -   $ 
stb01_Copy��$��23��$��5q�$	��Top=�$	��120��$
��Left=�$��13�� �� *	StyleName+$ windows��$ OneWay=��� -   $��C001-按鈕��$
��Left=�$��0,5,0,0q�$	��Top=�$��94��$��1��$��28���� -   $ cbStyleName_Copy��$
��Left=�$��5q�$	��Top=�$	��149��$	 Key��$ Value��$ 0��$��18������ *PageStyleList+�� -   $��C001-按鈕��$
��Left=�$	��Top=�$��5q�$��94��$��1��$��33���� -   $ cbStyleName_Copy1��$
��Left=�$��5q�$	��Top=�$	��149��$	 Key��$ Value��$ 0��$��18������ *PageStyleList+�� -   $��C001-按鈕��$
��Left=�$	��Top=�$��5q�$��94��$��1��$��33���� -   $ cbStyleName_Copy2��$
��Left=�$��5q�$	��Top=�$	��149��$	 Key��$ Value��$ 0��$��18������ *PageStyleList+�� -   $��C001-按鈕��$
��Left=�$	��Top=�$��5q�$��94��$��1��$��33���� -   $ cbStyleName_Copy3��$
��Left=�$��5q�$	��Top=�$	��149��$	 Key��$ Value��$ 0��$��18������ *PageStyleList+