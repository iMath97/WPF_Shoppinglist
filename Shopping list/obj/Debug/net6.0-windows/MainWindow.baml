   M S B A M L   `   `   `  ����H  DShopping list, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Shopping_listShopping_list  5   	       Shopping_list.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Shopping_list     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	   .��5      �� .+�5   
   �� -   5        $��Heading��5      .+�5      �� $��64(�6   ���#134371$��Center=�6;   $��SemiBold"�6X   SHOPPING LIST6}   5      �� 5   
   -   5        $
��Body��5       �� Orientation$ Vertical=�6!   .+�5      �� -   5        $��ShoppingList��5      $��Stretch=�6*   $��10q�6n   $	��250��6z   5      � 5      -   5        $
��Form��5      $
��10 0q�6    � ColumnDefinitions 5      �� 5      $
��auto �6'   66   �� 5      $��* �6'   63   �� 5      $
��auto �6'   66   .+�5      �� .+�5      �� -   5        $��newItem��5      $	��500��6-   $��0 0 10 0q�69   $��5q�6L   6Z   5      �� 5      $ 
Horizontal=�6   $��2��66   .+�5      �� -   5        $��5q�5   -   $��0 0 10 0q�69   .��6K   
Add item6U   �� 5      -   5        $��5q�5   .   $��0 0 10 0q�6:   .��6L   	Edit item6W   �� 5      -   5        $��5q�5   0   $��Right=�6<   .��6X   Delete item6e   5       5!      5"      5#      5$      