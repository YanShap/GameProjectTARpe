using Microsoft.EntityFrameworkCore;
using ShardsOfMonolith.Core.Domain;
using ShardsOfMonolith.Core.ServiceInterface;
using ShardsOfMonolith.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShardsOfMonolith.ApplicationServices.Services.StalkersServices;

namespace ShardsOfMonolith.ApplicationServices.Services
{    
    
        public class StalkersServices : IStalkersServices
        {
            private readonly ShardsOfMonolithContext _context;

            public StalkersServices(ShardsOfMonolithContext context /*IFileServices fileServices*/)
            {
                _context = context;
            }

            ///<summary>
            ///Get Dtails for one Sigma
            ///</summary>
            ///<param name="id">Id of Sigma to show details of</param>
            ///<returns>resulting sigma</returns>

            public async Task<Stalker> DetailsAsync(Guid id)
            {
                var result = await _context.Stalkers
                    .FirstOrDefaultAsync(x => x.ID == id);
                return result;
            }
        }
    
}
