namespace Composeur;

public class SandwichMaker
{
    private string[] protein = {"Jambon", "Fromage", "Roast Beef", "Salami"};
    private string[] condiment = {"Mayonnaise", "Ketchup"};
    private string[] pain = {"Pain gris", "Pains blanc"};
    private string[] crudite = {"Salade", "Tomate", "Onion"};

    // comose aléatoirement le sandwich
    // le this n'est pas obligatoire mais par habitude des autres langages,
    // je le met quand même.
    public Sandwich composeSandwich()
    {
        Random r = new Random();
        string[] ingredient = new string[4];

        ingredient[0] = this.protein[r.Next(0, this.protein.Length)];
        ingredient[1] = this.condiment[r.Next(0, this.condiment.Length)];
        ingredient[2] = this.pain[r.Next(0, this.pain.Length)];
        ingredient[3] = this.crudite[r.Next(0, this.crudite.Length)];

        Sandwich sandwich = new Sandwich(ingredient[0], ingredient[1] , ingredient[2], ingredient[3]);
        return sandwich;
    }
}