using System;
namespace FunctionalPrograms
{
    public class VowelsOrConsonants
    {
        public void VowelsConsonants(char input)
        {
            if (input =='a'||input =='e'||input=='i'||input=='o'||input=='u'||input=='A'||input=='E'||input=='I'||input=='O'||input=='U')
                Console.WriteLine(input+" is Vowel");
            else
                Console.WriteLine(input + " is Vowel");               
        }
    }
}
