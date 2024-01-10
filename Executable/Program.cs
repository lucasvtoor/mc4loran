using Injectors;
using Servers;

var injector = Injector.CreateDefaultInjector().Build();


var server = new Server(injector);