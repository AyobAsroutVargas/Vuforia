# Vuforia

## Modelo usado

Se ha incluido el modelo Astronaut del paquete Vuforia Core Samples

## Evento

Para el evento simplemente se ha añadido al target image un script que implementa una funcion para cambiar el color del material del target model a otro aleatorio.

Y haciendo uso del Default Observer Event Handler que vuforia añade a nuestro target image podemos llamar a esta funcion en los eventos OnTargetFound y OnTargetLost. En concreto hacemos que llame al evento changeColor OnTargetFound y OnTargetLost.

## Ejecución
