   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GUI.Child	GUI.Child  5          GUI.Child.BookPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:GUI.Child     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5         MaterialDesignFont  N� 
FontFamily#  �   5	      $��16(�5
      $��Regular"�5        MaterialDesignBody#���  5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   ]� $��0,0,0,14q�6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  $��28��5      $��28��5      $	��3,0q�5      $��Bottom=�5      $
��Left=�5         Kind$ Search=�5      �� 5      -   5         ��Name$ txtBookSearch��5      $	��150��5       $	��300��5!      $��Bottom=�5"      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tìm kiếm��5#      $
��Left=�5$      5%      �� 5&      -   5         ��Name$ 
btnRefresh��5'      $��28��5(      $��28��5)      $��Right=�5*      $��Bottom=�5+      $��Right=�5/       & "MaterialDesignIconForegroundButton#��[ 50       � ToolTip$ 
Làm mới��51      ��5-      0  *MaterialDesignThemes.Wpf.PackIconExtension  	   Kind$	 Refresh=�
   Size$
 25X�51      52      &   System.Windows.Controls.DataGrid  53   
   -   5          Name$ dtgBook��54      $��1��55         AutoGenerateColumns .     HeadersVisibility$ Column=�57      $   HorizontalScrollBarVisibility$
 Auto=�58         
IsReadOnly . "   VerticalScrollBarVisibility$
 Auto=�5:         Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<       ) %MaterialDesignDataGridTextColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 5>      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã sách��5?         Binding 5=      �� *BookID+5?        5@      # [ 5B      $ Tựa đề��5C       5A      �� *	BookTitle+5C        5D      # [ 5F      $ 
Danh mục��5G       5E      �� *CatalogName+5G        5H      # [ 5J      $ 
Tác giả��5K       5I      �� *Author+5K        5L      # [ 5N      $ Nhà xuất bản��5O       5M      �� *	Publisher+5O      5Q      5R      5S      