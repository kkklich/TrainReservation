   M S B A M L   `   `   `  ����K  GTrainReservation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TrainReservationTrainReservation  5           TrainReservation.ListTrain   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:TrainReservation     5        N� Title$  	ListTrain��5	      .��5      � .+�5   
   �� -   5         ��Name$ listView��5      $
��Left=�6%   $	��305��6@   $��	69,49,0,0q�6M   $	��Top=�6`   $	��633��6x    �� View 5      �� 5      .P�5      �� $��	timeleave��6%    �� Width$
 auto��68    �� DisplayMemberBinding 6E   �� *	TimeLeave+ �� StringFormat$ {0:dd.MM.yyyy HH:MM}���� 5      $��NameStationFrom��6%   $
 auto��6>    6K   �� *NameStationFrom+�� 5      $��Name_station2��6%   $
 auto��6<    6J   �� *Name_station2+�� 5      $��	TimeCome2��6%   $
 auto��68    6F   �� *	TimeCome2+$ {0:dd.MM.yyyy HH:MM}���� 5      $��	TimeCome2��6%   $
 auto��68    6F   �� *
TimeTravel+$ 	{0:HH:mm}���� 5      $��km��6%   $	 150��61    6>   �� *km+5      5      �� 5   
   -   5         ��Name$ label��5      $��Lista połączeń��6   $
��Left=�68   $��30��6S   $��	73,19,0,0q�6_   $	��Top=�6r   $	��263��6�   �� 5   
   -   5         ��Name$ 
btn_choose��5      $��Dalej��6%   $
��Left=�65   $��33��6P   $��551,374,0,0q�6\   $	��Top=�6q   $	��151��6�   6�   5      5      