using Aplication;
using Domain.Model.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UI.Desktop.AplicationController;

namespace TestProyecto_SIVET
{
    [TestClass]
    public class PruebasSIVET
    {
        [TestMethod]
        public void ValidacionDeLoginUsuarioInexistente()
        {
            UsuarioController usuario = new UsuarioController();
            Usuario user = new Usuario();
            string correo = "correomisterioso1";
            string contra = "contrasena";
            object[] login = usuario.IniciarUsuario(correo, contra);
            Assert.IsNull(login);
        }

        [TestMethod]
        public void ComprobarIncorrectaLonguitudDNI()
        {
            UsuarioService user = new UsuarioService();
            string dni = "123456789";
            string Nombre = "nombre1";
            string Apellido = "apellidos1";
            string Direccion = "direccion1";
            string Email = "email1";
            string Telefono = "telefono1";
            string Contrasenia = "contra1";

            int x = user.RegistrarUsuario(dni, Nombre, Apellido, Direccion, Email, Telefono, Contrasenia);
            Assert.AreEqual(x, -1);
        }
    }
}
