   M S B A M L   `   `   `  ����>  :DTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null&clr-namespace:DTO;assembly=DTODTO  5      > :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GUI.Child	GUI.Child 5         GUI.Child.AccountManPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .dtoclr-namespace:DTO;assembly=DTO     5      )localclr-namespace:GUI.Child     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5	         MaterialDesignFont  N� 
FontFamily#  �   5
      $��16(�5      $��Regular"�5        MaterialDesignBody#���  5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   ]� $��0,0,0,14q�6   .+�5      �� -   5         ��Name$ btnAddAccount��5      $��30��5      $��30��5      $
��Left=�5      $
��Left=�5       & "MaterialDesignIconForegroundButton#��[ 5        � ToolTip$ Tạo tài khoản��5!      ��5      0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$	 Add=�   Size$ 30X�5!      '  !MaterialDesignThemes.Wpf.PackIcon  5"      $��28��5#      $��28��5$      $	��3,0q�5%      $��Bottom=�5&      $
��Left=�5'         Kind$ Search=�5(      �� 5)      -   5        	 ��Name$	 txtAccountSearch��5*      $	��150��5+      $	��300��5,      $��Bottom=�5-      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Tìm kiếm��5.      $
��Left=�5/      50      �� 51      -   5        $ 
btnRefresh��52      $��28��53      $��28��54      $��Right=�55      $��Bottom=�56      $��Right=�5:      #��[ 5;      $ 
Làm mới��5<      ��58        $ Refresh=�$ 25X�5<      5=      &   System.Windows.Controls.DataGrid  5>   
   -   5          Name$ 
dtgAccount��5?      $��1��5@         AutoGenerateColumns .     HeadersVisibility$ Column=�5B      $   HorizontalScrollBarVisibility$
 Auto=�5C         
IsReadOnly . "   VerticalScrollBarVisibility$
 Auto=�5E         Columns 5F      0  *System.Windows.Controls.DataGridTextColumn  5G       ) %MaterialDesignDataGridTextColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 5I      ,  &System.Windows.Controls.DataGridColumn   Header$ Tên đăng nhập��5J         Binding 5H      �� *
Username+5J        5K      # [ 5M      $ Vai trò��5N       5L      �� *
RoleName+5N        5O      # [ 5Q      $ 	Họ tên��5R       5P      �� *
Fullname+5R        5S      # [ 5U      $ 
Ngày sinh��5V       5T      �� *
Birthday+ �� StringFormat$ d��5V      4	  .System.Windows.Controls.DataGridCheckBoxColumn	  5W       - )MaterialDesignDataGridCheckBoxColumnStyle# [ 5Y      $ Giới tính��5Z       5X      �� *Gender+5Z        5[      # [ 5]      $ 	CMND/CCCD��5^       5\      �� *ID+5^        5_      # [ 5a      $ Địa chỉ��5b       5`      �� *	Address+5b      	  5c      # [ 5e      $ Trạng thái��5f       5d      �� *Status+5f      4
  .System.Windows.Controls.DataGridTemplateColumn
  5g        MaterialDesignDataGridCell   	CellStyle# [ 6)   $ 	Thao tác��6a    
  CellTemplate 5h      �� 5i      .R�5j      ��  �� Orientation$ 
Horizontal=�6)   .+�5k   "   �� -   5        $��25��5l   %   $��25��5m   %   $��0q�5n   %   $
��Left=�5o   %   $	��Top=�5p   %    " MaterialDesignFlatDarkBgButton#��[ 5s   %   $ Sửa��5t   %   ��5r   %     $
 Edit=�5t   %   �� 5u   "   -   5        $��25��5v   %   $��25��5w   %   $	��5,0q�5x   %   $��0q�5y   %   #��[ 5|   %   $
 Xoá��5}   %   ��5{   %     $ Delete=�5}   %   �� 5~   "   -   5        $��25��5   %   $��25��5�   %   $��0q�5�   %   #��[ 5�   %   $ Đổi mật khẩu��5�   %   ��5�   %     $ KeyChain=�5�   %   �� 5�   "   -   5        $��25��5�   %   $��25��5�   %   $	��5,0q�5�   %   $��0q�5�   %   #��[ 5�   %   $ Cấp quyền/Khoá��5�   %   ��5�   %     $ AccountConvert=�5�   %   5�      5�      5�      5�      5�      5�      