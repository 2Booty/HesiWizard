   M S B A M L   `   `   `  ���� F  BHesi Wizard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Hesi_WizardHesi_Wizard  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35nKclr-namespace:System.Windows.Media.Animation;assembly=PresentationFrameworkSystem.Windows.Media.Animation "    Hesi_Wizard._1_Click_Install   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:Hesi_Wizard     _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  XEasingKclr-namespace:System.Windows.Media.Animation;assembly=PresentationFramework  A =Wpf.Ui, Version=2.0.3.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  -     � Title$  Hesi Wizard��$	��440��$	��600��   MaterialDesignBody#���    � AllowsTransparency .  � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�$y�Visible=�  MaterialDesignShadowDepth3 J� Effect# �   J� SnapsToDevicePixels .  � 
ResizeMode$ 	CanResize=� � Icon$, &/hesi-wizard-website-favicon-color.png����Z�  � Triggers :� 	 :� RoutedEvent$	 FrameworkElement.Loaded��.[��� .���� .��W� 
 �� TargetProperty$
 Width� W� From$	 144X�	 W� To$	 600X� g� Duration$ 0:0:1D� W� EasingFunction 2  ,System.Windows.Media.Animation.QuadraticEase  7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode$ 	EaseInOut=�.��#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q����	#FF303030$��25q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�.��� -    �Name$ mainGrid������  �� ImageSource$' !/neon-lights-jabvk7ta2tu43041.png�� j� Stretch$ UniformToFill=� j� TileMode$
 None=� J� OpacityMask ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black��� $ White�� � Offset$ 1Q� � ColumnDefinitions �� $��0 ��� $	��550 ��� $��0* �.+�  -     Name$ 
Top_G_Copy��$
��Left=�$	��Top=�$	��165��$	��208��$��1��$��
322,18,0,0q� 3  -System.Windows.Media.Effects.DropShadowEffect  .��� .+��� -    ��Name$ Sol_Install��$��Sol Install����.  $��	0,128,0,0q�$��Normal&�$��14(�$��Roboto)�$��28��$	��Top=�$��Center=�$	��194��   ����  �� Color$ Black�� �� Opacity$
 0.35Q����� $ 	#FFFFDE00��$
 0.75Q�� -     �Name$  ProgressBar��$��5��$��Bottom=�$��Stretch=�! � Minimum$! 0Q�" � Maximum$	" 100Q�# � Value$# 0Q�$y�	Collapsed=�  -   $ C1��$
��Left=�$	��Top=�$	��180��$	��200��$��1��$��115,193,0,0q�   .���� -   $ ��Name$$ image2��$
��Left=�$	��104��$��9,20,0,0q�$	��Top=�$	��180��$��/shutoko.webp��% J� RenderTransformOrigin$% 0.482,0.497&�   �� -   $ CM_Install_Copy��$��Install SRP��$��2��$
��Left=�$��122,336,0,0q�$	��Top=�$	��186��$��28����.  ���	#FF4E3B3B$��Roboto)����� $ 	#FF429A30��$ 1Q�   �� $��Center=�$��Center=�$	��300��$��0��$��1��  -	   $ Top_G��$
��Left=�$	��Top=�$	��165��$	��200��$��1��$��
115,18,0,0q�   .���� -
   $$ image��$��Center=�$��84��$��0,24,0,0q�$	��Top=�$��78��$��/CM.png��  -   $ PCard��$��2��$
��Left=�$��
96,314,0,0q�$	��Top=�$��44��$��0�����	#FF2D2D2D   .���� -   $ Pushin_Pee_Install��$��Install��$��Center=�$��Center=�$��70��$��28����.       -   $ GCard��$��2��$
��Left=�$��
96,216,0,0q�$	��Top=�$��44��$��0�����	#FF2D2D2D   .���� -   $ Goosy_Woosy_Install��$��Install��$��Center=�$��Center=�$��70��$��28����.  & �� 	ClickMode$& Release=�   �� -   $ 
CM_Install��$��Content Manager Install��$��2��$
��Left=�$��122,145,0,0q�$	��Top=�$	��186��$��28����.  $��Roboto)����� $ Black��$
 0.35Q����� $ 	#FFF32B21��$	 0.5Q�     -   $ TGACard��$��2��$
��Left=�$��	96,52,0,0q�$	��Top=�$��44��$��0�����	#FF2D2D2D   .���� -   $ TGA_Install��$��Install��$��Center=�$��Center=�$��70��$��28����.       -   $ NHCard��$��2��$
��Left=�$��
96,123,0,0q�$	��Top=�$��44��$��0�����	#FF2D2D2D   .���� -   $ No_Hezzer_Install��$��Install��$��Center=�$��Center=�$��70��$��28����.  $& Release=�     $��2��$
��Left=�$��Center=�$	��390��$��96��   �� -   $$ NHImg��$��2��$
��Left=�$��62��$��
14,112,0,0q�$	��Top=�$��67��$��/PP.png��   �� -   $$ TGAImg��$��2��$
��Left=�$��84��$��	11,29,0,0q�$	��Top=�$��75��$��/TGA.png�� .    �� -   $$ GoosyWoosyImg��$��2��$
��Left=�$��62��$��
14,206,0,0q�$	��Top=�$��67��$��/GoosyWoosy.png��$% 0.505,0.516&�   �� -   $$ 	PeePeeImg��$��2��$
��Left=�$��62��$��
15,305,0,0q�$	��Top=�$��62��$%��/channels4_profile-modified.png��$% 0.521,0.559&�   �� -   $ TGAButt��$��2��$
��Left=�$��	14,50,0,0q�$	��Top=�$��68��$��49��' J� Opacity$' 0Q����� $ 	#FF2196F3��$ 0Q����� $ White��$ 0Q��� -   $ NHButt��$��2��$
��Left=�$��
16,114,0,0q�$	��Top=�$��60��$��62��$' 0Q�$% 0.541,0.917&����� $ 	#FF2196F3��$ 0Q����� $ White��$ 0Q��� -   $ GoosyWoosyButt��$��2��$
��Left=�$��
11,204,0,0q�$	��Top=�$��68��$��68��$' 0Q����� $ 	#FF2196F3��$ 0Q����� $ White��$ 0Q��� -   $$ image1��$��2��$
��Left=�$��84��$��
387,42,0,0q�$	��Top=�$��78��$��/SOL.png��  -   $ C1_Copy��$
��Left=�$	��Top=�$	��180��$	��208��$��1��$��322,193,0,0q�   .���� -   $$ image2_Copy��$
��Left=�$��68��$��	68,38,0,0q�$	��Top=�$��69��$��/discord_icon_130958.ico��$% 0.482,0.497&�   �� -   $ CM_Install_Copy1��$��Discord��$��2��$
��Left=�$��329,336,0,0q�$	��Top=�$	��194��$��28����.  ���	#FF4E3B3B$��Roboto)����� $ 	#FF738ADB��$ 1Q�     $��2��$
��Left=�$	��Top=�$��35��$��96��$��0,2,0,0q�   �� -   $
$ exit��$��2��$��-1,3,516,357q�$)��#/power-button-icon-8345-Windows.ico��( � Cursor$
( Hand��$% 	0.571,0.5&�   �� -    $��2��$��60,3,458,357q�$��20��$��20��$&�� /settings-icon-14972-Windows.ico�� �	#FF424242$
( Hand��     -!   $ settings��$
��Left=�$��Center=�$	��370��$	��417��$��1��$��	115,0,0,0q�$y�Hidden=�   .��  Wpf.Ui.Controls.Button  -"   )  Name$) 	repairbtn��$��Repair��$��18,188,300,160q�$% 0.515,-0.136&����	#FF424242$y�Visible=�   �� -#   $$ Hesilogo��$��2��$"��/logo-no-backgroundwhite.png��$��184,19,85,301q�$y�Hidden=�  -$   $) 	browsbttn��$��Browse��$��2��$��133,137,318,232q����	#FF424242* � 
InputScope$* Default��$y�Hidden=�����      $��2��$��Button��$
��Left=�$��255,283,0,0q�$	��Top=�$��0���� -%   + ��Name$+ cmpath��$)��#If CM already installed (Give path)��$��2��$��131,108,231,260q�$y�Hidden=��� -&   $+ 	repairlbl��$��Repair game to defaults��$��2��$��131,172,261,187q�$y�Hidden=�  -'   $
) chkP��$��
Check path��$��2��$��133,227,318,141q�$��99��$��22�����	#FF424242$y�Hidden=�     -(   $) uldimg��$��Upload image��$��2��$��376,137,74,232q�$��99��$��21�����	#FF424242$y�Hidden=�   �� -)   $+ lblBrnd��$��Custom Backround��$��2��$��373,111,9,252q�