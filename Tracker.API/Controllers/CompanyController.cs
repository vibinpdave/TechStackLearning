#region Copyright TechStackLearning
// All rights are reserved. Reproduction or transmission in whole or in part,
// in any form or by any means, electronic, mechanical or otherwise, is 
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : CompanyController.cs
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
using Microsoft.AspNetCore.Mvc;
using Tracker.Application.Features.Company.Commands.CreateCompany;
using Tracker.Application.Features.Company.Queries.GetCompanyDetails;
using Tracker.Domain;
#endregion

namespace Tracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        #region Private Variables
        private readonly IMediator _mediator; 
        #endregion

        #region Constructor
        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region Methods

        #region Get Company Details By Id
        /// <summary>
        /// Retrieves company details by the specified ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<APIResponse>> Get(int id)
        {
            return await _mediator.Send(new GetCompanyDetailsQuery(id));
        }
        #endregion

        #region Creates a new company
        /// <summary>
        /// Creates a new company record.
        /// </summary>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Post(CreateCompanyCommand companyDetails)
        {
            var response = await _mediator.Send(companyDetails);
            return CreatedAtAction(nameof(Get), new { id = response });
        }  
        #endregion

        #endregion
    }
}
