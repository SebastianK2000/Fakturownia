   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5      $    MVVMFirma.Views.NewInvoiceView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5      .��5	      � 
�������  � ColumnDefinitions  5
   
   �� 5      $	��150 �6   �� 5      $	��300 �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $��0��6    $��0,8,0,8q�6-   $��Active��6>   �� 5   
   $��1��6   $��0��6#   $��0,8,0,8q�60    d� 	IsChecked 6A   ��  �� Path$ IsActive� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��0��6   $��1��6    $��0,8,0,8q�6-   $��Number��6>   �� 5   
   $��1��6   $��1��6"   $��0,8,0,8q�6/   ��6@   �� $ Number�$ PropertyChanged=��� 5!   
   $��0��6   $��2��6    $��0,8,0,8q�6-   $
��Date��6>   (  "System.Windows.Controls.DatePicker  5"   
   $��1��6   $��2��6%   $��0,8,0,8q�62      Text 6C   �� $
 Date�$ PropertyChanged=��� 5$   
   $��0��6   $��3��6    $��0,8,0,8q�6-   $��Deadline payment��6>     5%   
   $��1��6   $��3��6%   $��0,8,0,8q�62    6C   �� $ PaymentDeadline�$ PropertyChanged=��� 5'   
   $��0��6   $��4��6    $��0,8,0,8q�6-   $��Is Paid?��6>   �� 5(   
   $��1��6   $��4��6#   $��0,8,0,8q�60    6A   �� $ IsPaid�$ PropertyChanged=��� 5*   
   $��0��6   $��5��6    $��0,8,0,8q�6-   $��Price��6>   �� 5+   
   $��1��6   $��5��6"   $��0,8,0,8q�6/   ��6@   �� $ HowMuchCost�$ PropertyChanged=��� 5-   
   $��0��6   $��6��6    $��0,8,0,8q�6-   $��Notes��6>   �� 5.   
   $��1��6   $��6��6"   $��0,8,0,8q�6/   ��6@   �� $ Notes�$ PropertyChanged=��� 50   
   $��0��6   $��7��6    $��0,8,0,8q�6-   $��
Kontrahent��6>   �� 51   
   $��1��6   $��7��6#   $��0,8,0,8q�60    �� DisplayMemberPath$ Value��53       �� SelectedValuePath$	 Key��54      ��52      �� *KontrahentItems+ �� SelectedValue 55      �� $ IdKontrahenta�	 �� Mode$	 TwoWay=��� 58   
   $��0��6   $��8��6    $��0,8,0,8q�6-   $��Customer��6>   �� 59   
   $��1��6   $��8��6#   $��0,8,0,8q�60   $ Value��5;      $	 Key��5<      ��5:      �� *CustomerItems+ 5=      �� $ 
IdCustomer�$	 TwoWay=��� 5@   
   $��0��6   $��9��6    $��0,8,0,8q�6-   $��Payment Method��6>   �� 5A   
   $��1��6   $��9��6#   $��0,8,0,8q�60   $ Value��5C      $	 Key��5D      ��5B      �� *PaymentMethodItems+ 5E      �� $ PaymentMethod�$	 TwoWay=�5H      5I      