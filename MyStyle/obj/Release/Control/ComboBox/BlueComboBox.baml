   M S B A M L   `   `   `  ���� a  ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes  I EMyStyle, Version=1.0.6578.23344, Culture=neutral, PublicKeyToken=null1clr-namespace:MyStyle.ControlMyStyle.Control 1clr-namespace:MyStyle.CommandMyStyle.Command "   MyStyle.Control.BlueComboBox   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     d `ActiproSoftware.Shared.Wpf, Version=15.1.621.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9Ashared4http://schemas.actiprosoftware.com/winfx/xaml/shared  d `ActiproSoftware.Charts.Wpf, Version=15.1.621.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9c _ActiproSoftware.Views.Wpf, Version=15.1.621.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9i	 eActiproSoftware.MicroCharts.Wpf, Version=15.1.621.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9j
 fActiproSoftware.SyntaxEditor.Wpf, Version=15.1.621.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9e aActiproSoftware.Docking.Wpf, Version=15.1.621.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9e aActiproSoftware.Editors.Wpf, Version=15.1.621.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9j fActiproSoftware.PropertyGrid.Wpf, Version=15.1.621.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9Othemes4http://schemas.actiprosoftware.com/winfx/xaml/themes   	  
    eThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero   	  
    7localclr-namespace:MyStyle.Control   	  
    9commandclr-namespace:MyStyle.Command   	  
      � 	Resources     ComboboxFocus �� Property �� Value J� SnapsToDevicePixels+  %MyStyle.Command.MyCurrentStyleManager   BrushWindowForeground �� StrokeDashArray  ComboBoxToggleButton �� 
TargetType!   BrushWindowTitleBackground �� 
TargetType	 �Name
 ��Name �� RadiusX �� RadiusY J� Opacity K� ZIndex ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName ^� 
Conditions �� Binding �� RelativeSource �� AncestorType �� Value   BrushEvenTriggerLevel2   BrushEvenTriggerLevel1  ComboBoxTemplate � ColumnDefinitions �Name � AllowsTransparency  �� Mode5   /Microsoft.Windows.Themes.SystemDropShadowChrome!  Name"   BrushWindowBorderBrush#   Color$ �� MaxDropDownHeight% �� ElementName&   BrushWindowBackground' ��Name( �� ClearTypeHint) ��Name* ��Name-  'System.Windows.Input.KeyboardNavigation+   DirectionalNavigation, d�Name- d� 	IsChecked. ��Name/ �� SelectionBoxItemTemplate0 �� SelectionBoxItem#1 �� SelectionBoxItemStringFormat2 �� ContentStringFormat3 J� IsHitTestVisible4 P� 
SourceName  ComboBoxEditableTextBox  ComboBoxEditableTemplate5 ��Name6 �� 
IsReadOnly  BlueComboBox7   BrushButtonBlue8 �� Triggers9 �� Padding: �� TextAlignment��%�  &	        &	 T     &	 �	    7  &	 #    &	     7  7  &	 I    7   7  7  '�� �    7   �� .���  � �� �� .R��� $��0,0,0,0q� . #��Z $��1��$	 1 2R��� " d�.���  �@�OverridesDefaultStyle . ��  � �� .  ��  � ��# Z ��  � ��# Z ��  � ��# Z ��  � ��$	 0.0q���  � |� .  ��  �@��	ClickMode$ Press=���  � �� �� " d�.R�� $	 markGrid��.+��� $

 mask��#��z��$��0q�$��0��$ 4��$ 4��$ 0Q�$ 10���� $ templateRoot��#��z��$ 4��#��z�� . ._��� $ splitBorder��$��Right=�$ 4��$��0q� . #��� r�._��� $ arrow��$��8��$��8��$K��Epack://application:,,,/MyStyle;component/Image/ComboBox_DownArrow.png��$��Uniform=�$��0q� P�  � {� .  . ��� $
 mask�� �@J�Opacity$	 0.8Q�^�  ��  �� *
IsEditable+ �� " �� true��  �� *IsMouseOver+ �� *Self+	 false��  �� *	IsPressed+ �� *Self+	 false��  �� *	IsEnabled+ �� *Self+ true.0��� $ templateRoot��# Z  � ���� $ templateRoot��# Z  � ���� $ splitBorder��# Z  � ���� $ splitBorder��# Z  � ��P�  �@J�IsMouseOver . . ��� $ templateRoot��# Z  � ��^�  ��  �� *IsMouseOver+ �� *Self+ true��  �� *
IsEditable+ �� " ��	 false.0��� $ templateRoot��# Z  � ��^�  ��  �� *IsMouseOver+ �� *Self+ true��  �� *
IsEditable+ �� " �� true.0��� $ templateRoot��# Z  � ��P�  � �� . . ��� $ templateRoot��# Z  � ���� $ templateRoot��# Z  � ��^�  ��  �� *	IsPressed+ �� *Self+ true��  �� *
IsEditable+ �� " ��	 false.0��� $ templateRoot��# Z  � ���� $ templateRoot��# Z  � ��^�  ��  �� *	IsPressed+ �� *Self+ true��  �� *
IsEditable+ �� " �� true.0��� $ templateRoot��# Z  � ���� $ templateRoot��# Z  � ���� $ splitBorder��# Z  � ���� $ splitBorder��# Z  � ��P�  � {� .  . ��� $
 mask�� �@J�Opacity$	 0.8Q�^�  ��  �� *	IsEnabled+ �� *Self+	 false��  �� *
IsEditable+ �� " ��	 false.0��� $
 mask�� �@J�Opacity$	 0.8Q�^�  ��  �� *	IsEnabled+ �� *Self+	 false��  �� *
IsEditable+ �� " �� true.0��� $
 mask�� �@J�Opacity$	 0.8Q��� " ��.R�� $	 templateRoot�� . #��z�� �� $��* ��� #��� r�$��0 �.+�� $ 
PART_Popup��$��2�� . $��1q�#��� .�$��Bottom=����� *IsDropDownOpen+$  TwoWay=� �� *TemplatedParent+.��  $! shadow��## Z" #��z$ ���� *ActualWidth+$% templateRoot��._��� $ dropDownBorder��#��Z $	��0.5q�#��Z& ._��� $' DropDownScrollViewer��#��Z" #��Z .��� $
	 grid��$( Enabled=�.+��� $) canvas��$
��Left=�$	��Top=�$��0��$��0��.+��� $
 
opaqueRect��
������ ���� *ActualHeight+$% dropDownBorder������ *ActualWidth+$% dropDownBorder���� $* ItemsPresenter��$��Center=�$+ 	Contained=�# z d� $, toggleButton��$��2��#��z��#��z��#��z��8��  - �� *IsDropDownOpen+$  TwoWay=� �� *TemplatedParent+� .+��� $. contentPresenter��#��z/ #��z��#��z0 #2 z1 #��z��3 .  #��z��# z #��z�� ^�  ��  �� *	IsEnabled+ �� *Self+	 falseP� $4 
PART_Popup�� �@�HasDropShadow . . ��� $ shadow�� � ��$ 0,0,5,5q�P�  �@��HasItems .  . ��� $ dropDownBorder�� � ��$ 95��P� $4 DropDownScrollViewer�� � �� .  . ��� $ 
opaqueRect�� �� *VerticalOffset+$% DropDownScrollViewer�� �@��Top�� $ 
opaqueRect�� �� *HorizontalOffset+$% DropDownScrollViewer�� �@��Left�� " ��.���  �@�OverridesDefaultStyle . ��  � ��# Z ��  � ��# Z ��  � ��# Z ��  � ��$	 0.0q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@J�	AllowDrop . ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R�� .+��� $ border��$��Center=�$��0q�$ 4,0,0,4��#��z�� . $ 5��._��� $' PART_ContentHost��|�.  $��Hidden=�$��Hidden=��� " ��.R�� $	 templateRoot�� . #��z��$��0q� �� $��* ��� #��� r�$��0 �.+�� $ 
PART_Popup��$��2�� . $��1q�#��� .�$��Bottom=����� *IsDropDownOpen+ �� *TemplatedParent+.��  $! shadow��## Z" #��z$ ���� *ActualWidth+$% templateRoot��._��� $ dropDownBorder��#��Z $	��0.5q�#��Z& ._��� $' DropDownScrollViewer��#��Z" #��Z .��� $
	 grid��$( Enabled=�.+��� $) canvas��$
��Left=�$	��Top=�$��0��$��0��.+��� $
 
opaqueRect��
������ ���� *ActualHeight+$% dropDownBorder������ *ActualWidth+$% dropDownBorder���� $* ItemsPresenter��$+ 	Contained=�# z d� $, toggleButton��$��2��#��z��#��z��#��z��8��  - �� *IsDropDownOpen+$  TwoWay=� �� *TemplatedParent+� .+��� $5 PART_EditableTextBox��#��z��$��0q�$��0q�8�� #��z��6 �� *
IsReadOnly+ �� *TemplatedParent+ ^�  ��  �� *	IsEnabled+ �� *Self+	 falseP�  �@J�IsKeyboardFocused . . ��� $ PART_EditableTextBox�� �@J�Opacity$	 0.8Q�P�  �@J�IsKeyboardFocusWithin . . ��� $ PART_EditableTextBox�� �@J�Opacity$	 0.8Q�P� $4 
PART_Popup�� �@�HasDropShadow . . ��� $ shadow�� � ��$ 0,0,5,5q�P�  �@��HasItems .  . ��� $ dropDownBorder�� � ��$ 95��P� $4 DropDownScrollViewer�� � �� .  . ��� $ 
opaqueRect�� �� *VerticalOffset+$% DropDownScrollViewer�� �@��Top�� $ 
opaqueRect�� �� *HorizontalOffset+$% DropDownScrollViewer�� �@��Left�� " ��.���  �@�FocusVisualStyle8   ��  � ��# Z7 ��  � ��# Z ��  � ��$ 0q���  � ��$
 Auto=���  � ��$
 Auto=���  � ��$ 6,3,5,3q���  � �� . ��  �@��PanningMode$
 Both=���  �@��IsFlicksEnabled .  ��  � ��8  8 P�  �@��
IsEditable . . ���  � �� .  ��  � ��$ 6,4,5,4q���  � ��8  �� " ��.���  �@J�SnapsToDevicePixels . ��  �@�FocusVisualStyle8   ��  � ��# Z ��  � ��# Z" ��  � ��$	 0.5q���  � ��$ Stretch=���  � ��$ Stretch=���  �@�OverridesDefaultStyle . ��  � ��$ 0q���  � �� �� " ��.R��� $��Border��#��z��#��z��$9 0q�$ 0��._�� .+��� $��0q�#��Z& �  �� $��7 ��� $��5 ��� $��* �.+��� $

 flag��$��0��$��7��$��15��#��Z $ 0Q��� $��2��$
: Left=�
������ #��z����  P�  �@��IsHighlighted . . ��� $
 flag�� �@J�Opacity$	 0.5Q�P�  �@��
IsSelected . . ��� $
 flag�� �@J�Opacity$ 1Q�