namespace SisRent.Vista.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using Negocio.Common;

    public class ViewModelMapperHelper
    {
        public List<ComboModel> ListaComunas()
        {
            var response = new List<ComboModel>();
            var lista = new ListasBo().ObtenerComunas();
            if (lista.EsValido)
            {
                response = lista.Comunas.Select(o => new ComboModel
                {
                    Value = o.IdComuna.ToString(),
                    Text = o.Comuna
                }).ToList();
            }

            return response;
        }
    }
}