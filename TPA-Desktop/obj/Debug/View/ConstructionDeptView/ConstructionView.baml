   M S B A M L   `   `   `  ����F  BTPA-Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:TPA_Desktop.View.ConstructionDeptView%TPA_Desktop.View.ConstructionDeptView  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5   	   <    6TPA_Desktop.View.ConstructionDeptView.ConstructionView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:TPA_Desktop.View.ConstructionDeptView     5   	   =dragablz(clr-namespace:Dragablz;assembly=Dragablz     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignFont#���   5   	   $	��600��5   	   $	��875��6    � 
ResizeMode$ NoResize=�6"    � WindowStartupLocation$ CenterScreen=�68    � WindowStyle$
 None=�6]   .��5      � .+�5   
   � $	��120��6   $	��Top=�6   
����  � � RowDefinitions 5      �� 5      $��* �6    �� 5      $��70 �6    .+�5      �� -   5        $��txtName��5      $��Under The Sea��6'   
�������$
��Left=�6O   $��Center=�6j   $��16(�6�   $��Champagne & Limousines)�6�    �� Padding$
 10pxq�6�   �� 5      -   5        $��	btnLogout��5      $��Right=�6>   $��Center=�6Z   ��6u   Z� ��6�   Z� .��6�   Logout5      �� 5      $��1��6   .+�5      �� $��Construction Department��6   
�������$��Center=�6N   $��Center=�6k   $��22(�6�   $��Champagne & Limousines)�6�   5      5       � 5!   
   $��	0 100 0 0q�6   .+�5"        Dragablz.TabablzControl     InterTabController 5#      !  Dragablz.InterTabController  5$      .@�5&      �� $
��Home��6   .��5'      �� .+�5(      �� $#��On Progress Construction List��6$   $��20(�6I   $ 10q�6W   $
��Bold"�6d   &   System.Windows.Controls.DataGrid  5*      -   5        $��viewConstruction��5*   #      AutoGenerateColumns .  	   
IsReadOnly	 . $	��175��6i   $��Visible=�6v   
   Columns
 5+      0  *System.Windows.Controls.DataGridTextColumn  5,   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ��  �� Path$ Id�  5-   "   $ Title��65    6D   �� $ title�  5.   "   $ Information��65    6J   �� $ information�  5/   "   $ Status��65    6E   �� $ Status�4  .System.Windows.Controls.DataGridTemplateColumn  50   "      HeaderTemplate 51   &   �� 52   *   .R�53   .   �� $��Action��68   54   +      CellTemplate 56   &   �� 57   *   .R�58   .   ��  �� Orientation$ 
Horizontal=�69   .+�59   2   �� $��btnStart��69   -   5        $��Start��59   `   $��0 0 0 10q�6p   ��5:   5   �� $ Id��� 5;   2   $��	btnFinish��69   -   5        $��Finish��5;   b   $��	10 0 0 10q�6s   ��5<   5   �� $ Id�5=   /   5>   +   5@   #   5B      5C      5D      �� 5F      $��Request Purchase And Fund��6   .��5G      �� .+�5H      �� $��Request for Purchase��6$   $��20(�6@   $ 10q�6N   $��Center=�6[   $
��Bold"�6x   �� 5I      $
��10 0q�6    $��16(�6.   .��6<   Information6I   �� 5J      -   5        $��txtPurchase��5J   -   $��5q�6"   
�������6V   �� 5K      -   5        $��btnPurchase��5K   !   $��Send Request��6N   $��5 10 5 5q�6e   6y   �� 5M      $��Request for Fund��6$   $��20(�6<   $ 10q�6J   $��Center=�6W   $
��Bold"�6t   �� 5N      $
��10 0q�6    $��16(�6.   .��6<   Information6I   �� 5O      -   5        $��txtFund��5O   -   $��5q�6"   
�������6R   �� 5P      $
��10 0q�6    $��16(�6.   .��6<   Amount of Money6M   �� 5Q      -	   5        $��txtMoney��5Q   -   $��5q�6"   
�������6S   �� 5R      -
   5        $��btnFund��5R   !   $��Send Request��6F   $��5 10 5 5q�6]   6q   5S      5T      �� 5V      $��View Notification Request��6   .��5W      �� .+�5X      �� $#��Purchase Request Notification��6$   $��18(�6I   $ 10q�6W   $��Center=�6d   $
��Bold"�6�     5Y      -   5        $��viewPurchase��5Y   #    .  	 . $	��200��6e   $��Visible=�6r   
 5Z        5[   "   $ Id��65    6A   �� $ Id�  5\   "   $ Information��65    6J   �� $ Information�  5]   "   $
 Note��65    6C   �� $
 Note�  5^   "   $ Status��65    6E   �� $ Status�  5_   "   $
 Date��65    6C   �� $
 Date�5a      �� 5c      $��Fund Request Notification��6$   $��18(�6E   $ 10q�6S   $��Center=�6`   $
��Bold"�6}     5d      -   5        $��viewFund��5d   #    .  	 . $	��200��6a   $��Visible=�6n   
 5e        5f   "   $ Id��65    6A   �� $ Id�  5g   "   $ Information��65    6J   �� $ Information�  5h   "   $
 Note��65    6C   �� $
 Note�  5i   "   $ Status��65    6E   �� $ Status�  5j   "   $
 Date��65    6C   �� $
 Date�  5k   "   $ Amount of Money��65    6N   �� $ AmountMoney�5m      5n      5o      �� 5q      $��Submit Personal Request��6   .��5r      �� .+�5s      �� $��Request for Personal��6$   $��20(�6@   $ 10q�6N   $��Center=�6[   $
��Bold"�6x   �� 5t      $
��10 0q�6    $��16(�6.   .��6<   Title6C   �� 5u      -   5        $��txtTitlePersonal��5u   1   $��10 10q�6"   
�������6_   �� 5v      $
��10 0q�6    $��16(�6.   .��6<   Description6I   �� 5w      -   5        $��txtDescPersonal��5w   1   $��10 10q�6"   
�������6^   �� 5x      $ 
Horizontal=�6%   $��10q�6>   .+�5y      	� -   5        $��	btnResign��5y   G    	� 	GroupName$ RA��6*   $��14(�69    d� 	IsChecked$
 TrueY�6X   .��6i   Resignation Letter6}   	� 5z      -   5        $��
btnLeaving��5z   G   $ RA��6*   $��14(�69   $
��10 0q�6Y   .��6g   Leaving Permit Request6   5{      �� 5|      -   5        $��btnPersonal��5|   !   $��Send Request��6N   $��5 10 5 5q�6e   $	��800��6w   6�   5}      5~      �� 5�      $��View Personal Request��6   .��5�      �� .+�5�      �� $��Personal Request��6$   $��20(�6<   $ 10q�6J   $
��Bold"�6W     5�      -   5        $��viewPers��5�   #    .  	 . $	��350��6a   $��Visible=�6n   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Title��65    6D   �� $ Title�  5�   "   $ Description��65    6J   �� $ Description�  5�   "   $
 Date��65    6C   �� $
 Date�  5�   "   $
 Note��65    6C   �� $
 Note�  5�   "   $ Status��65    6E   �� $ Status�  5�   "   $
 Type��65    6C   �� $
 Type�5�      5�      5�      5�      5�      5�      5�      