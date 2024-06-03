﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Domain.Exceptions;
using Pgvector;

namespace Domain.Entities.Catalog;

public class CatalogItem
{
    public int Id { get; private set; }

    [Required]
    public string Name { get; private set; }

    public string Description { get; private set; }

    public decimal Price { get; private set; }

    public string PictureFileName { get; private set; }

    public int CatalogTypeId { get; private set; }

    public CatalogType CatalogType { get; private set; }

    public int CatalogBrandId { get; private set; }

    public CatalogBrand CatalogBrand { get; private set; }

    // Quantity in stock
    public int AvailableStock { get; private set; }

    // Available stock at which we should reorder
    public int RestockThreshold { get; private set; }


    // Maximum number of units that can be in-stock at any time (due to physicial/logistical constraints in warehouses)
    public int MaxStockThreshold { get; private set; }

    /// <summary>Optional embedding for the catalog item's description.</summary>
    [JsonIgnore]
    public Vector Embedding { get; private set; }

    /// <summary>
    /// True if item is on reorder
    /// </summary>
    public bool OnReorder { get; private set; }

    public CatalogItem() { }


    /// <summary>
    /// Decrements the quantity of a particular item in inventory and ensures the restockThreshold hasn't
    /// been breached. If so, a RestockRequest is generated in CheckThreshold. 
    /// 
    /// If there is sufficient stock of an item, then the integer returned at the end of this call should be the same as quantityDesired. 
    /// In the event that there is not sufficient stock available, the method will remove whatever stock is available and return that quantity to the client.
    /// In this case, it is the responsibility of the client to determine if the amount that is returned is the same as quantityDesired.
    /// It is invalid to pass in a negative number. 
    /// </summary>
    /// <param name="quantityDesired"></param>
    /// <returns>int: Returns the number actually removed from stock. </returns>
    /// 
    public int RemoveStock(int quantityDesired)
    {
        if (AvailableStock == 0)
        {
            throw new CatalogDomainException($"Empty stock, product item {Name} is sold out");
        }

        if (quantityDesired <= 0)
        {
            throw new CatalogDomainException($"Item units desired should be greater than zero");
        }

        int removed = Math.Min(quantityDesired, AvailableStock);

        AvailableStock -= removed;

        return removed;
    }

    /// <summary>
    /// Increments the quantity of a particular item in inventory.
    /// <param name="quantity"></param>
    /// <returns>int: Returns the quantity that has been added to stock</returns>
    /// </summary>
    public int AddStock(int quantity)
    {
        int original = AvailableStock;

        // The quantity that the client is trying to add to stock is greater than what can be physically accommodated in the Warehouse
        if (AvailableStock + quantity > MaxStockThreshold)
        {
            // For now, this method only adds new units up maximum stock threshold. In an expanded version of this application, we
            //could include tracking for the remaining units and store information about overstock elsewhere. 
            AvailableStock += MaxStockThreshold - AvailableStock;
        }
        else
        {
            AvailableStock += quantity;
        }

        OnReorder = false;

        return AvailableStock - original;
    }
}
