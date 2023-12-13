using System;
using System.Collections.Generic;

namespace P2_enshu9_4.Models;

public partial class Division
{
    public int DivisionId { get; set; }

    public string? DivisionName { get; set; }

    public bool DspFlg { get; set; }

    public string? Comments { get; set; }
}
