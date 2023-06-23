using System.Text.RegularExpressions;

namespace Core.API.Utilities;

public partial class SlugifyParameterTransformer : IOutboundParameterTransformer
{
    public string? TransformOutbound(object? value)
    {
        if (value == null) { return null; }

        string[] parts = value.ToString()!.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < parts.Length; i++)
        {
            // If it's not the domain folder, slug it
            if (i > 0)
            {
                parts[i] = SlugRegex().Replace(parts[i], "$1-$2").ToLower();
            }
            // Otherwise, just make it lowercase
            else
            {
                parts[i] = parts[i].ToLower();
            }
        }

        return string.Join("/", parts);
    }

    // SomeLongAssNamedController => some-long
    [GeneratedRegex("([a-z])([A-Z])")]
    private static partial Regex SlugRegex();
}

