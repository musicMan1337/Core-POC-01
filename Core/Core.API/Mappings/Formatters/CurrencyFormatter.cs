using AutoMapper;

namespace Core.API.Mappings.Formatters;

public class CurrencyFormatter : IValueConverter<decimal, string>
{
    public string Convert(decimal source, ResolutionContext context) => source.ToString("c");
}

