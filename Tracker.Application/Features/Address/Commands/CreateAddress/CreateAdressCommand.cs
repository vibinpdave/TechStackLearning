#region Copyright TechStackLearning
// All rights are reserved. Reproduction or transmission in whole or in part,
// in any form or by any means, electronic, mechanical or otherwise, is 
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : CreateAdressCommand.CS
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
#endregion

namespace Tracker.Application.Features.Address.Commands.CreateAddress
{
    #region CreateAdressCommand
    /// <summary>
    /// Command to create address.
    /// </summary>
    public class CreateAdressCommand : IRequest<int>
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
    } 
    #endregion
}
