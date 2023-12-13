using AutoMapper;
using LMS.Data.Entities;
using LMS.Data.Repositories.Daire;
using LMS.Data.Repositories.User;
using LMS.Services.Moldels.Aidat;
using LMS.Services.Moldels.Daire;
using LMS.Services.Moldels.Fatura;
using LMS.Services.Moldels.Odeme;
using LMS.Services.Moldels.User;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services.Mappers
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRequestModel, User>().ReverseMap();
            CreateMap<UpdateUser, User>().ReverseMap();
            CreateMap<DaireRequestModel, Daire>().ReverseMap();
            CreateMap<LoginEntity, User>();
            CreateMap<FaturaRequestModel, Fatura>();
            CreateMap<AidatRequestModels, Aidat>();
            CreateMap<AidatUpdateRequest, Aidat>();
            CreateMap<OdemeRequestModel, Odeme>();
            CreateMap<OdemeUpdateRequest, Odeme>();
        }
    }
    
}
