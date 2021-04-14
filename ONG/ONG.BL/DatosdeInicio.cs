using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ONG.BL
{
   public  class DatosdeInicio: CreateDatabaseIfNotExists<Contexto>
         
    {
            
        protected override void Seed(Contexto contexto)
        {

            var gabriela = new Usuario();
            gabriela.Nombre = "gabriela";
            gabriela.contrasena = Encriptar.CodificarContrasena("123");
            var catherin = new Usuario();
            catherin.Nombre = "catherin";
            catherin.contrasena = Encriptar.CodificarContrasena("0421");
            var nelson = new Usuario();
            nelson.Nombre = "nelson";
            nelson.contrasena = Encriptar.CodificarContrasena("123");
            var denuar = new Usuario();
            denuar.Nombre ="denuar";
            denuar.contrasena = Encriptar.CodificarContrasena("1234");
            var rocio = new Usuario();
            rocio.Nombre = "rocio";
            rocio.contrasena = Encriptar.CodificarContrasena("0990");


            contexto.Usuarios.Add(gabriela);
            contexto.Usuarios.Add(nelson);
            contexto.Usuarios.Add(catherin);
            contexto.Usuarios.Add(rocio);
            contexto.Usuarios.Add(denuar);

            base.Seed(contexto);
        }

    }
}
