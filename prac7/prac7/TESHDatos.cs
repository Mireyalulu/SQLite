using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace prac7
{
   public class TESHDatos
    {
string matricula;
string nombre;
string apellido;
string direccion;
string telefono;
string carrera;
string semestre;
string correo;
string github;


[PrimaryKey, Unique, MaxLength(8)]
public string Matricula
{
    get { return matricula; }
    set { matricula = value; }
}

[Column("Nombre"), MaxLength(20)]
public string Nombre
{
    get { return nombre; }
    set { nombre = value; }
}

[Column("Apellido"), MaxLength(20)]
public string Apellido
{
    get { return apellido; }
    set { apellido = value; }
}

[Column("Direccion"), MaxLength(20)]
public string Direccion
{
    get { return direccion; }
    set { direccion = value; }
}

[Column("Telefono"), MaxLength(20)]
public string Telefono
{
    get { return telefono; }
    set { telefono = value; }
}

[Column("Carrera"), MaxLength(20)]
public string Carrera
{
    get { return carrera; }
    set { carrera = value; }
}

[Column("Semestre"), MaxLength(20)]
public string Semestre
{
    get { return semestre; }
    set { semestre = value; }
}

[Column("Correo"), MaxLength(20)]
public string Correo
{
    get { return correo; }
    set { correo = value; }
}

[Column("Github"), MaxLength(20)]
public string Github
{
    get { return github; }
    set { github = value; }
}




    }
}