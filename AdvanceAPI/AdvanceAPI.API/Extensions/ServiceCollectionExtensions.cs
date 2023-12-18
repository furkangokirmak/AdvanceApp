using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.Concrete;
using AdvanceAPI.BLL.MailService;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.CORE.Helper;
using AdvanceAPI.DAL.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace AdvanceAPI.API.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddCustomServices(this IServiceCollection services)
		{
			services.AddTransient<IUnitOfWork, UnitOfWork>();
			services.AddScoped<IAuthManager, AuthManager>();
			services.AddScoped<ITitleManager, TitleManager>();
			services.AddScoped<IBusinessUnitManager, BusinessUnitManager>();
			services.AddScoped<IEmployeeManager, EmployeeManager>();
			services.AddScoped<IEmployeeProjectManager, EmployeeProjectManager>();
			services.AddScoped<IPageManager, PageManager>();
			services.AddScoped<IPaymentManager, PaymentManager>();
			services.AddScoped<IProjectManager, ProjectManager>();
			services.AddScoped<IReceiptManager, ReceiptManager>();
			services.AddScoped<IRuleManager, RuleManager>();
			services.AddScoped<IStatusManager, StatusManager>();
			services.AddScoped<ITitleAuthorizationManager, TitleAuthorizationManager>();
			services.AddScoped<IAdvanceHistoryManager, AdvanceHistoryManager>();
			services.AddScoped<IAdvanceManager, AdvanceManager>();
			services.AddScoped<IAuthorizationManager, AuthorizationManager>();

			services.AddScoped<MyMapper>();
			services.AddScoped<TokenHelper>();
			services.AddScoped<MailSender>();

			return services;
		}
	}
}
