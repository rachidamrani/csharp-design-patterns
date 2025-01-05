// See https://aka.ms/new-console-template for more information
using Builder;

IBuilder builder = new SimpleProductBuilder();

ProductDirector director = new ProductDirector(builder); 

director.ConstructProduct();

Product product = builder.Build();

Console.WriteLine(product);