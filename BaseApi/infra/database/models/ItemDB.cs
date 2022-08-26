using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi
{
    public record ItemDB(int idItem, string description, double price, int idDimenson, double? weight);
}