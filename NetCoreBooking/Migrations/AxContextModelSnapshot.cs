﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreBooking.Data;

namespace NetCoreBooking.Migrations
{
    [DbContext(typeof(AxContext))]
    partial class AxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Booking_Room.Models.Booking", b =>
                {
                    b.Property<string>("booking_id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("User_sUser_id");

                    b.Property<string>("booking_title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("end_time")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("note")
                        .HasMaxLength(1000);

                    b.Property<string>("participants")
                        .HasMaxLength(1000);

                    b.Property<string>("room_id")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<DateTime>("start_time")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("users_id")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("booking_id");

                    b.HasIndex("User_sUser_id");

                    b.HasIndex("room_id");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("Booking_Room.Models.Room", b =>
                {
                    b.Property<string>("room_id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<int>("capacity");

                    b.Property<string>("room_name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("room_id");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("Booking_Room.Models.User_s", b =>
                {
                    b.Property<string>("User_id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("User_name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("User_id");

                    b.ToTable("User_s");
                });

            modelBuilder.Entity("Booking_Room.Models.Booking", b =>
                {
                    b.HasOne("Booking_Room.Models.User_s", "User_s")
                        .WithMany("Bookings")
                        .HasForeignKey("User_sUser_id");

                    b.HasOne("Booking_Room.Models.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("room_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
