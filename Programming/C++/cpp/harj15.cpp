/* Tekijä: Jere Pesonen
Harjoitus 15 (Palautus vko 45)

Tee ohjelma, joka kysyy henkilötietosi seuraavasti :
Anna(kaikki) etunimesi(merkkijono) :
	Anna kengannumero(kokonaisluku) :
	Anna sukunimi(merkkijono) :
	Anna koulumatka(reaaliluku) :
	Anna osoitteesi :
Anna postinumero :

Ohjelma tulostaa tiedot seuraavasti :
sukunimi etunimet
osoite
postinumero
kengannumero ja koulumatka

Käytä C++:n cin - ja cout - olioita ohjelman toteuttamiseen.
*/

#include <iostream>
using namespace std;
#include <cstring>
int main()
{
	char etunimet[100];
	int kengannumero;
	char sukunimi[200];
	float matka;
	char osoite[30];
	int postinumero;

	cout << "Tehtävä 15\n";
	cout << "Anna kaikki etunimesi: ";
	cin.get (etunimet, 100);
	cout << "Anna kengannumero: ";
	cin >> kengannumero;
	cout << "Anna sukunimesi: ";
	cin.get();
	cin.get(sukunimi, 20);
	cout << "Anna koulumatka: ";
	cin >> matka;
	cout << "Anna osoitteesi: ";
	cin.get();
	cin.get(osoite, 30);
	cout << "Anna postinumerosi: ";
	cin >> postinumero;
	strcat_s(sukunimi, " ");
	strcat_s(sukunimi, etunimet);

	cout << sukunimi << endl << osoite << endl << postinumero << endl << kengannumero << " "<< matka << endl;

	system("pause");
}