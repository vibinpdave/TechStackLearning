#region Copyright TechStackLearning
// All rights are reserved. Reproduction or transmission in whole or in part,
// in any form or by any means, electronic, mechanical or otherwise, is 
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : CreateAddressCommandHandler.CS
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
#endregion

namespace Tracker.Application.Features.Address.Commands.CreateAddress
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAdressCommand, int>
    {
        #region Private Variables
        private readonly IMapper _mapper;
        private readonly IAddressRepository _addressRepository;
        #endregion

        #region Constructor
        public CreateAddressCommandHandler(IMapper mapper, IAddressRepository address)
        {
            _mapper = mapper;
            _addressRepository = address;
        }
        #endregion

        #region Handle CreateAdressCommand
        public async Task<int> Handle(CreateAdressCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateAddressCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
                throw new BadRequestException("Invalid Adress Details", validationResult);

            var address = _mapper.Map<Tracker.Domain.Address>(request);

            await _addressRepository.CreateAsync(address);

            return address.Id;
        } 
        #endregion
    }
}
