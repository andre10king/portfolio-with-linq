using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_reserva_linq.Models
{
    public class GestorReservaandres
    {
        static void Main(string[] args)
        {
          
        }

        public IEnumerable<Models.Reservaandres> GetReservaandres()

        {
            using (Models.Aviatur70Entities db = new Models.Aviatur70Entities())
            {


                IEnumerable<Models.Reservaandres> lst =
                    from r in db.Reservaandres.Where(x => x.origen.Contains("panama") || x.origen.Contains("rio de janeiro")).ToList()
                    select r;


                foreach (var oElement in lst)
                {


                    Console.WriteLine(oElement.nombre + oElement.categoria + "\t\t\t" + oElement.origen);
                }

                return lst;

            }


        }
    }






}