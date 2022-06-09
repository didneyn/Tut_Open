## Cifrado

Es el proceso de codificar la información de su representación original (texto plano)
a texto cifrado, de manera que solamente pueda ser descifrado utilizando una clave

Historia del cifrado

1. Se almacenan contraseñas en texto plano
2. Almacenar contraseñas con una funcion hash
3. Almacenar contraseñas con una funcion hash + salt
4. Almacenar contraseñas con una funcion adaptativa + factor de trabajo


La seguridad se gana haciendo que la validacion de contraseñas sea costosa computacionalmente.


## Algoritmos en Spring Security

* Bcrypt
* PBKDF2
* scrypt
* argon 2

