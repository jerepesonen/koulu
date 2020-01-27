/* Tekij� Jere Pesonen
Harjoitus 18 (Palautus vko 46)
Tee ohjelma, joka kysyy viiden koiran nimet ja i�t.
Tiedot tallennetaan tietuetaulukkoon.
a) j�rjest� tiedot ik� -kent�n mukaan suuruusj�rjestykseen
(pienimm�st� suurimpaan). Ohjelma tulostaa lopuksi
jarjestetyn taulukon n�yt�lle.
b) j�rjest� tiedot nimi -kent�n mukaan aakkosj�rjestyksess�
Ohjelma tulostaa lopuksi jarjestetyn taulukon n�ytolle.

Lajittelu tulee toteuttaa siten, ett� se toimisi samoin
my�s 50 tai 5000 koiran tapauksessa.
*/
#include <iostream>
using namespace std;
#include <cstring> // esittelee str... funktiot
const int MAX_KOIRAT = 5;
struct koirat
{
	char nimi[30];
	int ika;
};
int main()

{
	int m = 0;
	int i = 0;
	koirat tiedot[MAX_KOIRAT];
	cout << "Teht�v� 18\n";
	cout << "Sy�t� 5:n koiran nimi ja ik�\n";

	while (m < MAX_KOIRAT)
	{
		cout << m + 1 << ". Koiran nimi: " << endl;
		cin.get(tiedot[m].nimi, 30);

		cout << m + 1 << ". Koiran ik�: " << endl;
		cin >> ws >> tiedot[m].ika;
		cin.get();
		m++;

	}
	while (i < (MAX_KOIRAT - 1))
	{
		int j = i + 1;
		while (j < MAX_KOIRAT)
		{
			if (strcmp(tiedot[i].nimi, tiedot[j].nimi) > 0) // kirja s. 121
			{
				koirat tmp = tiedot[i];
				tiedot[i] = tiedot[j];
				tiedot[j] = tmp;

			}
			i++;
			j++;
		}
		i++;
	}
	cout << "Koirien tiedot aakkosj�rjestyksess�\n\n";
	for (int m = 0; m < MAX_KOIRAT; m++)
	{
		cout << tiedot[m].nimi << " " << tiedot[m].ika << endl;
	}

	system("pause");
}