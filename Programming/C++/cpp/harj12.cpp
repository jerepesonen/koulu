/* Tekij�, Jere Pesonen
Harjoitus 12 (Palautus vko 43)

Tee ohjelma, joka kysyy k�ytt�j�lt� kokonaisluvun v�lilt� 1-9 ja
tulostaa vastauksen perusteella seuraavan kuvion (jos vastaus on 6):

1
22
333
4444
55555
666666

Jokainen numero tulee tulostaa toistorakenten avulla erikseen lauseella:
cout << rivinro;
*/
#include <iostream>
using namespace std;
int main()
{

	cout << "Teht�v� 12\n\n";
	int luku, luku1, lkm;
	luku1 = 1;
	lkm = luku1;

			cout << "Sy�t� kokonaisluku v�lilt� 1-9\n";
			cin >> luku;

				while (luku > 0)
				{
					while (lkm > 0)
					{
						cout << (luku1);
						lkm--;
					}
					cout << endl;

					luku1++;
					lkm = luku1;
					luku--;
				}
	system("pause");
}