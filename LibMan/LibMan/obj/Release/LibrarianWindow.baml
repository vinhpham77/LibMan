   M S B A M L   `   `   `  ���� >  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI      GUI.LibrarianWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     #localclr-namespace:GUI     _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006    � Title$  Thư viện��$
��1300��$	��750��   MaterialDesignPaper#���     MaterialDesignFont#���   � Icon$ img/logo.ico��$��16(�$��Regular"�  MaterialDesignBody#���  &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=� � WindowStartupLocation$ CenterScreen=�.���  � RowDefinitions �� $
��auto ���  � ColumnDefinitions �� $
��auto ��� .+�(  "MaterialDesignThemes.Wpf.ColorZone  $��2��$��10q�$	��Top=�   Mode$ 
PrimaryMid=�.��]� $	��5,5q�.+��� $��Center=�$��Right=� �� Orientation$ 
Horizontal=�.+��� .��'  !MaterialDesignThemes.Wpf.PackIcon  $��30��$��30��
�������	   Kind$	 AccountSettings=�
 � ToolTip$
 
Thủ thư���� -    ��Name$ lblUsername��$��Center=�$��18(��� $
��Left=�$ 
Horizontal=�.+��� $��40��$��img/logo.ico��$
��Fill=��� -   $ lblHome��$��Center=�$��18(�$
��Bold"�.��QUẢN LÝ THƯ VIỆN� $��1��   MaterialDesignDarkBackground#���  .+��� -    ��Name$ lvwMenu��$��1��$��Center=� � 	Resources  �� 
TargetType �� Property �� Value��%�   '��       '  r     �� " ��.���  � ��$ 15(���  �@��Padding$ 2q���  � ��$ Center=���  � ��
 ������� "  .���  � ��$ 35����  � ��$ 35����  � ��
 �������  � ��$ Center=�.@��� -    ��Name$ lwiBook��.���� .+�  $
	 Book=��� $��Sách���� -   $ 
lwiCatalog��.���� .+�  $		 Tag=��� $��
Danh mục���� -   $ lwiLoan��.���� .+�  $	 	BookClock=��� $��Mượn trả���� -   $ 	lwiLogout��.���� .+�  $	 Logout=��� $��Đăng xuất��#  MaterialDesignThemes.Wpf.Card  $��1��$��1��.�� � -     �Name$ frmChild��$��35,25,35,40q�  � NavigationUIVisibility$ Hidden=�