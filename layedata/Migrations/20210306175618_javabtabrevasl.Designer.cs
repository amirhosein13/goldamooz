// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using layedata;

namespace layedata.Migrations
{
    [DbContext(typeof(context))]
    [Migration("20210306175618_javabtabrevasl")]
    partial class javabtabrevasl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("layedata.blogmaghale", b =>
                {
                    b.Property<int>("blogmaghaleid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("matnkamelblog")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("matnkootahblog")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlimage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("userbombuserid")
                        .HasColumnType("int");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.Property<string>("usernamemodars")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("blogmaghaleid");

                    b.HasIndex("userbombuserid");

                    b.ToTable("blogmaghales");
                });

            modelBuilder.Entity("layedata.dore", b =>
                {
                    b.Property<int>("doreid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("doreakharinberoozresany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("dorebargozary")
                        .HasColumnType("bit");

                    b.Property<int>("dorehgaymat")
                        .HasColumnType("int");

                    b.Property<string>("doreimageurl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dorematn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doremodars")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dorename")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("doresath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("doretedaddaneshamooz")
                        .HasColumnType("int");

                    b.Property<int>("doretedadgalase")
                        .HasColumnType("int");

                    b.Property<string>("doretedadsaatbargozary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortmatn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("doreid");

                    b.ToTable("dores");
                });

            modelBuilder.Entity("layedata.doreuser", b =>
                {
                    b.Property<int>("doreuserid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Userbombuserid")
                        .HasColumnType("int");

                    b.Property<int>("doreid")
                        .HasColumnType("int");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("doreuserid");

                    b.HasIndex("Userbombuserid");

                    b.HasIndex("doreid");

                    b.ToTable("Doreusers");
                });

            modelBuilder.Entity("layedata.javab", b =>
                {
                    b.Property<int>("javabid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Userbombuserid")
                        .HasColumnType("int");

                    b.Property<string>("javabmatn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("javabtitr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("soalid")
                        .HasColumnType("int");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.Property<string>("zamimejavab")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("javabid");

                    b.HasIndex("Userbombuserid");

                    b.HasIndex("soalid");

                    b.ToTable("javabs");
                });

            modelBuilder.Entity("layedata.payuserdore", b =>
                {
                    b.Property<int>("payuserid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("doreid")
                        .HasColumnType("int");

                    b.Property<bool>("dorostbood")
                        .HasColumnType("bit");

                    b.Property<int>("ghaymat")
                        .HasColumnType("int");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("payuserid");

                    b.ToTable("payuserdores");
                });

            modelBuilder.Entity("layedata.role", b =>
                {
                    b.Property<int>("roleid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("rolename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roleid");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("layedata.soal", b =>
                {
                    b.Property<int>("soalid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Userbombuserid")
                        .HasColumnType("int");

                    b.Property<int>("doreid")
                        .HasColumnType("int");

                    b.Property<string>("soalmatn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soaltitr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.Property<string>("zamimesoal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("soalid");

                    b.HasIndex("Userbombuserid");

                    b.HasIndex("doreid");

                    b.ToTable("Soals");
                });

            modelBuilder.Entity("layedata.userbomb", b =>
                {
                    b.Property<int>("userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("roleid")
                        .HasColumnType("int");

                    b.Property<string>("useractivatecode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("useractiveaya")
                        .HasColumnType("bit");

                    b.Property<string>("useremail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("userpassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userid");

                    b.HasIndex("roleid");

                    b.ToTable("userbombs");
                });

            modelBuilder.Entity("layedata.videodore", b =>
                {
                    b.Property<int>("videoid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("doreid")
                        .HasColumnType("int");

                    b.Property<string>("urlvideo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("videoname")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("videoid");

                    b.HasIndex("doreid");

                    b.ToTable("videodores");
                });

            modelBuilder.Entity("layedata.blogmaghale", b =>
                {
                    b.HasOne("layedata.userbomb", "userbomb")
                        .WithMany("Blogmaghales")
                        .HasForeignKey("userbombuserid");

                    b.Navigation("userbomb");
                });

            modelBuilder.Entity("layedata.doreuser", b =>
                {
                    b.HasOne("layedata.userbomb", "Userbomb")
                        .WithMany("Doreusers")
                        .HasForeignKey("Userbombuserid");

                    b.HasOne("layedata.dore", "Dore")
                        .WithMany("Doreusers")
                        .HasForeignKey("doreid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dore");

                    b.Navigation("Userbomb");
                });

            modelBuilder.Entity("layedata.javab", b =>
                {
                    b.HasOne("layedata.userbomb", "Userbomb")
                        .WithMany("Javabs")
                        .HasForeignKey("Userbombuserid");

                    b.HasOne("layedata.soal", "Soal")
                        .WithMany("Javabs")
                        .HasForeignKey("soalid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Soal");

                    b.Navigation("Userbomb");
                });

            modelBuilder.Entity("layedata.soal", b =>
                {
                    b.HasOne("layedata.userbomb", "Userbomb")
                        .WithMany("Soals")
                        .HasForeignKey("Userbombuserid");

                    b.HasOne("layedata.dore", "Dore")
                        .WithMany("Soals")
                        .HasForeignKey("doreid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dore");

                    b.Navigation("Userbomb");
                });

            modelBuilder.Entity("layedata.userbomb", b =>
                {
                    b.HasOne("layedata.role", "role")
                        .WithMany("userbombs")
                        .HasForeignKey("roleid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");
                });

            modelBuilder.Entity("layedata.videodore", b =>
                {
                    b.HasOne("layedata.dore", "dore")
                        .WithMany("videodores")
                        .HasForeignKey("doreid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dore");
                });

            modelBuilder.Entity("layedata.dore", b =>
                {
                    b.Navigation("Doreusers");

                    b.Navigation("Soals");

                    b.Navigation("videodores");
                });

            modelBuilder.Entity("layedata.role", b =>
                {
                    b.Navigation("userbombs");
                });

            modelBuilder.Entity("layedata.soal", b =>
                {
                    b.Navigation("Javabs");
                });

            modelBuilder.Entity("layedata.userbomb", b =>
                {
                    b.Navigation("Blogmaghales");

                    b.Navigation("Doreusers");

                    b.Navigation("Javabs");

                    b.Navigation("Soals");
                });
#pragma warning restore 612, 618
        }
    }
}
