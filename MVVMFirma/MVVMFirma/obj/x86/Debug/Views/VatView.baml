   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5          MVVMFirma.Views.VatView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMFirma.Views     5      .��5	      � ���#F5F5F5$��20q�6      � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��
Raport VAT��6!   $��20(�5      $
��Bold"�6"   $��Center=�5      $��0 0 0 10q�61   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   .+�5      �� $��	10 0 10 0q�6   $	��Od:��6+   $��Center=�66   (  "System.Windows.Controls.DatePicker  5      $	��150��6F      SelectedDate 6   �� *DataOd+ �� Mode$ TwoWay=�6F   �� 5      $��	10 0 10 0q�6   $	��Do:��6+   $��Center=�66     5      $	��150��6F    6   �� *DataDo+$ TwoWay=�6F   5      �� 5   
   $��2��6   $ 
Horizontal=�6"   $��
10 10 0 10q�6;   .+�5      �� $��	10 0 10 0q�6   $��Wybierz towar:��6+   $��Center=�6A   �� 5       �� DisplayMemberPath$ Value��5        �� SelectedValuePath$	 Key��5!      $	��200��5#      ��5      �� *TowaryItems+ �� SelectedValue 5"      ��  �� Path$ IdTowar�$ TwoWay=�5#      5$      �� 5&   
   $��3��6   $��Oblicz��6   $��10q�5'      ���#007ACC
�������$
��Bold"�5(      $��0q�6#    � Cursor$
 Hand��67   ��5&   /   �� *ObliczVatCommand+5(   7   �� 5*   
   $��4��6   $ 
Horizontal=�6"   $��	10 10 0 0q�6;   .+�5+      �� $��Utarg wynosi:��6   $
��Bold"�6-   �� 5,      $��5 0 10 5q�6   $��13(�6D   $
��Bold"�6R   ���#007ACC��6*   �� *
UtargVat+6d   5-      5.      5/      