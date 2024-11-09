﻿using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Net.Http;

namespace Persistencia
{
    public class ProductosWS
    {
        // Método para agregar un nuevo producto
        public bool AgregarProducto(ProductoWS producto)
        {
            try
            {
                // Serializar el objeto ProductoWS a JSON
                var jsonProducto = JsonConvert.SerializeObject(new
                {
                    id = producto.id,
                    idCategoria = producto.idCategoria,
                    nombre = producto.nombre,
                    fechaAlta = producto.fechaAlta.ToString("o"),
                    fechaBaja = producto.fechaBaja?.ToString("o"),
                    precio = producto.precio,
                    stock = producto.stock,
                    idUsuario = producto.idUsuario,
                    idProveedor = producto.idProveedor
                });

                // Mostrar el JSON generado en la consola para depuración
                System.Diagnostics.Debug.WriteLine("JSON antes de enviar: " + jsonProducto);

                // Llamar al método POST para agregar el producto
                HttpResponseMessage response = WebHelper.Post("Producto/AgregarProducto", jsonProducto);

                // Verificar si la respuesta fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Producto agregado exitosamente.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error al agregar producto: {response.StatusCode} - {response.ReasonPhrase}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar producto: " + ex.Message);
                return false;
            }
        }
    }
}