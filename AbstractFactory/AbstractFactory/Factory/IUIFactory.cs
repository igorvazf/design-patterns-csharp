using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    // interface AbstractFactory
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
