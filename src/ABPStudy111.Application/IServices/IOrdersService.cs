using Sino.Application.Services;
using ABPStudy111.Application.GetModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ABPStudy111.Application.IServices
{
    public interface IOrdersService
    {
        Task<List<GetCombineOS>> GetAddressListInfo();
    }
}
