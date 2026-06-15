using TeamR.Core.Definition;

namespace TeamR.Domain.Entities.Organization;

public interface IChartRepository : IRepository<Guid, Chart, ChartColumn>
{
}