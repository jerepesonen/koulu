/* Tekij�, Jere Pesonen
Harjoitus 11 (Palautus vko 43)
Muuta teht�v�n 9 laskin-ohjelmaa niin, etta valikko nayttaa
seuraavalta:

VALIKKO
0. Lopetus
1. Summa
2. Erotus
3. Tulo
4. Osamaara
5. Jakojaannos
6. Syota uudet luvut laskemista varten

Laskimella on siis mahdollista k�sitell�
useita lukupareja k�ytt�j�n toiveiden
mukaisesti. Mita tapahtuu, jos luku2 on 0?
HUOM! goto -lauseen k�ytt� on KIELLETTY!!!!
*/
#include <iostream>
using namespace std;
int main()
{
	cout << "Teht�v� 11\n\n";
	int luku1, luku2, valinta;
	valinta = 6;
		while (valinta == 6)
		{
			cout << "Anna kaksi kokonaislukua" << endl;
			cin >> luku1 >> luku2;


			cout << "\nValikko\n";
			cout << "1. Summa\n";
			cout << "2. Erotus\n";
			cout << "3. Tulo\n";
			cout << "4. Osam��r�\n";
			cout << "5. Jakoj��nn�s\n";
			cout << "6. Sy�t� uudet luvut\n";
			cin >> ws >> valinta;

			switch (valinta)
			{
			case 1: cout << (luku1 + luku2);
				break;
			case 2: cout << (luku1 - luku2);
				break;
			case 3: cout << (luku1 * luku2);
				break;
			case 4: cout << (luku1 / luku2);
				break;
			case 5: cout << (luku1 % luku2);
				break;
			case 6: cout << endl;
				break;
			}
		}
		cout << endl;
	system("pause");
	return 0;
}