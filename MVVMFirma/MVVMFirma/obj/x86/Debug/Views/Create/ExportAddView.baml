   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5      #    MVVMFirma.Views.ExportAddView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5      .��5	      � ���#F4F4F4$��20q�6    .+�5
   
   �� 
�������  �� CornerRadius$  10��6$    �� Padding$ 20q�66   ._�5      �  � ColumnDefinitions 5      �� 5      $	��150 �6'   �� 5      $	��300 �6'   �� 5      $��50 �6'    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� $��0��6   $��0��6(   $��0,8,0,8q�65   $	��300��6F   $
��Bold"�6U   $��Action - Export / Import?��6g   �� 5      $��1��6   $��0��6+   $��8,8,0,8q�68   $��6q�6I   $��3��6U   ��5      �� *ActionTypes+ �� SelectedItem 5      �� *
ActionType+ �� UpdateSourceTrigger$ PropertyChanged=��� 5      $��0��6   $��1��6(   $��0,8,0,8q�65   $
��Bold"�6F   $��Invoice��6X   �� 5      $��1��6   $��1��6*   {�.  $��8,8,0,8q�6I   $��6q�6Z   $��35��6f   ��6u   ��  �� Path$ InvoiceNumber��� 5       $	��...��6   $��2��6'   $��1��67   $��8,8,0,8q�6D   ��6U   �� *ShowInvoice+5!      5"      5#      5$      