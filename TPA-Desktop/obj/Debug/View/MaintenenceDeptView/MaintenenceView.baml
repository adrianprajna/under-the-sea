   M S B A M L   `   `   `  ����F  BTPA-Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:TPA_Desktop.View.MaintenenceDeptView$TPA_Desktop.View.MaintenenceDeptView  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5   	   :    4TPA_Desktop.View.MaintenenceDeptView.MaintenenceView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:TPA_Desktop.View.MaintenenceDeptView     5   	   =dragablz(clr-namespace:Dragablz;assembly=Dragablz     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignFont#���   5   	   $	��600��5   	   $	��775��6    � 
ResizeMode$ NoResize=�6"    � WindowStartupLocation$ CenterScreen=�68    � WindowStyle$
 None=�6]   .��5      � .+�5   
   � $	��120��6   $	��Top=�6   
����  � � RowDefinitions 5      �� 5      $��* �6    �� 5      $��70 �6    .+�5      �� -   5        $��txtName��5      $��Under The Sea��6'   
�������$
��Left=�6O   $��Center=�6j   $��16(�6�   $��Champagne & Limousines)�6�    �� Padding$
 10pxq�6�   �� 5      -   5        $��	btnLogout��5      $��Right=�6>   $��Center=�6Z   ��6u   Z� ��6�   Z� .��6�   Logout5      �� 5      $��1��6   .+�5      �� $��Maintenence Department��6   
�������$��Center=�6M   $��Center=�6j   $��22(�6�   $��Champagne & Limousines)�6�   5      5       � 5!   
   $��	0 100 0 0q�6   .+�5"        Dragablz.TabablzControl     InterTabController 5#      !  Dragablz.InterTabController  5$      .@�5&      �� $
��Home��6   .��5'      �� .+�5(      �� $��Maintenence List��6$   $��20(�6<   $ 10q�6J   $
��Bold"�6W   &   System.Windows.Controls.DataGrid  5*      -   5        $��viewMaintenence��5*   #      AutoGenerateColumns .  	   
IsReadOnly	 . $	��175��6h   $��Visible=�6u   
   Columns
 5+      0  *System.Windows.Controls.DataGridTextColumn  5,   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ��  �� Path$ Id�  5-   "   $ Attraction or Ride's Name��65    6X   �� $
 Name�  5.   "   $ Information��65    6J   �� $ Information�  5/   "   $ Status��65    6E   �� $ Status�4  .System.Windows.Controls.DataGridTemplateColumn  50   "      HeaderTemplate 51   &   �� 52   *   .R�53   .   �� $��Action��68   54   +      CellTemplate 56   &   �� 57   *   .R�58   .   ��  �� Orientation$ 
Horizontal=�69   .+�59   .   �� $��	btnUpdate��65   -   5        $��Update��59   ^   $��0 0 0 10q�6o   ��5:   5   �� $ Id��� 5<   .   $��	btnFinish��65   -   5        $��Finish��5<   ^   $��5 0 0 10q�6o   ��5=   5   �� $ Id�5>   /   5?   +   5A   #   5C      �� 5E      $��Add Maintenence Data��6$   $��18(�6@   $ 6q�6N   $
��Bold"�6Z   �� 5F      $	��5 0q�6    $��14(�6-   .��6;   Attraction or Ride6O   �� 5G      -   5        $��cbMaintenence��5G   #   $	��5 0q�68   
�������6E   �� 5H      $	��5 0q�6!   $��14(�6.   .��6<   Information6I   �� 5I      -   5        $��txtInformation��5I   -   $��5q�6"   
�������6Y   �� 5J      -   5        $��btnAdd��5J   !   $��Submit��6D   $��5 10 5 5q�6U   6i   5K      5L      �� 5N      $��Submit Personal Request��6   .��5O      �� .+�5P      �� $��Request for Personal��6$   $��20(�6@   $ 10q�6N   $��Center=�6[   $
��Bold"�6x   �� 5Q      $
��10 0q�6    $��16(�6.   .��6<   Title6C   �� 5R      -	   5        $��txtTitlePersonal��5R   1   $��10 10q�6"   
�������6_   �� 5S      $
��10 0q�6    $��16(�6.   .��6<   Description6I   �� 5T      -
   5        $��txtDescPersonal��5T   1   $��10 10q�6"   
�������6^   �� 5U      $ 
Horizontal=�6%   $��10q�6>   .+�5V      	� -   5        $��	btnResign��5V   G    	� 	GroupName$ RA��6*   $��14(�69    d� 	IsChecked$
 TrueY�6X   .��6i   Resignation Letter6}   	� 5W      -   5        $��
btnLeaving��5W   G   $ RA��6*   $��14(�69   $
��10 0q�6Y   .��6g   Leaving Permit Request6   5X      �� 5Y      -   5        $��btnPersonal��5Y   !   $��Send Request��6N   $��5 10 5 5q�6e   $	��800��6w   6�   5Z      5[      �� 5]      $(��"View Personal Request Notification��6   .��5^      �� .+�5_      �� $��Personal Request��6$   $��20(�6<   $ 10q�6J   $
��Bold"�6W     5a      -   5        $��viewPers��5a   #    .  	 . $	��350��6a   $��Visible=�6n   
 5b        5c   "   $ Id��65    6A   �� $ Id�  5d   "   $ Title��65    6D   �� $ Title�  5e   "   $ Description��65    6J   �� $ Description�  5f   "   $
 Date��65    6C   �� $
 Date�  5g   "   $
 Note��65    6C   �� $
 Note�  5h   "   $ Status��65    6E   �� $ Status�  5i   "   $
 Type��65    6C   �� $
 Type�5k      5l      5m      5o      5p      5q      5r      