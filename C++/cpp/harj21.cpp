/* Tekij� Jere Pesonen
Harjoitus 21 (Palautus vko 48)
Muunna harjoitus 11 niin, etta k�yt�t seuraavia aliohjelmia:

int KysyValinta(void);

-> KysyValinta paluttaa k�ytt�j�n antaman valintanumeron (0-6)

double Summa(float luku1, int luku2);

-> Summa laskee yhteen annetut tiedot ja palauttaa summan p��ohjelmaan*/

#include <iostream>
using namespace std;
int Kysyvalinta();
int main()
{
	int luku1, luku2, valinta;
	valinta = 6;
	cout << "Teht�v� 11\n\n";

	while (valinta == 6)
	{
	cout << "Anna kaksi kokonaislukua" << endl;
	cin >> luku1 >> luku2;
	cout << "\nValikko\n";
	cout << "1. Summa\n";
	cout << "2. Erotus\n";
	cout << "3. Tulo\n";
	cout << "4. Osam��r�\n";
	cout << "5. Jakoj��nn�s\n";
	cout << "6. Sy�t� uudet luvut\n";

	valinta = Kysyvalinta();



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
		case 6: cout << endl;
			break;

		}
	}
	system("pause");
	return 0;
}
int Kysyvalinta() {
	int valinta;
	cin >> valinta;
	return valinta;
}
