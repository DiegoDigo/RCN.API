using System.Collections.Generic;
using System.Linq;

namespace RCN.API.Data
{
    public class ProdutoRepository : IProdutoRepository
    {

        public readonly ProdutoContext Context;

        public ProdutoRepository(ProdutoRepository context)
        {
            Context = context;
        }
        public void Inserir(Produto produto)
        {
            Context.Produtos.Add(produto);
            Context.SaveChanges();
        }

        public void Editar(Produto produto)
        {
            Context.Produtos.Update(produto);
            Context.SaveChanges();
        }
        public void Excluir(Produto produto)
        {
            Context.Produtos.Remove(produto);
            Context.SaveChanges();
        }
        public Produto Obiter(int id)
        {
            return Context.Produtos.Find(id);
        }
        public IEnumerable<Produto> Obiter()
        {
            return Context.Produtos.ToList();
        }

    }
}