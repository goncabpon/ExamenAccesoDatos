Examen de acceso a datos
# ExamenAccesoDatos
## Nombre: Gonzalo Jos� 
## Apellidos: Caballero Ponce
## DNI: 15402396D

## Pregunta 1
La principal diferencia entre IQueryable<T> e IEnumerable<T> es que en el IEnumerable se pueden meter los delegados y en el IQueryable se tienen Expressions, con lo que se puede obtener un �rbol AST y con el visitior pattern obtener los resultados que quiera. 
Otra diferencia importante entre ambos es que el IQueryable es la interfaz que se usa para hacer consultas LINQ a SQL en el servidor de una base de datos, mientras que IEnumerable se usa para hacer consultas LINQ a objetos, trabajando con un conjunto de datos que se inorporan en la memoria antes de realizar la consulta. 
Con IEnumerable se usa Where.Utilizando IQueryable se obtienen los datos que se quieren m�s r�pidamente ya que si se usa IEnumerable todos los datos se cargan en la memoria.

## Pregunta 2a
Lo que he hecho ha sido definir una variable result que devuelve los valores que hay en a y no est�n en b utilizando except. Luego he hecho un foreach que me da todos los n�meros que haya en result. En el caso del enunciado el foreach solo me da un n�mero, que es el 3.

## Pregunta 2b

## Pregunta 3
Lo he hecho utilizando un array con valores, y luego usando for e if para que me devuelva de ese array los n�meros pares y los n�meros mayores y menores que 10, por separado.

## Pregunta 4
He utilizado una expresi�n LINQ, definiendo una variable entera max que dice que que de la secuencia que he creado (from) seleccione (select) el n�mero M�ximo (Max).

## Pregunta 5
Los objetos b�sicos de ADO.NET son los siguientes:
Connection: Proporciona conectividad a un origen de datos. Tambi�n act�a como abstract factory para los objetos command.

Command: Permite tener acceso a comandos de bases de datos para devolver datos, modificarlos, ejecutar procedimientos almacenados y enviar o recuperar informaci�n sobre par�metros. Se usa para realizar alguna acci�n en la fuente de datos, como lectura, actualizaci�n o borrado.

Parameter: Describe un par�metro para un command.


## Pregunta 6
Se hace utilizando un delegado que tiene dos par�metros de entrada (a, b)y un par�metro de salida, que puede ser la suma (a+b) o la multiplicaci�n (a*b).

