   M S B A M L   `   `   `  ���� >  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GUI.Child	GUI.Child      GUI.Child.LoanManPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:GUI.Child     _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006     MaterialDesignFont  N� 
FontFamily#  �   $��16(�$��Regular"�  MaterialDesignBody#���  &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�.���  � RowDefinitions �� $
��Auto ��� .+�]� $��0,0,0,14q�.+��� -    ��Name$ btnReturnBook��$��30��$��30��$
��Left=� & "MaterialDesignIconForegroundButton#��[  � ToolTip$ Lập hoá đơn����0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$	 Add=�   Size$ 30X�'  !MaterialDesignThemes.Wpf.PackIcon  $��28��$��28��$	��3,0q�$��Bottom=�$
��Left=�   Kind$ Search=��� -   	 ��Name$	 txtLoanReturnSearch��$	��150��$	��300��$��Bottom=�)  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Tìm kiếm��$
��Left=��� -   $ 
btnRefresh��$��28��$��28��$��Right=�$��Bottom=�$��Right=�#��[ $ 
Làm mới����  $ Refresh=�$ 25X�&   System.Windows.Controls.DataGrid  -     Name$ dtgLoan��$��1��   AutoGenerateColumns .     HeadersVisibility$ Column=�$   HorizontalScrollBarVisibility$
 Auto=�   
IsReadOnly .    SelectionMode$ Extended=�"   VerticalScrollBarVisibility$
 Auto=�   Columns 0  *System.Windows.Controls.DataGridTextColumn   ) %MaterialDesignDataGridTextColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ ,  &System.Windows.Controls.DataGridColumn   Header$ Mã giao dịch��   Binding �� *LoanID+  # [ $ Tên đăng nhập�� �� *
Username+  # [ $ 	Mã sách�� �� *BookID+  # [ $ Tựa đề�� �� *	BookTitle+  # [ $ Ngày mượn�� �� *
LoanDate+ �� StringFormat$ d��  # [ $ Ngày hẹn trả�� �� *	DueDate+$ d��  # [ $ Ngày trả�� �� *ReturnedDate+$ d��  # [ $ Phí(đ)�� �� *Fee+$ {0:N0}��4	  .System.Windows.Controls.DataGridTemplateColumn	    MaterialDesignDataGridCell   	CellStyle# [ $ 	Thao tác�� 	  CellTemplate �� .R���  �� Orientation$ 
Horizontal=�.+��� -   $��25��$��25��$��0q� " MaterialDesignFlatDarkBgButton#��[ $ Lập hoá đơn����  $ ReceiptTextPlusOutline=��� -   $��25��$��25��$	��5,0q�$��0q�#��[ $
 Xoá����  $ Delete=�