using ShardsOfMonolith.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShardsOfMonolith.Core.ServiceInterface
{
    public interface IStalkersServices
    {
        Task<Stalker> DetailsAsync(Guid id);
    }
}
