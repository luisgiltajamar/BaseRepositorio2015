using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BaseRepositorio.ViewModel;

namespace BaseRepositorio.Repositorio
{
   public interface IRepositorio<TModelo,TViewModel> where TModelo:class 
                        where TViewModel : IViewModel<TModelo>
   {
       TViewModel Add(TViewModel model);
       int Borrar(TViewModel model);
       int Borrar(Expression<Func<TModelo, bool>> consulta);
       int Actualizar(TViewModel model);
       ICollection<TViewModel> Get();
       TViewModel Get(params Object[] keys);
       ICollection<TViewModel> Get(Expression<Func<TModelo, bool>> consulta);

   }

}
