   M S B A M L   `   `   `  ����H  DBetaalsysteem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:BetaalsysteemBetaalsysteem  5   	       Betaalsysteem.Klok   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Betaalsysteem     5   	     � Title$
  Klok��5   	   $	��450��6   $	��800��6#   .��5	      � 
���   � � ColumnDefinitions 5
   
   �� 5      $	��10* �6   �� 5      $��3* �6   �� 5      $	��10* �6   �� 5      $��3* �6   �� 5      $	��10* �6   �� 5      $	��90* �6    � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   .+�5   
   �� -   5         ��Name$ tbUur��5      $��0��6!   $��24��61   $
��50px��6;    �� TextAlignment$ Center=�6H   $
��50px��6_   $��30(�6�   �� 5   
   $��:��6   $��10��6   
�������$��Center=�6;   $��1��6V   $��30(�6f   �� 5   
   $��:��6   $��10��6   
�������$��Center=�6;   $��3��6V   $��30(�6f   �� 5   
   -   5        $ tbMinuut��5      $��2��6$   $��60��64   $
��50px��6>   $ Center=�6K   $
��50px��6b   $��30(�6�   �� 5   
   -   5        $ tbSec��5      $��4��6"   $��60��62   $
��50px��6<   $ Center=�6I   $
��50px��6`   $��30(�6n   6�   �� 5   
   -   5         ��Name$ btStart��5      
����  �$��5��64   $��2��6D   $��(re)settime��6Q   $��40(�6g   
�������$��250px��6�   $
��50px��6�   6�   �� 5    
   -   5        $��5��5       
����  �
�������$��Betaalsysteem��6F   $��20(�6^   $	��200��6l   $��50��6x   6�   5!      5"      