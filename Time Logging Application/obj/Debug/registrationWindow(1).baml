   M S B A M L   `   `   `  ����S  OTime Logging Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Time_Logging_ApplicationTime_Logging_Application  5   	   1    +Time_Logging_Application.registrationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Time_Logging_Application     5   	     � Title$  
UserWindow��5   	   $	��500��6   $	��875��6)    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	   
������� � AllowsTransparency . .��5      ��  �� CornerRadius$ 10��5      $��1q�5      ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #1e2e29��6    � Offset$ 0Q�60   � 5      $ #13442f��6   $
 0.75Q�60   � 5      $ #075d37��6   $ 1Q�60   5      ._�5   
   � 	 � ColumnDefinitions	 5      �� 5      $
��419* �6#   �� 5      $	��27* �6#   �� 5      $
��111* �6#   �� 5      $
��243* �6#   .+�5       �� $��Employee ID:��6   $
��Left=�6+   $��	66,38,0,0q�6F   $	��Top=�6Y   
 J� RenderTransformOrigin$
 -3.777,-0.961&�6q   �� 5!      -   5         ��Name$ textBox_employeeID��5!      $��Center=�62   $��0,42,0,0q�6O    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5"      $��Confirm Password:��6   $
��Left=�60   $��
38,160,0,0q�6K   $	��Top=�6_   $
 -3.777,-0.961&�6w   �� 5#      $��	Password:��6   $
��Left=�6(   $��
83,129,0,0q�6C   $	��Top=�6W   $
 -3.777,-0.961&�6o   �� 5$      $��	Username:��6   $
��Left=�6(   $��	79,98,0,0q�6C   $	��Top=�6V   $
 -3.777,-0.961&�6n   �� 5%      -   5        $ textBox_completeName��5%      $��Center=�64   $��0,71,0,0q�6Q   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5&      -   5        $ textBox_username��5&      $��Center=�60   $��	0,102,0,0q�6M   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   G� 5'      -   5         G�Name$ 	passwordd��5'      $��Center=�6-   $��	0,133,0,0q�6J   $	��Top=�6]   $	��120��6u   G� 5(      -   5        $ confirmpassword��5(      $��Center=�63   $��	0,164,0,0q�6P   $	��Top=�6c   $	��120��6{   $
 0.342,0.522&�6�   �� 5)      $��Complete Name:��6   $
��Left=�6-   $��	47,67,0,0q�6H   $	��Top=�6[   $
 -3.777,-0.961&�6s   �� 5*      -   5         ��Name$ button_addNewUserReg��5*      $
��Left=�63   $��35��6N   $��
14,415,0,0q�6Z   $	��Top=�6n   $	��118��6�   ���	#FFB7B7B7$��3��6�   .��5+      �� $��Register��6   ���	#FFDDDDDD6,   5,      �� 5-      -   5        $ button_registerBack��5-      $
��Left=�62   $��35��6M   $��111,415,0,0q�6Y   $	��Top=�6n   $	��118��6�   ���	#FFB7B7B7.��5.      �� $
��Back��6   ���	#FFDDDDDD6(   5/      51      52      53      