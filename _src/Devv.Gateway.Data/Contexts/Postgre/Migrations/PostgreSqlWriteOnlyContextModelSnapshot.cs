﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Devv.Gateway.Data.Contexts.Postgre;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Devv.Gateway.Data.Contexts.Postgre.Migrations
{
    [DbContext(typeof(PostgreSqlWriteOnlyContext))]
    partial class PostgreSqlWriteOnlyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Devv.Gateway.Data.Entities.ActiveHealthCheckConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Enabled")
                        .HasColumnType("boolean");

                    b.Property<Guid>("HealthCheckConfigId")
                        .HasColumnType("uuid");

                    b.Property<TimeSpan?>("Interval")
                        .IsRequired()
                        .HasColumnType("interval");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Policy")
                        .HasColumnType("text");

                    b.Property<string>("Query")
                        .HasColumnType("text");

                    b.Property<TimeSpan?>("Timeout")
                        .HasColumnType("interval");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("HealthCheckConfigId")
                        .IsUnique();

                    b.ToTable("ActiveHealthChecks");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.CertificateConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AwsCertificateName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AwsRegion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("HostId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("KeyVaultCertificateName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KeyVaultName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KeyVaultUri")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("LocalPath")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<int>("SourceType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("HostId")
                        .IsUnique();

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.ClusterConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("HostId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LoadBalancingPolicy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("HostId")
                        .IsUnique();

                    b.ToTable("Clusters");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.DestinationConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ClusterConfigId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Health")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ClusterConfigId");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.HeaderMatchConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsCaseSensitive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid>("MatchConfigId")
                        .HasColumnType("uuid");

                    b.Property<string>("Mode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Values")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MatchConfigId");

                    b.ToTable("HeaderMatches");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.HealthCheckConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ClusterConfigId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ClusterConfigId")
                        .IsUnique();

                    b.ToTable("HealthChecks");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.Host", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CertificateId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ClusterId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("HostName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.HasKey("Id");

                    b.ToTable("Hosts");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.HttpClientConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ClusterConfigId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("DangerousAcceptAnyServerCertificate")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("EnableMultipleHttp2Connections")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("MaxConnectionsPerServer")
                        .HasColumnType("integer");

                    b.Property<string>("RequestHeaderEncoding")
                        .HasColumnType("text");

                    b.Property<string>("ResponseHeaderEncoding")
                        .HasColumnType("text");

                    b.Property<string>("SslProtocols")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ClusterConfigId")
                        .IsUnique();

                    b.ToTable("HttpClients");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.HttpRequestConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<TimeSpan>("ActivityTimeout")
                        .HasColumnType("interval");

                    b.Property<bool>("AllowResponseBuffering")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ClusterConfigId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VersionPolicy")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ClusterConfigId")
                        .IsUnique();

                    b.ToTable("HttpRequests");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.MatchConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<List<string>>("Hosts")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<List<string>>("Methods")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RouteConfigId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RouteConfigId")
                        .IsUnique();

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.MetadataConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ClusterConfigId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("RouteConfigId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ClusterConfigId")
                        .IsUnique();

                    b.HasIndex("RouteConfigId")
                        .IsUnique();

                    b.ToTable("Metadata");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.PassiveHealthCheckConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Enabled")
                        .HasColumnType("boolean");

                    b.Property<Guid>("HealthCheckConfigId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Policy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeSpan?>("ReactivationPeriod")
                        .HasColumnType("interval");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("HealthCheckConfigId")
                        .IsUnique();

                    b.ToTable("PassiveHealthChecks");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.QueryParameterMatchConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsCaseSensitive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid>("MatchConfigId")
                        .HasColumnType("uuid");

                    b.Property<string>("Mode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Values")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MatchConfigId");

                    b.ToTable("QueryParameterMatches");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.RouteConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AuthorizationPolicy")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<Guid>("ClusterId")
                        .HasColumnType("uuid");

                    b.Property<string>("CorsPolicy")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("HostId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long?>("MaxRequestBodySize")
                        .HasColumnType("bigint");

                    b.Property<int?>("Order")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("HostId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.SessionAffinityConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ClusterConfigId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Enabled")
                        .HasColumnType("boolean");

                    b.Property<string>("FailurePolicy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Policy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Settings")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ClusterConfigId")
                        .IsUnique();

                    b.ToTable("SessionAffinities");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.TransformConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("RequestHeader")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RouteConfigId")
                        .HasColumnType("uuid");

                    b.Property<string>("Set")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RouteConfigId");

                    b.ToTable("Transforms");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.ActiveHealthCheckConfig", b =>
                {
                    b.HasOne("Devv.Gateway.Data.Entities.HealthCheckConfig", "HealthCheckConfig")
                        .WithOne("Active")
                        .HasForeignKey("Devv.Gateway.Data.Entities.ActiveHealthCheckConfig", "HealthCheckConfigId");

                    b.Navigation("HealthCheckConfig");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.CertificateConfig", b =>
                {
                    b.HasOne("Devv.Gateway.Data.Entities.Host", "Host")
                        .WithOne("Certificate")
                        .HasForeignKey("Devv.Gateway.Data.Entities.CertificateConfig", "HostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Host");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.ClusterConfig", b =>
                {
                    b.HasOne("Devv.Gateway.Data.Entities.Host", "Host")
                        .WithOne("Cluster")
                        .HasForeignKey("Devv.Gateway.Data.Entities.ClusterConfig", "HostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Host");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.DestinationConfig", b =>
                {
                    b.HasOne("Devv.Gateway.Data.Entities.ClusterConfig", "ClusterConfig")
                        .WithMany("Destinations")
                        .HasForeignKey("ClusterConfigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClusterConfig");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.HeaderMatchConfig", b =>
                {
                    b.HasOne("Devv.Gateway.Data.Entities.MatchConfig", "MatchConfig")
                        .WithMany("Headers")
                        .HasForeignKey("MatchConfigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MatchConfig");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.HealthCheckConfig", b =>
                {
                    b.HasOne("Devv.Gateway.Data.Entities.ClusterConfig", "ClusterConfig")
                        .WithOne("HealthCheck")
                        .HasForeignKey("Devv.Gateway.Data.Entities.HealthCheckConfig", "ClusterConfigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClusterConfig");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.HttpClientConfig", b =>
                {
                    b.HasOne("Devv.Gateway.Data.Entities.ClusterConfig", "ClusterConfig")
                        .WithOne("HttpClient")
                        .HasForeignKey("Devv.Gateway.Data.Entities.HttpClientConfig", "ClusterConfigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClusterConfig");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.HttpRequestConfig", b =>
                {
                    b.HasOne("Devv.Gateway.Data.Entities.ClusterConfig", "ClusterConfig")
                        .WithOne("HttpRequest")
                        .HasForeignKey("Devv.Gateway.Data.Entities.HttpRequestConfig", "ClusterConfigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClusterConfig");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.MatchConfig", b =>
                {
                    b.HasOne("Devv.Gateway.Data.Entities.RouteConfig", "RouteConfig")
                        .WithOne("Match")
                        .HasForeignKey("Devv.Gateway.Data.Entities.MatchConfig", "RouteConfigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RouteConfig");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.MetadataConfig", b =>
                {
                    b.HasOne("Devv.Gateway.Data.Entities.ClusterConfig", "ClusterConfig")
                        .WithOne("Metadata")
                        .HasForeignKey("Devv.Gateway.Data.Entities.MetadataConfig", "ClusterConfigId");

                    b.HasOne("Devv.Gateway.Data.Entities.RouteConfig", "RouteConfig")
                        .WithOne("Metadata")
                        .HasForeignKey("Devv.Gateway.Data.Entities.MetadataConfig", "RouteConfigId");

                    b.Navigation("ClusterConfig");

                    b.Navigation("RouteConfig");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.PassiveHealthCheckConfig", b =>
                {
                    b.HasOne("Devv.Gateway.Data.Entities.HealthCheckConfig", "HealthCheckConfig")
                        .WithOne("Passive")
                        .HasForeignKey("Devv.Gateway.Data.Entities.PassiveHealthCheckConfig", "HealthCheckConfigId");

                    b.Navigation("HealthCheckConfig");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.QueryParameterMatchConfig", b =>
                {
                    b.HasOne("Devv.Gateway.Data.Entities.MatchConfig", "MatchConfig")
                        .WithMany("QueryParameters")
                        .HasForeignKey("MatchConfigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MatchConfig");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.RouteConfig", b =>
                {
                    b.HasOne("Devv.Gateway.Data.Entities.Host", "Host")
                        .WithMany("Routes")
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Host");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.SessionAffinityConfig", b =>
                {
                    b.HasOne("Devv.Gateway.Data.Entities.ClusterConfig", "ClusterConfig")
                        .WithOne("SessionAffinity")
                        .HasForeignKey("Devv.Gateway.Data.Entities.SessionAffinityConfig", "ClusterConfigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClusterConfig");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.TransformConfig", b =>
                {
                    b.HasOne("Devv.Gateway.Data.Entities.RouteConfig", "RouteConfig")
                        .WithMany("Transforms")
                        .HasForeignKey("RouteConfigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RouteConfig");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.ClusterConfig", b =>
                {
                    b.Navigation("Destinations");

                    b.Navigation("HealthCheck");

                    b.Navigation("HttpClient");

                    b.Navigation("HttpRequest");

                    b.Navigation("Metadata");

                    b.Navigation("SessionAffinity");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.HealthCheckConfig", b =>
                {
                    b.Navigation("Active");

                    b.Navigation("Passive");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.Host", b =>
                {
                    b.Navigation("Certificate")
                        .IsRequired();

                    b.Navigation("Cluster")
                        .IsRequired();

                    b.Navigation("Routes");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.MatchConfig", b =>
                {
                    b.Navigation("Headers");

                    b.Navigation("QueryParameters");
                });

            modelBuilder.Entity("Devv.Gateway.Data.Entities.RouteConfig", b =>
                {
                    b.Navigation("Match");

                    b.Navigation("Metadata");

                    b.Navigation("Transforms");
                });
#pragma warning restore 612, 618
        }
    }
}
