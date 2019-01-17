using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Smile.Northwind.MvcWebUI.Middlewares
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app,string root)
        {
            //Tamamı Root Altında Olmayan node_modules'a root altında göstermek için yapıldı.
            var path = Path.Combine(root, "node_modules"); //Root altındaki node_modules arayacak ve Combine edecek(Root ile node_modules)
            var provider = new PhysicalFileProvider(path); //static dosyaları taşımak adına servis nesnesi

            var options = new StaticFileOptions();
            options.RequestPath = "/node_modules";
            options.FileProvider = provider;

            app.UseStaticFiles(options);
            return app;
        }
    }
}
