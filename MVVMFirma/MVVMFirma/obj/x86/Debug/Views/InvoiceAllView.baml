   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5      $    MVVMFirma.Views.InvoiceAllView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5      .��5	      � 
�������.+�5
   
   ��   �� CornerRadius$  8��6   
������� �� Padding$ 10q�65   ._�5      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     HeadersVisibility$ Column=�5         RowBackground
 �����   AlternatingRowBackground �#F0F0F0   GridLinesVisibility$
 None=�5      ���#DDDDDD$��1q�5   %      CanUserAddRows .     CanUserDeleteRows .  	   
IsReadOnly	 . $��10q�5      ��5   3   �� *List+
 � 	Resources
 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value)  #System.Windows.Controls.DataGridRow��%  '        '  �     �� 5      "  6   .�5      ��  � �� �#007ACC67   �� 5       � ��
 �����67   �� 5       � ��$
 Bold"�67   �� 5       � ��$ 5q�64   5      �� 5      "  6   .�5      ��  � ��$ 35��63   5      5          Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *	IdInvoice+6S   4  .System.Windows.Controls.DataGridCheckBoxColumn  5#      $ Status��6-   $
 Auto 6X    6=   �� *Status+6X     5$      $ Number��6)   $
 Auto 6T    69   �� *Number+6T     5%      $
 Date��6)   $
 Auto 6P    67   �� *Date+6P     5&      $ Kontrahent NIP��6)   $
 Auto 6c    6A   �� *KontrahentNIP+6c     5'      $ Kontrahent Name��6)   $
 Auto 6f    6B   �� *KontrahentNazwa+6f     5(      $ Payment Deadline��6)   $
 Auto 6g    6C   �� *PaymentDeadline+6g     5)      $ Payment Method��6)   $
 Auto 6g    6A   �� *PaymentMethodName+6g     5*      $ Is Paid?��6-   $
 Auto 6Z    6?   �� *IsPaid+6Z     5+      $ 
Is Active?��6-   $
 Auto 6^    6A   �� *
IsActive+6^     5,      $ Price��6)   $
 Auto 6X    68   �� *HowMuchCost+6X     5-      $ Notes��6)   $
 Auto 6R    68   �� *Notes+6R   5/      50      51      52      