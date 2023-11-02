//Decorator pattern
//ordering vegan pesto ,mushroom,avacado pizza
using Design_Patterns.PizzaBillingSystem;


PestoPizza pestoPizza=new PestoPizza();
AvacadoTopping avoPizza = new AvacadoTopping(pestoPizza);
MushroomTopping mushroom = new MushroomTopping(avoPizza);
Console.WriteLine(mushroom.GetDesc());
Console.WriteLine(mushroom.GetCost());
Console.ReadLine();