﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Dispatch
{
    public partial class Project_StatusEntity
    {
        #region Properties
        ///----------------------------
        /// Generated By:   Sushi-Sashimi using CodeSmith 6.0.0.0
        /// Template:       TableEntity.cst
        /// Date Generated: April 8, 2017
        ///----------------------------
        public int Id { get; set; }

        ///----------------------------
        /// Generated By:   Sushi-Sashimi using CodeSmith 6.0.0.0
        /// Template:       TableEntity.cst
        /// Date Generated: April 8, 2017
        ///----------------------------
        ///
        [Display(Name = "Trạng thái")]
        [Required(ErrorMessage = "Nhập tên trạng thái")]
        [MaxLength(250, ErrorMessage = "Tên trạng thái quá dài, không được vượt quá 250 kí tự")]
        public string Name { get; set; }

        ///----------------------------
        /// Generated By:   Sushi-Sashimi using CodeSmith 6.0.0.0
        /// Template:       TableEntity.cst
        /// Date Generated: April 8, 2017
        ///----------------------------
        public bool IsDel { get; set; }
        public bool IsActive { get; set; }
        #endregion
    }
}
