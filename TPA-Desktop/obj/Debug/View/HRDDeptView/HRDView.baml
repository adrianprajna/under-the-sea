   M S B A M L   `   `   `  ����F  BTPA-Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:TPA_Desktop.View.HRDDeptViewTPA_Desktop.View.HRDDeptView  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5   	   *    $TPA_Desktop.View.HRDDeptView.HRDView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:TPA_Desktop.View.HRDDeptView     5   	   =dragablz(clr-namespace:Dragablz;assembly=Dragablz     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignFont#���   5   	   $	��600��5   	   $
��1020��6    � 
ResizeMode$ NoResize=�6#    � WindowStartupLocation$ CenterScreen=�69    � WindowStyle$
 None=�6^   .��5      � .+�5   
   � $	��120��6   $	��Top=�6   
����  � � RowDefinitions 5      �� 5      $��* �6    �� 5      $��70 �6    .+�5      �� -   5        $��txtName��5      $��Under The Sea��6'   
�������$
��Left=�6O   $��Center=�6j   $��16(�6�   $��Champagne & Limousines)�6�    �� Padding$
 10pxq�6�   �� 5      -   5        $��	btnLogout��5      $��Right=�6>   $��Center=�6Z   ��6u   Z� ��6�   Z� .��6�   Logout5      �� 5      $��1��6   .+�5      �� $#��Human and Resource Department��6   
�������$��Center=�6T   $��Center=�6q   $��22(�6�   $��Champagne & Limousines)�6�   5      5       � 5!   
   $��	0 100 0 0q�6   .+�5"        Dragablz.TabablzControl     InterTabController 5#      !  Dragablz.InterTabController  5$      .@�5&      �� $
��Home��6   .��5'      �� .+�5(      �� $��Employee List��6$   $��20(�69   $ 10q�6G   &   System.Windows.Controls.DataGrid  5*      -   5        $��viewEmployee��5*   #      AutoGenerateColumns .  	   
IsReadOnly	 . $	��350��6e   $��Visible=�6r   
   Columns
 5+      0  *System.Windows.Controls.DataGridTextColumn  5,   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ��  �� Path$ Id�  5-   "   $
 Name��65    6C   �� $
 Name�  5.   "   $ Email��65    6D   �� $ Email�  5/   "   $	 DOB��65    6B   �� $	 DOB�  50   "   $ Salary��65    6E   �� $ Salary�  51   "   $ Department Name��65    6N   �� $ DeptName�4  .System.Windows.Controls.DataGridTemplateColumn  52   "      HeaderTemplate 53   &   �� 54   *   .R�55   .   �� $��Action��68   56   +      CellTemplate 58   &   �� 59   *   .R�5:   .   ��  �� Orientation$ 
Horizontal=�69   .+�5;   2   �� $��	btnUpdate��69   -   5        $��Update��5;   b   $��0 0 0 10q�6s   ��5<   5   �� $ Id��� 5=   2   $��btnFire��69   -   5        $
��Fire��5=   ^   $��	10 0 0 10q�6�   ��6m   �� $ Id�6�   �� 5>   2   $��btnWork��69   -   5        $��Add Work Peformance��5>   ^   $��	10 0 0 10q�6|   ��5?   5   �� $ Id�5@   /   5A   +   5C   #   5E      �� 5G      -   5        $��btnAdd��5G   !   $��Hire Employee��6D   $	��5 5q�6\   5H      5I      �� 5K      $#��Manage Leaving Permit Request��6   .��5L      �� .+�5M      �� $��Leaving Permit Request��6$   $��20(�6B   $ 10q�6P   $
��Bold"�6]     5O      -   5        $��viewLeaving��5O   #    .  	 . $	��310��6d   $��Visible=�6q   
 5P        5Q   "   $ Id��65    6A   �� $ Id�  5R   "   $ Employee Name��65    6L   �� $ EmployeeName�  5S   "   $ Title��65    6D   �� $ Title�  5T   "   $ Description��65    6J   �� $ Description�  5U   "   $
 Date��65    6C   �� $
 Date�  5V   "    5W   &   �� 5X   *   .R�5Y   .   �� $��Action��68   5Z   +    5\   &   �� 5]   *   .R�5^   .   �� $ 
Horizontal=�69   .+�5_   2   �� $��btnAcc��69   -	   5        $��Accept��5_   \   $��0 0 0 10q�6m   ��5`   5   �� $ Id��� 5a   2   $��btnRej��69   -
   5        $��Reject��5a   \   $��	10 0 0 10q�6m   ��5b   5   �� $ Id�5c   /   5d   +   5f   #   5h      �� 5j      $
��Note��6$   $��20(�60   $ 10q�6>   $
��Bold"�6K   �� 5k      -   5        $��txtNote��5k   -   $��5q�6"   
�������6R   5l      5m      �� 5o      $&�� Manage Personal Request And Fund��6   .��5p      �� .+�5q      �� $��Request for Personal��6$   $��20(�6@   $ 10q�6N   $��Center=�6[   $
��Bold"�6x   �� 5r      $��10 -5q�6    $��16(�6/   .��6=   Title6D   �� 5s      -   5        $��txtTitlePersonal��5s   -   $��5q�6"   
�������6[   �� 5t      $
��10 0q�6    $��16(�6.   .��6<   Description6I   �� 5u      -   5        $��txtDescPersonal��5u   -   $��5q�6"   
�������6Z   �� 5v      $ 
Horizontal=�6%   $��10q�6>   .+�5w      	� -   5        $��	btnResign��5w   G    	� 	GroupName$ RA��6*   $��14(�69    d� 	IsChecked$
 TrueY�6X   .��6i   Resignation Letter6}   	� 5x      -   5        $��	btnFiring��5x   G   $ RA��6*   $��14(�69   $
��10 0q�6X   .��6f   Firing Employee Request6   	� 5y      -   5        $��btnRaise��5y   G   $ RA��6*   $��14(�69   $
��10 0q�6W   .��6e   Raise Salary Request6{   5z      �� 5{      -   5        $��btnPersonal��5{   !   $��Send Request��6N   $��5 10 5 5q�6e   6y   �� 5~      $��Request for Fund��6$   $��20(�6<   $ 10q�6J   $��Center=�6W   $
��Bold"�6t   �� 5      $
��10 0q�6    $��16(�6.   .��6<   Information6I   �� 5�      -   5        $��txtFund��5�   -   $��5q�6"   
�������6R   �� 5�      $
��10 0q�6    $��16(�6.   .��6<   Amount of Money6M   �� 5�      -   5        $��txtMoney��5�   -   $��5q�6"   
�������6S   �� 5�      -   5        $��btnFund��5�   !   $��Send Request��6F   $��5 10 5 5q�6]   6q   5�      5�      �� 5�      $��View Request Notification��6   .��5�      �� .+�5�      �� $#��Personal Request Notification��6$   $��20(�6I   $ 10q�6W   $
��Bold"�6d     5�      -   5        $��viewPers��5�   #    .  	 . $	��200��6a   $��Visible=�6n   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Title��65    6D   �� $ Title�  5�   "   $ Description��65    6J   �� $ Description�  5�   "   $
 Date��65    6C   �� $
 Date�  5�   "   $
 Note��65    6C   �� $
 Note�  5�   "   $ Status��65    6E   �� $ Status�  5�   "   $
 Type��65    6C   �� $
 Type�5�      �� 5�      $��Fund Request Notification��6$   $��20(�6E   $ 10q�6S   $
��Left=�6`   $
��Bold"�6{     5�      -   5        $��viewFund��5�   #    .  	 . $	��200��6a   $��Visible=�6n   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Information��65    6J   �� $ Information�  5�   "   $
 Note��65    6C   �� $
 Note�  5�   "   $ Status��65    6E   �� $ Status�  5�   "   $
 Date��65    6C   �� $
 Date�  5�   "   $ Amount of Money��65    6N   �� $ AmountMoney�5�      5�      5�      �� 5�      $��Manage Work Performance��6   .��5�      �� .+�5�      �� $��Employee Work Performance��6$   $��20(�6E   $ 10q�6S   $
��Bold"�6`     5�      -   5        $��viewWork��5�   #    .  	 . $	��300��6a   $��Visible=�6n   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Employee Id��65    6J   �� $ 
EmployeeId�  5�   "   $ Employee Name��65    6L   �� $ EmployeeName�  5�   "   $ Performance Detail��65    6Q   �� $ PerformanceDetail�  5�   "    5�   &   �� 5�   *   .R�5�   .   �� $��Action��68   5�   +    5�   &   �� 5�   *   .R�5�   .   �� $ 
Horizontal=�69   .+�5�   2   �� $��btnUpdateWork��69   -   5        $��Update��5�   j   $��0 0 0 10q�6{   ��5�   5   �� $ Id��� 5�   2   $��btnRemoveWork��69   -   5        $��Remove��5�   j   $��	10 0 0 10q�5�   ^   ��69   �� $ Id�6^   5�   /   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      