   M S B A M L   `   `   `  ����F  BTPA-Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TPA_Desktop.ViewTPA_Desktop.View  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5   	   #    TPA_Desktop.View.CreativeView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TPA_Desktop.View     5   	   =dragablz(clr-namespace:Dragablz;assembly=Dragablz     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignFont#���   5   	   $	��600��5   	   $	��875��6    � 
ResizeMode$ NoResize=�6"    � WindowStartupLocation$ CenterScreen=�68    � WindowStyle$
 None=�6]   .��5      � .+�5   
   � $	��120��6   $	��Top=�6   
����  � � RowDefinitions 5      �� 5      $��* �6    �� 5      $��70 �6    .+�5      �� -   5        $��txtName��5      $��Under The Sea��6'   
�������$
��Left=�6O   $��Center=�6j   $��16(�6�   $��Champagne & Limousines)�6�    �� Padding$
 10pxq�6�   �� 5      -   5        $��	btnLogout��5      $��Right=�6>   $��Center=�6Z   ��6u   Z� ��6�   Z� .��6�   Logout5      �� 5      $��1��6   .+�5      �� $-��'Ride and Attraction Creative Department��6   
�������$��Center=�6^   $��Center=�6{   $��22(�6�   $��Champagne & Limousines)�6�   5      5       � 5!   
   $��	0 100 0 0q�6   .+�5"        Dragablz.TabablzControl     InterTabController 5#      !  Dragablz.InterTabController  5$      .@�5&      �� $
��Home��6   .��5'      �� .+�5(      �� $��
Ideas List��6$   $��20(�66   $ 10q�6D   $
��Bold"�6Q   &   System.Windows.Controls.DataGrid  5*      -   5        $��	viewIdeas��5*   #      AutoGenerateColumns .  	   
IsReadOnly	 . $	��175��6b   $��Visible=�6o   
   Columns
 5+      0  *System.Windows.Controls.DataGridTextColumn  5,   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ��  �� Path$ Id�  5-   "   $ Title��65    6D   �� $ Tittle�  5.   "   $ Information��65    6J   �� $ Information�  5/   "   $
 Date��65    6C   �� $
 Date�  50   "   $ Status��65    6E   �� $ Status�  51   "   $
 Note��65    6C   �� $
 Note�4  .System.Windows.Controls.DataGridTemplateColumn  52   "      HeaderTemplate 53   &   �� 54   *   .R�55   .   �� $��Action��68   56   +      CellTemplate 58   &   �� 59   *   .R�5:   .   �� $��btnSend��65   -   5        $��Send to Construction��5:   Z   $��0 0 0 10q�6y   ��5;   5   �� $ Id�5<   +   5>   #   5@      �� 5B      $��Propose Idea��6$   $��20(�68   $ 10q�6F   $
��Bold"�6S   �� 5C      $
��10 0q�6    $��16(�6.   .��6<   Title6C   �� 5D      -   5        $��txtTitle��5D   -   $��5q�6"   
�������6S   �� 5E      $
��10 0q�6!   $��16(�6/   .��6=   Information6J   �� 5F      -   5        $��txtInformation��5F   -   $��5q�6"   
�������6Y   �� 5G      -   5        $��
btnPropose��5G   !   $��Submit��6L   $��5 10 5 5q�6]   6q   5H      5I      �� 5J      $��Ride and Attraction��6   .��5K      �� .+�5L      �� $��Ride and Attraction List��6$   $��18(�6D   $ 6q�6R   $
��Bold"�6^     5N      -   5        $��viewRA��5N   #    .  	 . $	��175��6_   $��Visible=�6l   
 5O        5P   "   $ Id��65    6A   �� $ Id�  5Q   "   $
 Name��65    6C   �� $
 Name�  5R   "   $ Description��65    6J   �� $ Description�  5S   "   $ Status��65    6E   �� $ Status�  5T   "   $
 Type��65    6C   �� $
 Type�  5U   "    5V   &   �� 5W   *   .R�5X   .   �� $��Action��68   5Y   +    5[   &   �� 5\   *   .R�5]   .   ��  �� Orientation$ 
Horizontal=�69   .+�5^   .   �� $��	btnUpdate��65   -	   5        $��Update��5^   ^   $��0 0 0 10q�6o   ��5_   5   �� $ Id��� 5`   2   $��	btnRemove��69   -
   5        $��Remove��5`   b   $��	10 0 0 10q�6�   ��6s   �� $ Id�6�   5a   /   5b   +   5d   #   5f      �� 5h      $��Add Attraction or Ride��6$   $��18(�6B   $ 6q�6P   $
��Bold"�6\   �� 5i      $
��10 0q�6    $��14(�6.   .��6<   Name6B   �� 5j      -   5        $��	txtRAName��5j   -   $��5q�6"   
�������6T   �� 5k      $
��10 0q�6!   $��14(�6/   .��6=   Description6J   �� 5l      -   5        $��txtRADescription��5l   -   $��5q�6"   
�������6[   �� 5m      $ 
Horizontal=�6%   .+�5n      	� -   5        $��btnRide��5n   G    	� 	GroupName$ RA��6*   $��14(�69    d� 	IsChecked$
 TrueY�6V   .��6g   Ride6m   	� 5o      -   5        $��btnAttraction��5o   G   $ RA��6*   $��14(�69   $
��10 0q�6\   .��6j   
Attraction6v   5p      �� 5q      -   5        $��btnAddRA��5q   !   $��Submit��6H   $��5 10 5 5q�6Y   6m   5r      5s      �� 5t      $��Request Purchase And Fund��6   .��5u      �� .+�5v      �� $��Request for Purchase��6$   $��20(�6@   $ 10q�6N   $��Center=�6[   $
��Bold"�6x   �� 5w      $
��10 0q�6    $��16(�6.   .��6<   Information6I   �� 5x      -   5        $��txtPurchase��5x   -   $��5q�6"   
�������6V   �� 5y      -   5        $��btnPurchase��5y   !   $��Send Request��6N   $��5 10 5 5q�6e   6y   �� 5{      $��Request for Fund��6$   $��20(�6<   $ 10q�6J   $��Center=�6W   $
��Bold"�6t   �� 5|      $
��10 0q�6    $��16(�6.   .��6<   Information6I   �� 5}      -   5        $��txtFund��5}   -   $��5q�6"   
�������6R   �� 5~      $
��10 0q�6    $��16(�6.   .��6<   Amount of Money6M   �� 5      -   5        $��txtMoney��5   -   $��5q�6"   
�������6S   �� 5�      -   5        $��btnFund��5�   !   $��Send Request��6F   $��5 10 5 5q�6]   6q   5�      5�      �� 5�      $��View Notification Request��6   .��5�      �� .+�5�      �� $#��Purchase Request Notification��6$   $��18(�6I   $ 10q�6W   $��Center=�6d   $
��Bold"�6�     5�      -   5        $��viewPurchase��5�   #    .  	 . $	��200��6e   $��Visible=�6r   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Information��65    6J   �� $ Information�  5�   "   $
 Note��65    6C   �� $
 Note�  5�   "   $ Status��65    6E   �� $ Status�  5�   "   $
 Date��65    6C   �� $
 Date�5�      �� 5�      $��Fund Request Notification��6$   $��18(�6E   $ 10q�6S   $��Center=�6`   $
��Bold"�6}     5�      -   5        $��viewFund��5�   #    .  	 . $	��200��6a   $��Visible=�6n   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Information��65    6J   �� $ Information�  5�   "   $
 Note��65    6C   �� $
 Note�  5�   "   $ Status��65    6E   �� $ Status�  5�   "   $
 Date��65    6C   �� $
 Date�  5�   "   $ Amount of Money��65    6N   �� $ AmountMoney�5�      5�      5�      �� 5�      $��Manage Personal Request��6   .��5�      �� .+�5�      �� $��Request for Personal��6$   $��20(�6@   $ 10q�6N   $��Center=�6[   $
��Bold"�6x   �� 5�      $
��10 0q�6    $��16(�6.   .��6<   Title6C   �� 5�      -   5        $��txtTitlePersonal��5�   1   $��10 10q�6"   
�������6_   �� 5�      $
��10 0q�6    $��16(�6.   .��6<   Description6I   �� 5�      -   5        $��txtDescPersonal��5�   1   $��10 10q�6"   
�������6^   �� 5�      $ 
Horizontal=�6%   $��10q�6>   .+�5�      	� -   5        $��	btnResign��5�   G   $ RA��6*   $��14(�69   $
 TrueY�6X   .��6i   Resignation Letter6}   	� 5�      -   5        $��
btnLeaving��5�   G   $ RA��6*   $��14(�69   $
��10 0q�6Y   .��6g   Leaving Permit Request6   5�      �� 5�      -   5        $��btnPersonal��5�   !   $��Send Request��6N   $��5 10 5 5q�6e   $	��800��6w   6�   5�      5�      �� 5�      $��View Personal Request��6   .��5�      �� .+�5�      �� $��Personal Request��6$   $��20(�6<   $ 10q�6J   $
��Bold"�6W     5�      -   5        $��viewPers��5�   #    .  	 . $	��350��6a   $��Visible=�6n   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Title��65    6D   �� $ Title�  5�   "   $ Description��65    6J   �� $ Description�  5�   "   $
 Date��65    6C   �� $
 Date�  5�   "   $
 Note��65    6C   �� $
 Note�  5�   "   $ Status��65    6E   �� $ Status�  5�   "   $
 Type��65    6C   �� $
 Type�5�      5�      5�      �� 5�      $ ��View Construction Progress��6   .��5�      �� .+�5�      �� $��Construction Progress��6$   $��20(�6A   $ 10q�6O   $
��Bold"�6\     5�      -   5        $��viewCons��5�   #    .  	 . $	��350��6a   $��Visible=�6n   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Title��65    6D   �� $ title�  5�   "   $ Information��65    6J   �� $ information�  5�   "   $ Status��65    6E   �� $ Status�  5�   "    5�   &   �� 5�   *   .R�5�   .   �� $��Action��68   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      