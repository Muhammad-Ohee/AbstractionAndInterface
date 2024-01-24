//Console.WriteLine("Hello, OS");

namespace AbstractionAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstaction 
            AbstractBurger burger1 = BurgerObjectFactory.GetBurgerObject("Chicken_Burger");
            string customer1 = "I love Chicken Burger. " + "Please give me a " +
                burger1.size() + ". Chesse " + burger1.cheese() + ". Spicey " +
                burger1.spicey() + ".";
            Console.WriteLine(customer1);

            AbstractBurger burger2 = BurgerObjectFactory.GetBurgerObject("Chicken_Chesse_Burger");
            string customer2 = "I love Chicken Cheese Burger. " + "Please give me a " +
                burger2.size() + ". Chesse " + burger2.cheese() + ". Spicey " +
                burger2.spicey() + ".";
            Console.WriteLine(customer2);



            // Interface
            /*
            IBurger burger1 = BurgerObjectFactory.GetBurgerObject("Chicken_Burger");
            string customer1 = "I love Chicken Burger. " + "Please give me a " +
                burger1.size() + ". Chesse " + burger1.cheese() + ". Spicey " +
                burger1.spicey() + ".";
            Console.WriteLine(customer1);

            IBurger burger2 = BurgerObjectFactory.GetBurgerObject("Chicken_Chesse_Burger");
            string customer2 = "I love Chicken Cheese Burger. " + "Please give me a " +
                burger2.size() + ". Chesse " + burger2.cheese() + ". Spicey " +
                burger2.spicey() + ".";
            Console.WriteLine(customer2);
            */
        }
    }



    public abstract class AbstractBurger
    {
        public abstract string size();
        public abstract string cheese();
        public abstract string spicey();
    }


    public class BurgerObjectFactory
    {
        public static AbstractBurger GetBurgerObject(string objectName)
        {
            AbstractBurger burgerObject = null;
            if (objectName == "Chicken_Burger")
            {
                burgerObject = new Chicken_Burger();
            }
            else if (objectName == "Chicken_Chesse_Burger")
            {
                burgerObject = new Chicken_Burger();
            }

            return burgerObject;
        }
    }

    public class Chicken_Burger : AbstractBurger
    {
        public override string cheese()
        {
            return "No";
        }

        public override string size()
        {
            return "Double";
        }

        public override string spicey()
        {
            return "Yes";
        }
    }

    public class Chicken_Chesse_Burger : AbstractBurger
    {
        public override string cheese()
        {
            return "Yes";
        }

        public override string size()
        {
            return "Double";
        }

        public override string spicey()
        {
            return "Yes";
        }
    }



    /*
    public interface IBurger
    {
        string size();
        string cheese();
        string spicey();   
    }

    public class BurgerObjectFactory
    {
        public static IBurger GetBurgerObject(string objectName)
        {
            IBurger burger = null;
            if (objectName == "Chicken_Burger")
            {
                burger = new Chicken_Burger();
            }
            else if (objectName == "Chicken_Chesse_Burger")
            {
                burger = new Chicken_Chesse_Burger();
            }
            
            return burger;
            
        }
    }
    

    public class Chicken_Burger : IBurger
    {
        public string cheese()
        {
            return "No";
        }

        public string size()
        {
            return "Double";
        }

        public string spicey()
        {
            return "Yes";
        }
    }

    public class Chicken_Chesse_Burger : IBurger
    {
        public string cheese()
        {
            return "Yes";
        }

        public string size()
        {
            return "Double";
        }

        public string spicey()
        {
            return "Yes";
        }
    }
    */

}