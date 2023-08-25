﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repostory;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfSocialMediaDal : GenericRepostory<SocialMedia>, ISocialMediaDal
    {
    }
}
