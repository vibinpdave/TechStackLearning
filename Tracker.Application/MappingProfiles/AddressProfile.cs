#region Copyright TechStackLearning
// All rights are reserved. Reproduction or transmission in whole or in part,
// in any form or by any means, electronic, mechanical or otherwise, is 
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : AddressProfile.CS
// Purpose         : 
// Creation Date   : 27SEP2024
// Author          : Vibin P
//
// Change History
// Changed by   :                         Date : 
// Purpose      : 
#endregion

#region Imported Namespaces
using AutoMapper;
using Tracker.Application.Features.Address.Commands.CreateAddress;
using Tracker.Application.Features.DTO;
using Tracker.Domain;
#endregion

namespace Tracker.Application.MappingProfiles
{
    public class AddressProfile : Profile
    {
        #region Constructor
        public AddressProfile()
        {
            CreateMap<CreateAdressCommand, Address>();

            CreateMap<AddressDto, Address>().ReverseMap();

            CreateMap<CreateAdressCommand, Address>()
            .ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.Street))
            .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
            .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.State))
            .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.PostalCode))
            .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country))
            .ForMember(dest => dest.AddressLine1, opt => opt.MapFrom(src => src.AddressLine1))
            .ForMember(dest => dest.AddressLine2, opt => opt.MapFrom(src => src.AddressLine2));
        } 
        #endregion
    }
}
