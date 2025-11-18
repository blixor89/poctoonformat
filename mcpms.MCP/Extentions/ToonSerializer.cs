using System.Text;
using System.Collections;

namespace mcpms.MCP.Extentions;
public static class ToonSerializer
{
    public static string Serialize(object obj)
    {
        return SerializeObject(obj, 0);
    }

    public static string SerializeObject(object obj, int indent)
    {
        var indentStr = new string(' ', indent);
        var result = new StringBuilder();

        var properties = obj.GetType().GetProperties();
        foreach (var prop in properties)
        {
            var value = prop.GetValue(obj);

            if (value is IList list)
            {
                result.AppendLine($"{indentStr}{prop.Name.ToLower()}:");
                foreach (var item in list)
                {
                    result.Append($"{indentStr}- ");
                    result.AppendLine(SerializeInline(item));
                }
            }
            else
            {
                result.AppendLine($"{indentStr}{prop.Name.ToLower()}:{value}");
            }
        }

        return result.ToString();
    }

    public static string SerializeInline(object obj)
    {
        var props = obj.GetType().GetProperties();
        return string.Join("|",
            props.Select(p => $"{p.Name.ToLower()}:{p.GetValue(obj)}"));
    }
}
