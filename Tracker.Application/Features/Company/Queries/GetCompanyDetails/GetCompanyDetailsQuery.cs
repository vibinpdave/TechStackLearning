#region Copyright TechStackLearning
// All rights are reserved. Reproduction or transmission in whole or in part,
// in any form or by any means, electronic, mechanical or otherwise, is 
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : GetCompanyDetailsQuery.cs
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
using Tracker.Domain;
#endregion

namespace Tracker.Application.Features.Company.Queries.GetCompanyDetails
{
    #region GetCompanyDetailsQuery
    public record GetCompanyDetailsQuery(int Id) : IRequest<APIResponse>; 
	#endregion
}
