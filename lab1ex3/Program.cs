/*
 * Ex3
Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
tastaura
 (google: how to get the last digit of a number)
*/
Console.WriteLine("Introduceti un numar intreg din mai multe cifre: ");
int numarTastatura = int.Parse(Console.ReadLine());

int lastDigit = numarTastatura % 10;

Console.WriteLine("Ultima cifra a numarului introdus este: " + lastDigit);

