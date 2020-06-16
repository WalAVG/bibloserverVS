using Biblo.Api.BO;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.Configuration
{
    public class Services
    {
        public static void Configure(IServiceCollection services)
        {
            //Ogni servizio va aggiunto qui
            services.AddTransient<AddressService>();
            services.AddTransient<AuthorService>();
            services.AddTransient<BookService>();
            services.AddTransient<BoardMessageService>();
            services.AddTransient<CommentBoardService>();
            services.AddTransient<InsertingService>();
            services.AddTransient<PrivateChatService>();
            services.AddTransient<PrivateMessageService>();
            services.AddTransient<UserService>();
        }
    }
}
