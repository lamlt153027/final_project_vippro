using System.Threading.Tasks;
using Abp.Application.Services;
using WS.MultiTenancy.HostDashboard.Dto;

namespace WS.MultiTenancy.HostDashboard
{
    public interface IHostDashboardAppService : IApplicationService
    {
        Task<HostDashboardData> GetDashboardStatisticsData(GetDashboardDataInput input);

        Task<GetIncomeStatisticsDataOutput> GetIncomeStatistics(GetIncomeStatisticsDataInput input);

        Task<GetEditionTenantStatisticsOutput> GetEditionTenantStatistics(GetEditionTenantStatisticsInput input);
    }
}