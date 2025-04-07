namespace Tix.Domain.Exceptions.{{ name }};

public class {{ name }}NotFoundException({{ tid }} id) : NotFoundException<Entities.{{ name }}, {{ tid }}>(id) {}