   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5          GUI.ReaderWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:GUI     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  Thư viện��5	      $
��1300��5
      $	��750��5         MaterialDesignPaper#���   5        MaterialDesignFont#���  5       � Icon$ img/logo.ico��5      $��16(�5      $��Regular"�5        MaterialDesignBody#���  5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��2��5       $��10q�5!      $	��Top=�5"         Mode$ 
PrimaryMid=�5#      .��5$      ]� $	��5,5q�6   .+�5%      �� $��Center=�5&      $��Right=�5'       �� Orientation$ 
Horizontal=�5(      .+�5)      �� .��5*      '  !MaterialDesignThemes.Wpf.PackIcon  $��30��5+      $��30��5,      
�������	   Kind$	 Account=�5.      
 � ToolTip$
 Đọc giả��5/      50      �� 51      -   5         ��Name$ lblUsername��52      $��Center=�53      $��16(�54      55      �� 56      $
��Left=�6   $ 
Horizontal=�63   .+�57      �� $��40��58      $��img/logo.ico��59      $
��Fill=�5:      �� 5;      -   5        $ lblHome��5<      $��Center=�5=      $��18(�5>      $
��Bold"�5?      .��6+   THƯ VIỆN5A      5B      5C      5D      � 5E   
   $��1��6      MaterialDesignDarkBackground#���  6   .+�5F      �� -   5         ��Name$ lvwMenu��5G      $��1��5H      $��Center=�5I       � 	Resources 5K       �� 
TargetType �� Property �� Value��%�  '��       '  �     �� 5L      " ��6   .�5M      ��  � ��$ 15(�65   �� 5N       �@��Padding$ 2q�64   �� 5O       � ��$ Center=�6>   �� 5P       � ��
 �����67   5Q      �� 5R      "  6   .�5S      ��  � ��$ 35��62   �� 5T       � ��$ 35��63   �� 5U       � ��
 �����67   �� 5V       � ��$ Center=�6@   5W      5X      .@�5Y      �� -   5         ��Name$ lwiBook��5Y      .��5Z      �� .+�5[        $
	 Book=�62   �� 5\      $��Sách��6$   5]      5^      �� 5_      -   5        $ lwiLoan��5_      .��5`      �� .+�5a        $	 	BookClock=�62   �� 5b      $��Mượn trả��6$   5c      5d      �� 5e      -   5        $ 	lwiLogout��5e      .��5f      �� .+�5g        $	 Logout=�62   �� 5h      $��Đăng xuất��6$   5i      5j      5k      5l      #  MaterialDesignThemes.Wpf.Card  5m   
   $��1��6   $��1��6+   .��5n       � -   5          �Name$ frmChild��5o      $��35,25,35,40q�5p      $��Stretch=�5q      $��Stretch=�5r        � NavigationUIVisibility$ Hidden=�5s      5t      5u      5v      