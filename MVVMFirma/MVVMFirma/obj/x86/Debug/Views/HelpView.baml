   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MVVMFirma.ViewModelsMVVMFirma.ViewModels  5      1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5          MVVMFirma.Views.HelpView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      1vm"clr-namespace:MVVMFirma.ViewModels     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5        � 	Resources  5         SidebarButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6+   .�5      ��  � �� �#0056B36+   �� 5       � ��
 �����6+   �� 5       � ��$ 16(�6)   �� 5       � ��$ 10q�6(   �� 5       � ��$	 0,5q�6'   �� 5       � ��$ 0q�60   �� 5       � ��$ Stretch=�64   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  � �� �#007BFF6?   5      P� 5       � �� . . �5    "   ��  � �� �#003F736?   5!      5#      5%      5&      5'       � DataContext 5)      (   "MVVMFirma.ViewModels.HelpViewModel  5*   
   .��5-      � 
�������	 � RowDefinitions	 5.   
   �� 5/      $
��Auto �6   �� 50      $��* �6   .+�53   
   �� 
 �� Orientation$
 
Horizontal=�6   ���#0056B3$��10q�6C   .+�54      �� $��Help Center��6   $��24(�6+   $
��Bold"�69   
�������$��Center=�6^   $��Center=�6y   $��5,5,0,5q�6�   �� 55      $ �� - Find your answers here!��6   $��16(�6:   
�������$��10,5,0,5q�6[   $��Center=�6m   56      � 58   
   $��1��6   $��10q�6    � ColumnDefinitions 59      �� 5:      $	��250 �6#   �� 5;      $��* �6#   .+�5>      �� ���#F5F5F5 �� Padding$ 10q�6*   $��0,0,10,0q�67   ._�5?      �� .+�5@      �� $��Topics��6    $��18(�6.   $
��Bold"�6<   $��5,0,0,20q�6N   �� 5A      $��Getting Started��6   #��[  67   $��30��6c   �� 5B      -   5        $��How to Create an Invoice��5B      #��[  6@   $��30��6�   �� 5C      $��Export Data��6   #��[  63   $��30��6_   �� 5D      $��Integration Settings��6   #��[  6<   $��30��6h   �� 5E      $��Contact Support��6   #��[  67   $��30��6c   5F      5G      �� 5I      $��1��6   $��10q�6+   ���#FFFFFF���#D3D3D3$��1q�6c   .��5J      �� .+�5K      �� $!��Welcome to the Help Center!��6    $��20(�6C   $
��Bold"�6Q   $��0,0,0,10q�6c   �� 5L      $Z��THere you can find the information you need to get started with the invoicing system.��6    $
��Wrap=�6|   $��0,0,0,10q�6�   �� 5M      $g��aUse the navigation on the left to explore topics, or use the search bar to find specific answers.��6    $
��Wrap=�6�   $��0,0,0,10q�6�   �� 5O      $��Common Questions:��6    $��18(�69   $
��Bold"�6G   $��	0,20,0,10q�6Y   �� 5P      $��10,0,0,0q�6!   .+�5Q      �� $"��1. How to create an invoice?��6$   $
��Wrap=�6H   �� 5R      $&�� 2. How to customize my settings?��6$   $
��Wrap=�6L   �� 5S      $��3. How to export my data?��6$   $
��Wrap=�6E   �� 5T      $ ��4. How to contact support?��6$   $
��Wrap=�6F   5U      5V      5W      5X      5Y      5Z      