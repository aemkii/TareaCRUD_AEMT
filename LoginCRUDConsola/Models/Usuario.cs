using System;
using System.Collections.Generic;

namespace LoginCRUDConsola.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nickname { get; set; } = null!;

    public string Contrasenia { get; set; } = null!;
}
