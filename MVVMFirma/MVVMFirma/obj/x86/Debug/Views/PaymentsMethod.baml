   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5      $    MVVMFirma.Views.PaymentsMethod   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5      .��5	      � ���#F4F4F4$��10q�6    .+�5
   
   ��   �� CornerRadius$  8��6   
������� �� Padding$ 10q�65   ���#DDDDDD$��1q�6X   ._�5      �� $��10q�6   .@�5      �� $��Payment Method��6   .��5      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     HeadersVisibility$ Column=�5         RowBackground
 �����   AlternatingRowBackground �#F0F0F0   GridLinesVisibility$
 None=�5      ���#DDDDDD$��1q�5   5      CanUserAddRows .     CanUserDeleteRows .  	   
IsReadOnly	 . $��10q�5      ��5   ;   �� *List+
 � 	Resources
 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value)  #System.Windows.Controls.DataGridRow��%  '        '  �     �� 5      "  6$   .�5   "   ��  � �� �#007ACC6?   �� 5   "    � ��
 �����6?   �� 5   "    � ��$
 Bold"�6?   �� 5   "    � ��$ 5q�6<   5      �� 5      "  6$   .�5   "   ��  � ��$ 35��6;   5       5!         Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��61      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
IdPayments+6\     5$      $
 Name��61   $ * 6X    6?   �� *Name+6X     5%      $ Description��61   $ 2* 6f    6F   �� *Description+6f   5'      5(      5)      5*      5+      5,      