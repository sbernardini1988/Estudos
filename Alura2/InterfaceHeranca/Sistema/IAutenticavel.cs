using InterfaceHeranca.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHeranca.Sistema
{
    public interface IAutenticavel 
    {
        bool Autenticar(string senha);
        
    }
}
