using System;
using System.Collections.Generic;

namespace MVC_Core_DbFirst.Models;

public partial class StudentInfo
{
    public int RollNo { get; set; }

    public string Name { get; set; } = null!;

    public short Age { get; set; }

    public string LocalAddr { get; set; } = null!;

    public string PerAddr { get; set; } = null!;

    public string? PhoneNo { get; set; }

    public string? SchoolName { get; set; }
}
