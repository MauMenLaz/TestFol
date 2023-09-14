using System;
using System.Collections.Generic;

namespace ConexionDatos.EDM;

public partial class ExaCArea
{
    public int IdArea { get; set; }

    public string Area { get; set; } = null!;

    public bool? Estatus { get; set; }
}
