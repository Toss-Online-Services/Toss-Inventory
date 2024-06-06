﻿using Domain.Infrastructure;

namespace Domain.Entities.Product;
 public record UpdatePhysicalAttributesCommand : ICommand<bool>
{
    public decimal Weight { get; init; }
    public decimal Length { get; init; }
    public decimal Width { get; init; }
    public decimal Height { get; init; }
    public string Color { get; init; }
    public string Material { get; init; }
    public string Size { get; init; }
    public string PackagingType { get; init; }
   }
