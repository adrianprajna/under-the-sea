   M S B A M L   `   `   `  ����F  BTPA-Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:TPA_Desktop.View.PurchaseDeptView!TPA_Desktop.View.PurchaseDeptView  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5   	   4    .TPA_Desktop.View.PurchaseDeptView.PurchaseView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:TPA_Desktop.View.PurchaseDeptView     5   	   =dragablz(clr-namespace:Dragablz;assembly=Dragablz     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignFont#���   5   	   $	��600��5   	   $	��875��6    � 
ResizeMode$ NoResize=�6"    � WindowStartupLocation$ CenterScreen=�68    � WindowStyle$
 None=�6]   .��5      � .+�5   
   � $	��120��6   $	��Top=�6   
����  � � RowDefinitions 5      �� 5      $��* �6    �� 5      $��70 �6    .+�5      �� -   5        $��txtName��5      $��Under The Sea��6'   
�������$
��Left=�6O   $��Center=�6j   $��16(�6�   $��Champagne & Limousines)�6�    �� Padding$
 10pxq�6�   �� 5      -   5        $��	btnLogout��5      $��Right=�6>   $��Center=�6Z   ��6u   Z� ��6�   Z� .��6�   Logout5      �� 5      $��1��6   .+�5      �� $��Purchase Department��6   
�������$��Center=�6J   $��Center=�6g   $��22(�6�   $��Champagne & Limousines)�6�   5      5       � 5!   
   $��	0 100 0 0q�6   .+�5"        Dragablz.TabablzControl     InterTabController 5#      !  Dragablz.InterTabController  5$      .@�5&      �� $
��Home��6   .��5'      �� .+�5(      �� $��Request Purchase��6$   $��20(�6<   $ 10q�6J   $
��Bold"�6W   &   System.Windows.Controls.DataGrid  5*      -   5        $��viewPurchaseRequest��5*   #      AutoGenerateColumns .  	   
IsReadOnly	 . $	��310��6l   $��Visible=�6y   
   Columns
 5+      0  *System.Windows.Controls.DataGridTextColumn  5,   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ��  �� Path$ Id�  5-   "   $ Department Name��65    6N   �� $ DepartmentName�  5.   "   $ Information��65    6J   �� $ Information�  5/   "   $
 Date��65    6C   �� $
 Date�4  .System.Windows.Controls.DataGridTemplateColumn  50   "      HeaderTemplate 51   &   �� 52   *   .R�53   .   �� $��Action��68   54   +      CellTemplate 56   &   �� 57   *   .R�58   .   ��  �� Orientation$ 
Horizontal=�69   .+�59   2   �� $��btnSend��69   -   5        $��Request to Fund��59   ^   $��0 0 0 10q�6x   ��5:   5   �� $ Id�5;   /   5<   +   5>   #   5@      �� 5B      $��Predicted Amount of Money��6$   $��20(�6E   $ 10q�6S   $
��Bold"�6`   �� 5C      -   5        $��txtMoney��5C   -   $��5q�6"   
�������6S   5D      5E      �� 5G      $��Fund Request Notification��6   .��5H      �� .+�5I      �� $��Fund Request��6$   $��20(�68   $ 10q�6F   $
��Bold"�6S     5K      -   5        $��viewFundRequest��5K   #    .  	 . $	��310��6h   $��Visible=�6u   
 5L        5M   "   $ Id��65    6A   �� $ Id�  5N   "   $ Information��65    6J   �� $ Information�  5O   "   $
 Date��65    6C   �� $
 Date�  5P   "   $
 Note��65    6C   �� $
 Note�  5Q   "   $ Status��65    6E   �� $ Status�  5R   "    5S   &   �� 5T   *   .R�5U   .   �� $��Action��68   5V   +    5X   &   �� 5Y   *   .R�5Z   .   �� $ 
Horizontal=�69   .+�5[   2   �� $��	btnNotify��69   -   5        $��Notify��5[   b   $��0 0 0 10q�6s   ��5\   5   �� $ Id�5]   /   5^   +   5`   #   5b      �� 5d      $
��Note��6$   $��20(�60   $ 10q�6>   $
��Bold"�6K   �� 5e      -   5        $��txtNote��5e   "   $��10q�61   
�������6S   5f      5g      �� 5i      $!��Manage Purchase Information��6   .��5j      �� .+�5k      �� $��Purchase Information��6$   $��20(�6@   $ 10q�6N   $
��Bold"�6[     5m      -	   5        $��viewPurchaseInformation��5m   #    .  	 . $	��290��6p   $��Visible=�6}   
 5n        5o   "   $ Id��65    6A   �� $ Id�  5p   "   $ Employee Id��65    6J   �� $ 
EmployeeId�  5q   "   $ Employee Name��65    6L   �� $ EmployeeName�  5r   "   $ Information��65    6J   �� $ Information�  5s   "   $
 Date��65    6C   �� $
 Date�5u      �� 5w      $��Information��6$   $��20(�67   $ 10q�6E   $
��Bold"�6R   �� 5x      -
   5        $��txtPurchase��5x   "   $��10q�65   
�������6W   �� 5y      -   5        $��	btnSubmit��5y   !   $��Submit��6J   $��0 0 0 10q�6[   5z      5{      �� 5}      $��Manage Personal Request��6   .��5      �� .+�5�      �� $��Request for Personal��6$   $��20(�6@   $ 10q�6N   $��Center=�6[   $
��Bold"�6x   �� 5�      $
��10 0q�6    $��16(�6.   .��6<   Title6C   �� 5�      -   5        $��txtTitlePersonal��5�   1   $��10 10q�6"   
�������6_   �� 5�      $
��10 0q�6    $��16(�6.   .��6<   Description6I   �� 5�      -   5        $��txtDescPersonal��5�   1   $��10 10q�6"   
�������6^   �� 5�      $ 
Horizontal=�6%   $��10q�6>   .+�5�      	� -   5        $��	btnResign��5�   G    	� 	GroupName$ RA��6*   $��14(�69    d� 	IsChecked$
 TrueY�6X   .��6i   Resignation Letter6}   	� 5�      -   5        $��
btnLeaving��5�   G   $ RA��6*   $��14(�69   $
��10 0q�6Y   .��6g   Leaving Permit Request6   5�      �� 5�      -   5        $��btnPersonal��5�   !   $��Send Request��6N   $��5 10 5 5q�6e   $	��800��6w   6�   5�      5�      �� 5�      $��View Personal Request��6   .��5�      �� .+�5�      �� $��Personal Request��6$   $��20(�6<   $ 10q�6J   $
��Bold"�6W     5�      -   5        $��viewPers��5�   #    .  	 . $	��350��6a   $��Visible=�6n   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Title��65    6D   �� $ Title�  5�   "   $ Description��65    6J   �� $ Description�  5�   "   $
 Date��65    6C   �� $
 Date�  5�   "   $
 Note��65    6C   �� $
 Note�  5�   "   $ Status��65    6E   �� $ Status�  5�   "   $
 Type��65    6C   �� $
 Type�5�      5�      5�      5�      5�      5�      5�      