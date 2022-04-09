﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAnnouncementService : IGenericService<Announcement>
    {
        List<Announcement> GetLastThreeAnnouncement();
    }
}
