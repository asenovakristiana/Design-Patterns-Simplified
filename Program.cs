using Dumpify;

void Main()
{
    new NavigationBar(new Apple());
    new DropdownMenu(new Apple());
}

public class NavigationBar
{
    public NavigationBar(IUIFactory factory) => factory.CreateButton();
}

public class DropdownMenu
{
    public DropdownMenu(Apple factory) => factory.CreateButton();
}

public interface IUIFactory
{
    public Button CreateButton();
}
public class Apple : IUIFactory
{
        public Button CreateButton()
        {
            return new Button { Type = "IOS Button".Dump() };
        }
}

public class Button
{
    public required string Type { get; set; }
}
