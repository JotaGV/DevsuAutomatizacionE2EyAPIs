# Devsu - Ejercicios de Automatización E2E y APIs

Este repositorio contiene la resolución de los dos ejercicios prácticos solicitados como parte del proceso de selección de Devsu:
1. Automatización E2E sobre una aplicación web.
2. Automatización de pruebas sobre APIs.

Cada ejercicio se encuentra organizado en una carpeta independiente, con su código, archivos de apoyo, evidencias, instrucciones de ejecución y conclusiones correspondientes.

## 1. Automatización E2E - SauceDemo
El primer ejercicio corresponde a una prueba automatizada E2E sobre la aplicación web:
https://www.saucedemo.com/

La prueba valida el flujo completo de compra exitosa, cubriendo:

* Login en la aplicación.
* Selección de productos.
* Agregado de productos al carrito.
* Inicio del checkout.
* Ingreso de datos del comprador.
* Finalización de la compra.
* Validación del mensaje final de éxito.

### Tecnologías utilizadas
* C#
* .NET 8
* MSTest
* Selenium WebDriver
* ChromeDriver
* Google Chrome

### Evidencias incluidas
Dentro de la carpeta del ejercicio se incluyen evidencias de ejecución, incluyendo el archivo de resultados generado mediante dotnet test y capturas del resultado exitoso en Test Explorer.

Para más detalle, revisar:
Automatizacion_E2E_SauceDemo/readme.txt
Automatizacion_E2E_SauceDemo/conclusiones.txt

## 2. Automatización de APIs - PetStore

El segundo ejercicio corresponde a pruebas de API sobre el servicio público:
https://petstore.swagger.io/v2

La prueba valida un flujo básico de gestión de mascotas utilizando Postman, cubriendo:
* Agregar una mascota a la tienda.
* Consultar la mascota ingresada por ID.
* Actualizar el nombre y el estatus de la mascota.
* Consultar la mascota modificada por estatus.

### Herramientas utilizadas
* Postman Desktop
* Collection de Postman
* Scripts de validación en la pestaña Tests
* Variables de collection para encadenamiento de requests

### Evidencias incluidas
Dentro de la carpeta del ejercicio se incluyen evidencias de ejecución de los requests y validaciones exitosas.

Para más detalle, revisar:
Automatizacion_APIs_PetStore/readme.txt
Automatizacion_APIs_PetStore/conclusiones.txt

## Instrucciones generales
Para revisar o ejecutar cada ejercicio, ingresar a la carpeta correspondiente y seguir las instrucciones indicadas en su respectivo archivo readme.txt.

Cada ejercicio incluye:
* Archivos fuente o collection correspondiente.
* Instrucciones paso a paso de ejecución.
* Evidencias de ejecución.
* Archivo de conclusiones con hallazgos técnicos y posibles mejoras futuras.

## Entregable
El repositorio público contiene el desarrollo de ambos ejercicios solicitados:

* Automatización E2E.
* Automatización de APIs.

URL del repositorio:
https://github.com/JotaGV/DevsuAutomatizacionE2EyAPIs

## Autor
Jorge Guamán Verdugo
GitHub: JotaGV
