﻿using EducationPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Persistence.Abstract
{
    public interface IInterestDal:IGenericDal<Interest>
    {
        Task<List<Interest>> GetByUserIdAsync(int userId);

    }
}
