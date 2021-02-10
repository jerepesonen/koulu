/*	Tekij‰: Jere Pesonen

Teht‰v‰: Harjoitus 6 (palautus vko 40)

Kirjoita ohjelma, joka kysyy k‰ytt‰j‰lt‰ lompakossa olevan raham‰‰r‰n
ja lihapiirakan hinnan.

Ohjelma tutkii, onko k‰ytt‰j‰ll‰ varaa ostaa lihapiirakka.
Jos on, ohjelma ilmoittaa, kuinka paljon lompakkoon j‰‰ viel‰ rahaa.
Muuten ohjelma kehottaa k‰ytt‰j‰‰ paastoamaan.

K‰yt‰ vain kahta muuttujaa. ‰l‰ v‰henn‰ lompakon sis‰lt‰‰, ellet voi
ostaa lihapiirakkaa.
Pvm:12.9.2018
Versio:1.0
*/

#include <iostream>
using namespace std;
int erotus;
void Laske(int, int);
void main()
{
	cout << "harjoitus 6" << endl;
	int luku1, luku2;
	cout << "Paljonko lompakossa on rahaa?" << endl;
	cin >> luku1;
	cout << "Paljonko lihapiirakka maksaa?" << endl;
	cin >> luku2;
	Laske(luku1, luku2);

	if (erotus > 0)
	{
		cout << endl;
		cout << "Ota lihapiirakka\n" << "lompakkoon j‰‰ " << erotus << endl;
	}
		else
	{
		cout << "Paastoa" << endl;
	}
		system("pause");
}
void Laske(int luku1, int luku2)
{
	erotus = luku1 - luku2;
}