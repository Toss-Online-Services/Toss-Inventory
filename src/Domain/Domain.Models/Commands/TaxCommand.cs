﻿namespace Domain.Models.Commands;
public record TaxCommand()
{
    public bool IsTaxExempt { get; init; }
    public int TaxCategoryId { get; init; }

}
