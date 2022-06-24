// a simple vowel and consonant game where when you enter an alphabet,
// it detects whether it is a vowel or a consonant.

Console.Write("Enter an alphabet: ");
char alp = Convert.ToChar(Console.ReadLine());


switch (alp)
{
    case 'i':
    case 'e':
    case 'o':
    case 'u':
    case 'a':
        Console.WriteLine($"{alp} is a vowel.");
        break;

    default:
        Console.WriteLine($"{alp} is a consonant.");
        break;
}




