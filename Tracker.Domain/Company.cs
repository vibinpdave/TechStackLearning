#region Copyright TechStackLearning
// All rights are reserved. Reproduction or transmission in whole or in part,
// in any form or by any means, electronic, mechanical or otherwise, is 
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : Company.cs
// Purpose         : 
// Creation Date   : 
// Author          : Vibin P
//
// Change History
// Changed by   :                         Date : 17SEP2024
// Purpose      : 
#endregion

#region Imported Namespaces
using Tracker.Domain.Common;
#endregion


namespace Tracker.Domain
{
    #region Company
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public int AddressId { get; set; }

    } 
    #endregion
}
