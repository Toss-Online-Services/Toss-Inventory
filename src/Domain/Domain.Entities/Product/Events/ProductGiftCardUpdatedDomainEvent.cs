﻿namespace Domain.Entities.Product.Events;
public record ProductGiftCardUpdatedDomainEvent(string ProductId, GiftCard GiftCard) : BaseEvent;
