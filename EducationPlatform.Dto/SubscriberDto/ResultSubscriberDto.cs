﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Dto.SubscriberDto
{
    public class ResultSubscriberDto
    {
        public int SubscriberId { get; set; }
        public string Email { get; set; }

        public bool IsActive { get; set; }
    }
}
