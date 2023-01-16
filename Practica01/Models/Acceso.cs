using System;
using System.Collections.Generic;

namespace Practica01.Models;

public partial class Acceso
{
    public int AccesoId { get; set; }

    public string Nombre { get; set; } = null!;

    public int EmpId { get; set; }

    public string Icono { get; set; } = null!;

    public int Estado { get; set; }
}
