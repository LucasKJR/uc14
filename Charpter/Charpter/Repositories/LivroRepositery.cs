using Charpter.Contexts;
using Charpter.Models;

namespace Charpter.Repositories
{
    public class LivroRepositery
    {
        private readonly Sqlcontext _context;
        public LivroRepositery(Sqlcontext context) 
        {
                _context = context;

        }
        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }
        

    }
}
