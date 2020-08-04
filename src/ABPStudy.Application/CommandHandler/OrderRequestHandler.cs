using ABPStudy.Application.RequestModels;
using ABPStudy.Core.Dto;
using ABPStudy.Repositories.DbContextFile;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ABPStudy.Application.CommandHandler
{
    public class OrderRequestHandler : IRequestHandler<OrderRequest, Orders>
    {
        private readonly TestDbContext _testDbContext;
        public OrderRequestHandler(TestDbContext testDbContext)
        {
            _testDbContext = testDbContext;
        }
        public async Task<Orders> Handle(OrderRequest request, CancellationToken cancellationToken)
        {
            var res = await _testDbContext.Tb_orders.Where(o => o.Id == request.Id).FirstOrDefaultAsync();
            return res;
        }
    }
}
