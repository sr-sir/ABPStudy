using Sino.Application.Services;
using ABPStudy.Application.GetModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ABPStudy.Application.IServices
{
    public interface IOrdersService
    {
        Task<List<GetCombineOS>> GetAddressListInfo();
    }
}
