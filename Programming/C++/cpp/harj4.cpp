/*
Tekij‰: Jere Pesonen
Teht‰v‰: Harjoitus 4
Ks.  Oppikirjan (+omat) esimerkit, harj4

a) Kirjoita, tallenna ja suorita ym. ohjelma.
b) Kommentoi ylla olevan esimerkin kaikki rivit (mit‰ rivill‰ tapahtuu).
c) Muuta vakioden nimet niin, ett‰
MAX => MINIMI
max => MAKSIMI

Muuta ohjelmaa niin, ett‰ voit tulostaa ohjelmalla jonkun seuraavat ilmoitukset riippuen syˆtetyst‰ luvusta:
Summa on pienempi kuin MINIMI 
Summa on suurempi kuin MAKSIMI
Summa on MINIMIN ja MAKSIMIN v‰liss‰*/
#include <iostream> // esik‰‰nt‰j‰n komento (input output stream)
using namespace std; 

// vakioiden m‰‰rittely (aina isolla)
const int MINIMI = 10;
const int MAXIMI = 20; // uusi tapa, SUOSITELTAVA

// muuttujien m‰‰rittely (aina pienell‰)
int summa; 

// aliohjelmien esittely
void Laske(int, int);

	int main() // P‰‰ohjelma alkaa t‰st‰
{
		int luku1;
	cout << "Syˆt‰ luku: ";
	cin  >> luku1;
	
	if (luku1 < MINIMI)
	{
		cout << "Luku on pienempi kuin " << MINIMI << endl;
	}
	else if (luku1 > MAXIMI)
	{
		cout << "Luku on suurempi kuin " << MAXIMI << endl;
	}
	else
	{
		cout << "Luku on " << MINIMI;
		cout << " ja " << MAXIMI;
		cout << " v‰liss‰" << endl;
	}
	system("pause");
	return 0;

}
