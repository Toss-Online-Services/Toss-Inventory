﻿using Domain.Entities.Discounts;

namespace Domain.Entities.Product.Events;

public record ProductDiscountAppliedDomainEvent : BaseEvent
{
    public Product Product { get; }
    public DiscountProductMapping Discount { get; }

    public ProductDiscountAppliedDomainEvent(Product product, DiscountProductMapping discount)
    {
        Product = product;
        Discount = discount;
    }
}
