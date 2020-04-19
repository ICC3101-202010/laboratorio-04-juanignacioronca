## Laboratorio 04 Juan Roncagliolo

### Parte 5:
Responda las siguientes preguntas:
1. ¿Que diferencia podría generar no haber hecho las clases base abstractas?
R: Generaría que el programa tenga código innecesario ya que se tendrían que crear clases padre y las clases hijas donde la clase padre no tendría ningún objeto. La otra forma de no tener este problema es no usar herencia pero eso hace que el código tenga lineas innecesarias las cuales podrían ser optimizadas.
2. ¿Podría haber utilizado clases abstractas en vez de las interfaces? ¿ Que consecuencias tendría?
R: Si ya que funcionan de manera similar, pero hace que el código sea menos optimo.
3. Explique cómo sabe .NET que implementación de un método heredado utilizar si se esta
refiriendo a una instancia de la clase hija a través de la clase padre.
R: Lo sabe ya que en el programa uno le tiene que poner de donde hereda, y va revisando de adentro hacia afuera, si no encuentra lo que se le esta pidiendo va escalando y buscado mas arriba hasta encontrarlo, de no ser así arroja error. 
