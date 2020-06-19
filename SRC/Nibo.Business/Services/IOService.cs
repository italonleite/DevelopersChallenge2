using Microsoft.AspNetCore.Http;
using Nibo.Business.Interfaces;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Nibo.Business.Services
{
    public class IOService : IIOService
    {
                                
        private string folder = @"F:\Projetos\DesafioNibo\SRC\Nibo.App\wwwroot\Data\";
        

        public StringBuilder ReadFile(string fileName)
        {
            fileName = folder + fileName;

            var builder = new StringBuilder();

            using (FileStream fs = File.OpenRead(fileName))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                while (fs.Read(b, 0, b.Length) > 0)
                {
                    builder.Append(temp.GetString(b));
                }
            }


            return builder;
        }

        
    }

}
