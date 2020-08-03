using System;
using System.Collections.Generic;
using System.Text;

namespace ABPStudy111.Application.GetModels
{
    public class GetCombineOS
    {
        /// <summary>
        /// 工单id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 结算单工单id
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 结算单id
        /// </summary>
        public int SettleOrderId { get; set; }
    }
}
