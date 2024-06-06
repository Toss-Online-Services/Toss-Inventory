﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Product.Commands;
public record UpdateInventoryCommand() : ICommand<bool>
{
    public int ManageInventoryMethodId { get; init; }
    public int WarehouseId { get; init; }
    public int StockQuantity { get; init; }
    public int MinStockQuantity { get; init; }
    public int LowStockActivityId { get; init; }
    public int NotifyAdminForQuantityBelow { get; init; }
    public int BackorderModeId { get; init; }
    public bool AllowBackInStockSubscriptions { get; init; }
    public int OrderMinimumQuantity { get; init; }
    public int OrderMaximumQuantity { get; init; }
    public string AllowedQuantities { get; init; }
    public bool AllowAddingOnlyExistingAttributeCombinations { get; init; }
    public bool DisplayAttributeCombinationImagesOnly { get; init; }
}

