/* Tekij‰ Jere Pesonen
Harjoitus 3 (palautus vko 39)

include <iostream> 
using namespace std;
void main (void)
{
cout << "Hei maailma!";
}

Muokkaa ylla olevaa ohjelmaa niin, etta tulostat oman nimesi
ja osoitteesi naytolle allekkain.
HUOM! Nime‰ tiedosto harj3a.cpp nimelle!
Muokkaa edellisest‰ ohjelmasta versio nimelle harj3b.cpp, jossa
nimi ja osoite tulostetaan n‰yt‰lle seuraavasti:

**********************************
* *
* Etunimi 
* Sukunimi *
* *
*-------------------------------------- *
* *
* Asemakatu 7 *
* 40520 JKL *
* *
***********************************/
#include <iostream>
using namespace std;
int main() //p‰‰ohjelma alkaa t‰st‰
{
	cout << "Teht‰v‰ 3\n\n";
	cout << "**********************************" << endl
		<< "**" << endl
		<< "*Jere" << endl
		<< "*Pesonen*" << endl
		<< "**" << endl
		<< "*--------------------------------*" << endl
		<< "**" << endl
		<< "*Schaumanin puistotie*" << endl
		<< "*40100 JKL*" << endl
		<< "**" << endl
		<< "**********************************" << endl;
		cout << endl;
	system("pause");
}