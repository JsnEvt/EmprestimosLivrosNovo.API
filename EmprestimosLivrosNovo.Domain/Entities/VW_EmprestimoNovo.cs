﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EmprestimosLivrosNovo.Domain.Entities;

public partial class VW_EmprestimoNovo
{
    public long? IdEmprestimo { get; set; }

    public string CPF { get; set; }

    public string nomeCliente { get; set; }

    public string nomeLivro { get; set; }

    public int? EIDLivro { get; set; }

    public int? EIDCliente { get; set; }

    public DateTime? dataEmprestimo { get; set; }

    public DateTime? dataEntrega { get; set; }

    public bool? entregue { get; set; }
}