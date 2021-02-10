#include <iostream>
using namespace std;
const int MAX_TAULU = 5;
int main()
{
	short taulu[MAX_TAULU] = { 0 };
	short *os; // m‰‰ritell‰‰n osoitin, jolla voidaan k‰sitell‰ taulukkoa
	os = &taulu[0]; //alustetaan osoitin osoittamaan taulukon alkuun
	int i = 0;
	cout << "Harjoitus 19\n\n";

	cout << "Alkutila: " << (taulu[0] + taulu[1] + taulu[2] + taulu[3] + taulu[4]) / MAX_TAULU << endl;

	while (true) {
		cin >> os[i];
		if (os[i] < 0)
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