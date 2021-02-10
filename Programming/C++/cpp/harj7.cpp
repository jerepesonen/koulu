/*Tekijä: Jere Pesonen

Harjoitus 7 (palautus vko 40)

Tee ohjelma, joka kysyy käyttäjältä nimen, pituuden sentteinä ja painon kiloina. 
Ohjelma laskee ja tulostaa käyttäjän ihannepainon (pituus-100). Lisäksi
ohjelma kertoo käyttäjän nykyisen painon eron kiloina verrattuna ihanne- 
painoon. Ohjelman käyttöliittymä toimii seuraavasti:

Ihannepaino

Ohjelma laskee ihannepainosi
pituutesi perusteella.

Anna nimesi > Mooses
Anna pituutesi sentteinä > 175
Anna osoitteesi > Peikkovuori 5 as 4
Anna painosi kiloina > 89


Arvoisa Mooses
Osoitteesi on Peikkovuori 5 as 4
Nykyinen painosi 89.0 kg
Ihannepainosi 75.0 kg
Erotus 14.0 kg


Käytä cin/cout/cin.get... olioita ohjelman
toteuttamiseen (c++ metodit, kirja sivu 92 - 99)

Pvm: 17.9.2019
Versio 1.0
*/
#include <iostream>
using namespace std;
int main()
{
	cout << "Tehtävä 7\n\n";
	int pituus;
	int paino;
	int ihannepaino;
	char nimi[30];
	char osoite[30];
	cout << "Tehtävä 7" << endl;
	cout << "Anna nimesi: ";
	cin.get(nimi, 30);
	cout << "Anna pituutesi sentteinä: ";
	cin >> pituus;
	cout << "Anna osoitteesi: ";
	cin.get();	
	cin.get(osoite, 30);
	cout << "Anna painosi kiloina: ";
	cin >> paino;
	cout << "\nArvoisa " << nimi <<endl;
	cout << "Pituutesi on: " << pituus <<endl;
	cout << "Osoitteesi on: " << osoite <<endl;
	cout << "ihannepainosi on: " << (pituus - 100) << endl;
	cout << "Erotus: " << (paino - (pituus - 100)) <<" kg" << endl;
	system("pause");
}