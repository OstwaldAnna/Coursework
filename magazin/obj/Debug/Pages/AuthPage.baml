   M S B A M L   `   `   `  ����B  >magazin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:magazin.Pagesmagazin.Pages  5          magazin.Pages.AuthPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:magazin.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  AuthPage��5	       N� 
Background �#8997AB N� 
FontFamily$- '/magazin;component/Resurs/Fonts/#Roboto)�5   	    N� FontSize$ 20(�5   	   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5   
   �� $��/Resurs/logo_1.png��6   $	��500��6,   $��10q�68   �� 5      $��Вход��6   $��30(�6$   $��Center=�62   $	��Top=�6O   $��10q�6g   5      �� 5   
   $��Center=�6   $��Center=�60   $	��400��6M   .+�5      �� $ 
Horizontal=�6   $��10q�62   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�6*   $��Center=�5   *   $��7q�5   *   $��25��5   *   $��25��5   *   �� 5      -   5         ��Name$ NameTextBox��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Login��5         
HelperText$ Введите логин��5      $	��340��5    P   ��6   �� *Name+	 �� UpdateSourceTrigger$	 PropertyChanged=�6P   5!      �� 5"      $ 
Horizontal=�6   $��10q�63   .+�5#        $ 
KeyVariant=�6*   $��Center=�5$   *   $��7q�5%   *   $��25��5&   *   $��25��5'   *   G� 5(      -   5        
 G�Name$
 PasswordBox��5)      $ Password��5*      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . $! Введите пароль��5,      $	��340��6K   5-      �� 5.      -   5        $
��Auth��5/          MaterialDesignFlatDarkButton#��[  50      $��
Войти��51      $��18(�52      $��10q�6   $
��Auto��55      $
��Auto��56      {�53      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�56      57      59      5:      