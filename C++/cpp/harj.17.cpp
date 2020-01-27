/* Tekijä: Jere Pesonen
Harjoitus 17 (Palautus vko 46)
Muokkaa edellistä ohjelmaa siten, että edellä määriteltyä tietuetyyppiä
käytetään myäs kahden muun "koululaisen" tietojen tallentamiseen.
Näiden kahden muun koululaisen tiedot alustetaan ao.muuttujien
määrittelyn yhteydessä.Ainoastaan yhden koululaisen tiedot kysytään
käyttäjältä edellisen tehtävän tapaan.

Tulosta kolmen koululaisen tiedot koulumatkan mukaisessa
suuruusjärjestyksessä(pienimmästä suurimpaan) näytölle
*/
#include <iostream>
using namespace std;
struct hlö
{
	char nimi[30];
	char sukunimi[30];
	double matka;
	char osoite[30];
	char postinumero[10];
	int kengannumero;
};
int main()
{
	hlö tiedot;
	hlö tiedot1 = {"Jere", "Pesonen", 0.1,"Schaumanin puistotie", "40100", 43 };
	hlö tiedot2 = { "Matti", "Meikäläinen", 20, "Kauppakatu", "40270", 38 };
	cout << "Tehtävä 17\n";
	cout << "Etunimesi: ";
	cin >> tiedot.nimi;
	cout << "Sukunimesi: ";
	cin >> tiedot.sukunimi;
	cout << "Anna koulumatkasi: ";
	cin >> tiedot.matka;
	cout << "Anna osoitteesi: ";
	cin.get();
	cin.get(tiedot.osoite, 30);
	cout << "Anna postinumerosi: ";
	cin >> tiedot.postinumero;
	cout << "Anna kengannumerosi: ";
	cin >> tiedot.kengannumero;



	if (tiedot.matka < tiedot1.matka && tiedot1.matka < tiedot2.matka)
	{
		cout << tiedot.nimi << endl << tiedot.sukunimi << endl << tiedot.matka << endl << tiedot.osoite << endl << tiedot.postinumero << endl << tiedot.kengannumero << endl;
		cout << tiedot1.nimi << endl << tiedot1.sukunimi << endl << tiedot1.matka << endl << tiedot1.osoite << endl << tiedot1.postinumero << endl << tiedot1.kengannumero << endl;
		cout << tiedot2.nimi << endl << tiedot2.sukunimi << endl << tiedot2.matka << endl << tiedot2.osoite << endl << tiedot2.postinumero << endl << tiedot2.kengannumero << endl;
	}

	else if (tiedot.matka < tiedot2.matka && tiedot2.matka < tiedot1.matka)
	{
		cout << tiedot.nimi << endl << tiedot.sukunimi << endl << tiedot.matka << endl << tiedot.osoite << endl << tiedot.postinumero << endl << tiedot.kengannumero << endl;
		cout << tiedot2.nimi << endl << tiedot2.sukunimi << endl << tiedot2.matka << endl << tiedot2.osoite << endl << tiedot2.postinumero << endl << tiedot2.kengannumero << endl;
		cout << tiedot1.nimi << endl << tiedot1.sukunimi << endl << tiedot1.matka << endl << tiedot1.osoite << endl << tiedot1.postinumero << endl << tiedot1.kengannumero << endl;
	}

	else if (tiedot1.matka < tiedot.matka && tiedot.matka < tiedot2.matka)
	{
		cout << tiedot1.nimi << endl << tiedot1.sukunimi << endl << tiedot1.matka << endl << tiedot1.osoite << endl << tiedot1.postinumero << endl << tiedot1.kengannumero << endl;
		cout << tiedot.nimi << endl << tiedot.sukunimi << endl << tiedot.matka << endl << tiedot.osoite << endl << tiedot.postinumero << endl << tiedot.kengannumero << endl;
		cout << tiedot2.nimi << endl << tiedot2.sukunimi << endl << tiedot2.matka << endl << tiedot2.osoite << endl << tiedot2.postinumero << endl << tiedot2.kengannumero << endl;
	}
	else if (tiedot1.matka < tiedot2.matka && tiedot2.matka < tiedot.matka)
	{
		cout << tiedot1.nimi << endl << tiedot1.sukunimi << endl << tiedot1.matka << endl << tiedot1.osoite << endl << tiedot1.postinumero << endl << tiedot1.kengannumero << endl;
		cout << tiedot2.nimi << endl << tiedot2.sukunimi << endl << tiedot2.matka << endl << tiedot2.osoite << endl << tiedot2.postinumero << endl << tiedot2.kengannumero << endl;
		cout << tiedot.nimi << endl << tiedot.sukunimi << endl << tiedot.matka << endl << tiedot.osoite << endl << tiedot.postinumero << endl << tiedot.kengannumero << endl;
	}
	else if (tiedot2.matka < tiedot.matka && tiedot.matka < tiedot1.matka)
	{
		cout << tiedot2.nimi << endl << tiedot2.sukunimi << endl << tiedot2.matka << endl << tiedot2.osoite << endl << tiedot2.postinumero << endl << tiedot2.kengannumero << endl;
		cout << tiedot.nimi << endl << tiedot.sukunimi << endl << tiedot.matka << endl << tiedot.osoite << endl << tiedot.postinumero << endl << tiedot.kengannumero << endl;
		cout << tiedot1.nimi << endl << tiedot1.sukunimi << endl << tiedot1.matka << endl << tiedot1.osoite << endl << tiedot1.postinumero << endl << tiedot1.kengannumero << endl;
	}
	else if (tiedot2.matka < tiedot1.matka && tiedot1.matka < tiedot.matka)
	{
		cout << tiedot2.nimi << endl << tiedot2.sukunimi << endl << tiedot2.matka << endl << tiedot2.osoite << endl << tiedot2.postinumero << endl << tiedot2.kengannumero << endl;
		cout << tiedot1.nimi << endl << tiedot1.sukunimi << endl << tiedot1.matka << endl << tiedot1.osoite << endl << tiedot1.postinumero << endl << tiedot1.kengannumero << endl;
		cout << tiedot.nimi << endl << tiedot.sukunimi << endl << tiedot.matka << endl << tiedot.osoite << endl << tiedot.postinumero << endl << tiedot.kengannumero << endl;
	}
	system("pause");
}