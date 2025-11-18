namespace mcpms.MCP.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Badage
    {
        public int Noticias { get; set; }
        public int Cumpleanios { get; set; }
        public int Politicas { get; set; }
        public int Eventos { get; set; }
    }

    public class ExtraInfo
    {
        public object? EditorNoticia { get; set; }
        public object? FechaEditor { get; set; }
        public object? Devices { get; set; }
        public object? Nomina { get; set; }
        public List<Posicion>? Posicion { get; set; }
        public object? RevisorNoticia { get; set; }
        public object? FechaRevisor { get; set; }
    }

    public class Posicion
    {
        public int IdPosicion { get; set; }
        public string? Nombre { get; set; }
        public DateTime FechaIngresoOrganizacion { get; set; }
    }

    public class Persona
    {
        public string? id { get; set; }
        public string? Tenant { get; set; }
        public int AccesoHabilitado { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? ApellidoPaterno { get; set; }
        public Badage? Badage { get; set; }
        public object? Email { get; set; }
        public object? Emailpersonal { get; set; }
        public string? EmpleadoId { get; set; }
        public List<ExtraInfo>? ExtraInfo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? GUIDExpediente { get; set; }
        public int IdPersona { get; set; }
        public int IdSexo { get; set; }
        public int IdTenant { get; set; }
        public string? Nombre { get; set; }
        public object? TelefonoCasa { get; set; }
        public object? TelefonoExtension { get; set; }
        public object? TelefonoMovil { get; set; }
        public object? TelefonoOficina { get; set; }
        public int Type { get; set; }
        public string? _etag { get; set; }
        public object? idEdoCivil { get; set; }
        public string? _rid { get; set; }
        public string? _self { get; set; }
        public string? _attachments { get; set; }
        public int _ts { get; set; }
    }
}

