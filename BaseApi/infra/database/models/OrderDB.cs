using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi.infra.database.models
{
    public record OrderDB(int idOrder, string cpf, double? freight);
    
}