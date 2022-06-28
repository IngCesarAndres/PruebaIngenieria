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


//GUARDA LIBRO
https://localhost:XXXX/api/libro/savelibro
/*Modelo*/
{
        "autorId": "5e21f81a-7f55-4036-5ada-08da593af2ae",
        "nombre": "Libro de prueba",
        "editorial": "Poli",
        "descripcion": "Libro de prueba",
        "Anio":2022
}


//CARGA LISTA LIBROS
https://localhost:XXXX/api/libro/getlibro/

//ACTUALIZA LIBRO
https://localhost:XXXX/api/libro/updatelibro/31f63631-1134-467b-c3fe-08da593c3afd
{
        "autorId": "5e21f81a-7f55-4036-5ada-08da593af2ae",
        "nombre": "Libro de prueba 2",
        "editorial": "Poli",
        "descripcion": "Libro de prueba 2",
        "Anio":2022
}

//ELIMINA LIBRO
https://localhost:XXXX/api/libro/deletelibro/31f63631-1134-467b-c3fe-08da593c3afd

