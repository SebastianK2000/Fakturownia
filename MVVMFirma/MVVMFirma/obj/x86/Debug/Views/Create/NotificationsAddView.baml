   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5      *    $MVVMFirma.Views.NotificationsAddView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5      .��5	      � 
�������  � ColumnDefinitions  5
   
   �� 5      $	��150 �6   �� 5      $	��300 �6   �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $��0��6    $��0,8,0,8q�6-   $��Message��6>   �� 5   
   $��1��6   $��0��6"   $��0,8,0,8q�6/   ��6@   ��  �� Path$ Message� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��0��6   $��1��6    $��0,8,0,8q�6-   $��	Send Date��6>   (  "System.Windows.Controls.DatePicker  5   
   $��1��6   $��1��6%   $��0,8,0,8q�62      Text 6C   �� $ SendDate�$ PropertyChanged=��� 5   
   $��0��6   $��2��6    $��0,8,0,8q�6-   $��Customer��6>   �� 5   
   $��1��6   $��2��6"   {�.  $��0,8,0,8q�6A   ��6R   �� $ CustomerName��� 5   
   $	��...��6   $��2��6   $��2��6/   $��8,8,0,8q�6<   ��6M   �� *ShowCustomers+5       5!      