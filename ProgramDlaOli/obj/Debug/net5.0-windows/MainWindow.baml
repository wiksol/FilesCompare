   M S B A M L   `   `   `  ����H  DProgramDlaOli, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProgramDlaOliProgramDlaOli  5   	       ProgramDlaOli.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProgramDlaOli     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��700��6)   .��5	      � 
���iii� � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $��2��61   $$��APLIKACJA OLEŃKI PIERDZIEŃKI��6E   $��40(�6i   
�����_� �� TextAlignment$ Center=�6�   $��0q�6�   6�   �� 5   
   -   5         ��Name$ BtnWybierz1��5   k   $	��250��6   $��50��6   $��0��6)   $��1��69   
�����_�$��15(�6]   $��Wybierz plik 1��6�   6�   �� 5   
   -   5        $ BtnWybierz2��5   k   $	��250��6   $��50��6   $��0��6)   $��2��69   
�����_�$��15(�6]   $��Wybierz plik 2��6�   6�   �� 5   
   -   5        $ BtnWybierz3��5   k   $	��250��6   $��50��6   $��0��6)   $��3��69   
�����_�$��15(�6]   $)��#Wybierz miejsca zapisu nowego pliku��6�   6�   �� 5   
   -   5        $ 
BtnWykonaj��5   k   $	��250��6   $��50��6   $��0��6)   $��4��69   
�����_�$��15(�6]   $��Wykonaj��6   6�   �� 5   
   -   5         ��Name$ tbPlik1��5   �   $	��300��6   $��50��6    $��1��6,   $��1��6<   $
��Wrap=�6I   $'��!Ścieżka pliku wejściowego nr.1��6]   $ Center=�6�   
�����w�6�   �� 5   
   -   5        $ tbPlik2��5   �   $	��300��6   $��50��6    $��1��6,   $��2��6<   $
��Wrap=�6I   $'��!Ścieżka pliku wejściowego nr.2��6]   $ Center=�6�   
�����w�6�   �� 5   
   -   5        $ tbPlik3��5   �   $	��300��6   $��50��6    $��1��6,   $��3��6<   $
��Wrap=�6I   $"��Ścieżka pliku wyjściowego��6]   $ Center=�6   
�����w�6�   �� 5   
   -   5        $ tbStatus��5   �   $	��300��6   $��50��6    $��1��6,   $��4��6<   $ Center=�6I   $��Status zadania��6a   
�����w�6�   5      5      