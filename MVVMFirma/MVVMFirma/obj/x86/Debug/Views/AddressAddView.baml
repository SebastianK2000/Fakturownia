   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5      $    MVVMFirma.Views.AddressAddView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5      .��5	      � ���#F4F4F4$��20q�6    .+�5
   
   �� 
�������  �� CornerRadius$  10��6$    �� Padding$ 20q�66   ._�5      �  � ColumnDefinitions 5      �� 5      $	��150 �6'   �� 5      $	��300 �6'   �� 5      $��50 �6'    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� $��0��6   $��0��6(   $��0,8,0,8q�65   $
��Bold"�6F   $
��City��6X   �� 5      $��1��6   $��0��6*   $��0,8,0,8q�67   $��6q�6H   $��35��6T   ��6c   ��  �� Path$
 City� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . �� 5      $��0��6   $��1��6(   $��0,8,0,8q�65   $
��Bold"�6F   $��Street��6X   �� 5      $��1��6   $��1��6*   $��0,8,0,8q�67   $��6q�6H   $��35��6T   ��6c   �� $ Street�$ PropertyChanged=��� 5!      $��0��6   $��2��6(   $��0,8,0,8q�65   $
��Bold"�6F   $
��Home��6X   �� 5"      $��1��6   $��2��6*   $��0,8,0,8q�67   $��6q�6H   $��35��6T   ��6c   �� $ NrHome�$ PropertyChanged=��� 5$      $��0��6   $��3��6(   $��0,8,0,8q�65   $
��Bold"�6F   $��Local��6X   �� 5%      $��1��6   $��3��6*   $��0,8,0,8q�67   $��6q�6H   $��35��6T   ��6c   �� $ NrLocal�$ PropertyChanged=��� 5'      $��0��6   $��4��6(   $��0,8,0,8q�65   $
��Bold"�6F   $��Zip Code��6X   �� 5(      $��1��6   $��4��6*   $��0,8,0,8q�67   $��6q�6H   $��35��6T   ��6c   �� $ ZipCode�$ PropertyChanged=��� 5*      $��0��6   $��5��6(   $��0,8,0,8q�65   $
��Bold"�6F   $��Customer��6X   �� 5+      -   5        $��1��5+      $��5��6*   {�.  $��0,8,0,8q�6I   $��6q�6Z   $��35��6f   ��6u   �� $ CustomerName�$ PropertyChanged=�6�   �� 5,      $	��...��6   $��2��6'   $��5��67   $��8,8,0,8q�6D   ��6U   �� *ShowCustomers+5-      5.      5/      50      