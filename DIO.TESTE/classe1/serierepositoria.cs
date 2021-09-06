using System;
using System.Collections.Generic;
using DIO.TESTE.interfaces;


namespace DIO.TESTE
{
   public class serierepositoria :serierepositoria<serie>
   {
       private List<serie> listaseries = new List<serie>();
       public void Atualiza (int id, serie Objeto)
       {
          listaseries[id] = Objeto;
       }
       
       public void Exclui(int id)
       {
            listaseries[id].Exclui();
       }
       public static void Insere(serie objeto)
       {
            Listaseries.Add(objeto);

        }
        public List<serie>lista()
        {
            return listaseries;

        }
        public int ProximoId()
        {
            return listaseries.Count;

        }   
        public serie retornaPORid(int id)    
        {
            return listaseries[id];
        }



   }  
}  