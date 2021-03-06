﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using testgreenfish.Data;

namespace testgreenfish.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20171111152628_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("testgreenfish.Models.Email", b =>
                {
                    b.Property<int>("emailId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("address")
                        .IsRequired();

                    b.HasKey("emailId");

                    b.ToTable("Emails");
                });
#pragma warning restore 612, 618
        }
    }
}
