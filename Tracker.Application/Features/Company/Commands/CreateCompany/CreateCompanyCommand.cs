#region Copyright TechStackLearning
// All rights are reserved. Reproduction or transmission in whole or in part,
// in any form or by any means, electronic, mechanical or otherwise, is 
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : CreateCompanyCommand.cs
// Purpose         : 
// Creation Date   : 27SEP2024
// Author          : Vibin P
//
// Change History
// Changed by   :                         Date : 
// Purpose      : 
#endregion

#region Imported Namespaces
using MediatR;
using Tracker.Application.Features.Address.Commands.CreateAddress;
#endregion

namespace Tracker.Application.Features.Company.Commands.CreateCompany
{

    #region CreateCompanyCommand
    /// <summary>
    /// Command to create a new company along with its address.
    /// </summary>
    public class CreateCompanyCommand : IRequest<Unit>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }

        public CreateAdressCommand Address { get; set; }
    } 
    #endregion
}
