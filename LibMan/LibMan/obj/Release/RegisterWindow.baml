   M S B A M L   `   `   `  ���� >  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI      GUI.RegisterWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     #localclr-namespace:GUI     _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006    � Title$  Thư viện��$	��850��$	��720��   MaterialDesignPaper#���     MaterialDesignFont#���   � Icon$ img/logo.ico�� � 
ResizeMode$ CanMinimize=�$��16(�$��16(�$��Regular"�  MaterialDesignBody#���  &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=� � WindowStartupLocation$ CenterScreen=�.��#  MaterialDesignThemes.Wpf.Card  $��140,50q�   UniformCornerRadius$ 10Q� +� FocusedElement ��  �� ElementName$ txtUsername��.��� $��70,20q�	 � 	Resources	 
 �� 
TargetType �� Property �� Value  PrimaryHueMidBrush��%p   '��       �� "
 ��.���  � ��$ Center=���  � ��# �  ��  � ��$ 24(���  � ��$ 0q� � RowDefinitions �� �� �� �� �� �� $
��2.2* ��� $
��1.8* � � ColumnDefinitions �� $��0.35* ��� $��0.12* ��� $��0.53* �.+��� .��TÀI KHOẢN�� -    ��Name$ txtUsername��$��1��$��Bottom=�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên đăng nhập�� % !MaterialDesignFloatingHintTextBox#��[ G� -    G�Name$ txtPassword��$��2��$��Bottom=�$ Mật khẩu�� ) %MaterialDesignFloatingHintPasswordBox#��[ G� -   $ txtRePassword��$��3��$��Bottom=�$ Nhập lại mật khẩu��#��[ �� $��2��.��
THÔNG TIN�� -   $ txtFullname��$��1��$��2��$��Bottom=�$ 	Họ tên��#��[ (  "System.Windows.Controls.DatePicker  -     Name$ 
dpBirthday��$��2��$��2��$��Bottom=�$ 
Ngày sinh�� ( $MaterialDesignFloatingHintDatePicker#��[ �� $��3��$��2��$��Bottom=� �� Orientation$ 
Horizontal=� � ToolTip$ Giới tính��.+�	� -    	�Name$ rdMale��$��Bottom=�#���   d� 	IsChecked$
 TrueY�   MaterialDesignTabRadioButton#��[ .���� .+�'  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�   Kind$ 
GenderMale=��� $��0,2,0,0q�$	��Nam��	� -   $ rdFemale��$��Bottom=�#���  #��[ .���� .+�  $��Center=�$ GenderFemale=��� $��0,2,0,0q�$
��Nữ���� -   $ txtID��$��4��$��2��$��Bottom=�$ 	CMND/CCCD�� �� 	MaxLength$ 12��#��[ �� -	   $ 
txtAddress��$��5��$��2��$	��100��$ Địa chỉ�� �� AcceptsReturn . #��[  �� TextWrapping$
 Wrap=�" �� VerticalScrollBarVisibility$
 Auto=��� $��6��$��3��$��Center=�.+��� -
    ��Name$ btnRegister��$	��0,5q�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 4��$��
ĐĂNG KÝ�� �� 	IsDefault .  ! MaterialDesignFlatMidBgButton#��[ �� -   $ 	btnCancel��$��7��$��3��$��Center=�$��
Quay lại�� �� IsCancel .  	 MaterialDesignFlatButton#��[	 