using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ABPStudy111.Application.GetModels;
using ABPStudy111.Application.IServices;
using ABPStudy.Application.RequestModels;
using MediatR;
using StackExchange.Redis;
using AutoMapper;

namespace ABPStudy111.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UseEFController : ControllerBase
    {
        private readonly IOrdersService _addressService;
        private readonly IMediator _mediator;
        public UseEFController(IOrdersService addressService, IMediator mediator)
        {
            _addressService = addressService;
            _mediator = mediator;
        }

        /// <summary>
        /// 获取地址信息（列表）
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAddressListInfo")]
        public async Task<List<GetCombineOS>> GetAddressListInfo()
        {
            var res = await _addressService.GetAddressListInfo();
            return res;
        }

        /// <summary>
        /// 使用MediatR
        /// </summary>
        [HttpGet("UseMediatR")]
        public async Task<GetOrders> UseMediatR(int Id)
        {
            var res = await _mediator.Send(new OrderRequest { Id = Id });
            var result = Mapper.Map<GetOrders>(res);
            return result;
        }
    }
}