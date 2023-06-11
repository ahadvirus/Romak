using Romak.Commons.Contracts;

namespace Romak.Identity;

public class Module : IModule
{
    public string Name
    {
        get
        {
            return nameof(Identity);
        }
    }
}
