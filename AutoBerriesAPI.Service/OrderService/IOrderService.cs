﻿using ProductsAPI.DAL.ViewModels.Order;

namespace ProductsAPI.Service.OrderService
{
    public interface IOrderService
    {
        void Create(OrderViewModel formData);
        void Update(OrderViewModel formData);
        OrderViewModel GetOrderById(int id);
        Task<List<OrderViewModel>> GetAllOrders();
    }
}
