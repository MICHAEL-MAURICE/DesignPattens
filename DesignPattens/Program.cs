using Design_Patterns.Singleton;
using DesignPattens.observable.NotificationSystem.EnhanceSolution;
using DesignPattens.observable.NotificationSystem.TopOfMind;
using Strategy_pattern.Mediator;
using Strategy_pattern.Strategy_Pattern;
using System.ComponentModel.DataAnnotations;


#region MAIN

#region  Strategy-pattern



//Duck1 d1=new Duck1();
//d1.perform();



//Duck2 d2 = new Duck2();
//d2.perform();

#endregion
#region Mediator

//var Mediator = new Mediator();
//var alarm = new Alarm(Mediator);
//var CoffeMachine = new CoffeeMachine(Mediator);
//var MovingRobot = new MovingRobot(Mediator);
//var SmartWindow = new SmartWindow();
//var Calender = new Calendar();

//Mediator.send(alarm, Calender, CoffeMachine, MovingRobot, SmartWindow);
//alarm.Snooz();




#endregion
#region Singleton

//while (true)
//{
//    Console.Write("Enter base Currency: ");
//    var baseCurrency = Console.ReadLine();

//    Console.Write("Enter target Currency: ");
//    var targetCurrency = Console.ReadLine();
//    Console.Write("Enter amount: ");

//    var amount = decimal.Parse(Console.ReadLine());



//    var Convertedamount = CurrencyConverter.Instance.Convert(baseCurrency, targetCurrency, amount);

//    Console.WriteLine($"{amount}{baseCurrency} = {Convertedamount}{targetCurrency} ");

//    Console.WriteLine("______________________________________________________________");

//}

#endregion

#region Adapter




#endregion


#region Obswevable

//TopOfMind 

//OnlineMarketPlace onlineMarketPlace=new OnlineMarketPlace();
//onlineMarketPlace.addUser(new User("Mohsen", true, true));
//onlineMarketPlace.addUser(new User("a", false, false));
//onlineMarketPlace.addUser(new User("b", true, false));
//onlineMarketPlace.addUser(new User("c", false, true));

//onlineMarketPlace.addProudect(new Proudect("Pro1", 200));
//onlineMarketPlace.addOffer(new Offer("This Is New Offer"));



//Enhance Solution
OnlineMarketPlace2 onlineMarketPlace= new OnlineMarketPlace2();
ISubscriper A = new Customer("A");
ISubscriper b = new Customer("b");
ISubscriper c = new Customer("c");
ISubscriper d = new Customer("d");
onlineMarketPlace.Subscripe(EventTypes.New_Proudect, A);
onlineMarketPlace.Subscripe(EventTypes.New_Offer, A);
onlineMarketPlace.Subscripe(EventTypes.New_Proudect, b);
onlineMarketPlace.Subscripe(EventTypes.New_Offer, b);
onlineMarketPlace.addProudect(new Proudect2("Pro1", 200));
onlineMarketPlace.addOffer(new Offer2("This Is New Offer"));
#endregion

#endregion














