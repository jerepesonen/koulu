/* 
Tekijä: Jere Pesonen
Harjoitus 13 (Palautus vko 43)
Tee ohjelma, joka kysyy etunimesi ja sukunimesi.Ohjelma
yhdistää nimet yhdeksi merkkijonoksi ja tulostaa ne
lopuksi naytölle.


a) Kayta cstring - kirjastoa(C:n merkkitaulukot)
tehdäksesi merkkijonojen yhdistämisen
b) Kayta string - kirjastoa(C++:n merkkijonot)
tehdäksesi merkkijonojen yhdistämisen  TEE, JOS ON AIKAA

Esimerkki
Anna etunimi : Aku
Anna sukunimi : Ankka
Nimesi oli : Aku Ankka
*/

#include <iostream>
using namespace std;
#include <cstring>
int main()

{
	char etunimi[100] = "";
	char sukunimi[100] = "";
	cout << "Tehtävä 13\n\n";
	cout << "Syötä etunimesi: ";
	cin >> etunimi;
	cout << "Syötä sukunimesi: ";
	cin >> sukunimi;
	strcat_s(etunimi, " ");
	strcat_s(etunimi, sukunimi);
	cout << "Nimesi oli: " << etunimi << endl;
	system("pause");
	return 0;
}