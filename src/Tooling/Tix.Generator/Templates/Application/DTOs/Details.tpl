using Tix.Domain.Entities;
namespace Tix.Application.DTOs.{{ name }};

public class {{ name }}DetailsDto
{
    {{- for prop in props }}
    {{ prop }}
    {{- end }}
}