   M S B A M L   `   `   `  ����S  OReportsPermissionChanger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:ReportsPermissionChanger.ViewModels#ReportsPermissionChanger.ViewModels  5   	   )    #ReportsPermissionChanger.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @vm1clr-namespace:ReportsPermissionChanger.ViewModels     5   	     � Title$  Report Permissions��5   	   $	��450��6$   $	��530��61   .��5      �  � DataContext 5   
   =  7ReportsPermissionChanger.ViewModels.MainWindowViewModel  5	       � RowDefinitions 5   
   �� 5      $	��19* �6   �� 5      $
��374* �6   �� 5      $	��18* �6   �� 5      $��5* �6   .+�5   
   � $��0��6   ���#FF5722   z-depth2 J� Effect# [  66   � 5   
   $��2��6   ���#FF57226!   � 5   
   $��3��6   ���#BF360C6!   � 5   
   $��1��6    5      �� 5      $	��28* �6    �� 5      $	��23* �6    �� 5      $
��351* �6     � ColumnDefinitions 5      �� 5       $
��261* �6#   �� 5!      $
��215* �6#   �� 5"      $	��46* �6#   .+�5$      � $��0��6   $��0��6%   $��3��65   .+�5%      �� $��
Report ID:��6   $��Right=�6.   �� 5&      $	��102��6    �� DisplayMemberPath$ ReportID��6Q   ��6'   �� *Model.ReportsList+ �� SelectedItem 6n   �� *Model.SelectedReport+ �� UpdateSourceTrigger$ PropertyChanged=�5'      � 5(      $��1��6   $��3��6%   .+�5)      �� -   5        $��Add User��5)      ���#BF360C
���������6,   �� *
CommandAdd+6s   �� 5*      $��Save Changes��6   ���#BF360C
���������60   �� *CommandSave+6e   �� 5+      $��Remove Access��6   ���#BF360C
���������61   �� *CommandDelete+6h   �� 5,      $��Add to Multiple...��6   ���#BF360C
�������$	��134��6�   ��66   �� *CommandMultiple+6�   5-      �� 50      ���#FFCCBC$��0��6*   $��2��6:    �� CornerRadius$ 25��6G   $��5q�6Y     z-depth3# [ 6d   ._�51      �� $��5,0,5,5q�6   .+�52      �� $��Access List:��6   
�������$��	ExtraBold"�6F   �� 53      -   5        $��Stretch=�53      $	��275��6:   ���#FFCCBC$��0q�6\   ��6p   �� *Model.AccessList+ 6�   �� *Model.SelectedAccess+6�   54      55      �� 57      ���#FFCCBC$��1��6*   $��2��6:   $ 25��6G   $��5q�6Y   # [ 6d   $��2��6�   ._�58      �� $��5,0,5,5q�6   .+�59      �� $��
User List:��6   
�������$��	ExtraBold"�6D   �� 5:      $��Stretch=�6   $	��275��6:   ���#FFCCBC$��0q�6\   $ STATUS��5;      ��5:   p   �� *Model.UserList+ 6�   �� *Model.SelectedUser+5;   ;   5<      5=      5?      5A      5B      