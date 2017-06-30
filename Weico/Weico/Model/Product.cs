using System;
using System.Collections.Generic;

namespace Weico.Model
{
    public partial class Product
    {
        private string photoSrc;
        public int ProId { get; set; }
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
        public string ProName { get; set; }
        public string ProDescribe { get; set; }
        public decimal? Price { get; set; }
        public string PhotoSrc { get => photoSrc; set => photoSrc = "http://mvcapi.azurewebsites.net/images/" + value; }
        public int? StoreCount { get; set; }
    }

    public class RootObject
    {
        public object contentType { get; set; }
        public object serializerSettings { get; set; }
        public object statusCode { get; set; }
        public List<Product> value { get; set; }
    }
}
