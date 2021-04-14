using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONG.BL
{
    public class Bodega
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Ingrese la bodega")]
        public string Descripcion { get; set; }
    }
}
