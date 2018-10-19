Examen de acceso a datos
# ExamenAccesoDatos
## Nombre: Gonzalo José 
## Apellidos: Caballero Ponce
## DNI: 15402396D

## Pregunta 1
La principal diferencia entre IQueryable<T> e IEnumerable<T> es que en el IEnumerable se pueden meter los delegados y en el IQueryable se tienen Expressions, con lo que se puede obtener un árbol AST y con el visitior pattern obtener los resultados que quiera. 
Otra diferencia importante entre ambos es que el IQueryable es la interfaz que se usa para hacer consultas LINQ a SQL en el servidor de una base de datos, mientras que IEnumerable se usa para hacer consultas LINQ a objetos, trabajando con un conjunto de datos que se inorporan en la memoria antes de realizar la consulta. 
Con IEnumerable se usa Where.Utilizando IQueryable se obtienen los datos que se quieren más rápidamente ya que si se usa IEnumerable todos los datos se cargan en la memoria.

## Pregunta 2a
Lo que he hecho ha sido definir una variable result que devuelve los valores que hay en a y no están en b utilizando except. Luego he hecho un foreach que me da todos los números que haya en result. En el caso del enunciado el foreach solo me da un número, que es el 3.

## Pregunta 2b

## Pregunta 3
Lo he hecho utilizando un array con valores, y luego usando for e if para que me devuelva de ese array los números pares y los números mayores y menores que 10, por separado.

## Pregunta 4
He utilizado una expresión LINQ, definiendo una variable entera max que dice que que de la secuencia que he creado (from) seleccione (select) el número Máximo (Max).

## Pregunta 5
Los objetos básicos de ADO.NET son los siguientes:
Connection: Proporciona conectividad a un origen de datos. También actúa como abstract factory para los objetos command.

Command: Permite tener acceso a comandos de bases de datos para devolver datos, modificarlos, ejecutar procedimientos almacenados y enviar o recuperar información sobre parámetros. Se usa para realizar alguna acción en la fuente de datos, como lectura, actualización o borrado.

Parameter: Describe un parámetro para un command.


## Pregunta 6
Se hace utilizando un delegado que tiene dos parámetros de entrada (a, b)y un parámetro de salida, que puede ser la suma (a+b) o la multiplicación (a*b).

