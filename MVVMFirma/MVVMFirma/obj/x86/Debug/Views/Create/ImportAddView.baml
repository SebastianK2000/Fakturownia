   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5      #    MVVMFirma.Views.ImportAddView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5      .��5	      � 
�������  � ColumnDefinitions  5
   
   �� 5      $	��150 �6   �� 5      $	��300 �6   �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $��0��6    $��0,8,0,8q�6-   $��Action - Export / Import?��6>   �� 5   
   $��1��6   $��0��6#   $��0,8,0,8q�60   ��5      �� *ActionTypes+ �� SelectedItem 5      �� *
ActionType+ �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��0��6   $��1��6    $��0,8,0,8q�6-   $��Invoice��6>   �� 5   
   $��1��6   $��1��6"   {�.  $��0,8,0,8q�6A   ��6R   ��  �� Path$ InvoiceNumber��� 5   
   $	��...��6   $��2��6   $��1��6/   $��8,8,0,8q�6<   ��6M   �� *ShowInvoice+5       5!      