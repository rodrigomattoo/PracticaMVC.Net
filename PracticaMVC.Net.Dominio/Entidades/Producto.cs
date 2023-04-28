﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMVC.Net.Dominio.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set;}

        public Producto(int id, string descripcion, double precio)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Precio = precio;
        }
    }
}
