using Microsoft.Extensions.Hosting;
using ShardsOfMonolith.Core.Domain;
using ShardsOfMonolith.Core.Dto;
using ShardsOfMonolith.Core.ServiceInterface;
using ShardsOfMonolith.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShardsOfMonolith.ApplicationServices.Services
{  
        public class FileServices : IFileServices
        {
            private readonly IHostEnvironment _webHost;
            private readonly ShardsOfMonolithContext _context;

            public FileServices
                (
                    IHostEnvironment webHost,
                    ShardsOfMonolithContext context
                )
            {
                _webHost = webHost;
                _context = context;
            }

            public void UploadFilesToDatabase(StalkerDto dto, Stalker domain)
            {
                if (dto.Files != null && dto.Files.Count > 0)
                {
                    foreach (var image in dto.Files)
                    {
                        using (var target = new MemoryStream())
                        {
                            FileToDatabase files = new FileToDatabase()
                            {
                                ID = Guid.NewGuid(),
                                ImageTitle = image.FileName,
                                StalkerID = domain.ID,
                            };

                            image.CopyTo(target);
                            files.ImageData = target.ToArray();
                            _context.FilesToDatabase.Add(files);
                        }
                    }
                }
            }
        }
    
}
