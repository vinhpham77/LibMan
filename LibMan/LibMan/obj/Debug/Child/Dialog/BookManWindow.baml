   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5      $    GUI.Child.Dialog.BookManWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:GUI     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $	��460��5	      $	��360��5
         MaterialDesignPaper#���   5        MaterialDesignFont#���  5        � Icon$  ../../img/logo.ico��5       � 
ResizeMode$ NoResize=�5      $��16(�5      $��Regular"�5        MaterialDesignBody#���  5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5      .��5      � $��100,20q�6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      $
��1.4* �6   .+�5   
   �� -   5         ��Name$ txtTitle��5       $��Center=�5!      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tựa đề��5"       % !MaterialDesignFloatingHintTextBox#��[ 5#      � 5$   
   $��1��6    � ColumnDefinitions 5%      �� 5&      �� 5'      $
��Auto �6#   .+�5)      �� -   5        	 ��Name$	 
cbxCatalog��5*      .  (MaterialDesignThemes.Wpf.ColorZoneAssist
   Mode$
 PrimaryLight=�5+      $ 
Danh mục��5,       �� IsTextSearchEnabled .  & "MaterialDesignFloatingHintComboBox#��[ 5.      �� 5/      -   5         ��Name$ btnAddCatalog��50      $��1��51      $��45��52      $��	10,10,0,0q�53      $��0q�54       � ToolTip$ Thêm danh mục mới��57      ��56      0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$
 Plus=�57      58      �� 59   
   -   5        $ 	txtAuthor��5:      $��2��5;      $��Center=�5<      $ 
Tác giả��5=      #��[ 5>      �� 5?   
   -   5        $ txtPublisher��5@      $��3��5A      $��Center=�5B      $ Nhà xuất bản��5C      #��[ 5D      � 5E   
   $��4��6   $��0,20,0,0q�6    5F      �� 5G      �� 5H      .+�5J      �� -   5        $ 	btnSubmit��5K      $��0��5L      $��0,0,10,0q�5M      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 4��5N      $��Xác nhận��5P       �� 	IsDefault .  ! MaterialDesignFlatMidBgButton#��[ 5R      �� 5S      -   5        $ 	btnCancel��5T      $��1��5U      $ 4��5V      $��
Huỷ bỏ��5X       �� IsCancel .    MaterialDesignOutlinedButton#��[ 5Z      5[      5\      5]      