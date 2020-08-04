using Microsoft.EntityFrameworkCore;
using ABPStudy.Application.GetModels;
using ABPStudy.Application.IServices;
using ABPStudy.Repositories.DbContextFile;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABPStudy.Application.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly TestDbContext _testDbContext;
        public OrdersService(TestDbContext testDbContext)
        {
            _testDbContext = testDbContext;
        }
        public async Task<List<GetCombineOS>> GetAddressListInfo()
        {
            //var dat1 = await _testDbContext.Tb_picture.Include("Tb_picturetype").ToListAsync();
            var res = await _testDbContext.Tb_orders.Where(o => o.Province == "江苏省").Where(o => o.City == "镇江市").OrderByDescending(o => o.Id).Skip(0).Take(10).ToListAsync();
            var reslink = _testDbContext.Tb_orders;
            var resjoin = await reslink.Join(_testDbContext.Tb_settleorder, s => s.Id, j => j.OrderId, (s, j) => new GetCombineOS
            {
                Id = s.Id,
                OrderId = j.OrderId,
                SettleOrderId = j.Id
            }).ToListAsync();

            //var result = Mapper.Map<List<GetOrders>>(resjoin);
            return resjoin;
        }
    }
}
