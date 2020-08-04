using Sino.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ABPStudy.Core.Dto
{
    public class Settleorder : Entity<int>
    {
        /// <summary>
        /// 结算单编号
        /// </summary>
        public string SettleOrderNumber { get; set; }

        /// <summary>
        /// 工单id
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public int CreatPeopleId { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public string CreatTime { get; set; }

        /// <summary>
        /// 结算日期
        /// </summary>
        public string SettleTime { get; set; }

        /// <summary>
        /// 系统工时合计
        /// </summary>
        public double SystemWorkTime { get; set; }

        /// <summary>
        /// 核定工时
        /// </summary>
        public double PeopleWorkTime { get; set; }

        /// <summary>
        /// 工时单价
        /// </summary>
        public double WorkTimePrice { get; set; }

        /// <summary>
        /// 核定工时总价
        /// </summary>
        public double TotalWorkPrice { get; set; }

        /// <summary>
        /// 核定工时修改原因
        /// </summary>
        public string ReviseTimeReason { get; set; }

        /// <summary>
        /// 系统里程
        /// </summary>
        public double SystemMileage { get; set; }

        /// <summary>
        /// 核定里程
        /// </summary>
        public double CheckMileage { get; set; }

        /// <summary>
        /// 里程单价
        /// </summary>
        public string MileagePrice { get; set; }

        /// <summary>
        /// 核定里程总价
        /// </summary>
        public string TotalMileagePrice { get; set; }

        /// <summary>
        /// 核定里程修改原因
        /// </summary>
        public string ReviseMilieageReason { get; set; }

        /// <summary>
        /// 费用合计
        /// </summary>
        public string TotalPrice { get; set; }

        /// <summary>
        /// 结算工单状态
        /// </summary>
        public int SettleOrderStateId { get; set; }

        /// <summary>
        /// 结算单添加方式 1、工单生成  2、手动新增
        /// </summary>
        public int AddOrderType { get; set; }

        /// <summary>
        /// 是否有故障分析
        /// </summary>
        public bool IsHaveFaultAnalysis { get; set; }

        /// <summary>
        /// 是否已结算
        /// </summary>
        public bool IsHaveSettle { get; set; }
    }
}
