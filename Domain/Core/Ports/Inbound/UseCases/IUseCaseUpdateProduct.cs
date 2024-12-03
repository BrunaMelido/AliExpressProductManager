﻿using aliexpress.Domain.Core.Models;

namespace aliexpress.Domain.Core.Ports.Inbound.UseCases
{
    public interface IUseCaseUpdateProduct
    {
        public Task<BaseReturn> Execute(ProductTransaction product);
    }
}
