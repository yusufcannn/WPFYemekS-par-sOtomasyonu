   M S B A M L   `   `   `  ����P  LCarServıceOtomatıon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CarServıceOtomatıonCarServıceOtomatıon  5   	       FoodOtomatıon.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:CarServıceOtomatıon     5   	     � Title$  
MainWindow��5
   	   $	��490��6   $	��800��6)   ���	#FFD3A62E.��5      � -   5        $	��grd��5      $��	0,0,0,244q�6   .+�5   
   �� -   5        $
��Left=�5      $	��232��60   $��
0,10,0,-27q�6=   $	��Top=�6Q   $	��770��6i   .+�5      �� $ ��Yemek Sipariş Uygulaması��6   $��10,10,10,10q�69   $��71��6O   .��5      ]� $��Center=�6   $��	10,0,10,0q�67   .+�5      �� .��6   " Sipariş Adına Göre Filtreleme6;   �� 5      -   5        $��txtAra��5      $��30��6-    �� TextWrapping$
 Wrap=�69   $	��330��6N   6Z   5      5      &   System.Windows.Controls.DataGrid  5      -   5        $��dtgDatabase��5      $��	10,0,10,0q�6*      SelectionMode$ Single=�6=      AutoGenerateColumns .     AlternatingRowBackground �	#FFD3A62E$	��140��6�    �� AlternationCount$ 0��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ SıraNo��6@      
IsReadOnly . 	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 150 6b   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6)   �� *ID+6b     5       $ 
SiparişNo��6G   $		 155 6Z   
 6)   �� *	SiparisNo+6Z     5!      $ SiparişTutarı��6K   $		 155 6b   
 6)   �� *SiparisTutarı+6b     5"      $ SiparişAdresi��6K   $		 175 6b   
 6)   �� *SiparisAdresi+6b     5#      $ Sipariş��6E   $		 155 6V   
 6)   �� *	Siparis+6V   5&      5+      �� 5,   
   $
��Left=�6   $
��Wrap=�6/   $��
SiparişNo��6C   $	��Top=�6T   $��555,303,0,-123q�6l   $��35��6�    J� RenderTransformOrigin$ 8.401,3.862&�6�   $��76��6�   �� 5-   
   $
��Left=�6   $
��Wrap=�6/   $��SiparişTutarı��6C   $	��Top=�6X   $��236,329,0,-147q�6p   $��33��6�   $ 4.06,3.1&�6�   $��77��6�   �� 5.   
   $
��Left=�6   $
��Wrap=�6/   $��SiparişAdresi��6C   $	��Top=�6X   $��236,273,0,-94q�6p   $��36��6�   $ -2.12,3.525&�6�   $	��111��6�   �� 5/   
   $
��Left=�6   $
��Wrap=�6/   $��Sipariş��6C   $	��Top=�6R   $��16,269,0,-87q�6j   $��33��6�   $ -1.031,0.677&�6�   $��64��6�   �� 50   
   -   5        $��txtSiparisAdres��50   -   $
��Left=�6   $��23��6D   $
 Wrap=�6P   $	��Top=�6�   $	��120��6�   $ 
0.973,3.26&�6�   $��375,269,0,-77q�6�   ��6d   �� *SiparisAdresi+6�   �� 51   
   -   5        $��
txtSiparis��51   .   $
��Left=�6   $��23��6@   $
 Wrap=�6L   $	��Top=�6y   $	��120��6�   $ 
0.973,3.26&�6�   $��80,273,0,-81q�6�   ��6`   �� *	Siparis+6�   �� 52   
   -   5        $��txtSiparisTutari��52   .   $
��Left=�6   $��23��6F   $
 Wrap=�6R   $	��Top=�6�   $	��120��6�   $ 
0.973,3.26&�6�   $��375,325,0,-133q�6�   ��6f   �� *SiparisTutarı+6�   �� 53   
   -   5        $��txtSiparisNo��53   .   $
��Left=�6   $��23��6B   $
 Wrap=�6N   $	��Top=�6}   $	��120��6�   $ 
0.973,3.26&�6�   $��650,303,0,-111q�6�   ��6b   �� *	SiparisNo+6�   �� 54   
   -	   5        $��txtID��54   .   $
��Left=�6   $��23��6;   $
 Wrap=�6G   $	��Top=�6o   $	��120��6�   $ 
0.973,3.26&�6�   $��80,329,0,-137q�6�   ��6[   �� *ID+6�   �� 55   
   -
   5        $��btEkle��55      $
��Ekle��6!   $
��Left=�60   $	��Top=�6K   $��86��6c   $��125,370,0,-213q�6n   $��58��6�   6�   �� 56   
   -   5        $��	btTemizle��56      $��Temizle��6#   $
��Left=�65   $	��Top=�6P   $��86��6h   $��236,370,0,-213q�6s   $��58��6�   �� 57   
   -   5        $��
btGuncelle��57      $��	Güncelle��6$   $
��Left=�67   $	��Top=�6R   $��86��6j   $��363,370,0,-213q�6u   $��58��6�   6�   �� 58   
   -   5        $��btSil��58      $	��Sil��6   $
��Left=�6-   $	��Top=�6I   $��86��6a   $��491,370,0,-213q�6l   $��58��6�   6�   �� 5:   
   $
��Left=�6   $
��Wrap=�6/   $��ID��6C   $	��Top=�6M   $��16,329,0,-147q�6e   $��33��6|   $ -1.031,0.677&�6�   $��64��6�   5?      5@      