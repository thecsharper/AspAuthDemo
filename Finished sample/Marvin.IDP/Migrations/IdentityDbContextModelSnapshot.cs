﻿using Marvin.IDP.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable disable

namespace Marvin.IDP.Migrations
{
    [DbContext(typeof(IdentityDbContext))]
    partial class IdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Marvin.IDP.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SecurityCode")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("SecurityCodeExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Subject")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Active = true,
                            ConcurrencyStamp = "85f9b3b9-9b38-405a-bb29-ad05f5097301",
                            Email = "david@someprovider.com",
                            Password = "AQAAAAEAACcQAAAAEIi0HEeTvqcxwhA+dR/RKOEIfdGn1VIKy0P+AhKOp5vIdsb80zmPxqbhxllt5AmkKg==",
                            SecurityCodeExpirationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "d860efca-22d9-47fd-8249-791ba61b07c7",
                            UserName = "David"
                        },
                        new
                        {
                            Id = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Active = true,
                            ConcurrencyStamp = "e13615bb-f503-45c8-a503-f87624d28b4f",
                            Email = "emma@someprovider.com",
                            Password = "AQAAAAEAACcQAAAAEHgXILmaP4pu/Kz8M2cASmfD/XsHykcmTNyFTvQQiwyWaLWjWAlxBH1L5pQfSyRYqw==",
                            SecurityCodeExpirationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                            UserName = "Emma"
                        });
                });

            modelBuilder.Entity("Marvin.IDP.Entities.UserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eb58baa5-fdfc-412a-9a02-0a5bdb92d62b"),
                            ConcurrencyStamp = "661c712d-31ff-45c7-9e30-50694e90e94b",
                            Type = "given_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "David"
                        },
                        new
                        {
                            Id = new Guid("e249bd8e-eeed-4b04-9fdc-9199d17c9505"),
                            ConcurrencyStamp = "2a5cbd03-5c8f-4a07-a347-b3b40903d366",
                            Type = "family_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Flagg"
                        },
                        new
                        {
                            Id = new Guid("4aa5e6f5-e0f4-4572-9e05-f3851f5b9614"),
                            ConcurrencyStamp = "dc4f8f58-d0d3-41b1-beab-9262ea4efe61",
                            Type = "country",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "nl"
                        },
                        new
                        {
                            Id = new Guid("de6bbc6e-6cb8-42cf-86dc-62d8245137d9"),
                            ConcurrencyStamp = "961ad9f3-9a17-4498-a9a2-3288c067e710",
                            Type = "role",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "FreeUser"
                        },
                        new
                        {
                            Id = new Guid("a17fb264-0764-4175-bdbd-12bf344dcb0c"),
                            ConcurrencyStamp = "02e615df-eec6-4a5b-8ef2-b215168a476c",
                            Type = "given_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Emma"
                        },
                        new
                        {
                            Id = new Guid("0f2bd3d8-4c17-47a1-839e-8eeb5debc964"),
                            ConcurrencyStamp = "19fd8dc7-987b-4213-aa6f-4b35c272ccef",
                            Type = "family_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Flagg"
                        },
                        new
                        {
                            Id = new Guid("97a5c26a-e753-46ed-a0f5-cd9bb504340a"),
                            ConcurrencyStamp = "20c0920d-d59c-4cc9-b7f6-78157f8cce02",
                            Type = "country",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "be"
                        },
                        new
                        {
                            Id = new Guid("8fabfb10-7cae-45e2-ae42-bf30f9145018"),
                            ConcurrencyStamp = "f7c7c00f-b69c-4ccb-86a8-cb6820b2e952",
                            Type = "role",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "PayingUser"
                        });
                });

            modelBuilder.Entity("Marvin.IDP.Entities.UserLogin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ProviderIdentityKey")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Marvin.IDP.Entities.UserSecret", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secret")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserSecrets");
                });

            modelBuilder.Entity("Marvin.IDP.Entities.UserClaim", b =>
                {
                    b.HasOne("Marvin.IDP.Entities.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Marvin.IDP.Entities.UserLogin", b =>
                {
                    b.HasOne("Marvin.IDP.Entities.User", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Marvin.IDP.Entities.UserSecret", b =>
                {
                    b.HasOne("Marvin.IDP.Entities.User", "User")
                        .WithMany("Secrets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Marvin.IDP.Entities.User", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Logins");

                    b.Navigation("Secrets");
                });
#pragma warning restore 612, 618
        }
    }
}
