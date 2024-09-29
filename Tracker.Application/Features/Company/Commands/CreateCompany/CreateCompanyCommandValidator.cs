#region Copyright TechStackLearning
// All rights are reserved. Reproduction or transmission in whole or in part,
// in any form or by any means, electronic, mechanical or otherwise, is 
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : CreateCompanyCommandValidator.cs
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

namespace Tracker.Application.Features.Company.Commands.CreateCompany
{
    public class CreateCompanyCommandValidator : AbstractValidator<CreateCompanyCommand>
    {
        #region Constructor
        public CreateCompanyCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotNull()
                .WithMessage("{PropertyName} should not be null.");
            RuleFor(p => p.Description)
                .NotNull()
                .WithMessage("{PropertyName} should not be null.");
        } 
        #endregion
    }
}
