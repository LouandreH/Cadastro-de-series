
using System.Collections.Generic;

namespace Aprender.Classes
{
    public interface IRepositorio
    {
         public interface IRepositorio<T>
         {
            List<T> Lista();

            T RetornaPorId(int id);
            void Insere(T entidade);
            void Exclui(int id);
            void Atualizar(int id, T entidade);
            int ProximoId();
            
         }
    }
}
    
