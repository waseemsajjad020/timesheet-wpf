   M S B A M L   `   `   `  ����H  Dtimesheet.wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:timesheet.wpf.Views.TimeSheet.Controls&timesheet.wpf.Views.TimeSheet.Controls  5      >    8timesheet.wpf.Views.TimeSheet.Controls.TimeSheetListItem   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:timesheet.wpf.Views.TimeSheet.Controls     5      -   5          � 	Resources  5	         NoScroll��%7   &	        �� 5
   
   .R�5      �� 6   5      5      .��5      � $��Center=�6   $��5,0,5,0q�6&   .+�5   
   �  � ColumnDefinitions 5      �� 5      $	��240 �6#   �� 5      $��* �6#   .+�5      �� $��Center=�6R   $
��Wrap=�6m    �� TextAlignment$
 Left=�6�   $��5,0,0,0q�6�   ��6   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��1��6   #��[  6&   
������ 
������ $��0q�6�   ��6~   �� *
TimeSheets+$ PropertyChanged=�  5       �� 
TargetType �� Property �� Value �� 
TargetType ��Name	 �� Padding
 J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName ]� 
Conditions �� Property �� Value��%�  '��       �� 5      " ��6   .�5      ��  � ��
 ���� 67   �� 5       � ��$ Stretch=�6G   �� 5       � ��$ Stretch=�6E   �� 5       � ��$ 0,0,0,0q�64   �� 5       � �� 5      �� 5   "   " ��62   .R�5   &   �� $ Bd��6-   #��z��69   $��0q�6e   #��z��6y   $	 0q�6�   
 . ._�5    *   �� $��Stretch=�6;   #
 z
 6Y   $��Stretch=�6�   $��0q�6�   5!   '    5"   &   P� 5#   *    �@��
IsSelected . . �5$   .   �� $ Bd��6K    � ��
 ���� 6[   5%   +   ]� 5&   *    5'   .   �� 5(   2    �@��
IsSelected . 6R   �� 5)   2    �@��IsSelectionActive .  6b   ./�5+   .   ��  � ��
 ���� 6K   �� 5,   .   $ Bd��6K    � ��
 ���� 6[   5-   +   P� 5.   *    � {� .  . �5/   .   �� # � ��6K    � ��50   +   P� 51   *    �@J�IsMouseOver . . �52   .   ��  � ��
 ���� 6K   53   +   55   #   57      58      59      ��5:      �� 5;      .R�5<      �  � Orientation$ 
Horizontal=�6$   5=      ��5?      �� 5@      .R�5A      � $
��72.6��6   $��40��6,   .+�5B      �� -   5        $��50��5B   i   $��Center=�6�   $��15(�6/  $��2��6=  $��Center=�6M  $��Center=�6j  $��0,0,0,0q�6�  {�6&   �� *
IsEnable+$ PropertyChanged=���6�   �� *Hours+$ PropertyChanged=� �� Mode$ TwoWay=�6�  5C      5D      5F      5H      5I      5J      