namespace Niveles_de_registro
{

    /*
        Consigna: 
            En este ejercicio procesará líneas de registro.

            Cada línea de registro es una cadena con el siguiente formato: "[<LEVEL>]: <MESSAGE>".

            Hay tres niveles de registro diferentes:
                INFO
                WARNING
                ERROR

            Tienes tres tareas, cada una de las cuales tomará una línea de registro y te pedirá que hagas algo con ella.

            Tarea 1: Obtener mensaje de una línea de registro
               Implemente el método ( estático ) LogLine.Message() para devolver un mensaje de línea de registro.
                   LogLine.Message("[ERROR]: Invalid operation")
                   // => "Invalid operation"

            Tarea 2: Obtener el nivel de registro de una línea de registro
               Implemente el método ( estático ) LogLine.LogLevel() para devolver el nivel de registro de una línea de registro, que debe devolverse en minúsculas.
                   LogLine.LogLevel("[ERROR]: Invalid operation")
                   // => "error"

            Tarea 3: Reformatear una línea de registro
               Implemente el método ( estático ) LogLine.Reformat() que reformatea la línea de registro, poniendo el mensaje primero y el nivel de registro después entre paréntesis.
                   LogLine.Reformat("[INFO]: Operation completed")
                   // => "Operation completed (info)"

            TIPS: Funciones Split, IndexOf y Substring de la clase String
   */

    static class LogLine
    {
        public static string Message(string logLine)
        {
            string[] invalid = logLine.Split(":");
            string msg = invalid[1].Trim();
            return msg;
        }

        public static string LogLevel(string logLine)
        {
            string[] invalid = logLine.Split(":");
            string partes = invalid[0];
            string msg = partes.ToLower().Substring(1, invalid[0].Length - 2);
            return msg;
        }

        public static string Reformat(string logLine)
        {
            string[] invalid = logLine.Split(":");
            string msg = invalid[1].Trim();
            string error = invalid[0];
            string final = error.Replace("[", "(").Replace("]", ")").ToLower();
            return msg + " " + final;
        }
    }

}
