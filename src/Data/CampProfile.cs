using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CoreCodeCamp.Data
{
    public class CampProfile :Profile
    {
        public CampProfile()
        {
            this.CreateMap<Camp, CampModel>()
            .ForMember(cm => cm.Venue, o => o.MapFrom(m => m.Location.VenueName));
        }
    }
}
