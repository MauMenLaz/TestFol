using ConexionDatos.EDM;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ConexionDatos
{
    //Clase encargada a conectarse con la base de datos mediante entity framework
    public class Repositorio
    {
        //Metodo para obtener las areas laborales 
        public ExaCArea[] obtieneAreas()
        {
            List<ExaCArea> lst = new List<ExaCArea>();
            using (ExamenPdpContext db = new ExamenPdpContext())
            {
                lst = (from d in db.ExaCAreas select d).ToList();
            }
            return lst.ToArray();
        }


       

        //Metodo para obtener los empleados
        public List<ExaTEmpleado2> obtieneEmpleados(int id)
        {
            List<ExaTEmpleado> lst = new List<ExaTEmpleado>();
            using (ExamenPdpContext db = new ExamenPdpContext())
            {
                if (id == 0)
                {
                    
                    using (ExamenPdpContext emp = new ExamenPdpContext())
                    {
                        var query = from e in emp.ExaTEmpleados
                                    where ((bool)e.Estatus)
                                    join a in emp.ExaCAreas on e.Area equals a.IdArea
                                    select new ExaTEmpleado2
                                    {
                                        IdEmpleado = e.IdEmpleado,
                                        Nombre = e.Nombre,
                                        Apaterno = e.Apaterno,
                                        Amaterno = e.Amaterno,
                                        Area = e.Area,
                                        FechaCreacion = e.FechaCreacion,
                                        FechaNacimiento = e.FechaNacimiento,
                                        Sueldo = e.Sueldo,
                                        Estatus = e.Estatus,
                                        areaDesc = a.Area,
                                    };
                        return query.ToList();

                    }


                }
                else
                {
                    using (ExamenPdpContext emp = new ExamenPdpContext())
                    {
                        var query = from e in emp.ExaTEmpleados
                                    join a in emp.ExaCAreas on e.Area equals a.IdArea
                                    where e.IdEmpleado == id
                                    select new ExaTEmpleado2
                                    {
                                        IdEmpleado = e.IdEmpleado,
                                        Nombre = e.Nombre,
                                        Apaterno = e.Apaterno,
                                        Amaterno = e.Amaterno,
                                        Area = e.Area,
                                        FechaCreacion = e.FechaCreacion,
                                        FechaNacimiento = e.FechaNacimiento,
                                        Sueldo = e.Sueldo,
                                        Estatus = e.Estatus,
                                        areaDesc = a.Area,
                                    };
                        return query.ToList();
                    }
                }
            }

        }

        public string ingModEmpleado(ExaTEmpleado emp)
        {
            try
            {
                using (ExamenPdpContext db = new ExamenPdpContext())
                {
                    if (emp.IdEmpleado == 0)
                    {
                        db.ExaTEmpleados.Add(emp);
                    }
                    else
                    {
                        ExaTEmpleado empl = db.ExaTEmpleados.FirstOrDefault(x => x.IdEmpleado == emp.IdEmpleado);
                        if (empl != null)
                        {
                            empl.Sueldo = emp.Sueldo;
                            empl.Area = emp.Area;
                            empl.Nombre = emp.Nombre;
                            empl.Apaterno = emp.Apaterno;
                            empl.Amaterno = emp.Amaterno;
                            empl.Estatus = emp.Estatus;
                            empl.FechaNacimiento = emp.FechaNacimiento;
                        }
                    }
                    db.SaveChanges();

                }
                return "Exito";
            }
            catch (Exception ex)
            {
                return "Algo fallo- " + ex.Message;
            }
        }

    }
}