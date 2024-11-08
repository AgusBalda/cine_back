﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Back.Data.Models;

public partial class Pelicula
{
    public int CodPelicula { get; set; }

    public string Titulo { get; set; }

    public DateTime? FechaEstreno { get; set; }

    public int? DuracionMin { get; set; }

    public int? IdGenero { get; set; }

    public int? IdClasificacion { get; set; }

    public int? IdDirector { get; set; }

    public int? IdIdioma { get; set; }

    public virtual ICollection<Funcione> Funciones { get; set; } = new List<Funcione>();

    public virtual ClasificacionesEdad IdClasificacionNavigation { get; set; }

    public virtual Directore IdDirectorNavigation { get; set; }

    public virtual Genero IdGeneroNavigation { get; set; }

    public virtual Idioma IdIdiomaNavigation { get; set; }
}