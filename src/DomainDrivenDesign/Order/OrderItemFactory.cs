﻿namespace DomainDrivenDesign
{
    public static class OrderItemFactory
    {
        public static OrderItem Create(Product product, decimal quantity)
        {
            return new(product, new Quantity(quantity));
        }
    }
}
