   M S B A M L   `   `   `  ����  timesheet.wpf&     timesheet.wpf.Views.EmployeeList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      &   System.Windows.Controls.DataGrid      AutoGenerateColumns  .   �� AlternationCount$ 2��6+      
IsReadOnly . ��6@   �� *	Employees+ �� UpdateSourceTrigger$ PropertyChanged=� � 	Resources 5	   
    �� 
TargetType �� Property �� Value �� 
TargetType	 ��Name
 J� SnapsToDevicePixels �� Padding ��Name � ColumnDefinitions � RowDefinitionsG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name7  1System.Windows.Controls.DataGridHeadersVisibility   Column �� ConverterParameter!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorType ��Name �� CanContentScroll ��Name �� Orientation �� ViewportHeight �� ViewportSize �� ScrollableHeight � Maximum* �� #ComputedVerticalScrollBarVisibility � Value  �� Mode! �� ViewportWidth" �� ScrollableWidth,# �� %ComputedHorizontalScrollBarVisibility$ �� Triggers% P� Property& P� Value' �� 	Resources=  7System.Windows.Controls.Primitives.DataGridColumnHeader( J� IsHitTestVisible) �� TextAlignment*  $System.Windows.Controls.DataGridCell* ��Name+ �� Triggers, �� 
TargetName)  #System.Windows.Controls.DataGridRow- �Name. J� Opacity?  9System.Windows.Controls.Primitives.DataGridCellsPresenter/  Name0  *System.Windows.Controls.DataGridCellsPanel��%f  '        �� 5
      "  6   .�5      ��  � ��
 ���� 6/   �� 5       � ��
 ���� 60   �� 5       � ��$ 0q�64   �� 5       � ��
 �   �6/   �� 5       �@ CanUserReorderColumns .  6:   �� 5       �@ CanUserResizeColumns .  69   �� 5       �@ CanUserAddRows .  63   �� 5       �@ CanUserResizeRows .  66   �� 5       �@ EnableRowVirtualization . 6<   �� 5      " �@ EnableColumnVirtualization . 6?   �� 5       �@%�VirtualizationMode$ 	Recycling=�6N   �� 5       �@%�IsVirtualizing . 6J   �� 5       �@ SelectionMode$ Single=�62   �� 5       �@ AutoGenerateColumns .  68   �� 5       �@ GridLinesVisibility$
 None=�68   �� 5        �@ RowDetailsVisibilityMode$ 	Collapsed=�6=   �� 5       � �� . 6C   �� 5       �@��PanningMode$
 Both=�6>   �� 5       � ��$ Visible=�6O   �� 5       �@��IsFlicksEnabled .  6;   �� 5       � �� 5       �� 5!      "  6*   .R�5"      �� $	 border��6%   
 . 
������ 
������ $��0q�6�   $ 0q�6�   ._�5#   "   �� $ DG_ScrollViewer��6/   |�.  
���   ���5$   &   �� 5%   *   " ��6:   .R�5&   .   � .+�5'   2   �  5(   6   �� 5)   :   $��* �6K   �� 5*   :   $
��Auto �6K    5,   6   �� 5-   :   $
��Auto �6H   �� 5.   :   $��* �6H   �� 5/   :   $
��Auto �6H   .+�51   6     $! PART_ColumnHeadersPresenter��6Y   $��2��6~   y�6�   �� *HeadersVisibility+# Z # Z  �� "  �� 52   6   $! PART_ScrollContentPresenter��6N   $��2��6s   $��1��6�   # z��6�   � 53   6   ���#F0F0F0$��Right=�6P   $��1��6l   $��1��6y   .+�54   :   �� $ PART_VerticalScrollBar��6E   $��Right=�6e   $��2��6�   $ Vertical=�6�   # z 6�   # z 6�   #y�z 6   6I  �� *VerticalOffset+$  OneWay=� �� *TemplatedParent+55   7   � 56   6   $��2��6;    57   :   �� 58   >   ��6O   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 59   >   $��* �6O   .+�5;   :   �� $ PART_HorizontalScrollBar��6D   $��1��6f   $ 
Horizontal=�6v   # z! 6�   # z" 6�   #y�z# 6�    6/  �� *HorizontalOffset+$  OneWay=� �� *TemplatedParent+5<   7   5=   3   5>   /   5?   +   .��5A   &   �� #
 z
 65   5B   #   5C      5D      5F      $ 5G      P� 5H      % �@��
IsGrouping& . . �5I      ��  � �� .  6J   5J      ' 5L      ���� 5M      '        "  6   .�5N      ��  � �� 5O      �� 5P   "   "  62   .R�5Q   &   � $��40��6+   ���#3A4B3B.+�5R   *     ( .  6?   �� 5S   *   $��Stretch=�6:   5T   '   5U   #   5W      5X      �� 5Z      '        "  6   .�5[      ��  � ��$ Center=�6E   �� 5\       � �� 5]      �� 5^   "   "  62   .R�5_   &   � .+�5`   *   �� 
�������$��14(�6G   #��z��6U   $��Center=�6v   $) Center=�6�   
 . $��Center=�6�   5a   '   5b   #   5d      5e      �� 5i      '        "  6   .�5j      ��  � ��
 ���� 67   �� 5k       � ��
 ���� 68   �� 5l       � ��$ 0q�6<   �� 5m       � ��$ Stretch=�6>   �� 5n       � ��$ Stretch=�6@   �� 5o       � �� 5p      �� 5q   "   "  62   .R�5r   &   �� $	 border��6-   
������ $��0q�6X   
������ 
 . ._�5s   *   �� $
* con2��6;   $��Center=�6I   #
 z
 6e   
���   �$��Center=�6�   5t   '   + 5u   &   P� 5v   *   % �@ 
IsSelected& . . �5w   .   �� $
, con2��65    � ��
 �   �6g   �� 5x   .    6K   Z�  � ���� 5y   .    6L   Z�  � ��5z   +   5|   #   5~      $ 5      P� 5�      % �@ 
IsSelected& . . �5�   "   ��  � �� 6?   �� *	ColorCode+$ PropertyChanged=�5�      5�      �� 5�      '        "  6   .�5�      ��  � ��
 ���� 67   �� 5�       �@J�SnapsToDevicePixels . 6A   �� 5�       � �� 5�      �� 5�   "   "  62   .R�5�   &   � $- grditem��6+   .+�5�   *   �� 
�������$	. 0.1Q�6D   �� 5�   *   $	 
DGR_Border��61   $��40��6E   
������ $��0q�6l   
 . ._�5�   .     $/ cont1��6X   
�������$��Center=�6g   $
��Left=�6�   $��Stretch=�6�   $��1��6�   #
 z
 6�   ��6  �� *	ColorCode+$ PropertyChanged=���5�   2   �� 5�   6   .R�5�   :     5�   7   5�   /   5�   +   5�   '   + 5�   &   P� 5�   *   % �@ 
IsSelected& . . �5�   .   �� $, 
DGR_Border��65    � �� �#CCD5F06c   5�   +   P� 5�   *   % �@ AlternationIndex$& 0��6N   . �5�   .   �� $, grditem��65    � ��
 �����6`   5�   +   P� 5�   *   % �@ AlternationIndex$& 1��6N   . �5�   .   �� $, grditem��66    � �� �#ECEBEA6a   5�   +   5�   #   5�      5�      5�      5�      5�      0   Columns0 5�   
   0	  *System.Windows.Controls.DataGridTextColumn	  5�      ,
  &System.Windows.Controls.DataGridColumn1 
  Header$1 ID��6!   2 
  Width5  /System.Windows.Controls.DataGridLengthConverter$2 50 6h   1  +System.Windows.Controls.DataGridBoundColumn3   Binding3 6-   �� *Id+$ PropertyChanged=�6h   	  5�      $
1 CODE��6!   $	2 100 6l   3 6/   �� *Code+$ PropertyChanged=�6l   	  5�      $
1 NAME��6!   $2 * 6l   3 6/   �� *Name+$ PropertyChanged=�6l   	  5�      $1 Weekly Effort��6!   $2 90 6�   3 68   �� *TotalWeeklyEffort+$ PropertyChanged=�6�   	  5�      $1 Avg. Effort��6!   $	2 100 6�   3 66   �� *AverageWeeklyEffort+$ PropertyChanged=�6�   4  .System.Windows.Controls.DataGridTemplateColumn  5�      $1 
TIME-SHEET��6%   $	2 160 69   4   CellTemplate4 5�      �� 5�      .R�5�      �� -   5        $��SHOW TIME SHEET��5�   7   $
��Left=�6Q   $	��120��6l   $��30��6x   5�      5�      5�      5�      