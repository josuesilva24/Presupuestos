namespace ModelMap
{
    public class IngresosMap
    {
        public int Id { get; set; }
        public CuentaContableMap CuentaContable { get; set; }
        public CentroCostosMap CentroCostos { get; set; }
        public MonedaMap Moneda { get; set; }
        public AnosMap Ano { get; set; }
        public bool Lineal { get; set; }
        public bool Puntual { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }

    }
}
