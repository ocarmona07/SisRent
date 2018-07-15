namespace SisRent.Vista.Models
{
    using System;

    [Serializable]
    public class ComboModel
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public string Tooltip { get; set; }
        public bool Selected { get; set; }
    }
}