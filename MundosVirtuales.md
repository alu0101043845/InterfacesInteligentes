Responde a las siguiente cuestiones:

- Qué funciones se pueden usar en los scripts de Unity para llevar a cabo traslaciones, rotaciones y escalados.

        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        
        transform.Translate();
      
        transform.Rotate();
        
        transform.localScale += new Vector3(0.1F, 0, 0);
        
- ¿Cómo duplicarías el tamaño de un objeto en en un script?.

        transform.localScale *= 2;

- Cómo situarías un objeto en la posición (3,5,1.)

        transform.position = new Vector3(3.0f, 5.0f, 1.0f);
        
- Como trasladarías 3 metros en cada uno de los ejes y luego lo rotas 30º alrededor del eje Y?

        transform.Translate(new Vector3(3, 3, 3));
        
        transform.Rotate(Vector3.up * 30);

- Como rotarías un objeto sobre el eje (1,1,1)

        transform.Rotate(Vector3.right * sin(45));
        
        transform.Rotate(Vector3.up * sin(45));
        
        Realizar la rotación deseada.
        
        transform.Rotate(Vector3.right * -sin(45));
        
        transform.Rotate(Vector3.up * -sin(45));

- Rota un objeto alrededor del eje Y 30ª y desplázalo 3 metros en cada uno de los ejes. ¿Obtendrías el mismo resultado que en 4?

        transform.Rotate(Vector3.up * 30);
        
        transform.Translate(new Vector3(3, 3, 3));
        
        No se obtiene el mismo resultado, ya que el desplazamiento se hace en otras direcciones.
        
- Como puedes obtener la distancia al plano cerca del volumen de vista
        
        Camera.nearClipPlane
        
- Como puedes realizar la proyección al espacio 2D

        La proyección al espacio 2D, el que se muestra en las pantallas se obtiene mediante el uso de la cámara de Unity.
        WorldToViewportPoint (Vector3 position);
        
- Investiga qué son los quaternion.

        Son usados para representar las rotaciones u orientaciones de los objetos. 
        Permiten evitar los Gimbal Lock pero no pueden representar una rotación que exceda los 180 grados.
        
- Analiza la documentación de la cámara en Unity 3D: https://docs.unity3d.com/es/current/Manual/CamerasOverview.htmlhttps://docs.unity3d.com/es/current/Manual/class-Camera.html e identifica los conceptos explicados respecto a la cámara.

        En la documentación se indican los dos tipos de cámaaras, la cámara perspectiva, la cual nos permite simular profundidad, viendo los objetos lejanos de menor tamaño que los cercanos. El otro tipo de cámara es la ortogonal, la cual es muy útil en arquitectura y en la creación de planos, ya que nos aporta información geométrica.
        También se explica el concepto de volumen de vista, que es la región 3D que va a ser proyectada y la cual se ve, además se explica el fondo de vista, el cual nos permite simular el cielo.
        Se explican bastantes más conceptos, así como funciones y atributos de la cámara, cómo trabajar con varias cámaras, etc.
        
- ¿Como puedes averiguar la matriz de proyección que se ha usado para proyectar la escena al último frame renderizado?.

        Camera.previousViewProjectionMatrix
        
- ¿Cómo puedes obtener la matriz de transformación entre el sistema de coordenadas local y el mundial?.
        
        Transform.worldToLocalMatrix
                
        Transform.localToWorldMatrix
        
- ¿Como puedes calcular las coordenadas del sistema de referencia de un objeto con las siguientes propiedades del Transform:?: 
 Position (3, 1, 1), Rotation (45, 0, 45)
 
        El sistema de referencia del objeto ya está descrito respecto al del mundo con las propiedades Position y Rotation, que indican el la posición y la orientación de este.
