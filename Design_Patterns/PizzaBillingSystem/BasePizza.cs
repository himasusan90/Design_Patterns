using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.PizzaBillingSystem
{

    //This is an example of decorator pattern
    //which is a structural pattern and good for scenarios
    //to avoid class explosions
    public abstract class BasePizza
    {
        public string Description { get; set; }
        public BasePizza(string pizzaDesc)
        {
            Description = pizzaDesc;
        }
        public abstract double GetCost();

        public virtual string GetDesc()
        {
            return Description;

        }
    }
    public class MargheritaPizza : BasePizza
    {
        public MargheritaPizza() : base("MargheritaPizza")
        {

        }
        public override double GetCost()
        {
            return 100;
        }



    }

    public class VegieDelight : BasePizza
    {
        public VegieDelight() : base("VegieDelight")
        {

        }
        public override double GetCost()
        {
            return 150;
        }
    }

    public class PestoPizza : BasePizza
    {
        public PestoPizza() : base("PestoPizza")
        {

        }
        public override double GetCost()
        {
            return 250;
        }
        public string GetDesc()
        {
            return Description;
        }
    }

    public abstract class PizzaTopping : BasePizza
    {

        public BasePizza BasePizza { get; set; }

        public PizzaTopping(BasePizza basePizza, string desc) : base(desc)
        {
            BasePizza = basePizza;
        }

        public override string GetDesc()
        {
            return BasePizza.GetDesc() + ", " + Description;
        }

    }

    public class MushroomTopping : PizzaTopping
    {

        public MushroomTopping(BasePizza basePizza) : base(basePizza, "Added mushroom")
        {
        }

        public override double GetCost()
        {
            return BasePizza.GetCost() + 5;
        }

    }
    public class ExtraCheeseTopping : PizzaTopping
    {

        public ExtraCheeseTopping(BasePizza basePizza) : base(basePizza, "Added extra cheese")
        {
        }

        public override double GetCost()
        {
            return BasePizza.GetCost() + 50;
        }
       
    }
    public class AvacadoTopping : PizzaTopping
    {

        public AvacadoTopping(BasePizza basePizza) : base(basePizza, "Added avo")
        {
        }

        public override double GetCost()
        {
            return BasePizza.GetCost() + 50;
        }
    }
}

