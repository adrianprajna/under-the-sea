   M S B A M L   `   `   `  ����F  BTPA-Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:TPA_Desktop.View.HotelDeptViewTPA_Desktop.View.HotelDeptView  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5   	   4    .TPA_Desktop.View.HotelDeptView.FrontOfficeView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:TPA_Desktop.View.HotelDeptView     5   	   =dragablz(clr-namespace:Dragablz;assembly=Dragablz     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignFont#���   5   	   $	��600��5   	   $	��975��6    � 
ResizeMode$ NoResize=�6"    � WindowStartupLocation$ CenterScreen=�68    � WindowStyle$
 None=�6]   .��5      � .+�5   
   � $	��120��6   $	��Top=�6   
����  � � RowDefinitions 5      �� 5      $��* �6    �� 5      $��70 �6    .+�5      �� -   5        $��txtName��5      $��Under The Sea��6'   
�������$
��Left=�6O   $��Center=�6j   $��16(�6�   $��Champagne & Limousines)�6�    �� Padding$
 10pxq�6�   �� 5      -   5        $��	btnLogout��5      $��Right=�6>   $��Center=�6Z   ��6u   Z� ��6�   Z� .��6�   Logout5      �� 5      $��1��6   .+�5      �� $��Front Office Division��6   
�������$��Center=�6L   $��Center=�6i   $��22(�6�   $��Champagne & Limousines)�6�   5      5       � 5!   
   $��	0 100 0 0q�6   .+�5"        Dragablz.TabablzControl     InterTabController 5#      !  Dragablz.InterTabController  5$      .@�5&      �� $
��Home��6   .��5'      �� .+�5(      �� $��Reservation List��6$   $��20(�6<   $ 10q�6J   $
��Bold"�6W   &   System.Windows.Controls.DataGrid  5*      -   5        $��viewResercation��5*   #      AutoGenerateColumns .  	   
IsReadOnly	 . $	��300��6h   $��Visible=�6u   
   Columns
 5+      0  *System.Windows.Controls.DataGridTextColumn  5,   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ��  �� Path$ Id�  5-   "   $ Employee Id��65    6J   �� $ 
EmployeeId�  5.   "   $ 
Visitor Id��65    6I   �� $ 	VisitorId�  5/   "   $ Room Id��65    6F   �� $ RoomId�  50   "   $ Check In��65    6G   �� $ CheckInDate�  51   "   $ 	Check Out��65    6H   �� $ CheckOutDate�  52   "   $ Total Price��65    6J   �� $ 
TotalPrice�4  .System.Windows.Controls.DataGridTemplateColumn  53   "      HeaderTemplate 54   &   �� 55   *   .R�56   .   �� $��Action��68   57   +      CellTemplate 59   &   �� 5:   *   .R�5;   .   ��  �� Orientation$ 
Horizontal=�69   .+�5<   2   �� $��
btnCheckIn��69   -   5        $��Check In��5<   d   $��0 0 0 10q�6w   ��5=   5   �� $ Id��� 5>   2   $��btnCheckOut��69   -   5        $��	Check Out��5>   f   $��	10 0 0 10q�6z   ��5?   5   �� $ Id��� 5@   2   $��btnUpdateRes��69   -   5        $��Update��5@   h   $��	10 0 0 10q�6y   ��5A   5   �� $ Id��� 5B   2   $��	btnCancel��69   -   5        $��Cancel��5B   b   $��	10 0 0 10q�6s   ��5C   5   �� $ Id�5D   /   5E   +   5G   #   5I      �� 5K      $��Old Inn��6$   $��20(�63   $ 10q�6A   $
��Bold"�6N   �� 5L      -   5        $��	txtOldInn��5L   -   $��5q�6"   
�������6T   5M      5N      �� 5P      $��View Visitor List��6   .��5Q      �� .+�5R      �� $��Visitor List��6$   $��20(�68   $ 10q�6F   $
��Bold"�6S     5T      -	   5        $��viewVisitor��5T   #    .  	 . $	��175��6d   $��Visible=�6q   
 5U        5V   "   $ Id��65    6A   �� $ Id�  5W   "   $
 Name��65    6C   �� $
 Name�  5X   "   $	 DOB��65    6B   �� $	 DOB�  5Y   "   $ Email��65    6D   �� $ Email�  5Z   "   $ Phone Number��65    6K   �� $ phoneNumber�  5[   "    5\   &   �� 5]   *   .R�5^   .   �� $��Action��68   5_   +    5a   &   �� 5b   *   .R�5c   .   �� $ 
Horizontal=�69   .+�5d   2   �� $��btnAddReservation��69   -
   5        $��Add Reservation��5d   r   $��0 0 0 10q�6�   ��5e   5   �� $ Id��� 5f   2   $��	btnUpdate��69   -   5        $��Update��5f   b   $��	10 0 0 10q�6s   ��5g   5   �� $ Id��� 5h   2   $��	btnRemove��69   -   5        $��Remove��5h   b   $��	10 0 0 10q�6s   ��5i   5   �� $ Id�5j   /   5k   +   5m   #   5o      �� 5q      .+�5r      �� $��Manage Visitor��6(   $��20(�6>   $ 10q�6L   $
��Bold"�6Y   �� 5s      $ 
Horizontal=�6)   .+�5t   "   �� $
��10 0q�6(   $��16(�66   .��6D   Name6J   �� 5u   "   -   5        $��
txtNameVis��5u   5   $��5q�6*   
�������$	��600��6[   6i   5v      �� 5w      $ 
Horizontal=�6)   $	��0 5q�6B   .+�5x   "   �� $
��10 0q�6(   $��16(�66   .��6D   DOB6I   (	  "System.Windows.Controls.DatePicker	  5y   "   -   5        $��datepick��5y   -   $	��100��6=   6K   5z      �� 5{      $ 
Horizontal=�6)   $	��0 5q�6B   .+�5|   "   �� $
��10 0q�6(   $��16(�66   .��6D   Email6K   �� 5}   "   -   5        $��txtEmail��5}   5   $��5q�6*   
�������$	��600��6Y   6g   5~      �� 5      $ 
Horizontal=�6)   $	��0 5q�6B   .+�5�   "   �� $
��10 0q�6(   $��16(�66   .��6D   Phone Number6R   �� 5�   "   -   5        $��txtPhone��5�   5   $��5q�6*   
�������$	��600��6Y   6g   5�      �� 5�      -   5        $��	btnSubmit��5�   6   $��Submit��6%   $
��5 -5q�6G   6o   5�      5�      5�      �� 5�      $��View Room List��6   .��5�      �� .+�5�      �� $��	Room List��6$   $��20(�65   $ 10q�6C   $
��Bold"�6P     5�      -   5        $��viewRoom��5�   #    .  	 . $	��350��6a   $��Visible=�6n   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Description��65    6J   �� $ Description�  5�   "   $ Price��65    6D   �� $ Price�  5�   "   $ Status��65    6E   �� $ Status�5�      5�      5�      �� 5�      $��Manage Charge Information��6   5�      �� 5�      $��View Feedback��6   .��5�      �� .+�5�      �� $��Feedback List��6$   $��20(�69   $ 10q�6G   $
��Bold"�6T     5�      -   5        $��viewFeedback��5�   #    .  	 . $	��350��6e   $��Visible=�6r   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Room Id��65    6F   �� $ RoomId�  5�   "   $ 	Room Name��65    6H   �� $ RoomName�  5�   "   $ Description��65    6J   �� $ Description�5�      �� 5�      -   5        $��View Feedback��5�   !   $��5q�69   6[   5�      5�      �� 5�      $��Submit Personal Request��6   .��5�      �� .+�5�      �� $��Request for Personal��6$   $��20(�6@   $ 10q�6N   $��Center=�6[   $
��Bold"�6x   �� 5�      $
��10 0q�6    $��16(�6.   .��6<   Title6C   �� 5�      -   5        $��txtTitlePersonal��5�   1   $��10 10q�6"   
�������6_   �� 5�      $
��10 0q�6    $��16(�6.   .��6<   Description6I   �� 5�      -   5        $��txtDescPersonal��5�   1   $��10 10q�6"   
�������6^   �� 5�      $ 
Horizontal=�6%   $��10q�6>   .+�5�      	� -   5        $��	btnResign��5�   G    	� 	GroupName$ RA��6*   $��14(�69    d� 	IsChecked$
 TrueY�6X   .��6i   Resignation Letter6}   	� 5�      -   5        $��
btnLeaving��5�   G   $ RA��6*   $��14(�69   $
��10 0q�6Y   .��6g   Leaving Permit Request6   5�      �� 5�      -   5        $��btnPersonal��5�   !   $��Send Request��6N   $��5 10 5 5q�6e   $	��800��6w   6�   5�      5�      �� 5�      $��View Personal Request��6   .��5�      �� .+�5�      �� $��Personal Request��6$   $��20(�6<   $ 10q�6J   $
��Bold"�6W     5�      -   5        $��viewPers��5�   #    .  	 . $	��350��6a   $��Visible=�6n   
 5�        5�   "   $ Id��65    6A   �� $ Id�  5�   "   $ Title��65    6D   �� $ Title�  5�   "   $ Description��65    6J   �� $ Description�  5�   "   $
 Date��65    6C   �� $
 Date�  5�   "   $
 Note��65    6C   �� $
 Note�  5�   "   $ Status��65    6E   �� $ Status�  5�   "   $
 Type��65    6C   �� $
 Type�5�      5�      5�      5�      5�      5�      5�      