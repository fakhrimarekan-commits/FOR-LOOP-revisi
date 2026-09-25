string secretcode = "1992";
string attempt = "";

while (attempt != secretcode)
{
    Console.Write("enter the secret code:");
    attempt = Console.ReadLine();
    if(attempt != secretcode);
    Console.WriteLine("the door is keep locked");
}

Console.WriteLine("the door is unlocked. congratulation!!");