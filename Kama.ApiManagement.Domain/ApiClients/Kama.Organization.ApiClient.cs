using Kama.ApiManagement.Core;
using Kama.ApiManagement.Core.Model;
using Kama.ApiManagement.Domain.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kama.Organization.ApiClient
{
    public interface IOrganizationApiClient : ICoustoumApiClient
    {
    }

    public class OrganizationApiClient : CoustoumApiClient, IOrganizationApiClient
    {
        public OrganizationApiClient(Microsoft.Extensions.Configuration.IConfiguration configuration,
            AppCore.IObjectSerializer objectSerializer, 
            IApiHubServerUrl serverUrl,
            IHttpContextAccessor _httpContextAccessor)
            : base(configuration, objectSerializer, _httpContextAccessor)
        {
            HostUrl = configuration["AppSettings:OrganizationHost"];
        }

        public string HostUrl { get; set; }
        public override string Host
            => HostUrl;

    }

}

namespace Kama.Organization.ApiClient.Interface
{
    public interface IService
    {
    }

    public interface IAddressService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Address>> Add(Kama.Organization.Core.Model.Address model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Address>> GetInquiry(Kama.Organization.Core.Model.AddressVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ValidatePostalCode>>> ValidatePostalCode(Kama.Organization.Core.Model.ValidatePostalCodeVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> ValidatePostalCodeFormat(System.String postalCode, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Address>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IAnnouncementService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Announcement>> Add(Kama.Organization.Core.Model.Announcement model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Announcement>> Edit(Kama.Organization.Core.Model.Announcement model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SetOrders(System.Collections.Generic.List<Kama.Organization.Core.Model.Announcement> models, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Announcement>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Announcement>>> List(Kama.Organization.Core.Model.AnnouncementListVM announcement, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Announcement>>> ListForBulletin(Kama.Organization.Core.Model.AnnouncementListVM announcement, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.AnnouncementPositionType>>> ListPositionTypes(System.Guid announcementId, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IApplicationAssignmentService : IService
    {
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationAssignment>> Add(Kama.Organization.Core.Model.ApplicationAssignment model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationAssignment>>> List(Kama.Organization.Core.Model.ApplicationAssignmentListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationAssignmentPosition>>> ListForCartable(Kama.Organization.Core.Model.ApplicationAssignmentListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationAssignment>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IApplicationService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Application>> Add(Kama.Organization.Core.Model.Application model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Application>> Edit(Kama.Organization.Core.Model.Application model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Application>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Application>>> List(Kama.Organization.Core.Model.ApplicationListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Application>>> ListByAssignment(Kama.Organization.Core.Model.ApplicationListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Application>>> List2(Kama.Organization.Core.Model.ApplicationListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IApplicationSurveyAnswerService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyAnswer>> Add(Kama.Organization.Core.Model.ApplicationSurveyAnswer model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyAnswer>> Edit(Kama.Organization.Core.Model.ApplicationSurveyAnswer model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyAnswer>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurveyAnswer>>> List(Kama.Organization.Core.Model.ApplicationSurveyAnswerListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IApplicationSurveyService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurvey>> Add(Kama.Organization.Core.Model.ApplicationSurvey model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurvey>> Edit(Kama.Organization.Core.Model.ApplicationSurvey model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurvey>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurvey>>> List(Kama.Organization.Core.Model.ApplicationSurveyListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IApplicationSurveyGroupService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyGroup>> Add(Kama.Organization.Core.Model.ApplicationSurveyGroup model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyGroup>> Edit(Kama.Organization.Core.Model.ApplicationSurveyGroup model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyGroup>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurveyGroup>>> List(Kama.Organization.Core.Model.ApplicationSurveyGroupListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IApplicationSurveyParticipantService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyParticipant>> Add(Kama.Organization.Core.Model.ApplicationSurveyParticipant model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyParticipant>> Edit(Kama.Organization.Core.Model.ApplicationSurveyParticipant model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyParticipant>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurveyParticipant>>> List(Kama.Organization.Core.Model.ApplicationSurveyParticipantListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IApplicationSurveyQuestionChoiceService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyQuestionChoice>> Add(Kama.Organization.Core.Model.ApplicationSurveyQuestionChoice model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyQuestionChoice>> Edit(Kama.Organization.Core.Model.ApplicationSurveyQuestionChoice model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyQuestionChoice>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurveyQuestionChoice>>> List(Kama.Organization.Core.Model.ApplicationSurveyQuestionChoiceListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IApplicationSurveyQuestionService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyQuestion>> Add(Kama.Organization.Core.Model.ApplicationSurveyQuestion model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyQuestion>> Edit(Kama.Organization.Core.Model.ApplicationSurveyQuestion model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyQuestion>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurveyQuestion>>> List(Kama.Organization.Core.Model.ApplicationSurveyQuestionListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IAttachmentService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Attachment>> Add(Kama.Organization.Core.Model.Attachment model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Attachment>> Edit(Kama.Organization.Core.Model.Attachment model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.Attachment model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Attachment>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Attachment>>> List(Kama.Organization.Core.Model.AttachmentListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IBankMarkaziService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.BankMarkaziSheba>> CustomerHasShebaId(Kama.Organization.Core.Model.BankMarkaziShebaListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IBaseApiService : IService
    {
    }

    public interface IBehdashtService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Vaccine>> GetInquiry(Kama.Organization.Core.Model.VaccineVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Vaccine>> GetInquiryOfflineApproach(Kama.Organization.Core.Model.VaccineVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.OmidVaccine>> GetOmidVaccineInquiry(Kama.Organization.Core.Model.OmidVaccineVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.OmidVaccine>> GetOmidVaccineInquiryOfflineApproach(Kama.Organization.Core.Model.OmidVaccineVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IBudgetCodeAssignmentService : IService
    {
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.BudgetCodeAssignment>> Add(Kama.Organization.Core.Model.BudgetCodeAssignment model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.BudgetCodeAssignment>> Edit(Kama.Organization.Core.Model.BudgetCodeAssignment model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.BudgetCodeAssignment>>> List(Kama.Organization.Core.Model.BudgetCodeAssignmentListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.BudgetCodeAssignment>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface ICaptchaService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.CaptchaReturnVM>> Generate(Kama.Organization.Core.Model.GenerateCaptchaVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.CaptchaReturnVM>> Validate(Kama.Organization.Core.Model.Captcha model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IClientService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Client>> Add(Kama.Organization.Core.Model.Client model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Client>> Edit(Kama.Organization.Core.Model.Client model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Client>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Client>>> List(Kama.Organization.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Client>>> List2(Kama.Organization.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Client>> ChangeOrder(Kama.Organization.Core.Model.Client model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Client>>> ListForUser(Kama.Organization.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Client>> CheckUserBySso(Kama.Organization.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface ICommandService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Command>> Add(Kama.Organization.Core.Model.Command model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Command>> Edit(Kama.Organization.Core.Model.Command model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SetOrder(System.Guid id, Kama.Organization.Core.Model.Direction direction, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Command>>> List(Kama.Organization.Core.Model.CommandListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Command>>> ListCommands(Kama.Organization.Core.Model.Position model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.CommandByNationalCode>>> ListByNationalCode(Kama.Organization.Core.Model.CommandByNationalCodeListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Command>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IContactService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Contact>> Add(Kama.Organization.Core.Model.Contact contact, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Contact>> SetArchive(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Contact>> SetUnArchive(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Contact>> SetNote(Kama.Organization.Core.Model.Contact contact, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Contact>>> List(Kama.Organization.Core.Model.ContactListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Contact>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IContactDetailService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ContactDetail>> Add(Kama.Organization.Core.Model.ContactDetail model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ContactDetail>> Edit(Kama.Organization.Core.Model.ContactDetail model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IContactInfoService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ContactInfo>> Add(Kama.Organization.Core.Model.ContactInfo model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ContactInfo>> Edit(Kama.Organization.Core.Model.ContactInfo model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ContactInfo>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ContactInfo>>> List(System.Guid parentId, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IDataBaseProblemFieldsService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DataBaseProblemFields>> Add(Kama.Organization.Core.Model.DataBaseProblemFields model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DataBaseProblemFields>> Edit(Kama.Organization.Core.Model.DataBaseProblemFields model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DataBaseProblemFields>>> List(Kama.Organization.Core.Model.DataBaseProblemFieldsListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DataBaseProblemFields>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IDBAReportService : IService
    {
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DataBaseBackupVM>>> GetDataBaseBackup(Kama.Organization.Core.Model.DataBaseBackupVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.JobLogVM>>> GetDataBaseJobLogs(Kama.Organization.Core.Model.JobLogVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.JobVM>>> GetDataBaseJobs(Kama.Organization.Core.Model.JobVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.StepVM>>> GetDataBaseJobSteps(Kama.Organization.Core.Model.StepVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IDepartmentBudgetService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DepartmentBudget>> Add(Kama.Organization.Core.Model.DepartmentBudget model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DepartmentBudget>> Edit(Kama.Organization.Core.Model.DepartmentBudget model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentBudget>>> List(Kama.Organization.Core.Model.DepartmentBudgetListVM department, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentBudgetForSalary>>> ListForSalary(Kama.Organization.Core.Model.DepartmentBudgetForSalaryListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentBudget>>> listOrganDistinct(Kama.Organization.Core.Model.DepartmentBudgetListVM department, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DepartmentBudget>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Byte[]>> ListExcel(Kama.Organization.Core.Model.DepartmentBudgetListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IDepartmentService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Department>> Add(Kama.Organization.Core.Model.Department model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Department>> Edit(Kama.Organization.Core.Model.Department model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Department>>> List(Kama.Organization.Core.Model.DepartmentListVM department, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentSummary>>> ListSummary(Kama.Organization.Core.Model.DepartmentSummaryListVM departmentSummary, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Department>>> ListForManagement(Kama.Organization.Core.Model.DepartmentListVM department, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Department>>> ExceptList(Kama.Organization.Core.Model.DepartmentListVM department, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Department>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Department>>> GetSubsetCount(Kama.Organization.Core.Model.DepartmentListVM department, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Byte[]>> GetOrgansProgressExcelReport(Kama.Organization.Core.Model.DepartmentListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Byte[]>> GetDepartmentExcelReport(Kama.Organization.Core.Model.DepartmentListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SetTreeOrder(System.Collections.Generic.List<Kama.Organization.Core.Model.Department> model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IDepartmentEnableStateService : IService
    {
        Task<Kama.AppCore.Result> UpdateList(Kama.Organization.Core.Model.DepartmentEnableStateUpdateListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentEnableState>>> List(Kama.Organization.Core.Model.DepartmentEnableStateListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IDepartmentPostImportService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DepartmentPostImport>> Add(Kama.Organization.Core.Model.DepartmentPostImport model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DepartmentPostImport>> Edit(Kama.Organization.Core.Model.DepartmentPostImport model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentPostImport>>> List(Kama.Organization.Core.Model.DepartmentPostImportListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DepartmentPostImport>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IDepartmentWebServiceService : IService
    {
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentWebServiceVM>>> List(Kama.Organization.Core.Model.DepartmentWebServiceListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IDigitalSignatureService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DigitalSignatureMiddleResult>> SendRequest(Kama.Organization.Core.Model.DigitalSignatureListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DigitalSignature>> GetFinalResult(System.String code, System.String state, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IDynamicPermissionService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DynamicPermission>> Add(Kama.Organization.Core.Model.DynamicPermission model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DynamicPermission>> Edit(Kama.Organization.Core.Model.DynamicPermission model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.DynamicPermission model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DynamicPermission>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DynamicPermission>>> List(Kama.Organization.Core.Model.DynamicPermissionListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DynamicPermissionDepartment>>> ListDynamicPermissionDepartment(Kama.Organization.Core.Model.DynamicPermissionDepartmentListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position>>> ListPositionsAsync(Kama.Organization.Core.Model.DynamicPermissionListPositionsVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Model>>> ListObjectsByPositionAsync(Kama.Organization.Core.Model.DynamicPermissionObjectsByPositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Model>>> ListObjectsByPositionAndOrganAsync(Kama.Organization.Core.Model.DynamicPermissionObjectsByPositionAndOrganListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IEducationalService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Educational>> GetInquiry(System.Guid individualId, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Educational>>> GetInquiries(Kama.Organization.Core.Model.EducationalListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Educational2>>> ListManagementEducational(Kama.Organization.Core.Model.Educational2ListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Byte[]>> GetExcel(Kama.Organization.Core.Model.Educational2ListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Educational2>>> GetInquiriesNewVersion(Kama.Organization.Core.Model.EducationalInquiry model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Educational2>>> GetInquiriesNewVersionOffline(Kama.Organization.Core.Model.EducationalInquiry model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SendSms(Kama.Organization.Core.Model.EducationalInquiry model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IEmailSecurityStampService : IService
    {
        Task<Kama.AppCore.Result> Send(Kama.Organization.Core.Model.EmailSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Verify(Kama.Organization.Core.Model.EmailSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IEntranceService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TokenInfo>> DecodingToken(IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Logout(Kama.Organization.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> LogoutByRefreshTokenID(Kama.Organization.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ActiveToken>>> ActiveTokenByUser(Kama.Organization.Core.Model.ActiveToken model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.String>> GetToken(Kama.Organization.Core.Model.Token model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.String>> GetRefreshToken(Kama.Organization.Core.Model.GetRefreshTokenVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> CheckAuthorizationForSso(Kama.Organization.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Client>> ShiftLoginUrl(Kama.Organization.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.IssuedToken>>> List(Kama.Organization.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.IssuedToken>> Add(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.IssuedToken>> Edit(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> DeleteByUserID(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.IssuedToken>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TokenInfo>> ValidateToken(Kama.Organization.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IFAQService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.FAQ>> Add(Kama.Organization.Core.Model.FAQ model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.FAQ>> Edit(Kama.Organization.Core.Model.FAQ model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.FAQ>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.FAQ>>> List(Kama.Organization.Core.Model.FAQListVM faqListVm, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IFAQGroupService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.FAQGroup>> Add(Kama.Organization.Core.Model.FAQGroup model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.FAQGroup>> Edit(Kama.Organization.Core.Model.FAQGroup model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.FAQGroup>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.FAQGroup>>> List(Kama.Organization.Core.Model.FAQGroupListVM faqGroupListVM, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.FAQGroup>>> ListWithFAQs(Kama.Organization.Core.Model.FAQGroupListVM faqGroupListVM, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SetOrders(System.Collections.Generic.List<Kama.Organization.Core.Model.FAQGroup> model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IHelpSectionService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.HelpSection>> Add(Kama.Organization.Core.Model.HelpSection model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.HelpSection>> Edit(Kama.Organization.Core.Model.HelpSection model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.HelpSection>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.HelpSection>>> List(Kama.Organization.Core.Model.HelpSectionListVM helpSectionListVm, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SetOrders(System.Collections.Generic.List<Kama.Organization.Core.Model.HelpSection> model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IHelpSectionGroupService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.HelpSectionGroup>> Add(Kama.Organization.Core.Model.HelpSectionGroup model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.HelpSectionGroup>> Edit(Kama.Organization.Core.Model.HelpSectionGroup model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.HelpSectionGroup>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.HelpSectionGroup>>> List(Kama.Organization.Core.Model.HelpSectionGroupListVM helpSectionGroupListVm, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SetOrders(System.Collections.Generic.List<Kama.Organization.Core.Model.HelpSectionGroup> model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IHubService : IService
    {
        Task<Kama.AppCore.Result> AddLog(IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IICTService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ICTExcelLink>> GetExcelLink(Kama.Organization.Core.Model.ICTExcelLinkVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IIndividualService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> Add(Kama.Organization.Core.Model.IndividualAddVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> Edit(Kama.Organization.Core.Model.Individual model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Individual>>> AddList(Kama.Organization.Core.Model.IndividualForUpdateListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Individual>>> List(Kama.Organization.Core.Model.IndividualListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> GetPersonalInfoInquiry(System.Guid individualId, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.NationalCodeExistence>> IsNationalCodeExists(Kama.Organization.Core.Model.Shahkar.ShahkarVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.NationalCodeExistence>> IsCellPhoneExists(Kama.Organization.Core.Model.Shahkar.ShahkarVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SendSecurityCodeBySmsAsync(Kama.Organization.Core.Model.Shahkar.ShahkarVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SendCellPhoneSavedSms(Kama.Organization.Core.Model.Shahkar.ShahkarVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> VerifySecurityCode(Kama.Organization.Core.Model.IndividualPhoneNumberValidationVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> AddWithCellPhone(Kama.Organization.Core.Model.Individual model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> AddCellPhone(Kama.Organization.Core.Model.IndividualCellPhone model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> GetImageSmart(Kama.Organization.Core.Model.Individual model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> GetImageSmart2(Kama.Organization.Core.Model.Individual model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> GetByNationalCode(System.String nationalCode, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IInquiryLogService : IService
    {
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListAddress(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListEducational(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListSacrificial(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListRetirementInformation(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListVaccination(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListInsurance(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListImageSmart(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListIsManager(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListDigitalSignature(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IInsuranceService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Datum>> GetTaminSocialInquiry(System.Guid individualId, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Datum>> GetSalamatInquiry(System.Guid individualId, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Datum>> Add(Kama.Organization.Core.Model.Datum model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Datum>> Edit(Kama.Organization.Core.Model.Datum model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Datum>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Datum>> GetByIndividualId(System.Guid individualId, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IIssuedTokenService : IService
    {
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.IssuedToken>>> List(Kama.Organization.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.IssuedToken>> Add(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.IssuedToken>> Edit(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> DeleteByUserID(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.IssuedToken>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TokenInfo>> ValidateToken(Kama.Organization.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TokenInfo>> DecodingToken(IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> UndoToken(Kama.Organization.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IJudiciaryService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.JudicialVoteConfirmation>> GetJudicialVoteConfirmationInquiry(Kama.Organization.Core.Model.JudicialVoteConfirmationVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.JudicialClearances>> GetJudicialClearanceCertificateInquiry(Kama.Organization.Core.Model.JudicialClearancesVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IMasterApplicationService : IService
    {
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.MasterApplication>> Add(Kama.Organization.Core.Model.MasterApplication model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.MasterApplication>> Edit(Kama.Organization.Core.Model.MasterApplication model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.MasterApplication>>> List(Kama.Organization.Core.Model.MasterApplicationListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.MasterApplication>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IMasterPasswordService : IService
    {
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.MasterPassword>> Add(Kama.Organization.Core.Model.MasterPassword model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.MasterPassword>> Edit(Kama.Organization.Core.Model.MasterPassword model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.MasterPassword>>> List(Kama.Organization.Core.Model.MasterPasswordListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.MasterPassword>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.MasterPassword>> CreatePassword(IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IMessageService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Message>> Add(Kama.Organization.Core.Model.Message model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Message>> Edit(Kama.Organization.Core.Model.Message model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> PermanentDelete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Seen(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Unseen(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Send(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Message>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Message>>> ListInBox(Kama.Organization.Core.Model.InboxMessageListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Message>>> ListOutBox(Kama.Organization.Core.Model.OutboxMessageListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Message>>> ListDraft(Kama.Organization.Core.Model.DraftMessageListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface INewSsoService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Sso>> CheckAuthorization(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Sso>> ShiftLoginUrl(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Sso>>> ListApplication(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Sso>> CheckSmsLogin(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> EditListApp(Kama.Organization.Core.Model.Sso model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface INotificationConditionService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.NotificationCondition>> Add(Kama.Organization.Core.Model.NotificationCondition model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.NotificationCondition>> Edit(Kama.Organization.Core.Model.NotificationCondition model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.NotificationCondition>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.NotificationCondition>>> List(Kama.Organization.Core.Model.NotificationConditionsListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface INotificationService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Notification>> Add(Kama.Organization.Core.Model.Notification model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Notification>> Edit(Kama.Organization.Core.Model.Notification model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Archive(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Send(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Notification>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Notification>>> List(Kama.Organization.Core.Model.NotificationsListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Notification>>> ListByPosition(Kama.Organization.Core.Model.NotificationListByPositionVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.NotificationPosition>>> ListPositions(Kama.Organization.Core.Model.NotificationPositionsListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IOutsideSettingService : IService
    {
        Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.OutsideSetting model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.OutsideSetting>> Add(Kama.Organization.Core.Model.OutsideSetting model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.OutsideSetting>> Edit(Kama.Organization.Core.Model.OutsideSetting model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.OutsideSetting>>> List(Kama.Organization.Core.Model.OutsideSettingListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.OutsideSetting>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IPasswordSettingsService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PasswordSettings>> Edit(Kama.Organization.Core.Model.PasswordSettings model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PasswordSettings>> Get(IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IPlaceService : IService
    {
        Task Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Place>> Add(Kama.Organization.Core.Model.Place model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Place>> Edit(Kama.Organization.Core.Model.Place model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Place>>> List(Kama.Organization.Core.Model.PlaceListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Place>>> ListWithoutSetad(Kama.Organization.Core.Model.PlaceListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Place>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Place>> GetByCode(Kama.Organization.Core.Model.PlaceByCodeListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IPositionService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Position>> Add(Kama.Organization.Core.Model.Position model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Position>> Edit(Kama.Organization.Core.Model.Position model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> ListUpdateEnableState(Kama.Organization.Core.Model.PositionEnableStateVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SetDefault(System.Guid positionId, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> RemoveUser(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>> List(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position>>> ListForSakhtar(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationByUser>>> ListApplicationByUser(Kama.Organization.Core.Model.ApplicationByUserListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentByUser>>> ListDepartmentByUser(Kama.Organization.Core.Model.DepartmentByUserListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>> ListAggregateWithSSO(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>> ListWithRoles(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>> ListCurrentUserPositions(IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>> ListInAllApplications(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Position>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.GetOnlineUsersAndPositionsCountVM>> GetOnlineCount(IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>> GetDefaultPosition(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Byte[]>> ListExcel(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Byte[]>> ListExcelWithRole(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PermissionVM>>> GetPermissions(System.Guid positionId, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Boolean>> CheckPermission(System.Guid commandId, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Boolean>> CheckPermission2(Kama.Organization.Core.Model.CheckPermissionListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IPositionHistoryService : IService
    {
        Task Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionHistory>> Add(Kama.Organization.Core.Model.PositionHistory model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionHistory>> Edit(Kama.Organization.Core.Model.PositionHistory model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PositionHistory>>> List(Kama.Organization.Core.Model.PositionHistoryListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionHistory>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IPositionSubTypeService : IService
    {
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionSubType>> Add(Kama.Organization.Core.Model.PositionSubType model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionSubType>> Edit(Kama.Organization.Core.Model.PositionSubType model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PositionSubType>>> List(Kama.Organization.Core.Model.PositionSubTypeListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionSubType>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IPositionTypeService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionTypeModel>> Add(Kama.Organization.Core.Model.PositionTypeModel model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionTypeModel>> Edit(Kama.Organization.Core.Model.PositionTypeModel model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SetRoles(Kama.Organization.Core.Model.PositionTypeModel model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PositionTypeModel>>> List(Kama.Organization.Core.Model.PositionTypeListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionTypeModel>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionTypeModel>> ChangeUserType(Kama.Organization.Core.Model.PositionTypeModel model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Role>>> GetRoles(Kama.Organization.Core.Model.PositionType positionType, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IPushWebServiceUserService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PushWebServiceUser>> Add(Kama.Organization.Core.Model.PushWebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PushWebServiceUser>> Edit(Kama.Organization.Core.Model.PushWebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.PushWebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PushWebServiceUser>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PushWebServiceUser>>> List(Kama.Organization.Core.Model.PushWebServiceUserListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IPushWebServiceUserPermissionService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PushWebServiceUserPermission>> Add(Kama.Organization.Core.Model.PushWebServiceUserPermission model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PushWebServiceUserPermission>> Edit(Kama.Organization.Core.Model.PushWebServiceUserPermission model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.PushWebServiceUserPermission model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PushWebServiceUserPermission>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PushWebServiceUserPermission>>> List(Kama.Organization.Core.Model.PushWebServiceUserPermissionListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IQrService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Qr>> SetCode(IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Qr>> CheckCode(Kama.Organization.Core.Model.Qr model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Qr>> EditCode(Kama.Organization.Core.Model.Qr model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IQueueService : IService
    {
        Task<Kama.AppCore.Result> PushMessage(Kama.Organization.Core.Model.Sso model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IRefreshTokenService : IService
    {
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.RefreshTokens>>> ListByUserID(Kama.Organization.Core.Model.RefreshTokenListVM refreshTokenListVM, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.RefreshTokens>>> OnlineTokens(Kama.Organization.Core.Model.RefreshTokenListVM refreshTokenListVM, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IRetirementInformationService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.RetirementInformation>> GetInquiry(System.Guid individualId, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IRoleService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Role>> Add(Kama.Organization.Core.Model.Role model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Role>> Edit(Kama.Organization.Core.Model.Role model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.Role model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Role>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Role>> GetAllApplication(Kama.Organization.Core.Model.Role model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Role>>> List(Kama.Organization.Core.Model.RoleListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface ISabteAsnadNationalCodeService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlak>> Save(Kama.Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlak model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlak>> GetByNationalCode(System.String nationalCode, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlak>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface ISabteAsnadVaAmlakService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlak>> GetInquiryByNationalCode(Kama.Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlakVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>> SendItemsInfoForRequestNatinalCodeAsync(Kama.Organization.Core.Model.CLPLegalPersonReview model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>> SendItemsInfoForReviewNatinalCodeAsync(Kama.Organization.Core.Model.CLPLegalPersonReview model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>> SendItemsInfoForChangeNatinalCodeAsync(Kama.Organization.Core.Model.CLPLegalPersonReview model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>> SendItemsInfoForSuspendNatinalCodeAsync(Kama.Organization.Core.Model.CLPLegalPersonReview model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>> SendItemsInfoForRemoveSuspendNatinalCodeAsync(Kama.Organization.Core.Model.CLPLegalPersonReview model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>> SendItemsInfoForActiveNatinalCode(Kama.Organization.Core.Model.CLPLegalPersonReview model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>> SendItemsInfoForDeActiveNatinalCode(Kama.Organization.Core.Model.CLPLegalPersonReview model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.IsManagerResult>> IsManager(Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.IsManagerVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface ISacrificialService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Sacrificial>> GetInquiry(System.Guid individualId, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Sacrificial>>> List(Kama.Organization.Core.Model.SacrificialListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IShahkarService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Shahkar.Shahkar>> GetInquiry(Kama.Organization.Core.Model.Shahkar.ShahkarVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface ISmsService : IService
    {
        Task<Kama.AppCore.Result> Send(Kama.Organization.Core.Model.SendSmsVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SendToGroup(Kama.Organization.Core.Model.SendSmsToGroupVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>> ListSmsUsers(Kama.Organization.Core.Model.SendSmsToGroupVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface ISmsSecurityStampService : IService
    {
        Task<Kama.AppCore.Result> Send(Kama.Organization.Core.Model.SmsSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SendForAllCellphone(Kama.Organization.Core.Model.SmsSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> LoginSend(Kama.Organization.Core.Model.SmsSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ForgotPasswordVM>> FogotPasswordSend(Kama.Organization.Core.Model.SmsSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Verify(Kama.Organization.Core.Model.SmsSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.UserCellphone>> VerifyForAllCellphone(Kama.Organization.Core.Model.SmsSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.SmsSecurityStamp>> SetByUserName(Kama.Organization.Core.Model.SmsSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface ISsoService : IService
    {
        Task<Kama.AppCore.Result> Logout(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> RemoveLogoutCache(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> CheckLogoutCache(Kama.Organization.Core.Model.LogoutCache model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Sso>> CheckAuthorization(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Sso>>> ListApplication(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Sso>> CheckSmsLogin(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> EditListApp(Kama.Organization.Core.Model.Sso model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> GetUser(Kama.Organization.Core.Model.Sso model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IStatisticsService : IService
    {
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Statistics>>> GetStatistics(Kama.Organization.Core.Model.StatisticsListVM listVM, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface ITextTemplateService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TextTemplate>> Edit(Kama.Organization.Core.Model.TextTemplate model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TextTemplate>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TextTemplate>> GetSmsTemplate(System.Int32 code, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TextTemplate>>> List(Kama.Organization.Core.Model.TextTemplateListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface ITicketService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Ticket>> Add(Kama.Organization.Core.Model.Ticket model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Ticket>> Edit(Kama.Organization.Core.Model.Ticket model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Ticket>> SetTicketOwner(Kama.Organization.Core.Model.Ticket model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Ticket>> Rating(Kama.Organization.Core.Model.Ticket model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Ticket>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Ticket>>> List(Kama.Organization.Core.Model.TicketListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Ticket>>> Report(Kama.Organization.Core.Model.TicketReportListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Ticket>>> ReportAll(Kama.Organization.Core.Model.TicketReportAllListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Byte[]>> GetReportExcel(Kama.Organization.Core.Model.TicketReportListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Ticket>>> ListForCallCenter(Kama.Organization.Core.Model.TicketForCallCenterListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface ITicketSequenceService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSequence>> Add(Kama.Organization.Core.Model.TicketSequence model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSequence>> Edit(Kama.Organization.Core.Model.TicketSequence model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSequence>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TicketSequence>>> List(Kama.Organization.Core.Model.TicketSequenceListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSequence>> SetReadDate(Kama.Organization.Core.Model.TicketSequence model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface ITicketSubjectService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSubject>> Add(Kama.Organization.Core.Model.TicketSubject model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSubject>> Edit(Kama.Organization.Core.Model.TicketSubject model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSubject>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TicketSubject>>> List(Kama.Organization.Core.Model.TicketSubjectListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TicketSubject>>> ListForOrganization(Kama.Organization.Core.Model.TicketSubjectListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SetOrders(System.Collections.Generic.List<Kama.Organization.Core.Model.TicketSubject> model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface ITicketSubjectUserService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSubjectUser>> Add(Kama.Organization.Core.Model.TicketSubjectUser model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSubjectUser>> Edit(Kama.Organization.Core.Model.TicketSubjectUser model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSubjectUser>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TicketSubjectUser>>> List(Kama.Organization.Core.Model.TicketSubjectUserListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TicketSubjectUser>>> AllUserBySubjects(Kama.Organization.Core.Model.TicketSubjectUserListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IToken2Service : IService
    {
        Task<Kama.AppCore.Result<System.String>> GetToken(Kama.Organization.Core.Model.Token model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.String>> GetRefreshToken(Kama.Organization.Core.Model.GetRefreshTokenVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IUserCellphoneService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.UserCellphone>> Add(Kama.Organization.Core.Model.UserCellphoneAddVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.UserCellphone>>> List(Kama.Organization.Core.Model.UserCellphoneListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IUserService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> Add(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> Edit(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> EditProfile(Kama.Organization.Core.Model.UserProfileVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> VerifyCellPhone(Kama.Organization.Core.Model.VerifyCellPhoneVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> VerifyEmail(Kama.Organization.Core.Model.VerifyEmailVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SendSecurityCodeBySms(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SendSecurityCodeByEmail(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> ResetPassword(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SetPassword(Kama.Organization.Core.Model.SetPasswordVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SetPasswordWithSecuriyStamp(Kama.Organization.Core.Model.SetPasswordWithSecuriyStampVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.SecuriyStamp>> CheckSecuriyStamp(Kama.Organization.Core.Model.SetPasswordWithSecuriyStampVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> SaveSetting(Kama.Organization.Core.Model.UserSetting model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.User>>> List(Kama.Organization.Core.Model.UserListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> Get(IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> GetCurrentUser(IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> Get(System.String username, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> GetByUsernamePassword(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> GetUserByUserNameMasterPassAsync(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> GetByNationalCode(System.String nationalCode, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> GetByNationalCodeThenByIndividualInformation(System.String nationalCode, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> GetByEmail(System.String email, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.UserSetting>> GetSetting(IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> DeleteTokensBySsoTicket(IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.UserSetting>> GetSettingByUserId(System.Guid userId, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> EmptyInvalidUsersUsingShahkar(IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> EmptyInvalidUsersUsingSabteAhval(IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> ValidateUserWithShahkar(Kama.Organization.Core.Model.Shahkar.ShahkarVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.UserGridSetting>> GetGridSetting(Kama.Organization.Core.Model.UserGridSetting model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.UserGridSetting>> CreateGridSetting(Kama.Organization.Core.Model.UserGridSetting model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.UserGridSetting>> UpdateGridSetting(Kama.Organization.Core.Model.UserGridSetting model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> SendSecurityCodeBySmsByNationalCode(Kama.Organization.Core.Model.UserListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Attachment>> GetProfilePicture(IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> AddUserByIndividual(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IWebServiceService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebService>> Add(Kama.Organization.Core.Model.WebService model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebService>> Edit(Kama.Organization.Core.Model.WebService model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebService>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceForPermissionAcount>> GetForPermissionAcount(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.WebService>>> List(Kama.Organization.Core.Model.WebServiceListVM listVM, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebService>> UpdateLocalInquiryState(Kama.Organization.Core.Model.WebServiceInquiryStateVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebService>> UpdateGsbInquiryState(Kama.Organization.Core.Model.WebServiceInquiryStateVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> UpdateEnbaleState(Kama.Organization.Core.Model.WebService model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> InquiryAllActiveWebServices(IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.WebServiceForPermissionAcount>>> ListForPermissionAcount(Kama.Organization.Core.Model.WebServiceForPermissionAcountListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.InquiryReports>> GetInquiryDetails(Kama.Organization.Core.Model.InquiryReportsListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryReports>>> GetInquiryDetailsForChart(Kama.Organization.Core.Model.InquiryReportsListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IWebServiceUserActionService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUserAction>> Create(Kama.Organization.Core.Model.WebServiceUserAction model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.WebServiceUserAction>>> List(Kama.Organization.Core.Model.WebServiceUserActionListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUserAction>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IWebServiceUserService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUser>> Add(Kama.Organization.Core.Model.WebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUser>> Edit(Kama.Organization.Core.Model.WebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUser>> ResetPassword(Kama.Organization.Core.Model.WebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> CheckUsagePermission(Kama.Organization.Core.Model.CheckWebServiceUserPermission model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.WebServiceUser>>> List(Kama.Organization.Core.Model.WebServiceUserListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUser>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUser>> GetByUserName(System.String userName, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUser>> Get(Kama.Organization.Core.Model.WebServiceUserGetVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Byte[]>> GetExcel(Kama.Organization.Core.Model.WebServiceUserListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> UpdateEnbaleState(Kama.Organization.Core.Model.WebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> UpdateIndividualID(Kama.Organization.Core.Model.WebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

    public interface IWebServiceUserPermissionService : IService
    {
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUserPermission>> Add(Kama.Organization.Core.Model.WebServiceUserPermission model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUserPermission>> Edit(Kama.Organization.Core.Model.WebServiceUserPermission model, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUserPermission>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null);
        Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.WebServiceUserPermission>>> List(Kama.Organization.Core.Model.WebServiceUserPermissionListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
    }

}
namespace Kama.Organization.ApiClient
{
    abstract class Service
    {
    }

    partial class AddressService : Interface.IAddressService
    {
        public AddressService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Address>> Add(Kama.Organization.Core.Model.Address model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/address/Add";
            return _client.SendAsync<Organization.Core.Model.Address>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Address>> GetInquiry(Kama.Organization.Core.Model.AddressVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/address/GetInquiry";
            return _client.SendAsync<Organization.Core.Model.Address>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ValidatePostalCode>>> ValidatePostalCode(Kama.Organization.Core.Model.ValidatePostalCodeVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/address/validate-postal-code";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ValidatePostalCode>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> ValidatePostalCodeFormat(System.String postalCode, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "postalCode", postalCode == null ? null : postalCode.ToString() } };
            const string url = "api/v1/address/validate-postal-code-format/{postalCode}";
            return _client.SendAsync(true, url, routeParamValues, headers, postalCode, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Address>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/address/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.Address>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class AnnouncementService : Interface.IAnnouncementService
    {
        public AnnouncementService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Announcement>> Add(Kama.Organization.Core.Model.Announcement model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Announcement/Add";
            return _client.SendAsync<Organization.Core.Model.Announcement>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Announcement>> Edit(Kama.Organization.Core.Model.Announcement model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Announcement/Edit";
            return _client.SendAsync<Organization.Core.Model.Announcement>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Announcement/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> SetOrders(System.Collections.Generic.List<Kama.Organization.Core.Model.Announcement> models, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "models", models == null ? null : models.ToString() } };
            const string url = "api/v1/Announcement/SetOrders";
            return _client.SendAsync(true, url, routeParamValues, headers, models, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Announcement>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/Announcement/Get/{Id:guid}";
            return _client.SendAsync<Organization.Core.Model.Announcement>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Announcement>>> List(Kama.Organization.Core.Model.AnnouncementListVM announcement, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "announcement", announcement == null ? null : announcement.ToString() } };
            const string url = "api/v1/Announcement/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Announcement>>(true, url, routeParamValues, headers, announcement, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Announcement>>> ListForBulletin(Kama.Organization.Core.Model.AnnouncementListVM announcement, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "announcement", announcement == null ? null : announcement.ToString() } };
            const string url = "api/v1/Announcement/ListForBulletin";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Announcement>>(true, url, routeParamValues, headers, announcement, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.AnnouncementPositionType>>> ListPositionTypes(System.Guid announcementId, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "announcementId", announcementId == null ? null : announcementId.ToString() } };
            const string url = "api/v1/Announcement/ListUserTypes/{announcementId:guid}";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.AnnouncementPositionType>>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class ApplicationAssignmentService : Interface.IApplicationAssignmentService
    {
        public ApplicationAssignmentService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/ApplicationAssignment/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationAssignment>> Add(Kama.Organization.Core.Model.ApplicationAssignment model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/ApplicationAssignment/Add";
            return _client.SendAsync<Organization.Core.Model.ApplicationAssignment>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationAssignment>>> List(Kama.Organization.Core.Model.ApplicationAssignmentListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/ApplicationAssignment/list";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationAssignment>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationAssignmentPosition>>> ListForCartable(Kama.Organization.Core.Model.ApplicationAssignmentListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/ApplicationAssignment/listForCartable";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationAssignmentPosition>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationAssignment>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/ApplicationAssignment/get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.ApplicationAssignment>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class ApplicationService : Interface.IApplicationService
    {
        public ApplicationService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Application>> Add(Kama.Organization.Core.Model.Application model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Application/Add";
            return _client.SendAsync<Organization.Core.Model.Application>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Application>> Edit(Kama.Organization.Core.Model.Application model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Application/Edit";
            return _client.SendAsync<Organization.Core.Model.Application>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Application>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Application/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.Application>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Application/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Application>>> List(Kama.Organization.Core.Model.ApplicationListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Application/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Application>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Application>>> ListByAssignment(Kama.Organization.Core.Model.ApplicationListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Application/ListByAssignment";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Application>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Application>>> List2(Kama.Organization.Core.Model.ApplicationListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Application/List2";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Application>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class ApplicationSurveyAnswerService : Interface.IApplicationSurveyAnswerService
    {
        public ApplicationSurveyAnswerService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyAnswer>> Add(Kama.Organization.Core.Model.ApplicationSurveyAnswer model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey-answer/Add";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurveyAnswer>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyAnswer>> Edit(Kama.Organization.Core.Model.ApplicationSurveyAnswer model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey-answer/Edit";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurveyAnswer>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyAnswer>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/application-survey-answer/Get/{Id:guid}";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurveyAnswer>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurveyAnswer>>> List(Kama.Organization.Core.Model.ApplicationSurveyAnswerListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey-answer/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurveyAnswer>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class ApplicationSurveyService : Interface.IApplicationSurveyService
    {
        public ApplicationSurveyService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurvey>> Add(Kama.Organization.Core.Model.ApplicationSurvey model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey/Add";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurvey>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurvey>> Edit(Kama.Organization.Core.Model.ApplicationSurvey model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey/Edit";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurvey>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurvey>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/application-survey/Get/{Id:guid}";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurvey>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurvey>>> List(Kama.Organization.Core.Model.ApplicationSurveyListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurvey>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/application-survey/Delete/{Id:guid}";
            return _client.SendAsync(false, url, routeParamValues, headers, timeOut);
        }

    }

    partial class ApplicationSurveyGroupService : Interface.IApplicationSurveyGroupService
    {
        public ApplicationSurveyGroupService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyGroup>> Add(Kama.Organization.Core.Model.ApplicationSurveyGroup model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey-group/Add";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurveyGroup>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyGroup>> Edit(Kama.Organization.Core.Model.ApplicationSurveyGroup model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey-group/Edit";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurveyGroup>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyGroup>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/application-survey-group/Get/{Id:guid}";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurveyGroup>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurveyGroup>>> List(Kama.Organization.Core.Model.ApplicationSurveyGroupListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey-group/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurveyGroup>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/application-survey-group/Delete/{Id:guid}";
            return _client.SendAsync(false, url, routeParamValues, headers, timeOut);
        }

    }

    partial class ApplicationSurveyParticipantService : Interface.IApplicationSurveyParticipantService
    {
        public ApplicationSurveyParticipantService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyParticipant>> Add(Kama.Organization.Core.Model.ApplicationSurveyParticipant model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey-participant/Add";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurveyParticipant>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyParticipant>> Edit(Kama.Organization.Core.Model.ApplicationSurveyParticipant model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey-participant/Edit";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurveyParticipant>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyParticipant>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/application-survey-participant/Get/{Id:guid}";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurveyParticipant>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurveyParticipant>>> List(Kama.Organization.Core.Model.ApplicationSurveyParticipantListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey-participant/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurveyParticipant>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class ApplicationSurveyQuestionChoiceService : Interface.IApplicationSurveyQuestionChoiceService
    {
        public ApplicationSurveyQuestionChoiceService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyQuestionChoice>> Add(Kama.Organization.Core.Model.ApplicationSurveyQuestionChoice model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey-question-choice/Add";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurveyQuestionChoice>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyQuestionChoice>> Edit(Kama.Organization.Core.Model.ApplicationSurveyQuestionChoice model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey-question-choice/Edit";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurveyQuestionChoice>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyQuestionChoice>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/application-survey-question-choice/Get/{Id:guid}";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurveyQuestionChoice>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurveyQuestionChoice>>> List(Kama.Organization.Core.Model.ApplicationSurveyQuestionChoiceListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey-question-choice/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurveyQuestionChoice>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/application-survey-question-choice/Delete/{Id:guid}";
            return _client.SendAsync(false, url, routeParamValues, headers, timeOut);
        }

    }

    partial class ApplicationSurveyQuestionService : Interface.IApplicationSurveyQuestionService
    {
        public ApplicationSurveyQuestionService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyQuestion>> Add(Kama.Organization.Core.Model.ApplicationSurveyQuestion model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey-question/Add";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurveyQuestion>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyQuestion>> Edit(Kama.Organization.Core.Model.ApplicationSurveyQuestion model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey-question/Edit";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurveyQuestion>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ApplicationSurveyQuestion>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/application-survey-question/Get/{Id:guid}";
            return _client.SendAsync<Organization.Core.Model.ApplicationSurveyQuestion>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurveyQuestion>>> List(Kama.Organization.Core.Model.ApplicationSurveyQuestionListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/application-survey-question/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationSurveyQuestion>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/application-survey-question/Delete/{Id:guid}";
            return _client.SendAsync(false, url, routeParamValues, headers, timeOut);
        }

    }

    partial class AttachmentService : Interface.IAttachmentService
    {
        public AttachmentService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Attachment>> Add(Kama.Organization.Core.Model.Attachment model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Attachment/Add";
            return _client.SendAsync<Organization.Core.Model.Attachment>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Attachment>> Edit(Kama.Organization.Core.Model.Attachment model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Attachment/Edit";
            return _client.SendAsync<Organization.Core.Model.Attachment>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.Attachment model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Attachment/Delete";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Attachment>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Attachment/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.Attachment>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Attachment>>> List(Kama.Organization.Core.Model.AttachmentListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Attachment/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Attachment>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class BankMarkaziService : Interface.IBankMarkaziService
    {
        public BankMarkaziService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.BankMarkaziSheba>> CustomerHasShebaId(Kama.Organization.Core.Model.BankMarkaziShebaListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/bank-markazi/CustomerHasShebaId";
            return _client.SendAsync<Organization.Core.Model.BankMarkaziSheba>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class BaseApiService : Interface.IBaseApiService
    {
        public BaseApiService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

    }

    partial class BehdashtService : Interface.IBehdashtService
    {
        public BehdashtService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Vaccine>> GetInquiry(Kama.Organization.Core.Model.VaccineVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/behdasht/get-vaccine-inquiry";
            return _client.SendAsync<Organization.Core.Model.Vaccine>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Vaccine>> GetInquiryOfflineApproach(Kama.Organization.Core.Model.VaccineVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/behdasht/get-vaccine-inquiry-offline-approach";
            return _client.SendAsync<Organization.Core.Model.Vaccine>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.OmidVaccine>> GetOmidVaccineInquiry(Kama.Organization.Core.Model.OmidVaccineVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/behdasht/get-omid-vaccine-inquiry";
            return _client.SendAsync<Organization.Core.Model.OmidVaccine>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.OmidVaccine>> GetOmidVaccineInquiryOfflineApproach(Kama.Organization.Core.Model.OmidVaccineVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/behdasht/get-omid-vaccine-inquiry-offline-approach";
            return _client.SendAsync<Organization.Core.Model.OmidVaccine>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class BudgetCodeAssignmentService : Interface.IBudgetCodeAssignmentService
    {
        public BudgetCodeAssignmentService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/BudgetCodeAssignment/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.BudgetCodeAssignment>> Add(Kama.Organization.Core.Model.BudgetCodeAssignment model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/BudgetCodeAssignment/Add";
            return _client.SendAsync<Organization.Core.Model.BudgetCodeAssignment>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.BudgetCodeAssignment>> Edit(Kama.Organization.Core.Model.BudgetCodeAssignment model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/BudgetCodeAssignment/Edit";
            return _client.SendAsync<Organization.Core.Model.BudgetCodeAssignment>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.BudgetCodeAssignment>>> List(Kama.Organization.Core.Model.BudgetCodeAssignmentListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/BudgetCodeAssignment/list";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.BudgetCodeAssignment>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.BudgetCodeAssignment>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/BudgetCodeAssignment/get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.BudgetCodeAssignment>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class CaptchaService : Interface.ICaptchaService
    {
        public CaptchaService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.CaptchaReturnVM>> Generate(Kama.Organization.Core.Model.GenerateCaptchaVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Captcha/Generate";
            return _client.SendAsync<Organization.Core.Model.CaptchaReturnVM>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.CaptchaReturnVM>> Validate(Kama.Organization.Core.Model.Captcha model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Captcha/Validate";
            return _client.SendAsync<Organization.Core.Model.CaptchaReturnVM>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class ClientService : Interface.IClientService
    {
        public ClientService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Client>> Add(Kama.Organization.Core.Model.Client model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Client/Add";
            return _client.SendAsync<Organization.Core.Model.Client>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Client>> Edit(Kama.Organization.Core.Model.Client model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Client/Edit";
            return _client.SendAsync<Organization.Core.Model.Client>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Client>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Client/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.Client>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Client>>> List(Kama.Organization.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Client/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Client>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Client>>> List2(Kama.Organization.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Client/List2";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Client>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Client>> ChangeOrder(Kama.Organization.Core.Model.Client model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Client/ChangeOrder";
            return _client.SendAsync<Organization.Core.Model.Client>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Client/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Client>>> ListForUser(Kama.Organization.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Client/ListForUser";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Client>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Client>> CheckUserBySso(Kama.Organization.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Client/CheckUserBySso";
            return _client.SendAsync<Organization.Core.Model.Client>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class CommandService : Interface.ICommandService
    {
        public CommandService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Command>> Add(Kama.Organization.Core.Model.Command model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Command/Add";
            return _client.SendAsync<Organization.Core.Model.Command>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Command>> Edit(Kama.Organization.Core.Model.Command model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Command/Edit";
            return _client.SendAsync<Organization.Core.Model.Command>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> SetOrder(System.Guid id, Kama.Organization.Core.Model.Direction direction, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() }, { "direction", direction == null ? null : direction.ToString() } };
            const string url = "api/v1/Command/set-order/{id:guid}/{direction}";
            return _client.SendAsync(true, url, routeParamValues, headers, direction, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Command/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Command>>> List(Kama.Organization.Core.Model.CommandListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Command/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Command>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Command>>> ListCommands(Kama.Organization.Core.Model.Position model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Command/ListCommands";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Command>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.CommandByNationalCode>>> ListByNationalCode(Kama.Organization.Core.Model.CommandByNationalCodeListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Command/ListByNationalCode";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.CommandByNationalCode>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Command>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Command/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.Command>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class ContactService : Interface.IContactService
    {
        public ContactService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Contact>> Add(Kama.Organization.Core.Model.Contact contact, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "contact", contact == null ? null : contact.ToString() } };
            const string url = "api/v1/Contact/Add";
            return _client.SendAsync<Organization.Core.Model.Contact>(true, url, routeParamValues, headers, contact, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Contact>> SetArchive(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Contact/SetArchive";
            return _client.SendAsync<Organization.Core.Model.Contact>(true, url, routeParamValues, headers, id, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Contact>> SetUnArchive(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Contact/SetUnArchive";
            return _client.SendAsync<Organization.Core.Model.Contact>(true, url, routeParamValues, headers, id, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Contact>> SetNote(Kama.Organization.Core.Model.Contact contact, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "contact", contact == null ? null : contact.ToString() } };
            const string url = "api/v1/Contact/SetNote";
            return _client.SendAsync<Organization.Core.Model.Contact>(true, url, routeParamValues, headers, contact, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Contact>>> List(Kama.Organization.Core.Model.ContactListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Contact/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Contact>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Contact>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/Contact/Get/{Id:guid}";
            return _client.SendAsync<Organization.Core.Model.Contact>(false, url, routeParamValues, headers, timeOut);
        }

    }

    partial class ContactDetailService : Interface.IContactDetailService
    {
        public ContactDetailService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ContactDetail>> Add(Kama.Organization.Core.Model.ContactDetail model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/ContactDetail/Add";
            return _client.SendAsync<Organization.Core.Model.ContactDetail>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ContactDetail>> Edit(Kama.Organization.Core.Model.ContactDetail model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/ContactDetail/Edit";
            return _client.SendAsync<Organization.Core.Model.ContactDetail>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/ContactDetail/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class ContactInfoService : Interface.IContactInfoService
    {
        public ContactInfoService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ContactInfo>> Add(Kama.Organization.Core.Model.ContactInfo model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/ContactInfo/Add";
            return _client.SendAsync<Organization.Core.Model.ContactInfo>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ContactInfo>> Edit(Kama.Organization.Core.Model.ContactInfo model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/ContactInfo/Edit";
            return _client.SendAsync<Organization.Core.Model.ContactInfo>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/ContactInfo/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ContactInfo>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/ContactInfo/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.ContactInfo>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ContactInfo>>> List(System.Guid parentId, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "parentId", parentId == null ? null : parentId.ToString() } };
            const string url = "api/v1/ContactInfo/List/{parentId:guid}";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ContactInfo>>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class DataBaseProblemFieldsService : Interface.IDataBaseProblemFieldsService
    {
        public DataBaseProblemFieldsService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DataBaseProblemFields>> Add(Kama.Organization.Core.Model.DataBaseProblemFields model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DataBaseProblemFields/Add";
            return _client.SendAsync<Organization.Core.Model.DataBaseProblemFields>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DataBaseProblemFields>> Edit(Kama.Organization.Core.Model.DataBaseProblemFields model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DataBaseProblemFields/Edit";
            return _client.SendAsync<Organization.Core.Model.DataBaseProblemFields>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DataBaseProblemFields>>> List(Kama.Organization.Core.Model.DataBaseProblemFieldsListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DataBaseProblemFields/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DataBaseProblemFields>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DataBaseProblemFields>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/DataBaseProblemFields/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.DataBaseProblemFields>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class DBAReportService : Interface.IDBAReportService
    {
        public DBAReportService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DataBaseBackupVM>>> GetDataBaseBackup(Kama.Organization.Core.Model.DataBaseBackupVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DBAReport/GetDataBaseBackup";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DataBaseBackupVM>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.JobLogVM>>> GetDataBaseJobLogs(Kama.Organization.Core.Model.JobLogVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DBAReport/GetDataBaseJobLogs";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.JobLogVM>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.JobVM>>> GetDataBaseJobs(Kama.Organization.Core.Model.JobVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DBAReport/GetDataBaseJobs";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.JobVM>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.StepVM>>> GetDataBaseJobSteps(Kama.Organization.Core.Model.StepVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DBAReport/GetDataBaseJobSteps";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.StepVM>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class DepartmentBudgetService : Interface.IDepartmentBudgetService
    {
        public DepartmentBudgetService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DepartmentBudget>> Add(Kama.Organization.Core.Model.DepartmentBudget model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DepartmentBudget/Add";
            return _client.SendAsync<Organization.Core.Model.DepartmentBudget>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DepartmentBudget>> Edit(Kama.Organization.Core.Model.DepartmentBudget model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DepartmentBudget/Edit";
            return _client.SendAsync<Organization.Core.Model.DepartmentBudget>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/DepartmentBudget/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentBudget>>> List(Kama.Organization.Core.Model.DepartmentBudgetListVM department, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "department", department == null ? null : department.ToString() } };
            const string url = "api/v1/DepartmentBudget/list";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentBudget>>(true, url, routeParamValues, headers, department, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentBudgetForSalary>>> ListForSalary(Kama.Organization.Core.Model.DepartmentBudgetForSalaryListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DepartmentBudget/ListForSalary";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentBudgetForSalary>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentBudget>>> listOrganDistinct(Kama.Organization.Core.Model.DepartmentBudgetListVM department, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "department", department == null ? null : department.ToString() } };
            const string url = "api/v1/DepartmentBudget/listOrganDistinct";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentBudget>>(true, url, routeParamValues, headers, department, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DepartmentBudget>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/DepartmentBudget/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.DepartmentBudget>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Byte[]>> ListExcel(Kama.Organization.Core.Model.DepartmentBudgetListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DepartmentBudget/ListExcel";
            return _client.SendAsync<System.Byte[]>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class DepartmentService : Interface.IDepartmentService
    {
        public DepartmentService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Department>> Add(Kama.Organization.Core.Model.Department model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Department/Add";
            return _client.SendAsync<Organization.Core.Model.Department>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Department>> Edit(Kama.Organization.Core.Model.Department model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Department/Edit";
            return _client.SendAsync<Organization.Core.Model.Department>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Department/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Department>>> List(Kama.Organization.Core.Model.DepartmentListVM department, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "department", department == null ? null : department.ToString() } };
            const string url = "api/v1/Department/list";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Department>>(true, url, routeParamValues, headers, department, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentSummary>>> ListSummary(Kama.Organization.Core.Model.DepartmentSummaryListVM departmentSummary, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "departmentSummary", departmentSummary == null ? null : departmentSummary.ToString() } };
            const string url = "api/v1/Department/listSummary";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentSummary>>(true, url, routeParamValues, headers, departmentSummary, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Department>>> ListForManagement(Kama.Organization.Core.Model.DepartmentListVM department, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "department", department == null ? null : department.ToString() } };
            const string url = "api/v1/Department/ListForManagement";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Department>>(true, url, routeParamValues, headers, department, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Department>>> ExceptList(Kama.Organization.Core.Model.DepartmentListVM department, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "department", department == null ? null : department.ToString() } };
            const string url = "api/v1/Department/except-list";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Department>>(true, url, routeParamValues, headers, department, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Department>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Department/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.Department>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Department>>> GetSubsetCount(Kama.Organization.Core.Model.DepartmentListVM department, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "department", department == null ? null : department.ToString() } };
            const string url = "api/v1/Department/GetSubsetCount";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Department>>(true, url, routeParamValues, headers, department, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Byte[]>> GetOrgansProgressExcelReport(Kama.Organization.Core.Model.DepartmentListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Department/GetOrgansProgressExcelReport";
            return _client.SendAsync<System.Byte[]>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Byte[]>> GetDepartmentExcelReport(Kama.Organization.Core.Model.DepartmentListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Department/GetDepartmentExcelReport";
            return _client.SendAsync<System.Byte[]>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> SetTreeOrder(System.Collections.Generic.List<Kama.Organization.Core.Model.Department> model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Department/SetTreeOrder";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class DepartmentEnableStateService : Interface.IDepartmentEnableStateService
    {
        public DepartmentEnableStateService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result> UpdateList(Kama.Organization.Core.Model.DepartmentEnableStateUpdateListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DepartmentEnableState/UpdateList";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentEnableState>>> List(Kama.Organization.Core.Model.DepartmentEnableStateListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DepartmentEnableState/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentEnableState>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class DepartmentPostImportService : Interface.IDepartmentPostImportService
    {
        public DepartmentPostImportService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DepartmentPostImport>> Add(Kama.Organization.Core.Model.DepartmentPostImport model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DepartmentPostImport/Add";
            return _client.SendAsync<Organization.Core.Model.DepartmentPostImport>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DepartmentPostImport>> Edit(Kama.Organization.Core.Model.DepartmentPostImport model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DepartmentPostImport/Edit";
            return _client.SendAsync<Organization.Core.Model.DepartmentPostImport>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/DepartmentPostImport/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentPostImport>>> List(Kama.Organization.Core.Model.DepartmentPostImportListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DepartmentPostImport/list";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentPostImport>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DepartmentPostImport>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/DepartmentPostImport/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.DepartmentPostImport>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class DepartmentWebServiceService : Interface.IDepartmentWebServiceService
    {
        public DepartmentWebServiceService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentWebServiceVM>>> List(Kama.Organization.Core.Model.DepartmentWebServiceListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/ws/Department/list";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentWebServiceVM>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class DigitalSignatureService : Interface.IDigitalSignatureService
    {
        public DigitalSignatureService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DigitalSignatureMiddleResult>> SendRequest(Kama.Organization.Core.Model.DigitalSignatureListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DigitalSignature/send-request";
            return _client.SendAsync<Organization.Core.Model.DigitalSignatureMiddleResult>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DigitalSignature>> GetFinalResult(System.String code, System.String state, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "code", code == null ? null : code.ToString() }, { "state", state == null ? null : state.ToString() } };
            const string url = "api/v1/DigitalSignature/get-final-result";
            return _client.SendAsync<Organization.Core.Model.DigitalSignature>(false, url, routeParamValues, headers, state, timeOut);
        }

    }

    partial class DynamicPermissionService : Interface.IDynamicPermissionService
    {
        public DynamicPermissionService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DynamicPermission>> Add(Kama.Organization.Core.Model.DynamicPermission model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DynamicPermission/Add";
            return _client.SendAsync<Organization.Core.Model.DynamicPermission>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DynamicPermission>> Edit(Kama.Organization.Core.Model.DynamicPermission model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DynamicPermission/Edit";
            return _client.SendAsync<Organization.Core.Model.DynamicPermission>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.DynamicPermission model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DynamicPermission/Delete";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.DynamicPermission>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/DynamicPermission/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.DynamicPermission>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DynamicPermission>>> List(Kama.Organization.Core.Model.DynamicPermissionListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DynamicPermission/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DynamicPermission>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DynamicPermissionDepartment>>> ListDynamicPermissionDepartment(Kama.Organization.Core.Model.DynamicPermissionDepartmentListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DynamicPermission/ListDynamicPermissionDepartment";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DynamicPermissionDepartment>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position>>> ListPositionsAsync(Kama.Organization.Core.Model.DynamicPermissionListPositionsVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DynamicPermission/ListPositions";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Model>>> ListObjectsByPositionAsync(Kama.Organization.Core.Model.DynamicPermissionObjectsByPositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DynamicPermission/ListObjectsByPosition";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Model>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Model>>> ListObjectsByPositionAndOrganAsync(Kama.Organization.Core.Model.DynamicPermissionObjectsByPositionAndOrganListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/DynamicPermission/ListObjectsByPositionAndOrgan";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Model>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class EducationalService : Interface.IEducationalService
    {
        public EducationalService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Educational>> GetInquiry(System.Guid individualId, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "individualId", individualId == null ? null : individualId.ToString() } };
            const string url = "api/v1/educational/get-inquiry/{individualId:guid}";
            return _client.SendAsync<Organization.Core.Model.Educational>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Educational>>> GetInquiries(Kama.Organization.Core.Model.EducationalListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/educational/get-inquiries";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Educational>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Educational2>>> ListManagementEducational(Kama.Organization.Core.Model.Educational2ListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/educational/list-management-educational";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Educational2>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Byte[]>> GetExcel(Kama.Organization.Core.Model.Educational2ListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/educational/get-excel";
            return _client.SendAsync<System.Byte[]>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Educational2>>> GetInquiriesNewVersion(Kama.Organization.Core.Model.EducationalInquiry model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/educational/get-inquiries-new-version";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Educational2>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Educational2>>> GetInquiriesNewVersionOffline(Kama.Organization.Core.Model.EducationalInquiry model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/educational/get-inquiries-new-version-offline";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Educational2>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> SendSms(Kama.Organization.Core.Model.EducationalInquiry model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/educational/SendSms";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class EmailSecurityStampService : Interface.IEmailSecurityStampService
    {
        public EmailSecurityStampService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result> Send(Kama.Organization.Core.Model.EmailSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/EmailSecurityStamp/Send";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Verify(Kama.Organization.Core.Model.EmailSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/EmailSecurityStamp/Verify";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class EntranceService : Interface.IEntranceService
    {
        public EntranceService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TokenInfo>> DecodingToken(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/EntranceController/DecodingToken";
            return _client.SendAsync<Organization.Core.Model.TokenInfo>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> Logout(Kama.Organization.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/EntranceController/Logout";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> LogoutByRefreshTokenID(Kama.Organization.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/EntranceController/LogoutByRefreshTokenID";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ActiveToken>>> ActiveTokenByUser(Kama.Organization.Core.Model.ActiveToken model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/EntranceController/ActiveTokenByUser";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ActiveToken>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.String>> GetToken(Kama.Organization.Core.Model.Token model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/EntranceController/GetToken";
            return _client.SendAsync<System.String>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.String>> GetRefreshToken(Kama.Organization.Core.Model.GetRefreshTokenVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/EntranceController/GetRefreshToken";
            return _client.SendAsync<System.String>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> CheckAuthorizationForSso(Kama.Organization.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/EntranceController/CheckAuthorizationForSso";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Client>> ShiftLoginUrl(Kama.Organization.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/EntranceController/ShiftLoginUrl";
            return _client.SendAsync<Organization.Core.Model.Client>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.IssuedToken>>> List(Kama.Organization.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/EntranceController/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.IssuedToken>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.IssuedToken>> Add(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/EntranceController/add";
            return _client.SendAsync<Organization.Core.Model.IssuedToken>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.IssuedToken>> Edit(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/EntranceController/Edit";
            return _client.SendAsync<Organization.Core.Model.IssuedToken>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/EntranceController/Delete";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> DeleteByUserID(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/EntranceController/DeleteByUserID";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.IssuedToken>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/EntranceController/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.IssuedToken>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TokenInfo>> ValidateToken(Kama.Organization.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/EntranceController/ValidateToken";
            return _client.SendAsync<Organization.Core.Model.TokenInfo>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class FAQService : Interface.IFAQService
    {
        public FAQService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.FAQ>> Add(Kama.Organization.Core.Model.FAQ model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/FAQ/Add";
            return _client.SendAsync<Organization.Core.Model.FAQ>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.FAQ>> Edit(Kama.Organization.Core.Model.FAQ model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/FAQ/Edit";
            return _client.SendAsync<Organization.Core.Model.FAQ>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.FAQ>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/FAQ/Get/{Id:guid}";
            return _client.SendAsync<Organization.Core.Model.FAQ>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.FAQ>>> List(Kama.Organization.Core.Model.FAQListVM faqListVm, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "faqListVm", faqListVm == null ? null : faqListVm.ToString() } };
            const string url = "api/v1/FAQ/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.FAQ>>(true, url, routeParamValues, headers, faqListVm, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/FAQ/Delete/{Id:guid}";
            return _client.SendAsync(false, url, routeParamValues, headers, timeOut);
        }

    }

    partial class FAQGroupService : Interface.IFAQGroupService
    {
        public FAQGroupService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.FAQGroup>> Add(Kama.Organization.Core.Model.FAQGroup model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/FAQGroup/Add";
            return _client.SendAsync<Organization.Core.Model.FAQGroup>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.FAQGroup>> Edit(Kama.Organization.Core.Model.FAQGroup model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/FAQGroup/Edit";
            return _client.SendAsync<Organization.Core.Model.FAQGroup>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.FAQGroup>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/FAQGroup/Get/{Id:guid}";
            return _client.SendAsync<Organization.Core.Model.FAQGroup>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.FAQGroup>>> List(Kama.Organization.Core.Model.FAQGroupListVM faqGroupListVM, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "faqGroupListVM", faqGroupListVM == null ? null : faqGroupListVM.ToString() } };
            const string url = "api/v1/FAQGroup/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.FAQGroup>>(true, url, routeParamValues, headers, faqGroupListVM, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.FAQGroup>>> ListWithFAQs(Kama.Organization.Core.Model.FAQGroupListVM faqGroupListVM, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "faqGroupListVM", faqGroupListVM == null ? null : faqGroupListVM.ToString() } };
            const string url = "api/v1/FAQGroup/ListWithFAQs";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.FAQGroup>>(true, url, routeParamValues, headers, faqGroupListVM, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/FAQGroup/Delete/{Id:guid}";
            return _client.SendAsync(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> SetOrders(System.Collections.Generic.List<Kama.Organization.Core.Model.FAQGroup> model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/FAQGroup/SetOrders";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class HelpSectionService : Interface.IHelpSectionService
    {
        public HelpSectionService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.HelpSection>> Add(Kama.Organization.Core.Model.HelpSection model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/HelpSection/Add";
            return _client.SendAsync<Organization.Core.Model.HelpSection>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.HelpSection>> Edit(Kama.Organization.Core.Model.HelpSection model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/HelpSection/Edit";
            return _client.SendAsync<Organization.Core.Model.HelpSection>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/HelpSection/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.HelpSection>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/HelpSection/Get/{Id:guid}";
            return _client.SendAsync<Organization.Core.Model.HelpSection>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.HelpSection>>> List(Kama.Organization.Core.Model.HelpSectionListVM helpSectionListVm, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "helpSectionListVm", helpSectionListVm == null ? null : helpSectionListVm.ToString() } };
            const string url = "api/v1/HelpSection/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.HelpSection>>(true, url, routeParamValues, headers, helpSectionListVm, timeOut);
        }

        public Task<Kama.AppCore.Result> SetOrders(System.Collections.Generic.List<Kama.Organization.Core.Model.HelpSection> model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/HelpSection/SetOrders";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class HelpSectionGroupService : Interface.IHelpSectionGroupService
    {
        public HelpSectionGroupService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.HelpSectionGroup>> Add(Kama.Organization.Core.Model.HelpSectionGroup model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/HelpSectionGroup/Add";
            return _client.SendAsync<Organization.Core.Model.HelpSectionGroup>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.HelpSectionGroup>> Edit(Kama.Organization.Core.Model.HelpSectionGroup model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/HelpSectionGroup/Edit";
            return _client.SendAsync<Organization.Core.Model.HelpSectionGroup>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/HelpSectionGroup/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.HelpSectionGroup>> Get(System.Guid Id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "Id", Id == null ? null : Id.ToString() } };
            const string url = "api/v1/HelpSectionGroup/Get/{Id:guid}";
            return _client.SendAsync<Organization.Core.Model.HelpSectionGroup>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.HelpSectionGroup>>> List(Kama.Organization.Core.Model.HelpSectionGroupListVM helpSectionGroupListVm, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "helpSectionGroupListVm", helpSectionGroupListVm == null ? null : helpSectionGroupListVm.ToString() } };
            const string url = "api/v1/HelpSectionGroup/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.HelpSectionGroup>>(true, url, routeParamValues, headers, helpSectionGroupListVm, timeOut);
        }

        public Task<Kama.AppCore.Result> SetOrders(System.Collections.Generic.List<Kama.Organization.Core.Model.HelpSectionGroup> model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/HelpSectionGroup/SetOrders";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class HubService : Interface.IHubService
    {
        public HubService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result> AddLog(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/Hub/AddLog";
            return _client.SendAsync(false, url, routeParamValues, headers, timeOut);
        }

    }

    partial class ICTService : Interface.IICTService
    {
        public ICTService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ICTExcelLink>> GetExcelLink(Kama.Organization.Core.Model.ICTExcelLinkVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/ict/GetExcelLink";
            return _client.SendAsync<Organization.Core.Model.ICTExcelLink>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class IndividualService : Interface.IIndividualService
    {
        public IndividualService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> Add(Kama.Organization.Core.Model.IndividualAddVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Individual/Add";
            return _client.SendAsync<Organization.Core.Model.Individual>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> Edit(Kama.Organization.Core.Model.Individual model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Individual/Edit";
            return _client.SendAsync<Organization.Core.Model.Individual>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Individual>>> AddList(Kama.Organization.Core.Model.IndividualForUpdateListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Individual/AddList";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Individual>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Individual>>> List(Kama.Organization.Core.Model.IndividualListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Individual/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Individual>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Individual/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.Individual>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> GetPersonalInfoInquiry(System.Guid individualId, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "individualId", individualId == null ? null : individualId.ToString() } };
            const string url = "api/v1/Individual/GetPersonalInfoInquiry/{individualId:guid}";
            return _client.SendAsync<Organization.Core.Model.Individual>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.NationalCodeExistence>> IsNationalCodeExists(Kama.Organization.Core.Model.Shahkar.ShahkarVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Individual/IsNationalCodeExists";
            return _client.SendAsync<Organization.Core.Model.NationalCodeExistence>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.NationalCodeExistence>> IsCellPhoneExists(Kama.Organization.Core.Model.Shahkar.ShahkarVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Individual/IsCellPhoneExists";
            return _client.SendAsync<Organization.Core.Model.NationalCodeExistence>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> SendSecurityCodeBySmsAsync(Kama.Organization.Core.Model.Shahkar.ShahkarVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Individual/SendSecurityCodeBySms";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> SendCellPhoneSavedSms(Kama.Organization.Core.Model.Shahkar.ShahkarVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Individual/SendCellPhoneSavedSms";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> VerifySecurityCode(Kama.Organization.Core.Model.IndividualPhoneNumberValidationVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Individual/VerifySecurityCode";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> AddWithCellPhone(Kama.Organization.Core.Model.Individual model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Individual/AddWithCellPhone";
            return _client.SendAsync<Organization.Core.Model.Individual>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> AddCellPhone(Kama.Organization.Core.Model.IndividualCellPhone model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Individual/AddCellPhone";
            return _client.SendAsync<Organization.Core.Model.Individual>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> GetImageSmart(Kama.Organization.Core.Model.Individual model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Individual/GetImageSmart";
            return _client.SendAsync<Organization.Core.Model.Individual>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> GetImageSmart2(Kama.Organization.Core.Model.Individual model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Individual/GetImageSmart2";
            return _client.SendAsync<Organization.Core.Model.Individual>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Individual>> GetByNationalCode(System.String nationalCode, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "nationalCode", nationalCode == null ? null : nationalCode.ToString() } };
            const string url = "api/v1/Individual/GetByNationalCode";
            return _client.SendAsync<Organization.Core.Model.Individual>(true, url, routeParamValues, headers, nationalCode, timeOut);
        }

    }

    partial class InquiryLogService : Interface.IInquiryLogService
    {
        public InquiryLogService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListAddress(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/InquiryLog/ListAddress";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListEducational(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/InquiryLog/ListEducational";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListSacrificial(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/InquiryLog/ListSacrificial";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListRetirementInformation(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/InquiryLog/ListRetirementInformation";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListVaccination(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/InquiryLog/ListVaccination";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListInsurance(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/InquiryLog/ListInsurance";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListImageSmart(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/InquiryLog/ListImageSmart";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListIsManager(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/InquiryLog/ListIsManager";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>> ListDigitalSignature(Kama.Organization.Core.Model.InquiryLogListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/InquiryLog/ListDigitalSignature";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryLog>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class InsuranceService : Interface.IInsuranceService
    {
        public InsuranceService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Datum>> GetTaminSocialInquiry(System.Guid individualId, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "individualId", individualId == null ? null : individualId.ToString() } };
            const string url = "api/v1/insurance/get-tamin-social-inquiry/{individualId:guid}";
            return _client.SendAsync<Organization.Core.Model.Datum>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Datum>> GetSalamatInquiry(System.Guid individualId, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "individualId", individualId == null ? null : individualId.ToString() } };
            const string url = "api/v1/insurance/get-salamat-inquiry/{individualId:guid}";
            return _client.SendAsync<Organization.Core.Model.Datum>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Datum>> Add(Kama.Organization.Core.Model.Datum model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/insurance/add";
            return _client.SendAsync<Organization.Core.Model.Datum>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Datum>> Edit(Kama.Organization.Core.Model.Datum model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/insurance/Edit";
            return _client.SendAsync<Organization.Core.Model.Datum>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Datum>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/insurance/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.Datum>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Datum>> GetByIndividualId(System.Guid individualId, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "individualId", individualId == null ? null : individualId.ToString() } };
            const string url = "api/v1/insurance/Get-By-Chart/{individualId:guid}";
            return _client.SendAsync<Organization.Core.Model.Datum>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class IssuedTokenService : Interface.IIssuedTokenService
    {
        public IssuedTokenService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.IssuedToken>>> List(Kama.Organization.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/IssuedToken/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.IssuedToken>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.IssuedToken>> Add(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/IssuedToken/add";
            return _client.SendAsync<Organization.Core.Model.IssuedToken>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.IssuedToken>> Edit(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/IssuedToken/Edit";
            return _client.SendAsync<Organization.Core.Model.IssuedToken>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/IssuedToken/Delete";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> DeleteByUserID(Kama.Organization.Core.Model.IssuedToken model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/IssuedToken/DeleteByUserID";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.IssuedToken>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/IssuedToken/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.IssuedToken>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TokenInfo>> ValidateToken(Kama.Organization.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/IssuedToken/ValidateToken";
            return _client.SendAsync<Organization.Core.Model.TokenInfo>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TokenInfo>> DecodingToken(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/IssuedToken/DecodingToken";
            return _client.SendAsync<Organization.Core.Model.TokenInfo>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> UndoToken(Kama.Organization.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/IssuedToken/UndoToken";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class JudiciaryService : Interface.IJudiciaryService
    {
        public JudiciaryService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.JudicialVoteConfirmation>> GetJudicialVoteConfirmationInquiry(Kama.Organization.Core.Model.JudicialVoteConfirmationVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/judiciary/get-judicial-vote-confirmation-inquiry";
            return _client.SendAsync<Organization.Core.Model.JudicialVoteConfirmation>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.JudicialClearances>> GetJudicialClearanceCertificateInquiry(Kama.Organization.Core.Model.JudicialClearancesVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/judiciary/get-judicial-clearance-certificate-inquiry";
            return _client.SendAsync<Organization.Core.Model.JudicialClearances>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class MasterApplicationService : Interface.IMasterApplicationService
    {
        public MasterApplicationService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/MasterApplication/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.MasterApplication>> Add(Kama.Organization.Core.Model.MasterApplication model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/MasterApplication/Add";
            return _client.SendAsync<Organization.Core.Model.MasterApplication>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.MasterApplication>> Edit(Kama.Organization.Core.Model.MasterApplication model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/MasterApplication/Edit";
            return _client.SendAsync<Organization.Core.Model.MasterApplication>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.MasterApplication>>> List(Kama.Organization.Core.Model.MasterApplicationListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/MasterApplication/list";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.MasterApplication>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.MasterApplication>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/MasterApplication/get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.MasterApplication>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class MasterPasswordService : Interface.IMasterPasswordService
    {
        public MasterPasswordService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/MasterPassword/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.MasterPassword>> Add(Kama.Organization.Core.Model.MasterPassword model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/MasterPassword/Add";
            return _client.SendAsync<Organization.Core.Model.MasterPassword>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.MasterPassword>> Edit(Kama.Organization.Core.Model.MasterPassword model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/MasterPassword/Edit";
            return _client.SendAsync<Organization.Core.Model.MasterPassword>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.MasterPassword>>> List(Kama.Organization.Core.Model.MasterPasswordListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/MasterPassword/list";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.MasterPassword>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.MasterPassword>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/MasterPassword/get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.MasterPassword>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.MasterPassword>> CreatePassword(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/MasterPassword/CreatePassword";
            return _client.SendAsync<Organization.Core.Model.MasterPassword>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class MessageService : Interface.IMessageService
    {
        public MessageService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Message>> Add(Kama.Organization.Core.Model.Message model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Message/Add";
            return _client.SendAsync<Organization.Core.Model.Message>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Message>> Edit(Kama.Organization.Core.Model.Message model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Message/Edit";
            return _client.SendAsync<Organization.Core.Model.Message>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Message/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> PermanentDelete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Message/PermanentDelete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> Seen(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Message/Seen/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> Unseen(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Message/Unseen/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> Send(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Message/Send/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Message>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Message/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.Message>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Message>>> ListInBox(Kama.Organization.Core.Model.InboxMessageListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Message/ListInBox";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Message>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Message>>> ListOutBox(Kama.Organization.Core.Model.OutboxMessageListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Message/ListOutBox";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Message>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Message>>> ListDraft(Kama.Organization.Core.Model.DraftMessageListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Message/ListDraft";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Message>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class NewSsoService : Interface.INewSsoService
    {
        public NewSsoService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Sso>> CheckAuthorization(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/NewSso/CheckAuthorization";
            return _client.SendAsync<Organization.Core.Model.Sso>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Sso>> ShiftLoginUrl(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/NewSso/ShiftLoginUrl";
            return _client.SendAsync<Organization.Core.Model.Sso>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Sso>>> ListApplication(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/NewSso/ListApplication";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Sso>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Sso>> CheckSmsLogin(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/NewSso/CheckSmsLogin";
            return _client.SendAsync<Organization.Core.Model.Sso>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> EditListApp(Kama.Organization.Core.Model.Sso model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/NewSso/EditListApp";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class NotificationConditionService : Interface.INotificationConditionService
    {
        public NotificationConditionService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.NotificationCondition>> Add(Kama.Organization.Core.Model.NotificationCondition model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/NotificationCondition/Add";
            return _client.SendAsync<Organization.Core.Model.NotificationCondition>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.NotificationCondition>> Edit(Kama.Organization.Core.Model.NotificationCondition model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/NotificationCondition/Edit";
            return _client.SendAsync<Organization.Core.Model.NotificationCondition>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/NotificationCondition/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.NotificationCondition>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/NotificationCondition/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.NotificationCondition>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.NotificationCondition>>> List(Kama.Organization.Core.Model.NotificationConditionsListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/NotificationCondition/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.NotificationCondition>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class NotificationService : Interface.INotificationService
    {
        public NotificationService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Notification>> Add(Kama.Organization.Core.Model.Notification model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Notification/Add";
            return _client.SendAsync<Organization.Core.Model.Notification>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Notification>> Edit(Kama.Organization.Core.Model.Notification model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Notification/Edit";
            return _client.SendAsync<Organization.Core.Model.Notification>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Notification/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> Archive(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Notification/Archive/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> Send(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Notification/Send/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Notification>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Notification/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.Notification>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Notification>>> List(Kama.Organization.Core.Model.NotificationsListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Notification/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Notification>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Notification>>> ListByPosition(Kama.Organization.Core.Model.NotificationListByPositionVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Notification/ListByPosition";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Notification>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.NotificationPosition>>> ListPositions(Kama.Organization.Core.Model.NotificationPositionsListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Notification/ListPositions";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.NotificationPosition>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class OutsideSettingService : Interface.IOutsideSettingService
    {
        public OutsideSettingService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.OutsideSetting model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/OutsideSetting/Delete";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.OutsideSetting>> Add(Kama.Organization.Core.Model.OutsideSetting model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/OutsideSetting/Add";
            return _client.SendAsync<Organization.Core.Model.OutsideSetting>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.OutsideSetting>> Edit(Kama.Organization.Core.Model.OutsideSetting model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/OutsideSetting/Edit";
            return _client.SendAsync<Organization.Core.Model.OutsideSetting>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.OutsideSetting>>> List(Kama.Organization.Core.Model.OutsideSettingListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/OutsideSetting/list";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.OutsideSetting>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.OutsideSetting>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/OutsideSetting/get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.OutsideSetting>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class PasswordSettingsService : Interface.IPasswordSettingsService
    {
        public PasswordSettingsService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PasswordSettings>> Edit(Kama.Organization.Core.Model.PasswordSettings model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PasswordSettings/Edit";
            return _client.SendAsync<Organization.Core.Model.PasswordSettings>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PasswordSettings>> Get(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/PasswordSettings/get";
            return _client.SendAsync<Organization.Core.Model.PasswordSettings>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class PlaceService : Interface.IPlaceService
    {
        public PlaceService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/place/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Place>> Add(Kama.Organization.Core.Model.Place model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/place/Add";
            return _client.SendAsync<Organization.Core.Model.Place>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Place>> Edit(Kama.Organization.Core.Model.Place model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/place/Edit";
            return _client.SendAsync<Organization.Core.Model.Place>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Place>>> List(Kama.Organization.Core.Model.PlaceListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/place/list";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Place>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Place>>> ListWithoutSetad(Kama.Organization.Core.Model.PlaceListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/place/ListWithoutSetad";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Place>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Place>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/place/get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.Place>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Place>> GetByCode(Kama.Organization.Core.Model.PlaceByCodeListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/place/GetByCode";
            return _client.SendAsync<Organization.Core.Model.Place>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class PositionService : Interface.IPositionService
    {
        public PositionService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Position>> Add(Kama.Organization.Core.Model.Position model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Position/Add";
            return _client.SendAsync<Organization.Core.Model.Position>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Position>> Edit(Kama.Organization.Core.Model.Position model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Position/Edit";
            return _client.SendAsync<Organization.Core.Model.Position>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> ListUpdateEnableState(Kama.Organization.Core.Model.PositionEnableStateVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Position/ListUpdateEnableState";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Position/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> SetDefault(System.Guid positionId, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "positionId", positionId == null ? null : positionId.ToString() } };
            const string url = "api/v1/Position/SetDefault/{positionId:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> RemoveUser(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Position/RemoveUser/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>> List(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Position/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position>>> ListForSakhtar(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Position/ListForSakhtar";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationByUser>>> ListApplicationByUser(Kama.Organization.Core.Model.ApplicationByUserListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Position/ListApplicationByUser";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.ApplicationByUser>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentByUser>>> ListDepartmentByUser(Kama.Organization.Core.Model.DepartmentByUserListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Position/ListDepartmentByUser";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.DepartmentByUser>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>> ListAggregateWithSSO(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Position/ListAggregateWithSSO";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>> ListWithRoles(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Position/ListWithRoles";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>> ListCurrentUserPositions(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/Position/ListCurrentUserPositions";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>> ListInAllApplications(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Position/ListInAllApplications";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Position>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Position/get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.Position>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.GetOnlineUsersAndPositionsCountVM>> GetOnlineCount(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/Position/GetOnlineCount";
            return _client.SendAsync<Organization.Core.Model.GetOnlineUsersAndPositionsCountVM>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>> GetDefaultPosition(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Position/GetDefaultPosition";
            return _client.SendAsync<Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Byte[]>> ListExcel(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Position/ListExcel";
            return _client.SendAsync<System.Byte[]>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Byte[]>> ListExcelWithRole(Kama.Organization.Core.Model.PositionListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Position/ListExcelWithRole";
            return _client.SendAsync<System.Byte[]>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PermissionVM>>> GetPermissions(System.Guid positionId, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "positionId", positionId == null ? null : positionId.ToString() } };
            const string url = "api/v1/Position/GetPermissions/{positionId:guid}";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PermissionVM>>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Boolean>> CheckPermission(System.Guid commandId, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "commandId", commandId == null ? null : commandId.ToString() } };
            const string url = "api/v1/Position/CheckPermission/commandId";
            return _client.SendAsync<System.Boolean>(true, url, routeParamValues, headers, commandId, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Boolean>> CheckPermission2(Kama.Organization.Core.Model.CheckPermissionListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Position/CheckPermission2";
            return _client.SendAsync<System.Boolean>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class PositionHistoryService : Interface.IPositionHistoryService
    {
        public PositionHistoryService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/positionHistory/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionHistory>> Add(Kama.Organization.Core.Model.PositionHistory model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/positionHistory/Add";
            return _client.SendAsync<Organization.Core.Model.PositionHistory>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionHistory>> Edit(Kama.Organization.Core.Model.PositionHistory model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/positionHistory/Edit";
            return _client.SendAsync<Organization.Core.Model.PositionHistory>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PositionHistory>>> List(Kama.Organization.Core.Model.PositionHistoryListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/positionHistory/list";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PositionHistory>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionHistory>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/positionHistory/get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.PositionHistory>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class PositionSubTypeService : Interface.IPositionSubTypeService
    {
        public PositionSubTypeService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/PositionSubType/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionSubType>> Add(Kama.Organization.Core.Model.PositionSubType model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PositionSubType/Add";
            return _client.SendAsync<Organization.Core.Model.PositionSubType>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionSubType>> Edit(Kama.Organization.Core.Model.PositionSubType model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PositionSubType/Edit";
            return _client.SendAsync<Organization.Core.Model.PositionSubType>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PositionSubType>>> List(Kama.Organization.Core.Model.PositionSubTypeListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PositionSubType/list";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PositionSubType>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionSubType>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/PositionSubType/get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.PositionSubType>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class PositionTypeService : Interface.IPositionTypeService
    {
        public PositionTypeService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionTypeModel>> Add(Kama.Organization.Core.Model.PositionTypeModel model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PositionType/Add";
            return _client.SendAsync<Organization.Core.Model.PositionTypeModel>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionTypeModel>> Edit(Kama.Organization.Core.Model.PositionTypeModel model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PositionType/Edit";
            return _client.SendAsync<Organization.Core.Model.PositionTypeModel>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> SetRoles(Kama.Organization.Core.Model.PositionTypeModel model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PositionType/SetRoles";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PositionTypeModel>>> List(Kama.Organization.Core.Model.PositionTypeListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PositionType/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PositionTypeModel>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionTypeModel>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/PositionType/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.PositionTypeModel>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PositionTypeModel>> ChangeUserType(Kama.Organization.Core.Model.PositionTypeModel model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PositionType/ChangeUserType";
            return _client.SendAsync<Organization.Core.Model.PositionTypeModel>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Role>>> GetRoles(Kama.Organization.Core.Model.PositionType positionType, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "positionType", positionType == null ? null : positionType.ToString() } };
            const string url = "api/v1/PositionType/GetRoles/{positionType}";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Role>>(true, url, routeParamValues, headers, positionType, timeOut);
        }

    }

    partial class PushWebServiceUserService : Interface.IPushWebServiceUserService
    {
        public PushWebServiceUserService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PushWebServiceUser>> Add(Kama.Organization.Core.Model.PushWebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PushWebServiceUser/Add";
            return _client.SendAsync<Organization.Core.Model.PushWebServiceUser>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PushWebServiceUser>> Edit(Kama.Organization.Core.Model.PushWebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PushWebServiceUser/Edit";
            return _client.SendAsync<Organization.Core.Model.PushWebServiceUser>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.PushWebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PushWebServiceUser/Delete";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PushWebServiceUser>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/PushWebServiceUser/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.PushWebServiceUser>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PushWebServiceUser>>> List(Kama.Organization.Core.Model.PushWebServiceUserListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PushWebServiceUser/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PushWebServiceUser>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class PushWebServiceUserPermissionService : Interface.IPushWebServiceUserPermissionService
    {
        public PushWebServiceUserPermissionService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PushWebServiceUserPermission>> Add(Kama.Organization.Core.Model.PushWebServiceUserPermission model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PushWebServiceUserPermission/Add";
            return _client.SendAsync<Organization.Core.Model.PushWebServiceUserPermission>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PushWebServiceUserPermission>> Edit(Kama.Organization.Core.Model.PushWebServiceUserPermission model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PushWebServiceUserPermission/Edit";
            return _client.SendAsync<Organization.Core.Model.PushWebServiceUserPermission>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.PushWebServiceUserPermission model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PushWebServiceUserPermission/Delete";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.PushWebServiceUserPermission>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/PushWebServiceUserPermission/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.PushWebServiceUserPermission>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PushWebServiceUserPermission>>> List(Kama.Organization.Core.Model.PushWebServiceUserPermissionListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/PushWebServiceUserPermission/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.PushWebServiceUserPermission>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class QrService : Interface.IQrService
    {
        public QrService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Qr>> SetCode(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/Qr/SetCode";
            return _client.SendAsync<Organization.Core.Model.Qr>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Qr>> CheckCode(Kama.Organization.Core.Model.Qr model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Qr/CheckCode";
            return _client.SendAsync<Organization.Core.Model.Qr>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Qr>> EditCode(Kama.Organization.Core.Model.Qr model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Qr/EditCode";
            return _client.SendAsync<Organization.Core.Model.Qr>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class QueueService : Interface.IQueueService
    {
        public QueueService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result> PushMessage(Kama.Organization.Core.Model.Sso model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Queue/PushMessage";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class RefreshTokenService : Interface.IRefreshTokenService
    {
        public RefreshTokenService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/RefreshToken/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.RefreshTokens>>> ListByUserID(Kama.Organization.Core.Model.RefreshTokenListVM refreshTokenListVM, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "refreshTokenListVM", refreshTokenListVM == null ? null : refreshTokenListVM.ToString() } };
            const string url = "api/v1/RefreshToken/ListByUserID";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.RefreshTokens>>(true, url, routeParamValues, headers, refreshTokenListVM, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.RefreshTokens>>> OnlineTokens(Kama.Organization.Core.Model.RefreshTokenListVM refreshTokenListVM, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "refreshTokenListVM", refreshTokenListVM == null ? null : refreshTokenListVM.ToString() } };
            const string url = "api/v1/RefreshToken/OnlineTokens";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.RefreshTokens>>(true, url, routeParamValues, headers, refreshTokenListVM, timeOut);
        }

    }

    partial class RetirementInformationService : Interface.IRetirementInformationService
    {
        public RetirementInformationService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.RetirementInformation>> GetInquiry(System.Guid individualId, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "individualId", individualId == null ? null : individualId.ToString() } };
            const string url = "api/v1/retirement-information/get-inquiry/{individualId:guid}";
            return _client.SendAsync<Organization.Core.Model.RetirementInformation>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class RoleService : Interface.IRoleService
    {
        public RoleService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Role>> Add(Kama.Organization.Core.Model.Role model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Role/Add";
            return _client.SendAsync<Organization.Core.Model.Role>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Role>> Edit(Kama.Organization.Core.Model.Role model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Role/Edit";
            return _client.SendAsync<Organization.Core.Model.Role>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(Kama.Organization.Core.Model.Role model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Role/Delete";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Role>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Role/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.Role>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Role>> GetAllApplication(Kama.Organization.Core.Model.Role model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Role/GetAllApplication";
            return _client.SendAsync<Organization.Core.Model.Role>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Role>>> List(Kama.Organization.Core.Model.RoleListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Role/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Role>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class SabteAsnadNationalCodeService : Interface.ISabteAsnadNationalCodeService
    {
        public SabteAsnadNationalCodeService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlak>> Save(Kama.Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlak model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sabte-asnad-national-code/Save";
            return _client.SendAsync<Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlak>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlak>> GetByNationalCode(System.String nationalCode, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "nationalCode", nationalCode == null ? null : nationalCode.ToString() } };
            const string url = "api/v1/sabte-asnad-national-code/GetByNationalCode/{nationalCode}";
            return _client.SendAsync<Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlak>(false, url, routeParamValues, headers, nationalCode, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlak>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/sabte-asnad-national-code/get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlak>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class SabteAsnadVaAmlakService : Interface.ISabteAsnadVaAmlakService
    {
        public SabteAsnadVaAmlakService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlak>> GetInquiryByNationalCode(Kama.Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlakVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sabte-asnad-va-amlak/get-inquiry-by-nationalcode";
            return _client.SendAsync<Organization.Core.Model.SpecialInquiryForSabteAsnadVaAmlak>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>> SendItemsInfoForRequestNatinalCodeAsync(Kama.Organization.Core.Model.CLPLegalPersonReview model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sabte-asnad-va-amlak/SendItemsInfoForRequestNatinalCode";
            return _client.SendAsync<Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>> SendItemsInfoForReviewNatinalCodeAsync(Kama.Organization.Core.Model.CLPLegalPersonReview model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sabte-asnad-va-amlak/SendItemsInfoForReviewNatinalCodeAsync";
            return _client.SendAsync<Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>> SendItemsInfoForChangeNatinalCodeAsync(Kama.Organization.Core.Model.CLPLegalPersonReview model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sabte-asnad-va-amlak/SendItemsInfoForChangeNatinalCodeAsync";
            return _client.SendAsync<Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>> SendItemsInfoForSuspendNatinalCodeAsync(Kama.Organization.Core.Model.CLPLegalPersonReview model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sabte-asnad-va-amlak/SendItemsInfoForSuspendNatinalCode";
            return _client.SendAsync<Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>> SendItemsInfoForRemoveSuspendNatinalCodeAsync(Kama.Organization.Core.Model.CLPLegalPersonReview model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sabte-asnad-va-amlak/SendItemsInfoForRemoveSuspendNatinalCode";
            return _client.SendAsync<Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>> SendItemsInfoForActiveNatinalCode(Kama.Organization.Core.Model.CLPLegalPersonReview model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sabte-asnad-va-amlak/SendItemsInfoForActiveNatinalCode";
            return _client.SendAsync<Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>> SendItemsInfoForDeActiveNatinalCode(Kama.Organization.Core.Model.CLPLegalPersonReview model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sabte-asnad-va-amlak/SendItemsInfoForDeActiveNatinalCode";
            return _client.SendAsync<Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.IsManagerResult>> IsManager(Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.IsManagerVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sabte-asnad-va-amlak/is-manager";
            return _client.SendAsync<Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.IsManagerResult>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class SacrificialService : Interface.ISacrificialService
    {
        public SacrificialService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Sacrificial>> GetInquiry(System.Guid individualId, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "individualId", individualId == null ? null : individualId.ToString() } };
            const string url = "api/v1/sacrificial/get-inquiry/{individualId:guid}";
            return _client.SendAsync<Organization.Core.Model.Sacrificial>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Sacrificial>>> List(Kama.Organization.Core.Model.SacrificialListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sacrificial/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Sacrificial>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class ShahkarService : Interface.IShahkarService
    {
        public ShahkarService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Shahkar.Shahkar>> GetInquiry(Kama.Organization.Core.Model.Shahkar.ShahkarVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/shahkar/get-inquiry";
            return _client.SendAsync<Organization.Core.Model.Shahkar.Shahkar>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class SmsService : Interface.ISmsService
    {
        public SmsService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result> Send(Kama.Organization.Core.Model.SendSmsVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sms/Send";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> SendToGroup(Kama.Organization.Core.Model.SendSmsToGroupVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sms/SendToGroup";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>> ListSmsUsers(Kama.Organization.Core.Model.SendSmsToGroupVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sms/ListSmsUsers";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Position<Kama.Organization.Core.Model.PositionType>>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class SmsSecurityStampService : Interface.ISmsSecurityStampService
    {
        public SmsSecurityStampService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result> Send(Kama.Organization.Core.Model.SmsSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/SmsSecurityStamp/Send";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> SendForAllCellphone(Kama.Organization.Core.Model.SmsSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/SmsSecurityStamp/SendForAllCellphone";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> LoginSend(Kama.Organization.Core.Model.SmsSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/SmsSecurityStamp/LoginSend";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.ForgotPasswordVM>> FogotPasswordSend(Kama.Organization.Core.Model.SmsSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/SmsSecurityStamp/FogotPasswordSend";
            return _client.SendAsync<Organization.Core.Model.ForgotPasswordVM>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Verify(Kama.Organization.Core.Model.SmsSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/SmsSecurityStamp/Verify";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.UserCellphone>> VerifyForAllCellphone(Kama.Organization.Core.Model.SmsSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/SmsSecurityStamp/VerifyForAllCellphone";
            return _client.SendAsync<Organization.Core.Model.UserCellphone>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.SmsSecurityStamp>> SetByUserName(Kama.Organization.Core.Model.SmsSecurityStamp model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/SmsSecurityStamp/SetByUserName";
            return _client.SendAsync<Organization.Core.Model.SmsSecurityStamp>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class SsoService : Interface.ISsoService
    {
        public SsoService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result> Logout(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sso/Logout";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> RemoveLogoutCache(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sso/RemoveLogoutCache";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> CheckLogoutCache(Kama.Organization.Core.Model.LogoutCache model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sso/CheckLogoutCache";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Sso>> CheckAuthorization(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sso/CheckAuthorization";
            return _client.SendAsync<Organization.Core.Model.Sso>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Sso>>> ListApplication(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sso/ListApplication";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Sso>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Sso>> CheckSmsLogin(Kama.Organization.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sso/CheckSmsLogin";
            return _client.SendAsync<Organization.Core.Model.Sso>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> EditListApp(Kama.Organization.Core.Model.Sso model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sso/EditListApp";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> GetUser(Kama.Organization.Core.Model.Sso model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/sso/GetUser";
            return _client.SendAsync<Organization.Core.Model.User>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class StatisticsService : Interface.IStatisticsService
    {
        public StatisticsService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Statistics>>> GetStatistics(Kama.Organization.Core.Model.StatisticsListVM listVM, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "listVM", listVM == null ? null : listVM.ToString() } };
            const string url = "api/v1/Statistics/GetStatistics";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Statistics>>(true, url, routeParamValues, headers, listVM, timeOut);
        }

    }

    partial class TextTemplateService : Interface.ITextTemplateService
    {
        public TextTemplateService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TextTemplate>> Edit(Kama.Organization.Core.Model.TextTemplate model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/TextTemplate/Edit";
            return _client.SendAsync<Organization.Core.Model.TextTemplate>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TextTemplate>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/TextTemplate/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.TextTemplate>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TextTemplate>> GetSmsTemplate(System.Int32 code, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "code", code == null ? null : code.ToString() } };
            const string url = "api/v1/TextTemplate/GetSmsTemplate";
            return _client.SendAsync<Organization.Core.Model.TextTemplate>(true, url, routeParamValues, headers, code, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TextTemplate>>> List(Kama.Organization.Core.Model.TextTemplateListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/TextTemplate/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TextTemplate>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/TextTemplate/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class TicketService : Interface.ITicketService
    {
        public TicketService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Ticket>> Add(Kama.Organization.Core.Model.Ticket model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Ticket/Add";
            return _client.SendAsync<Organization.Core.Model.Ticket>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Ticket>> Edit(Kama.Organization.Core.Model.Ticket model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Ticket/Edit";
            return _client.SendAsync<Organization.Core.Model.Ticket>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Ticket>> SetTicketOwner(Kama.Organization.Core.Model.Ticket model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Ticket/SetTicketOwner";
            return _client.SendAsync<Organization.Core.Model.Ticket>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Ticket>> Rating(Kama.Organization.Core.Model.Ticket model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Ticket/Rating";
            return _client.SendAsync<Organization.Core.Model.Ticket>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Ticket/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Ticket>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/Ticket/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.Ticket>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Ticket>>> List(Kama.Organization.Core.Model.TicketListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Ticket/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Ticket>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Ticket>>> Report(Kama.Organization.Core.Model.TicketReportListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Ticket/Report";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Ticket>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Ticket>>> ReportAll(Kama.Organization.Core.Model.TicketReportAllListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Ticket/ReportAll";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Ticket>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Byte[]>> GetReportExcel(Kama.Organization.Core.Model.TicketReportListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Ticket/GetReportExcel";
            return _client.SendAsync<System.Byte[]>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Ticket>>> ListForCallCenter(Kama.Organization.Core.Model.TicketForCallCenterListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Ticket/ListForCallCenter";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.Ticket>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class TicketSequenceService : Interface.ITicketSequenceService
    {
        public TicketSequenceService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSequence>> Add(Kama.Organization.Core.Model.TicketSequence model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/TicketSequence/Add";
            return _client.SendAsync<Organization.Core.Model.TicketSequence>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSequence>> Edit(Kama.Organization.Core.Model.TicketSequence model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/TicketSequence/Edit";
            return _client.SendAsync<Organization.Core.Model.TicketSequence>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/TicketSequence/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSequence>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/TicketSequence/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.TicketSequence>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TicketSequence>>> List(Kama.Organization.Core.Model.TicketSequenceListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/TicketSequence/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TicketSequence>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSequence>> SetReadDate(Kama.Organization.Core.Model.TicketSequence model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/TicketSequence/SetReadDate";
            return _client.SendAsync<Organization.Core.Model.TicketSequence>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class TicketSubjectService : Interface.ITicketSubjectService
    {
        public TicketSubjectService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSubject>> Add(Kama.Organization.Core.Model.TicketSubject model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/TicketSubject/Add";
            return _client.SendAsync<Organization.Core.Model.TicketSubject>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSubject>> Edit(Kama.Organization.Core.Model.TicketSubject model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/TicketSubject/Edit";
            return _client.SendAsync<Organization.Core.Model.TicketSubject>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/TicketSubject/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSubject>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/TicketSubject/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.TicketSubject>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TicketSubject>>> List(Kama.Organization.Core.Model.TicketSubjectListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/TicketSubject/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TicketSubject>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TicketSubject>>> ListForOrganization(Kama.Organization.Core.Model.TicketSubjectListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/TicketSubject/ListForOrganization";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TicketSubject>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> SetOrders(System.Collections.Generic.List<Kama.Organization.Core.Model.TicketSubject> model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/TicketSubject/SetOrders";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class TicketSubjectUserService : Interface.ITicketSubjectUserService
    {
        public TicketSubjectUserService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSubjectUser>> Add(Kama.Organization.Core.Model.TicketSubjectUser model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/TicketSubjectUser/Add";
            return _client.SendAsync<Organization.Core.Model.TicketSubjectUser>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSubjectUser>> Edit(Kama.Organization.Core.Model.TicketSubjectUser model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/TicketSubjectUser/Edit";
            return _client.SendAsync<Organization.Core.Model.TicketSubjectUser>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/TicketSubjectUser/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.TicketSubjectUser>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/TicketSubjectUser/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.TicketSubjectUser>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TicketSubjectUser>>> List(Kama.Organization.Core.Model.TicketSubjectUserListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/TicketSubjectUser/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TicketSubjectUser>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TicketSubjectUser>>> AllUserBySubjects(Kama.Organization.Core.Model.TicketSubjectUserListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/TicketSubjectUser/AllUserBySubjects";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.TicketSubjectUser>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class Token2Service : Interface.IToken2Service
    {
        public Token2Service(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<System.String>> GetToken(Kama.Organization.Core.Model.Token model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Token/Get";
            return _client.SendAsync<System.String>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.String>> GetRefreshToken(Kama.Organization.Core.Model.GetRefreshTokenVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/Token/Refresh";
            return _client.SendAsync<System.String>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class UserCellphoneService : Interface.IUserCellphoneService
    {
        public UserCellphoneService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.UserCellphone>> Add(Kama.Organization.Core.Model.UserCellphoneAddVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/UserCellphone/Add";
            return _client.SendAsync<Organization.Core.Model.UserCellphone>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/UserCellphone/delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.UserCellphone>>> List(Kama.Organization.Core.Model.UserCellphoneListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/UserCellphone/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.UserCellphone>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class UserService : Interface.IUserService
    {
        public UserService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> Add(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/Add";
            return _client.SendAsync<Organization.Core.Model.User>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> Edit(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/edit";
            return _client.SendAsync<Organization.Core.Model.User>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/User/delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> EditProfile(Kama.Organization.Core.Model.UserProfileVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/EditProfile";
            return _client.SendAsync<Organization.Core.Model.User>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> VerifyCellPhone(Kama.Organization.Core.Model.VerifyCellPhoneVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/VerifyCellPhone";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> VerifyEmail(Kama.Organization.Core.Model.VerifyEmailVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/VerifyEmail";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> SendSecurityCodeBySms(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/SendSecurityCodeBySms";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> SendSecurityCodeByEmail(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/SendSecurityCodeByEmail";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> ResetPassword(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/ResetPassword";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> SetPassword(Kama.Organization.Core.Model.SetPasswordVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/SetPassword";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> SetPasswordWithSecuriyStamp(Kama.Organization.Core.Model.SetPasswordWithSecuriyStampVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/SetPasswordWithSecuriyStamp";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.SecuriyStamp>> CheckSecuriyStamp(Kama.Organization.Core.Model.SetPasswordWithSecuriyStampVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/CheckSecuriyStamp";
            return _client.SendAsync<Organization.Core.Model.SecuriyStamp>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> SaveSetting(Kama.Organization.Core.Model.UserSetting model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/SaveSetting";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.User>>> List(Kama.Organization.Core.Model.UserListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.User>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/User/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.User>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> Get(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/User/Get";
            return _client.SendAsync<Organization.Core.Model.User>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> GetCurrentUser(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/User/GetCurrentUser";
            return _client.SendAsync<Organization.Core.Model.User>(false, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> Get(System.String username, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "username", username == null ? null : username.ToString() } };
            const string url = "api/v1/User/Get/{username}";
            return _client.SendAsync<Organization.Core.Model.User>(false, url, routeParamValues, headers, username, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> GetByUsernamePassword(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/GetByUsernamePassword";
            return _client.SendAsync<Organization.Core.Model.User>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> GetUserByUserNameMasterPassAsync(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/GetUserByUserNameMasterPass";
            return _client.SendAsync<Organization.Core.Model.User>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> GetByNationalCode(System.String nationalCode, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "nationalCode", nationalCode == null ? null : nationalCode.ToString() } };
            const string url = "api/v1/User/GetByNationalCode/{nationalCode}";
            return _client.SendAsync<Organization.Core.Model.User>(true, url, routeParamValues, headers, nationalCode, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> GetByNationalCodeThenByIndividualInformation(System.String nationalCode, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "nationalCode", nationalCode == null ? null : nationalCode.ToString() } };
            const string url = "api/v1/User/GetByNationalCodeThenByIndividualInformation/{nationalCode}";
            return _client.SendAsync<Organization.Core.Model.User>(true, url, routeParamValues, headers, nationalCode, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> GetByEmail(System.String email, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "email", email == null ? null : email.ToString() } };
            const string url = "api/v1/User/GetByEmail/{email}";
            return _client.SendAsync<Organization.Core.Model.User>(true, url, routeParamValues, headers, email, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.UserSetting>> GetSetting(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/User/GetSetting";
            return _client.SendAsync<Organization.Core.Model.UserSetting>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> DeleteTokensBySsoTicket(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/User/DeleteTokensBySsoTicket";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.UserSetting>> GetSettingByUserId(System.Guid userId, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "userId", userId == null ? null : userId.ToString() } };
            const string url = "api/v1/User/GetSettingByUserId/{userId:guid}";
            return _client.SendAsync<Organization.Core.Model.UserSetting>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> EmptyInvalidUsersUsingShahkar(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/User/EmptyInvalidUsersUsingShahkar";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> EmptyInvalidUsersUsingSabteAhval(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/User/EmptyInvalidUsersUsingSabteAhval";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> ValidateUserWithShahkar(Kama.Organization.Core.Model.Shahkar.ShahkarVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/validate-user-with-shahkar";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.UserGridSetting>> GetGridSetting(Kama.Organization.Core.Model.UserGridSetting model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/GetGridSetting";
            return _client.SendAsync<Organization.Core.Model.UserGridSetting>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.UserGridSetting>> CreateGridSetting(Kama.Organization.Core.Model.UserGridSetting model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/CreateGridSetting";
            return _client.SendAsync<Organization.Core.Model.UserGridSetting>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.UserGridSetting>> UpdateGridSetting(Kama.Organization.Core.Model.UserGridSetting model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/UpdateGridSetting";
            return _client.SendAsync<Organization.Core.Model.UserGridSetting>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> SendSecurityCodeBySmsByNationalCode(Kama.Organization.Core.Model.UserListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/SendSecurityCodeBySmsByNationalCode";
            return _client.SendAsync<Organization.Core.Model.User>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.Attachment>> GetProfilePicture(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/User/GetProfilePicture";
            return _client.SendAsync<Organization.Core.Model.Attachment>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.User>> AddUserByIndividual(Kama.Organization.Core.Model.User model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/User/AddUserByIndividual";
            return _client.SendAsync<Organization.Core.Model.User>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class WebServiceService : Interface.IWebServiceService
    {
        public WebServiceService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebService>> Add(Kama.Organization.Core.Model.WebService model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebService/Add";
            return _client.SendAsync<Organization.Core.Model.WebService>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebService>> Edit(Kama.Organization.Core.Model.WebService model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebService/Edit";
            return _client.SendAsync<Organization.Core.Model.WebService>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/WebService/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebService>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/WebService/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.WebService>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceForPermissionAcount>> GetForPermissionAcount(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/WebService/GetForPermissionAcount/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.WebServiceForPermissionAcount>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.WebService>>> List(Kama.Organization.Core.Model.WebServiceListVM listVM, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "listVM", listVM == null ? null : listVM.ToString() } };
            const string url = "api/v1/WebService/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.WebService>>(true, url, routeParamValues, headers, listVM, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebService>> UpdateLocalInquiryState(Kama.Organization.Core.Model.WebServiceInquiryStateVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebService/UpdateLocalInquiryState";
            return _client.SendAsync<Organization.Core.Model.WebService>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebService>> UpdateGsbInquiryState(Kama.Organization.Core.Model.WebServiceInquiryStateVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebService/UpdateGsbInquiryState";
            return _client.SendAsync<Organization.Core.Model.WebService>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> UpdateEnbaleState(Kama.Organization.Core.Model.WebService model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebService/UpdateEnbaleState";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> InquiryAllActiveWebServices(IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { };
            const string url = "api/v1/WebService/InquiryAllActiveWebServices";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.WebServiceForPermissionAcount>>> ListForPermissionAcount(Kama.Organization.Core.Model.WebServiceForPermissionAcountListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebService/ListForPermissionAcount";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.WebServiceForPermissionAcount>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.InquiryReports>> GetInquiryDetails(Kama.Organization.Core.Model.InquiryReportsListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebService/GetInquiryDetails";
            return _client.SendAsync<Organization.Core.Model.InquiryReports>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryReports>>> GetInquiryDetailsForChart(Kama.Organization.Core.Model.InquiryReportsListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebService/GetInquiryDetailsForChart";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.InquiryReports>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class WebServiceUserActionService : Interface.IWebServiceUserActionService
    {
        public WebServiceUserActionService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUserAction>> Create(Kama.Organization.Core.Model.WebServiceUserAction model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebServiceUserAction/Create";
            return _client.SendAsync<Organization.Core.Model.WebServiceUserAction>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/WebServiceUserAction/Delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.WebServiceUserAction>>> List(Kama.Organization.Core.Model.WebServiceUserActionListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebServiceUserAction/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.WebServiceUserAction>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUserAction>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/WebServiceUserAction/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.WebServiceUserAction>(true, url, routeParamValues, headers, timeOut);
        }

    }

    partial class WebServiceUserService : Interface.IWebServiceUserService
    {
        public WebServiceUserService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUser>> Add(Kama.Organization.Core.Model.WebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebServiceUser/Add";
            return _client.SendAsync<Organization.Core.Model.WebServiceUser>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUser>> Edit(Kama.Organization.Core.Model.WebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebServiceUser/edit";
            return _client.SendAsync<Organization.Core.Model.WebServiceUser>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUser>> ResetPassword(Kama.Organization.Core.Model.WebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebServiceUser/Reset-Password";
            return _client.SendAsync<Organization.Core.Model.WebServiceUser>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/WebServiceUser/delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result> CheckUsagePermission(Kama.Organization.Core.Model.CheckWebServiceUserPermission model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebServiceUser/CheckUsagePermission";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.WebServiceUser>>> List(Kama.Organization.Core.Model.WebServiceUserListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebServiceUser/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.WebServiceUser>>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUser>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/WebServiceUser/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.WebServiceUser>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUser>> GetByUserName(System.String userName, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "userName", userName == null ? null : userName.ToString() } };
            const string url = "api/v1/WebServiceUser/GetByUserName/{userName}";
            return _client.SendAsync<Organization.Core.Model.WebServiceUser>(true, url, routeParamValues, headers, userName, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUser>> Get(Kama.Organization.Core.Model.WebServiceUserGetVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebServiceUser/Get";
            return _client.SendAsync<Organization.Core.Model.WebServiceUser>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Byte[]>> GetExcel(Kama.Organization.Core.Model.WebServiceUserListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebServiceUser/get-excel";
            return _client.SendAsync<System.Byte[]>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> UpdateEnbaleState(Kama.Organization.Core.Model.WebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebServiceUser/UpdateEnbaleState";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> UpdateIndividualID(Kama.Organization.Core.Model.WebServiceUser model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebServiceUser/UpdateIndividualID";
            return _client.SendAsync(true, url, routeParamValues, headers, model, timeOut);
        }

    }

    partial class WebServiceUserPermissionService : Interface.IWebServiceUserPermissionService
    {
        public WebServiceUserPermissionService(IOrganizationApiClient client)
        {
            _client = client;
        }

        readonly IOrganizationApiClient _client;

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUserPermission>> Add(Kama.Organization.Core.Model.WebServiceUserPermission model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebServiceUserPermission/Add";
            return _client.SendAsync<Organization.Core.Model.WebServiceUserPermission>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUserPermission>> Edit(Kama.Organization.Core.Model.WebServiceUserPermission model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebServiceUserPermission/edit";
            return _client.SendAsync<Organization.Core.Model.WebServiceUserPermission>(true, url, routeParamValues, headers, model, timeOut);
        }

        public Task<Kama.AppCore.Result> Delete(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/WebServiceUserPermission/delete/{id:guid}";
            return _client.SendAsync(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<Kama.Organization.Core.Model.WebServiceUserPermission>> Get(System.Guid id, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "id", id == null ? null : id.ToString() } };
            const string url = "api/v1/WebServiceUserPermission/Get/{id:guid}";
            return _client.SendAsync<Organization.Core.Model.WebServiceUserPermission>(true, url, routeParamValues, headers, timeOut);
        }

        public Task<Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.WebServiceUserPermission>>> List(Kama.Organization.Core.Model.WebServiceUserPermissionListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
        {
            var routeParamValues = new Dictionary<string, string> { { "model", model == null ? null : model.ToString() } };
            const string url = "api/v1/WebServiceUserPermission/List";
            return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.Organization.Core.Model.WebServiceUserPermission>>(true, url, routeParamValues, headers, model, timeOut);
        }

    }

}
