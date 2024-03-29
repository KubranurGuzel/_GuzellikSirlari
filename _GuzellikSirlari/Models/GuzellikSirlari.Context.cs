﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _GuzellikSirlari.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GuzellikSirlariEntities1 : DbContext
    {
        public GuzellikSirlariEntities1()
            : base("name=GuzellikSirlariEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CiltBakimi> CiltBakimi { get; set; }
        public virtual DbSet<CiltSagligi> CiltSagligi { get; set; }
        public virtual DbSet<CiltSorunlari> CiltSorunlari { get; set; }
        public virtual DbSet<DogalMaskeler> DogalMaskeler { get; set; }
        public virtual DbSet<Iletisim> Iletisim { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int Sp_CiltBakimiEkle(string ciltBakimiAdi, string ciltBakimiAciklama)
        {
            var ciltBakimiAdiParameter = ciltBakimiAdi != null ?
                new ObjectParameter("CiltBakimiAdi", ciltBakimiAdi) :
                new ObjectParameter("CiltBakimiAdi", typeof(string));
    
            var ciltBakimiAciklamaParameter = ciltBakimiAciklama != null ?
                new ObjectParameter("CiltBakimiAciklama", ciltBakimiAciklama) :
                new ObjectParameter("CiltBakimiAciklama", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_CiltBakimiEkle", ciltBakimiAdiParameter, ciltBakimiAciklamaParameter);
        }
    
        public virtual ObjectResult<Sp_CiltBakimiList_Result> Sp_CiltBakimiList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_CiltBakimiList_Result>("Sp_CiltBakimiList");
        }
    
        public virtual ObjectResult<Sp_CiltBakimiSec_Result> Sp_CiltBakimiSec(Nullable<int> ciltBakimiId)
        {
            var ciltBakimiIdParameter = ciltBakimiId.HasValue ?
                new ObjectParameter("CiltBakimiId", ciltBakimiId) :
                new ObjectParameter("CiltBakimiId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_CiltBakimiSec_Result>("Sp_CiltBakimiSec", ciltBakimiIdParameter);
        }
    
        public virtual int SP_CiltBakimiSil(Nullable<int> ciltBakimiId)
        {
            var ciltBakimiIdParameter = ciltBakimiId.HasValue ?
                new ObjectParameter("CiltBakimiId", ciltBakimiId) :
                new ObjectParameter("CiltBakimiId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CiltBakimiSil", ciltBakimiIdParameter);
        }
    
        public virtual int Sp_CiltSagligiEkle(string ciltSagligiAdi, string ciltSagligiAciklama)
        {
            var ciltSagligiAdiParameter = ciltSagligiAdi != null ?
                new ObjectParameter("CiltSagligiAdi", ciltSagligiAdi) :
                new ObjectParameter("CiltSagligiAdi", typeof(string));
    
            var ciltSagligiAciklamaParameter = ciltSagligiAciklama != null ?
                new ObjectParameter("CiltSagligiAciklama", ciltSagligiAciklama) :
                new ObjectParameter("CiltSagligiAciklama", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_CiltSagligiEkle", ciltSagligiAdiParameter, ciltSagligiAciklamaParameter);
        }
    
        public virtual ObjectResult<Sp_CiltSagligiList_Result> Sp_CiltSagligiList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_CiltSagligiList_Result>("Sp_CiltSagligiList");
        }
    
        public virtual ObjectResult<Sp_CiltSagligiSec_Result> Sp_CiltSagligiSec(Nullable<int> ciltSagligiId)
        {
            var ciltSagligiIdParameter = ciltSagligiId.HasValue ?
                new ObjectParameter("CiltSagligiId", ciltSagligiId) :
                new ObjectParameter("CiltSagligiId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_CiltSagligiSec_Result>("Sp_CiltSagligiSec", ciltSagligiIdParameter);
        }
    
        public virtual int SP_CiltSagligiSil(Nullable<int> ciltSagligiId)
        {
            var ciltSagligiIdParameter = ciltSagligiId.HasValue ?
                new ObjectParameter("CiltSagligiId", ciltSagligiId) :
                new ObjectParameter("CiltSagligiId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CiltSagligiSil", ciltSagligiIdParameter);
        }
    
        public virtual int Sp_CiltSorunlariEkle(string ciltSorunlariAdi, string ciltSorunlariAciklama)
        {
            var ciltSorunlariAdiParameter = ciltSorunlariAdi != null ?
                new ObjectParameter("CiltSorunlariAdi", ciltSorunlariAdi) :
                new ObjectParameter("CiltSorunlariAdi", typeof(string));
    
            var ciltSorunlariAciklamaParameter = ciltSorunlariAciklama != null ?
                new ObjectParameter("CiltSorunlariAciklama", ciltSorunlariAciklama) :
                new ObjectParameter("CiltSorunlariAciklama", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_CiltSorunlariEkle", ciltSorunlariAdiParameter, ciltSorunlariAciklamaParameter);
        }
    
        public virtual ObjectResult<Sp_CiltSorunlariList_Result> Sp_CiltSorunlariList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_CiltSorunlariList_Result>("Sp_CiltSorunlariList");
        }
    
        public virtual ObjectResult<Sp_CiltSorunlariSec_Result> Sp_CiltSorunlariSec(Nullable<int> ciltSorunlariId)
        {
            var ciltSorunlariIdParameter = ciltSorunlariId.HasValue ?
                new ObjectParameter("CiltSorunlariId", ciltSorunlariId) :
                new ObjectParameter("CiltSorunlariId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_CiltSorunlariSec_Result>("Sp_CiltSorunlariSec", ciltSorunlariIdParameter);
        }
    
        public virtual int SP_CiltSorunlariSil(Nullable<int> ciltSorunlariId)
        {
            var ciltSorunlariIdParameter = ciltSorunlariId.HasValue ?
                new ObjectParameter("CiltSorunlariId", ciltSorunlariId) :
                new ObjectParameter("CiltSorunlariId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CiltSorunlariSil", ciltSorunlariIdParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int Sp_DogalMaskelerEkle(string dogalMaskelerAdi, string dogalMaskelerAciklama)
        {
            var dogalMaskelerAdiParameter = dogalMaskelerAdi != null ?
                new ObjectParameter("DogalMaskelerAdi", dogalMaskelerAdi) :
                new ObjectParameter("DogalMaskelerAdi", typeof(string));
    
            var dogalMaskelerAciklamaParameter = dogalMaskelerAciklama != null ?
                new ObjectParameter("DogalMaskelerAciklama", dogalMaskelerAciklama) :
                new ObjectParameter("DogalMaskelerAciklama", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_DogalMaskelerEkle", dogalMaskelerAdiParameter, dogalMaskelerAciklamaParameter);
        }
    
        public virtual ObjectResult<Sp_DogalMaskelerList_Result> Sp_DogalMaskelerList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_DogalMaskelerList_Result>("Sp_DogalMaskelerList");
        }
    
        public virtual ObjectResult<Sp_DogalMaskelerSec_Result> Sp_DogalMaskelerSec(Nullable<int> dogalMaskelerId)
        {
            var dogalMaskelerIdParameter = dogalMaskelerId.HasValue ?
                new ObjectParameter("DogalMaskelerId", dogalMaskelerId) :
                new ObjectParameter("DogalMaskelerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_DogalMaskelerSec_Result>("Sp_DogalMaskelerSec", dogalMaskelerIdParameter);
        }
    
        public virtual int SP_DogalMaskelerSil(Nullable<int> dogalMaskelerId)
        {
            var dogalMaskelerIdParameter = dogalMaskelerId.HasValue ?
                new ObjectParameter("DogalMaskelerId", dogalMaskelerId) :
                new ObjectParameter("DogalMaskelerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DogalMaskelerSil", dogalMaskelerIdParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int Sp_IletisimEkle(string adi, string email, string aciklama)
        {
            var adiParameter = adi != null ?
                new ObjectParameter("Adi", adi) :
                new ObjectParameter("Adi", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var aciklamaParameter = aciklama != null ?
                new ObjectParameter("Aciklama", aciklama) :
                new ObjectParameter("Aciklama", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_IletisimEkle", adiParameter, emailParameter, aciklamaParameter);
        }
    
        public virtual ObjectResult<Sp_IletisimList_Result> Sp_IletisimList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_IletisimList_Result>("Sp_IletisimList");
        }
    
        public virtual ObjectResult<Sp_IletisimSec_Result> Sp_IletisimSec(Nullable<int> iletisimId)
        {
            var iletisimIdParameter = iletisimId.HasValue ?
                new ObjectParameter("IletisimId", iletisimId) :
                new ObjectParameter("IletisimId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_IletisimSec_Result>("Sp_IletisimSec", iletisimIdParameter);
        }
    
        public virtual int SP_IletisimSil(Nullable<int> iletisimId)
        {
            var iletisimIdParameter = iletisimId.HasValue ?
                new ObjectParameter("IletisimId", iletisimId) :
                new ObjectParameter("IletisimId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_IletisimSil", iletisimIdParameter);
        }
    
        public virtual int Sp_KullaniciEkle(string kullaniciId, string kullaniciSifre)
        {
            var kullaniciIdParameter = kullaniciId != null ?
                new ObjectParameter("KullaniciId", kullaniciId) :
                new ObjectParameter("KullaniciId", typeof(string));
    
            var kullaniciSifreParameter = kullaniciSifre != null ?
                new ObjectParameter("KullaniciSifre", kullaniciSifre) :
                new ObjectParameter("KullaniciSifre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_KullaniciEkle", kullaniciIdParameter, kullaniciSifreParameter);
        }
    
        public virtual int SP_KullaniciSil(Nullable<int> kullaniciId)
        {
            var kullaniciIdParameter = kullaniciId.HasValue ?
                new ObjectParameter("KullaniciId", kullaniciId) :
                new ObjectParameter("KullaniciId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_KullaniciSil", kullaniciIdParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
