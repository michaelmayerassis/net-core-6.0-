using ApiData.Mapping;
using CustomDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CustomData.Context
{
    public class ApiContext : DbContext
    {

        //Configure DbSet
        public DbSet<UserEntity> Users { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configure ModelBuilder Entity Map
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);

        }

        //internal class SequenceValueGenerator : ValueGenerator<long>
        //{
        //    private readonly string _sequenceName;

        //    public SequenceValueGenerator(string sequenceName)
        //    {
        //        _sequenceName = sequenceName;
        //    }

        //    public override bool GeneratesTemporaryValues => false;

        //    public override long Next(EntityEntry entry)
        //    {
        //        using (var command = entry.Context.Database.GetDbConnection().CreateCommand())
        //        {
        //            command.CommandText = $"SELECT {_sequenceName}.NEXTVAL FROM DUAL";
        //            entry.Context.Database.OpenConnection();
        //            var reader = command.ExecuteScalar();
        //            return Convert.ToInt32(reader);
        //        }
        //    }

        //}
    }
}
