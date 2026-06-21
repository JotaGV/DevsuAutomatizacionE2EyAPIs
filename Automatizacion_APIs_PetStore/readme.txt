PETSTORE - OPCION 3 - PRUEBAS DE API (MASCOTAS)
README - INSTRUCCIONES DE EJECUCION

1. DESCRIPCION

Este proyecto contiene la ejecucion de pruebas de API sobre el servicio publico:
https://petstore.swagger.io/v2

La prueba valida el flujo de gestion de mascotas de la API PetStore utilizando una collection de Postman con requests encadenados y validaciones automaticas.

2. HERRAMIENTAS UTILIZADAS

- Herramienta principal: Postman Desktop.
- Tipo de prueba: Pruebas de API.
- API probada: PetStore - Swagger.
- URL base: https://petstore.swagger.io/v2
- Metodo de ejecucion: Manual desde Postman, con validaciones automatizadas en la pestana Tests.
- Fecha de ejecucion: Junio 2026.

3. PRECONDICIONES

Antes de ejecutar la collection, verificar:

- Tener instalado Postman Desktop.
- Tener conexion a Internet.
- Tener generado el archivo PetStore-Tests.postman_collection.json generado con los 4 casos de prueba definidos:
    POST: Agregar una mascota a la tienda.
    GET: Consultar la mascota ingresada por ID.
    PUT: Modificar el nombre y status de la mascota.
    GET: Consultar la mascota modificada por estatus.
- Importar la collection en un workspace de Postman.
- Verificar que la variable baseUrl tenga el valor:
  https://petstore.swagger.io/v2

No se requiere instalacion de servidor local, ya que la API corresponde a un sandbox publico online.

4. ARCHIVOS INCLUIDOS

- PetStore.postman_collection.json
  Collection con los 4 requests del ejercicio, sus bodies, parametros y scripts de validacion.

- Evidencias/
  Carpeta con capturas de cada request ejecutado exitosamente, mostrando status 200 y validaciones en estado PASSED.

- conclusiones.txt
  Archivo con los hallazgos, resultados y conclusiones del ejercicio.

5. EJECUCION PASO A PASO

Paso 1:
Abrir Postman Desktop e ingresar al workspace donde se desea trabajar.

Paso 2:
Importar la collection.

Para ello:
- Hacer clic en el boton Import.
- Seleccionar o arrastrar el archivo PetStore.postman_collection.json.
- Confirmar la importacion.
- Verificar que la collection PetStore aparezca en el panel Collections.

Paso 3:
Verificar las variables de la collection.

Para ello:
- Hacer clic en el nombre de la collection.
- Abrir la pestana Variables.
- Confirmar que la variable baseUrl tenga el valor:
  https://petstore.swagger.io/v2
- Considerar que la variable petId se completa automaticamente al ejecutar el primer request.

Paso 4:
Ejecutar los requests en el orden definido en la collection, ya que cada request depende de datos generados por el anterior.

Paso 5:
Ejecutar el request:
1. Agregar una mascota a la tienda

Validar:
- Status 200 OK.
- Presencia del id de la mascota.
- Nombre correcto.
- Estado correcto.

Paso 6:
Ejecutar el request:
2. Consultar la mascota ingresada por ID

Validar:
- Status 200 OK.
- Que el id coincida con el generado en el primer request.
- Que el nombre de la mascota sea correcto.

Paso 7:
Ejecutar el request:
3. Actualizar nombre y status a sold

Validar:
- Status 200 OK.
- Nombre actualizado a Firulais Adoptado.
- Status actualizado a sold.

Paso 8:
Ejecutar el request:
4. Consultar mascota modificada por estatus

Validar:
- Status 200 OK.
- Que la respuesta sea un arreglo.
- Que la mascota creada aparezca dentro del listado con status sold.

Paso 9:
Revisar los resultados de las validaciones automaticas en la pestana Test Results de cada request.

Cada validacion en estado PASSED confirma que la API respondio segun lo esperado.

6. CASOS DE PRUEBA EJECUTADOS
Los casos incluidos en la collection son:

- Agregar una mascota a la tienda.
- Consultar la mascota ingresada por ID.
- Actualizar el nombre de la mascota y el status a sold.
- Consultar la mascota modificada por estatus.

7. RESULTADO ESPERADO
La ejecucion completa debe finalizar con:

- 4 de 4 requests ejecutados correctamente.
- 13 de 13 validaciones automaticas en estado PASSED.
- Status 200 OK en cada request.
- Variable petId capturada y reutilizada correctamente entre requests.
- Mascota creada, consultada, actualizada y validada dentro del listado por estatus.

8. OBSERVACIONES

- La API PetStore es un sandbox publico compartido por multiples usuarios.
- En caso de obtener un error 404 al consultar la mascota por ID, puede deberse a una demora de propagacion del servidor. En ese caso, se recomienda reenviar el request.
- El endpoint findByStatus puede devolver multiples registros de otros usuarios del sandbox. Por esta razon, la validacion debe buscar la mascota creada por id dentro del arreglo de respuesta.
- La variable petId se captura dinamicamente desde el primer request y se reutiliza en los siguientes, evitando copiar datos manualmente.
