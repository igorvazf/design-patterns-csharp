using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    // classe ConcreteFactory
    internal class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
