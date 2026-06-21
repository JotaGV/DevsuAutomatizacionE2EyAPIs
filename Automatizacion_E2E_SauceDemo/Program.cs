using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomatizacionSauceDemo
{
    [TestClass]
    public class CompraE2ETest
    {
        private IWebDriver driver = null!;
        private WebDriverWait wait = null!;

        [TestInitialize]
        public void Setup()
        {
            var options = new ChromeOptions();

            // Desactiva el servicio de credenciales de Chrome durante la prueba.
            options.AddUserProfilePreference("credentials_enable_service", false);

            // Desactiva el administrador de contraseñas de Chrome.
            options.AddUserProfilePreference("profile.password_manager_enabled", false);

            // Desactiva la alerta de Chrome sobre contraseñas filtradas.
            options.AddUserProfilePreference("profile.password_manager_leak_detection", false);

            // Con Selenium actualizado, Selenium Manager puede resolver
            // automáticamente el ChromeDriver compatible con el navegador instalado.
            driver = new ChromeDriver(options);

            // Maximiza la ventana para evitar problemas
            driver.Manage().Window.Maximize();

            // Espera explícita reutilizable para sincronizar el test con la página.
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        [TestMethod]
        public void RealizarCompraExitosa_E2E()
        {
            // Ir a la página principal de SauceDemo.
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            // Login con credenciales públicas de prueba.
            Escribir(By.Id("user-name"), "standard_user");
            Escribir(By.Id("password"), "secret_sauce");
            System.Threading.Thread.Sleep(2500);
            Click(By.Id("login-button"));

            // Agregar dos productos al carrito.
            System.Threading.Thread.Sleep(2500);
            Click(By.Id("add-to-cart-sauce-labs-backpack"));
            System.Threading.Thread.Sleep(2500);
            Click(By.Id("add-to-cart-sauce-labs-bike-light"));
            System.Threading.Thread.Sleep(2500);

            // Ir al carrito de compras.
            Click(By.ClassName("shopping_cart_link"));
            System.Threading.Thread.Sleep(2500);

            // Iniciar el proceso de checkout.
            Click(By.Id("checkout"));
            System.Threading.Thread.Sleep(2500);

            // Información requerida para continuar la compra.
            Escribir(By.Id("first-name"), "Enrique");
            Escribir(By.Id("last-name"), "Verdugo");
            Escribir(By.Id("postal-code"), "55555");
            System.Threading.Thread.Sleep(2500);
            Click(By.Id("continue"));

            // Finalizar la compra.
            System.Threading.Thread.Sleep(2500);
            Click(By.Id("finish"));

            // Validar el mensaje final de compra exitosa con el formato correcto.
            string mensajeExito = ObtenerTexto(By.ClassName("complete-header"));
            Assert.AreEqual(
                "Thank you for your order!",
                mensajeExito,
                "La compra no se completó correctamente."
            );
            System.Threading.Thread.Sleep(2500);
        }

        private IWebElement EsperarElementoVisible(By locator)
        {
            // Espera hasta que el elemento exista en el DOM y sea visible.
            return wait.Until(driver =>
            {
                var element = driver.FindElement(locator);
                return element.Displayed ? element : null;
            });
        }

        private IWebElement EsperarElementoClickeable(By locator)
        {
            // Espera hasta que el elemento sea visible y esté habilitado.
            return wait.Until(driver =>
            {
                var element = driver.FindElement(locator);
                return element.Displayed && element.Enabled ? element : null;
            });
        }

        private void Click(By locator)
        {
            // Centraliza la acción de click para que todos los clicks
            EsperarElementoClickeable(locator).Click();
        }

        private void Escribir(By locator, string texto)
        {
            // Espera el campo, limpia cualquier valor previo y escribe el texto.
            var element = EsperarElementoVisible(locator);
            element.Clear();
            element.SendKeys(texto);
        }

        private string ObtenerTexto(By locator)
        {
            // Obtiene el texto de un elemento únicamente
            return EsperarElementoVisible(locator).Text;
        }

        [TestCleanup]
        public void Teardown()
        {
            // Cierra el navegador al finalizar la prueba, incluso si el test falla en algún punto.
            driver?.Quit();
        }
    }
}