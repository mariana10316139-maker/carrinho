using DataAccess.Repositorios.Contratos;
using Dominio;
using System.Linq;
using System.Collections.Generic;

namespace DataAccess.Repositorios
{
    public class MotoresRepositorio : IMotoresRepositorio
    {
        private readonly Contexto _contexto;

        public MotoresRepositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        // Obter por ID
        public Motores ObterPorId(int motoresID)
        {
            return _contexto.Motores
                .FirstOrDefault(motores => motores.IdMotor == motoresID);
        }

        // Adicionar
        public void AdicionarMotores(Motores motores)
        {
            _contexto.Motores.Add(motores);
            _contexto.SaveChanges();
        }

        // Atualizar
        public void AtualizarMotores(Motores motores)
        {
            _contexto.Motores.Update(motores);
            _contexto.SaveChanges();
        }

        // Remover
        public void RemoverMotores(Motores motores)
        {
            _contexto.Motores.Remove(motores);
            _contexto.SaveChanges();
        }

        // Listar todos
        public IEnumerable<Motores> ListarTodos()
        {
            return _contexto.Motores.ToList();
        }
    }
}