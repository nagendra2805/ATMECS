   M S B A M L   `   `   `  ����R  NContactsMangementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ContactsMangementSystemContactsMangementSystem  5   	   +    %ContactsMangementSystem.UpdateContact   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:ContactsMangementSystem     5   	     � Title$  UpdateContact��5   	   $	��487��6   $	��553��6,   
�������.��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $��Contact Updation Window��6   $��22(�6A   
��� ���$
��Bold"�6c   $
��Left=�6u   $��
128,10,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        $ fname��5      $��First Name :��6   $��14(�66   $
��Bold"�6D   $
��Left=�6V   $��	29,75,0,0q�6q   $	��Top=�6�   �� 5   
   -   5         ��Name$ FName��5      ${�False��6!   $
��Left=�63   $��
222,82,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��182��6�   $y�Visible=�6�   �� 5   
   -   5        $ lname��5      $��Last Name :��6   $��14(�65   $
��Bold"�6C   $
��Left=�6U   $��
29,110,0,0q�6p   $	��Top=�6�   �� 5   
   -   5        $ LName��5      ${�False��6!   $
��Left=�63   $��222,118,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��182��6�   �� 5   
   -   5        $	 DOB��5      $��Date of Birth :��6   $��14(�67   $
��Bold"�6E   $
��Left=�6W   $��
29,144,0,0q�6r   $	��Top=�6�   �� 5   
   -   5        $	 dob��5      $
��Left=�6   $��222,151,0,0q�6:   $
 Wrap=�6O   $	��Top=�6c   $	��182��6{   �� 5   
   -   5        $ EmailId��5      $��
Email ID :��6!   $��14(�66   $
��Bold"�6D   $
��Left=�6V   $��
29,179,0,0q�6q   $	��Top=�6�   �� 5   
   -	   5        $ emailid��5      $
��Left=�6#   $��222,187,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��183��6   �� 5   
   -
   5        $ alternateEmailId��5      $
��Left=�6,   $��222,219,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $	��183��6�   �� 5   
   -   5        $ mobileno��5      $
��Left=�6$   $��222,252,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��183��6�   �� 5   
   -   5        $ Alternateemaild��5      $��Alternate Email ID :��6)   $��14(�6H   $
��Bold"�6V   $
��Left=�6h   $��
29,212,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        $ Alternatemobileno��5      $��Alternate Mobile Number:��6+   $��14(�6N   $
��Bold"�6\   $
��Left=�6n   $��
29,278,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        $ Mobileno��5      $��Mobile Number:��6"   $��14(�6;   $
��Bold"�6I   $
��Left=�6[   $��
29,244,0,0q�6v   $	��Top=�6�   �� 5   
   -   5        $ alternatemobileno��5      $
��Left=�6-   $��222,286,0,0q�6H   $
 Wrap=�6]   $	��Top=�6q   $	��187��6�   �� 5   
   -   5         ��Name$ button��5      $��Update Contact��6!   $
��Bold"�6:   $
��Left=�6L   $��166,341,0,0q�6g   $	��Top=�6|   $	��119��6�   $��27��6�   6�   5      5      