   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5          GUI.LibrarianWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:GUI     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  Thư viện��5	      $
��1300��5
      $	��750��5         MaterialDesignPaper#���   5        MaterialDesignFont#���  5       � Icon$ img/logo.ico��5      $��16(�5      $��Regular"�5        MaterialDesignBody#���  5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5    
   (  "MaterialDesignThemes.Wpf.ColorZone  $��2��5!      $��10q�5"      $	��Top=�5#         Mode$ 
PrimaryMid=�5$      .��5%      ]� $	��5,5q�6   .+�5&      �� $��Center=�5'      $��Right=�5(       �� Orientation$ 
Horizontal=�5)      .+�5*      �� .��5+      '  !MaterialDesignThemes.Wpf.PackIcon  $��30��5,      $��30��5-      
�������	   Kind$	 AccountSettings=�5/      
 � ToolTip$
 
Thủ thư��50      51      �� 52      -   5         ��Name$ lblUsername��53      $��Center=�54      $��18(�55      56      �� 57      $
��Left=�6   $ 
Horizontal=�63   .+�58      �� $��40��59      $��img/logo.ico��5:      $
��Fill=�5;      �� 5<      -   5        $ lblHome��5=      $��Center=�5>      $��18(�5?      $
��Bold"�5@      .��6+   QUẢN LÝ THƯ VIỆN5B      5C      5D      5E      � 5F   
   $��1��6      MaterialDesignDarkBackground#���  6   .+�5G      �� -   5         ��Name$ lvwMenu��5H      $��1��5I      $��Center=�5J       � 	Resources 5L       �� 
TargetType �� Property �� Value��%�  '��       '  �     �� 5M      " ��6   .�5N      ��  � ��$ 15(�65   �� 5O       �@��Padding$ 2q�64   �� 5P       � ��$ Center=�6>   �� 5Q       � ��
 �����67   5R      �� 5S      "  6   .�5T      ��  � ��$ 35��62   �� 5U       � ��$ 35��63   �� 5V       � ��
 �����67   �� 5W       � ��$ Center=�6@   5X      5Y      .@�5Z      �� -   5         ��Name$ lwiBook��5Z      .��5[      �� .+�5\        $
	 Book=�62   �� 5]      $��Sách��6$   5^      5_      �� 5`      -   5        $ 
lwiCatalog��5`      .��5a      �� .+�5b        $		 Tag=�62   �� 5c      $��
Danh mục��6$   5d      5e      �� 5f      -   5        $ lwiLoan��5f      .��5g      �� .+�5h        $	 	BookClock=�62   �� 5i      $��Mượn trả��6$   5j      5k      �� 5l      -   5        $ 	lwiLogout��5l      .��5m      �� .+�5n        $	 Logout=�62   �� 5o      $��Đăng xuất��6$   5p      5q      5r      5s      #  MaterialDesignThemes.Wpf.Card  5t   
   $��1��6   $��1��6+   .��5u       � -   5          �Name$ frmChild��5v      $��35,25,35,40q�5w        � NavigationUIVisibility$ Hidden=�5x      5y      5z      5{      