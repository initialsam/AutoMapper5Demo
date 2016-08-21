using AutoMapper;
using AutoMapper5Demo.Infrastructure.AutoMapperProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapper5Demo.App_Start
{
    /// <summary>
    /// AutoMapperConfig
    /// </summary>
    public class AutoMapperConfig
    {
        /// <summary>
        /// Configures this instance.
        /// </summary>
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ClientProfile>();
            });


        }
    }
}