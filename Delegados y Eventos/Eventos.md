# Físicas
En la escena hay un jugador que es el tigre con el tag "Player", un rigidbody que tiene el script TigerBehaviourScript.cs, el cual se mueve mediante fuerzas, y gira también mediante estas. Hay una esfera rigidbody con un collider que estará estática y otra que además tendrá el script RandomSphereBehaviourScript.cs, que permite a la esfera moverse de forma aleatoria. Existen 4 cilindros que son rigidbody con collider static, con el script CilindroBehaviourScript.cs, que hace que los cilindros cambien de color al entrar en colisión, al quedarse en colisión y al salir de colisión. 

También se ha añadido un cubo rigidbody, con un collider y con el script PhysicCubeBehaviourScript.cs que permite moverla mediante fuerzas con las teclas: I, L, J, M, además de aumentar un contador cada vez que colisiona. Para que los objetos no salgan del terreno se han creado "paredes" con GameObject empty static y añadiéndo un collider.

## Ejecución
<img src="./ejecucionFisicas.gif" width="800">
