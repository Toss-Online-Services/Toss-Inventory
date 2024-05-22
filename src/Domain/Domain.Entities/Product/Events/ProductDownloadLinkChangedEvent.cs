﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Infrastructure;

namespace Domain.Entities.Product.Events;
public record class ProductDownloadLinkChangedEvent(Product Product, int OldDownloadId, int NewDownloadId):BaseEvent;
