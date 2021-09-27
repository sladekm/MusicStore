using AutoMapper;
using MusicStore.Models;
using MusicStore.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Mapping
{
    public class OrderItemsCountResolver : IValueResolver<Order, OrderListVM, int>
    {
        public int Resolve(Order source, OrderListVM destination, int member, ResolutionContext context)
        {
            int itemsCount = 0;
            foreach (var orderDetail in source.OrderDetails)
            {
                itemsCount += orderDetail.Quantity;
            }
            return itemsCount;
        }
    }
}
