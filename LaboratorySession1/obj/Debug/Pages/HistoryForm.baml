   M S B A M L   `   `   `  ����M  ILaboratorySession1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LaboratorySession1.PagesLaboratorySession1.Pages  5      *    $LaboratorySession1.Pages.HistoryForm   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:LaboratorySession1.Pages     5        N� Title$!  Исторяи входов��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��1* �6   .+�5   
   �� -   5        $��Btn_Back��5      $��40��5      $	��150��5      $��Right=�5      $��0 0 30 0q�5      $��
Назад��5      
����� �5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��HistoryDataGrid��5      $��2��5         CanUserSortColumns .    AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�5         
IsReadOnly .    EnableRowVirtualization .     Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Логин��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 1* 5#   %   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5$   %   �� *Login+  5%      $ Удачный вход��6%   $	 1* 5&   %   
 5'   %   �� *SuccessLoginIN+  5(      $' !Время авторизации��6%   $	 1* 5)   %   
 5*   %   �� *TimeLoginIN+5,      5.      5/      