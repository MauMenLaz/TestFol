using System;
using System.Collections.Generic;

namespace ConexionDatos.EDM;

public partial class ExaTEmpleado
{
    public int IdEmpleado { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apaterno { get; set; } = null!;

    public string? Amaterno { get; set; }

    public int Area { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public decimal Sueldo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Estatus { get; set; }
}
