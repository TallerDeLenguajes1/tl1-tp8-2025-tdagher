public class Tarea
{
    private int tareaID;
    private string descripcion;
    private int duracion;

    public int TareaID { get => tareaID; set => tareaID = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion
    {
        get => duracion;
        set
        {
            if (value >= 10 && value <= 100)
            {
                duracion = value;
            }
            else
            {
                Console.WriteLine("duracion equivocada");
            }
        }
    } // Validar que esté entre 10 y 100
      // Puedes añadir un constructor y métodos auxiliares si lo consideras necesario
}
