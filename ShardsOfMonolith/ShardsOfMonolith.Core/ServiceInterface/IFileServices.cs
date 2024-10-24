using ShardsOfMonolith.Core.Domain;
using ShardsOfMonolith.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShardsOfMonolith.Core.ServiceInterface
{
    public interface IFileServices
    {
        void UploadFilesToDatabase(StalkerDto dto, Stalker domain);
    }
}
