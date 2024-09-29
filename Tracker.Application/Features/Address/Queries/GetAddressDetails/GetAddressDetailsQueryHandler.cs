#region Copyright TechStackLearning
// All rights are reserved. Reproduction or transmission in whole or in part,
// in any form or by any means, electronic, mechanical or otherwise, is 
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : GetAddressDetailsQueryHandler.cs
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
using MediatR;
using Tracker.Application.Contracts.Persistence;
using Tracker.Application.Exceptions;
using Tracker.Application.Features.DTO;

#endregion

namespace Tracker.Application.Features.Address.Queries.GetAddressDetails
{
    #region GetAddressDetailsQueryHandler
    public class GetAddressDetailsQueryHandler : IRequestHandler<GetAddressDetailsQuery, AddressDto>
    {
        private readonly IMapper _mapper;
        private readonly IAddressRepository _addressRepository;
        public GetAddressDetailsQueryHandler(IMapper mapper, IAddressRepository addressRepository)
        {
            _mapper = mapper;
            _addressRepository = addressRepository;
        }

        public async Task<AddressDto> Handle(GetAddressDetailsQuery request, CancellationToken cancellationToken)
        {
            var AddressDetails = await _addressRepository.GetByIdAsync(request.Id);

            if (AddressDetails == null)
                throw new NotFoundException(nameof(AddressDetails), request.Id);

            var data = _mapper.Map<AddressDto>(AddressDetails);
            return data;
        }
    } 
    #endregion
}
