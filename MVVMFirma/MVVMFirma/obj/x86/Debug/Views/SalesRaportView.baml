   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5      ;"clr-namespace:MVVMFirma.ViewModelsMVVMFirma.ViewModels  6:   %    MVVMFirma.Views.SalesRaportView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5      9
viewmodels"clr-namespace:MVVMFirma.ViewModels     6:   .��5
      � ���#F5F5F5$��20q�6      � RowDefinitions  5   
   �� 5      $��33 �6   �� 5      $��33 �6   �� 5      $��33 �6   �� 5      $��40 �6   �� 5      $��33 �6   .+�5   
   �� $��0��6   $��Raport: Sales��6!   $��20(�5      $
��Bold"�6"   ���#333$��Center=�5   &   $��0,0,0,10q�6C   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��40 �6#   �� 5      $��* �6#   �� 5      $��40 �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��Od��6$   $��3q�61   (  "System.Windows.Controls.DatePicker  5      $��1��6   $��3q�6)      SelectedDate 64   �� *DataOd+ �� Mode$ TwoWay=��� 5      $��2��6   $��Do��6$   $��3q�61     5       $��3��6   $��3q�6)    64   �� *DataDo+$ TwoWay=�5!      � 5"   
   $��2��6    5#      �� 5$      $	��100 �6#   �� 5%      $��* �6#   .+�5'      �� $��0��6   $��Wybierz towar:��6$   $��3q�6=   �� 5(      $��1��6   $��3q�6'    �� DisplayMemberPath$ Value��5*       �� SelectedValuePath$	 Key��5+      ��5)      �� *TowaryItems+ �� SelectedValue 5,      ��  �� Path$ IdTowar�$ TwoWay=�5.      �� 50   
   $��3��6   $��Oblicz��6   $��10q�51      ���#007ACC
�������$
��Bold"�52      $��0q�6#    � Cursor$
 Hand��67   ��50   /   �� *ObliczCommand+52   7   � 54   
   $��4��6   .+�55      �� $��4��6   	 �� Orientation$	 
Horizontal=�6&   $��	10 10 0 0q�6?   .+�56      �� $��Utarg wynosi:��6   $
��Bold"�61   �� 57      $��5 0 10 5q�6   $��13(�6E   $
��Bold"�6S   ���#007ACC��6.   �� *Utarg+6e   58      59      5:      5;      