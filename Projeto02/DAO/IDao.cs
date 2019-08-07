using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.DAO
{
    public interface IDao<TEntidade> where TEntidade : class
    {
        void Adicionar(TEntidade entidade);
        void Remover(TEntidade entidade);
        void Atualizar(TEntidade entidade);
        void Listar(TEntidade entidade);
        void BuscarPorId(TEntidade entidade);
    }
}
