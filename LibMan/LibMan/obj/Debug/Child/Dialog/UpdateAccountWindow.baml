   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5      *    $GUI.Child.Dialog.UpdateAccountWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:GUI     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $	��480��5	      $	��580��5
         MaterialDesignPaper#���   5        MaterialDesignFont#���  5        � Icon$  ../../img/logo.ico��5       � 
ResizeMode$ NoResize=�5      $��16(�5      $��Regular"�5        MaterialDesignBody#���  5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5      .��5      � $��120,20q�6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      $
��1.2* �6   �� 5      �� 5      $��2* �6   �� 5       $
��1.6* �6   .+�5"   
   �� -   5         ��Name$ txtUsername��5#      $��Bottom=�5$      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên tài khoản��5%      {�.   % !MaterialDesignFloatingHintTextBox#��[ 5'      �� 5(   
   -   5         ��Name$ cbxRole��5)      $��1��5*      $��Bottom=�5+      .  (MaterialDesignThemes.Wpf.ColorZoneAssist	   Mode$	 PrimaryLight=�5,      $ Vai trò��5-      
 �� DisplayMemberPath$

 Name��5.       �� IsTextSearchEnabled .  �� SelectedValuePath$ ID��50       & "MaterialDesignFloatingHintComboBox#��[ 51      �� 52   
   -   5        $ txtFullname��53      $��2��54      $��Bottom=�55      $ 	Họ tên��56      #��[ 57      (  "System.Windows.Controls.DatePicker  58   
   -   5          Name$ dtpBirthday��59      $��3��5:      $��Bottom=�5;      $ 
Ngày sinh��5<       ( $MaterialDesignFloatingHintDatePicker#��[ 5=      �� 5>   
   $��4��5?      $��Center=�5@      $��Bottom=�5A       �� Orientation$ 
Horizontal=�5B       � ToolTip$ Giới tính��5C      .+�5D      	� -   5         	�Name$ rdMale��5E      $��Bottom=�5F      #���  5G         MaterialDesignTabRadioButton#��[ 5H      .��5I      �� .+�5J      '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�6.      Kind$ 
GenderMale=�6K   �� 5K      $��0,2,0,0q�6    $	��Nam��61   5L      5M      	� 5N      -   5        $ rdFemale��5O      $��Bottom=�5P      #���  5Q      #��[ 5R      .��5S      �� .+�5T        $��Center=�6.   $ GenderFemale=�6K   �� 5U      $��0,2,0,0q�6    $
��Nữ��61   5V      5W      5X      �� 5Y   
   -   5        $ txtID��5Z      $��5��5[      $��Bottom=�5\      $ 	CMND/CCCD��5]       �� 	MaxLength$ 12��5^      #��[ 5_      �� 5`   
   -   5        $ 
txtAddress��5a      $��6��5b      $��90��5c      $��0,6,0,0q�5d      $ Địa chỉ��5e       �� AcceptsReturn . #��[ 5g       �� TextWrapping$
 Wrap=�5h      " �� VerticalScrollBarVisibility$
 Auto=�5i      � 5j   
   $��7��6   $��0,10,0,0q�6    � ColumnDefinitions 5k      �� 5l      �� 5m      .+�5o      �� -	   5         ��Name$ 	btnSubmit��5p      $��0��5q      $��0,0,10,0q�5r      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 4��5s      $��Xác nhận��5u       �� 	IsDefault .  ! MaterialDesignFlatMidBgButton#��[ 5w      �� 5x      -
   5        $ 	btnCancel��5y      $��1��5z      $ 4��5{      $��
Huỷ bỏ��5}       �� IsCancel .    MaterialDesignOutlinedButton#��[ 5      5�      5�      5�      