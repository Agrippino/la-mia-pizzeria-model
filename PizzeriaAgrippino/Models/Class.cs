namespace PizzeriaAgrippino.Models
{
    public class Pizze
    {
        public int Id { get; set; }
        public string NamePizza { get; set; }
        public string DescriptionPizza { get; set; }
        public string ImagePizza { get; set; }

        public Pizze()
        {

        }

        public Pizze(int id, string namePizza, string descriptionPizza, string imagePizza)
        {
            this.Id = id;
            this.NamePizza = namePizza;
            this.DescriptionPizza = descriptionPizza;
            this.ImagePizza = imagePizza;
        }
    }
}
