   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MVVMFirma.ViewModelsMVVMFirma.ViewModels  5      1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5          MVVMFirma.Views.HelpView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      1vm"clr-namespace:MVVMFirma.ViewModels     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5        � DataContext  5
      (   "MVVMFirma.ViewModels.HelpViewModel  5   
   .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   ���	#FF3C78D8$��10q�6E   .+�5      �� $��Help Center��6   $��24(�6+   $
��Bold"�69   
�������$��35��6^   �� 5      $ �� - Find your answers here!��6   $��16(�6:   
�������$	��187��6[   $��22��6g   5      � 5   
   $��1��6   $��10q�6    � ColumnDefinitions 5      �� 5      $	��250 �6#   �� 5      $��* �6#   .+�5#      �� ���#F5F5F5$��0,0,10,0q�6.   .+�5$      �� $��Topics��6   $��18(�6*   $
��Bold"�68   $��0,0,0,10q�6J   �� 5%      $��Getting Started��6   $	��0,5q�63   �� 5&      $��How to Create an Invoice��6   $	��0,5q�6<   �� 5'      $��Export Data��6   $	��0,5q�6/   �� 5(      $��Integration Settings��6   $	��0,5q�68   �� 5)      $��Contact Support��6   $	��0,5q�63   5*      �� 5-      $��1��6   $��10q�6+   ���#FFFFFF���#D3D3D3$��1q�6c   .��5.      �� .+�5/      �� $!��Welcome to the Help Center!��6    $��20(�6C   $
��Bold"�6Q   $��0,0,0,10q�6c   �� 50      $Z��THere you can find the information you need to get started with the invoicing system.��6    $
��Wrap=�6|   $��0,0,0,10q�6�   �� 51      $g��aUse the navigation on the left to explore topics, or use the search bar to find specific answers.��6    $
��Wrap=�6�   $��0,0,0,10q�6�   �� 53      $��Common Questions:��6    $��18(�69   $
��Bold"�6G   $��	0,20,0,10q�6Y   �� 54      $��10,0,0,0q�6!   .+�55      �� $"��1. How to create an invoice?��6$   $
��Wrap=�6H   �� 56      $&�� 2. How to customize my settings?��6$   $
��Wrap=�6L   �� 57      $��3. How to export my data?��6$   $
��Wrap=�6E   �� 58      $ ��4. How to contact support?��6$   $
��Wrap=�6F   59      5:      5;      5<      5=      5>      