﻿Random random = new Random();
int daysUntilExpiration = random.Next(12);
//int daysUntilExpiration = 12;
int discountPercentage = 0;

// Your code goes here
Console.WriteLine("Days remaining " + daysUntilExpiration);

if (daysUntilExpiration >= 5 && daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration >= 2 && daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day! \n Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}