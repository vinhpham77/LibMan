   M S B A M L   `   `   `  ���� >  :DTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null&clr-namespace:DTO;assembly=DTODTO  > :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GUI.Child	GUI.Child    GUI.Child.AccountManPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     .dtoclr-namespace:DTO;assembly=DTO     )localclr-namespace:GUI.Child     _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006     MaterialDesignFont  N� 
FontFamily#  �   $��16(�$��Regular"�  MaterialDesignBody#���  &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�.���  � RowDefinitions �� $
��Auto ��� .+�]� $��0,0,0,14q�.+��� -    ��Name$ btnAddAccount��$��30��$��30��$
��Left=�$
��Left=� & "MaterialDesignIconForegroundButton#��[  � ToolTip$ Tạo tài khoản����0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$	 Add=�   Size$ 30X�'  !MaterialDesignThemes.Wpf.PackIcon  $��28��$��28��$	��3,0q�$��Bottom=�$
��Left=�   Kind$ Search=��� -   	 ��Name$	 txtAccountSearch��$	��150��$	��300��$��Bottom=�)  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Tìm kiếm��$
��Left=��� -   $ 
btnRefresh��$��28��$��28��$��Right=�$��Bottom=�$��Right=�#��[ $ 
Làm mới����  $ Refresh=�$ 25X�&   System.Windows.Controls.DataGrid  -     Name$ 
dtgAccount��$��1��   AutoGenerateColumns .     HeadersVisibility$ Column=�$   HorizontalScrollBarVisibility$
 Auto=�   
IsReadOnly . "   VerticalScrollBarVisibility$
 Auto=�   Columns 0  *System.Windows.Controls.DataGridTextColumn   ) %MaterialDesignDataGridTextColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ ,  &System.Windows.Controls.DataGridColumn   Header$ Tên đăng nhập��   Binding �� *
Username+  # [ $ Vai trò�� �� *
RoleName+  # [ $ 	Họ tên�� �� *
Fullname+  # [ $ 
Ngày sinh�� �� *
Birthday+ �� StringFormat$ d��4	  .System.Windows.Controls.DataGridCheckBoxColumn	   - )MaterialDesignDataGridCheckBoxColumnStyle# [ $ Giới tính�� �� *Gender+  # [ $ 	CMND/CCCD�� �� *ID+  # [ $ Địa chỉ�� �� *	Address+	  # [ $ Trạng thái�� �� *Status+4
  .System.Windows.Controls.DataGridTemplateColumn
    MaterialDesignDataGridCell   	CellStyle# [ $ 	Thao tác�� 
  CellTemplate �� .R���  �� Orientation$ 
Horizontal=�.+��� -   $��25��$��25��$��0q�$
��Left=�$	��Top=� " MaterialDesignFlatDarkBgButton#��[ $ Sửa����  $
 Edit=��� -   $��25��$��25��$	��5,0q�$��0q�#��[ $
 Xoá����  $ Delete=��� -   $��25��$��25��$��0q�#��[ $ Đổi mật khẩu����  $ KeyChain=��� -   $��25��$��25��$	��5,0q�$��0q�#��[ $ Cấp quyền/Khoá����  $ AccountConvert=�