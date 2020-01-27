/* Tekijä, Jere Pesonen

Harjoitus 10 (Palautus vko 41)

Tee ohjelma, joka laskee syötetyistä kokonaisluvuista sekä positiivisten
että negatiivisten kokonaislukujen osuuden. Lukujen syöttä lopetetaan
syöttämällä luku 0.

Tulostus:
Syötit kokonaislukuja seuraavasti:
----------------------------------
Negatiiviset 7 kpl 70.00%
Positiiviset 3 kpl 30.00%
Yhteensä 10 kpl 100.00%
*/
#include <iostream>
using namespace std;
int main()
{
	cout << "Harjoitus 10\n\n";
	int luku;
	short pos = 0;
	short neg = 0;
	short yht = 0;
	while (true)
	{
		cout << "Anna luku ";
		cin >> luku;

		if (luku > 0)
		{
			pos++; yht++;
			cout << "Positiivisia lukuja on " << pos << endl;
			cout << "Lukuja on yhteenä " << yht << endl;
		}

		else if (luku < 0)
		{
			neg++; yht++;
			cout << "Negatiivisia lukuja on " << neg << endl;
			cout << "Lukuja on yhteensö " << yht << endl;
		}
		else
			break;
	}
	cout << "Syötit kokonaislukuja seuraavasti\n";
	cout << "-----------------------------------\n";
	cout << "Positiviset " << pos << " kpl " << (pos*100 / yht ) <<".00%" << endl;
	cout << "Negatiiviset " << neg << " kpl " << (neg*100 / yht) << ".00%" << endl;
	cout << "Yhteensä " << yht << " kpl " << " 100.00%" << endl;
	system("pause");
}