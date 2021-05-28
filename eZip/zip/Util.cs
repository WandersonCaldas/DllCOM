using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.EnterpriseServices;

[assembly: ApplicationName("Zip")]
[assembly: ApplicationActivation(ActivationOption.Library)]
//[assembly: System.Reflection.AssemblyKeyFile("zip.snk")]

namespace Net
{    
    public class Util : ServicedComponent
    {        
        public bool compactar(string caminho_origem, string caminho_destino)
        {
            var culture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            string _caminho_origem = caminho_origem;
            string _caminho_destino = caminho_destino;

            try
            {
                System.IO.Compression.ZipFile.CreateFromDirectory(_caminho_origem, _caminho_destino);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

