﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Back.Data.Models;

public partial class Funcione
{
    public int? CodFuncion { get; set; }

    public TimeOnly? HoraInicio { get; set; }

    public decimal? Precio { get; set; }

    public bool? Subtitulo { get; set; }

    public int? Dia { get; set; }

    public int? CodPelicula { get; set; }

    public int? IdSala { get; set; }

    public int? CodPromocion { get; set; }

    public int? IdTipoFuncion { get; set; }

    public bool? Estado { get; set; }

    [JsonIgnore]
    public virtual Pelicula CodPeliculaNavigation { get; set; }
    [JsonIgnore]
    public virtual Promocione CodPromocionNavigation { get; set; }
    [JsonIgnore]
    public virtual Sala IdSalaNavigation { get; set; }
    [JsonIgnore]
    public virtual TiposFuncion IdTipoFuncionNavigation { get; set; }
    [JsonIgnore]
    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}