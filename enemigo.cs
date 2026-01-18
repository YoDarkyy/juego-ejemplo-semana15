public class Enemigo
{
    private int vida;
    private string nombre;

    public void Inicializar(string nombre, int vida)
    {
        this.nombre = nombre;
        this.vida = vida;
    }

    public void RecibirDaño(int cantidad)
    {
        vida -= cantidad;
    }
}
