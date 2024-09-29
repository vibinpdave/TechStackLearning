#region Copyright TechStackLearning
// All rights are reserved. Reproduction or transmission in whole or in part,
// in any form or by any means, electronic, mechanical or otherwise, is 
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : GetAddressDetailsQuery.cs
// Purpose         : 
// Creation Date   : 
// Author          : Vibin P
//
// Change History
// Changed by   :                         Date : 
// Purpose      : 
#endregion

#region Imported Namespaces
using MediatR;
using Tracker.Application.Features.DTO;
#endregion


namespace Tracker.Application.Features.Address.Queries.GetAddressDetails
{
    #region GetAddressDetailsQuery
    /// <summary>
    /// Query to get address by ID.
    /// </summary>
    public record GetAddressDetailsQuery(int Id) : IRequest<AddressDto>; 
    #endregion
}
