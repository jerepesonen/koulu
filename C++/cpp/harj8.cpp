/*Tekijä Jere Pesonen
Harjoitus 8 (palautus vko 41)
Tee ohjelma, joka tulostaa annetut kolme lukua suuruus -
järjestyksessä(pienimmästä suurimpaan) näytölle
(katso harj. 1 suunnitelma)
a) käytä kokonaislukuja
b) käytä liukulukuja(= reaalilukuja)
*/
#include <iostream>
/*Tekijä Jere Pesonen
Harjoitus 8 (palautus vko 41)
Tee ohjelma, joka tulostaa annetut kolme lukua suuruus -
järjestyksessä(pienimmästä suurimpaan) näytölle
(katso harj. 1 suunnitelma)
a) käytä kokonaislukuja
b) käytä liukulukuja(= reaalilukuja)
*/
#include <iostream>
using namespace std;
int main()
{
	double luku1;
	double luku2;
	double luku3;
	cout << "Anna kolme eri lukua" << endl;
	cin >> luku1;
	cin >> luku2;
	cin >> luku3;

	if (luku1 < luku2 && luku2 < luku3)
	{
		cout << luku1 << "<" << luku2 << "<" << luku3;
	}

	else if (luku1 < luku3 && luku3 < luku2)
	{
		cout << luku1 << "<" << luku3 << "<" << luku2;
	}

	else if (luku2 < luku1 && luku1 < luku3)
	{
		cout << luku2 << "<" << luku1 << "<" << luku3;
	}
	else if (luku2 < luku3 && luku3 < luku1)
	{
		cout << luku2 << "<" << luku3 << "<" << luku1;
	}
	else if (luku3 < luku1 && luku1 < luku2)
	{
		cout << luku3 << "<" << luku1 << "<" << luku2;
	}
	else if (luku3 < luku2 && luku2 < luku1)
	{
		cout << luku3 << "<" << luku2 << "<" << luku1;
	}
	cout << endl;
	system("pause");
}