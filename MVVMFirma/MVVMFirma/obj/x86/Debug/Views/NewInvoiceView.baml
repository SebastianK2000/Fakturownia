   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5      $    MVVMFirma.Views.NewInvoiceView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5      .��5	      � 
�������  � ColumnDefinitions  5
   
   �� 5      $	��150 �6   �� 5      $	��300 �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $��0��6    $��0,8,0,8q�6-   $��Status��6>   �� 5   
   $��1��6   $��0��6"   $��0,8,0,8q�6/   ��6@   ��  �� Path$ Status� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��0��6   $��1��6    $��0,8,0,8q�6-   $��Number��6>   �� 5   
   $��1��6   $��1��6"   $��0,8,0,8q�6/   ��6@   �� $ Number�$ PropertyChanged=��� 5   
   $��0��6   $��2��6    $��0,8,0,8q�6-   $
��Date��6>   �� 5    
   $��1��6   $��2��6"   $��0,8,0,8q�6/   ��6@   �� $
 Date�$ PropertyChanged=��� 5"   
   $��0��6   $��3��6    $��0,8,0,8q�6-   $��Deadline payment��6>   �� 5#   
   $��1��6   $��3��6"   $��0,8,0,8q�6/   ��6@   �� $ PaymentDeadline�$ PropertyChanged=��� 5%   
   $��0��6   $��4��6    $��0,8,0,8q�6-   $��Is Paid?��6>   �� 5&   
   $��1��6   $��4��6"   $��0,8,0,8q�6/   ��6@   �� $ IsPaid�$ PropertyChanged=��� 5(   
   $��0��6   $��5��6    $��0,8,0,8q�6-   $��
Is Active?��6>   �� 5)   
   $��1��6   $��5��6"   $��0,8,0,8q�6/   ��6@   �� $ IsActive�$ PropertyChanged=��� 5+   
   $��0��6   $��6��6    $��0,8,0,8q�6-   $��Price��6>   �� 5,   
   $��1��6   $��6��6"   $��0,8,0,8q�6/   ��6@   �� $ HowMuchCost�$ PropertyChanged=��� 5.   
   $��0��6   $��7��6    $��0,8,0,8q�6-   $��Notes��6>   �� 5/   
   $��1��6   $��7��6"   $��0,8,0,8q�6/   ��6@   �� $ Notes�$ PropertyChanged=�51      52      