/* Tekijä Jere Pesonen
Harjoitus 18 (Palautus vko 46)
Tee ohjelma, joka kysyy viiden koiran nimet ja iät.
Tiedot tallennetaan tietuetaulukkoon.
a) järjestä tiedot ikä -kentän mukaan suuruusjärjestykseen
(pienimmästä suurimpaan). Ohjelma tulostaa lopuksi
jarjestetyn taulukon näytälle.
b) järjestä tiedot nimi -kentän mukaan aakkosjärjestyksessä
Ohjelma tulostaa lopuksi jarjestetyn taulukon näytolle.

Lajittelu tulee toteuttaa siten, että se toimisi samoin
myös 50 tai 5000 koiran tapauksessa.
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
	cout << "Tehtävä 18\n";
	cout << "Syötä 5:n koiran nimi ja ikä\n";

	while (m < MAX_KOIRAT)
	{
		cout << m + 1 << ". Koiran nimi: " << endl;
		cin.get(tiedot[m].nimi, 30);

		cout << m + 1 << ". Koiran ikä: " << endl;
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
	cout << "Koirien tiedot aakkosjärjestyksessä\n\n";
	for (int m = 0; m < MAX_KOIRAT; m++)
	{
		cout << tiedot[m].nimi << " " << tiedot[m].ika << endl;
	}

	system("pause");
}