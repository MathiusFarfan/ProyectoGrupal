using Aplication;
using Domain.Model.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
        public void ValidacionDeLoginUsuario()
        {
            UsuarioController usuario = new UsuarioController();
            Usuario user = new Usuario();
            string correo = "emailNEW";
            string contra = "3333";
            object[] login = usuario.IniciarUsuario(correo, contra);
            Assert.IsNotNull(login);
        }
        [TestMethod]
        public void ComprobarIncorrectaLonguitudDNI()//TDD
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

        [TestMethod]
        public void RegistroDetallePedido()
        {
            DetallePedidoService user = new DetallePedidoService();

            bool x = user.RegistrarDetallePedido(new DetallePedido() {Pedido=new Pedido() {ID_Pedido=20},Material=new Material() {ID_Material=6},Cantidad=50,PrecioUnit=1,SubTotal=1});
            Assert.AreEqual(true,x);
        }

        [TestMethod]
        public void Activar_Empleado()
        {
            EmpleadoService employee = new EmpleadoService();
            Empleado person = new Empleado();
            person.ID_EMPLEADO = 1;
            bool correcto = employee.ActivarEmpleado(person.ID_EMPLEADO);
            Assert.AreEqual(true, correcto);
        }
        [TestMethod]
        public void Desactivar_Empleado()
        {
            EmpleadoService employee = new EmpleadoService();
            Empleado person = new Empleado();
            person.ID_EMPLEADO = 1;
            bool correcto = employee.DesactivarEmpleado(person.ID_EMPLEADO);
            Assert.AreEqual(true, correcto);
        }
        [TestMethod]
        public void Actualizar_Contacto_al_Cliente()
        {
            ClienteService client = new ClienteService();
            Cliente person = new Cliente();
            person.ID_Cliente = 31;
            bool correcto = client.ActualizarCliente(31, "emailNEW", "telefonoN");
            Assert.AreEqual(true, correcto);
        }
        [TestMethod]
        public void Registrar_Cliente()
        {
            ClienteService customer = new ClienteService();
            bool resultado = customer.RegistrarCliente("12345678", "NOMBRE1", "APELLIDO1", "Av. Calle 123123", "email1", "telefono1", "1111");
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void Registrar_Cliente_DNI_Incorrecto()
        {
            ClienteService customer = new ClienteService();
            bool resultado = customer.RegistrarCliente("123456789", "NOMBRE1", "APELLIDO1", "Av. Calle 123123", "email1", "telefono1", "1111");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Registrar_Empleado()
        {
            EmpleadoService employee = new EmpleadoService();
            bool resultado = employee.RegistrarEmpleado("Secretario", "Administracion", "47383067", "PRUEBA03", "XD", "Av. XD", "emailNEW", "telefonoN", "3333");
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void Registrar_Empleado_DNI_Incorrecto()//TDD
        {
            EmpleadoService employee = new EmpleadoService();
            Empleado person = new Empleado();

            bool resultado = employee.RegistrarEmpleado("Secretario", "Administracion", "123456789", "PRUEBA03", "XD", "Av. XD", "emailNEW", "telefonoN", "3333");
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void Buscar_Empleado()
        {
            EmpleadoService employee = new EmpleadoService();
            List<Empleado> busqueda = employee.BuscarEmpleado("47383067");
            Assert.IsNotNull(busqueda);
        }
        [TestMethod]
        public void Buscar_Cliente()
        {
            ClienteService employee = new ClienteService();
            List<Cliente> busqueda = employee.BuscarCliente("47383067");
            Assert.IsNotNull(busqueda);
        }

        [TestMethod]
        public void Registrar_Pedido()
        {
            PedidoService obj = new PedidoService();

            int resultado = obj.RegistrarPedido(1,1,1,1000.00);
            Assert.IsNotNull(resultado);
        }
        [TestMethod]
        public void Listar_Pedidos()
        {
            PedidoService obj = new PedidoService();

            List<Pedido> resultado = obj.ListarPedidos("97875450");
            Assert.IsNotNull(resultado);
        }
        [TestMethod]
        public void Buscar_Estado_Pedido()
        {
            PedidoService obj = new PedidoService();

            bool resultado = obj.VerificarEstadoPedido(1);
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void Buscar_Detalle_Pedido()
        {
            DetallePedidoService obj = new DetallePedidoService();

            List<DetallePedido> detalles = obj.BuscarDetallePedido(1);
            Assert.IsNotNull(detalles);
        }
        [TestMethod]
        public void Buscar_Material()
        {
            MaterialService obj = new MaterialService();

            List<Material> detalles = obj.BuscarMaterial("Pomello");
            Assert.IsNotNull(detalles);
        }
        [TestMethod]
        public void Aumentar_Stock_Material()
        {
            MaterialService obj = new MaterialService();

            bool resultado = obj.AumentarStock(1,10);
            Assert.IsTrue(resultado);
        }
    }
}