   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GUI.Child	GUI.Child  5          GUI.Child.BookManPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:GUI.Child     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5         MaterialDesignFont  N� 
FontFamily#  �   5	      $��16(�5
      $��Regular"�5        MaterialDesignBody#���  5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   ]� $��0,0,0,14q�6   .+�5      �� -   5         ��Name$ 
btnAddBook��5      $��30��5      $��30��5      $
��Left=�5      $
��Left=�5       & "MaterialDesignIconForegroundButton#��[ 5       � ToolTip$ Thêm sách��5       ��5      0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$	 Add=�   Size$ 30X�5       '  !MaterialDesignThemes.Wpf.PackIcon  5!      $��28��5"      $��28��5#      $	��3,0q�5$      $��Bottom=�5%      $
��Left=�5&         Kind$ Search=�5'      �� 5(      -   5        	 ��Name$	 txtBookSearch��5)      $	��150��5*      $	��300��5+      $��Bottom=�5,      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Tìm kiếm��5-      $
��Left=�5.      5/      �� 50      -   5        $ 
btnRefresh��51      $��28��52      $��28��53      $��Right=�54      $��Bottom=�55      $��Right=�59      #��[ 5:      $ 
Làm mới��5;      ��57        $ Refresh=�$ 25X�5;      5<      &   System.Windows.Controls.DataGrid  5=   
   -   5          Name$ dtgBook��5>      $��1��5?         AutoGenerateColumns .     HeadersVisibility$ Column=�5A      $   HorizontalScrollBarVisibility$
 Auto=�5B         
IsReadOnly . "   VerticalScrollBarVisibility$
 Auto=�5D         Columns 5E      0  *System.Windows.Controls.DataGridTextColumn  5F       ) %MaterialDesignDataGridTextColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 5H      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã sách��5I         Binding 5G      �� *BookID+5I        5J      # [ 5L      $ Tựa đề��5M       5K      �� *	BookTitle+5M        5N      # [ 5P      $ 
Danh mục��5Q       5O      �� *CatalogName+5Q        5R      # [ 5T      $ 
Tác giả��5U       5S      �� *Author+5U        5V      # [ 5X      $ Nhà xuất bản��5Y       5W      �� *	Publisher+5Y      4	  .System.Windows.Controls.DataGridTemplateColumn	  5Z        MaterialDesignDataGridCell   	CellStyle# [ 6)   $ 	Thao tác��6a    	  CellTemplate 5[      �� 5\      .R�5]      ��  �� Orientation$ 
Horizontal=�6)   .+�5^   "   �� -   5        $��25��5_   %   $��25��5`   %   $��0q�5a   %   $
��Left=�5b   %   $	��Top=�5c   %    " MaterialDesignFlatDarkBgButton#��[ 5f   %   $ Sửa��5g   %   ��5e   %     $
 Edit=�5g   %   �� 5h   "   -   5        $��25��5i   %   $��25��5j   %   $	��5,0q�5k   %   $��0q�5l   %   #��[ 5o   %   $
 Xoá��5p   %   ��5n   %     $ Delete=�5p   %   �� 5q   "   -   5        $��25��5r   %   $��25��5s   %   $��0q�5t   %   #��[ 5w   %   $ Cho mượn��5x   %   ��5v   %     $ HandExtended=�5x   %   5y      5z      5|      5~      5      5�      