using Dominio;
using System.Collections.Generic;

namespace DataAccess.Repositorios.Contratos
{
    public interface IMotoresRepositorio
    {
        void AdicionarMotores(Motores motores);
        void AtualizarMotores(Motores motores);
        void RemoverMotores(Motores motores);
        IEnumerable<Motores> ListarTodos();
        //// adicionando 
        Motores ObterPorId(int motoresID);
    }
}