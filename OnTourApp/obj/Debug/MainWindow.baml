   M S B A M L   `   `   `  ����D  @OnTourApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:OnTourApp	OnTourApp  5   	       OnTourApp.MainWindow   5      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   R NMahApps.Metro.IconPacks, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:OnTourApp     5   	     � Title$  OnTour - Login��5
   	   $	��423��6    $	��231��6,   $	��424��69   $	��300��6H   $	��424��6X   $	��300��6g   (  "MahApps.Metro.Controls.MetroWindow   TitleCharacterCasing$ Normal=�6w      TitlebarHeight$ 24��6�    � Icon$ img/OnTourLogo.png��6�   .��5      � ���	#FF3373F2$��5q�6"    � RowDefinitions 5   
   �� 5      $��0* �6   �� 5      $
��115* �6   �� 5      $	��20* �6   �� 5      $	��12* �6   �� 5      $	��20* �6   �� 5      $	��24* �6   �� 5      $��0* �6    � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      $	��20* �6   �� 5      $	��25* �6   �� 5      $	��82* �6   �� 5      $	��10* �6   �� 5      $
��153* �6   �� 5      $	��10* �6   �� 5      $	��81* �6   �� 5      $	��20* �6   �� 5      $��0* �6   .+�5!   
   �� -   5         ��Name$ 
txtUsuario��5!       �� TextWrapping$
 Wrap=�6&   $��5��6:   $��2��6J   $��Right=�6W   G� 5"   
   -   5         G�Name$ txtPassword��5"      $��5��6,   $��4��6<   $��Right=�6I   ,  &MahApps.Metro.IconPacks.PackIconModern  5$   
   E AControlzEx, Version=3.0.2.4, Culture=neutral, PublicKeyToken=null�  �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconModernKind, MahApps.Metro.IconPacks, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null]]	   Kind$
	 User=�6#   $
��Auto��6/   $
��Auto��6=   $��2��6J   $��2��6Z   $��Center=�6g   $��Center=�6�   $��Center=�6�   $��Center=�6�   
�������$��2q�6�     5%   
   $	 InterfacePassword=�6#   $��28��6<   $
��Auto��6H   $��2��6U   $��4��6e   $��Center=�6r   $��Center=�6�   $��Center=�6�   $��Center=�6�   
�������$��2,0.476,2,31.524q�6  $��2��6  �� 5'   
   $��Usuario:��6   $��3��6#   $��2��63   $��16(�6@   $��Center=�6N   $
��Bold"�6p   $��Calibri)�6�   $��2��6�   
�������6�   �� 5(   
   $��Contraseña:��6   $��3��6&   $��4��66   $��16(�6C   $��Center=�6Q   $
��Bold"�6s   $��Calibri)�6�   $��2��6�   
�������6�   �� 5*   
   $��1��6   $��1��6    $��img/OnTourLogo.png��6-   $��8��6I   
 J� OpacityMask
 �	#FF3373F26]   �� 5+   
   -   5         ��Name$ btnLogin��5+      $��Ingresar��6#   $��7��66   $��2��6F   $��3��6S   $��16(�6d   $
��Bold"�6r   $��Calibri)�6�   6�   5,      5-      