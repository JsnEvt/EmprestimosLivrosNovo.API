﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EmprestimosLivrosNovo.Domain.Entities;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public string Email { get; set; }

    public byte[] PasswordHash { get; set; }

    public byte[] PasswordSalt { get; set; }
}