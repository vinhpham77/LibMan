   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5          GUI.AdminWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:GUI     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  Thư viện��5	      $
��1300��5
      $	��750��5          MaterialDesignDarkBackground#���   5        MaterialDesignFont#���  5       � Icon$ img/logo.ico��5      $��16(�5      $��Regular"�5         MaterialDesignDarkForeground#���  5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��2��5       $��10q�5!      $	��Top=�5"         Mode$ 
PrimaryMid=�5#      .��5$      ]� $	��5,5q�6   .+�5%      �� $��Center=�5&      $��Right=�5'       �� Orientation$ 
Horizontal=�5(      .+�5)      �� .��5*      '  !MaterialDesignThemes.Wpf.PackIcon  $��30��5+      $��30��5,      
�������	   Kind$	 
AccountTie=�5.      
 � ToolTip$
 Quản trị viên��5/      50      �� 51      -   5         ��Name$ lblUsername��52      $��Center=�53      $��18(�54      55      �� 56      $
��Left=�6   $ 
Horizontal=�63   .+�57      �� $��40��58      $��img/logo.ico��59      $
��Fill=�5:      �� 5;      -   5        $ lblHome��5<      $��Center=�5=      $��18(�5>      $
��Bold"�5?      .��6+   QUẢN LÝ THƯ VIỆN5A      5B      5C      5D      � 5E   
   $��1��6   #���   6   .+�5F      �� -   5         ��Name$ lvwMenu��5G      $��1��5H      $��Center=�5I       � 	Resources 5K       �� 
TargetType �� Property �� Value��%d  '��       '  �     �� 5L      " ��6   .�5M      ��  � ��$ 16(�65   �� 5N       � ��$ Center=�6>   �� 5O       � ��
 �����67   5P      �� 5Q      "  6   .�5R      ��  � ��$ 35��62   �� 5S       � ��$ 35��63   �� 5T       � ��
 �����67   �� 5U       � ��$ Center=�6@   5V      5W      .@�5X      �� -   5         ��Name$ 
lwiAccount��5X      .��5Y      �� .+�5Z        $	��0,2q�62   $	 
AccountBox=�6?   �� 5[      $��Tài khoản��6$   5\      5]      �� 5^      -   5        $ lwiBook��5^      .��5_      �� .+�5`        $
	 Book=�62   �� 5a      $��Sách��6$   5b      5c      �� 5d      -   5        $ 
lwiCatalog��5d      .��5e      �� .+�5f        $		 Tag=�62   �� 5g      $��
Danh mục��6$   5h      5i      �� 5j      -   5        $ lwiLoan��5j      .��5k      �� .+�5l        $	 	BookClock=�62   �� 5m      $��Mượn trả��6$   5n      5o      �� 5p      -   5        $ 	lwiLogout��5p      .��5q      �� .+�5r        $	 Logout=�62   �� 5s      $��Đăng xuất��6$   5t      5u      5v      5w      #  MaterialDesignThemes.Wpf.Card  5x   
   $��1��6   $��1��6+   .��5y       � -	   5          �Name$ frmChild��5z      $��35,30,35,40q�5{      $��Stretch=�5|      $��Stretch=�5}        � NavigationUIVisibility$ Hidden=�5~      5      5�      5�      