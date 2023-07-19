﻿// <auto-generated />
using System;
using HotelBooking.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelBooking.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20230531080255_changedColumn")]
    partial class changedColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelBooking.DataModels.Bill", b =>
                {
                    b.Property<Guid>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckinDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckoutDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PaymentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TaxAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BillId");

                    b.HasIndex("PaymentId")
                        .IsUnique();

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("HotelBooking.DataModels.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HotelBooking.DataModels.Guest", b =>
                {
                    b.Property<Guid>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GuestId");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("HotelBooking.DataModels.Payment", b =>
                {
                    b.Property<Guid>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("CreditCardDetalis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PaymentTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PaymentId");

                    b.HasIndex("ReservationId")
                        .IsUnique();

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("HotelBooking.DataModels.Reservation", b =>
                {
                    b.Property<Guid>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GuestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NumberOfAdults")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfChildren")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfNights")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("GuestId");

                    b.HasIndex("RoomNumber");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("HotelBooking.DataModels.Room", b =>
                {
                    b.Property<int>("RoomNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomNumber"));

                    b.Property<string>("AvailableStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomNumber");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HotelBooking.DataModels.Staff", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("HotelBooking.DataModels.Bill", b =>
                {
                    b.HasOne("HotelBooking.DataModels.Payment", "payment")
                        .WithOne("bill")
                        .HasForeignKey("HotelBooking.DataModels.Bill", "PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("payment");
                });

            modelBuilder.Entity("HotelBooking.DataModels.Payment", b =>
                {
                    b.HasOne("HotelBooking.DataModels.Reservation", "Reservation")
                        .WithOne("Payment")
                        .HasForeignKey("HotelBooking.DataModels.Payment", "ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("HotelBooking.DataModels.Reservation", b =>
                {
                    b.HasOne("HotelBooking.DataModels.Guest", "Guest")
                        .WithMany("Reservations")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelBooking.DataModels.Room", "Room")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guest");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HotelBooking.DataModels.Guest", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("HotelBooking.DataModels.Payment", b =>
                {
                    b.Navigation("bill")
                        .IsRequired();
                });

            modelBuilder.Entity("HotelBooking.DataModels.Reservation", b =>
                {
                    b.Navigation("Payment")
                        .IsRequired();
                });

            modelBuilder.Entity("HotelBooking.DataModels.Room", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
