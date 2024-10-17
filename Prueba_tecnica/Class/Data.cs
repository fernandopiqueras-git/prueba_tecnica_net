namespace Prueba_tecnica.Clases
{
    public class Data_Test
    {
    public int Id { get; set; }  // Primary Key
    public string? DataType { get; set; }  // Tipo de dato (puede ser precio, cantidad, etc.)
    public string? DataValue { get; set; }  // El valor de ese dato
    public DateTime Timestamp { get; set; }  // La fecha y hora asociada al dato
}
}
