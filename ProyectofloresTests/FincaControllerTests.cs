using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
namespace ProyectofloresTests
{
    [TestClass]
    public class FincaControllerTests
    {
        [TestMethod]
        public void vistalista()
        {
            string result = Proyectoflores.Controllers.FincaController.vistalista();
            Assert.AreEqual("lst", result);
        }
    }
}
