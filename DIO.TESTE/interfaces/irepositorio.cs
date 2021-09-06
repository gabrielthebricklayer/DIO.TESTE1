
using System;
using System.Collections.Generic;
using DIO.TESTE.interfaces;
    
namespace DIO.TESTE.interfaces
{
   public interface irepositorio<T>
   {
       List<T> lista();
        
        T RetornaPorId( int id);

        void Insere(T entidae);
         
         void Exclui( int id);

         void Atualiza(int id, T entidade);

         int ProximoId();

   }


}