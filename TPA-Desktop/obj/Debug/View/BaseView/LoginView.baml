   M S B A M L   `   `   `  ����F  BTPA-Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TPA_Desktop.ViewTPA_Desktop.View  5   	        TPA_Desktop.View.LoginView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TPA_Desktop.View     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��525��6)   $
��20px(�65   $��Arial)�6E    � WindowStartupLocation$ CenterScreen=�6X    � 
ResizeMode$ NoResize=�6}   .��5	      ��  �� Padding$
 10pxq�6   ._�5
   
   �  � RowDefinitions 5      �� 5      $��50 �6!   �� 5      $	��225 �6!   �� 5      $��* �6!   .+�5      �� $��0��6   .+�5      �� $
��22px(�6   $��Arial)�6,   
����  � �� Padding$
 10pxq�6Q   Under The Sea5       5      �� 5      $��1��6   
����  �.+�5      �� $��Center=�6   $
��22px(�65   
�������.��6X   Login6_   �� 5      $
��10pxq�6   
�������6?   �� 5      
�������$��10px 0q�6+   .��6;   Email6B   �� 5      -   5        $��txtEmail��5   (   $
��10pxq�6   
�������6M   �� 5      
�������$��10px 0q�6+   .��6;   
Password6E   G� 5      -   5        $��txtPassword��5   ,   $
��10pxq�6   
�������6?   5      �� 5      -   5        $��	btnSubmit��5   �   $��Center=�6-   $��2��6J   $
��50px��6W   $	��5pxq�6e   $��100px��6s   
�������
����  �.��6�   Submit5       5!      5"      5#      