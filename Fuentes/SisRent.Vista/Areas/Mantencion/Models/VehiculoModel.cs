﻿namespace SisRent.Vista.Areas.Mantencion.Models
{
    using System;

    [Serializable]
    public class VehiculoModel
    {
        public int IdVehiculo { get; set; }
        public int? IdMarca { get; set; }
        public string Marca { get; set; }
        public int? IdModelo { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public decimal Valor { get; set; }
        public string Patente { get; set; }
        public string RutaImagen { get; set; }
        public string Detalles { get; set; }
        public bool Estado { get; set; }
    }
}