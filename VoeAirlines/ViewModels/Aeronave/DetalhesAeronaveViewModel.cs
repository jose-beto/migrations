namespace VoeAirlines.ViewModel;

public class DetalhesAeronaveViewModel{
    public DetalhesAeronaveViewModel(string fabricante, string modelo, string codigo)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        Codigo = codigo;
    }

    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public string Codigo { get; set; }


}