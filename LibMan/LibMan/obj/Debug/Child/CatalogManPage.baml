   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GUI.Child	GUI.Child  5          GUI.Child.CatalogManPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:GUI.Child     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5         MaterialDesignFont  N� 
FontFamily#  �   5	      $��16(�5
      $��Regular"�5        MaterialDesignBody#���  5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   ]� $��0,0,0,14q�6   .+�5      �� -   5         ��Name$ btnAddCatalog��5      $��30��5      $��30��5      $
��Left=�5       & "MaterialDesignIconForegroundButton#��[ 5       � ToolTip$ Thêm danh mục��5       ��5      0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$	 Add=�   Size$ 30X�5       '  !MaterialDesignThemes.Wpf.PackIcon  5!      $��28��5"      $��28��5#      $	��3,0q�5$      $��Bottom=�5%      $
��Left=�5&         Kind$ Search=�5'      �� 5(      -   5        	 ��Name$	 txtCatalogSearch��5)      $	��150��5*      $	��300��5+      $��Bottom=�5,      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Tìm kiếm��5-      $
��Left=�5.      5/      �� 50      -   5        $ 
btnRefresh��51      $��28��52      $��28��53      $��Right=�54      $��Bottom=�55      $��Right=�59      #��[ 5:      $ 
Làm mới��5;      ��57        $ Refresh=�$ 25X�5;      5<      &   System.Windows.Controls.DataGrid  5=   
   -   5          Name$ 
dtgCatalog��5>      $��1��5?         AutoGenerateColumns .     HeadersVisibility$ Column=�5A      $   HorizontalScrollBarVisibility$
 Auto=�5B         
IsReadOnly . "   VerticalScrollBarVisibility$
 Auto=�5D         Columns 5E      0  *System.Windows.Controls.DataGridTextColumn  5F       ) %MaterialDesignDataGridTextColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 5H      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã danh mục��5I         Binding 5G      �� *ID+5I        5J      # [ 5L      $ Tên danh mục��5M       5K      �� *Name+5M      4	  .System.Windows.Controls.DataGridTemplateColumn	  5N        MaterialDesignDataGridCell   	CellStyle# [ 6)   $ 	Thao tác��6a    	  CellTemplate 5O      �� 5P      .R�5Q      ��  �� Orientation$ 
Horizontal=�6)   .+�5R   "   �� -   5        $��25��5S   %   $��25��5T   %   $��0q�5U   %   $
��Left=�5V   %   $	��Top=�5W   %    " MaterialDesignFlatDarkBgButton#��[ 5Z   %   $ Sửa��5[   %   ��5Y   %     $
 Edit=�5[   %   �� 5\   "   -   5        $��25��5]   %   $��25��5^   %   $	��5,0q�5_   %   $��0q�5`   %   #��[ 5c   %   $
 Xoá��5d   %   ��5b   %     $ Delete=�5d   %   5e      5f      5h      5j      5k      5l      