   M S B A M L   `   `   `  ����R  NContactsMangementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ContactsMangementSystemContactsMangementSystem  5   	   (    "ContactsMangementSystem.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:ContactsMangementSystem     5   	     � Title$   Contacts Management System��5   	   $��570.58��6,   $	��800��6<   
�������.��5	      � .+�5
   
   �� -   5         ��Name$ textBox��5
      $
��Left=�6#   $��23��6>   $��
559,25,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6s   $	��137��6�   �� 5   
   -   5         ��Name$ button��5      $��Search Contact��6!   $
��Left=�6:   $	��Top=�6U   $��43��6m   $��
715,27,0,0q�6x   6�   �� 5   
   -   5         ��Name$ listView��5      $
��Left=�6%   $	��458��6@   
�������$��
396,69,0,0q�6d   $	��Top=�6x   $	��386��6�   $ �� IsSynchronizedWithCurrentItem$ FalseY�6�    �� View 5      �� 5      P�5      �� 5      $��	FirstName��6T    �� Width$	 120��6g    �� DisplayMemberBinding 6)   �� *	FirstName+6g   �� 5      $��LastName��6S   $	 120��6e    6)   �� *
LastName+6e   �� 5      $��DateofBirth��6q   $	 120��6�    6)   �� *DateofBirth+	 �� StringFormat$	 
dd-MM-yyyy��6�   5      5      �� 5   
   -   5        
 ��Name$
 groupBox��5      $��CreateContact��6%   $��	UltraBold"�6<   $
��Left=�6S   $	��500��6n   $��	15,25,0,0q�6{   $	��Top=�6�   $	��365��6�   .��5      �� $
��Left=�6   $	��496��64   $��-5,16,-6,-85q�6A   $	��Top=�6W   $	��364��6o   .+�5      �� -   5         ��Name$ label��5      $��First Name :   *��6'   
���  ��$
��Bold"�6S   $��12(�6e   �� 5      -   5        $ fnametextbox��5      $��23��60   $
 Wrap=�6<   �� 5      -   5        $ lname��5      $��Last Name :   *��6'   
���  ��$
��Bold"�6R   $��12(�6d   �� 5      -   5        $ lnametextbox��5      $��23��60   $
 Wrap=�6<   �� 5      -	   5        $ DateofBirth��5      $��Date of Birth :��6-   $
��Bold"�6G   $��12(�6Y   (  "System.Windows.Controls.DatePicker  5      -
   5          Name$ 
datePicker��5      �� 5      -   5        $ EmailId��5      $��	EmailId :��6)   $
��Bold"�6=   $��12(�6O   �� 5       -   5        $ emailid��5       $��23��6+   $
 Wrap=�67   �� 5!      -   5        $ AlternateEmailId��5!      $��Alternate EmailId :��62   $
��Bold"�6P   $��12(�6b   �� 5"      -   5        $ alternateemailid��5"      $��23��64   $
 Wrap=�6@   �� 5#      -   5        $ Mobileno��5#      $��Mobile Number :��6*   $
��Bold"�6D   $��12(�6V   �� 5$      -   5        $ mobileno��5$      $��23��6,   $
 Wrap=�68   �� 5%      -   5        $ AlternateMobileno��5%      $��Alternate Mobile Number :��63   $
��Bold"�6W   $��12(�6i   �� 5&      -   5        $ alternatemobileno��5&      $��23��65   $
 Wrap=�6A   5'      5(      �� 5)   
   -   5        $ button1��5)      $��Create Contact��6"   $
��Bold"�6;   $
��Left=�6M   $��231,434,0,0q�6h   $	��Top=�6}   $	��108��6�   $��34��6�   6�   �� 5*   
   -   5        $ label1��5*      $
��Left=�6    $��
447,38,0,0q�6;   $	��Top=�6O   �� 5+   
   -   5         ��Name$ contactname��5+      $
��Left=�6)   $��
434,29,0,0q�6D   $
��Wrap=�6X   $��Contact Name :��6l   $
��Bold"�6�   $��12(�6�   $	��Top=�6�   $��19��6�   $	��102��6�   �� 5,   
   -   5        $ button1_Copy��5,      $��Reset��6'   $
��Bold"�67   $
��Left=�6I   $��
58,434,0,0q�6d   $	��Top=�6x   $	��108��6�   $��34��6�   6�   5-      5.      