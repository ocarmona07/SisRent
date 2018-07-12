namespace SisRent.Vista.Areas.Mantencion.Models
{
    using System;

    [Serializable]
    public class ComboModel
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; }
    }
}