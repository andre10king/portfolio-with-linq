//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace back_reserva_linq.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservaandres
    {
        public int id_reserva { get; set; }
        public string nombre { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string categoria { get; set; }
        public Nullable<int> cantpasj { get; set; }
        public string cedula { get; set; }
    }
}
