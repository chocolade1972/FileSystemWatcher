   M S B A M L   `   `   `  ����F  BWatcher_WPF, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Watcher_WPFWatcher_WPF  5   	       Watcher_WPF.FilterWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Watcher_WPF     5   	     � Title$   ��5   	   $	��300��6   $	��350��6    � 
ResizeMode$ NoResize=�6+    � Topmost .  � WindowStartupLocation$ CenterOwner=�6P   .��5	      � .+�5
   
   �� -   5        $��OK��5
      $��Right=�6   $��0,0,9.6,10.4q�6:   $��Bottom=�6P   $��75��6k   6v   �� 5   
   -   5        $��Cancel��5      $��Right=�6"   $��0,0,89.6,10.4q�6>   $��Bottom=�6U   $��75��6p   6{   �� 5   
   $��NotifyFilter��6   $��	25,25,0,0q�6(   $
��Left=�6;   $	��Top=�6V   $��18(�6n   �� 5   
   -   5         ��Name$ CheckBox_Size��5      $
��Size��6*   $
��Left=�69   $��	35,65,0,0q�6T   $	��Top=�6g   �� 5   
   -   5        $ CheckBox_FileName��5      $��FileName��6.   $
��Left=�6A   $��
100,65,0,0q�6\   $	��Top=�6p   �� 5   
   -   5        $ CheckBox_DirectoryName��5      $��DirectoryName��63   $
��Left=�6K   $��
190,65,0,0q�6f   $	��Top=�6z   �� 5   
   $��
25,115,0,0q�6   $
��Left=�6(   $	��Top=�6C   $��18(�6[   $��Filter��6i   �� 5   
   -   5         ��Name$ TextBox_Filter��5      $
��Left=�6*   $��23��6E   $��
35,151,0,0q�6Q    �� TextWrapping$ NoWrap=�6e   $	��Top=�6{   $	��261��6�   $��Center=�6�   5      5      