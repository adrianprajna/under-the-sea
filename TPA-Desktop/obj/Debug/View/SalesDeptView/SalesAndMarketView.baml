   M S B A M L   `   `   `  ����F  BTPA-Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:TPA_Desktop.View.SalesDeptViewTPA_Desktop.View.SalesDeptView  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5   	   7    1TPA_Desktop.View.SalesDeptView.SalesAndMarketView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:TPA_Desktop.View.SalesDeptView     5   	   =dragablz(clr-namespace:Dragablz;assembly=Dragablz     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignFont#���   5   	   $	��600��5   	   $	��775��6    � 
ResizeMode$ NoResize=�6"    � WindowStartupLocation$ CenterScreen=�68    � WindowStyle$
 None=�6]   .��5      � .+�5   
   � $	��120��6   $	��Top=�6   
����  � � RowDefinitions 5      �� 5      $��* �6    �� 5      $��70 �6    .+�5      �� -   5        $��txtName��5      $��Under The Sea��6'   
�������$
��Left=�6O   $��Center=�6j   $��16(�6�   $��Champagne & Limousines)�6�    �� Padding$
 10pxq�6�   �� 5      -   5        $��	btnLogout��5      $��Right=�6>   $��Center=�6Z   ��6u   Z� ��6�   Z� .��6�   Logout5      �� 5      $��1��6   .+�5      �� $$��Sales and Marketing Department��6   
�������$��Center=�6U   $��Center=�6r   $��22(�6�   $��Champagne & Limousines)�6�   5      5       � 5!   
   $��	0 100 0 0q�6   .+�5"        Dragablz.TabablzControl     InterTabController 5#      !  Dragablz.InterTabController  5$      .@�5&      �� $
��Home��6   .��5'      �� .+�5(      �� $��Advertisement List��6$   $��20(�6>   $ 10q�6L   $
��Bold"�6Y   &   System.Windows.Controls.DataGrid  5*      -   5        $��viewAdvertisement��5*   #      AutoGenerateColumns .  	   
IsReadOnly	 . $	��175��6j   $��Visible=�6w   
   Columns
 5+      0  *System.Windows.Controls.DataGridTextColumn  5,   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ��  �� Path$ Id�  5-   "   $ Title��65    6D   �� $ Title�  5.   "   $ Description��65    6J   �� $ Description�  5/   "   $ Status��65    6E   �� $ Status�4  .System.Windows.Controls.DataGridTemplateColumn  50   "      HeaderTemplate 51   &   �� 52   *   .R�53   .   �� $��Action��68   54   +      CellTemplate 56   &   �� 57   *   .R�58   .   ��  �� Orientation$ 
Horizontal=�69   .+�59   2   �� $��	btnUpdate��69   -   5        $��Update��59   b   $��0 0 0 10q�6s   ��5:   5   �� $ Id��� 5;   2   $��	btnRemove��69   -   5        $��Remove��5;   b   $��	10 0 0 10q�6�   ��6s   �� $ Id�6�   5<   /   5=   +   5?   #   5A      �� 5C      $��Add Advertisement��6$   $��18(�6=   $ 6q�6K   $
��Bold"�6W   �� 5D      $
��10 0q�6    $��14(�6.   .��6<   Title6C   �� 5E      -   5        $��txtTitle��5E   -   $��5q�6"   
�������6S   �� 5F      $
��10 0q�6!   $��14(�6/   .��6=   Description6J   �� 5G      -   5        $��txtDescription��5G   -   $��5q�6"   
�������6Y   �� 5H      -   5        $��btnAdd��5H   !   $��Submit��6D   $��5 10 5 5q�6U   6i   5I      5J      �� 5L      $��Request Purchase And Fund��6   .��5M      �� .+�5N      �� $��Request for Purchase��6$   $��20(�6@   $ 10q�6N   $��Center=�6[   �� 5O      $
��10 0q�6    $��16(�6.   .��6<   Information6I   �� 5P      -	   5        $��txtPurchase��5P   -   $��5q�6"   
�������6V   �� 5Q      -
   5        $��btnPurchase��5Q   !   $��Send Request��6N   $��5 10 5 5q�6e   6y   �� 5S      $��Request for Fund��6$   $��20(�6<   $ 10q�6J   $��Center=�6W   �� 5T      $
��10 0q�6    $��16(�6.   .��6<   Information6I   �� 5U      -   5        $��txtFund��5U   -   $��5q�6"   
�������6R   �� 5V      $
��10 0q�6    $��16(�6.   .��6<   Amount of Money6M   �� 5W      -   5        $��txtMoney��5W   -   $��5q�6"   
�������6S   �� 5X      -   5        $��btnFund��5X   !   $��Send Request��6F   $��5 10 5 5q�6]   6q   5Y      5Z      �� 5\      $��View Request Notification��6   .��5]      �� .+�5^      �� $#��Purchase Request Notification��6$   $��18(�6I   $ 10q�6W   $��Center=�6d   $
��Bold"�6�     5_      -   5        $��viewPurchase��5_   #    .  	 . $	��200��6e   $��Visible=�6r   
 5`        5a   "   $ Id��65    6A   �� $ Id�  5b   "   $ Information��65    6J   �� $ Information�  5c   "   $
 Note��65    6C   �� $
 Note�  5d   "   $ Status��65    6E   �� $ Status�  5e   "   $
 Date��65    6C   �� $
 Date�5g      �� 5i      $��Fund Request Notification��6$   $��18(�6E   $ 10q�6S   $��Center=�6`   $
��Bold"�6}     5j      -   5        $��viewFund��5j   #    .  	 . $	��200��6a   $��Visible=�6n   
 5k        5l   "   $ Id��65    6A   �� $ Id�  5m   "   $ Information��65    6J   �� $ Information�  5n   "   $
 Note��65    6C   �� $
 Note�  5o   "   $ Status��65    6E   �� $ Status�  5p   "   $
 Date��65    6C   �� $
 Date�  5q   "   $ Amount of Money��65    6N   �� $ AmountMoney�5s      5t      5u      �� 5w      $��Submit Personal Request��6   .��5x      �� .+�5y      �� $��Request for Personal��6$   $��20(�6@   $ 10q�6N   $��Center=�6[   $
��Bold"�6x   �� 5z      $
��10 0q�6    $��16(�6.   .��6<   Title6C   �� 5{      -   5        $��txtTitlePersonal��5{   1   $��10 10q�6"   
�������6_   �� 5|      $
��10 0q�6    $��16(�6.   .��6<   Description6I   �� 5}      -   5        $��txtDescPersonal��5}   1   $��10 10q�6"   
�������6^   �� 5~      $ 
Horizontal=�6%   $��10q�6>   .+�5      	� -   5        $��	btnResign��5   G    	� 	GroupName$ RA��6*   $��14(�69    d� 	IsChecked$
 TrueY�6X   .��6i   Resignation Letter6}   	� 5�      -   5        $��
btnLeaving��5�   G   $ RA��6*   $��14(�69   $
��10 0q�6Y   .��6g   Leaving Permit Request6   5�      �� 5�      -   5        $��btnPersonal��5�   !   $��Send Request��6N   $��5 10 5 5q�6e   $	��800��6w   6�   5�      5�      �� 5�      $��View Personal Request��6   .��5�      �� .+�5�      �� $��Personal Request��6$   $��20(�6<   $ 10q�6J   $
��Bold"�6W     5�      -   5        $��viewPers��5�   #    .  	 . $	��350��6a   $��Visible=�6n   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Title��65    6D   �� $ Title�  5�   "   $ Description��65    6J   �� $ Description�  5�   "   $
 Date��65    6C   �� $
 Date�  5�   "   $
 Note��65    6C   �� $
 Note�  5�   "   $ Status��65    6E   �� $ Status�  5�   "   $
 Type��65    6C   �� $
 Type�5�      5�      5�      5�      5�      5�      5�      