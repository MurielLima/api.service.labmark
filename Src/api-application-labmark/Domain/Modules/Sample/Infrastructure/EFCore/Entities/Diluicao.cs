﻿using Labmark.Domain.Modules.Exam.Infrastructure.EFCore.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Labmark.Domain.Modules.Sample.Infrastructure.EFCore.Entities
{
    [Table("Diluicao", Schema = "LAB")]
    public partial class Diluicao
    {
        [Key]
        public int Id { get; set; }
        public int? fk_Leitura_Id { get; set; }
        [Column("Diluicao")]
        public double Diluicao1 { get; set; }
        [StringLength(30)]
        public string Lote { get; set; }

        [ForeignKey(nameof(fk_Leitura_Id))]
        [InverseProperty(nameof(Leitura.Diluicaos))]
        public virtual Leitura fk_Leitura { get; set; }
    }
}
