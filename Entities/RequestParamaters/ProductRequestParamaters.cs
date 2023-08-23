﻿using System;
namespace Entities.RequestParamaters
{
    public class ProductRequestParamaters : RequestParamater
    {
        public int? CategoryId { get; set; }

        public int MinPrice { get; set; } = 0;

        public int MaxPrice { get; set; } = int.MaxValue;

        public bool IsValidPrice => MaxPrice > MinPrice;

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public ProductRequestParamaters() : this(1, 6)
        {

        }

        public ProductRequestParamaters(int pageNumber=1, int pageSize=6)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

    }
}
