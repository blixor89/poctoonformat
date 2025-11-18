using System.Text.Json;
using System.Threading.Tasks;
using System.ComponentModel;
using ModelContextProtocol.Server;

namespace mcpms.MCP.Tools
{
    [McpServerToolType]  
    public class ToonTool    
    {

        [McpServerTool(Name = "toonJson"), Description ("A tool that return a toonified JSON representation of an employee.")]
        public async Task<string> GetToonJsonAsync()
        {
            var employees = new[]
            {
                new Employee
                {
                    Id = "1",
                    Nombre = "Juan",
                    ApellidoPaterno = "Pérez",
                    ApellidoMaterno = "García",
                    Email = "juan.perez@example.com",
                    EmailPersonal = "juan.personal@example.com",
                    Movil = "555-1234",
                    Posicion = "Desarrollador",
                    RazonSocial = "ACME S.A.",
                    Tenant = "tenant1",
                    EmpleadoId = "EMP001",
                    IdPersona = 1001,
                    IdPosicion = 2001,
                    IdRazonSocial = 3001,
                    IdTenant = 4001
                },
                new Employee
                {
                    Id = "2",
                    Nombre = "Ana",
                    ApellidoPaterno = "López",
                    ApellidoMaterno = "Martínez",
                    Email = "ana.lopez@example.com",
                    EmailPersonal = "ana.personal@example.com",
                    Movil = "555-5678",
                    Posicion = "QA",
                    RazonSocial = "ACME S.A.",
                    Tenant = "tenant2",
                    EmpleadoId = "EMP002",
                    IdPersona = 1002,
                    IdPosicion = 2002,
                    IdRazonSocial = 3002,
                    IdTenant = 4002
                }
            };

            return await Task.FromResult(JsonSerializer.Serialize(employees));
        }

        [McpServerTool(Name = "toonToon"),Description("A tool that return a toonified representation.")]
        public async Task<string> GetToonToonAsync()
        {
            var employees = new[]
            {
                new Employee
                {
                    Id = "1",
                    Nombre = "Juan",
                    ApellidoPaterno = "Pérez",
                    ApellidoMaterno = "García",
                    Email = "juan.perez@example.com",
                    EmailPersonal = "juan.personal@example.com",
                    Movil = "555-1234",
                    Posicion = "Desarrollador",
                    RazonSocial = "ACME S.A.",
                    Tenant = "tenant1",
                    EmpleadoId = "EMP001",
                    IdPersona = 1001,
                    IdPosicion = 2001,
                    IdRazonSocial = 3001,
                    IdTenant = 4001
                },
                new Employee
                {
                    Id = "2",
                    Nombre = "Ana",
                    ApellidoPaterno = "López",
                    ApellidoMaterno = "Martínez",
                    Email = "ana.lopez@example.com",
                    EmailPersonal = "ana.personal@example.com",
                    Movil = "555-5678",
                    Posicion = "QA",
                    RazonSocial = "ACME S.A.",
                    Tenant = "tenant2",
                    EmpleadoId = "EMP002",
                    IdPersona = 1002,
                    IdPosicion = 2002,
                    IdRazonSocial = 3002,
                    IdTenant = 4002
                }
            };

            
            return await Task.FromResult(mcpms.MCP.Extentions.ToonSerializer.SerializeObject(employees, 0));
        }

        [McpServerTool(Name = "toonTuna"),Description("A tool that return a tuna representation.")]
        public async Task<string> GetToonTunaAsync()
        {
            var keyMap = new Dictionary<string, string>
            {
                {"Id", "i"},
                {"Nombre", "n"},
                {"ApellidoPaterno", "ap"},
                {"ApellidoMaterno", "am"},
                {"Email", "em"},
                {"EmailPersonal", "emp"},
                {"Movil", "mov"},
                {"Posicion", "pos"},
                {"RazonSocial", "rzs"},
                {"Tenant", "ten"},
                {"EmpleadoId", "empi"},
                {"IdPersona", "iper"},
                {"IdPosicion", "ipos"},
                {"IdRazonSocial", "irzs"},
                {"IdTenant", "iten"}
            };

            var employees = new Dictionary<string, object>
            {
                { "employees", new List<object>
                    {
                        new Dictionary<string, object>{
                            {"Id", "1"},
                            {"Nombre", "Juan"},
                            {"ApellidoPaterno", "Pérez"},
                            {"ApellidoMaterno", "García"},
                            {"Email", "email@email.com"},
                            {"EmailPersonal", "persona@email.com"},
                            {"Movil", "555-1234"},
                            {"Posicion", "Desarrollador"},
                            {"RazonSocial", "ACME S.A."},
                            {"Tenant", "tenant1"},
                            {"EmpleadoId", "EMP001"},
                            {"IdPersona", 1001},
                            {"IdPosicion", 2001},
                            {"IdRazonSocial", 3001},
                            {"IdTenant", 4001}
                        },
                        new Dictionary<string, object>{
                            {"Id", "2"},
                            {"Nombre", "Ana"},
                            {"ApellidoPaterno", "López"},
                            {"ApellidoMaterno", "Martínez"},
                            {"Email", "email2@email.com"},
                            {"EmailPersonal", "persona2@email.com"},
                            {"Movil", "555-5678"},
                            {"Posicion", "QA"},
                            {"RazonSocial", "ACME S.A."},
                            {"Tenant", "tenant2"},
                            {"EmpleadoId", "EMP002"},
                            {"IdPersona", 1002},
                            {"IdPosicion", 2002},
                            {"IdRazonSocial", 3002},
                            {"IdTenant", 4002}
                        }
        
                    }   
                }
            };

            var serializer = new mcpms.MCP.Extentions.TunaSerializer(keyMap);
            var tunaString = serializer.Serialize(employees);   
            return await Task.FromResult(tunaString);
        }
    }
}
