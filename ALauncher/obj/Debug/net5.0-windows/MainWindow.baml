   M S B A M L   `   `   `  ����D  @ALauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ALauncher	ALauncher  5   	       ALauncher.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ALauncher     5   	   -   5          �Name$  wnwMainWindow��5	   	    � Title$ 
MainWindow��5   	   $	��500��6   $	��800��6,    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   ���#1e1c1d���#d1d1d2.��5      �  � RowDefinitions 5   
   �� 5      -   5         ��Name$ FirstRow��5      ��6.   ��  �� ElementName$
 Menu�� �� Path$ Height�6a   �� 5      6   	 � ColumnDefinitions	 5   
   �� 5      6!   .+�5   
   �� -   5        
 ��Name$
 BorderWindow��5      $��3q�5      ���#000000$
��1000��5      $
��1000��5      o� 5   
   -   5         o�Name$
 Menu��5      $��0��5      $��30��5      $��28��5      $	��Top=�5       ���#000000���#d1d1d2
������ $��3 3 3 0q�5$      5%      � 5&   
    � Orientation$ 
Horizontal=�6   $��Right=�5'       K� ZIndex$ 10��5(      $��3 3 3 0q�5*      $��Stretch=�5+      .+�5,      �� -   5         ��Name$ btnCollapse��5,      $��30��5-      $	��—��5.      
������ ���#d1d1d2$��15(�51      $��0q�52      ��53      �� $ FirstRow��$ Height�6L   �� 54      -   5        $ btnMaximize��54      $��30��55      $	��▭��56      
������ ���#d1d1d2$��15(�59      $��0q�5:      ��5;      �� $ FirstRow��$ Height�6L   �� 5<      -   5        $ btnExit��5<      $��30��5=      $��X��5>      
������ ���#d1d1d2$��0q�5A      ��5B      �� $ FirstRow��$ Height�6L   5C      � 5D   
   -   5         �Name$ AppList��5D      $��1��5E      $ 
Horizontal=�5F      $��20q�5G      ��5H      �� $ wnwMainWindow��$ 
Background�.+�5I      �� -	   5        $
 SecApp��5I      $��
10 10 5 10q�5J      ���#0000$	��150��5L      ._�5M      �� .+�5O      �� $	��100��6   $	��100��5P      $��0 10 0 0q�5Q      $"��pack://application:,,,/1.jpg��5R      6D   �� 5S      ���#0000���#FFFFFF$��Center=�5U      $��15(�5V      $��0q�5W      $��QR-Code��5X      62   �� 5Y      ���#0000���#FFFFFF$��Center=�5[      $��0q�5\      $��	5 -5 5 10q�5]      $��60��5^      $��
ExtraLight"�5_      ��5`      �� 5a       �� TextWrapping$
 Wrap=�6)   $D��>AaaaaaaaaaaaaaaaaaaaaaaaaaAAAAAAAAAAAAAAAAAAaaaaaaaaaaaaaaxxxx��6=   5c      5d      5e      5f      5g      5h      