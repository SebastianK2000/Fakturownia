   M S B A M L   `   `   `  ����D  @MVVMFirma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MVVMFirma.ViewModelsMVVMFirma.ViewModels  5      1clr-namespace:MVVMFirma.ViewsMVVMFirma.Views  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� DataType3    -MVVMFirma.ViewModels.WszystkieTowaryViewModel)   #MVVMFirma.Views.WszystkieTowaryView-   'MVVMFirma.ViewModels.NowyTowarViewModel#   MVVMFirma.Views.NowyTowarView.   (MVVMFirma.ViewModels.NewInvoiceViewModel$   MVVMFirma.Views.NewInvoiceView.   (MVVMFirma.ViewModels.InvoiceAllViewModel$   MVVMFirma.Views.InvoiceAllView(   "MVVMFirma.ViewModels.HelpViewModel	   MVVMFirma.Views.HelpView/
   )MVVMFirma.ViewModels.CompanyDataViewModel%   MVVMFirma.Views.CompanyDataView2   ,MVVMFirma.ViewModels.ContactSupportViewModel(   "MVVMFirma.Views.ContactSupportView3   -MVVMFirma.ViewModels.CustomerHistoryViewModel)   #MVVMFirma.Views.CustomerHistoryView1   +MVVMFirma.ViewModels.CustomersListViewModel'   !MVVMFirma.Views.CustomersListView3   -MVVMFirma.ViewModels.CustomersRaportViewModel)   #MVVMFirma.Views.CustomersRaportView,   &MVVMFirma.ViewModels.CustomerViewModel"   MVVMFirma.Views.CustomerView*   $MVVMFirma.ViewModels.ExportViewModel    MVVMFirma.Views.ExportView2   ,MVVMFirma.ViewModels.HistoryInvoiceViewModel(   "MVVMFirma.Views.HistoryInvoiceView*   $MVVMFirma.ViewModels.ImportViewModel    MVVMFirma.Views.ImportView1   +MVVMFirma.ViewModels.NotificationsViewModel'   !MVVMFirma.Views.NotificationsView/   )MVVMFirma.ViewModels.PaidInvoiceViewModel!   MVVMFirma.Views.PaidInvoice/    )MVVMFirma.ViewModels.SalesRaportViewModel%!   MVVMFirma.Views.SalesRaportView,"   &MVVMFirma.ViewModels.SettingsViewModel"#   MVVMFirma.Views.SettingsView/$   )MVVMFirma.ViewModels.SettlementsViewModel%%   MVVMFirma.Views.SettlementsView1&   +MVVMFirma.ViewModels.UnpaidInvoiceViewModel''   !MVVMFirma.Views.UnpaidInvoiceView'(   !MVVMFirma.ViewModels.VatViewModel)   MVVMFirma.Views.VatView   MainHCCStyle �� 
TargetType �� Property �� Value �� CornerRadius �� Padding J� SnapsToDevicePixels �� 
TargetType  MainBorderStyle  CommandsTemplate �� Command	 �� Path  ClosableTabItemTemplate
 � Cursor  WorkspacesTemplate$ �� IsSynchronizedWithCurrentItem�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      )vm"clr-namespace:MVVMFirma.ViewModels  5      $vwclr-namespace:MVVMFirma.Views  5      %�  (��       5      *,  +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)(�� �     5      *, +)(�� �     5      *,
 +)(�� ,    5      *, +)(�� ^    5#      *, +)(�� �    5'      *, +)(�� �    5+      *, +)(�� �    5/      *, +)(�� &    53      *, +)(�� X    57      *, +)(�� �    5;      *, +)(�� �    5?      *, +)(�� �    5C      *, +)(��      5G      *,  +)(�� R    5K      *," +)(�� �    5O      *,$ +)(�� �    5S      *,& +)(�� �    5W      *,( +)&	      &	 l    &	 e    &	 s    &	 
    7  �� 5      "    6   .R�5   
     5	      �� 5      "   6   .R�5   
     5      �� 5      "   6   .R�5   
     5      �� 5      "   6   .R�5   
     5      �� 5      "   6   .R�5   
   	  5      �� 5      "  
 6   .R�5   
     5      �� 5      "   6   .R�5    
     5!      �� 5#      "   6   .R�5$   
     5%      �� 5'      "   6   .R�5(   
     5)      �� 5+      "   6   .R�5,   
     5-      �� 5/      "   6   .R�50   
     51      �� 53      "   6   .R�54   
     55      �� 57      "   6   .R�58   
     59      �� 5;      "   6   .R�5<   
     5=      �� 5?      "   6   .R�5@   
     5A      �� 5C      "   6   .R�5D   
     5E      �� 5G      "    6   .R�5H   
   !  5I      �� 5K      "  " 6   .R�5L   
   #  5M      �� 5O      "  $ 6   .R�5P   
   %  5Q      �� 5S      "  & 6   .R�5T   
   '  5U      �� 5W      "  ( 6   .R�5X   
   )  5Y      �� 5[      " ��6!   .�5\   
   ��  � �� 5]      �� 5^      .R�5_      �� 
����  �
�������$��1q�5b      $ 5��5c      $��4q�5d      $ 4q�5e       . ._�5h      �� $��14(�5i      $
��Bold"�5j      
�������$��Center=�5l      #��z��5m      5o      5p      5r      �� 5s   
    � �� .  6&   �� 5t   
    � �� 5u      �� 5z      " ��6"   .R�5{      ]� .+�5|      �� $	��Top=�5}      $��Header��5~      #��z��5      �� 5�      $��Content��5�      #��z��5�      5�      5�      5�      5�      �� 5�      " ��6$   .�5�   
   ��  � ��
 �����6'   �� 5�   
    � ��
 �����6(   �� 5�   
    � ��$ 1q�6,   �� 5�   
    �@��CornerRadius$ 5��6)   �� 5�   
    �@J�SnapsToDevicePixels . 60   5�      �� 5�      .R�5�   
   �� ��.  $	��6,2q�6A   ��6)   �� ��5�      �� 5�      .R�5�      �� $	��2,6q�6    �� 5�       6   �� $	 Command�.�69   .�5�      �� ��6   �� $	 DisplayName�5�      5�      5�      5�      5�      �� 5�      .R�5�   
   ]� $	��120��6   .+�5�      �� $��X��5�   	   $

 Hand��5�   	   $��Right=�5�   	   |�.  $��Courier)�5�   	   $��9(�5�   	   $
��Bold"�5�   	   $��0,1,0,0q�5�   	   $��0q�5�   	   $��Bottom=�5�   	   $��16��5�   	   $��16��6   ��5�   	   �� $	 CloseCommand�5�      �� 5�      $��Center=�5�   	   ��5�   	   �� $	 DisplayName�5�   	   5�      5�      �� 5�      .R�5�   
   �� $
 TrueY�5�      8��  $��4q�5�      ��5�      �� 5�      5�      5�      