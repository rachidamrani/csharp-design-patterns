/*
Define an object that encapsulates how a set of object interact.
Mediator promotes loose coupling by keeping objects from referring to each
other explicitly, and it lets you vary their interaction independently.
*/


using Mediator;

ChatRoom chatRoom = new();

RegularUser alice = new("Alice");
RegularUser bob = new("Bob");
AdminUser charlie = new("Charlie");

chatRoom.AddUser(alice);
chatRoom.AddUser(bob);
chatRoom.AddUser(charlie);


charlie.Send("Welcome, everybody.");

alice.Send("Hello, everyone!");
bob.Send("Hi Alice, how are you?");
alice.Send("I'm good, thanks.");

charlie.BroadcastAlert("Keep it friendly guys!");