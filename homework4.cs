string food = "";

Random random = new Random();
int i = random.Next(0, 3);

switch (i)
{
    case 0:
        food = "Pork Belly";
        break;
    case 1:
        food = "Chicken Karaage";
        break;
    case 2:
        food = "Spicy Dumplings";
        break;
}
Console.WriteLine("Random result : " + food + ".");