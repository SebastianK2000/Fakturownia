   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5      (    "MVVMFirma.Views.CompanyDataAddView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5      .��5	      � 
�������  � ColumnDefinitions  5
   
   �� 5      $	��150 �6   �� 5      $	��300 �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $��0��6    $��0,8,0,8q�6-   $��Type Of Activity��6>   �� 5   
   $��1��6   $��0��6"   $��0,8,0,8q�6/   ��6@   ��  �� Path$ TypeOfActivity� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��0��6   $��1��6    $��0,8,0,8q�6-   $��Company Name��6>   �� 5   
   $��1��6   $��1��6"   $��0,8,0,8q�6/   ��6@   �� $ CompanyName�$ PropertyChanged=��� 5    
   $��0��6   $��2��6    $��0,8,0,8q�6-   $��
First Name��6>   �� 5!   
   $��1��6   $��2��6"   $��0,8,0,8q�6/   ��6@   �� $ FirstNameCompanyOwner�$ PropertyChanged=��� 5#   
   $��0��6   $��3��6    $��0,8,0,8q�6-   $��	Last Name��6>   �� 5$   
   $��1��6   $��3��6"   $��0,8,0,8q�6/   ��6@   �� $ LastNameCompanyOwner�$ PropertyChanged=��� 5&   
   $��0��6   $��4��6    $��0,8,0,8q�6-   $	��NIP��6>   �� 5'   
   $��1��6   $��4��6"   $��0,8,0,8q�6/   ��6@   �� $	 NIP�$ PropertyChanged=��� 5)   
   $��0��6   $��5��6    $��0,8,0,8q�6-   $��REGON��6>   �� 5*   
   $��1��6   $��5��6"   $��0,8,0,8q�6/   ��6@   �� $ REGON�$ PropertyChanged=��� 5,   
   $��0��6   $��6��6    $��0,8,0,8q�6-   $��Addres��6>   �� 5-   
   $��1��6   $��6��6#   $��0,8,0,8q�60    �� DisplayMemberPath$ Value��5/       �� SelectedValuePath$	 Key��50      ��5.      �� *AddressItems+ �� SelectedValue 51      �� $ IdAdress� �� Mode$ TwoWay=��� 54   
   $��0��6   $��7��6    $��0,8,0,8q�6-   $��Customer��6>   �� 55   
   $��1��6   $��7��6#   $��0,8,0,8q�60   $ Value��57      $	 Key��58      ��56      �� *CustomerItems+ 59      �� $ 
IdCustomer�$ TwoWay=�5;      5<      