
string[] OneArray = new string[6] { "morning", "fox", "life", "sea", "glory", "cool"}; 
string[] TwoArray = new string[OneArray.Length]; 
int n = 0;
for(int i = 0; i < OneArray.Length;i++)
{
    if(OneArray[i].Length <=3)
    {
        TwoArray[n] = OneArray[i];
        n++;
    }
     Console.Write($"{OneArray[i]} ");

        Console.Write(" ");
}

Console.Write("--> "); 