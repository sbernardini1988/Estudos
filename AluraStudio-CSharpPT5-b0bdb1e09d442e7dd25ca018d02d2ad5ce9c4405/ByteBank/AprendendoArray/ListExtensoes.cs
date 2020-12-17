using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoArray
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios(this List<int> listaDeInteiros, params int[] itens)
        {
            foreach (int item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }
    }
}
