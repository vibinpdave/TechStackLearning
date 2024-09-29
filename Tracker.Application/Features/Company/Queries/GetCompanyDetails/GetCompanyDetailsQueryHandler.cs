#region Copyright TechStackLearning
// All rights are reserved. Reproduction or transmission in whole or in part,
// in any form or by any means, electronic, mechanical or otherwise, is 
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : $fileName$
// Purpose         : 
// Creation Date   : 
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
using Tracker.Application.Features.Address.Queries.GetAddressDetails;
using Tracker.Application.Features.DTO;
using Tracker.Domain;
#endregion

namespace Tracker.Application.Features.Company.Queries.GetCompanyDetails
{
    #region GetCompanyDetailsQueryHandler
    public class GetCompanyDetailsQueryHandler : IRequestHandler<GetCompanyDetailsQuery, APIResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICompanyRepository _companyRepository;
        private readonly IMediator _mediator;
        public GetCompanyDetailsQueryHandler(IMapper mapper, ICompanyRepository companyRepository, IMediator mediator)
        {
            _mapper = mapper;
            _companyRepository = companyRepository;
            _mediator = mediator;
            _mediator = mediator;
        }
        public async Task<APIResponse> Handle(GetCompanyDetailsQuery request, CancellationToken cancellationToken)
        {
            var companyDetails = await _companyRepository.GetByIdAsync(request.Id);

            if (companyDetails == null)
                throw new NotFoundException(nameof(companyDetails), request.Id);

            var data = _mapper.Map<CompanyDto>(companyDetails);

            // Map CreateCompanyCommand to CreateAdressCommand
            var GetAddressDetailsQuery = _mapper.Map<GetAddressDetailsQuery>(companyDetails.AddressId);
            // Create address and get address ID
            var address = await _mediator.Send(GetAddressDetailsQuery);
            data.address = _mapper.Map<AddressDto>(address);

            return new APIResponse(data);
        }
    } 
    #endregion
}
