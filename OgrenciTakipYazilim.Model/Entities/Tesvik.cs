﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OgrenciTakipYazilim.Model.Attributes;
using OgrenciTakipYazilim.Model.Entities.Base;

namespace OgrenciTakipYazilim.Model.Entities
{
    public class Tesvik : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Teşvik Adı", "txtTesvikAdi")]
        public string TesvikAdi { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}