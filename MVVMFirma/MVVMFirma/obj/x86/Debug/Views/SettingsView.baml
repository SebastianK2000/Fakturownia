   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5      "    MVVMFirma.Views.SettingsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5      .��5	      � 
�������$	��500��6   $
��2050��6+     � ColumnDefinitions  5
   
   �� 5      $
��533* �6   �� 5      $
��267* �6   .+�5   
   ��  �� CornerRadius$ 8��6   
������� �� Padding$ 10q�65   ._�5      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     HeadersVisibility$ Column=�5         RowBackground
 �����   AlternatingRowBackground �#F0F0F0   GridLinesVisibility$
 None=�5      ���#DDDDDD$��1q�5   -      CanUserAddRows .  	   CanUserDeleteRows	 .  
   
IsReadOnly
 . $��10q�5      ��5   3   �� *List+ � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value)  #System.Windows.Controls.DataGridRow��%  '        '  �     �� 5      "  6   .�5      ��  � �� �#007ACC67   �� 5       � ��
 �����67   �� 5       � ��$
 Bold"�67   �� 5       � ��$ 5q�64   5       �� 5!      "  6   .�5"      ��  � ��$ 35��63   5#      5$         Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *
IdSettings+6T     5'      $ Language��6)   $
 Auto 6W    6;   �� *	Languge+6W     5(      $ Login��6)   $
 Auto 6R    68   �� *Login+6R     5)      $ Password��6)   $
 Auto 6X    6;   �� *
Password+6X   4  .System.Windows.Controls.DataGridCheckBoxColumn  5*      $ Payment Deadline Trigger��6-   $
 Auto 6z    6O   �� *PaymentDeadlineTrigger+6z     5+      $ New Inovice Trigger��6-   $
 Auto 6p    6J   �� *NewInvoiceTrigger+6p     5,      $ Pyment Not Made��6-   $
 Auto 6i    6F   �� *PaymentNotMade+6i     5-      $ Customer Name��6)   $
 Auto 6a    6@   �� *CustomerName+6a     5.      $ Customer Email��6)   $
 Auto 6c    6A   �� *CustomerEmail+6c     5/      $ Customer Phone��6)   $
 Auto 6c    6A   �� *CustomerPhone+6c   51      52      53      54      