using System;
using System.Collections.Generic;

namespace Practica01.Models;

public partial class Perfile
{
    public int PerfilId { get; set; }

    public string Nombre { get; set; } = null!;

    public int Estado { get; set; }
}
