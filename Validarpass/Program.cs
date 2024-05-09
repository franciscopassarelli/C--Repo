int intentos = 0;

string contrasenia;

bool ingreso = true;

Console.WriteLine("ingrese su contraseña");

while (ingreso)
{
    contrasenia = Console.ReadLine();
    intentos++;
    if (contrasenia.Equals("usSystem-2022"))
    {
        ingreso = false;
        Console.WriteLine("Bienvenidos a coderhouse dev");
        break;
    }

  else if (intentos >= 5) 
    {
        Console.WriteLine("su contraseña es incorrecta y se agotaron los intentos");
        break;

    }

    Console.WriteLine("su contraseña fue invalida, intente nuevamente");
   

}
