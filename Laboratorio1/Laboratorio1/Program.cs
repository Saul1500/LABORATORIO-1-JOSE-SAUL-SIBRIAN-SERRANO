﻿using Laboratorio1.Entidades;
using Laboratorio1.Negocio;



ClsPersona Clspersona = new ClsPersona();
Persona persona = new Persona();

Console.WriteLine("===============================================");
Console.WriteLine("Ingrese su Nombre: ");
persona.nombre = (Console.ReadLine());

Console.WriteLine(" ");

Console.WriteLine("Ingrese su edad: ");
persona.edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");

Console.WriteLine("Ingrese su Sexo: ");
persona.sexo = (Console.ReadLine());

Console.WriteLine(" ");

Console.WriteLine("Ingrese su Peso: ");
persona.peso = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");

Console.WriteLine("Ingrese su Altura: ");
persona.altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine("===============================================");

Clspersona.PesodePersonas(persona);


Console.WriteLine(" ");

Clspersona.MayordeEdad(persona);


Console.ReadKey();

