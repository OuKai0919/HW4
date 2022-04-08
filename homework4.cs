string food = "";

Random random = new Random();
int i = random.Next(0, 8);

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
    case 3:
        food = "Beef";
        break;
    case 4:
        food = "Sausage";
        break;
    case 5:
        food = "Pizza";
        break;  
    case 6
        food = "Spaghetti";
        break;
    case 7:
        food = "Stinky tofu";
        break;
    case 8:
        food = "Braised pork on rice";
        break; 
}
Console.WriteLine("Random result : " + food + ".");