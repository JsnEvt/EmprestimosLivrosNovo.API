﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EmprestimosLivrosNovo.Domain.Entities;

public partial class Livro
{
    public int LivroId { get; set; }

    public string nome { get; set; }

    public string autor { get; set; }

    public string editora { get; set; }

    public DateTime anoPublicacao { get; set; }

    public string edicao { get; set; }

    public virtual ICollection<Emprestimo> Emprestimo { get; set; } = new List<Emprestimo>();
}