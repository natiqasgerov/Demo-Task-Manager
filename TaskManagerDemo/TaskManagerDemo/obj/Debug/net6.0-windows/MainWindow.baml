   M S B A M L   `   `   `  ????J  FTaskManagerDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:TaskManagerDemoTaskManagerDemo  5   	        TaskManagerDemo.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:TaskManagerDemo     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     ? Title$  Demo Task Manager??5	   	   $	??550??6#   $	??700??60    ? 
ResizeMode$ CanMinimize=?6<    ? Icon$I Chttps://www.shareicon.net/data/2015/07/27/75978_manager_256x256.png??5
   	   .??5      ? .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ process_datagrid??5   <   
???   ?$??1q?6'   $??Visible=?6V   $
??auto??6?   $??23,23,92,112q?6?   ??6?   ?? *MyProcesses+   RowStyle 5      ?? 5       ?? 
TargetType)  #System.Windows.Controls.DataGridRow"  6    ?? Triggers 5      P? 5       P? Property ?@ 
IsSelected P? Value$
 True??68   . ?5      ?? 	 ?? Property	 ? ??
 ?? Value

 ???d?6;   ?? 5      	 ? ??

 ?????6;   5      5      5      ?? 5   
   -   5         ??Name$ count_textblock??5      $
??auto??6-   $
??auto??6;   $??18(?6I   $
??Left=?6W   $??100,450,0,0q?6r   $
??Wrap=?6?   $	??Top=?6?   ?? 5   
   -   5        $??run_btn??5   3   $	??120??6'   $??Run new task??6B   $??14(?6Y   $??Bottom=?6g   $??Right=?6?   $??	0,0,40,38q?6?   ?? 5   
   -   5        $??end_btn??5      $??End task??6    $??90??63   $??14(?6T   $??Right=?6b   $??Bottom=?6~   $??
0,0,180,38q?6?   ?? 5   
   -   5        $??add_btn??5      $??14(?5       $??Bottom=?5!      $??Right=?6(   $??Add Block List??5"      $??
0,0,290,38q?6&   ?? 5$   
   $??	Threads :??6   $??18(?6$   $
??Left=?62   $??
20,445,0,0q?6M   $	??Top=?6a   5%      5&      