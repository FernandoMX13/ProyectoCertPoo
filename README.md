# Proyecto Final del Curso de Programación Orientada a Objetos del programa de Becarios-CERT

## Proyecto realizado por:
## Ceron Rodriguez Lesly Dialid
## Luis Fernando Resendiz Cruz
## Urbina Garrido Mauricio

## Login

![Menu de login](img/login.png)

En esta pantalla se debe ingresar el usuario y contraseña para acceder a la sección de trabajo de acuerdo al perfil.

Nuestro proyecto cuenta con tres secciones distintas: 

Administración: Administra usuarios creandolos y eliminandolos.

Gerenecial: Administra los productos que se venden agregando y eliminando produtos.

Cajero: Se realiza las compras.

## Administración

![Menu de la Administración](img/administracionMenu.png)

Para acceder a esta seccion es necesario acceder con el nombre de usuario: Mau y contraseña: 12345 desde el login

En esta seccion podemos acceder a las secciones de agregar usuarios, eliminar usuarios, regresar al login o salir del programa.

### Agregar usuario

![Interfaz para agregar usuarios](img/agregarUsuario.png)

Para agregar usuarios se solcita el nombre del usuario, contraseña, confimacion de la contraseña y puesto que desempeñara.

### Eliminar usuario

![Interfaz para eliminar usuarios ](img/eliminarUsuario.png)

En esta seccion se muestra la lista de usuarios actuales, para eliminar se puede seleccionar distintos usuarios pero no se permite eliminar todos se debe de mantener al menos un administrador para funcionar.

## Gerencial

![Menu de la Gerencia](img/gerenciaMenu.png)

Para acceder a esta seccion es necesario acceder con el nombre de usuario: Dialid y contraseña: hola123., desde el login

En esta seccion podemos acceder a la acceder a las secciones de agregar productos, eliminar productos, regresar al login o salir del programa.

### Agregar productos

![Interfaz para agregar productos](img/agregarProductos.png)

Para agregar usuarios se solcita el ID del producto que no debera ser nulo ni se debera repetir, una descripción que no se debera repetir ni ser nulo y precio que debera ser un flotante Ej. 12.00 ó 12.99

### Eliminar productos

![Interfaz para eliminar productos](img/eliminarProductos.png)

En esta seccion se muestra la lista de productos permitiendo seleccionar que productos se pueden eliminar, la unica restriccion es que debe de existir un solo producto.

## Cajero

Para acceder a esta seccion es necesario acceder con el nombre de usuario: Fer y contraseña: qwerty desde el login

![Interfaz del cajero](img/Cajero1.jpg)

La interfaz funciona ingresando un código de producto. Al presionar el botón "OK" se muestran los datos del producto. El cajero también agregará la cantidad de elementos de ese producto que agregará.

![Datos del producto](img/Cajero2.jpg)

Si se presiona el botón de "Agregar" se agregará a la lista de productos a comprar.

![Producto agregado al carrito](img/Cajero3.jpg)

Para quitar un producto de la lista se vuelve a ingresar el código del producto para ver sus datos, y se presiona el botón de eliminar. Sin imporar el valor de "Cantidad" que se le indique, sólo se eliminará 1 de ese producto.

![Eliminar producto](img/Cajero5.jpg)

Para finalizar la compra, en el cuadro para pagar se ingresa la cantidad que el cliente dará como pago.

![Pagar](img/Cajero6.jpg)

Si el dinero es igual o mayor, la compra se llevó a cabo con éxito.

![Compra finalizada](img/Cajero7.jpg)

Si el dinero es insuficiente, se le pide ingresar una cantidad mayor.

![Dinero insuficiente](img/Cajero8.jpg)

El botón de "Cancelar compra" elimina la lista de productos a comprar y reinicia el cajero.

![Cancelar compra](img/Cajero9.jpg)

## General

El programa genera una carpeta llamada "BecarioMart" donde es contenido los usuarios, productos y historila de tickets y el ticket de la ultima compra.
