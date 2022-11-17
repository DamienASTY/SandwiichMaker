namespace Composeur;

public class Sandwich
{
    private string protein;
    private string condiment;
    private string pain;
    private string crudite;

    public Sandwich(string protein, string condiment, string pain, string crudite)
    {
        this.protein = protein;
        this.condiment = condiment;
        this.pain = pain;
        this.crudite = crudite;
    }

    public override string ToString()
    {
        return $"{this.pain} {this.protein} {this.condiment} {this.crudite}"; // à faire !
    }
}