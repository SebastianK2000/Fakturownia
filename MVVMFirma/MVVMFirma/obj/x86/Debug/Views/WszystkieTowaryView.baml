   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5      )    #MVVMFirma.Views.WszystkieTowaryView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5      .��5	      � 
�������$
��Auto��6     � ColumnDefinitions  5
   
   �� 5      $	��50* �6   �� 5      $��7* �6   .+�5   
   ��  �� CornerRadius$ 8��6   
������� �� Padding$ 10q�65   ._�5      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     HeadersVisibility$ Column=�5         RowBackground
 �����   AlternatingRowBackground �#F0F0F0   GridLinesVisibility$
 None=�5      ���#DDDDDD$��1q�5   %      CanUserAddRows .  	   CanUserDeleteRows	 .  
   
IsReadOnly
 . $��10q�5      ��5   3   �� *List+ �� SelectedItem 5      ��  �� Path$ SelectedInvoice� � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value)  #System.Windows.Controls.DataGridRow��%  '        '  �     �� 5      "  6   .�5      ��  � �� �#007ACC67   �� 5       � ��
 �����67   �� 5       � ��$
 Bold"�67   �� 5        � ��$ 5q�64   5!      �� 5"      "  6   .�5#      ��  � ��$ 35��63   5$      5%         Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *
IdTowaru+6R     5(      $
 Code��6)   $
 Auto 6P    67   �� *Code+6P     5)      $
 Name��6)   $
 Auto 6P    67   �� *Name+6P     5*      $ Purchase Rate��6)   $
 Auto 6a    6@   �� *PurchaseRate+6a     5+      $ 
Sales Rate��6)   $
 Auto 6[    6=   �� *	SalesRate+6[     5,      $ Price��6)   $
 Auto 6R    68   �� *Price+6R     5-      $ Spread��6)   $
 Auto 6T    69   �� *Spread+6T     5.      $ Notes��6)   $
 Auto 6R    68   �� *Notes+6R     5/      $ 
Created At��6)   $
 Auto 6[    6=   �� *	CreatedAt+6[     50      $ 
Updated At��6)   $
 Auto 6[    6=   �� *	UpdatedAt+6[   52      53      54      55      