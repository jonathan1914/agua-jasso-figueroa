using System;
using System.Linq;
using System.Threading.Tasks;
using agua2019.Controllers;
using agua2019.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace agua2019.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnSuccess_ForCalcular()
        {
            // Arrange
            var controller = new HomeController();
            var proximoCumple = DateTime.Today.AddDays(1);
            var lapso = proximoCumple - DateTime.Today;
            DateTime hoy = DateTime.Today;
            int totalDays = proximoCumple.Subtract(hoy).Days;

            int domingos = Enumerable.Range(1, totalDays)
                .Select(item => new DateTime(DateTime.Today.Year, DateTime.Today.Month, item))
                .Where(date => date.DayOfWeek == DayOfWeek.Sunday)
                .Count();


            // Act
            var viewResult = controller.Calcular(proximoCumple, 10) as ViewResult;
            var resultado = viewResult.Model as AguaViewModel;




            // Assert
            Assert.NotNull(viewResult);
            Assert.Equal<int>(120, resultado.Botellas);
            Assert.Equal<int>(1, resultado.Dias);
            Assert.Equal<int>(domingos, resultado.Domingos);
        }
    }
}
