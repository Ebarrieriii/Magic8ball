
// ****** .NET 6!!! ****** //
string userAnswer;
string userQuestion;
bool loop = true;

//Ascii Art
PrintAsciiArt();

while (loop)
{
    //Get User Answer
    GetUserAnswer();

    if (userAnswer.ToLower() == "no")
    {
        //Exit loop
        loop = false;
    } else if (userAnswer.ToLower() == "yes")
    {
        // Get the user's question
        GetUserQuestion();

        // Return a random answer
        ReturnAnswer();
    } else
    {
        Console.WriteLine("Answer not recognized. Please respond with 'yes' or 'no'.");
    }

}


Console.WriteLine("\n \nThanks for playing!");




void GetUserAnswer()
{
    Console.WriteLine("Would you like to ask the magic 8 ball a question?");
    userAnswer = Console.ReadLine();
}

void PrintAsciiArt()
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(@"
    ,dP9CGG88@b,
  ,IP  _   Y888@@b,
 dIi  (_)   G8888@b
dCII  (_)   G8888@@b
GCCIi     ,GG8888@@@
GGCCCCCCCGGG88888@@@
GGGGCCCGGGG88888@@@@...
Y8GGGGGG8888888@@@@P.....
 Y88888888888@@@@@P......
 `Y8888888@@@@@@@P'......
    `@@@@@@@@@P'.......
        """"........
");
    Console.ForegroundColor = ConsoleColor.White;
}

void GetUserQuestion()
{
    Console.WriteLine("What would you like to ask the magic 8 ball?");
    userQuestion = Console.ReadLine();
}

void ReturnAnswer()
{
    // 8 Ball answers
    string[] eightBallAnswers = { "It is certain.", "Without a doubt", "Yes, definitely.", "Ask again later.", "Better not tell you now", "Concentrate and ask again", "Don't count on it.", "My reply is no.", "Doubtful." };
    
    Random rand = new Random();
    int newAnswer = rand.Next(eightBallAnswers.Length);
    Console.WriteLine(eightBallAnswers[newAnswer]);
}