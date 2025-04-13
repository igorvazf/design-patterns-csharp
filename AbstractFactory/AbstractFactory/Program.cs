using AbstractFactory.Factory;

// Cliente

IUIFactory factory;

Console.WriteLine("=== MacOS ===");

factory = new MacOSUIFactory();

factory.CreateButton().Render();
factory.CreateButton().OnClick();

factory.CreateCheckbox().Render();
factory.CreateCheckbox().Toggle();


Console.WriteLine("=== Windows ===");

factory = new WindowsUIFactory();

factory.CreateButton().Render();
factory.CreateButton().OnClick();

factory.CreateCheckbox().Render();
factory.CreateCheckbox().Toggle();