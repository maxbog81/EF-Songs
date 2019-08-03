using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_Songs.Data
{
    public class Artist
    {
        //[Key]
        public int Id { get; set; }

        [Required, MaxLength(120)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Surname { get; set; }

        /// <summary>Отчество</summary>
        [MaxLength(255)]
        public string Patronimyc { get; set; }

        public DateTime? BirthDay { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}