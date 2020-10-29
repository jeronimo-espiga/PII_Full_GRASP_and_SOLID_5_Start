
namespace Full_GRASP_And_SOLID
{
    /*
    Esta interfaz se creo bajo el principio de inversión de dependencias, al principio ConsolePrinter dependía de Recipe, lo cual viola el principio de
    que las clases deben depender de abstracciones en lugar de detalles, al crear IRecipeContent, ConsolePrinter implementa esta interfaz y deja de depender de Recipe
    que es un detalle y empieza a depender de una abstracción(según el patrón).
    */
    public interface IRecipeContent
    {
        string GetTextToPrint();
    }
}