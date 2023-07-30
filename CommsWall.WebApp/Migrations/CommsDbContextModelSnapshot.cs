﻿// <auto-generated />
using System;
using CommsWall.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CommsWall.WebApp.Migrations
{
    [DbContext(typeof(CommsDbContext))]
    partial class CommsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CommsWall.Core.Aggregates.ChatGroupAg.AdminsAg.GroupAdmin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChatGroupId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePromoted")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChatGroupId");

                    b.HasIndex("UserID");

                    b.ToTable("GroupAdmin");
                });

            modelBuilder.Entity("CommsWall.Core.Aggregates.ChatGroupAg.ChatGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatorID")
                        .HasColumnType("int");

                    b.Property<string>("GroupDescription")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorID");

                    b.ToTable("ChatGroups");
                });

            modelBuilder.Entity("CommsWall.Core.Aggregates.ChatGroupAg.MembersAg.GroupMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChatGroupId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime2");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChatGroupId");

                    b.HasIndex("UserID");

                    b.ToTable("GroupMember");
                });

            modelBuilder.Entity("CommsWall.Core.Aggregates.ChatMessageAg.ChatMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("SessionID")
                        .HasColumnType("int");

                    b.Property<string>("TextMessage")
                        .IsRequired()
                        .HasMaxLength(4096)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SessionID");

                    b.ToTable("ChatMessages");
                });

            modelBuilder.Entity("CommsWall.Core.Aggregates.ChatSessionAg.ChatSession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<int>("TargetIdentifier")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SenderId");

                    b.ToTable("ChatSessions");
                });

            modelBuilder.Entity("CommsWall.Core.Aggregates.ChatSubscriberAg.ChatSubscriber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DateSubscribed")
                        .HasColumnType("datetime2");

                    b.Property<int>("SysIdentifier")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("ChatSubscribers");
                });

            modelBuilder.Entity("CommsWall.Core.Aggregates.NotificationsAg.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<int>("TargetUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TargetUserID");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("CommsWall.Core.Aggregates.ChatGroupAg.AdminsAg.GroupAdmin", b =>
                {
                    b.HasOne("CommsWall.Core.Aggregates.ChatGroupAg.ChatGroup", null)
                        .WithMany("GroupAdmins")
                        .HasForeignKey("ChatGroupId");

                    b.HasOne("CommsWall.Core.Aggregates.ChatSubscriberAg.ChatSubscriber", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CommsWall.Core.Aggregates.ChatGroupAg.ChatGroup", b =>
                {
                    b.HasOne("CommsWall.Core.Aggregates.ChatSubscriberAg.ChatSubscriber", "Creator")
                        .WithMany("UserGroups")
                        .HasForeignKey("CreatorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("CommsWall.Core.Aggregates.ChatGroupAg.MembersAg.GroupMember", b =>
                {
                    b.HasOne("CommsWall.Core.Aggregates.ChatGroupAg.ChatGroup", null)
                        .WithMany("GroupMembers")
                        .HasForeignKey("ChatGroupId");

                    b.HasOne("CommsWall.Core.Aggregates.ChatSubscriberAg.ChatSubscriber", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CommsWall.Core.Aggregates.ChatMessageAg.ChatMessage", b =>
                {
                    b.HasOne("CommsWall.Core.Aggregates.ChatSessionAg.ChatSession", "Session")
                        .WithMany("Messages")
                        .HasForeignKey("SessionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Session");
                });

            modelBuilder.Entity("CommsWall.Core.Aggregates.ChatSessionAg.ChatSession", b =>
                {
                    b.HasOne("CommsWall.Core.Aggregates.ChatSubscriberAg.ChatSubscriber", "Sender")
                        .WithMany("UserSessions")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("CommsWall.Core.Aggregates.NotificationsAg.Notification", b =>
                {
                    b.HasOne("CommsWall.Core.Aggregates.ChatSubscriberAg.ChatSubscriber", "TargetUser")
                        .WithMany("Notifications")
                        .HasForeignKey("TargetUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TargetUser");
                });

            modelBuilder.Entity("CommsWall.Core.Aggregates.ChatGroupAg.ChatGroup", b =>
                {
                    b.Navigation("GroupAdmins");

                    b.Navigation("GroupMembers");
                });

            modelBuilder.Entity("CommsWall.Core.Aggregates.ChatSessionAg.ChatSession", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("CommsWall.Core.Aggregates.ChatSubscriberAg.ChatSubscriber", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("UserGroups");

                    b.Navigation("UserSessions");
                });
#pragma warning restore 612, 618
        }
    }
}
