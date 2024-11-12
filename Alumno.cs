public class Alumno
{
    public int DNI { get; set; }
    public string? Nombre { get; set; }
    public double Nota { get; set; }

    public Alumno(int dni, string? nombre, double nota)
    {
        DNI = dni;
        Nombre = nombre;
        Nota = nota;
    }
}