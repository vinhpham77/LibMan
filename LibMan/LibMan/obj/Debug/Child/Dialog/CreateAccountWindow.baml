   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:GUI.Child.DialogGUI.Child.Dialog  5      *    $GUI.Child.Dialog.CreateAccountWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:GUI.Child.Dialog     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  Tạo tài khoản��5	      $	��580��5
      $	��500��5         MaterialDesignPaper#���   5        MaterialDesignFont#���  5       � Icon$ ../../img/logo.ico��5       � 
ResizeMode$ CanMinimize=�5      $��16(�5      $��Regular"�5        MaterialDesignBody#���  5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5      .��5      � $��70,20q�6    +� FocusedElement 6   ��  �� ElementName$ txtUsername�� � 	Resources 5   
   ��%    	 � RowDefinitions	 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      $��2* �6   �� 5      $
��1.4* �6   
 � ColumnDefinitions
 5!   
   �� 5"      $��0.38* �6   �� 5#      $��0.12* �6   �� 5$      $��0.50* �6   .+�5&   
   �� -   5         ��Name$ txtUsername��5'      $��0��5(      $��Bottom=�5)      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên đăng nhập��5*       % !MaterialDesignFloatingHintTextBox#��[ 5+      �� 5,   
   -   5         ��Name$ cbxRole��5-      $��1��5.      $��Bottom=�5/      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ PrimaryLight=�50      $ Vai trò��51       �� DisplayMemberPath$
 Name��52       �� IsTextSearchEnabled .  �� SelectedValuePath$ ID��54       & "MaterialDesignFloatingHintComboBox#��[ 55      G� 56   
   -   5         G�Name$ txtPassword��57      $��2��58      $��Bottom=�59      $ Mật khẩu��5:       ) %MaterialDesignFloatingHintPasswordBox#��[ 5;      G� 5<   
   -   5        $ txtRePassword��5=      $��3��5>      $��Bottom=�5?      $ Nhập lại mật khẩu��5@      #��[ 5A      �� 5B   
   -   5        $ txtFullname��5C      $��0��5D      $��2��5E      $��Bottom=�5F      $ 	Họ tên��5G      #��[ 5H      (  "System.Windows.Controls.DatePicker  5I   
   -   5          Name$ dtpBirthday��5J      $��1��5K      $��2��5L      $��Bottom=�5M      $ 
Ngày sinh��5N       ( $MaterialDesignFloatingHintDatePicker#��[ 5O      �� 5P   
   $��2��5Q      $��2��5R      $��Bottom=�5S       �� Orientation$ 
Horizontal=�5T       � ToolTip$ Giới tính��5U      .+�5V      	� -   5         	�Name$ rdMale��5W      $��Bottom=�5X      #���  5Y       d� 	IsChecked$
 TrueY�5Z         MaterialDesignTabRadioButton#��[ 5[      .��5\      �� .+�5]      '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�6.      Kind$ 
GenderMale=�6K   �� 5^      $��0,2,0,0q�6    $	��Nam��61   5_      5`      	� 5a      -   5        $ rdFemale��5b      $��Bottom=�5c      #���  5d      #��[ 5e      .��5f      �� .+�5g        $��Center=�6.   $ GenderFemale=�6K   �� 5h      $��0,2,0,0q�6    $
��Nữ��61   5i      5j      5k      �� 5l   
   -	   5        $ txtID��5m      $��3��5n      $��2��5o      $��Bottom=�5p      $ 	CMND/CCCD��5q       �� 	MaxLength$ 12��5r      #��[ 5s      �� 5t   
   -
   5        $ 
txtAddress��5u      $��4��5v      $��2��5w      $	��100��5x      $��Stretch=�5y      $ Địa chỉ��5z       �� AcceptsReturn . #��[ 5|       �� TextWrapping$
 Wrap=�5}      " �� VerticalScrollBarVisibility$
 Auto=�5~      �� 5   
   -   5         ��Name$ 	btnSubmit��5�      $��5��5�      $��2��5�      $��0,5,10,0q�5�      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 4��5�      $��Xác nhận��5�       �� 	IsDefault .  ! MaterialDesignFlatMidBgButton#��[ 5�      �� 5�   
   -   5        $ 	btnCancel��5�      $��5��5�      $��2��5�      $��0,5,0,0q�5�      $ 4��5�      $��
Huỷ bỏ��5�        �� IsCancel  .   	 MaterialDesignOutlinedButton#��[	 5�      5�      5�      