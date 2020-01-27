/*	Tekijä: Jere Pesonen

	Tehtävä: Harjoitus 9 (palautus vko 41)

		Tee ohjelma, joka toimii laskimena.
		Käyttäjältä kysytään kaksi kokonaislukua,
		jonka jälkeen ohjelma antaa valikon
		laskutoimituksista. Valikko nayttaa
		seuraavalta:

		VALIKKO
		1. Summa
		2. Erotus
		3. Tulo
		4. Osamaara
		5. Jakojaannos

		Lopuksi ohjelma tulostaa valitun tuloksen naytölle.

	Pvm:23.9.2018
	Versio:1.0
*/

#include <iostream>
using namespace std;
int main()

{
	cout << "Tehtävä 9\n\n";
	int luku1, luku2, valinta;
	cout << "Anna kaksi kokonaislukua" << endl;
	cin >> luku1 >> luku2;
	cout << "Valikko\n";
	cout << "1. Summa\n";
	cout << "2. Erotus\n";
	cout << "3. Tulo\n";
	cout << "4. Osamäärä\n";
	cout << "5. Jakojäännös\n";
	cin >> ws >> valinta;

	switch (valinta)
	{
		case 1: cout << (luku1 + luku2);
			break;
		case 2: cout << (luku1 - luku2);
			break;
		case 3: cout << (luku1 * luku2);
			break;
		case 4: cout << (luku1 / luku2);
			break;
		case 5: cout << (luku1 % luku2);
			break;
	}
	system("pause");
	return 0;
}