/* Tekij�, Jere Pesonen

Harjoitus 10 (Palautus vko 41)

Tee ohjelma, joka laskee sy�tetyist� kokonaisluvuista sek� positiivisten
ett� negatiivisten kokonaislukujen osuuden. Lukujen sy�tt� lopetetaan
sy�tt�m�ll� luku 0.

Tulostus:
Sy�tit kokonaislukuja seuraavasti:
----------------------------------
Negatiiviset 7 kpl 70.00%
Positiiviset 3 kpl 30.00%
Yhteens� 10 kpl 100.00%
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
			cout << "Lukuja on yhteen� " << yht << endl;
		}

		else if (luku < 0)
		{
			neg++; yht++;
			cout << "Negatiivisia lukuja on " << neg << endl;
			cout << "Lukuja on yhteens� " << yht << endl;
		}
		else
			break;
	}
	cout << "Sy�tit kokonaislukuja seuraavasti\n";
	cout << "-----------------------------------\n";
	cout << "Positiviset " << pos << " kpl " << (pos*100 / yht ) <<".00%" << endl;
	cout << "Negatiiviset " << neg << " kpl " << (neg*100 / yht) << ".00%" << endl;
	cout << "Yhteens� " << yht << " kpl " << " 100.00%" << endl;
	system("pause");
}