   M S B A M L   `   `   `  ����F  BTPA-Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:TPA_Desktop.View.ManagerViewTPA_Desktop.View.ManagerView  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5   	   .    (TPA_Desktop.View.ManagerView.ManagerView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:TPA_Desktop.View.ManagerView     5   	   =dragablz(clr-namespace:Dragablz;assembly=Dragablz     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignFont#���   5   	   $	��600��5   	   $
��1020��6    � 
ResizeMode$ NoResize=�6#    � WindowStartupLocation$ CenterScreen=�69    � WindowStyle$
 None=�6^   .��5      � .+�5   
   � $	��120��6   $	��Top=�6   
����  � � RowDefinitions 5      �� 5      $��* �6    �� 5      $��70 �6    .+�5      �� -   5        $��txtName��5      $��Under The Sea��6'   
�������$
��Left=�6O   $��Center=�6j   $��16(�6�   $��Champagne & Limousines)�6�    �� Padding$
 10pxq�6�   �� 5      -   5        $��	btnLogout��5      $��Right=�6>   $��Center=�6Z   ��6u   Z� ��6�   Z� .��6�   Logout5      �� 5      $��1��6   .+�5      �� $��Manager��6   
�������$��Center=�6>   $��Center=�6[   $��22(�6v   $��Champagne & Limousines)�6�   5      5       � 5!   
   $��	0 100 0 0q�6   .+�5"        Dragablz.TabablzControl     InterTabController 5#      !  Dragablz.InterTabController  5$      .@�5&      �� $
��Home��6   .��5'      �� .+�5(      �� $��Employee List��6$   $��20(�69   $ 10q�6G   &   System.Windows.Controls.DataGrid  5*      -   5        $��viewEmployee��5*   #      AutoGenerateColumns .  	   
IsReadOnly	 . $	��350��6e   $��Visible=�6r   
   Columns
 5+      0  *System.Windows.Controls.DataGridTextColumn  5,   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ��  �� Path$ Id�  5-   "   $
 Name��65    6C   �� $
 Name�  5.   "   $ Email��65    6D   �� $ Email�  5/   "   $	 DOB��65    6B   �� $	 DOB�  50   "   $ Salary��65    6E   �� $ Salary�  51   "   $ Department Name��65    6N   �� $ DeptName�53      54      55      �� 57      $ ��Manage Resignation Request��6   .��58      �� .+�59      �� $��Resignation Request List��6$   $��20(�6D   $ 10q�6R   $
��Bold"�6_     5;      -   5        $��
viewResign��5;   #    .  	 . $	��310��6c   $��Visible=�6p   
 5<        5=   "   $ Id��65    6A   �� $ Id�  5>   "   $ Employee Id��65    6J   �� $ 
EmployeeId�  5?   "   $ Employee Name��65    6L   �� $ EmployeeName�  5@   "   $ Title��65    6D   �� $ Title�  5A   "   $ Description��65    6J   �� $ Description�  5B   "   $
 Date��65    6C   �� $
 Date�4  .System.Windows.Controls.DataGridTemplateColumn  5C   "      HeaderTemplate 5D   &   �� 5E   *   .R�5F   .   �� $��Action��68   5G   +      CellTemplate 5I   &   �� 5J   *   .R�5K   .   ��  �� Orientation$ 
Horizontal=�69   .+�5L   2   �� $��	btnAccRes��69   -   5        $��Accept��5L   b   $��0 0 0 10q�6s   ��5M   5   �� $ Id��� 5N   2   $��	btnRejRes��69   -   5        $��Reject��5N   b   $��	10 0 0 10q�6s   ��5O   5   �� $ Id�5P   /   5Q   +   5S   #   5U      �� 5V      $
��Note��6$   $��20(�60   $ 10q�6>   $
��Bold"�6K   �� 5W      -   5        $��txtNote��5W   -   $��5q�6"   
�������6R   5X      5Y      �� 5[      $!��Manage Raise Salary Request��6   .��5\      �� .+�5]      �� $��Raise Salary Request List��6$   $��20(�6E   $ 10q�6S   $
��Bold"�6`     5_      -   5        $��	viewRaise��5_   #    .  	 . $	��310��6b   $��Visible=�6o   
 5`        5a   "   $ Id��65    6A   �� $ Id�  5b   "   $ Title��65    6D   �� $ Title�  5c   "   $ Description��65    6J   �� $ Description�  5d   "   $
 Date��65    6C   �� $
 Date�  5e   "    5f   &   �� 5g   *   .R�5h   .   �� $��Action��68   5i   +    5k   &   �� 5l   *   .R�5m   .   �� $ 
Horizontal=�69   .+�5n   2   �� $��btnAccRaise��69   -	   5        $��Accept��5n   f   $��0 0 0 10q�6w   ��5o   5   �� $ Id��� 5p   2   $��btnRejRaise��69   -
   5        $��Reject��5p   f   $��	10 0 0 10q�6w   ��5q   5   �� $ Id�5r   /   5s   +   5u   #   5w      �� 5x      $
��Note��6$   $��20(�60   $ 10q�6>   $
��Bold"�6K   �� 5y      -   5        $��txtNoteRaise��5y   -   $��5q�6"   
�������6W   5z      5{      �� 5}      $��Manage Firing Request��6   .��5~      �� .+�5      �� $ ��Fire Employee Request List��6$   $��20(�6F   $ 10q�6T   $
��Bold"�6a     5�      -   5        $��viewFire��5�   #    .  	 . $	��310��6a   $��Visible=�6n   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Title��65    6D   �� $ Title�  5�   "   $ Description��65    6J   �� $ Description�  5�   "   $
 Date��65    6C   �� $
 Date�  5�   "    5�   &   �� 5�   *   .R�5�   .   �� $��Action��68   5�   +    5�   &   �� 5�   *   .R�5�   .   �� $ 
Horizontal=�69   .+�5�   2   �� $��
btnAccFire��69   -   5        $��Accept��5�   d   $��0 0 0 10q�6u   ��5�   5   �� $ Id��� 5�   2   $��
btnRejFire��69   -   5        $��Reject��5�   d   $��	10 0 0 10q�6u   ��5�   5   �� $ Id�5�   /   5�   +   5�   #   5�      �� 5�      $
��Note��6$   $��20(�60   $ 10q�6>   $
��Bold"�6K   �� 5�      -   5        $��txtNoteFire��5�   -   $��5q�6"   
�������6V   5�      5�      �� 5�      $��Manage Ideas��6   .��5�      �� .+�5�      �� $��
Ideas List��6$   $��20(�66   $ 10q�6D   $
��Bold"�6Q     5�      -   5        $��	viewIdeas��5�   #    .  	 . $	��300��6b   $��Visible=�6o   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Title��65    6D   �� $ Tittle�  5�   "   $ Information��65    6J   �� $ Information�  5�   "   $
 Date��65    6C   �� $
 Date�  5�   "    5�   &   �� 5�   *   .R�5�   .   �� $��Action��68   5�   +    5�   &   �� 5�   *   .R�5�   .   �� $ 
Horizontal=�69   .+�5�   .   �� $��
btnAccIdea��65   -   5        $��Accept��5�   `   $��0 0 0 10q�6q   ��5�   5   �� $ Id��� 5�   .   $��
btnRejIdea��65   -   5        $��Reject��5�   `   $��	10 0 0 10q�6q   ��5�   5   �� $ Id�5�   /   5�   +   5�   #   5�      �� 5�      $
��Note��6$   $��20(�60   $ 10q�6>   $
��Bold"�6K   �� 5�      -   5        $��txtNoteIdea��5�   -   $��5q�6"   
�������6V   5�      5�      �� 5�      $��View Work Performance��6   .��5�      �� .+�5�      �� $��Employee Work Performance��6$   $��20(�6E   $ 10q�6S   $
��Bold"�6`     5�      -   5        $��viewWork��5�   #    .  	 . $	��300��6a   $��Visible=�6n   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Employee Id��65    6J   �� $ 
EmployeeId�  5�   "   $ Employee Name��65    6L   �� $ EmployeeName�  5�   "   $ Performance Detail��65    6Q   �� $ PerformanceDetail�5�      5�      5�      5�      5�      5�      5�      