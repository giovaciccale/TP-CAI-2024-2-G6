using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Persistencia.Utils
{
    public class DBHelper
    {
        private string filePath;

        public DBHelper(String dataBaseName)
        {
            string solutionDirectory = AppDomain.CurrentDomain.BaseDirectory;
            filePath = Path.Combine(solutionDirectory, dataBaseName + ".txt");

            // Crear el archivo si no existe
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }

        // Método para insertar un nuevo registro
        public void Insertar(string key, string value)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{key}|{value}");
            }
        }

        // Método para modificar el valor de un registro existente o agregarlo si no existe
        public void Modificar(string key, string newValue)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            bool modified = false;

            // Eliminar duplicados de la misma clave
            lines = lines.Where(line => !line.StartsWith($"{key}|")).ToList();

            // Buscar la línea con la clave coincidente y modificarla
            for (int i = 0; i < lines.Count; i++)
            {
                string[] keyValue = lines[i].Split('|');
                if (keyValue[0] == key)
                {
                    lines[i] = $"{key}|{newValue}";
                    modified = true;
                    break;
                }
            }

            // Si la clave no existía, agregarla como una nueva entrada
            if (!modified)
            {
                lines.Add($"{key}|{newValue}");
            }

            // Guardar los cambios en el archivo, reemplazando el contenido original
            File.WriteAllLines(filePath, lines);
        }

        // Método para buscar el valor de una clave específica
        public string Buscar(string key)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                string[] keyValue = line.Split('|');
                if (keyValue[0] == key)
                {
                    return keyValue[1];
                }
            }

            return null; // Retorna null si no encuentra la clave
        }
    }
}
