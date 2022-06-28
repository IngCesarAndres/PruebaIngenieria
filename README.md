# PruebaIngenieria

En program.cs se encuentra las inyecciones y la configuracion a una base de datos local.

/*Verifica y Crea la base de datos*/
https://localhost:XXXX/dbverifica

/*Consultas (se pueden realizar en POSTMAN)*/
//CARGA LISTA DE AUTORES
https://localhost:XXXX/api/autor/getautor

//GUARDA AUTORES
https://localhost:XXXX/api/autor/saveautor
/*Modelo*/
{
    "Nombre": "Jhon",
    "Apellido": "Doe"
}

//ACTUALIZA AUTORES
https://localhost:XXXX/api/autor/updateautor/5e21f81a-7f55-4036-5ada-08da593af2ae
/*Modelo*/
{
        "autorId": "5e21f81a-7f55-4036-5ada-08da593af2ae",
        "nombre": "Jhon",
        "apellido": "Perez"
}

//ELIMINA AUTOR
https://localhost:XXXX/api/autor/deleteautor/5e21f81a-7f55-4036-5ada-08da593af2ae
