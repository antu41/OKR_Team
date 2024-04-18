﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OKR.Data;

#nullable disable

namespace OKR.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OKR.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Designation")
                        .HasColumnType("text");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("OKR.Models.Milestone", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("ProjectId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Milestones");
                });

            modelBuilder.Entity("OKR.Models.MilestoneSubTask", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("MilestoneTaskId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MilestoneTaskId");

                    b.ToTable("MilestoneSubTasks");
                });

            modelBuilder.Entity("OKR.Models.MilestoneTask", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("MilestoneId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MilestoneId");

                    b.ToTable("MilestoneTasks");
                });

            modelBuilder.Entity("OKR.Models.Project", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("FilePath")
                        .HasColumnType("text");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("OKR.Models.TeamMember", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("AssigneeId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AssigneeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("TeamMembers");
                });

            modelBuilder.Entity("OKR.Models.Milestone", b =>
                {
                    b.HasOne("OKR.Models.Project", "Project")
                        .WithMany("Milestones")
                        .HasForeignKey("ProjectId");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("OKR.Models.MilestoneSubTask", b =>
                {
                    b.HasOne("OKR.Models.MilestoneTask", "MilestoneTask")
                        .WithMany("SubTasks")
                        .HasForeignKey("MilestoneTaskId");

                    b.Navigation("MilestoneTask");
                });

            modelBuilder.Entity("OKR.Models.MilestoneTask", b =>
                {
                    b.HasOne("OKR.Models.Milestone", "Milestone")
                        .WithMany("MilestoneTasks")
                        .HasForeignKey("MilestoneId");

                    b.Navigation("Milestone");
                });

            modelBuilder.Entity("OKR.Models.TeamMember", b =>
                {
                    b.HasOne("OKR.Models.Employee", "Assignee")
                        .WithMany()
                        .HasForeignKey("AssigneeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OKR.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("OKR.Models.Milestone", b =>
                {
                    b.Navigation("MilestoneTasks");
                });

            modelBuilder.Entity("OKR.Models.MilestoneTask", b =>
                {
                    b.Navigation("SubTasks");
                });

            modelBuilder.Entity("OKR.Models.Project", b =>
                {
                    b.Navigation("Milestones");
                });
#pragma warning restore 612, 618
        }
    }
}
