AUTOMATIZACION SAUCEDEMO - INSTRUCCIONES DE EJECUCION

1. DESCRIPCION

Este proyecto contiene la automatizacion de una prueba E2E sobre la aplicacion web:
https://www.saucedemo.com/

La prueba automatizada valida el flujo de compra exitosa usando Selenium WebDriver con C# y MSTest.

2. TECNOLOGIAS UTILIZADAS

* Lenguaje: C#
* Framework de pruebas: MSTest
* Automatizacion web: Selenium WebDriver
* Navegador: Google Chrome
* IDE recomendado: Visual Studio 2022 o superior
* SDK recomendado: .NET 6 o superior
* SDK utilizado en este ejercicio: .NET 8

3. PRECONDICIONES

Antes de ejecutar el proyecto, verificar:

* Tener instalado Visual Studio o Visual Studio Code con soporte para .NET.
* Tener instalado .NET SDK.
* Tener instalado Google Chrome.
* Tener acceso a Internet para abrir:
  https://www.saucedemo.com/
* Tener restaurados los paquetes NuGet requeridos por el proyecto.

4. CONFIGURACION

Para configurar el proyecto:

* Clonar o descargar el proyecto.
* Abrir la solucion en Visual Studio.
* Restaurar los paquetes NuGet del proyecto.
* Verificar que las dependencias esten correctamente instaladas.

Paquetes principales utilizados:

* Selenium.WebDriver
* Selenium.Support
* MSTest.TestFramework
* MSTest.TestAdapter

5. EJECUCION PASO A PASO

Paso 1:
Abrir la solucion del proyecto.

Paso 2:
Compilar la solucion.

Paso 3:
Abrir el Test Explorer.

Paso 4:
Ejecutar la prueba:
RealizarCompraExitosa_E2E

Paso 5:
Esperar a que la automatizacion complete el flujo:

* Login.
* Agregar productos al carrito.
* Ir al carrito.
* Iniciar checkout.
* Completar datos.
* Finalizar compra.

Paso 6:
Validar que la prueba termine en estado Passed.

6. CASO AUTOMATIZADO

Nombre del caso:
* RealizarCompraExitosa_E2E

Descripcion:
Valida el flujo completo de compra exitosa en SauceDemo utilizando el usuario de prueba:
* Usuario: standard_user
* Password: secret_sauce

El flujo automatizado contempla:

* Ingreso a la pagina principal.
* Autenticacion con credenciales validas.
* Seleccion de productos.
* Agregado de productos al carrito.
* Acceso al carrito.
* Inicio del checkout.
* Ingreso de informacion del comprador.
* Finalizacion de la orden.
* Validacion del mensaje final de compra exitosa.

7. RESULTADO ESPERADO

La prueba debe finalizar correctamente mostrando el mensaje con este formato, no con mayúsculas ya que asi lo devuelve la pagina:
"Thank you for your order!"

8. OBSERVACIONES

* Se configuraron opciones de Chrome para desactivar popups del administrador de contrasenas y deteccion de fuga de contrasenas, ya que interferian con la ejecucion automatica.
* Se utilizaron esperas explicitas para mejorar la estabilidad de la automatizacion.
* Se agregaron pausas visuales para permitir observar el paso a paso de la ejecucion, segun necesidad de demostracion.
* La automatizacion utiliza credenciales publicas de prueba proporcionadas por SauceDemo.
* Las opciones configuradas en Chrome aplican solo para la instancia del navegador utilizada por Selenium durante la ejecucion de la prueba.
* Como evidencia de ejecución se incluye el archivo testResults.trx generado mediante dotnet test, junto con capturas de la ejecución correcta por consola y del resultado Passed en el Test Explorer.

9. REPOSITORIO GITHUB

Como parte de la entrega, el proyecto fue publicado en un repositorio público de GitHub. 
La URL del repositorio debe colocarse también en los comentarios del ejercicio, según lo solicitado en las instrucciones.

URL del repositorio:
https://github.com/JotaGV/AutomatizacionSauceDemo
