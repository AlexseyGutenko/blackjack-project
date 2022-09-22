using static System.Console;

WriteLine("игра Blackjack");

int[] deck = new int [52] {2,3,4,5,6,7,8,9,10,10,10,15,11,2,3,4,5,6,7,8,9,11,10, 10, 10, 15, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 15, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 15 };
while (true)
{
    int count1 = 0;
    int count2 = 0;
    for (int i = 0; i < 2; i++)
    {
        Random rnd = new Random();
        int index = rnd.Next(52);
        int cart = deck[index];
        if (cart == 15)
        {
            WriteLine("у вас Туз как его будете оценивать 1 или 11");
            string chis;
            chis = ReadLine();
            int vbr = Convert.ToInt32(chis);
            if (vbr == 11) { cart = 11; }
            if (vbr == 1) { cart = 1; }
        }
        count1 = count1 + cart;
    }
    WriteLine("ваши очки :"); Write(count1); Write("\n");

    for (int i = 0; i < 2; i++)
    {
        Random rnd = new Random();
        int index = rnd.Next(52);
        int cart = deck[index];
        if (cart == 15)
        {
            Random rn = new Random();
            int vb = rn.Next(2);
            if (vb == 1) { cart = 1; }
            if (vb == 2) { cart = 11; }
        }
        count2 = count2 + cart;
    }
    WriteLine(" очки противника :"); Write(count2); Write("\n");

    if (count1 == 21)
    { WriteLine("вы выйграли"); break; }
    if (count2 > 21)
    { WriteLine("вы выйграли"); break; }
    if (count2 == 21)
    { WriteLine("вы проиграли"); break; }
    

    WriteLine("вы хотите добрать карты да/нет");
    string choice;
    choice = ReadLine();
    if (choice == "да")
    {
        WriteLine("сколько карт хотите добрать");
        string chis;
        chis = ReadLine();
        int vbr = Convert.ToInt32(chis);

        for (int i = 0; i < vbr; i++)
        {
            Random rnd = new Random();
            int index = rnd.Next(52);
            int cart = deck[index];
            if (cart == 15)
            {
                WriteLine("у вас Туз как его будете оценивать 1 или 11");
                string chis1;
                chis = ReadLine();
                int vbr1 = Convert.ToInt32(chis);
                if (vbr == 11) { cart = 11; }
                if (vbr == 1) { cart = 1; }
            }
            count1 = count1 + cart;
        }
        WriteLine("ваши очки :"); Write(count1); Write("\n");
    }
    if (count1 == 21)
    { WriteLine("вы выйграли"); break; }
    if (count1 > 21)
    { WriteLine("вы проиграли"); break; }

    Random r = new Random();
    int ie = r.Next(2);
    if (ie == 1) { break; }
    if (ie == 2)
    {

        if (count2 < 21)
        {
            Random rn = new Random();
            int colvo = rn.Next(3);

            for (int i = 0; i < colvo; i++)
            {
                Random rnd = new Random();
                int index = rnd.Next(52);
                int cart = deck[index];
                if (cart == 15)
                {
                    Random rand = new Random();
                    int vb = rand.Next(2);
                    if (vb == 1) { cart = 1; }
                    if (vb == 2) { cart = 11; }
                }
                count2 = count2 + cart;
            }
        }
        WriteLine(" очки противника :"); Write(count2); Write("\n");

        if (count2 < count1 || count1 <= 21) { WriteLine("вы выйграли"); break; }
    }
}
