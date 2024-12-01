// /**
// Define a family of algorithms, encapsulate each one, and make them interchangeable.
// Strategy lets the algorithm vary independently of clients that use it.
// <=>
// Put interchangeable logic behind an interface
// **/


Context context = new Context();

var strategyA = new ConcreteStrategyA();
context.SetStrategy(strategyA);
context.Execute();

var strategyB = new ConcreteStrategyB();
context.SetStrategy(strategyB);
context.Execute();

var strategyC = new ConcreteStrategyC();
context.SetStrategy(strategyC);
context.Execute();
