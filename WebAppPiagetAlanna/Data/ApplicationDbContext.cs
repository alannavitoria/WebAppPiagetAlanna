﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppPiagetAlanna.Models;

namespace WebAppPiagetAlanna.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<Aluno> Aluno { get; set; } = default!;

public DbSet<Professor> Professor { get; set; } = default!;
}
