Datos de Version: 2.8.0.:3.>:3 

**Advertencia**
Solo hay soporte para Windows, para poder activar o programar el soporte para MACos (unix) o una Distro de Linux ocupa re programar los DLL y los detectores de la consola (o usar un sistema de deteccion por cordenadas)

Version de sistema de deteccion de errores: 0.7.0 (Magnus[ :3 ])

Sistema de ayuda para el arreglo de errores: 0.5.0 (Ferguson [ >:3 ]) 

Obscure engine Kernel: 1.3.0.Repair (Diana) 

Engine CPP implementation version: 1.0 
Engine Map Gen 1.0 

**Template ahora esta Activo :D**

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




Referencia para Caracteres en sistema ASCII en uso de Datos Char: https://www.w3.org/Style/XSL/TestSuite/results/4/XEP/charsets.pdf




Requirimientos 

       [Minimo]
       Kernel | Win 16
       Ram    | 2GB DDR3
       Procesador| Intel Core i3 10010F 
       Sistema operativo de 16 bits 
       Sin Tarjeta Grafica
       [Recomendado]
       Kernel | NT.10 o Linux 7.1x 
       Ram    | 8 GB DDR4
       Procesador| Intel Core i5 14400 o Ryzen 5 8600F
       Sistema operativo de 64 bits 
       Sin tarjeta grafica 

Notas Importantes

-> En caso de usarse linux el Kernel de ObscureEngine no esta diseñado con Linux 7.1x en mente, de hecho esta pensado con Win32 en mente por tanto requiere hacer una consola gustom.

->Si se quiere agregar openGL o Vulkan estos son los requerimientos Universales:

       [OpenGL Universal]
       Kernel | NT.10 o Linux 7.1x 
       Ram    | 32 GB DDR4
       Procesador| Intel Core i7 12700F o Ryzen 7 5800x
       Sistema operativo de 64 bits 
       Nvidia RTX 2060 | Radeon RX 5600 XT
