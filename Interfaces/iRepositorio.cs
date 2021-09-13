using System.Collections.Generic;

namespace cadastro_series.Interfaces
{
    public interface iRepositorio<T>
    {
        List<T> Lista();
        
        T RetornaaPorId(int id);

        void Insere(T entidade);
        
        void Exclui(int id);

        void Atualiza(int id, T entidade);

        int ProximoId();
        
    }
}