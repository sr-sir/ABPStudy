using Sino.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABPStudy111.Core.Dto
{
    public class Orders : Entity<int>
    {
        /// <summary>
        /// 创建人姓名
        /// </summary>
        public string CreatePeopleName { get; set; }

        /// <summary>
        /// 工单编号
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// 维修站/经销商ID
        /// </summary>
        public int RepairStationId { get; set; }

        /// <summary>
        /// 工单服务类型
        /// </summary>
        public string OrderServiceType { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        public string FrameNumber { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 完整地址
        /// </summary>
        public string Detailaddress { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public string Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// 报修人姓名
        /// </summary>
        public string RepairName { get; set; }

        /// <summary>
        /// 手机号区号
        /// </summary>
        public string PhoneCode { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
