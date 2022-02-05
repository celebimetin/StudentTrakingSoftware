﻿using OgrenciTakipYazilim.Data.Contexts.BaseContext;
using OgrenciTakipYazilim.Data.Migrations;
using OgrenciTakipYazilim.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OgrenciTakipYazilim.Data.Contexts
{
    public class OgrenciTakipContext : BaseDbContext<OgrenciTakipContext, Configuration>
    {
        public OgrenciTakipContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public OgrenciTakipContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Il>().HasMany(t => t.Ilce).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Banka>().HasMany(t => t.BankaSube).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Indirim>().HasMany(t => t.IndirimUygulamaHizmetBilgileri).WithRequired().WillCascadeOnDelete(true);
        }

        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Okul> Okul { get; set; }
        public DbSet<Filtre> Filtre { get; set; }
        public DbSet<AileBilgi> AileBilgi { get; set; }
        public DbSet<IptalNedeni> IptalNedeni { get; set; }
        public DbSet<YabanciDil> YabanciDil { get; set; }
        public DbSet<Tesvik> Tesvik { get; set; }
        public DbSet<Kontenjan> Kontenjan { get; set; }
        public DbSet<Rehber> Rehber { get; set; }
        public DbSet<SinifGrup> SinifGrup { get; set; }
        public DbSet<Meslek> Meslek { get; set; }
        public DbSet<Yakinlik> Yakinlik { get; set; }
        public DbSet<Isyeri> Isyeri { get; set; }
        public DbSet<Gorev> Gorev { get; set; }
        public DbSet<IndirimTuru> IndirimTuru { get; set; }
        public DbSet<Evrak> Evrak { get; set; }
        public DbSet<Promosyon> Promosyon { get; set; }
        public DbSet<Servis> Servis { get; set; }
        public DbSet<Sinif> Sinif { get; set; }
        public DbSet<HizmetTuru> HizmetTuru { get; set; }
        public DbSet<Hizmet> Hizmet { get; set; }
        public DbSet<OzelKod> OzelKod { get; set; }
        public DbSet<Kasa> Kasa { get; set; }
        public DbSet<Banka> Banka { get; set; }
        public DbSet<BankaSube> BankaSube { get; set; }
        public DbSet<Avukat> Avukat { get; set; }
        public DbSet<Cari> Cari { get; set; }
        public DbSet<OdemeTuru> OdemeTuru { get; set; }
        public DbSet<BankaHesap> BankaHesap { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Ogrenci> Ogrenci { get; set; }
        public DbSet<Indirim> Indirim { get; set; }
        public DbSet<Tahakkuk> Tahakkuk { get; set; }
        public DbSet<KardesBilgileri> KardesBilgileri { get; set; }
        public DbSet<AileBilgileri> AileBilgileri { get; set; }
        public DbSet<SinavBilgileri> SinavBilgileri { get; set; }
        public DbSet<EvrakBilgileri> EvrakBilgileri { get; set; }
        public DbSet<PromosyonBilgileri> PromosyonBilgileri { get; set; }
        public DbSet<IletisimBilgileri> IletisimBilgileri { get; set; }
        public DbSet<EposBilgileri> EposBilgileri { get; set; }
        public DbSet<BilgiNotlari> BilgiNotlari { get; set; }
        public DbSet<HizmetBilgileri> HizmetBilgileri { get; set; }
        public DbSet<IndirimBilgileri> IndirimBilgileri { get; set; }
        public DbSet<OdemeBilgileri> OdemeBilgileri { get; set; }
        public DbSet<GeriOdemeBilgileri> GeriOdemeBilgileri { get; set; }
        public DbSet<IndirimUygulamaHizmetBilgileri> IndirimUygulamaHizmetBilgileri { get; set; }
    }
}