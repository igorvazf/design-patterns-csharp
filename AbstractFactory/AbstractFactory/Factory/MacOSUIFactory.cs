using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    // classe ConcreteFactory
    public class MacOSUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacOSCheckbox();
        }
    }
}
