using TeamR.Database.Dataset;
using TeamR.Domain.Entities.Organization;

namespace TeamR.Repository.Entities;

public class ChartRepository(ApplicationContext context) : Base.Repository<Guid, Chart, ChartColumn>(context)
{
}