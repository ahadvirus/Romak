using Romak.Commons.Contracts;

namespace Romak.Inventory;

public class Module : IModule
{
    public string Name
    {
        get
        {
            return nameof(Inventory);
        }
    }
}
