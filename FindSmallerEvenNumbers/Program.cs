Console.WriteLine("Введите число");
int number = Convert.ToInt32 (Console.ReadLine());
int NextEvenNumber = 2;
    while (NextEvenNumber <= number)
        {
            Console.WriteLine (NextEvenNumber);
            NextEvenNumber = NextEvenNumber + 2;
        }
