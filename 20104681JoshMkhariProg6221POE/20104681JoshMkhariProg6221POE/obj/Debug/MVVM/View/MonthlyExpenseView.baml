   M S B A M L   `   `   `  ����X  T20104681JoshMkhariProg6221POE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:_20104681JoshMkhariProg6221POE.MVVM.View(_20104681JoshMkhariProg6221POE.MVVM.View  5      m;clr-namespace:_20104681JoshMkhariProg6221POE.MVVM.ViewModel-_20104681JoshMkhariProg6221POE.MVVM.ViewModel  6S   A    ;_20104681JoshMkhariProg6221POE.MVVM.View.MonthlyExpenseView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:_20104681JoshMkhariProg6221POE.MVVM.View     5      Q	viewmodel;clr-namespace:_20104681JoshMkhariProg6221POE.MVVM.ViewModel     6S   
�������.��5
      �� .+�5   
   � .+�5      �� $	��800��6   $��13��5      ���#ffea00$	��Top=�5      $��-13,167,13,0q�6-   �� 5      $��13��6   $	��480��5      ���#ffea00$
��Left=�5      �� 5      $��13��6   $	��480��5      ���#ffea00$��Right=�5      �� 5      $(��"/Images/MonthlyExpenseseImages.png��5   %   $��Center=�5   %   $��Center=�5    %     �� BitmapScalingMode$
  Fant=�5!   %   $��	0,0,0,373q�5"   %   $	��800��68   $	��174��6D   $
��Fill=�6Q   �� 5%      $ ��Enter Gross Monthly Income��6   
���   �$��10(�5'   $   $��100,-150,10,0q�5(   $   $��Center=�5)   $   $��Fonts/#Dosis)�5*   $   ]� 5+      $��Center=�6   $��100,-90,400,0q�63   .+�5,      �� -   5         ��Name$ TGrossMonthlyIncome��5,      $	��Top=�6�    �� TextAlignment$
 Left=�6�   $	��200��6�   ��67   ��  �� ElementName$ GrossMonthlyIncome�� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5-      -   5         ��Name$ GrossMonthlyIncome��5-   x    � Maximum$ 10000000Q�6    �� TickPlacement$ BottomRight=�6,   	 �� TickFrequency$
	 1000Q�6H   
 �� IsSnapToTickEnabled
 .  � Cursor$
 Hand��6�   6�   5.      �� 50      $��Enter Estimated Tax��6   
���   �$��10(�52   $   $��100,-20,10,0q�53   $   $��Center=�54   $   $��Fonts/#Dosis)�55   $   ]� 56      $��Center=�6   $��100,40,400,0q�63   .+�57      �� -   5        $
 TTax��57      $	��Top=�6z   $
 Left=�6�   $	��200��6�   ��6(   �� $	 Tax��$ Value�$ PropertyChanged=�6�   �� 58      -   5        $	 Tax��58   �    � Minimum$ 0Q�6X   $ BottomRight=�6d   $		 100Q�6�   
 . $
 Hand��6�    6   �� $ GrossMonthlyIncome��$ Value�6�   59      �� 5;      $��Enter Groceries��6   
���   �$��10(�5=   $   $��100,100,10,0q�5>   $   $��Center=�5?   $   $��Fonts/#Dosis)�5@   $   ]� 5A      $��Center=�6   $��100,160,400,0q�63   .+�5B      �� -   5        $ 
TGroceries��5B      $	��Top=�6�   $
 Left=�6�   $	��200��6�   ��6.   �� $ 	Groceries��$ Value�$ PropertyChanged=�6�   �� 5C      -   5        $ 	Groceries��5C   �   $ 0Q�6X   $ BottomRight=�6d   $		 100Q�6�   
 . $
 Hand��6�    6   �� $ GrossMonthlyIncome��$ Value�6�   5D      �� 5F      $��Enter Water and Lights��6   
���   �$��10(�5H   $   $��100,220,10,0q�5I   $   $��Center=�5J   $   $��Fonts/#Dosis)�5K   $   ]� 5L      $��Center=�6   $��100,280,400,0q�63   .+�5M      �� -   5        $ TWaterL��5M      $	��Top=�6�   $
 Left=�6�   $	��200��6�   ��6+   �� $ WaterL��$ Value�$ PropertyChanged=�6�   �� 5N      -   5        $ WaterL��5N   �   $ 0Q�6X   $ BottomRight=�6d   $		 100Q�6�   
 . $
 Hand��6�    6   �� $ GrossMonthlyIncome��$ Value�6�   5O      �� 5Q      $��Enter Travel Costs��6   
���   �$��10(�5S   $   $��400,-155,10,0q�5T   $   $��Center=�5U   $   $��Fonts/#Dosis)�5V   $   ]� 5W      $��Center=�6   $��Right=�5X      $��0,-95,100,0q�5Y      .+�5Z      �� -	   5        $ TTravel��5Z      $	��Top=�6�   $
 Left=�6�   $	��200��6�   ��6+   �� $ Travel��$ Value�$ PropertyChanged=�6�   �� 5[      -
   5        $ Travel��5[   �   $ 0Q�6X   $ BottomRight=�6d   $		 100Q�6�   
 . $
 Hand��6�    6   �� $ GrossMonthlyIncome��$ Value�6�   5\      �� 5^      $$��Enter Cell phone and telephone��6   
���   �$��10(�5`   $   $��400,-35,10,0q�5a   $   $��Center=�5b   $   $��Fonts/#Dosis)�5c   $   ]� 5d      $��Center=�6   $��Right=�5e      $��
0,25,100,0q�5f      .+�5g      �� -   5        $ TCell��5g      $	��Top=�6|   $
 Left=�6�   $	��200��6�   ��6)   �� $
 Cell��$ Value�$ PropertyChanged=�6�   �� 5h      -   5        $
 Cell��5h   �   $ 0Q�6X   $ BottomRight=�6d   $		 100Q�6�   
 . $
 Hand��6�    6   �� $ GrossMonthlyIncome��$ Value�6�   5i      �� 5k      $��Enter Other Expenses��6   
���   �$��10(�5m   $   $��400,85,10,0q�5n   $   $��Center=�5o   $   $��Fonts/#Dosis)�5p   $   ]� 5q      $��Center=�6   $��Right=�5r      $��0,145,100,0q�5s      .+�5t      �� -   5        $ TOther��5t      $	��Top=�6~   $
 Left=�6�   $	��200��6�   ��6*   �� $ Other��$ Value�$ PropertyChanged=�6�   �� 5u      -   5        $ Other��5u   �   $ 0Q�6X   $ BottomRight=�6d   $		 100Q�6�   
 . $
 Hand��6�    6   �� $ GrossMonthlyIncome��$ Value�6�   5v      �� 5x      $%��/Images/MonthlyExpensesMenu.png��5y      $��right=�5z      $��Center=�5{      $��
0,420,0,67q�67   $
  Fant=�5|       J� RenderTransformOrigin$ 	0.6,1.235&�6C   $
��Fill=�6e   $	��338��6t   $��40��6�   5�      �� 5�   
   -   5         ��Name$ 
NextButton��5�      $��HomeLoan��5�   7   $
��Next��5�      
�������$��14(�5�      $��Medium"�5�      $��50��5�      $��20��5�      $��Right=�5�      $��0,-180,50,0q�5�      ��5�      �� *UpdateViewCommand+��5�      �� 5�       �� 
TargetType" ��6   .�5�      ��  �� Property � �� �� Value$ Fonts/#Dosis)�6?   �� 5�       � �� �#fa910963   �� 5�       �@�Cursor$
 Hand��6/   5�      5�      �� 5�   
   -   5        $ Reset��5�      $��Reset��5�      
�������$��14(�5�      $��Medium"�5�      $��50��5�      $��20��5�      $��Right=�5�      $��0,-180,250,0q�5�      ��5�      �� 5�      " ��6   .�5�      ��  � ��$ Fonts/#Dosis)�6?   �� 5�       � �� �#6ac28a63   �� 5�       �@�Cursor$
 Hand��6/   5�      5�      �� 5�   
   $��12��5�      ���#ffea00$��0,-160,335,0q�5�      5�      5�      