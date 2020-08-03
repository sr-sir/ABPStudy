using System;
using System.Collections.Generic;
using System.Text;

namespace ABPStudy111.Application.GetModels
{
    public class GetOrders
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
    }
}
