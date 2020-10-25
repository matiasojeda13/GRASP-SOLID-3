namespace Full_GRASP_And_SOLID.Library
{
    /*
        Se crea la interfaz IPrinter para asi poder aplicar el patron polymorfismo.
        Este patron nos permite definir diferentes tipos de recipe printers,
        cada uno va a definir su forma de imprimir la receta.
        Podremos imprimir una receta utilizando cualquier clase que implemente
        esta interfaz IPrinter sin la necesidad de conocer o preguntar por su propio tipo.
    */
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}