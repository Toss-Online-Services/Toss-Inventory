﻿using Infrastructure.EventBus.Events;

namespace Application.Catalog.IntegrationEvents.Events;

public record OrderStatusChangedToAwaitingValidationIntegrationEvent(int OrderId, IEnumerable<OrderStockItem> OrderStockItems) : IntegrationEvent;