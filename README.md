# Tutorial Roll a Ball

## Creacion de los objetos 3D:

- Player (Sphera)
- Enemy (Box)
- Floor
- Walls
- PickUp

<img width="315" height="236" alt="image" src="https://github.com/user-attachments/assets/d62cb7e8-588a-4e2c-ae18-7ba5b40f5a1a" />

## Creacion de Materials

Cuando creamos los objetos simplemente arrastramos los materials y ya se modifica el color

<img width="651" height="936" alt="image" src="https://github.com/user-attachments/assets/edaff6bd-ded7-45e8-991e-da806d295200" />

<img width="618" height="135" alt="image" src="https://github.com/user-attachments/assets/96d8d46f-5647-4911-b0a6-33e37f9a41f6" />


## Creacion de Scripts

### ```CameraController```

En este script lo que hago es cofigurar la camara, para que siga al jugador. Tenemos que meterle el script y asignarle su objetivo como vemos en la imagen. En este caso Player

<img width="437" height="79" alt="image" src="https://github.com/user-attachments/assets/35d18f6b-06e2-49a4-9209-07e6ca62aef2" />


### ```PlayerController```

Este script sirver para manejar el movimiento del Player junto con el PlaterInput

Primero le asigno unos vectores 

<img width="223" height="89" alt="image" src="https://github.com/user-attachments/assets/466d6355-25ad-44ad-964c-bb8c85fa2ff2" />

Despues le digo que se mueva por ellos y le asigno una velocidad

<img width="545" height="347" alt="image" src="https://github.com/user-attachments/assets/3a296fda-2178-4155-9b7b-086bf98faaf3" />

Tambien se encarga de contar los PickUp recolectados para ver si ha ganado

<img width="379" height="246" alt="image" src="https://github.com/user-attachments/assets/0ea64d8a-2b84-4a6e-b3bc-eb950f0ceeb5" />

Por ultimo tiene una funcion para comprobar si colisionó con el Enemy y mostrar el mensage de derrota

<img width="596" height="250" alt="image" src="https://github.com/user-attachments/assets/ae5b2a08-39ec-4043-b46f-75382dadd7ba" />






### ```EnemyMovement```

Este script controla el movimiento del Enemy. Este va a perseguir al Player. 
Para eso es necesario meter el script en el objeto de Enemy y asignarle su objetivo, que seria el Player.

<img width="434" height="72" alt="image" src="https://github.com/user-attachments/assets/04a8649a-ce21-4680-a80e-084b6ae93d83" />


### ```Rotator```

Este script sirve para darle movimiento sobre su mismo eje a los PickUp. Para que el juego se muestre más dinamico.


## A continuacion creé los canvas:

El de coun para tener un contador de los PickUp recogidos

<img width="655" height="437" alt="image" src="https://github.com/user-attachments/assets/a5fdebad-34de-472e-b576-2a69a5e58458" />

Y otro para el mensaje de Win

<img width="157" height="50" alt="image" src="https://github.com/user-attachments/assets/2901fca8-0b74-4f95-b895-adf71cb5a146" />
