# Algoritmos de Ordenamiento

> [!info] Entender estos algoritmos es fundamental para el desarrollo de software, ya que te permiten optimizar el rendimiento y la eficiencia de tus programas. 

---
## Merge Sort (Ordenamiento por Mezcla)

>  [!summary] Como funciona?

> Es un algoritmo basado en el paradigma de **"divide y vencerás"**. Divide la lista de elementos por la mitad repetidamente hasta que cada sublista tiene un solo elemento (una lista de un elemento ya está ordenada). Luego, "mezcla" (merges) estas sublistas de nuevo en orden, creando listas ordenadas cada vez más grandes hasta reconstruir la lista completa.

### Complejidad

- `Tiempo:` O(nlogn) en el mejor, promedio y peor de los casos.
- `Espacio:` O(n) porque requiere memoria adicional para crear los arreglos temporales durante la mezcla.

### Aplicaciones en Software

- `Bases de Datos y Ordenamiento Externo:` Es excelente cuando el conjunto de datos es demasiado grande para caber en la memoria RAM y debe leerse desde el disco duro (external sorting).
- `Lenguajes de Programacion:` Muchos lenguajes lo usan (o variaciones como Timsort) para sus funciones de ordenamiento nativas porque es un algoritmo _estable_ (mantiene el orden relativo de elementos con el mismo valor).

---

## Quick Sort (Ordenamiento Rapido)

> [!summary] Como funciona?

>También usa "divide y vencerás". Elige un elemento de la lista llamado **pivote**. Luego, reorganiza la lista de manera que todos los elementos menores que el pivote queden a su izquierda, y los mayores a su derecha. Finalmente, aplica este mismo proceso de forma recursiva a las sublistas de la izquierda y la derecha.

### Complejidad

- `Tiempo:` O(nlogn) en el caso promedio. En el peor de los casos (si el pivote elegido es siempre el extremo) cae a O(n2), pero con buenas técnicas para elegir el pivote, esto es raro.
- `Espacio:` O(logn) debido a las llamadas en la pila de recursividad.

### Aplicaciones de Software

- `Sistemas y librerias estandar:` Es el algoritmo de ordenamiento por defecto en muchas librerías estándar (como la función `qsort` en C o el ordenamiento de tipos primitivos en Java) porque, en la práctica, sus constantes ocultas son muy pequeñas y es extremadamente amigable con la memoria caché del procesador.

---

## Heap Sort (Ordenamiento por Monticulos)

> [!summary] Como funciona?

> Convierte el arreglo en una estructura de datos de árbol binario llamada **Max-Heap** (donde el nodo padre siempre es mayor que sus hijos). Una vez construido el árbol, el elemento más grande queda en la raíz (la primera posición del arreglo). El algoritmo intercambia esta raíz con el último elemento, reduce el tamaño del Heap en uno, y vuelve a balancear el árbol. Repite esto hasta que todos los elementos estén ordenados.

### Complejidad

- `Tiempo:` O(nlogn) en el mejor, promedio y peor de los casos.
- `Espacio:` O(1) porque ordena los elementos en el mismo arreglo (in-place), sin requerir memoria extra. 

### Aplicaciones de Software

- `Sistemas embebidos y de tiempo real:` Como no usa memoria adicional y su tiempo de ejecución está garantizado en O(nlogn), es ideal para sistemas con recursos muy limitados (como el kernel de Linux) donde un fallo por falta de memoria o un pico de lentitud repentino (como el peor caso de Quick Sort) sería catastrófico.

---

## Shell Sort 

>[!summary] Como Funciona?

> El **Shell Sort** es una mejora directa del algoritmo de inserción simple (_Insertion Sort_). Fue diseñado por Donald Shell en 1959 para romper uno de los mayores problemas de la inserción: que un elemento muy pequeño al final de la lista tenga que moverse una posición a la vez a través de todo el arreglo.

-> `Como funciona el Algoritmo?

> La idea central es la 'Ganancia de Distancia'. En lugar de comparar elementos adyacentes, el Shell Sort compara que estan a una distancia determinada (llamada brecha o gap).

1. **Divide y venceras (Parcialmente):** Se elige una brecha inicial (usualmente n/2)
2. **Ordena subgrupos:** Se ordenan los elementos que están separados por esa brecha.
3. **Reduce la brecha:** La brecha se reduce (normalmente a la mitad) y se repite el proceso.
4. **Fase final:** Cuando la brecha llega a **1**, el algoritmo se comporta como un _Insertion Sort_ normal, pero con la ventaja de que la lista ya está "casi ordenada", por lo que termina rapidísimo.

### Complejidad

- `Peor caso:` Con la secuencia original (n/2k), su complejidad es de O(n2).
- `Caso promedio:` Con secuencias más optimizadas (como la de Knuth), puede llegar a ser O(n3/2) o incluso O(nlog2n).
- `Espacio:` Es un algoritmo **in-place** (O(1)), lo que significa que no requiere memoria extra significativa.

### Aplicaciones en Software

- `Sistemas Embebidos y Microcontroladores:` Debido a que el código es extremadamente corto y no utiliza recursividad (evitando el riesgo de _Stack Overflow_), es ideal para hardware con memoria muy limitada.
- `Bibliotecas de C (uclibc):` Algunas implementaciones de la biblioteca estándar de C lo prefieren sobre otros algoritmos más complejos por su simplicidad.
- `Compresion de Datos:` Se utiliza en ciertos pasos de algoritmos de compresión donde los conjuntos de datos son pequeños o están parcialmente ordenados.
- `Casi-Ordenado:` Si sabes que tus datos ya están mayormente en orden y solo necesitas un "ajuste" final rápido sin la sobrecarga de un algoritmo recursivo pesado.

---

## Explicacion de La Notacion Big O (O)

> Es la forma Estandar de medir la complejidad. Imagina que tienes una lista de n elementos:

- **O(1) - Tiempo Constante:** El algoritmo tarda lo mismo sin importar si tienes 10 datos o 10 millones.

 >[!example] Ejemplo: Acceder al primer elemento de un array.

- **O(n) - Tiempo Lineal:** El tiempo crece proporcionalmente a los datos.

>[!example] _Ejemplo:_ Buscar un nombre en una lista desordenada (tienes que leer uno por uno).

- **O(n2) - Tiempo Cuadrático:** El tiempo se dispara. Si doblas los datos, el tiempo se cuadruplica.

>[!example] _Ejemplo:_ Dos bucles `for` anidados (común en ordenamientos básicos como el de burbuja).

- **O(logn) - Tiempo Logarítmico:** Es el "santo grial" de las búsquedas. A medida que los datos crecen, el tiempo aumenta muy poco.

>[!example] _Ejemplo:_ Búsqueda binaria.



## Overview

>[!success] Esta imagen es un gráfico que ilustra el concepto de la Notación O Grande. Representa visualmente cuánto tiempo o espacio le tomaría a una función o algoritmo completar una tarea determinada. En otras palabras, nos ayuda a comprender mejor la complejidad de un algoritmo y su eficiencia a medida que aumenta el número de elementos que debe procesar.

## O

>[!success] The vertical axis of this chart is represented by the letter O, which represents the output of the algorithm. It measures the number of operations or the time complexity of an algorithm. A smaller value on this axis represents better efficiency and is more desirable.

## N

>[!success] El eje horizontal de este gráfico está representado por la letra N. Representa el número de elementos del conjunto de datos sobre los que el algoritmo realiza sus operaciones. Por ejemplo, podría tratarse de una matriz de 10 elementos que se buscan para un elemento específico.

## O(1)

>[!success] En la parte inferior del gráfico, vemos la notación O(1), que representa la complejidad de tiempo constante. El tiempo que tarda este algoritmo no aumenta con el número de elementos en el conjunto de datos. Un ejemplo de una función O(1) es acceder a un elemento de una matriz por su índice.

## O(log N)

>[!success] La siguiente notación, O(log N), se denomina complejidad temporal logarítmica. A medida que aumenta el número de elementos en la entrada, el número de operaciones crece logarítmicamente. El ejemplo más común de este tipo de función es la búsqueda binaria.

## O(N)

>[!success] Al ascender en el gráfico, O(N) se conoce como complejidad temporal lineal. Esto significa que el algoritmo crece linealmente con el número de elementos en el conjunto de datos. A medida que el número de elementos se duplica, también lo hace el tiempo que tarda en completarse la función. Buscar un elemento en una matriz sin ordenar es un ejemplo de una función de complejidad temporal lineal.

## O N(log N)

>[!success] La siguiente notación en nuestro gráfico es O(N log N), o tiempo lineal-ítmico. La complejidad temporal de dicha función es directamente proporcional al número de elementos multiplicado por el logaritmo del número de elementos. Los algoritmos de ordenamiento más eficientes, como el ordenamiento por fusión o el ordenamiento rápido, tienen una complejidad temporal promedio de O(N log N).

## O(N^3)

>[!success] Subiendo, vemos la notación O(N^3), que representa la complejidad temporal cúbica. A medida que aumenta el número de elementos, el tiempo que tarda el algoritmo en completar su tarea crece de forma cúbica. Un ejemplo de un algoritmo con esta complejidad temporal es cuando buscamos tres números en un conjunto que suman cero.

## O(2^N)

>[!success] La notación O(2^N) representa una complejidad temporal exponencial. Esto significa que, a medida que aumenta el número de elementos, la complejidad temporal se duplica con cada elemento añadido. Un ejemplo de este algoritmo es calcular el n-ésimo número de Fibonacci mediante un enfoque recursivo sin memorización.

## O(N!)

>[!success] La notación más alta en este gráfico es O(N!). Esto representa una complejidad temporal factorial. El algoritmo requiere N! operaciones para completarse, donde N es el tamaño del conjunto de datos. A menudo se considera uno de los peores escenarios en términos de rendimiento. Un ejemplo de un algoritmo con esta complejidad temporal es la solución del problema del viajante mediante fuerza bruta.

