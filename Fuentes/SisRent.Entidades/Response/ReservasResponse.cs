namespace SisRent.Entidades.Response
{
    using System.Collections.Generic;
    using Common;
    using Entidades;

    public class ReservasResponse : ResponseBase
    {
        public Reservas Reserva { get; set; }
        public List<Reservas> Reservas { get; set; }
    }
}
