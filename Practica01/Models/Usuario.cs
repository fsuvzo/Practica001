using System;
using System.Collections.Generic;

namespace Practica01.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Estado { get; set; }

    public string Email { get; set; } = null!;

}
