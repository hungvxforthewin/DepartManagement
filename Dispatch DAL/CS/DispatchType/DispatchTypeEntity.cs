﻿using System.ComponentModel.DataAnnotations;

namespace Dispatch
{
    [MetadataType(typeof(DispatchTypeMetadata))]
    public partial class DispatchTypeEntity
    {
        #region Properties
        ///----------------------------
        /// Generated By:   Sushi-Sashimi using CodeSmith 6.0.0.0
        /// Template:       TableEntity.cst
        /// Date Generated: March 6, 2017
        ///----------------------------
        public int Id { get; set; }

        ///----------------------------
        /// Generated By:   Sushi-Sashimi using CodeSmith 6.0.0.0
        /// Template:       TableEntity.cst
        /// Date Generated: March 6, 2017
        ///----------------------------
        public string Name { get; set; }

        ///----------------------------
        /// Generated By:   Sushi-Sashimi using CodeSmith 6.0.0.0
        /// Template:       TableEntity.cst
        /// Date Generated: March 6, 2017
        ///----------------------------
        public System.DateTime Createdate { get; set; }

        #endregion
    }
}

