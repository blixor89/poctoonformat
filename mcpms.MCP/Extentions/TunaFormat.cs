using System.Text;

namespace mcpms.MCP.Extentions;
public class TunaSerializer
{
    private Dictionary<string, string> keyMap;

    public TunaSerializer(Dictionary<string, string> keyMap)
    {
        this.keyMap = keyMap;
    }

    public string Serialize(Dictionary<string, object> data)
    {
        var sb = new StringBuilder();
        foreach (var kv in data)
        {
            var key = keyMap.ContainsKey(kv.Key) ? keyMap[kv.Key] : kv.Key;
            if (kv.Value is IList<object> list)
            {
                // Suponemos lista de objetos homogéneos
                var first = (Dictionary<string, object>)list[0];
                var fieldKeys = first.Keys
                    .Select(k => keyMap.ContainsKey(k) ? keyMap[k] : k)
                    .ToList();
                sb.Append($"{key}[{list.Count}]{{");
                sb.Append(string.Join(",", fieldKeys));
                sb.AppendLine("}:");

                foreach (var item in list)
                {
                    var dict = (Dictionary<string, object>)item;
                    var values = fieldKeys.Select(fk => {
                        // encontrar su clave original (inversa)
                        var originalKey = keyMap.FirstOrDefault(x => x.Value == fk).Key ?? fk;
                        return dict[originalKey]?.ToString();
                    });
                    sb.AppendLine("  " + string.Join(",", values));
                }
            }
            else
            {
                sb.AppendLine($"{key}:{kv.Value}");
            }
        }
        return sb.ToString();
    }
}
