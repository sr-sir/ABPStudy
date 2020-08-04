using Sino.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ABPStudy.Core.Dto
{
    public class Picture : Entity<int>
    {
        /// <summary>
        /// 工单id
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 照片类型
        /// </summary>
        public int PictureTypeId { get; set; }

        public string Picture1 { get; set; }

        public string Picture2 { get; set; }

        public string Picture3 { get; set; }

        public string Picture4 { get; set; }

        public string Picture5 { get; set; }
    }
}
