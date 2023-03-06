using System;
using System.Collections.Generic;

namespace EGE;

public partial class Rule
{
    public long IdRules { get; set; }

    public string Ruledescription { get; set; } = null!;

    public byte[] Link { get; set; } = null!;
}
