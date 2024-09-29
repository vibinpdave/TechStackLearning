#region Copyright TechStackLearning
// All rights are reserved. Reproduction or transmission in whole or in part,
// in any form or by any means, electronic, mechanical or otherwise, is 
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : CreateCompanyCommandHandler.cs
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
using Tracker.Application.Features.Address.Commands.CreateAddress;
#endregion

namespace Tracker.Application.Features.Company.Commands.CreateCompany
{
    public class CreateCompanyCommandHandler:IRequestHandler<CreateCompanyCommand, Unit>
    {
        #region Private Variables
        private readonly IMapper _mapper;
        private readonly ICompanyRepository _companyRepository;
        private readonly IMediator _mediator;
        #endregion

        #region Constructor
        public CreateCompanyCommandHandler(IMapper mapper, ICompanyRepository companyRepository, IMediator mediator)
        {
            _mapper = mapper;
            _companyRepository = companyRepository;
            _mediator = mediator;
        }
        #endregion

        #region Handle CreateCompanyCommand
        /// <summary>
        /// Handles the CreateCompanyCommand by creating a company and its associated address.
        /// </summary>
        /// <param name="request">The command containing company and address details.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Unit representing the result of the operation.</returns>
        public async Task<Unit> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            // Map CreateCompanyCommand to CreateAdressCommand
            var createAddressCommand = _mapper.Map<CreateAdressCommand>(request.Address);
            // Create address and get address ID
            var addressId = await _mediator.Send(createAddressCommand);

            var validator = new CreateCompanyCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
                throw new BadRequestException("Invalid Company Details", validationResult);

            var company = _mapper.Map<Tracker.Domain.Company>(request);
            company.AddressId = Convert.ToInt32(addressId);

            // Save the company
            await _companyRepository.CreateAsync(company);

            return Unit.Value;
        } 
        #endregion
    }
}
