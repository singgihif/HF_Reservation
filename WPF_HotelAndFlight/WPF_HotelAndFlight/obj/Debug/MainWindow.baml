   M S B A M L   `   `   `  ����M  IWPF_HotelAndFlight, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_HotelAndFlightWPF_HotelAndFlight  5   	   #    WPF_HotelAndFlight.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_HotelAndFlight     5   	     � Title$  
Menu Utama��5   	   $	��450��6   $	��550��6)   .��5	      � $��0,0,-6.4,0.4q�6    � ColumnDefinitions 5
   
   �� 5      $
��191* �6   �� 5      $
��309* �6   �� 5      $��0* �6   �� 5      $��0* �6   �� 5      $��0* �6    J� OpacityMask 5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FF961F1F��6   $ 1Q�61   5      .+�5   
   �� $��0,102,10,-0.4q�6   
���   �$	��538��6:   $��Center=�6F   $��2��6c   $	��317��6w   $	��Top=�6�   ��5      �� 5      5      �� 5   
   -   5         ��Name$ label��5      $"��Reservasi
Pesawat Dan Hotel��6   $	��Top=�6N   $��Stencil)�6f   $��2q�6{    J� 	AllowDrop . $��36(�6�   	 J� RenderTransformOrigin$	 0.351,0.026&�6�   $	��538��6�   $��95��6�   $��Center=�6�   $��Center=�6  $��0,0,10,0q�6+  $��2��6=  
 � IsSharedSizeScope
 . {�.  ���	#FFF4F8F9��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FFEA5A2F��6#   $ 0Q�65   5        J� Effect 5"      3  -System.Windows.Media.Effects.DropShadowEffect  5#         Color$ 	#FF1A1CC7��6#      ShadowDepth$ 6Q�65   5%      �� 5&   
   -   5         ��Name$ login��5&      $��LOGIN��6    $��Right=�60   $��0,337,251,0q�6L   $	��Top=�6a   $	��140��6y   $��50��6�   $	 0.435,3.508&�6�   $��18.667(�6�   $
��Bold"�6�   ���	#FF113871$��2��6  �� 5'   
   -   5        $ cancel��5'      $
��EXIT��6!   $��
99,337,0,0q�60   $	��Top=�6D   $	��140��6\   $��50��6h   $
��Left=�6t   $	 0.274,0.504&�6�   $��18.667(�6�   $
��Bold"�6�   ���	#FFDDDDDD���	#FFEA3333$��1��6   5(      �� 5)      $ 0.5,1&�6&   $ 0.5,0&�67   .��5*      � $ Black��6#   $ 0Q�61   � 5+      $ 	#FF19B426��6#   $ 1Q�65   5,      5.      �� 5/   
   -   5        $ label1��5/      $��LOGIN��6    $��Center=�60   $��149,102,149,0q�6M   $	��Top=�6d   $��30(�6|   
���   �$��Lucida Bright)�6�   $
��Bold"�6�   $��40��6�   $	��200��6�   $��2��6�   $��Center=�6�   �� 50   
   -   5         ��Name$ usernamebox��50      $
��Left=�6'   $��38��6B   $��174,161,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��291��6�   $��29(�6�   $
��Left=�6�    � ToolTip$ Username��6�   $��
2147483646��6�   
 � Tag$  ��6�    � Cursor$  ��6�    �� IsReadOnlyCaretVisible . $��2��6#  G� 51   
   -   5         G�Name$ passwordBox��51      $
��Left=�6+   $��174,218,0,0q�6F   $	��Top=�6[   $	��291��6s   $��37��6   $ Password��6�   $��29(�6�   $
��Left=�6�   $��2��6�   �� 52   
   -   5        $ label2��52      $��Username��6    $
��Left=�63   $��-11,161,0,0q�6N   $	��Top=�6c   $��Mongolian Baiti)�6{   $��21.333(�6�   $��40��6�   $	��210��6�   $��Center=�6�   
���   �$
��Bold"�6�   �� 53   
   -   5        $ label2_Copy��53      $��Password��6%   $
��Left=�68   $��-11,223,0,0q�6S   $	��Top=�6h   $��Mongolian Baiti)�6�   $��21.333(�6�   $��32��6�   $	��210��6�   $��Center=�6�   
���   �$
��Bold"�6�   54      55      