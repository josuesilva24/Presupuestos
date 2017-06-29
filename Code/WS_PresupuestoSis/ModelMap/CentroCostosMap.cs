namespace ModelMap
{
    public class CentroCostosMap
    {
        public int IdBD { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public string Estado { get; set; }
    }


    public class ProyectoCentroCostosMap
    {
        public int IdBD { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public bool?  Estado { get; set; }
        public string CentroCosto { get; set; }
    }
}