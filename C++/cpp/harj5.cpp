/*	Tekijä: Jere Pesonen
	
	Tehtävä: Harjoitus 5 (palautus vko 40)
		
		Kirjoita ohjelma, joka pyytää käyttäjältä kaksi kokonaislukua.
		Ohjelma tulostaa tekstin BINGO, mikäli luvut ovat samoja.
		Muussa tapauksessa ohjelma tulostaa tekstin BONGO.
		
	Pvm:10.9.2018
	Versio:1.0
*/

#include <iostream>
using namespace std;
int main()

{
	cout << "Harjoitus 5" << endl;
	int luku1, luku2;
	cout << "Syötä kaksi lukua: " << endl;
	cin >> luku1 >> luku2;

	if (luku1 == luku2)
	{
		cout << "BINGO" << endl;
	}
	else
	{
		cout << "BONGO" << endl;
	}
	
			system("pause");
	return 0;
}
