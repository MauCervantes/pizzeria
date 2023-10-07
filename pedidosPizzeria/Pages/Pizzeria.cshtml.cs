using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace pedidosPizzeria.Pages
{
    public class PizzeriaModel : PageModel
    {
        [BindProperty]
        public string cliente { get; set; } = "";
        [BindProperty]
        public string dire { get; set; } = "";
        [BindProperty]
        public string tel { get; set; } = "";
        [BindProperty]
        public string pizza { get; set; } = "";
        [BindProperty]
        public int num { get; set; } = 0;
        [BindProperty]
        public string formaPago { get; set; } = "";
        [BindProperty]
        public double total { get; set; } = 0;


        public void OnGet()
        {
        }

        public void OnPost() {
            int price = 0;

            //Switch para separar nombre pizza con precio
            switch (pizza)
            {
                case "Hawayana $100":
                    pizza = "Hawayana";
                    price = 100;
                    break;
                case "Especial $120":
                    pizza = "Especial";
                    price = 120;
                    break;
                case "Vegetariana $150":
                    price = 150;
                    pizza = "Vegetariana";
                    break;
            }

            //Calculamos total general
            total = num * price;

            //Condicional que si el metodo de pago es tarjeta de credito 
            //Sumamos un 10% del total
            if (formaPago.Equals("Tarjeta Credito"))
            {
                total = total + total * .10;
            }
        }
    }
}
