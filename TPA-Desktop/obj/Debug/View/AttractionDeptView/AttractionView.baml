   M S B A M L   `   `   `  ����F  BTPA-Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:TPA_Desktop.View.AttractionDeptView#TPA_Desktop.View.AttractionDeptView  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5   	   8    2TPA_Desktop.View.AttractionDeptView.AttractionView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:TPA_Desktop.View.AttractionDeptView     5   	   =dragablz(clr-namespace:Dragablz;assembly=Dragablz     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignFont#���   5   	   $	��600��5   	   $	��875��6    � 
ResizeMode$ NoResize=�6"    � WindowStartupLocation$ CenterScreen=�68    � WindowStyle$
 None=�6]   .��5      � .+�5   
   � $	��120��6   $	��Top=�6   
����  � � RowDefinitions 5      �� 5      $��* �6    �� 5      $��70 �6    .+�5      �� -   5        $��txtName��5      $��Under The Sea��6'   
�������$
��Left=�6O   $��Center=�6j   $��16(�6�   $��Champagne & Limousines)�6�    �� Padding$
 10pxq�6�   �� 5      -   5        $��	btnLogout��5      $��Right=�6>   $��Center=�6Z   ��6u   Z� ��6�   Z� .��6�   Logout5      �� 5      $��1��6   .+�5      �� $��Attraction Department��6   
�������$��Center=�6L   $��Center=�6i   $��22(�6�   $��Champagne & Limousines)�6�   5      5       � 5!   
   $��	0 100 0 0q�6   .+�5"        Dragablz.TabablzControl     InterTabController 5#      !  Dragablz.InterTabController  5$      .@�5&      �� $
��Home��6   .��5'      �� .+�5(      �� $��Ticket Transaction��6$   $��20(�6>   $ 10q�6L   $
��Bold"�6Y   &   System.Windows.Controls.DataGrid  5*      -   5        $��viewTransaction��5*   #      AutoGenerateColumns .  	   
IsReadOnly	 . $	��280��6h   $��Visible=�6u   
   Columns
 5+      0  *System.Windows.Controls.DataGridTextColumn  5,   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ��  �� Path$ Id�  5-   "   $ Employee Id��65    6J   �� $ 
EmployeeId�  5.   "   $
 Date��65    6C   �� $
 Date�  5/   "   $ Ticket Quantity��65    6N   �� $ Quantity�  50   "   $ Total Price��65    6J   �� $ 
TotalPrice�4  .System.Windows.Controls.DataGridTemplateColumn  51   "      HeaderTemplate 52   &   �� 53   *   .R�54   .   �� $��Action��68   55   +      CellTemplate 57   &   �� 58   *   .R�59   .   ��  �� Orientation$ 
Horizontal=�69   .+�5:   2   �� $��	btnUpdate��69   -   5        $��Update��5:   b   $��0 0 0 10q�6s   ��5;   5   �� $ Id�5<   /   5=   +   5?   #   5A      �� 5C      $��Ticket Quantity��6$   $��20(�6;   $ 10q�6I   $
��Bold"�6V   �� 5D      -   5        $��txtQty��5D   "   $��10q�60   
�������6R   �� 5E      -   5        $��	btnSubmit��5E   !   $��5 q�6J   $��Submit��6V   5F      5G      �� 5I      $��Manage Ticket��6   .��5J      �� .+�5K      �� $��Ticket��6$   $��20(�62   $ 10q�6@   $
��Bold"�6M     5M      -   5        $��
viewTicket��5M   #    .  	 . $	��175��6c   $��Visible=�6p   
 5N        5O   "   $ Id��65    6A   �� $ Id�  5P   "   $ Validity Date��65    6L   �� $ 
Valid_Date�  5Q   "    5R   &   �� 5S   *   .R�5T   .   �� $��Action��68   5U   +    5W   &   �� 5X   *   .R�5Y   .   �� $ 
Horizontal=�69   .+�5Z   2   �� $��btnCheck��69   -   5        $��Check Ticket��5Z   `   $��0 0 0 10q�6w   ��5[   5   �� $ Id�5\   /   5]   +   5_   #   5a      �� 5c      -	   5        $��image��5c       $��Center=�6-   $��10q�6J   $	��150��6V   6e   �� 5d      -
   5        $��btnGenerate��5d   !   $��Generate Ticket��64   $��5q�6N   6u   5e      5f      �� 5h      $��Submit Personal Request��6   .��5i      �� .+�5j      �� $��Request for Personal��6$   $��20(�6@   $ 10q�6N   $��Center=�6[   $
��Bold"�6x   �� 5k      $
��10 0q�6    $��16(�6.   .��6<   Title6C   �� 5l      -   5        $��txtTitlePersonal��5l   1   $��10 10q�6"   
�������6_   �� 5m      $
��10 0q�6    $��16(�6.   .��6<   Description6I   �� 5n      -   5        $��txtDescPersonal��5n   1   $��10 10q�6"   
�������6^   �� 5o      $ 
Horizontal=�6%   $��10q�6>   .+�5p      	� -   5        $��	btnResign��5p   G    	� 	GroupName$ RA��6*   $��14(�69    d� 	IsChecked$
 TrueY�6X   .��6i   Resignation Letter6}   	� 5q      -   5        $��
btnLeaving��5q   G   $ RA��6*   $��14(�69   $
��10 0q�6Y   .��6g   Leaving Permit Request6   5r      �� 5s      -   5        $��btnPersonal��5s   !   $��Send Request��6N   $��5 10 5 5q�6e   $	��800��6w   6�   5t      5u      �� 5w      $��View Personal Request��6   .��5x      �� .+�5y      �� $��Personal Request��6$   $��20(�6<   $ 10q�6J   $
��Bold"�6W     5{      -   5        $��viewPers��5{   #    .  	 . $	��350��6a   $��Visible=�6n   
 5|        5}   "   $ Id��65    6A   �� $ Id�  5~   "   $ Title��65    6D   �� $ Title�  5   "   $ Description��65    6J   �� $ Description�  5�   "   $
 Date��65    6C   �� $
 Date�  5�   "   $
 Note��65    6C   �� $
 Note�  5�   "   $ Status��65    6E   �� $ Status�  5�   "   $
 Type��65    6C   �� $
 Type�5�      5�      5�      5�      5�      5�      5�      