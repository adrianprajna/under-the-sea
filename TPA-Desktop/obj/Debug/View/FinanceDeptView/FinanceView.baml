   M S B A M L   `   `   `  ����F  BTPA-Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:TPA_Desktop.View.FinanceDeptView TPA_Desktop.View.FinanceDeptView  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5   	   2    ,TPA_Desktop.View.FinanceDeptView.FinanceView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:TPA_Desktop.View.FinanceDeptView     5   	   =dragablz(clr-namespace:Dragablz;assembly=Dragablz     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignFont#���   5   	   $	��600��5   	   $	��875��6    � 
ResizeMode$ NoResize=�6"    � WindowStartupLocation$ CenterScreen=�68    � WindowStyle$
 None=�6]   .��5      � .+�5   
   � $	��120��6   $	��Top=�6   
����  � � RowDefinitions 5      �� 5      $��* �6    �� 5      $��70 �6    .+�5      �� -   5        $��txtName��5      $��Under The Sea��6'   
�������$
��Left=�6O   $��Center=�6j   $��16(�6�   $��Champagne & Limousines)�6�    �� Padding$
 10pxq�6�   �� 5      -   5        $��	btnLogout��5      $��Right=�6>   $��Center=�6Z   ��6u   Z� ��6�   Z� .��6�   Logout5      �� 5      $��1��6   .+�5      �� $'��!Accounting and Finance Department��6   
�������$��Center=�6X   $��Center=�6u   $��22(�6�   $��Champagne & Limousines)�6�   5      5       � 5!   
   $��	0 100 0 0q�6   .+�5"        Dragablz.TabablzControl     InterTabController 5#      !  Dragablz.InterTabController  5$      .@�5&      �� $
��Home��6   .��5'      �� .+�5(      �� $��Fund Request��6$   $��20(�68   $ 10q�6F   &   System.Windows.Controls.DataGrid  5*      -   5        $��viewFundRequest��5*   #      AutoGenerateColumns .  	   
IsReadOnly	 . $	��350��6h   $��Visible=�6u   
   Columns
 5+      0  *System.Windows.Controls.DataGridTextColumn  5,   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ��  �� Path$ Id�  5-   "   $ Department Name��65    6N   �� $ DepartmentName�  5.   "   $ Information��65    6J   �� $ Information�  5/   "   $
 Date��65    6C   �� $
 Date�  50   "   $ Amount of Money��65    6N   �� $ AmountMoney�4  .System.Windows.Controls.DataGridTemplateColumn  51   "      HeaderTemplate 52   &   �� 53   *   .R�54   .   �� $��Action��68   55   +      CellTemplate 57   &   �� 58   *   .R�59   .   ��  �� Orientation$ 
Horizontal=�69   .+�5:   2   �� $��	btnNotify��69   -   5        $��Manage Request��5:   b   $��0 0 0 10q�6{   ��5;   5   �� $ Id�5<   /   5=   +   5?   #   5A      �� 5C      -   5        $��btnCalculate��5C   ;   $��Calculate Money��6!   $��10q�6j   5D      5E      �� 5G      $��Submit Personal Request��6   .��5H      �� .+�5I      �� $��Request for Personal��6$   $��20(�6@   $ 10q�6N   $��Center=�6[   $
��Bold"�6x   �� 5J      $
��10 0q�6    $��16(�6.   .��6<   Title6C   �� 5K      -   5        $��txtTitlePersonal��5K   1   $��10 10q�6"   
�������6_   �� 5L      $
��10 0q�6    $��16(�6.   .��6<   Description6I   �� 5M      -   5        $��txtDescPersonal��5M   1   $��10 10q�6"   
�������6^   �� 5N      $ 
Horizontal=�6%   $��10q�6>   .+�5O      	� -   5        $��	btnResign��5O   G    	� 	GroupName$ RA��6*   $��14(�69    d� 	IsChecked$
 TrueY�6X   .��6i   Resignation Letter6}   	� 5P      -	   5        $��
btnLeaving��5P   G   $ RA��6*   $��14(�69   $
��10 0q�6Y   .��6g   Leaving Permit Request6   5Q      �� 5R      -
   5        $��btnPersonal��5R   !   $��Send Request��6N   $��5 10 5 5q�6e   $	��800��6w   6�   5S      5T      �� 5V      $��View Personal Request��6   .��5W      �� .+�5X      �� $��Personal Request��6$   $��20(�6<   $ 10q�6J   $
��Bold"�6W     5Z      -   5        $��viewPers��5Z   #    .  	 . $	��350��6a   $��Visible=�6n   
 5[        5\   "   $ Id��65    6A   �� $ Id�  5]   "   $ Title��65    6D   �� $ Title�  5^   "   $ Description��65    6J   �� $ Description�  5_   "   $
 Date��65    6C   �� $
 Date�  5`   "   $
 Note��65    6C   �� $
 Note�  5a   "   $ Status��65    6E   �� $ Status�  5b   "   $
 Type��65    6C   �� $
 Type�5d      5e      5f      5i      5j      5k      5l      