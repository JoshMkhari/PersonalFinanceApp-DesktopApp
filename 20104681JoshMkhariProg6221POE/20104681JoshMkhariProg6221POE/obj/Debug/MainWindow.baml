   M S B A M L   `   `   `  ����X  T20104681JoshMkhariProg6221POE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:_20104681JoshMkhariProg6221POE.MVVM.ViewModel-_20104681JoshMkhariProg6221POE.MVVM.ViewModel  5   	   O,clr-namespace:_20104681JoshMkhariProg6221POE_20104681JoshMkhariProg6221POE  5   	   /    )_20104681JoshMkhariProg6221POE.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Q	viewModel;clr-namespace:_20104681JoshMkhariProg6221POE.MVVM.ViewModel     5   	   >local,clr-namespace:_20104681JoshMkhariProg6221POE     5   	   $	��600��5	   	   $	��920��6     � WindowStyle$
  None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      A   ;_20104681JoshMkhariProg6221POE.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���	#FF1A173A �� CornerRadius$ 20��5      ._�5   
   �  � RowDefinitions 5      �� 5      $��40 �6    �� 5      $��75 �6    �� 5       � ColumnDefinitions 5      �� 5       $	��163 �6#   �� 5!      $��37 �6#   �� 5"      .+�5%      � -   5        ���#0F0F2D$��3��5&      ��5(      �� 5)       �� 
TargetType" �6   .�5*      ��  �� Property � ��	 �� Value$	 Fonts/#Dosis)�6C   �� 5+       �@�Cursor$
	 Hand��63   5,       5/      51      �� 52      $	��350��6   $	��300��6    $��Images/CoolLines.png��53      
 �� BitmapScalingMode$

 Fant=�54      $��Center=�55      $��Center=�56      $��2��57      $��0��58      $��-99,149,669,36q�59      $��3��5:      �� 5<      $	��350��6   $	��300��6    $��Images/CoolLines.png��5=      $

 Fant=�5>      $��Center=�5?      $��Center=�5@      $��2��5A      $��461,-45,-91,345q�6$   $��3��6=   �� 5C      -   5         ��Name$ MinimizeButton��5D      $��0��5F      $��2��5G      $��1��5H      $��
630,0,45,0q�5I      
������ 
������ .��5M      �� $��30��6   $��30��6#   $��Images/minimizeIcon.png��5N      $

 Fant=�5O      $��Center=�5P      $��Center=�5Q      ��5R      �� 5S      " ��6   .�5T      ��  � ��$	 Fonts/#Dosis)�6C   �� 5U       �@�Cursor$
	 Hand��63   5V      5X      �� 5[      -   5        $ CloseButton��5\      $��45��5^      $��40��5_      $��Center=�5`      $��Center=�5a      $��0��5b      $��2��5c      $��1��5d      $��	675,0,0,0q�5e      
������ 
������ .��5h      �� $��30��6   $��30��6#   $��Images/closeIcon.png��5i      $

 Fant=�5j      $��Center=�5k      $��Center=�5l      ��5m      �� 5n      " ��6   .�5o      ��  � ��$	 Fonts/#Dosis)�6C   �� 5p       �@�Cursor$
	 Hand��63   5q      5s      �� 5v      $	��120��6   $��80��6    $��Images/Logo.png��5w      $

 Fant=�5x      $��1��5y      $��
40,0,3,495q�6!   $��2��65   �� 5{      $��2��6   $��2��6&   .+�5|      	� -   5         	�Name$ 	HomeRadio��5}      $
��Home��5|      $��50��5~      
�������$��14(�5�      $
��Bold"�5�         MenuButtonTheme#��[  5�       d� 	IsChecked$
 TrueY�5�      $
��Home��5�   D   $��Fonts/#Dosis)�5�      ��5�      �� *UpdateViewCommand+5�      	� 5�      -   5        $ BudgetRadio��5�      $��Budget Planner��5�      $��50��5�      
�������$��14(�5�      $
��Bold"�5�      #��[  5�      $��BudgetPlanner��5�   D   $��Fonts/#Dosis)�5�      ��5�      �� *UpdateViewCommand+5�   8   5�      �� 5�      $��2��6   $��2��5�      $��10q�5�      ��5�      �� *SelectedViewModel+5�      �� 5�      $	��350��6   $	��300��6    $��Images/CoolLines.png��5�      $

 Fant=�5�      $��Center=�5�      $��Center=�5�      $��2��5�      $��304,-232,66,47q�6!   $��2��69   5�      5�      5�      