using System.ComponentModel.DataAnnotations;

namespace BlazingPizza.Enumerators
{
    public enum StatusOrder
    {
        [Display(Name = "Entregue")]
        Entregue = 1,
        [Display(Name = "Preparando")]
        Preparando = 2,
        [Display(Name = "Saiu para entrega")]
        SaiuParaEntrega = 3
    }
}