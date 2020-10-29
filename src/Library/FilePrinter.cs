using System.IO;

namespace Full_GRASP_And_SOLID
{
    /*
    Esta clase implementa la inmterfaz IPrinter y tiene la responsabilidad de imprimir la receta con el metodo PrintRecipe
    */
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeContent recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}