﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Back.Data.Models;

public partial class Directore
{
    public int IdDirector { get; set; }

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public DateTime? FechaNac { get; set; }

    public virtual ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
}