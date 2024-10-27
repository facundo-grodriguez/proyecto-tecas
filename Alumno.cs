class Alumno
{
    //Generamos los tipos de datos 
    public string DNI {get; set;}
    public string Nombre {get; set;}
    public double Nota1 {get; set;}
    public double Nota2 {get; set;}

    //Constructor para inicializar las propiedades
    public Alumno(string dni, string nombre, double nota1, double nota2)
    {
        DNI = dni;
        Nombre = nombre;
        Nota1 = nota1;
        Nota2 = nota2; 
    }
}       