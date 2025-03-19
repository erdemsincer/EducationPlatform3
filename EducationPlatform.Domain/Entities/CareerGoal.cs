﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Domain.Entities
{
    public class CareerGoal
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string GoalName { get; set; }
        public string Description { get; set; }
        
        public  User User { get; set; }
    }
}
