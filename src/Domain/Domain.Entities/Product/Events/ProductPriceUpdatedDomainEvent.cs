﻿namespace Domain.Entities.Product.Events;
public record ProductPriceUpdatedDomainEvent(string ProductId, Price Price) : BaseEvent;
