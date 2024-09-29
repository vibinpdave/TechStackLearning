#region Copyright 
// All rights are reserved. Reproduction or transmission in whole or in part,
// in any form or by any means, electronic, mechanical or otherwise, is 
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : CreateAddressCommandValidator.CS
// Purpose         : 
// Creation Date   : 27SEP2024
// Author          : Vibin P
//
// Change History
// Changed by   :                         Date : 
// Purpose      : 
#endregion

#region Imported Namespaces
using FluentValidation;
#endregion


namespace Tracker.Application.Features.Address.Commands.CreateAddress
{
    public class CreateAddressCommandValidator : AbstractValidator<CreateAdressCommand>
    {
        #region Constructor
        public CreateAddressCommandValidator()
        {
            RuleFor(p => p.Street)
                .NotNull()
                .WithMessage("{PropertyName} should not be null.");
            RuleFor(p => p.City)
                .NotNull()
                .WithMessage("{PropertyName} should not be null.");
            RuleFor(p => p.Country)
                .NotNull()
                .WithMessage("{PropertyName} should not be null.");
            RuleFor(p => p.AddressLine1)
                .NotNull()
                .WithMessage("{PropertyName} should not be null.");
            RuleFor(p => p.State)
                .NotNull()
                .WithMessage("{PropertyName} should not be null.");
        } 
        #endregion
    }
}
