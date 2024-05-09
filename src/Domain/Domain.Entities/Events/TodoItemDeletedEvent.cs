﻿using Toss.Inventory.Catalog.Domain.Common;

namespace Domain.Entities.Events;

public class TodoItemDeletedEvent : BaseEvent
{
    public TodoItemDeletedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}