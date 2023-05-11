using FRN.Domain.Notifications;
using System.ComponentModel.DataAnnotations;

namespace FRN.Domain._2._2_Entity
{
    public class Base : Notifies
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}
