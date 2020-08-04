using ABPStudy.Core.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABPStudy.Application.RequestModels
{
    public class OrderRequest : IRequest<Orders>
    {
        public int Id { get; set; }
    }
}
