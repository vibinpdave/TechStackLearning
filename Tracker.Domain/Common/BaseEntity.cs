#region Copyright TechStackLearning
// All rights are reserved. Reproduction or transmission in whole or in part,
// in any form or by any means, electronic, mechanical or otherwise, is 
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : BaseEntity.cs
// Purpose         : 
// Creation Date   : 02SEP2024
// Author          : Vibin P
//
// Change History
// Changed by   :                         Date : 
// Purpose      : 
#endregion

namespace Tracker.Domain.Common
{
    #region Class-BaseEntity
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    } 
    #endregion
}
