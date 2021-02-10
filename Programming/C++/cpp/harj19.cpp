/* Tekij�. Jere Pesonen
Harjoitus 19 (Palautus vko 47)
Tee ohjelma, joka toimii auton nopeusmittarina.
Periaate on seuraava : N�pp�imist� toimii
nopeusanturina ja n�ytt� mittarin n�ytt�n�.
Nopeusmittari laskee viiden viimeisen nopeuden
keskiarvon ja tulostaa sen nykyisen� nopeutena
n�yt�lle.Negatiivinen nopeus lopettaa ohjelman.
Toiminta on siis seuraava :
Ohjelman kaynnistyksessa mittari n�ytt�� nolla
0
0
0
0
0 (alkutila)nopeus = 0 km / h
Anna nopeus : 10
= > 2 km / h
Anna nopeus : 20
= > 6 km / h
Anna nopeus : 30
= > 12 km / h
Anna nopeus : 40
= > 20 km / h
Anna nopeus : 50
= > 30 km / h
Anna nopeus : 50
= > 38 km / h
Anna nopeus : 50
= > 44 km / h
Anna nopeus : 50
= > 48 km / h
Anna nopeus : 50
= > 50 km / h
Anna nopeus : 50
= > 50 km / h
Anna nopeus : -5
= > loppu */

#include <iostream>
using namespace std;
const int MAX_TAULU = 5;
int main()
{
	int taulu[MAX_TAULU] = { 0 };
	int i = 0;
	cout << "Harjoitus 19\n\n";

	cout << "Alkutila: " << (taulu[0] + taulu[1] + taulu[2] + taulu[3] + taulu[4]) / MAX_TAULU << endl;

	while (true) {
		cin >> taulu[i];
		if (taulu[i] < 0)
		{
			break;
		}

		cout << (taulu[0] + taulu[1] + taulu[2] + taulu[3] + taulu[4]) / MAX_TAULU << endl;
		i++;
		if (i == 5) {
			i = 0;
		}
	}
	system("pause");
}