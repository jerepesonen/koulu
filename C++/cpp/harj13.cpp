/* 
Tekij�: Jere Pesonen
Harjoitus 13 (Palautus vko 43)
Tee ohjelma, joka kysyy etunimesi ja sukunimesi.Ohjelma
yhdist�� nimet yhdeksi merkkijonoksi ja tulostaa ne
lopuksi nayt�lle.


a) Kayta cstring - kirjastoa(C:n merkkitaulukot)
tehd�ksesi merkkijonojen yhdist�misen
b) Kayta string - kirjastoa(C++:n merkkijonot)
tehd�ksesi merkkijonojen yhdist�misen  TEE, JOS ON AIKAA

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
	cout << "Teht�v� 13\n\n";
	cout << "Sy�t� etunimesi: ";
	cin >> etunimi;
	cout << "Sy�t� sukunimesi: ";
	cin >> sukunimi;
	strcat_s(etunimi, " ");
	strcat_s(etunimi, sukunimi);
	cout << "Nimesi oli: " << etunimi << endl;
	system("pause");
	return 0;
}