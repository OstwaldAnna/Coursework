   M S B A M L   `   `   `  ����B  >magazin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:magazin.Pagesmagazin.Pages  5          magazin.Pages.OrdersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:magazin.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$  
OrdersPage��5	       N� 
FontFamily$- '/magazin;component/Resurs/Fonts/#Roboto)�5   	    N� FontSize$ 20(�5   	    N� 
Background �#A7B9D1.��5      �  � RowDefinitions 5   
   �� 5      $��8* �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��DgOrders��5      ���#BCD0EB   
IsReadOnly .    AutoGenerateColumns .  $��0��5   )      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 66   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6@   �� *Orders.FirstName+  5      $ Имя��6%   $	 * 62   
 6<   �� *Orders.MiddleName+  5      $ Отчество��6%   $	 * 67   
 6A   �� *Orders.LastName+  5      $ 
Товар��6%   $	 * 64   
 6>   �� *Closes.Product+  5      $ Пункт выдачи��6%   $	 * 6;   
 6E   �� *Orders.Address+5       5"      5#      