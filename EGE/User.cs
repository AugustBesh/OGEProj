using System;
using System.Collections.Generic;

namespace EGE;

public partial class User
{
    public long Id { get; set; }

    public string Login { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public string Email { get; set; } = null!;
}
