﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Device_BE.Models.MDevice
{
    public class CMLoaiTuDien
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string MaLoai { get; set; }
        [Required]
        [StringLength(50)]
        public string Ten { get; set; }

    }
}
