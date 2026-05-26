Datos de Version: 2.0.0.:3.>:3 
Version de sistema de deteccion de errores: 0.3.0 (Magnus[ :3 ])
Sistema de ayuda para el arreglo de errores: 0.1.0 (Ferguson [ >:3 ]) 

Engine CPP implementation version: 1.0 
Engine Map Gen 1.0 

Hola! 
creo que cualquiera haya visto mi repositorio se dara cuenta aprendo haciendo cosas que definitivamente no deberia estar haciendo. 
Esto es un game engine, es completamente funcional y plenamente modificable, de hecho tiene solo lo basico para poder funcionar con un juego de supervivencia por tiempo no infinito (para el que le interese mi record es de 240)
este tiene dos particularidades a tomar en cuenta:

(1)CPP.
Esta completamente conectado a traves de un dll a c++, lo que significa que es posible usar la consola de C# ya programada en ves de tener que crear una (aunque el framework permite crearla).

(2)CS.
Esta pensada para sostener los procesos en C#, no hace falta realmente usar c++, pero tambien de usarse c++ en buena teoria puede conectarse a OpenGL y usarse con graficos.

(3)Pido perdon si tiene una mala optimizacion (no deberia), aun no eh estudiado muy bien la arquitectura como tal.
(4) Si, si corre en linux solo es cambiar el archivo lo fuerza a correr solo en windows y retirarlo, es una linea de codigo si no me equiboco en el Core. 

(5) Codigo abierto.

(6) si ves a "Marcus" o "Ferguson" son mis dos clases de handle Error, si les di nombre y si uno es un enojon el otro no. que no te sorprensa los uso para burlarme de la gente no revisa el codigo antes y usualmente solo sirven para dar alertas de cosas no deberias hacer.
