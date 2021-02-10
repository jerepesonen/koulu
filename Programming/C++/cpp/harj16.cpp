/* Tekijä: Jere Pesonen
Harjoitus 16 (Palautus vko 45)
Tee ohjelma, joka kysyy henkilotietosi ja tallentaa ne tietueeseen.
Tietueeseen talletetaan seuraavat tiedot :
etunimi(merkkijono; C:n merkkitaulukko)
sukunimi(merkkijono; C:n merkkitaulukko)
koulumatka(reaaliluku)
osoite(merkkijono; C:n merkkitaulukko)
postinumero(merkkijono; C:n merkkitaulukko)
kengannumero(kokonaisluku)
Ohjelma tulostaa lopuksi tietueen tiedot naytölle.
*/
#include <iostream>
using namespace std;
struct hlö
{
	char nimi[30];
	char sukunimi[30];
	float matka;
	char osoite[30];
	char postinumero[10];
	int kengannumero;
};
int main()
{
	hlö tiedot;
	cout << "Tehtävä 16\n";
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
	cout << tiedot.nimi << endl << tiedot.sukunimi << endl << tiedot.matka << endl << tiedot.osoite << endl << tiedot.postinumero << endl << tiedot.kengannumero << endl;
	system("pause");
}