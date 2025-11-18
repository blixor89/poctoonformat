// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Attr
    {
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Jefe
    {
        public string EmpleadoId { get; set; }
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int IdPosicion { get; set; }
        public string Posicion { get; set; }
        public string Email { get; set; }
    }

    public class Plantilla
    {
        public int IdOrgPlantilla { get; set; }
        public int IdGrupoPlantilla { get; set; }
        public string? NombrePlantilla { get; set; }
    }

    public class Posiciones
    {
        public string id { get; set; }
        public string Tenant { get; set; }
        public string CentroCostos { get; set; }
        public string Departamento { get; set; }
        public object ExtraData { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdDepartamento { get; set; }
        public int IdNivelJerarquico { get; set; }
        public int IdOrganizacion { get; set; }
        public int IdPosicion { get; set; }
        public int IdPosicionPadre { get; set; }
        public int IdPuesto { get; set; }
        public int IdRegion { get; set; }
        public int IdRelacionLaboral { get; set; }
        public object IdServidor { get; set; }
        public int IdTenant { get; set; }
        public List<Jefe> Jefes { get; set; }
        public string NivelJerarquico { get; set; }
        public object Organizacion { get; set; }
        public string Path { get; set; }
        public List<Plantilla> Plantilla { get; set; }
        public string Posicion { get; set; }
        public string PositionId { get; set; }
        public int Profundidad { get; set; }
        public string Puesto { get; set; }
        public string Region { get; set; }
        public string RelacionLaboral { get; set; }
        public object Servidor { get; set; }
        public List<Attr> Attrs { get; set; }
    }

