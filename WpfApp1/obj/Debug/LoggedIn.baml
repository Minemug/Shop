   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.LoggedIn   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          �Name$  	LoggedIn1��5   	    � Title$ LoggedIn��5   	   $	��450��6   $	��800��6'    � Icon$� �kisspng-computer-icons-portable-network-graphics-vector-gr-login-icon-png-single-sign-on-icon-539x539-p-5cf3251b86a5e2.2608025915594386195515.png��63    � 	Resources 5	         basketViewSource��%   &	        �� 5
   
   6   5      .��5      � ���	#FF24292E � DataContext# [  6"   .+�5   
   �� $��Dodaj produkt do koszyka��6   $
��Left=�63   $��	27,15,0,0q�6N   $	��Top=�6a   $	��220��6y   ���	#FF9DA5A9$��18(�6�   $��43��6�   �� 5   
   $��Koszyk��6   $
��Left=�6!   $��
403,28,0,0q�6<   $	��Top=�6P   $	��260��6h   ���	#FF9DA5A9$��18(�6�   $��43��6�   �� 5   
   -   5         ��Name$ ComboBox��5      $
��Left=�6%   $��	27,58,0,0q�6@   $	��Top=�6S   $	��220��6k   
���   ����	#FF24292E���	#FF9DA5A96�   �� 5   
   $��Ilość��6   $
��Left=�6    $��	27,85,0,0q�6;   $	��Top=�6N   $��69��6f   ���	#FF9DA5A9$��18(�6�   $��33��6�   �� 5   
   -   5         ��Name$ QuantityTextBox��5      $
��Left=�6+   $��33��6F   $��
126,85,0,0q�6R    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��120��6�   $��18(�6�   ���	#FF1B1D26���	#FF9DA5A96�   �� 5   
   -   5         ��Name$ AddToBasketButton��5      $��Dodaj��6,   $
��Left=�6<   $��125,123,0,0q�6W   $	��Top=�6l   $	��121��6�   $��31��6�   $��18(�6�   ���	#FF1B1D26���	#FF9DA5A96�   �� 5   
   -   5        	 ��Name$	 Passdata��5      $
��Left=�6&   $��
10,394,0,0q�6A   $
��Wrap=�6U   $��	TextBlock��6i   $	��Top=�6z   $	��126��6�   ���	#FF24292E6�   �� 5   
   -   5        $��Powrót do logowania��5      $
��Left=�6/   $��39��6J   $��
10,350,0,0q�6V   $	��Top=�6j   $	��180��6�   $��18(�6�   ���	#FF1B1D26���	#FF9DA5A96�   &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 basketDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��403,76,147,22q�6~      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6f   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        basketIDColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 	Basket ID��5   Z      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6m   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
BasketID+6m     5      -	   5        clientIDColumn��$ 	Client ID��5   Z   $ SizeToHeader 6m    6=   �� *
ClientID+6m     5      -
   5        productIDColumn��$ 
Product ID��5   \   $ SizeToHeader 6p    6>   �� *	ProductID+6p     5      -   5        quantityColumn��$ Quantity��5   Z   $ SizeToHeader 6l    6=   �� *
Quantity+6l   5      �� 5   
   $��Usuń produkt z koszyka��6   $
��Left=�61   $��
26,172,0,0q�6L   $	��Top=�6`   $	��220��6x   ���	#FF9DA5A9$��18(�6�   $��43��6�   �� 5   
   -   5        $ ComboBoxDelete��5      $
��Left=�6+   $��
27,215,0,0q�6F   $	��Top=�6Z   $	��220��6r   
���   ����	#FF24292E���	#FF9DA5A96�   �� 5   
   -   5        $ DeleteFromBasketButton��5      $��Usuń��61   $
��Left=�6@   $��126,260,0,0q�6[   $	��Top=�6p   $	��121��6�   $��31��6�   $��18(�6�   ���	#FF1B1D26���	#FF9DA5A96�   5!      5"      