   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5      %    MVVMFirma.Views.SettingsAddView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5      .��5	      � ���#F4F4F4$��20q�6    .+�5
   
   ��   �� CornerRadius$  8��6   
������� �� Padding$ 20q�65   ���#DDDDDD$��1q�6X   ._�5      �  � ColumnDefinitions 5      �� 5      $	��200 �6'   �� 5      $��* �6'   �� 5      $��50 �6'    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� $��0��6   $��0��6(   $��	Language:��65   $
��Bold"�6I   $��Center=�6[   �� 5      $��1��6   $��0��6+   $��6q�68   $��35��6D   ��6S   �� *	Languages+ �� SelectedItem 5      �� *
Language+ �� UpdateSourceTrigger$ PropertyChanged=��� 5      $��0��6   $��1��6(   $��Login:��65   $
��Bold"�6F   $��Center=�6X   �� 5       $��25��6   $��0 10 0 0q�6&   $��1��68   $��1��6H   $��6q�6U   $��35��6a   ��6p   ��  �� Path$ Login�$ PropertyChanged=��� 5"      $��0��6   $��2��6(   $��	Password:��65   $
��Bold"�6I   $��Center=�6[   �� 5#      $��1��6   $��2��6,    �� Padding$ 6q�69   $��35��6E   ��6T   �� $ Password�$ PropertyChanged=� �� Mode$ TwoWay=��� 5%      $��0��6   $��3��6(   $��Payment Deadline Trigger:��65   $
��Bold"�6Y   $��Center=�6k   �� 5&      $��1��6   $��3��6+   $��6q�68   $��35��6D   	 d� 	IsChecked	 6S   �� $ PaymentDeadlineTrigger�$ PropertyChanged=��� 5(      $��0��6   $��4��6(   $��New Invoice Trigger:��65   $
��Bold"�6T   $��Center=�6f   �� 5)      $��1��6   $��4��6+   $��6q�68   $��35��6D   	 6S   �� $ NewInvoiceTrigger�$ PropertyChanged=��� 5+      $��0��6   $��5��6(   $��Payment Not Made:��65   $
��Bold"�6Q   $��Center=�6c   �� 5,      $��1��6   $��5��6+   $��6q�68   $��35��6D   	 6S   �� $ PaymentNotMade�$ PropertyChanged=��� 5.      $��0��6   $��6��6(   $��	Customer:��65   $
��Bold"�6I   $��Center=�6[   �� 5/      $��1��6   $��6��6*   $��6q�67   $��35��6C   {�.  ��6d   �� $ CustomerName��� 50      $	��...��6   $��2��6'   $��6��67   ��6D   �� *ShowCustomers+51      52      53      54      