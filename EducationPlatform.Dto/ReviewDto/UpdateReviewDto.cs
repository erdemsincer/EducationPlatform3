﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Dto.ReviewDto
{
    public class UpdateReviewDto
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public int UserId { get; set; } // Değerlendiren kullanıcı
        public int Rating { get; set; } // 1-5 arası puan
        public string Comment { get; set; } // Kullanıcının yorumu
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
