using System;
using System.Collections.Generic;

namespace Kama.Organization.Core.Model
{
    public class ApplicationSurveyQuestionChoice
    {
        public System.Guid RemoverPositionID { get; set; }

        public System.Guid QuestionID { get; set; }

        public System.String Name { get; set; }

        public System.String QuestionName { get; set; }

        public System.DateTime RemoveDate { get; set; }

        public System.Boolean Enable { get; set; }

        public System.Int32 Total { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationSurveyQuestionChoiceListVM
    {
        public System.Guid QuestionID { get; set; }

        public System.String Name { get; set; }

        public System.String QuestionName { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationSurveyParticipant
    {
        public System.Guid UserID { get; set; }

        public System.Guid SurveyID { get; set; }

        public System.DateTime Date { get; set; }

        public System.String FullName { get; set; }

        public System.String SurveyName { get; set; }

        public System.Int32 Total { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationSurveyAnswer
    {
        public System.Guid ChoiceID { get; set; }

        public System.Guid ParticipantID { get; set; }

        public System.Guid QuestionID { get; set; }

        public System.String Text { get; set; }

        public System.String FullName { get; set; }

        public System.String SurveyName { get; set; }

        public System.String ChoiceTitle { get; set; }

        public System.Boolean Agree { get; set; }

        public System.Int32 Total { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationSurveyParticipantListVM
    {
        public System.Guid SurveyID { get; set; }

        public System.Guid UserID { get; set; }

        public System.DateTime Date { get; set; }

        public System.String FullName { get; set; }

        public System.String SurveyName { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationSurveyAnswerListVM
    {
        public System.Guid ParticipantID { get; set; }

        public System.Guid QuestionID { get; set; }

        public System.Guid ChoiceID { get; set; }

        public System.String Text { get; set; }

        public System.String FullName { get; set; }

        public System.String SurveyName { get; set; }

        public System.String ChoiceTitle { get; set; }

        public System.Boolean Agree { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationSurveyQuestionListVM
    {
        public System.Guid GroupID { get; set; }

        public System.String Name { get; set; }

        public Kama.Organization.Core.Model.ApplicationSurveyQuestionType Type { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationSurveyQuestion
    {
        public System.Int32 Total { get; set; }

        public System.String Name { get; set; }

        public Kama.Organization.Core.Model.ApplicationSurveyQuestionType Type { get; set; }

        public System.Guid GroupID { get; set; }

        public System.String GroupName { get; set; }

        public System.Guid ApplicationSurveyID { get; set; }

        public System.String ApplicationSurveyName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationSurveyGroupListVM
    {
        public System.Int32 Total { get; set; }

        public System.Guid ApplicationSurveyID { get; set; }

        public System.String Name { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationSurveyGroup
    {
        public System.Int32 Total { get; set; }

        public System.Guid ApplicationSurveyID { get; set; }

        public System.String Name { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationSurveyListVM
    {
        public System.String Name { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationSurvey
    {
        public System.Int32 Total { get; set; }

        public System.Guid ApplicationID { get; set; }

        public System.String Name { get; set; }

        public System.Boolean Enable { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class Auth
    {
        public System.Boolean isAuthorized { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class ContactDetail
    {
        public System.Guid ContactInfoID { get; set; }

        public Kama.Organization.Core.Model.ContactDetailType Type { get; set; }

        public System.String Name { get; set; }

        public System.String Value { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class ContactInfo
    {
        public System.Guid ParentID { get; set; }

        public System.String Name { get; set; }

        public System.Int32 Order { get; set; }

        public List<Kama.Organization.Core.Model.ContactDetail> ContactDetails { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.String Hash { get; set; }

    }
    public class FAQGroup
    {
        public System.Int32 Total { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.String Title { get; set; }

        public System.Guid CreatorID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public List<Kama.Organization.Core.Model.FAQ> FAQs { get; set; }

        public System.Guid ID { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class HelpSection
    {
        public System.Guid HelpSectionGroupID { get; set; }

        public System.Int32 Order { get; set; }

        public System.Boolean IsActive { get; set; }

        public System.Boolean IsFileModified { get; set; }

        public System.String Title { get; set; }

        public System.String Description { get; set; }

        public Kama.Organization.Core.Model.FileType FileType { get; set; }

        public System.String FileName { get; set; }

        public System.Int32 Total { get; set; }

        public System.String GroupTitle { get; set; }

        public System.String GroupDescription { get; set; }

        public System.Guid ApplicationID { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.String Hash { get; set; }

    }
    public class HelpSectionGroup
    {
        public System.Int32 Order { get; set; }

        public System.String Title { get; set; }

        public System.String Description { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.Int32 Total { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.String Hash { get; set; }

    }
    public class HelpSectionGroupListVM
    {
        public System.String Title { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Description { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class HelpSectionListVM
    {
        public System.Guid? HelpSectionGroupID { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Title { get; set; }

        public System.String Description { get; set; }

        public Kama.Organization.Core.Model.FileType FileType { get; set; }

        public System.String FileName { get; set; }

        public Kama.Organization.Core.Model.EnableState IsActive { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class Message
    {
        public System.Guid ApplicationID { get; set; }

        public System.Guid SenderUserID { get; set; }

        public System.Guid SenderPositionID { get; set; }

        public System.String SenderUserFullName { get; set; }

        public System.Byte SenderPositionType { get; set; }

        public System.Guid CurrentUserID { get; set; }

        public System.Guid MessageID { get; set; }

        public System.Byte SendType { get; set; }

        public System.Guid ParentID { get; set; }

        public System.String Title { get; set; }

        public System.String SenderDepartmentName { get; set; }

        public System.String ReceiverUserFullName { get; set; }

        public System.String ReceiverDepartment { get; set; }

        public System.Guid ReceiverPositionID { get; set; }

        public System.Byte ReceiverPositionType { get; set; }

        public System.String Content { get; set; }

        public System.Boolean IsRemoved { get; set; }

        public System.Boolean IsSent { get; set; }

        public System.String TimePart { get; set; }

        public List<Kama.Organization.Core.Model.MessageReceiver> ReceiverUsers { get; set; }

        public System.Boolean Seen { get; set; }

        public System.Int32 Total { get; set; }

        public System.DateTime? ExpireDate { get; set; }

        public Kama.Organization.Core.Model.MessageType MessageType { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class DraftMessageListVM
    {
        public System.Guid ReceiverUserID { get; set; }

        public System.String Title { get; set; }

        public System.String Content { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class OutboxMessageListVM
    {
        public System.Guid ReceiverUserID { get; set; }

        public System.String ReceiverUserFullName { get; set; }

        public System.Guid ReceiverPositionID { get; set; }

        public System.Byte ReceiverPositionType { get; set; }

        public System.String Title { get; set; }

        public System.String Content { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class InboxMessageListVM
    {
        public System.Guid SenderUserID { get; set; }

        public System.Guid SenderPositionID { get; set; }

        public System.Byte SenderPositionType { get; set; }

        public System.String SenderUserFullName { get; set; }

        public System.String SenderDepartmentName { get; set; }

        public System.String Title { get; set; }

        public System.String Content { get; set; }

        public System.Guid DepartmentID { get; set; }

        public System.Boolean Seen { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class NotificationCondition
    {
        public System.Guid NotificationID { get; set; }

        public Kama.Organization.Core.Model.NotificationState State { get; set; }

        public System.Guid? DepartmentID { get; set; }

        public System.String DepartmentName { get; set; }

        public System.Guid? ProvinceID { get; set; }

        public System.String ProvinceName { get; set; }

        public System.Guid? PositionID { get; set; }

        public System.Byte PositionType { get; set; }

        public System.String FullName { get; set; }

        public System.Int32 Total { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class Notification
    {
        public System.Guid? SenderPositionID { get; set; }

        public System.String SenderName { get; set; }

        public System.String Title { get; set; }

        public System.String Content { get; set; }

        public Kama.Organization.Core.Model.NotificationPriority Priority { get; set; }

        public Kama.Organization.Core.Model.NotificationState State { get; set; }

        public List<Kama.Organization.Core.Model.Position> Positions { get; set; }

        public List<Kama.Organization.Core.Model.NotificationPosition> ReceiverPositions { get; set; }

        public System.Int32 Total { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class NotificationConditionsListVM
    {
        public System.Guid NotificationID { get; set; }

        public System.Guid? DepartmentID { get; set; }

        public System.String DepartmentName { get; set; }

        public System.Guid? ProvinceID { get; set; }

        public System.String ProvinceName { get; set; }

        public System.Byte PositionType { get; set; }

        public System.String FullName { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class NotificationPositionsListVM
    {
        public System.Guid NotificationID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class NotificationPosition
    {
        public System.String FullName { get; set; }

        public Kama.Organization.Core.Model.PositionType PositionType { get; set; }

        public System.String DepartmentName { get; set; }

        public System.Int32 Total { get; set; }

    }
    public class NotificationListByPositionVM
    {
    }
    public class NotificationsListVM
    {
        public Kama.Organization.Core.Model.NotificationSenderType SenderType { get; set; }

        public System.String Title { get; set; }

        public System.String Content { get; set; }

        public Kama.Organization.Core.Model.NotificationPriority Priority { get; set; }

        public Kama.Organization.Core.Model.NotificationState State { get; set; }

        public System.DateTime? CreationDateFrom { get; set; }

        public System.DateTime? CreationDateTo { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class TicketForCallCenterListVM
    {
        public System.Guid? SubjectID { get; set; }

        public System.String TrackingCode { get; set; }

        public System.Guid? DepartmentID { get; set; }

        public System.String DepartmentName { get; set; }

        public System.Byte Score { get; set; }

        public System.DateTime? ReadDate { get; set; }

        public System.Guid? CreatorPositionID { get; set; }

        public System.Guid? OwnerID { get; set; }

        public System.Guid? OwnerPositionID { get; set; }

        public Kama.Organization.Core.Model.TicketReportState State { get; set; }

        public System.String Title { get; set; }

        public System.String SubjectTitle { get; set; }

        public System.String OwnerFullName { get; set; }

        public Kama.Organization.Core.Model.TicketPriority Priority { get; set; }

        public System.DateTime CreationDate { get; set; }

        public Kama.Organization.Core.Model.TicketAnswerState TicketAnswerState { get; set; }

        public System.DateTime? CloseDate { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class Ticket
    {
        public System.Guid ApplicationID { get; set; }

        public System.Guid SubjectID { get; set; }

        public System.Guid CreatorUserID { get; set; }

        public Kama.Organization.Core.Model.TicketReportState State { get; set; }

        public System.DateTime? ReadDate { get; set; }

        public System.DateTime? LastReadDate { get; set; }

        public System.String TrackingCode { get; set; }

        public System.String Title { get; set; }

        public System.String SubjectTitle { get; set; }

        public Kama.Organization.Core.Model.TicketPriority Priority { get; set; }

        public System.Byte Score { get; set; }

        public Kama.Organization.Core.Model.SakhtarPositionType PositionType { get; set; }

        public System.Guid CreatorPositionID { get; set; }

        public System.Guid? LastTicketSequenceUserID { get; set; }

        public System.Guid? OwnerID { get; set; }

        public System.Guid? DepartmentID { get; set; }

        public System.Guid? OwnerPositionID { get; set; }

        public System.String DepartmentName { get; set; }

        public System.String OwnerPositionName { get; set; }

        public System.String OwnerFullName { get; set; }

        public System.String CreatorUserName { get; set; }

        public System.Boolean IsRead { get; set; }

        public System.Int32 Total { get; set; }

        public System.Byte TicketAnswerState { get; set; }

        public System.Int32 SequenceCount { get; set; }

        public System.DateTime? CloseDate { get; set; }

        public System.Int32 AnsweringTime { get; set; }

        public System.String ApplicationName { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.String NationalCode { get; set; }

        public System.String CellPhone { get; set; }

        public System.Guid? UserID { get; set; }

        public System.Guid? FAQGroupID { get; set; }

        public Kama.Organization.Core.Model.CreationTicketType CreationTicketType { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class TicketReportAllListVM
    {
        public System.Guid? ApplicationID { get; set; }

        public System.Guid? SubjectID { get; set; }

        public System.String TrackingCode { get; set; }

        public System.Guid? DepartmentID { get; set; }

        public Kama.Organization.Core.Model.TicketReportState State { get; set; }

        public System.Byte Score { get; set; }

        public System.String Title { get; set; }

        public Kama.Organization.Core.Model.TicketPriority Priority { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.DateTime? CreationDateFrom { get; set; }

        public System.DateTime? CreationDateTo { get; set; }

        public Kama.Organization.Core.Model.CreationTicketType CreationTicketType { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class TicketReportListVM
    {
        public System.Guid? SubjectID { get; set; }

        public System.String TrackingCode { get; set; }

        public System.Guid? DepartmentID { get; set; }

        public System.Guid? SubjectUserID { get; set; }

        public Kama.Organization.Core.Model.TicketReportState State { get; set; }

        public System.Byte Score { get; set; }

        public System.String Title { get; set; }

        public Kama.Organization.Core.Model.TicketPriority Priority { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.Guid? OwnerID { get; set; }

        public System.DateTime? CreationDateFrom { get; set; }

        public System.DateTime? CreationDateTo { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class TicketListVM
    {
        public System.Guid? SubjectID { get; set; }

        public System.String TrackingCode { get; set; }

        public System.Guid? DepartmentID { get; set; }

        public System.String DepartmentName { get; set; }

        public System.Byte Score { get; set; }

        public System.DateTime? ReadDate { get; set; }

        public System.Guid? CreatorPositionID { get; set; }

        public System.Guid? OwnerID { get; set; }

        public System.Guid? OwnerPositionID { get; set; }

        public Kama.Organization.Core.Model.TicketReportState State { get; set; }

        public System.String Title { get; set; }

        public System.String SubjectTitle { get; set; }

        public System.String OwnerFullName { get; set; }

        public Kama.Organization.Core.Model.TicketPriority Priority { get; set; }

        public System.DateTime CreationDate { get; set; }

        public Kama.Organization.Core.Model.TicketAnswerState TicketAnswerState { get; set; }

        public System.DateTime? CloseDate { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public Kama.Organization.Core.Model.CreationTicketType CreationTicketType { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class TicketSequence
    {
        public System.Guid UserID { get; set; }

        public System.Guid TicketID { get; set; }

        public System.Guid? AttachmentID { get; set; }

        public System.String Content { get; set; }

        public System.DateTime? ReadDate { get; set; }

        public System.String TicketSequenceUserName { get; set; }

        public System.String DepartmentName { get; set; }

        public System.Byte PositionType { get; set; }

        public System.String TimePart { get; set; }

        public System.Int32 Total { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class TicketSequenceListVM
    {
        public System.Guid TicketID { get; set; }

        public System.Guid UserID { get; set; }

        public System.String Content { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.DateTime? ReadDate { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class TicketSubject
    {
        public System.String Name { get; set; }

        public System.Int32 Total { get; set; }

        public System.Boolean Enable { get; set; }

        public System.String Description { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.String ApplicationName { get; set; }

        public System.Guid? FAQGroupID { get; set; }

        public System.String FAQGroupName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class TicketSubjectListVM
    {
        public System.Guid? ApplicationID { get; set; }

        public System.String Name { get; set; }

        public Kama.Organization.Core.Model.EnableState Enable { get; set; }

        public System.Guid? FAQGroupID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class TicketSubjectUser
    {
        public System.Guid ApplicationID { get; set; }

        public System.Guid TicketSubjectID { get; set; }

        public System.String SubjectName { get; set; }

        public System.String UserName { get; set; }

        public System.String NationalCode { get; set; }

        public System.Guid UserID { get; set; }

        public System.Guid? PositionID { get; set; }

        public Kama.Organization.Core.Model.PositionType PositionType { get; set; }

        public System.Int32 Total { get; set; }

        public System.String Name { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class TicketSubjectUserListVM
    {
        public System.Guid UserID { get; set; }

        public System.Guid TicketSubjectID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class CommandDictionary
    {
    }
    public class DataBaseBackupVM
    {
        public System.String DatabaseName { get; set; }

        public Kama.Organization.Core.Model.BackupType BackupType { get; set; }

        public System.DateTime? BackupStartDate { get; set; }

        public System.DateTime? BackupFinishDate { get; set; }

        public System.Decimal BackupSizeMB { get; set; }

        public System.Int32 Total { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class JobLogVM
    {
        public System.Guid JobID { get; set; }

        public System.Guid StepID { get; set; }

        public System.String JobName { get; set; }

        public System.String JobDescription { get; set; }

        public System.String StepDescription { get; set; }

        public System.String LastRunStatus { get; set; }

        public Kama.Organization.Core.Model.JobStatus JobStatus { get; set; }

        public Kama.Organization.Core.Model.StepStatus StepStatus { get; set; }

        public System.DateTime? LastRunDateTime { get; set; }

        public System.DateTime? NextRunDateTime { get; set; }

        public System.String LastRunDuration { get; set; }

        public System.Int32 Total { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class AttachmentListVM
    {
        public List<System.Guid> ParentIDs { get; set; }

        public System.Guid? ParentID { get; set; }

        public Kama.Organization.Core.Model.OrganizationAttachmentType Type { get; set; }

        public Kama.Organization.Core.Model.AttachmentLoadDataType LoadDataType { get; set; }

    }
    public class JobVM
    {
        public System.Guid JobID { get; set; }

        public System.String JobDescription { get; set; }

    }
    public class StepVM
    {
        public System.Guid JobID { get; set; }

        public System.Guid StepID { get; set; }

        public System.String StepDescription { get; set; }

    }
    public class Extensions
    {
    }
    public class InquiryLog
    {
        public System.Int32 Total { get; set; }

        public System.Guid IndividualID { get; set; }

        public System.Guid AddressID { get; set; }

        public System.Guid AttachmentID { get; set; }

        public System.Guid ApplicationID { get; set; }

        public System.String PostalCode { get; set; }

        public System.String NationalCode { get; set; }

        public System.String RedirectApiUrl { get; set; }

        public Kama.Organization.Core.Model.InquiryResultType ResultType { get; set; }

        public System.Int32 ResultCount { get; set; }

        public System.String ResultMessage { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class InquiryLogListVM
    {
        public System.Int32 Total { get; set; }

        public System.Guid? IndividualID { get; set; }

        public System.Guid? AttachmentID { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.Guid? AddressID { get; set; }

        public System.String PostalCode { get; set; }

        public System.String NationalCode { get; set; }

        public System.DateTime? StartDate { get; set; }

        public System.DateTime? EndDate { get; set; }

        public Kama.Organization.Core.Model.InquiryResultType ResultType { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class AddressVM
    {
        public System.Guid ID { get; set; }

        public System.String PostalCode { get; set; }

        public System.Boolean InquiryOnlineOnly { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class ValidatePostalCodeVM
    {
        public IEnumerable<System.String> PostalCode { get; set; }

    }
    public class ValidatePostalCode
    {
        public System.String PostalCode { get; set; }

        public System.Boolean IsExist { get; set; }

    }
    public class BankMarkaziSheba
    {
        public System.Boolean IsValid { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class BankMarkaziShebaListVM
    {
        public Kama.Organization.Core.Model.AccountOwnerType AccountOwnerType { get; set; }

        public System.String NationalCode { get; set; }

        public System.String LegalId { get; set; }

        public System.String ShebaId { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class Vaccine
    {
        public System.Guid IndividualID { get; set; }

        public System.Int32 NumberOfReceivedDoses { get; set; }

        public System.DateTime LastDoseDate { get; set; }

        public System.String LastDoseDateFa { get; set; }

        public System.String HealthStatus { get; set; }

        public System.String PermissionStatus { get; set; }

        public System.Boolean? Quarantined { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class VaccineListVM
    {
        public System.Guid? IndividualID { get; set; }

        public System.String NationalCode { get; set; }

        public System.DateTime? StartDate { get; set; }

        public System.DateTime? EndDate { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class VaccineVM
    {
        public System.Guid IndividualID { get; set; }

    }
    public class EducationalInquiry
    {
        public System.Guid IndividualID { get; set; }

        public System.String TrackCode { get; set; }

        public System.String NationalCode { get; set; }

        public System.String PhoneNumber { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class Educational2
    {
        public System.Guid IndividualID { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.String FatherName { get; set; }

        public System.String Nationalcode { get; set; }

        public System.String BirthDate { get; set; }

        public System.String IdentificationNo { get; set; }

        public System.String UniStudyLevel { get; set; }

        public System.String UniStudyingMode { get; set; }

        public System.String UniStudentStatus { get; set; }

        public System.String UniCourseStudy { get; set; }

        public System.String UniStartDate { get; set; }

        public System.String UniStopDate { get; set; }

        public System.String MsrtStudyingMode { get; set; }

        public System.String MsrtStudyLevel { get; set; }

        public System.String MsrtStudentStatus { get; set; }

        public System.String PersonCode { get; set; }

        public System.String University { get; set; }

        public System.Double? TotalAverage { get; set; }

        public Kama.Organization.Core.Model.Gender Gender { get; set; }

        public System.DateTime? IndividualBirthDate { get; set; }

        public System.Int32 Total { get; set; }

        public System.String NationalCode { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class Educational2ListVM
    {
        public System.Guid? IndividualID { get; set; }

        public System.String NationalCode { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public Kama.Organization.Core.Model.Gender Gender { get; set; }

        public System.String UniStudyLevel { get; set; }

        public System.String UniStudyingMode { get; set; }

        public System.String UniCourseStudy { get; set; }

        public System.String University { get; set; }

        public System.Single? AverageLowRange { get; set; }

        public System.Single? AverageHighRange { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class EducationalListVM
    {
        public System.Guid? IndividualID { get; set; }

        public System.String NationalCode { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class Educational
    {
        public System.Guid IndividualID { get; set; }

        public System.Int32 UniversityId { get; set; }

        public System.String UniversityName { get; set; }

        public System.String FacultyName { get; set; }

        public System.String CourseTitle { get; set; }

        public System.String MsrtCourseTitle { get; set; }

        public System.String StopDate { get; set; }

        public Kama.Organization.Core.Model.StudentStatusEnum StudentStatus { get; set; }

        public Kama.Organization.Core.Model.StudentStatusEnum MsrtStudentStatus { get; set; }

        public System.String MsrtStudentStatusCode { get; set; }

        public System.String StudyLevelTitle { get; set; }

        public System.String MsrtstudyLevelTitle { get; set; }

        public System.String MsrtstudyLevelCode { get; set; }

        public Kama.Organization.Core.Model.StudyingModeEnum StudyingMode { get; set; }

        public Kama.Organization.Core.Model.StudyingModeEnum MsrtStudyingMode { get; set; }

        public System.String MsrtStudyingModeCode { get; set; }

        public System.Double? TotalAverage { get; set; }

        public System.String UserTypeName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class JudicialClearances
    {
    }
    public class JudicialVoteConfirmation
    {
        public System.String DocumentNumber { get; set; }

        public System.Byte[] PDFData { get; set; }

    }
    public class JudicialClearancesVM
    {
    }
    public class JudicialVoteConfirmationVM
    {
        public System.String DocumentNumber { get; set; }

        public System.DateTime? DocumentCreationDate { get; set; }

        public System.String DocumentCaseNumber { get; set; }

    }
    public class OmidVaccine
    {
        public System.Guid IndividualID { get; set; }

        public System.Int32 NumberOfReceivedDoses { get; set; }

        public System.String HealthStatus { get; set; }

        public System.String PermissionStatus { get; set; }

        public System.Boolean? Quarantined { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class OmidVaccineVM
    {
        public System.Guid IndividualID { get; set; }

    }
    public class Data
    {
        public System.Boolean IsRetired { get; set; }

        public System.Boolean IsEmployed { get; set; }

        public System.Boolean IsRetiredReturnEmployed { get; set; }

        public System.Object RetiredOrganizationCode { get; set; }

        public System.Object RetiredOrganizationPost { get; set; }

        public System.DateTime RetiredDate { get; set; }

        public System.Int32 RetiredDays { get; set; }

        public System.Int32 EmployedDays { get; set; }

        public System.String EmployedOrganizationPost { get; set; }

        public System.String EmployedOrganization { get; set; }

        public System.String EmployedLastSalary { get; set; }

        public System.Object EmployementLastSalary { get; set; }

        public System.String LastManagerialBonus { get; set; }

    }
    public class Datum
    {
        public System.Object ErrorCode { get; set; }

        public System.Boolean HasValue { get; set; }

        public System.String ResourceName { get; set; }

        public System.Guid IndividualID { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.String ResourceType { get; set; }

        public System.Int32 Row { get; set; }

        public System.Boolean HasError { get; set; }

        public System.String NationalCode { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.String InsuranceType { get; set; }

        public System.String BookletExpirationDate { get; set; }

        public System.String InsuranceId { get; set; }

        public System.String FatherName { get; set; }

        public System.String InsuredRelationType { get; set; }

        public System.String Relation { get; set; }

        public System.String RelationType { get; set; }

        public System.String InquiryDate { get; set; }

        public System.String LastWorkingMonth { get; set; }

        public System.String WorkShopName { get; set; }

    }
    public class Address
    {
        public System.String PostalCode { get; set; }

        public System.Guid? ProvinceID { get; set; }

        public System.String ProvinceName { get; set; }

        public System.Guid? CityID { get; set; }

        public System.String CityName { get; set; }

        public System.Guid? DistrictID { get; set; }

        public System.String DistrictName { get; set; }

        public System.Guid? TownID { get; set; }

        public System.String TownName { get; set; }

        public System.String LocalityName { get; set; }

        public System.String VillageName { get; set; }

        public System.String SubLocality { get; set; }

        public System.String Street { get; set; }

        public System.String Street2 { get; set; }

        public System.String HouseNumber { get; set; }

        public System.String BuildingName { get; set; }

        public System.String Description { get; set; }

        public System.String Floor { get; set; }

        public System.String SideFloor { get; set; }

        public System.String LocationName { get; set; }

        public System.Double Long { get; set; }

        public System.Double Lat { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class InquiryState
    {
        public System.Guid IndividualID { get; set; }

        public System.Guid WebServiceID { get; set; }

        public System.Guid AddressID { get; set; }

        public System.Guid ApplicationID { get; set; }

        public System.Guid AttachmentID { get; set; }

        public Kama.Organization.Core.Model.InquiryResultType ResultType { get; set; }

        public Kama.Organization.Core.Model.IsManager IsManager { get; set; }

        public Kama.Organization.Core.Model.WebServiceLocationType WebServiceLocationType { get; set; }

        public System.Int32 ResultCount { get; set; }

        public System.String ResultMessage { get; set; }

        public System.String RedirectApiUrl { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class CLPLegalPersonReviewVM
    {
        public System.String PassWord { get; set; }

        public Kama.Organization.Core.Model.CLPLegalPersonReview TheCLPLegalPersonReview { get; set; }

        public System.String UserName { get; set; }

    }
    public class CLPILegalPersonReviewType
    {
        public System.String Code { get; set; }

        public Kama.Organization.Core.Model.State State { get; set; }

        public System.String Title { get; set; }

    }
    public class CLPILegalPersonType
    {
        public System.String Code { get; set; }

        public Kama.Organization.Core.Model.State State { get; set; }

        public System.String Title { get; set; }

    }
    public class TheCLPLegalPerson
    {
        public System.String NationalCode { get; set; }

    }
    public class CLPIReferenceType
    {
        public System.String Code { get; set; }

        public System.String Title { get; set; }

        public Kama.Organization.Core.Model.State State { get; set; }

    }
    public class CLPLegalPersonReviewActLicList
    {
        public System.String DocFile { get; set; }

        public Kama.Organization.Core.Model.FileExtension FileExtension { get; set; }

        public System.String LastLicenseDateSH { get; set; }

        public System.String LicenseDateSH { get; set; }

        public System.String LicenseNumber { get; set; }

        public Kama.Organization.Core.Model.CLPIReferenceType TheCLPIReferenceType { get; set; }

    }
    public class TheAttachmentType
    {
        public System.String Code { get; set; }

        public Kama.Organization.Core.Model.State State { get; set; }

        public System.String Title { get; set; }

    }
    public class CLPLegalPersonReviewAttachList
    {
        public System.String AttachmentDocDate { get; set; }

        public System.String AttachmentDocNo { get; set; }

        public System.String DocFile { get; set; }

        public Kama.Organization.Core.Model.FileExtension FileExtension { get; set; }

        public System.String PageNum { get; set; }

        public Kama.Organization.Core.Model.TheAttachmentType TheAttachmentType { get; set; }

        public System.String Title { get; set; }

    }
    public class CLPICluster
    {
        public System.String Code { get; set; }

        public Kama.Organization.Core.Model.State State { get; set; }

        public System.String Title { get; set; }

    }
    public class CLPIClusterGroup
    {
        public System.String Code { get; set; }

        public Kama.Organization.Core.Model.State State { get; set; }

        public System.String Title { get; set; }

    }
    public class CLPLegalPersonReviewClstrGrpList
    {
        public Kama.Organization.Core.Model.CLPICluster TheCLPICluster { get; set; }

        public Kama.Organization.Core.Model.CLPIClusterGroup TheCLPIClusterGroup { get; set; }

    }
    public class CLPLegalPersonReviewField
    {
        public System.String AppCode { get; set; }

        public System.String UnitCode { get; set; }

    }
    public class CLPIPostType
    {
        public System.String Code { get; set; }

        public Kama.Organization.Core.Model.State State { get; set; }

        public System.String Title { get; set; }

    }
    public class CLPLegalPersonReviewPrsnPstList
    {
        public System.String Description { get; set; }

        public System.String EndDate { get; set; }

        public Kama.Organization.Core.Model.YesNo IsTopManager { get; set; }

        public System.String StartDate { get; set; }

        public Kama.Organization.Core.Model.CLPIPostType TheCLPIPostType { get; set; }

    }
    public class CLPLegalPersonReviewPrsnList
    {
        public System.String BirthDate { get; set; }

        public System.String DeathDate { get; set; }

        public System.String DecreeDate { get; set; }

        public System.String DecreeNo { get; set; }

        public System.String DecreeValidityDate { get; set; }

        public System.String FatherName { get; set; }

        public Kama.Organization.Core.Model.SexType Gender { get; set; }

        public Kama.Organization.Core.Model.YesNo LifeStatus { get; set; }

        public System.String MobileNumber { get; set; }

        public System.String NationalityCode { get; set; }

        public Kama.Organization.Core.Model.NationalityType NationalityType { get; set; }

        public System.String PersonFamily { get; set; }

        public System.String PersonName { get; set; }

        public Kama.Organization.Core.Model.PersonType PersonType { get; set; }

        public IList<Kama.Organization.Core.Model.CLPLegalPersonReviewPrsnPstList> TheCLPLegalPersonReviewPrsnPstList { get; set; }

    }
    public class NajaUnit
    {
        public System.String Code { get; set; }

        public Kama.Organization.Core.Model.State State { get; set; }

        public System.String Title { get; set; }

    }
    public class TheObjectStat
    {
        public System.String Code { get; set; }

        public Kama.Organization.Core.Model.State State { get; set; }

        public System.String Title { get; set; }

    }
    public class ParentNationalCode
    {
        public System.String NationalCode { get; set; }

    }
    public class CLPLegalPersonReview
    {
        public System.String Address { get; set; }

        public System.String BudgetCode { get; set; }

        public Kama.Organization.Core.Model.DependentLPType DependentLgpType { get; set; }

        public System.String EmailAddress { get; set; }

        public System.String NationalCode { get; set; }

        public System.String FaxNumber { get; set; }

        public System.String InquiryNameCode { get; set; }

        public System.String MobileNumber { get; set; }

        public System.String NameDescPE { get; set; }

        public System.String PostCode { get; set; }

        public System.String ResultText { get; set; }

        public System.String RegisterDateSH { get; set; }

        public System.String RegisterDate { get; set; }

        public System.Object RegisterNumber { get; set; }

        public System.String TelNumber { get; set; }

        public System.String UniqueRequestId { get; set; }

        public System.String WebSiteAddress { get; set; }

        public Kama.Organization.Core.Model.CLPLegalPersonReviewField TheCLPLegalPersonReviewField { get; set; }

        public Kama.Organization.Core.Model.NajaUnit TheNajaUnit { get; set; }

        public Kama.Organization.Core.Model.CLPILegalPersonReviewType TheCLPILegalPersonReviewType { get; set; }

        public Kama.Organization.Core.Model.CLPILegalPersonType TheCLPILegalPersonType { get; set; }

        public IList<Kama.Organization.Core.Model.CLPLegalPersonReviewActLicList> TheCLPLegalPersonReviewActLicList { get; set; }

        public IList<Kama.Organization.Core.Model.CLPLegalPersonReviewAttachList> TheCLPLegalPersonReviewAttachList { get; set; }

        public IList<Kama.Organization.Core.Model.CLPLegalPersonReviewClstrGrpList> TheCLPLegalPersonReviewClstrGrpList { get; set; }

        public IList<Kama.Organization.Core.Model.CLPLegalPersonReviewPrsnList> TheCLPLegalPersonReviewPrsnList { get; set; }

        public Kama.Organization.Core.Model.ParentNationalCode TheParentNationalCode { get; set; }

        public Kama.Organization.Core.Model.TheObjectStat TheObjectStat { get; set; }

        public System.String ReasonRequest { get; set; }

    }
    public class Example
    {
        public System.String PassWord { get; set; }

        public Kama.Organization.Core.Model.CLPLegalPersonReview TheCLPLegalPersonReview { get; set; }

        public System.String UserName { get; set; }

    }
    public class SpecialInquiryForSabteAsnadVaAmlakVM
    {
        public System.String NationalCode { get; set; }

        public System.String Name { get; set; }

    }
    public class SpecialInquiryForSabteAsnadVaAmlak
    {
        public System.String FollowUpNo { get; set; }

        public System.String NationalCode { get; set; }

        public System.String Name { get; set; }

        public System.String State { get; set; }

        public System.String EstablishmentDate { get; set; }

        public System.String RegisterDate { get; set; }

        public System.String RegisterNumber { get; set; }

        public System.String Address { get; set; }

        public System.String PostCode { get; set; }

        public System.String LastChangeDate { get; set; }

        public System.String LegalPersonType { get; set; }

        public System.String RegisterUnit { get; set; }

        public System.String Residency { get; set; }

        public System.String BreakupDate { get; set; }

        public System.String SettleDate { get; set; }

        public System.Boolean IsBranch { get; set; }

        public System.Boolean IsBreakup { get; set; }

        public System.Boolean IsSettle { get; set; }

        public System.Guid? SabteAsnadNationalcodeID { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class GetSacrificialStatusInquiryVM
    {
        public System.Guid IndividualID { get; set; }

        public System.Boolean OnlineInguiry { get; set; }

    }
    public class SacrificialTypeListVM
    {
        public System.Guid? SacrificialID { get; set; }

        public List<System.Guid> SacrificialIDs { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class SacrificialListVM
    {
        public System.Guid? IndividualID { get; set; }

        public List<System.Guid> IndividualIDs { get; set; }

        public System.String NationalCode { get; set; }

        public List<System.String> NationalCodes { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public Kama.Organization.Core.Model.Gender Gender { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class Sacrificial
    {
        public System.Guid IndividualID { get; set; }

        public System.String NationalCode { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.DateTime? BirthDate { get; set; }

        public System.Boolean IsDead { get; set; }

        public Kama.Organization.Core.Model.Gender Gender { get; set; }

        public Kama.Organization.Core.Model.IndividualConfirmType ConfirmType { get; set; }

        public System.Boolean HasSacrificialBackGround { get; set; }

        public List<Kama.Organization.Core.Model.SacrificialTypeModel> SacrificialTypes { get; set; }

        public System.Byte? VeteranPercent { get; set; }

        public System.Byte? ParentVeteranPercent { get; set; }

        public System.Byte? SpouseVeteranPercent { get; set; }

        public System.Int32? CaptivityDurationDays { get; set; }

        public System.Int32? ParentCaptivityDurationDays { get; set; }

        public System.Int32? SpouseCaptivityDurationDays { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class SacrificialTypeModel
    {
        public System.Guid SacrificialID { get; set; }

        public Kama.Organization.Core.Model.SacrificialType Type { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class Request
    {
        public System.String NationalCode { get; set; }

        public System.String UserName { get; set; }

        public System.String Password { get; set; }

    }
    public class RoostayanResponse
    {
        public System.Object data { get; set; }

        public System.Boolean succeeded { get; set; }

        public System.Object message { get; set; }

        public System.Object modelState { get; set; }

    }
    public class RootObject<T>
    {
        public System.Int32 serviceCode { get; set; }

        public System.Int32 trackCode { get; set; }

        public T data { get; set; }

        public System.Boolean succeeded { get; set; }

        public System.Object message { get; set; }

        public System.Object modelState { get; set; }

    }
    public class SalamatResponse
    {
        public List<Kama.Organization.Core.Model.Datum> data { get; set; }

        public System.Boolean succeeded { get; set; }

        public System.Object message { get; set; }

        public System.Object modelState { get; set; }

    }
    public class TaaminSocialResponse
    {
        public List<Kama.Organization.Core.Model.Datum> data { get; set; }

        public System.Boolean succeeded { get; set; }

        public System.Object message { get; set; }

        public System.Object modelState { get; set; }

    }
    public class ICTExcelLink
    {
        public System.String FileName { get; set; }

        public System.String URL { get; set; }

        public System.Byte[] ExcelData { get; set; }

    }
    public class ICTExcelLinkVM
    {
        public System.DateTime? Date { get; set; }

    }
    public class ApplicationAssignmentPosition
    {
        public System.Int32? Total { get; set; }

        public System.String NationalCode { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public Kama.Organization.Core.Model.PositionType PositionType { get; set; }

        public List<Kama.Organization.Core.Model.ApplicationForAssignment> AssignedApplications { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationForAssignment
    {
        public System.String Name { get; set; }

        public System.String Abbreviation { get; set; }

        public System.Guid PositionID { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class ClientListVM
    {
        public System.Guid ApplicationID { get; set; }

        public System.String Name { get; set; }

        public System.String UserID { get; set; }

        public System.String UserHash { get; set; }

        public System.String CallBack { get; set; }

        public Kama.Organization.Core.Model.SsoEnum Type { get; set; }

        public System.String Key { get; set; }

        public System.String Abbreviation { get; set; }

        public Kama.Organization.Core.Model.EnableState Enabled { get; set; }

        public Kama.Organization.Core.Model.ClientType TypeClient { get; set; }

        public System.String ConnectionHubId { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class DataBaseProblem
    {
        public System.String Code { get; set; }

        public System.Int32 Count { get; set; }

    }
    public class DepartmentEnableState
    {
        public System.Int32? Total { get; set; }

        public System.Guid ApplicationID { get; set; }

        public System.String ApplicationName { get; set; }

        public System.Guid DepartmentID { get; set; }

        public System.String DepartmentName { get; set; }

        public System.Boolean Enable { get; set; }

        public System.Boolean EnableForWebService { get; set; }

        public System.Boolean EnableForReport { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class DepartmentEnableStateListVM
    {
        public System.Guid DepartmentID { get; set; }

        public List<System.Guid> DepartmentIDs { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class DepartmentEnableStateUpdateListVM
    {
        public System.Guid DepartmentID { get; set; }

        public List<Kama.Organization.Core.Model.DepartmentEnableState> EnableStates { get; set; }

    }
    public class DynamicPermissionDepartment
    {
        public System.Int32 Total { get; set; }

        public System.Guid OrganID { get; set; }

        public System.String OrganName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class DynamicPermissionDepartmentListVM
    {
        public System.Guid? ObjectID { get; set; }

        public List<System.Guid> ObjectIDs { get; set; }

        public Kama.Organization.Core.Model.DynamicPermissionType DynamicPermissionType { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class ActiveToken
    {
        public System.String SsoTicket { get; set; }

        public List<Kama.Organization.Core.Model.ActiveTokenItems> Items { get; set; }

    }
    public class ActiveTokenItems
    {
        public System.String SsoTicket { get; set; }

        public System.Int32 Total { get; set; }

        public System.Guid UserID { get; set; }

        public System.DateTime IssuedDate { get; set; }

        public System.DateTime ExpireDate { get; set; }

        public System.Boolean Expired { get; set; }

        public System.Int16 OS { get; set; }

        public System.String OSVersion { get; set; }

        public System.Int16 Browser { get; set; }

        public System.String BrowserVersion { get; set; }

        public System.Int16 DeviceType { get; set; }

        public System.Guid ApplicationID { get; set; }

        public System.String ApplicationName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class IndividualAddVM
    {
        public System.Boolean GetSabteAhvalInquiry { get; set; }

        public System.Int32? Total { get; set; }

        public System.String NationalCode { get; set; }

        public System.String FirstName { get; set; }

        public System.String OrganCode { get; set; }

        public System.String OrganProvinceName { get; set; }

        public System.String OrganCityName { get; set; }

        public System.String LastName { get; set; }

        public System.String FatherName { get; set; }

        public System.String BCNumber { get; set; }

        public System.String SerialCard { get; set; }

        public Kama.Organization.Core.Model.Gender Gender { get; set; }

        public System.Boolean IsDead { get; set; }

        public System.DateTime? BirthDate { get; set; }

        public System.String BirthDateJalali { get; set; }

        public Kama.Organization.Core.Model.IndividualConfirmType ConfirmType { get; set; }

        public System.Byte Isaargar { get; set; }

        public System.Byte[] ImageData { get; set; }

        public System.String ImageBase64 { get; set; }

        public System.Int32? Age { get; set; }

        public System.Guid? BpProvinceID { get; set; }

        public System.String BpProvinceName { get; set; }

        public System.Guid? BpCityID { get; set; }

        public System.String BpCityName { get; set; }

        public System.String CellPhone { get; set; }

        public System.Boolean WithoutInquiry { get; set; }

        public System.String Name { get; set; }

        public System.DateTime? ConfirmDate { get; set; }

        public System.Int32? ErrorCode { get; set; }

        public System.String BpProvinceCode { get; set; }

        public System.String BpCityCode { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class TokenInfo
    {
        public System.String Token { get; set; }

        public System.String UserName { get; set; }

        public System.String RemoteIP { get; set; }

        public System.String AppURL { get; set; }

        public System.Guid? UserId { get; set; }

        public System.Guid? ApplicationId { get; set; }

        public System.Guid? ClientId { get; set; }

        public System.Guid? DepartmentId { get; set; }

        public System.Guid? ProvinceId { get; set; }

        public System.Guid? PositionId { get; set; }

        public System.Byte UserType { get; set; }

        public System.Byte PositionType { get; set; }

        public System.Guid? PositionSubTypeID { get; set; }

        public System.Byte PositionSubType { get; set; }

        public System.Byte DepartmentType { get; set; }

        public System.String SsoTicket { get; set; }

    }
    public class IndividualCellPhone
    {
        public System.Guid IndividualID { get; set; }

        public System.String CellPhone { get; set; }

    }
    public class OnlineAction
    {
        public System.String Title { get; set; }

        public System.String Name { get; set; }

        public System.Guid? ControllerID { get; set; }

        public System.Int32 Total { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class OnlineActionListVM
    {
        public System.Guid ControllerID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class OnlineControllers
    {
        public System.String Name { get; set; }

        public System.String Title { get; set; }

        public System.Int32 Total { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class OnlineControllersListVM
    {
        public System.String Name { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationAssignment
    {
        public System.Int32? Total { get; set; }

        public System.Guid PositionID { get; set; }

        public System.Guid ApplicationID { get; set; }

        public System.Boolean UniqueRole { get; set; }

        public System.String EnumName { get; set; }

        public System.String ApplicationName { get; set; }

        public System.String ApplicationAbbreviation { get; set; }

        public System.String PositionFullName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationAssignmentListVM
    {
        public System.Guid? PositionID { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.String ApplicationName { get; set; }

        public System.String FirstName { get; set; }

        public System.String NationalCode { get; set; }

        public System.String Abbreviation { get; set; }

        public System.String LastName { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class DataBaseProblemFieldsListVM
    {
        public System.Guid? ApplicationID { get; set; }

        public System.String ApplicationName { get; set; }

        public System.String Name { get; set; }

        public System.String Code { get; set; }

        public System.Int32 Count { get; set; }

        public System.String Solution { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class DataBaseProblemFields
    {
        public System.Int32 Total { get; set; }

        public System.Guid ApplicationID { get; set; }

        public System.String ApplicationName { get; set; }

        public System.String Name { get; set; }

        public System.String Code { get; set; }

        public System.Int32 Count { get; set; }

        public System.Int32? Threshold { get; set; }

        public System.String Solution { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class MasterPassword
    {
        public System.Int32? Total { get; set; }

        public System.Guid? UserID { get; set; }

        public System.DateTime? FromDate { get; set; }

        public System.DateTime? ToDate { get; set; }

        public System.String Password { get; set; }

        public System.String PasswordString { get; set; }

        public System.Guid? CreatorUserID { get; set; }

        public System.DateTime? CreationDate { get; set; }

        public System.Guid? RemoverUserID { get; set; }

        public System.DateTime? RemoveDate { get; set; }

        public Kama.Organization.Core.Model.User User { get; set; }

        public System.Guid ID { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class MasterPasswordListVM
    {
        public System.Guid? UserID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class MasterApplication
    {
        public System.Int32? Total { get; set; }

        public System.Guid? MasterPasswordID { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.Guid? ClientID { get; set; }

        public System.Guid? RemoverUserID { get; set; }

        public System.DateTime? RemoveDate { get; set; }

        public System.String ApplicationName { get; set; }

        public System.String ClientName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class MasterApplicationListVM
    {
        public System.Guid? MasterPasswordID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class PositionTypeListVM
    {
        public System.Guid? ApplicationID { get; set; }

        public System.Byte PositionType { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class PermissionVM
    {
        public System.String Name { get; set; }

    }
    public class IssuedToken
    {
        public System.Int32 Total { get; set; }

        public System.Guid? UserID { get; set; }

        public System.Guid ClientID { get; set; }

        public System.Guid RefreshTokenID { get; set; }

        public System.DateTime IssuedDate { get; set; }

        public System.DateTime ExpireDate { get; set; }

        public System.String Token { get; set; }

        public System.Boolean Expired { get; set; }

        public System.Guid? RefrshTokenID { get; set; }

        public System.DateTime? RefrshTokenExpireDate { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class IssuedTokenListVM
    {
        public System.Guid? UserID { get; set; }

        public System.Guid? ClientID { get; set; }

        public System.Guid? RefreshTokenID { get; set; }

        public System.DateTime IssuedDate { get; set; }

        public System.DateTime ExpireDate { get; set; }

        public System.String Token { get; set; }

        public System.Boolean UndoOnlyApp { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class CheckPermissionListVM
    {
        public System.Guid CommandID { get; set; }

    }
    public class PositionEnableStateVM
    {
        public Kama.Organization.Core.Model.EnableState EnableState { get; set; }

        public System.Guid? DepartmentID { get; set; }

        public System.Guid? ApplicationID { get; set; }

    }
    public class PushWebServiceUserPermission
    {
        public System.Int32 Total { get; set; }

        public System.Guid PushWebServiceUserID { get; set; }

        public Kama.Organization.Core.Model.PushWebServiceUserPermissionType Type { get; set; }

        public System.Guid ApplicationID { get; set; }

        public System.Guid DepartmentID { get; set; }

        public System.String Url { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class PushWebServiceUserPermissionListVM
    {
        public System.Guid? PushWebServiceUserID { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.Guid? DepartmentID { get; set; }

        public Kama.Organization.Core.Model.PushWebServiceUserPermissionType Type { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class RefreshTokenListVM
    {
        public System.Guid? UserID { get; set; }

        public System.DateTime IssuedDate { get; set; }

        public System.DateTime ExpireDate { get; set; }

        public System.String ProtectedTicket { get; set; }

        public System.String SsoTicket { get; set; }

        public System.Boolean Expired { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class TextTemplate
    {
        public System.Guid ApplicationID { get; set; }

        public System.String Name { get; set; }

        public System.String Title { get; set; }

        public System.String Content { get; set; }

        public System.Int32 Code { get; set; }

        public System.Int32 Total { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class TextTemplateListVM
    {
        public System.Guid ApplicationID { get; set; }

        public System.String Name { get; set; }

        public System.String Title { get; set; }

        public System.Int32 Code { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class UserCellphoneAddVM
    {
        public System.String CellPhone { get; set; }

        public System.String NationalCode { get; set; }

    }
    public class UserCellphone
    {
        public System.Guid UserID { get; set; }

        public System.Guid IndividualID { get; set; }

        public System.Guid? RemoverUserID { get; set; }

        public System.Boolean Deleted { get; set; }

        public System.String CellPhone { get; set; }

        public System.String NationalCode { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.DateTime BirthDate { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class UserCellphoneListVM
    {
        public System.Guid UserID { get; set; }

        public System.String NationalCode { get; set; }

        public System.Boolean OnlyActive { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class RefreshTokens
    {
        public System.Int32 Total { get; set; }

        public System.Guid ID { get; set; }

        public System.Guid UserID { get; set; }

        public System.DateTime IssuedDate { get; set; }

        public System.DateTime ExpireDate { get; set; }

        public System.String ProtectedTicket { get; set; }

        public System.String SsoTicket { get; set; }

        public System.Boolean Expired { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.Int16 OS { get; set; }

        public System.String OSVersion { get; set; }

        public System.Int16 Browser { get; set; }

        public System.String BrowserVersion { get; set; }

        public System.Int16 DeviceType { get; set; }

    }
    public class SecuriyStamp
    {
        public System.String UserName { get; set; }

        public System.String Stamp { get; set; }

        public System.String CellPhone { get; set; }

    }
    public class DigitalSignature
    {
        public System.Guid ApplicationID { get; set; }

        public System.Guid AttachmentID { get; set; }

        public Kama.Organization.Core.Model.InquiryResultType ResultType { get; set; }

        public System.String ResultMessage { get; set; }

        public System.Byte[] PDFData { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class DigitalSignatureListVM
    {
        public System.Guid ApplicationID { get; set; }

        public System.Guid AttachmentID { get; set; }

        public System.Byte[] PDFData { get; set; }

        public System.String RedirectApiUrl { get; set; }

    }
    public class InquiryReports
    {
        public System.Int32 Total { get; set; }

        public System.Int64 InquiryCount { get; set; }

        public System.Int64 InquirySuccessCount { get; set; }

        public System.Int64 InquiryUnSuccessCount { get; set; }

        public System.String InquiryMaxUserName { get; set; }

        public System.String InquiryMinUserName { get; set; }

        public System.Int64 WebServiceCount { get; set; }

        public System.Int64 WebServiceEnableCount { get; set; }

        public System.Int64 WebServiceDisableCount { get; set; }

        public System.String InquiryMaxActionName { get; set; }

        public System.String InquiryMinActionName { get; set; }

        public System.String MaxOrganName { get; set; }

        public System.String MinOrganName { get; set; }

        public System.DateTime? CreationDate { get; set; }

        public System.Guid ID { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class InquiryReportsListVM
    {
        public System.Guid? WebServiceID { get; set; }

        public System.DateTime? CreationDateFrom { get; set; }

        public System.DateTime? CreationDateTo { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class WebServiceInquiryStateVM
    {
        public System.Guid WebServiceID { get; set; }

    }
    public class WebServiceForPermissionAcount
    {
        public System.Int32 Total { get; set; }

        public System.Guid ApplicationID { get; set; }

        public System.String ApplicationName { get; set; }

        public System.Boolean Enable { get; set; }

        public System.String TitlePer { get; set; }

        public System.String TitleEng { get; set; }

        public System.DateTime? LatestLocalInquiryDate { get; set; }

        public Kama.Organization.Core.Model.InquiryResultType LatestLocalInquiryResultType { get; set; }

        public System.DateTime? LatestGsbInquiryDate { get; set; }

        public Kama.Organization.Core.Model.InquiryResultType LatestGsbInquiryResultType { get; set; }

        public System.String Comment { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class WebService
    {
        public System.Int32 Total { get; set; }

        public System.Guid ApplicationID { get; set; }

        public System.Boolean Enable { get; set; }

        public System.String TitleEng { get; set; }

        public System.String TitlePer { get; set; }

        public System.String LocalUrl { get; set; }

        public System.String GsbUrl { get; set; }

        public System.String Body { get; set; }

        public System.String Comment { get; set; }

        public System.String ApplicationName { get; set; }

        public System.DateTime? LatestGsbInquiryDate { get; set; }

        public Kama.Organization.Core.Model.InquiryResultType LatestGsbInquiryResultType { get; set; }

        public System.String LatestGsbInquiryResultTypeName { get; set; }

        public System.DateTime? LatestLocalInquiryDate { get; set; }

        public Kama.Organization.Core.Model.InquiryResultType LatestLocalInquiryResultType { get; set; }

        public System.String LatestLocalInquiryResultTypeName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class WebServiceForPermissionAcountListVM
    {
        public System.Guid? ApplicationID { get; set; }

        public System.Guid? ParentOrganID { get; set; }

        public System.Guid? OrganID { get; set; }

        public Kama.Organization.Core.Model.InquiryResultType LatestLocalInquiryResultType { get; set; }

        public Kama.Organization.Core.Model.InquiryResultType LatestGsbInquiryResultType { get; set; }

        public Kama.Organization.Core.Model.EnableState EnableState { get; set; }

        public System.Guid? WebServiceID { get; set; }

        public Kama.Organization.Core.Model.WebServiceType WebServiceType { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class WebServiceListVM
    {
        public System.Guid? ApplicationID { get; set; }

        public Kama.Organization.Core.Model.EnableState EnableState { get; set; }

        public System.String TitleEng { get; set; }

        public System.String TitlePer { get; set; }

        public System.String LocalUrl { get; set; }

        public System.String GsbUrl { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class CheckWebServiceUserPermission
    {
        public System.String UserName { get; set; }

        public System.String Password { get; set; }

        public System.String WebServiceEngName { get; set; }

    }
    public class LoginVM
    {
        public Kama.Organization.Core.Model.LoginType LoginType { get; set; }

        public System.String Cellphone { get; set; }

        public System.String SecurityStamp { get; set; }

        public System.String RefreshToken { get; set; }

        public System.String Username { get; set; }

        public System.String Password { get; set; }

        public System.String TokenCaptcha { get; set; }

        public System.String Stamp { get; set; }

    }
    public class TokenErrorResult
    {
        public System.String error { get; set; }

        public System.String error_description { get; set; }

    }
    public class SmsLogin
    {
        public System.Boolean IsSms { get; set; }

        public System.Boolean Success { get; set; }

    }
    public class SendSmsVM
    {
        public System.Guid AccountID { get; set; }

        public System.String AccountTitle { get; set; }

        public Kama.Organization.Core.Model.SmsPriority Priority { get; set; }

        public System.DateTime SendDate { get; set; }

        public System.String Content { get; set; }

        public List<System.String> ReceiverNumbers { get; set; }

    }
    public class SendSmsToGroupItem
    {
        public System.Guid? OrganID { get; set; }

        public System.Boolean IncludeSubOrgans { get; set; }

        public Kama.Organization.Core.Model.OrganizationPositionType PositionType { get; set; }

    }
    public class SendSmsToGroupVM
    {
        public List<Kama.Organization.Core.Model.SendSmsToGroupItem> Items { get; set; }

        public System.String Content { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class SortExp
    {
        public System.String ColumnName { get; set; }

        public Kama.Organization.Core.Model.SortOrderType SortOrder { get; set; }

    }
    public class PasswordSettings
    {
        public System.Byte CharacterLength { get; set; }

        public System.Boolean Number { get; set; }

        public System.Boolean Upper { get; set; }

        public System.Boolean Lower { get; set; }

        public System.Boolean Special { get; set; }

    }
    public class BudgetCodeAssignment
    {
        public System.Int32 Total { get; set; }

        public System.Guid PositionSubTypeID { get; set; }

        public System.String PositionSubTypeName { get; set; }

        public System.Guid DepartmentBudgetID { get; set; }

        public System.String DepartmentBudgetName { get; set; }

        public System.Guid DepartmentID { get; set; }

        public System.String DepartmentName { get; set; }

        public System.String BudgetCode { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class BudgetCodeAssignmentListVM
    {
        public System.Guid PositionSubTypeID { get; set; }

        public System.Guid DepartmentID { get; set; }

        public System.Guid DepartmentBudgetID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class CommandByNationalCode
    {
        public System.Int32 Total { get; set; }

        public System.String Name { get; set; }

        public System.String Title { get; set; }

        public System.String FullName { get; set; }

        public System.Guid RoleID { get; set; }

        public System.String RoleName { get; set; }

        public Kama.Organization.Core.Model.PositionType PositionType { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.String NationalCode { get; set; }

        public System.String UserName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class CommandByNationalCodeListVM
    {
        public System.String NationalCode { get; set; }

        public System.Guid? RoleID { get; set; }

        public Kama.Organization.Core.Model.PositionType PositionType { get; set; }

        public System.Guid? CommandID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class DepartmentBudgetForSalary
    {
        public System.Int32 Total { get; set; }

        public System.Guid DepartmentID { get; set; }

        public System.String DepartmentName { get; set; }

        public System.String DepartmentCode { get; set; }

        public System.String Name { get; set; }

        public System.String BudgetCode { get; set; }

        public Kama.Organization.Core.Model.DepartmentBudgetType Type { get; set; }

        public System.Guid? PositionSubTypeID { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class DepartmentBudget
    {
        public System.Int32 Total { get; set; }

        public System.Guid DepartmentID { get; set; }

        public System.String DepartmentCode { get; set; }

        public System.String DepartmentName { get; set; }

        public System.String Name { get; set; }

        public System.String BudgetCode { get; set; }

        public System.String SalaryInputBudgetCode { get; set; }

        public System.Boolean Enabled { get; set; }

        public Kama.Organization.Core.Model.DepartmentBudgetType Type { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class DepartmentBudgetForSalaryListVM
    {
        public System.Guid DepartmentID { get; set; }

        public System.Guid? PositionSubTypeID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class DepartmentBudgetListVM
    {
        public System.Guid? DepartmentID { get; set; }

        public System.String DepartmentCode { get; set; }

        public Kama.Organization.Core.Model.EnableState EnableType { get; set; }

        public System.String BudgetCode { get; set; }

        public System.String Name { get; set; }

        public Kama.Organization.Core.Model.DepartmentBudgetType Type { get; set; }

        public System.String SalaryInputBudgetCode { get; set; }

        public System.Guid? ParentDepartmentID { get; set; }

        public List<System.Guid> DepartmentIDs { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class DepartmentPostImport
    {
        public System.Int32 Total { get; set; }

        public System.Guid DepartmentID { get; set; }

        public System.String DepartmentName { get; set; }

        public Kama.Organization.Core.Model.EmploymentType EmploymentType { get; set; }

        public System.Int32 LimitedNumber { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class DepartmentPostImportListVM
    {
        public System.Guid? DepartmentID { get; set; }

        public Kama.Organization.Core.Model.EmploymentType EmploymentType { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class DepartmentSummary
    {
        public System.String Name { get; set; }

        public System.String Code { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class DepartmentSummaryListVM
    {
        public System.Guid? ParentID { get; set; }

        public System.Guid? ProvinceID { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public Kama.Organization.Core.Model.DepartmentType Type { get; set; }

        public System.String NationalCode { get; set; }

        public Kama.Organization.Core.Model.DepartmentSubType SubType { get; set; }

        public Kama.Organization.Core.Model.CouncilType CouncilType { get; set; }

        public Kama.Organization.Core.Model.DepartmentShowType DepartmentShowType { get; set; }

        public Kama.Organization.Core.Model.OrganType OrganType { get; set; }

        public System.String Code { get; set; }

        public System.String BudgetCode { get; set; }

        public System.Boolean OnlyFetchedWithProvinceSubDepartments { get; set; }

        public System.Boolean GetProtectedDepartments { get; set; }

        public System.String Name { get; set; }

        public System.Boolean SearchWithHierarchy { get; set; }

        public List<System.String> Codes { get; set; }

        public List<System.String> Types { get; set; }

        public Kama.Organization.Core.Model.COFOG COFOG { get; set; }

        public System.Int32? Level { get; set; }

        public System.Boolean LoadLabel { get; set; }

        public Kama.Organization.Core.Model.EnableState Enabled { get; set; }

        public System.Guid? UnitType { get; set; }

        public Kama.Organization.Core.Model.NeedsChartType NeedsChartType { get; set; }

        public Kama.Organization.Core.Model.DepartmentWebServiceSaveType WebServiceSaveType { get; set; }

        public Kama.Organization.Core.Model.MainOrganType MainOrganType { get; set; }

        public Kama.Organization.Core.Model.ElaboratedBudgetType ElaboratedBudgetType { get; set; }

        public Kama.Organization.Core.Model.TreasurySupervisionType TreasurySupervisionType { get; set; }

        public Kama.Organization.Core.Model.UserDefinitionReferenceType UserDefinitionReferenceType { get; set; }

        public Kama.Organization.Core.Model.BoardOfTrusteesType BoardOfTrusteesType { get; set; }

        public List<Kama.Organization.Core.Model.UserDefinitionReferenceType> UserDefinitionReferenceTypes { get; set; }

        public Kama.Organization.Core.Model.ArrangementTypeInSalary ArrangementTypeInSalary { get; set; }

        public Kama.Organization.Core.Model.BriefNameType BriefNameType { get; set; }

        public System.Guid? ID { get; set; }

        public Kama.Organization.Core.Model.IsDiscludedInPaknaType IsDiscludedInPaknaType { get; set; }

        public System.Boolean NoLoadTestDepartment { get; set; }

        public List<System.Guid> EnabledApplicationIDs { get; set; }

        public List<System.Guid> EnabledApplicationIDsForWebService { get; set; }

        public List<System.Guid> EnabledApplicationIDsForReport { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class DynamicPermissionObjectsByPositionAndOrganListVM
    {
        public Kama.Organization.Core.Model.DynamicPermissionType DynamicPermissionType { get; set; }

        public System.Guid? OrganID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class DynamicPermissionObjectsByPositionListVM
    {
        public Kama.Organization.Core.Model.DynamicPermissionType DynamicPermissionType { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class IndividualForUpdateListVM
    {
        public List<Kama.Organization.Core.Model.Individual> Individuals { get; set; }

        public Kama.Organization.Core.Model.EstelamType EstelamType { get; set; }

    }
    public class IndividualPhoneNumberValidationVM
    {
        public System.String NationalCode { get; set; }

        public System.String PhoneNumber { get; set; }

        public System.String VerifyCode { get; set; }

    }
    public class IndividualInquiryListVM
    {
        public System.String NationalCode { get; set; }

        public System.DateTime? CreationDateFrom { get; set; }

        public System.DateTime? CreationDateTo { get; set; }

        public List<System.String> NationalCodes { get; set; }

        public List<System.Int32> ErrorCodes { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class NationalCodeExistence
    {
        public System.Boolean IsExists { get; set; }

    }
    public class IndividualInquiry
    {
        public System.Int32? Total { get; set; }

        public System.Guid IndividualID { get; set; }

        public System.String NationalCode { get; set; }

        public Kama.Organization.Core.Model.IndividualConfirmType ConfirmType { get; set; }

        public System.Int32 ErrorCode { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class MergeIndividualVM
    {
        public Kama.Organization.Core.Model.Individual Individual { get; set; }

        public List<Kama.Organization.Core.Model.Individual> MergedIndividuals { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class RetirementInformation
    {
        public System.Guid IndividualID { get; set; }

        public System.Boolean IsRetired { get; set; }

        public System.Boolean IsEmployed { get; set; }

        public System.Boolean IsRetiredReturnEmployed { get; set; }

        public System.DateTime? RetiredDate { get; set; }

        public System.Int32 RetiredDays { get; set; }

        public System.Int32 EmployedDays { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class OutsideSetting
    {
        public System.Int32 Total { get; set; }

        public Kama.Organization.Core.Model.ElementType ElementType { get; set; }

        public System.Boolean Show { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class OutsideSettingListVM
    {
        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class PlaceByCodeListVM
    {
        public System.String Code { get; set; }

        public Kama.Organization.Core.Model.PlaceType Type { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class PositionHistory
    {
        public System.Int32 Total { get; set; }

        public System.Guid PositionID { get; set; }

        public System.Guid UserID { get; set; }

        public System.String LetterNumber { get; set; }

        public System.DateTime? Date { get; set; }

        public System.String Comment { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.String NationalCode { get; set; }

        public System.String Username { get; set; }

        public System.String CellPhone { get; set; }

        public System.Boolean IsEndUser { get; set; }

        public System.String CreatorUserFirstName { get; set; }

        public System.String CreatorUserLastName { get; set; }

        public System.String CreatorUserNationalCode { get; set; }

        public System.String CreatorUserUsername { get; set; }

        public System.String CreatorUserCellPhone { get; set; }

        public Kama.Organization.Core.Model.PositionType CreatorPositionType { get; set; }

        public System.Guid CreatorPositionDepartmentID { get; set; }

        public System.String CreatorPositionDepartmentName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class PositionHistory<TPositionType>
    {
        public System.Int32 Total { get; set; }

        public System.Guid PositionID { get; set; }

        public System.Guid UserID { get; set; }

        public System.String LetterNumber { get; set; }

        public System.DateTime? Date { get; set; }

        public System.String Comment { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.String NationalCode { get; set; }

        public System.String Username { get; set; }

        public System.String CellPhone { get; set; }

        public System.Boolean IsEndUser { get; set; }

        public System.String CreatorUserFirstName { get; set; }

        public System.String CreatorUserLastName { get; set; }

        public System.String CreatorUserNationalCode { get; set; }

        public System.String CreatorUserUsername { get; set; }

        public System.String CreatorUserCellPhone { get; set; }

        public TPositionType CreatorPositionType { get; set; }

        public System.Guid CreatorPositionDepartmentID { get; set; }

        public System.String CreatorPositionDepartmentName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class PositionHistoryListVM
    {
        public System.Guid? PositionID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class PositionSubType
    {
        public System.Int32 Total { get; set; }

        public System.String Name { get; set; }

        public System.Guid DepartmentID { get; set; }

        public System.String DepartmentName { get; set; }

        public Kama.Organization.Core.Model.PositionUnitType Type { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class PositionSubTypeListVM
    {
        public System.String Name { get; set; }

        public System.Guid? DepartmentID { get; set; }

        public System.String DepartmentName { get; set; }

        public Kama.Organization.Core.Model.PositionUnitType Type { get; set; }

        public List<Kama.Organization.Core.Model.PositionUnitType> Types { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class DepartmentByUser
    {
        public System.Guid ID { get; set; }

        public System.String Name { get; set; }

    }
    public class DepartmentByUserListVM
    {
        public System.Guid UserID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationByUserListVM
    {
        public System.Guid UserID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationByUser
    {
        public System.Guid ID { get; set; }

        public System.String Name { get; set; }

    }
    public class ForgotPasswordVM
    {
        public System.Guid UserID { get; set; }

    }
    public class UserGridSetting
    {
        public System.String Setting { get; set; }

        public System.String Path { get; set; }

        public System.String AncillaryPath { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class WebServiceUserAction
    {
        public System.Guid UserID { get; set; }

        public System.Guid ActionID { get; set; }

        public System.String ActionTitle { get; set; }

        public System.String ActionName { get; set; }

        public System.Int32 Total { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class WebServiceUserActionListVM
    {
        public System.Guid UserID { get; set; }

        public System.Guid ActionID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class WebServiceUserPermission
    {
        public System.Int32? Total { get; set; }

        public System.Guid WebServiceID { get; set; }

        public System.String WebServiceEngName { get; set; }

        public System.String WebServicePerName { get; set; }

        public System.Guid WebServiceUserID { get; set; }

        public System.Int32? NumberPerDay { get; set; }

        public System.Int32? NumberPerMonth { get; set; }

        public System.DateTime? StartDate { get; set; }

        public System.DateTime? EndDate { get; set; }

        public System.String UseHours { get; set; }

        public System.String UserName { get; set; }

        public System.String OrganName { get; set; }

        public Kama.Organization.Core.Model.WebServiceType WebServiceType { get; set; }

        public System.Boolean WebServiceUserEnable { get; set; }

        public System.String NationalCode { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public Kama.Organization.Core.Model.PasswordStatusType PasswordStatusType { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class WebServiceUserPermissionListVM
    {
        public System.Guid? WebServiceUserID { get; set; }

        public System.Guid? WebServiceID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class DigitalSignatureMiddleResult
    {
        public System.String identifier { get; set; }

        public System.String gatewayUri { get; set; }

    }
    public class SignatureFormat
    {
        public Kama.Organization.Core.Model.SignatureRequest signatureRequest { get; set; }

    }
    public class SignatureRequest
    {
        public System.String state { get; set; }

        public System.String redirectUrl { get; set; }

        public Kama.Organization.Core.Model.SignerInfo signerInfo { get; set; }

        public Kama.Organization.Core.Model.SignatureProfile signatureProfile { get; set; }

        public Kama.Organization.Core.Model.ToBeSignDocument toBeSignDocument { get; set; }

        public Kama.Organization.Core.Model.ServiceProvider serviceProvider { get; set; }

    }
    public class SignerInfo
    {
        public Kama.Organization.Core.Model.SignerCertificate signerCertificate { get; set; }

    }
    public class SignerCertificate
    {
        public System.String certificate { get; set; }

    }
    public class SignatureProfile
    {
        public System.String name { get; set; }

    }
    public class ToBeSignDocument
    {
        public System.String name { get; set; }

        public System.String data { get; set; }

        public System.String type { get; set; }

    }
    public class ServiceProvider
    {
        public System.String clientId { get; set; }

        public System.String clientSecret { get; set; }

    }
    public class SignatureFinalResultFormat
    {
        public Kama.Organization.Core.Model.DigitalSignatureDocument document { get; set; }

    }
    public class DigitalSignatureDocument
    {
        public System.String name { get; set; }

        public System.String data { get; set; }

    }
    public class Signature
    {
        public System.String FileName { get; set; }

        public System.String RedirectUrl { get; set; }

        public System.Byte[] PDFData { get; set; }

        public System.Byte[] CertificateData { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class StatisticsListVM
    {
        public Kama.Organization.Core.Model.StatType Type { get; set; }

        public System.Guid? UserPositionID { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class Statistics
    {
        public Kama.Organization.Core.Model.StatType Type { get; set; }

        public System.Int32 Count { get; set; }

    }
    public class FileModel
    {
        public System.String FileName { get; set; }

        public System.String Comment { get; set; }

        public System.Byte[] Data { get; set; }

        public System.String Base64 { get; set; }

        public System.String UTF8 { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class ApplicationListVM
    {
        public System.String Code { get; set; }

        public System.String Name { get; set; }

        public System.String Abbreviation { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.String ClientName { get; set; }

        public System.String Comment { get; set; }

        public Kama.Organization.Core.Model.EnableState Enabled { get; set; }

        public System.Boolean? SsoState { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class Application
    {
        public System.Int32 Total { get; set; }

        public System.Guid? ClientID { get; set; }

        public System.String Code { get; set; }

        public System.String Name { get; set; }

        public System.String Comment { get; set; }

        public System.String Abbreviation { get; set; }

        public System.Boolean Enabled { get; set; }

        public System.String Icon { get; set; }

        public System.Boolean SsoState { get; set; }

        public System.Boolean UniqueRole { get; set; }

        public System.String EnumName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class GenerateCaptchaVM
    {
        public Kama.Organization.Core.Model.CaptchaType Type { get; set; }

    }
    public class CaptchaReturnVM
    {
        public System.String Base64Image { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class Client
    {
        public System.Guid ApplicationID { get; set; }

        public System.String ApplicationName { get; set; }

        public System.String ApplicationCode { get; set; }

        public System.Boolean ApplicationEnabled { get; set; }

        public System.String Name { get; set; }

        public System.String Abbreviation { get; set; }

        public System.String Secret { get; set; }

        public Kama.Organization.Core.Model.ClientType Type { get; set; }

        public System.Boolean Enabled { get; set; }

        public System.Boolean SsoState { get; set; }

        public System.Int32 RefreshTokenLifeTime { get; set; }

        public System.String AllowedOrigin { get; set; }

        public System.String Url { get; set; }

        public System.String UserID { get; set; }

        public System.String UserHash { get; set; }

        public System.String CallBack { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class Command
    {
        public System.Guid ParentID { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.String Node { get; set; }

        public System.String ParentNode { get; set; }

        public System.String Name { get; set; }

        public System.String FullName { get; set; }

        public System.String Title { get; set; }

        public System.Int32 Order { get; set; }

        public Kama.Organization.Core.Model.CommandType Type { get; set; }

        public System.String PermissionName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.String Hash { get; set; }

    }
    public class CommandListVM
    {
        public System.Guid? ParentID { get; set; }

        public System.Guid? RoleID { get; set; }

        public System.String Name { get; set; }

        public System.String Title { get; set; }

        public Kama.Organization.Core.Model.CommandType Type { get; set; }

        public System.Guid? ApplicationID { get; set; }

    }
    public class Department
    {
        public System.Int32 Total { get; set; }

        public System.Guid? ParentID { get; set; }

        public System.String Node { get; set; }

        public System.Int32 NodeLevel { get; set; }

        public System.Byte[] Timestamp { get; set; }

        public System.DateTime? ExpirationDate { get; set; }

        public System.String BudgetCode { get; set; }

        public System.String LegalNumber { get; set; }

        public System.String ParentNode { get; set; }

        public Kama.Organization.Core.Model.DepartmentType Type { get; set; }

        public Kama.Organization.Core.Model.DepartmentSubType SubType { get; set; }

        public Kama.Organization.Core.Model.CouncilType CouncilType { get; set; }

        public Kama.Organization.Core.Model.OrganType OrganType { get; set; }

        public Kama.Organization.Core.Model.ElaboratedBudgetType ElaboratedBudgetType { get; set; }

        public Kama.Organization.Core.Model.TreasurySupervisionType TreasurySupervisionType { get; set; }

        public Kama.Organization.Core.Model.UserDefinitionReferenceType UserDefinitionReferenceType { get; set; }

        public Kama.Organization.Core.Model.BoardOfTrusteesType BoardOfTrusteesType { get; set; }

        public Kama.Organization.Core.Model.ArrangementTypeInSalary ArrangementTypeInSalary { get; set; }

        public Kama.Organization.Core.Model.BriefNameType BriefNameType { get; set; }

        public Kama.Organization.Core.Model.DepartmentShowType DepartmentShowType { get; set; }

        public System.String Code { get; set; }

        public System.String Name { get; set; }

        public System.String ParentName { get; set; }

        public System.String ParentNationalCode { get; set; }

        public System.String UnitTypeName { get; set; }

        public System.String ParentCode { get; set; }

        public System.Boolean Enabled { get; set; }

        public System.Guid? ProvinceID { get; set; }

        public System.String ProvinceName { get; set; }

        public System.String Address { get; set; }

        public System.String PostalCode { get; set; }

        public Kama.Organization.Core.Model.COFOG COFOG { get; set; }

        public System.Guid? AddressID { get; set; }

        public System.Guid? UnitTypeID { get; set; }

        public System.String NationalCode { get; set; }

        public Kama.Organization.Core.Model.NeedsChartType NeedsChartType { get; set; }

        public System.Boolean EnableForPostImport { get; set; }

        public Kama.Organization.Core.Model.DepartmentWebServiceSaveType WebServiceSaveType { get; set; }

        public Kama.Organization.Core.Model.MainOrganType MainOrganType { get; set; }

        public System.String MainOrgan1Name { get; set; }

        public System.String MainOrgan1Code { get; set; }

        public System.String MainOrgan2Name { get; set; }

        public System.String MainOrgan2Code { get; set; }

        public System.DateTime? TopChartApproveDate { get; set; }

        public System.DateTime? ElaboratedChartApproveDate { get; set; }

        public System.DateTime? ProvincialChartApproveDate { get; set; }

        public System.Int32 ProvincialSubsetCount { get; set; }

        public System.Int32 ElaboratedSubsetCount { get; set; }

        public System.Int32 CurrentDepartmentProvincialSubsetCount { get; set; }

        public System.Boolean IsDiscludedInPakna { get; set; }

        public System.Int32? TreeOrder { get; set; }

        public List<Kama.Organization.Core.Model.DepartmentEnableState> DepartmentEnableStates { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class DepartmentListVM
    {
        public System.Guid? ParentID { get; set; }

        public System.Guid? ProvinceID { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public Kama.Organization.Core.Model.DepartmentType Type { get; set; }

        public System.Guid? OrganID { get; set; }

        public System.String NationalCode { get; set; }

        public Kama.Organization.Core.Model.DepartmentSubType SubType { get; set; }

        public Kama.Organization.Core.Model.CouncilType CouncilType { get; set; }

        public Kama.Organization.Core.Model.DepartmentShowType DepartmentShowType { get; set; }

        public Kama.Organization.Core.Model.OrganType OrganType { get; set; }

        public System.String Code { get; set; }

        public System.String BudgetCode { get; set; }

        public System.Boolean OnlyFetchedWithProvinceSubDepartments { get; set; }

        public System.Boolean GetProtectedDepartments { get; set; }

        public System.String Name { get; set; }

        public System.Boolean SearchWithHierarchy { get; set; }

        public List<System.String> Codes { get; set; }

        public List<System.String> Types { get; set; }

        public Kama.Organization.Core.Model.COFOG COFOG { get; set; }

        public System.Int32? Level { get; set; }

        public System.Boolean LoadLabel { get; set; }

        public System.Boolean GetKanoonDepartment { get; set; }

        public Kama.Organization.Core.Model.EnableState Enabled { get; set; }

        public System.Guid? UnitType { get; set; }

        public Kama.Organization.Core.Model.NeedsChartType NeedsChartType { get; set; }

        public Kama.Organization.Core.Model.DepartmentWebServiceSaveType WebServiceSaveType { get; set; }

        public Kama.Organization.Core.Model.MainOrganType MainOrganType { get; set; }

        public Kama.Organization.Core.Model.ElaboratedBudgetType ElaboratedBudgetType { get; set; }

        public Kama.Organization.Core.Model.TreasurySupervisionType TreasurySupervisionType { get; set; }

        public Kama.Organization.Core.Model.UserDefinitionReferenceType UserDefinitionReferenceType { get; set; }

        public Kama.Organization.Core.Model.BoardOfTrusteesType BoardOfTrusteesType { get; set; }

        public List<Kama.Organization.Core.Model.UserDefinitionReferenceType> UserDefinitionReferenceTypes { get; set; }

        public Kama.Organization.Core.Model.ArrangementTypeInSalary ArrangementTypeInSalary { get; set; }

        public Kama.Organization.Core.Model.BriefNameType BriefNameType { get; set; }

        public System.Guid? ID { get; set; }

        public Kama.Organization.Core.Model.IsDiscludedInPaknaType IsDiscludedInPaknaType { get; set; }

        public System.Boolean FetchedWithDeleted { get; set; }

        public System.Boolean NoLoadTestDepartment { get; set; }

        public System.Boolean LoadDepartmentEnableState { get; set; }

        public List<System.Guid> EnabledApplicationIDs { get; set; }

        public List<System.Guid> EnabledApplicationIDsForWebService { get; set; }

        public List<System.Guid> EnabledApplicationIDsForReport { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class DynamicPermissionListPositionsVM
    {
        public System.Guid ObjectID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class DynamicPermissionListVM
    {
        public System.Guid ObjectID { get; set; }

        public Kama.Organization.Core.Model.DynamicPermissionType DynamicPermissionType { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class DynamicPermissionDetail
    {
        public System.Guid DynamicPermissionID { get; set; }

        public Kama.Organization.Core.Model.DynamicPermissionDetailType Type { get; set; }

        public System.Guid GuidValue { get; set; }

        public System.Byte ByteValue { get; set; }

        public System.String DepartmentName { get; set; }

        public System.String ProvinceName { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class DynamicPermission
    {
        public System.Int32 Total { get; set; }

        public System.Guid ObjectID { get; set; }

        public System.Int32 Order { get; set; }

        public Kama.Organization.Core.Model.DynamicPermissionType DynamicPermissionType { get; set; }

        public List<Kama.Organization.Core.Model.Department> ParentDepartments { get; set; }

        public List<Kama.Organization.Core.Model.Department> Departments { get; set; }

        public List<Kama.Organization.Core.Model.Place> Provinces { get; set; }

        public List<Kama.Organization.Core.Model.DepartmentType> DepartmentTypes { get; set; }

        public List<Kama.Organization.Core.Model.PositionType> PositionTypes { get; set; }

        public List<Kama.Organization.Core.Model.Position> Positions { get; set; }

        public List<Kama.Organization.Core.Model.Department> EstekhdamParentDepartments { get; set; }

        public List<Kama.Organization.Core.Model.Place> EstekhdamProvinces { get; set; }

        public List<Kama.Organization.Core.Model.OrganLawType> EstekhdamOrganLawTypes { get; set; }

        public List<Kama.Organization.Core.Model.EmploymentRegulationsType> EstekhdamEmploymentRegulationsTypes { get; set; }

        public List<Kama.Organization.Core.Model.DepartmentType> EstekhdamDepartmentTypes { get; set; }

        public List<Kama.Organization.Core.Model.BudgetType> EstekhdamDepartmentBudgetTypes { get; set; }

        public List<Kama.Organization.Core.Model.RegulationType> EstekhdamDepartmentRegulationTypes { get; set; }

        public List<Kama.Organization.Core.Model.DepartmentSubType> EstekhdamDepartmentSubTypes { get; set; }

        public List<Kama.Organization.Core.Model.Department> PaknaParentDepartments { get; set; }

        public List<Kama.Organization.Core.Model.Place> PaknaProvinces { get; set; }

        public List<Kama.Organization.Core.Model.OrganLawType> PaknaOrganLawTypes { get; set; }

        public List<Kama.Organization.Core.Model.EmploymentRegulationsType> PaknaEmploymentRegulationsTypes { get; set; }

        public List<Kama.Organization.Core.Model.DepartmentType> PaknaDepartmentTypes { get; set; }

        public List<Kama.Organization.Core.Model.BudgetType> PaknaDepartmentBudgetTypes { get; set; }

        public List<Kama.Organization.Core.Model.RegulationType> PaknaDepartmentRegulationTypes { get; set; }

        public List<Kama.Organization.Core.Model.DepartmentSubType> PaknaDepartmentSubTypes { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.String Hash { get; set; }

    }
    public class Individual
    {
        public System.Int32? Total { get; set; }

        public System.String NationalCode { get; set; }

        public System.String FirstName { get; set; }

        public System.String OrganCode { get; set; }

        public System.String OrganProvinceName { get; set; }

        public System.String OrganCityName { get; set; }

        public System.String LastName { get; set; }

        public System.String FatherName { get; set; }

        public System.String BCNumber { get; set; }

        public System.String SerialCard { get; set; }

        public Kama.Organization.Core.Model.Gender Gender { get; set; }

        public System.Boolean IsDead { get; set; }

        public System.DateTime? BirthDate { get; set; }

        public System.String BirthDateJalali { get; set; }

        public Kama.Organization.Core.Model.IndividualConfirmType ConfirmType { get; set; }

        public System.Byte Isaargar { get; set; }

        public System.Byte[] ImageData { get; set; }

        public System.String ImageBase64 { get; set; }

        public System.Int32? Age { get; set; }

        public System.Guid? BpProvinceID { get; set; }

        public System.String BpProvinceName { get; set; }

        public System.Guid? BpCityID { get; set; }

        public System.String BpCityName { get; set; }

        public System.String CellPhone { get; set; }

        public System.Boolean WithoutInquiry { get; set; }

        public System.String Name { get; set; }

        public System.DateTime? ConfirmDate { get; set; }

        public System.Int32? ErrorCode { get; set; }

        public System.String BpProvinceCode { get; set; }

        public System.String BpCityCode { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class IndividualListVM
    {
        public List<System.Guid> IDs { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.String NationalCode { get; set; }

        public System.DateTime? BirthDate { get; set; }

        public System.String BirthDateJalali { get; set; }

        public Kama.Organization.Core.Model.IndividualConfirmType ConfirmType { get; set; }

        public List<System.String> NationalCodes { get; set; }

        public System.Int32 ImageInquiryType { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class Place
    {
        public System.Int32? Total { get; set; }

        public System.String Node { get; set; }

        public System.String ParentNode { get; set; }

        public Kama.Organization.Core.Model.PlaceType Type { get; set; }

        public System.String Name { get; set; }

        public System.String LatinName { get; set; }

        public System.String Code { get; set; }

        public System.Guid? ParentID { get; set; }

        public Kama.Organization.Core.Model.PlaceDevelopmentType DevelopmentType { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class PlaceListVM
    {
        public List<System.Guid> IDs { get; set; }

        public System.Guid? ParentID { get; set; }

        public Kama.Organization.Core.Model.PlaceType Type { get; set; }

        public System.Int32 AncestorLevel { get; set; }

        public System.String Name { get; set; }

        public Kama.Organization.Core.Model.PlaceDevelopmentType DevelopmentType { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class PositionDepartmentMappingListVM
    {
        public Kama.Organization.Core.Model.PositionType PositionType { get; set; }

        public Kama.Organization.Core.Model.DepartmentType DepartmentType { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class PositionDepartmentMapping
    {
        public Kama.Organization.Core.Model.PositionType PositionType { get; set; }

        public Kama.Organization.Core.Model.DepartmentType DepartmentType { get; set; }

        public System.Int32? MaxUsersCount { get; set; }

        public System.Guid CreatorUserID { get; set; }

        public System.String CreatorFirstName { get; set; }

        public System.String CreatorLastName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class GetOnlineUsersAndPositionsCountVM
    {
        public System.Int32 UsersCount { get; set; }

        public System.Int32 PositionsCount { get; set; }

    }
    public class Position
    {
        public System.Int32 Total { get; set; }

        public System.Int32 TotalWithOutSazman { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.String ApplicationName { get; set; }

        public System.String ApplicationCode { get; set; }

        public System.Guid? DepartmentID { get; set; }

        public System.String DepartmentCode { get; set; }

        public System.String DepartmentName { get; set; }

        public Kama.Organization.Core.Model.DepartmentType DepartmentType { get; set; }

        public System.Guid? UserID { get; set; }

        public System.String Username { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.String NationalCode { get; set; }

        public System.String CellPhone { get; set; }

        public System.Boolean CellPhoneVerified { get; set; }

        public System.String Email { get; set; }

        public System.Boolean EmailVerified { get; set; }

        public System.Boolean Enabled { get; set; }

        public System.Boolean UserEnabled { get; set; }

        public System.Boolean PasswordExpired { get; set; }

        public Kama.Organization.Core.Model.PositionType Type { get; set; }

        public System.String TypeName { get; set; }

        public System.Byte TypeValue { get; set; }

        public Kama.Organization.Core.Model.UserType UserType { get; set; }

        public System.Guid ParentID { get; set; }

        public System.Boolean Default { get; set; }

        public System.Boolean HasUserMoreThanOnePosition { get; set; }

        public System.Guid? ProvinceID { get; set; }

        public System.String ProvinceName { get; set; }

        public System.String Comment { get; set; }

        public System.String RoleName { get; set; }

        public List<Kama.Organization.Core.Model.Role> Roles { get; set; }

        public System.String LetterNumber { get; set; }

        public System.DateTime? LetterDate { get; set; }

        public System.String HistoryComment { get; set; }

        public Kama.Organization.Core.Model.PositionSubTypeEnum SubType { get; set; }

        public Kama.Organization.Core.Model.OnlineState OnlineState { get; set; }

        public System.Guid? PositionSubTypeID { get; set; }

        public System.String PositionSubTypeName { get; set; }

        public System.Boolean IsPublicDefinition { get; set; }

        public Kama.Organization.Core.Model.Gender Gender { get; set; }

        public Kama.Organization.Core.Model.IsDead IsDead { get; set; }

        public Kama.Organization.Core.Model.IndividualConfirmType ConfirmType { get; set; }

        public System.String ApplicationEnumName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class Position<TPositionType>
    {
        public System.Int32 Total { get; set; }

        public System.Int32 TotalWithOutSazman { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.String ApplicationName { get; set; }

        public System.String ApplicationCode { get; set; }

        public System.Guid? DepartmentID { get; set; }

        public System.String DepartmentCode { get; set; }

        public System.String DepartmentName { get; set; }

        public Kama.Organization.Core.Model.DepartmentType DepartmentType { get; set; }

        public System.Guid? UserID { get; set; }

        public System.String Username { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.String NationalCode { get; set; }

        public System.String CellPhone { get; set; }

        public System.Boolean CellPhoneVerified { get; set; }

        public System.String Email { get; set; }

        public System.Boolean EmailVerified { get; set; }

        public System.Boolean Enabled { get; set; }

        public System.Boolean UserEnabled { get; set; }

        public System.Boolean PasswordExpired { get; set; }

        public TPositionType Type { get; set; }

        public System.String TypeName { get; set; }

        public System.Byte TypeValue { get; set; }

        public Kama.Organization.Core.Model.UserType UserType { get; set; }

        public System.Guid ParentID { get; set; }

        public System.Boolean Default { get; set; }

        public System.Boolean HasUserMoreThanOnePosition { get; set; }

        public System.Guid? ProvinceID { get; set; }

        public System.String ProvinceName { get; set; }

        public System.String Comment { get; set; }

        public System.String RoleName { get; set; }

        public List<Kama.Organization.Core.Model.Role> Roles { get; set; }

        public System.String LetterNumber { get; set; }

        public System.DateTime? LetterDate { get; set; }

        public System.String HistoryComment { get; set; }

        public Kama.Organization.Core.Model.PositionSubTypeEnum SubType { get; set; }

        public Kama.Organization.Core.Model.OnlineState OnlineState { get; set; }

        public System.Guid? PositionSubTypeID { get; set; }

        public System.String PositionSubTypeName { get; set; }

        public System.Boolean IsPublicDefinition { get; set; }

        public Kama.Organization.Core.Model.Gender Gender { get; set; }

        public Kama.Organization.Core.Model.IsDead IsDead { get; set; }

        public Kama.Organization.Core.Model.IndividualConfirmType ConfirmType { get; set; }

        public System.String ApplicationEnumName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class PositionListVM
    {
        public List<System.Guid> IDs { get; set; }

        public System.Guid? ParentDepartmentID { get; set; }

        public System.Guid? DepartmentID { get; set; }

        public System.Guid? CreatorUserID { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public List<System.Guid> ApplicationIDs { get; set; }

        public Kama.Organization.Core.Model.PositionType Type { get; set; }

        public Kama.Organization.Core.Model.UserPasswordExpireState UserPasswordExpireState { get; set; }

        public Kama.Organization.Core.Model.UserCellPhoneVerifyState UserCellPhoneVerifyState { get; set; }

        public List<Kama.Organization.Core.Model.PositionType> Types { get; set; }

        public Kama.Organization.Core.Model.UserType UserType { get; set; }

        public Kama.Organization.Core.Model.HasUserMoreThanOnePosition HasUserMoreThanOnePosition { get; set; }

        public System.Guid? UserID { get; set; }

        public System.String NationalCode { get; set; }

        public System.String Name { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.String CellPhone { get; set; }

        public System.String Email { get; set; }

        public System.String DepartmentName { get; set; }

        public System.Boolean IsPublicDefinition { get; set; }

        public Kama.Organization.Core.Model.EnableState EnableState { get; set; }

        public Kama.Organization.Core.Model.OnlineState OnlineState { get; set; }

        public System.Guid? RoleID { get; set; }

        public Kama.Organization.Core.Model.PositionSubTypeEnum SubType { get; set; }

        public List<System.Guid> DepartmentIDs { get; set; }

        public System.Guid? PositionSubTypeID { get; set; }

        public System.Guid? CommandID { get; set; }

        public Kama.Organization.Core.Model.Gender Gender { get; set; }

        public Kama.Organization.Core.Model.IndividualConfirmType ConfirmType { get; set; }

        public Kama.Organization.Core.Model.IsDead IsDead { get; set; }

        public System.Boolean GetForAllApplications { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class PositionTypeModel
    {
        public System.Int32 Total { get; set; }

        public System.Guid? ParentID { get; set; }

        public System.Guid ApplicationID { get; set; }

        public System.String ApplicationName { get; set; }

        public System.Int32? MaxPositionsPerOrgan { get; set; }

        public Kama.Organization.Core.Model.PositionType PositionType { get; set; }

        public Kama.Organization.Core.Model.UserType UserType { get; set; }

        public List<Kama.Organization.Core.Model.Role> Roles { get; set; }

        public List<Kama.Organization.Core.Model.PositionDepartmentMapping> PositionDepartmentMappings { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class AnnouncementListVM
    {
        public System.String Title { get; set; }

        public Kama.Organization.Core.Model.EnableState Enable { get; set; }

        public Kama.Organization.Core.Model.AnnouncementType Type { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.Guid? ClinetID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class Announcement
    {
        public System.Int32 Total { get; set; }

        public Kama.Organization.Core.Model.AnnouncementType Type { get; set; }

        public System.String Title { get; set; }

        public System.String Content { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.String ExtendedContent { get; set; }

        public System.Boolean HasExtendedContent { get; set; }

        public System.Boolean Enable { get; set; }

        public System.DateTime? DueDate { get; set; }

        public System.DateTime ReleaseDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.Boolean AllUsers { get; set; }

        public System.Boolean AuthorizedUsers { get; set; }

        public System.Boolean UnAuthorizedUsers { get; set; }

        public System.Int32 VisitCount { get; set; }

        public System.Boolean Pinned { get; set; }

        public System.Guid AttachmentID { get; set; }

        public System.Boolean Expanded { get; set; }

        public Kama.Organization.Core.Model.AnnouncementPriorityType Priority { get; set; }

        public System.String FileName { get; set; }

        public System.String Comment { get; set; }

        public System.Byte[] Data { get; set; }

        public System.String Base64 { get; set; }

        public System.String UTF8 { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.String Hash { get; set; }

    }
    public class AnnouncementPositionType<TPositionType>
    {
        public TPositionType PositionType { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class AnnouncementPositionType
    {
        public Kama.Organization.Core.Model.PositionType PositionType { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class Attachment
    {
        public System.Guid? ParentID { get; set; }

        public Kama.Organization.Core.Model.OrganizationAttachmentType Type { get; set; }

        public System.Boolean? IsUnique { get; set; }

        public System.String FileName { get; set; }

        public System.String Comment { get; set; }

        public System.Byte[] Data { get; set; }

        public System.String Base64 { get; set; }

        public System.String UTF8 { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class ContactListVM
    {
        public System.String Title { get; set; }

        public System.String Content { get; set; }

        public System.DateTime? CreationDateFrom { get; set; }

        public System.DateTime? CreationDateTo { get; set; }

        public Kama.Organization.Core.Model.ArchivedType ArchivedType { get; set; }

        public System.String Note { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class Contact
    {
        public System.Int32 Total { get; set; }

        public System.String Email { get; set; }

        public System.String Tel { get; set; }

        public System.String Title { get; set; }

        public System.String Content { get; set; }

        public System.String Name { get; set; }

        public System.String Note { get; set; }

        public System.String NationalCode { get; set; }

        public System.Boolean Archived { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Guid ID { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class FAQ
    {
        public System.Int32 Total { get; set; }

        public System.Guid FAQGroupID { get; set; }

        public System.Guid ApplicationID { get; set; }

        public System.String Title { get; set; }

        public System.String Question { get; set; }

        public System.String Answer { get; set; }

        public System.Guid CreatorID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Guid ID { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class MessageReceiver
    {
        public System.Guid MessageID { get; set; }

        public System.Guid ReceiverUserID { get; set; }

        public System.String ReceiverUserFullName { get; set; }

        public System.Guid ReceiverPositionID { get; set; }

        public System.Byte ReceiverPositionType { get; set; }

        public System.Boolean IsRemoved { get; set; }

        public System.Boolean Seen { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class ListVM
    {
        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class RefreshToken
    {
        public System.Int32 Total { get; set; }

        public System.Guid UserID { get; set; }

        public System.DateTime IssuedDate { get; set; }

        public System.DateTime ExpireDate { get; set; }

        public System.String ProtectedTicket { get; set; }

        public System.String SsoTicket { get; set; }

        public System.Boolean Expired { get; set; }

        public Kama.Organization.Core.Model.OperatingSystemType OS { get; set; }

        public System.String OSVersion { get; set; }

        public Kama.Organization.Core.Model.BrowserType Browser { get; set; }

        public System.String BrowserVersion { get; set; }

        public Kama.Organization.Core.Model.DeviceType DeviceType { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class Captcha
    {
        public System.String Text { get; set; }

        public Kama.Organization.Core.Model.CaptchaType Type { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class Role
    {
        public System.Int32 Total { get; set; }

        public System.Guid ApplicationID { get; set; }

        public System.String Name { get; set; }

        public Kama.Organization.Core.Model.PositionType PositionType { get; set; }

        public System.String ApplicationName { get; set; }

        public List<Kama.Organization.Core.Model.Command> Permissions { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class RoleListVM
    {
        public System.String Name { get; set; }

        public Kama.Organization.Core.Model.PositionType PositionType { get; set; }

        public Kama.Organization.Core.Model.UserType UserType { get; set; }

        public System.Guid? PositionID { get; set; }

        public System.Guid? UserID { get; set; }

        public System.Guid? CommandID { get; set; }

        public System.String NationalCode { get; set; }

        public System.Boolean IsPublic { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class FAQGroupListVM
    {
        public System.String Title { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class FAQListVM
    {
        public System.Guid? faqGroupId { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class EmailSecurityStamp
    {
        public System.String Email { get; set; }

        public System.String Stamp { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class SmsSecurityStamp
    {
        public System.String CellPhone { get; set; }

        public System.String Stamp { get; set; }

        public Kama.Organization.Core.Model.SecurityStampUsageType UsageType { get; set; }

        public System.Byte UsedCount { get; set; }

        public System.String UserName { get; set; }

        public System.String Password { get; set; }

        public System.Boolean Inforce { get; set; }

        public System.Boolean Again { get; set; }

        public System.Guid? UserID { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class WebServiceUser
    {
        public System.Int32 Total { get; set; }

        public System.String UserName { get; set; }

        public System.String Password { get; set; }

        public System.Guid? OrganID { get; set; }

        public System.String OrganName { get; set; }

        public System.Boolean Enabled { get; set; }

        public System.DateTime? PasswordExpireDate { get; set; }

        public Kama.Organization.Core.Model.PasswordStatusType PasswordStatusType { get; set; }

        public System.String Comment { get; set; }

        public Kama.Organization.Core.Model.WebServiceType WebServiceType { get; set; }

        public System.String WebServiceTypeName { get; set; }

        public System.Int32 Code { get; set; }

        public System.Guid? IndividualID { get; set; }

        public System.String NationalCode { get; set; }

        public Kama.Organization.Core.Model.IndividualConfirmType IndividualConfirmType { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.String FatherName { get; set; }

        public System.String BCNumber { get; set; }

        public Kama.Organization.Core.Model.Gender Gender { get; set; }

        public System.DateTime? BirthDate { get; set; }

        public System.Guid? BpProvinceID { get; set; }

        public System.String BpProvinceName { get; set; }

        public System.Guid? BpCityID { get; set; }

        public System.String BpCityName { get; set; }

        public System.String CellPhone { get; set; }

        public System.Boolean SendSms { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class WebServiceUserListVM
    {
        public System.String UserName { get; set; }

        public System.Guid? OrganID { get; set; }

        public System.Guid? ParentOrganID { get; set; }

        public Kama.Organization.Core.Model.EnableState Enabled { get; set; }

        public Kama.Organization.Core.Model.WebServiceType WebServiceType { get; set; }

        public Kama.Organization.Core.Model.PasswordStatusType PasswordStatusType { get; set; }

        public System.String NationalCode { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class WebServiceUserGetVM
    {
        public System.String UserName { get; set; }

        public System.String Password { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class SetPasswordWithSecuriyStampVM
    {
        public System.Guid ID { get; set; }

        public System.String Username { get; set; }

        public System.String Email { get; set; }

        public System.String CellPhone { get; set; }

        public System.String SecurityStamp { get; set; }

        public System.String Password { get; set; }

        public Kama.Organization.Core.Model.SecurityStampUsageType UsageType { get; set; }

    }
    public class UserProfileVM
    {
        public System.String NationalCode { get; set; }

        public System.String Username { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.String Email { get; set; }

        public System.String CellPhone { get; set; }

    }
    public class VerifyEmailVM
    {
        public System.Guid ID { get; set; }

        public System.String Email { get; set; }

        public System.String SecurityStamp { get; set; }

    }
    public class VerifyCellPhoneVM
    {
        public System.Guid ID { get; set; }

        public System.String CellPhone { get; set; }

        public System.String SecurityStamp { get; set; }

    }
    public class SetPasswordVM
    {
        public System.String OldPassword { get; set; }

        public System.String NewPassword { get; set; }

    }
    public class GetRefreshTokenVM
    {
        public System.Guid client_id { get; set; }

        public System.String client_secret { get; set; }

        public System.String grant_type { get; set; }

        public System.String refresh_token { get; set; }

    }
    public class User
    {
        public System.String Name { get; set; }

        public System.Int32 Total { get; set; }

        public System.Boolean Enabled { get; set; }

        public System.String Username { get; set; }

        public System.String Password { get; set; }

        public System.String ApplicationName { get; set; }

        public System.DateTime? PasswordExpireDate { get; set; }

        public System.Guid? IndividualID { get; set; }

        public Kama.Organization.Core.Model.UserType Type { get; set; }

        public System.String FirstName { get; set; }

        public System.String LastName { get; set; }

        public System.String NationalCode { get; set; }

        public System.String Email { get; set; }

        public System.Boolean EmailVerified { get; set; }

        public System.String CellPhone { get; set; }

        public System.Boolean CellPhoneVerified { get; set; }

        public System.Boolean TwoStepVerification { get; set; }

        public System.String DepartmentName { get; set; }

        public System.String FatherName { get; set; }

        public System.String BCNumber { get; set; }

        public Kama.Organization.Core.Model.Gender Gender { get; set; }

        public System.Boolean IsDead { get; set; }

        public System.DateTime? BirthDate { get; set; }

        public System.Guid? CurrentPositionID { get; set; }

        public System.Byte CurrentPositionType { get; set; }

        public System.Guid? CurrentDepartmentID { get; set; }

        public System.Guid? MasterPasswordID { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class UserListVM
    {
        public System.String Name { get; set; }

        public System.String NationalCode { get; set; }

        public System.String Email { get; set; }

        public System.String CellPhone { get; set; }

        public Kama.Organization.Core.Model.EnableState EnableOrDisable { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public List<System.Guid> IDs { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class UserModifyValidation
    {
        public System.String NationalCode { get; set; }

        public System.String Username { get; set; }

        public System.String CellPhone { get; set; }

        public System.String Email { get; set; }

        public System.Boolean IsNationalCodeRepeated { get; set; }

        public System.Boolean IsUserNameRepeated { get; set; }

        public System.Boolean IsEmailRepeated { get; set; }

        public System.Boolean IsCellphoneRepeated { get; set; }

        public System.Boolean IsCellPhoneChanged { get; set; }

        public System.Boolean IsEmailChanged { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class UserPermission
    {
        public System.String Role { get; set; }

        public System.Guid CommandID { get; set; }

    }
    public class UserSetting
    {
        public System.String Setting { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class Model
    {
        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class Token
    {
        public System.Guid client_id { get; set; }

        public System.String client_secret { get; set; }

        public System.String grant_type { get; set; }

        public System.String username { get; set; }

        public System.String password { get; set; }

        public Kama.Organization.Core.Model.LoginType LoginType { get; set; }

        public System.String CellPhone { get; set; }

        public System.String Email { get; set; }

        public System.String SecurityStamp { get; set; }

    }
    public class Qr
    {
        public System.String Key { get; set; }

        public System.String Value { get; set; }

        public System.String Hash { get; set; }

        public System.String UserName { get; set; }

    }
    public class LogoutCache
    {
        public System.Boolean ControllerDescriptor { get; set; }

        public System.Boolean ActionDescriptor { get; set; }

        public System.String UserName { get; set; }

    }
    public class SsoCache
    {
        public System.Guid ID { get; set; }

        public System.Guid? MasterPassword { get; set; }

        public System.String Key { get; set; }

        public System.String SsoTicket { get; set; }

        public System.String Hash { get; set; }

        public System.String UserName { get; set; }

        public System.String UserHash { get; set; }

        public System.DateTime Date { get; set; }

        public System.DateTime ExpireDate { get; set; }

    }
    public class Sso
    {
        public Kama.Organization.Core.Model.SsoEnum Type { get; set; }

        public System.String Url { get; set; }

        public System.String Key { get; set; }

        public System.String Hash { get; set; }

        public System.String Token { get; set; }

        public System.String AppName { get; set; }

        public System.String AppAbbreviation { get; set; }

        public System.String UserID { get; set; }

        public System.String UserHash { get; set; }

        public System.String CallBack { get; set; }

        public System.Boolean SmsLogin { get; set; }

        public System.Boolean GetType { get; set; }

        public List<System.Guid> AppIDs { get; set; }

        public System.Guid? ClientID { get; set; }

        public System.String ConnectionHubId { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

    }
    public class SsoVM
    {
        public Kama.Organization.Core.Model.SsoEnum Type { get; set; }

        public System.String UserID { get; set; }

        public System.String UserHash { get; set; }

        public System.String CallBack { get; set; }

        public System.String Key { get; set; }

        public System.Guid? ApplicationID { get; set; }

        public System.Guid? ClientID { get; set; }

        public System.String ConnectionHubId { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class TimeRange
    {
        public System.Int32 StartHour { get; set; }

        public System.Int32 EndHour { get; set; }

    }
    public class DepartmentWebServiceVM
    {
        public System.Guid? ParentID { get; set; }

        public System.String Node { get; set; }

        public System.String BudgetCode { get; set; }

        public Kama.Organization.Core.Model.DepartmentType Type { get; set; }

        public System.String Code { get; set; }

        public System.String Name { get; set; }

        public System.Boolean Enabled { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class DepartmentWebServiceListVM
    {
        public System.Guid? ParentID { get; set; }

        public Kama.Organization.Core.Model.DepartmentType Type { get; set; }

        public System.String Name { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public class PushWebServiceUser
    {
        public System.Int32 Total { get; set; }

        public System.Guid ApplicationID { get; set; }

        public System.Guid DepartmentID { get; set; }

        public System.Boolean Enable { get; set; }

        public System.String Url { get; set; }

        public System.String Comment { get; set; }

        public System.String DepartmentName { get; set; }

        public System.String ApplicationName { get; set; }

        public System.Guid ID { get; set; }

        public System.DateTime CreationDate { get; set; }

        public System.Int32 Order { get; set; }

        public System.String Hash { get; set; }

    }
    public class PushWebServiceUserListVM
    {
        public System.Guid ApplicationID { get; set; }

        public System.Guid DepartmentID { get; set; }

        public System.Boolean Enable { get; set; }

        public System.String Url { get; set; }

        public System.String Comment { get; set; }

        public System.Int32? PageSize { get; set; }

        public System.Int32? PageIndex { get; set; }

        public List<Kama.Organization.Core.Model.SortExp> SortExp { get; set; }

        public System.Boolean GetTotalCount { get; set; }

        public System.String Hash { get; set; }

    }
    public enum OrganizationCommands : System.Int16
    {
        Unknown = 0,
    }
    public enum PostExitHistoryType : System.Int32
    {
        نامشخص = 0,
        به_واسطه_اینکه_وضعیت_اشتغال_حکم_فرد_از_نوع_خروج_است_از_پست_خارج_گردید = 1,
        به_واسطه_اینکه_پست_فرد_به_شخص_دیگری_داده_شده_است_از_پست_خارج_گردید = 2,
        به_واسطه_اینکه_به_فرد_پست_جدیدی_داده_شده_است_از_پست_خارج_گردید = 3,
        به_واسطه_اینکه_فرد_فاقد_حکم_می_باشد_و_شخص_دیگری_پست_را_انتخاب_کرده_است_از_پست_خارج_گردید = 4,
        به_واسطه_اینکه_اطلاعات_قراردادی_بدون_پست_بلوکه_تغییر_کرده_است_از_پست_خارج_گردید = 7,
        به_واسطه_اینکه_برای_فرد_اطلاعات_قراردادی_بدون_پست_بلوکه_ثبت_گردیده_است_از_پست_خارج_گردید = 8,
        به_واسطه_اینکه_اطلاعات_قراردادی_فرد_تغییر_کرده_است_از_پست_خارج_گردید = 9,
    }
    public enum SacrificialReviewType : System.Byte
    {
        Unknown = 0,
        مدارک_پیوست_گردد = 1,
        از_بنیاد_شهید_استعلام_گردد = 2,
    }
    public enum Gender : System.Byte
    {
        Unknown = 0,
        مرد = 1,
        زن = 2,
    }
    public enum BankConfirmType : System.Byte
    {
        Unknown = 0,
        تایید_شده_توسط_بانک_مرکزی = 1,
        در_انتظار_تایید_اطلاعات_از_بانک_مرکزی = 2,
        رد_شده_توسط_بانک_مرکزی = 3,
    }
    public enum AccountOwnerType : System.Byte
    {
        Unknown = 0,
        حقیقی_ایرانی = 1,
        حقوقی_ایرانی = 2,
        حقیقی_خارجی = 3,
        حقوقی_خارجی = 4,
    }
    public enum MarriageStatus : System.Byte
    {
        Unknown = 0,
        مجرد = 1,
        متاهل = 2,
        معیل = 3,
    }
    public enum EducationDegree : System.Byte
    {
        Unknown = 0,
        دکترا = 1,
        فوق_لیسانس = 2,
        لیسانس = 3,
        فوق_دیپلم = 4,
        دیپلم = 5,
        زیر_دیپلم = 6,
    }
    public enum Religion : System.Byte
    {
        Unknown = 0,
        اسلام = 1,
        زرتشتی = 2,
        کلیمی = 3,
        مسیحی = 4,
    }
    public enum EmploymentType : System.Byte
    {
        Unknown = 0,
        رسمی_قطعی = 1,
        رسمی_آزمایشی = 2,
        پیمانی = 3,
        کارگری_دائم = 6,
        قراردادی_کار_معین_مشخص = 10,
        قراردادی_موقت_کارگری = 11,
        مشمول_طرح_پزشکان_و_پیراپزشکان = 12,
        بازنشسته_مشمول_تبصره_یک_قانون_ممنوعیت = 13,
        سرباز_امریه = 14,
        بازنشسته_مشمول_تبصره_دو_قانون_ممنوعیت = 15,
        مشمول_طرح_عمرانی__شاغل_در_فعالیت_های_مربوط_به_طرح = 16,
        مشمول_ماده_3_قانون_بازرسی = 18,
        شرکتی_پیمانکاری__بکارگیری_شده_در_قالب_شرکت_تامین_نیروی_انسانی = 19,
        مشمول_طرح_عمرانی__شاغل_در_فعالیت_های_جاری_دستگاه = 21,
        قرارداد_حق_التدریس = 22,
        قرارداد_ساعتی____پاره_وقت = 23,
        عضو_افتخاری__شورای_حل_اختلاف = 24,
        اشکال_دیگر_بکارگیری_بجز_موارد_فوق_الذکر = 100,
    }
    public enum ContractType : System.Byte
    {
        Unknown = 0,
        قرارداد_کار_معین_قدیم = 31,
        قرارداد_کار_معین_جدید = 32,
        قرارداد_کار_معین_بند_ب_مصوبه_90_11_01 = 33,
        قرارداد_کارگری_موقت_قدیم = 41,
        قرارداد_کارگری_موقت_جدید = 42,
        قرارداد_کارگری_موقت_بند_الف_مصوبه_90_11_01 = 43,
        قرارداد_ساعتی = 51,
        شرکتی_پیمانکاری = 61,
        قرارداد_طرحی = 71,
        بازنشسته_قراردادی_ساعتی = 85,
        بازنشسته_قراردادی_تمام_وقت = 86,
    }
    public enum EmployeeType : System.Byte
    {
        نامشخص = 0,
        شهید = 1,
        جانباز_از_کار_افتاده_کلی_غیر_قادر_به_کار = 2,
        آزاده_از_کار_افتاده_کلی_غیر_قادر_به_کار = 3,
        مفقودالاثر_انقلاب_اسلامی_و_جنگ_تحمیلی = 4,
        جانبازانی_که_توانایی_انجام_کار_تمام_وقت_را_ندارند = 5,
        جانبازان_آماده_به_خدمت_صرفا_یک_بار = 6,
        جانبازان_ماموریت_آموزشی_در_صورتی_که_حفظ_پست_سازمانی_آنها_مقدور_نباشد = 7,
        رای_صادره_توسط_دیوان_عدالت_اداری = 8,
        در_راستای_اصلاح_ساختار_سازمانی_دستگاه = 9,
        سایر = 10,
    }
    public enum EmploymentStatusItemPostRequirementType : System.Int32
    {
        نامشخص = 0,
        با_پست_ارتباط_ندارد = 1,
        با_پست_ارتباط_دارد = 2,
    }
    public enum EmploymentStatusItemExitPostType : System.Int32
    {
        نامشخص = 0,
        از_پست_خارج_نشود = 1,
        از_پست_خارج_شود = 2,
    }
    public enum EmploymentStatusItemEmployeeStatus : System.Int32
    {
        نامشخص = 0,
        کارمند_نیست = 1,
        کارمند_است = 2,
    }
    public enum EmploymentBlockType : System.Byte
    {
        نامشخص = 0,
        بلوکه_برای_آزمون_استخدامی = 1,
    }
    public enum EmploymentStatusItemCountType : System.Int32
    {
        نامشخص = 0,
        عدم_شمارش = 1,
        شمارش = 2,
    }
    public enum EmploymentStatusItemType : System.Int32
    {
        نامشخص = 0,
        بلااثر = 1,
        افزایش = 2,
        کاهش = 3,
    }
    public enum EmploymentStatus : System.Byte
    {
        Unknown = 0,
        حالت_شاغل_جاری = 1,
        حالت_خدمت_نیمه_وقت__پاره_وقت = 2,
        حالت_مرخصی_بدون_حقوق = 3,
        حالت_مرخصی_استعلاجی_یا_معذوریت = 4,
        حالت_ماموریت_با_حفظ_پست_سازمانی_خروج_از_مبدا = 5,
        حالت_ماموریت_بدون_حفظ_پست_سازمانی_خروج_از_مبدا = 6,
        حالت_ماموریت_با_حفظ_پست_سازمانی_ورود_به_مقصد = 7,
        حالت_ماموریت_بدون_حفظ_پست_سازمانی_ورود_به_مقصد = 8,
        حالت_بازگشت_از_ماموریت_بدون_حفظ_پست_سازمانی__ورود = 9,
        حالت_ماموریت_آموزشی = 10,
        حالت_خدمت_نظام_وظیفه = 11,
        حالت_باز_نشستگی = 12,
        حالت_از_کار_افتادگی = 13,
        حالت_استعفا = 14,
        حالت_آماده_به_خدمت = 15,
        حالت_فوت = 16,
        حالت_تعلیق = 17,
        حالت_برکناری_از_خدمت = 18,
        حالت_انفصال_موقت = 19,
        حالت_انفصال_دائم = 20,
        حالت_غیبت_غیر_موجه = 21,
        حالت_بازخریدی_خدمت = 22,
        حالت_اخراج = 23,
        حالت_فسخ_یا_خاتمه_پیمان_____قرارداد = 24,
        حالت_خاتمه_خدمت = 25,
        حالت_انتقال = 26,
        حالت_اشتغال_مستخدمین_شهید____جانباز_از_کار_افتاده____آزاده_از_کار_افتاده____مفقودالاثر = 27,
        حالت_انتقال__ورود_به_مقصد = 28,
        حالت_ماموریت_به_بخش_غیر_دولتی = 29,
        حالت_استخدام_جدید_رسمی_یا_پیمانی____بکارگیری_جدید_قراردادی = 30,
        حالت_بازگشت_از_مرخصی_استعلاجی_یا_معذوریت = 31,
        حالت_خاتمه_ماموریت_با_حفظ_پست_سازمانی_خروج_از_مقصد = 32,
        حالت_بازگشت_از_ماموریت_با_حفظ_پست_سازمانی_ورود_به_مبدا = 33,
        حالت_خاتمه_ماموریت_بدون_حفظ_پست_سازمانی_خروج_از_مقصد = 34,
        حالت_بازگشت_از_ماموریت_از_بخش_غیر_دولتی = 35,
        حالت_بازگشت_از_ماموریت_آموزشی = 36,
        حالت_پایان_خدمت_نظام_وظیفه = 37,
        حالت_غیبت = 38,
        خاتمه_انفصال_موقت = 39,
        حالت_بکارگیری_جدید_قراردادی = 40,
        حالت_بازگشت_از_مرخصی_بدون_حقوق = 41,
        حالت_اشتغال_جانباز_از_کار_افتاده____آزاده_از_کار_افتاده_2 = 42,
        حالت_ماموریت = 43,
        انتقال_به_بخش_غیر_دولتی = 44,
    }
    public enum PensionFundType : System.Byte
    {
        Unknown = 0,
        صندوق_بازنشستگی_نیروهای_مسلح_جمهوری_اسلامی_ایران = 1,
        صندوق_بازنشستگی_آینده_ساز = 2,
        صندوق_بازنشستگی_کشوری = 3,
        صندوق_بازنشستگی_بانک_مرکزی_جمهوری_اسلامی_ایران = 4,
        _صندوق_بازنشستگی_سازمان_بنادر_و_کشتیرانی = 5,
        صندوق_بازنشستگی_سازمان_تامین_اجتماعی = 6,
        صندوق_بازنشستگی_شرکت_سهامی_بیمه_ایران = 7,
        صندوق_بازنشستگی_شرکت_سهامی_بیمه_مرکزی_ایران = 8,
        صندوق_بازنشستگی_شرکت_ملی_نفت_ایران = 9,
        صندوق_بازنشستگی_شهرداری_تهران = 10,
        صندوق_بازنشستگی_کارکنان_ذوب_آهن_ایران = 11,
        صندوق_بازنشستگی_کارکنان_صدا_و_سیمای_جمهوری_اسلامی_ایران = 12,
        صندوق_بازنشستگی_کارکنان_هواپیمایی_جمهوری_اسلامی_ایران = 13,
        صندوق_بازنشستگی_کارمندان_شرکت_ملی_مس_ایران = 14,
        صندوق_بازنشستگی_مشترک_بانک_ها = 15,
        سایر = 16,
    }
    public enum OrderType : System.Byte
    {
        Unknown = 0,
        آماده_به_خدمت = 1,
        احتساب_تجربه = 2,
        احتساب_خدمت_نظام_وظیفه = 3,
        احتساب_سوابق = 4,
        اخراج = 5,
        ارتقاء_رتبه = 6,
        ارتقاء__طبقه = 7,
        ارتقاء_گروه = 8,
        استخدام_آزمایشی = 9,
        استخدام_پیمانی = 10,
        استخدام_رسمی_آزمایشی = 11,
        استخدام_قراردادی = 12,
        استعفاء = 13,
        اشتغال_مجدد = 14,
        اصلاح = 15,
        اصلاح_تطبیق_وضع = 16,
        اصلاح_تفاوت_تطبیق = 17,
        اصلاح_رقم_تفاوت_تطبیق = 18,
        اصلاح_طبقه_شغلی = 19,
        اصلاح_فوق_العاده_ایثارگری = 20,
        اصلاح_فوق_العاده_جذب = 21,
        اصلاح_قرارداد = 22,
        اصلاح_گروه = 23,
        اصلاح_گروه_شغلی = 24,
        اصلاحیه = 25,
        اعاده_بخدمت_و_انتصاب = 26,
        اعمال_امتیاز_رزمندگی = 27,
        اعمال_حقوق_و_دستمزد = 28,
        اعمال_مدرک_تحصیلی = 29,
        افزایش_حقوق = 30,
        افزایش_حقوق_براساس_مصوبه_شورای_عالی_کار = 31,
        افزایش_سنواتی = 32,
        افزایش_سنواتی_احتساب_سوابق = 33,
        افزایش_سنواتی_بسیج = 34,
        افزایش_فوق_العاده_ایثارگری = 35,
        افزایش_فوق_العاده_جذب = 36,
        افزایش_فوق_العاده_سختی_شرایط_محیط_کار = 37,
        افزایش_فوق_العاده_شغل = 38,
        افزایش_فوق_العاده_مخصوص = 39,
        افزایش_کمک_هزینه_اقلام_مصرفی = 40,
        افزایش_کمک_هزینه_اولاد = 41,
        انتصاب = 42,
        انتصاب_تعیین_حقوق_و_مزایا = 43,
        انتقال = 44,
        انتقال_و_انتصاب = 45,
        انفصال_دائم_از_خدمات_دولتی = 46,
        انفصال_موقت = 47,
        بازخرید_خدمت = 48,
        بازنشستگی = 49,
        برقراری_فوق_العاده_سختی_شرایط_محیط_کار = 50,
        برقراری_فوق_العاده_ویژه = 51,
        برقراری_فوق_العاده_ویژه_و_ارتقاء_رتبه = 52,
        برقراری_فوق_العاده_ایثارگری = 53,
        برقراری_فوق_العاده_ایثارگری_ماده51 = 54,
        برقراری_فوق_العاده_جذب = 55,
        برقراری_فوق_العاده_شغل = 56,
        برقراری_فوق_العاده_محرومیت_از_مطب = 57,
        برقراری_فوق_العاده_مخصوص = 58,
        برقراری_کمک_هزینه_اولاد = 59,
        برقراری_کمک_هزینه_عائله_مندی = 60,
        برقراری_کمک_هزینه_عائله_مندی_و_اولاد = 61,
        برکناری_از_خدمت = 62,
        پایان_قرارداد = 63,
        پایان_ماموریت = 64,
        تبدیل_وضع = 65,
        ترفیع_پایه = 66,
        تطبیق_با_قانون_مدیریت_خدمات_کشوری = 67,
        تطبیق_وضع = 68,
        تعلیق = 69,
        تعیین_حقوق_و_فوق_العاده_شغل = 70,
        تعیین_حقوق_و_مزایا = 71,
        تعیین_حقوق_و_مزایا_تغییر_ضریب = 72,
        تعیین_ردیف_و_پایه = 73,
        تغییر_حقوق_و_مزایا = 74,
        تغییر_ردیف = 75,
        تغییر_رشته_شغلی = 76,
        تغییر_شماره_پست = 77,
        تغییر_صندوق_بازنشستگی = 78,
        تغییر_ضریب = 79,
        تغییر_عنوان_شغل = 80,
        تغییر_محل_جغرافیایی_خدمت = 81,
        تغییر_محل_خدمت = 82,
        تقلیل_کمک_هزینه_اولاد = 83,
        تمدید_خدمت_رسمی_آزمایشی = 84,
        تمدید_قرارداد = 85,
        تمدید_ماموریت = 86,
        تنزل_گروه = 87,
        توقف_عملیات_اجرایی_از_تصمیم_بازنشستگی = 88,
        توقف_عملیات_اجرایی_و_اعمال_امتیاز_رزمندگی = 89,
        حذف_فوق_العاده_مخصوص = 90,
        حکم_سوری = 91,
        خاتمه_ماموریت = 92,
        خدمت_تمام_وقت = 93,
        خدمت_سه_چهارم_وقت = 94,
        خدمت_نیمه_وقت = 95,
        رسمی_قطعی = 96,
        ضریب_حقوق_و_افزایش_سنواتی = 97,
        طبقه_شغلی_تشویقی = 98,
        غیبت_موجه = 99,
        فوق_العاده_ویژه_کارشناس_ارشد = 100,
        فوق_العاده_ویژه_کارشناس_خبره = 101,
        فوق_العاده_ویژه_کارشناس_عالی = 102,
        قطع_تفاوت_تطبیق = 103,
        قطع_فوق_العاده_سختی_شرایط_محیط_کار = 104,
        قطع_فوق_العاده_محرومیت_از_مطب = 105,
        قطع_فوق_العاده_ویژه = 106,
        قطع_کمک_هزینه_اولاد = 107,
        قطع_کمک_هزینه_عائله_مندی = 108,
        گروه_ارفاقی = 109,
        گروه_تشویقی = 110,
        لغو_حکم = 111,
        لغو_طبقه_تشویقی = 112,
        لغو_قرارداد = 113,
        لغو_ماموریت_آموزشی = 114,
        ماموریت_آموزشی_پاره_وقت = 115,
        _ماموریت_آموزشی_تمام_وقت = 116,
        ماموریت_با_حفظ_پست_سازمانی = 117,
        ماموریت_بدون_حفظ_پست_سازمانی = 118,
        مرخصی_استعلاجی = 119,
        مرخصی_بدون_حقوق = 120,
        مرخصی_زایمان = 121,
        مرخصی_صعب_العلاج = 122,
        همترازی = 123,
        کاهش_افزایش_سنواتی = 124,
        کاهش_امتیاز_ایثارگری = 125,
        کاهش_طبقه_تشویقی = 126,
        کاهش_فوق_العاده_جذب = 127,
        کاهش_فوق_العاده_شغل = 128,
        کسر_حقوق_طبق_ماده_5_آیین_نامه_حضور_و_غیاب = 129,
        کسر_یک_چهارم_حقوق = 130,
        کسر_یک_سوم_حقوق = 131,
        کسر_یک_ششم_حقوق = 132,
        افزایش_امتیازات_فصل_دهم_قانون_مدیریت_خدمات_کشوری = 133,
        فوت = 134,
        سایر = 255,
    }
    public enum SacrificialType : System.Byte
    {
        Unknown = 0,
        اسیر = 1,
        فرزند_اسیر = 2,
        پدر_اسیر = 3,
        برادر_اسیر = 4,
        همسر_اسیر = 5,
        آزاده = 11,
        فرزند_آزاده = 12,
        همسر_آزاده = 13,
        جانباز_25_درصد_و_بالاتر = 21,
        فرزند_جانباز_25_درصد_و_بالاتر = 22,
        همسر_جانباز_25_درصد_و_بالاتر = 23,
        مفقود = 31,
        فرزند_مفقود = 32,
        پدر_مفقود = 33,
        برادر_مفقود = 34,
        همسر_مفقود = 35,
        شهید = 41,
        فرزند_شهید = 42,
        پدر_شهید = 43,
        بستگان_شهید = 44,
        برادر_شهید = 45,
        همسر_شهید = 46,
        خواهر_شهید = 47,
        رزمنده = 50,
        مادر_اسیر = 51,
        خواهر_اسیر = 52,
        خواهر_مفقود = 53,
        مادر_مفقود = 54,
        مادر_شهید = 55,
        فرزند_رزمنده = 56,
        همسر_رزمنده = 57,
        جانباز_زیر_25_درصد = 58,
        فرزند_جانباز_زیر_25_درصد = 59,
        همسر_جانباز_زیر_25_درصد = 60,
        فاقد_ایثارگری = 99,
    }
    public enum SacrificeStatus : System.Byte
    {
        Unknown = 0,
        ایثارگر_نیست = 1,
        ایثارگر_است = 2,
    }
    public enum VaccineStatus : System.Byte
    {
        Unknown = 0,
        واکسن_دریافت_نکرده_است = 1,
        واکسن_دریافت_کرده_است = 2,
    }
    public enum JobRank : System.Byte
    {
        Unknown = 0,
        مقدماتی__قانون_مدیریت_خدمات_کشوری = 1,
        پایه__قانون_مدیریت_خدمات_کشوری = 2,
        ارشد__قانون_مدیریت_خدمات_کشوری = 3,
        خبره__قانون_مدیریت_خدمات_کشوری = 4,
        عالی__قانون_مدیریت_خدمات_کشوری = 5,
        مربی_آموزشیار__عضو_هیات_علمی = 6,
        مربی_آموزشی__عضو_هیات_علمی = 7,
        استادیار_آموزشی__عضو_هیات_علمی = 8,
        دانشیار_آموزشی__عضو_هیات_علمی = 9,
        استاد_آموزشی__عضو_هیات_علمی = 10,
        مربی_پژوهشیار__عضو_هیات_علمی = 11,
        مربی_پژوهشی__عضو_هیات_علمی = 12,
        استادیار_پژوهشی__عضو_هیات_علمی = 13,
        دانشیار_پژوهشی__عضو_هیات_علمی = 14,
        استاد_پژوهشی__عضو_هیات_علمی = 15,
        مقدماتی_غیر_اعضای_هیات_علمی = 16,
        مهارتی_غیر_اعضای_هیات_علمی = 17,
        رتبه1_غیر_اعضای_هیات_علمی = 18,
        رتبه2_غیر_اعضای_هیات_علمی = 19,
        رتبه3_غیر_اعضای_هیات_علمی = 20,
        سایر = 255,
    }
    public enum JobPublicityType : System.Byte
    {
        Unknown = 0,
        عمومی = 1,
        اختصاصی = 2,
    }
    public enum IndividualConfirmType : System.Byte
    {
        Unknown = 0,
        تایید_شده_توسط_ثبت_احوال = 1,
        در_انتظار_تایید_اطلاعات_از_ثبت_احوال_کشور = 2,
        رد_شده_توسط_ثبت_احوال = 3,
    }
    public enum FinancialLawAuthoritiesType : System.Byte
    {
        نامشخص = 0,
        بند_یکم_ماده_سه = 1,
        بند_دوم_ماده_سه = 2,
        بند_سوم_ماده_سه = 3,
        بند_چهارم_ماده_سه = 4,
        بند_پنجم_ماده_سه = 5,
        بند_ششم_ماده_سه = 6,
        بند_هفتم_ماده_سه = 7,
        بند_هشتم_ماده_سه = 8,
        بند_نهم_ماده_سه = 9,
        بند_دهم_ماده_سه = 10,
        بند_یازدهم_ماده_سه = 11,
        بند_دوازدهم_ماده_سه = 12,
        بند_سیزدهم_ماده_سه = 13,
        بند_چهاردهم_ماده_سه = 14,
        بند_پانزدهم_ماده_سه = 15,
        بند_شانزدهم_ماده_سه = 16,
        بند_هفدهم_ماده_سه = 17,
        بند_هجدهم_ماده_سه = 18,
        بند_نوزدهم_ماده_سه = 19,
        بند_بیستم_ماده_سه = 20,
        بند_بیست_و_یکم_ماده_سه = 21,
        بند_بیست_و_دوم_ماده_سه = 22,
        بند_بیست_و_سوم_ماده_سه = 23,
        بند_بیست_و_چهارم_ماده_سه = 24,
        اصل_صد_و_چهل_و_دو_قانون_اساسی = 25,
        تبصره_یک_ماده_سه = 26,
        تبصره_دو_ماده_سه = 27,
    }
    public enum PostTypeCategory : System.Byte
    {
        نامشخص = 0,
        مدیریتی = 1,
        سرپرستی = 2,
        کارشناسی = 3,
        غیر_کارشناسی = 4,
    }
    public enum PostTypePositionType : System.Int32
    {
        نامشخص = 0,
        سمت_____های_تک_ستاره_مخصوص_هیئت_علمی = 1,
        سمت_____های_دو_ستاره_مخصوص_هیئت_علمی_و_غیر_هیئت_علمی = 2,
        سمت_____های_قضایی = 3,
    }
    public enum PostTypeManagementType : System.Int32
    {
        نامشخص = 0,
        مدیر_ارشد = 1,
        مدیر_میانی = 2,
        مدیر_پایه = 3,
        مدیر_سیاسی = 4,
        مدیر_ارشد_عملیاتی = 5,
        مدیر_میانی_عملیاتی = 6,
        مدیر_پایه_عملیاتی = 7,
    }
    public enum PostCategory : System.Byte
    {
        نامشخص = 0,
        پست_سازمانی = 1,
        قراردادی_کار_معین_مشخص = 2,
        کادر_آموزشی = 3,
        قراردادی_کارگری_دائم = 4,
        قراردادی_کارگری_موقت = 5,
    }
    public enum SmsPriority : System.Byte
    {
        Unknown = 0,
        Normal = 1,
        Medium = 2,
        High = 4,
        VeryHigh = 8,
    }
    public enum SortOrderType : System.Byte
    {
        ASC = 0,
        DESC = 1,
    }
    public enum CaptchaType : System.Int32
    {
        Login = 1,
        ForgotPassword = 2,
        UserRegister = 3,
    }
    public enum EmployeeInfoForSalaryPaymentType : System.Byte
    {
        نامشخص = 0,
        در_انتظار_پردازش = 1,
        در_حال_پردازش = 2,
        پردازش_با_موفقیت_انجام_شد = 3,
        پردازش_اطلاعات_با_خطا_مواجه_گردید = 4,
    }
    public enum Direction : System.Int16
    {
        Unknown = 0,
        Up = 1,
        Down = 2,
    }
    public enum IsDiscludedInPaknaType : System.Byte
    {
        نامشخص = 0,
        مشمول_در_پاکنا = 1,
        غیر_مشمول_در_پاکنا = 2,
    }
    public enum PushWebServiceUserPermissionType : System.Byte
    {
        نامشخص = 0,
        عملیات_تغییر_پست_____ها = 1,
        عملیات_تغییر_واحد_____ها = 2,
        عملیات_تغییر_نیروی_انسانی = 3,
    }
    public enum ActivityLogCallType : System.Byte
    {
        unknown = 0,
        UI = 1,
        WebService = 2,
    }
    public enum AttachmentLoadDataType : System.Byte
    {
        Unknown = 0,
        ByteArray = 1,
        Base64 = 2,
        UTF8 = 3,
    }
    public enum ProcessingStatus : System.Byte
    {
        نامشخص = 0,
        درانتظار_پردازش = 1,
        در_حال_پردازش = 2,
        خطا_در_پردازش = 3,
        اتمام_پردازش = 4,
    }
    public enum ContractLicenceType : System.Byte
    {
        Unknown = 0,
        ساعتی = 1,
        کارگری = 2,
        معین_مشخص = 3,
        بازنشسته_قراردادی = 4,
    }
    public enum WebserviceInquiryType : System.Byte
    {
        نا_مشخص = 0,
        واکسن = 1,
        مدارک_تحصیلی = 2,
        کد_پستی = 3,
        تصویر_کارت_ملی = 4,
        بیمه_تامین_اجتماعی = 5,
        بازنشستگی = 6,
        ایثارگری = 7,
    }
    public enum DepartmentShowType : System.Byte
    {
        Unknown = 0,
        دستگاه = 1,
        دستگاه_و_زیر_مجموعه_استانی = 2,
        دستگاه_و_زیر_مجموعه_استانی_و_ستادی = 3,
        دستگاه_و_تمامی_زیر_مجموعه_____ها = 4,
    }
    public enum RasmiLicenceType : System.Byte
    {
        Unknown = 0,
        ستادی = 1,
        استانی = 2,
    }
    public enum WithNameType : System.Byte
    {
        غیر_بانام = 0,
        پست_سازمانی_حالت_اشتغال_ستاره_____دار_برای_مستخدم_شهید = 1,
        پست_سازمانی_حالت_اشتغال_ستاره_____دار_برای_مستخدم_جانباز_از_کار_افتاده_کلی = 2,
        پست_سازمانی_حالت_اشتغال_ستاره_____دار_برای_مستخدم_آزاده_از_کار_افتاده_غیر_قادر_به_کار = 3,
        پست_سازمانی_حالت_اشتغال_ستاره_____دار_برای_مستخدم_مفقودالاثر = 4,
        پست_سازمانی_همتراز_برای_مستخدم_جانبازی_که_توانایی_کار_تمام_وقت_را_ندارد = 5,
        پست_سازمانی_همتراز_برای_جانبازان_اعاده_به_خدمت_صرفا_یک_____بار = 6,
        پست_سازمانی_همتراز_برای_ماموریت_آموزشی = 7,
        پست_سازمانی_بانام_برای_مشمولین_رای_دیوان_عدالت_اداری = 8,
        پست_سازمانی_بانام_برای_مشمولین_رای_کمیسیون_ماده_16 = 9,
        پست_سازمانی_بانام_در_راستای_اصلاح_ساختار_سازمانی_داخل_مجموعه = 10,
        پست_سازمانی_بانام_در_راستای_اصلاح_ساختار_سازمانی_انتهای_مجموعه = 11,
        پست_سازمانی_بانام_برای_جانبازانی_که_برای_اولین_بار_استخدام_می_____شوند = 12,
        پست_سازمانی_بانام_برای_کارکنان_مامور_به_دفتر_مقام_معظم_رهبری = 13,
        پست_سازمانی_بانام_برای_تبدیل_وضعیت_جانبازان_غیر_رسمی_به_رسمی = 14,
        مشمولان_تبصره_یک_بند_ذ_ماده_۸۷_قانون_برنامه_ششم_توسعه = 15,
        دستیاران_ستادی_موضوع_مصوبه_شماره_۴۸۸۹۲_مورخ_ششم_تیرماه_1394_شورای_عالی_اداری = 16,
    }
    public enum PasswordStatusType : System.Byte
    {
        نامشخص = 0,
        فاقد_اعتبار = 1,
        دارای_اعتبار = 2,
    }
    public enum UserPasswordExpireState : System.Byte
    {
        نامشخص = 0,
        منقضی_نشده_است = 1,
        منقضی_شده_است = 2,
    }
    public enum UserCellPhoneVerifyState : System.Byte
    {
        نامشخص = 0,
        تایید_نشده_است = 1,
        تایید_شده_است = 2,
    }
    public enum WebServiceType : System.Byte
    {
        Unknown = 0,
        GSB = 1,
        PGSB = 2,
    }
    public enum ModuleFinalizeType : System.Byte
    {
        Unknown = 0,
        پرسشنامه_نهایی_نگردیده_است = 1,
        پرسشنامه_نهایی_گردیده_است = 2,
    }
    public enum AgeAvgType : System.Byte
    {
        Unknown = 0,
        زیر_بیست_سال = 1,
        بیست_و_یک_تا_سی_سال = 2,
        سی_و_یک_تا_چهل_سال = 3,
        چهل_و_یک_تا_پنجاه_سال = 4,
        پنجاه_و_یک_تا_شصت_سال = 5,
        بیشتر_از_شصت_سال = 6,
    }
    public enum WorkExperienceYearsAvgType : System.Byte
    {
        Unknown = 0,
        یک_تا_پنج_سال = 1,
        شش_تا_ده_سال = 2,
        یازده_تا_پانزده_سال = 3,
        شانزده_تا_بیست_سال = 4,
        بیست_و_یک_تا_بیست_و_پنج_سال = 5,
        بیست_و_شش_تا_سی_سال = 6,
        بیشتر_از_سی_سال = 7,
    }
    public enum TreasuryRequestType : System.Byte
    {
        نامشخص = 0,
        ستادی = 1,
        واحدهای_استانی_متمرکز = 2,
        واحدهای_استانی_منفرد = 3,
        ستاد_و_واحدهای_استانی = 4,
    }
    public enum HasUserMoreThanOnePosition : System.Byte
    {
        نامشخص = 0,
        بیش_از_یک_جایگاه_ندارد = 1,
        بیش_از_یک_جایگاه_دارد = 2,
    }
    public enum Year : System.Int16
    {
        Unknown = 0,
        _1397 = 1397,
        _1398 = 1398,
        _1399 = 1399,
        _1400 = 1400,
        _1401 = 1401,
        _1402 = 1402,
    }
    public enum Month : System.Byte
    {
        Unknown = 0,
        فروردین = 1,
        اردیبهشت = 2,
        خرداد = 3,
        تیر = 4,
        مرداد = 5,
        شهریور = 6,
        مهر = 7,
        آبان = 8,
        آذر = 9,
        دی = 10,
        بهمن = 11,
        اسفند = 12,
    }
    public enum PaymentListType : System.Byte
    {
        unknown = 0,
        لیست_حقوق_جاری = 1,
        لیست_حقوق_معوقه = 2,
    }
    public enum ExceptionEmployeeInfoForT20Type : System.Byte
    {
        unknown = 0,
        حالت_ماموریت = 1,
        دریافت_حقوق_فرد_وابسته = 2,
        سایر = 50,
    }
    public enum ModuleType : System.Byte
    {
        unknown = 0,
        ویندوز = 1,
        تحت_وب = 2,
    }
    public enum FileType : System.Byte
    {
        ناشناس = 0,
        تصویر = 1,
        ویدیو = 2,
    }
    public enum ModuleScoreType : System.Byte
    {
        unknown = 0,
        کاملا_ناراضی = 1,
        ناراضی = 2,
        رضایت_نسبی = 3,
        راضی = 4,
        کاملا_راضی = 5,
    }
    public enum DepartmentBudgetType : System.Byte
    {
        Unknown = 0,
        ردیف_بودجه_اصلی = 1,
        ردیف_بودجه_فرعی_فعالیتی = 2,
        ردیف_بودجه_فرعی = 3,
    }
    public enum SecurityStampUsageType : System.Byte
    {
        Unknown = 0,
        Login = 1,
        ForgotPassword = 2,
        ForgotPasswordStepTwo = 3,
    }
    public enum PaymentType : System.Byte
    {
        Unknown = 0,
        حکم_و_غیر_حکم_در_مبدا = 1,
        حکم_در_مبدا_و_غیر_حکم_در_مقصد = 2,
        حکم_و_غیر_حکم_در_مقصد = 4,
        حکم_در_مقصد_و_غیر_حکم_در_مبداء = 5,
        حکم_در_مبداء_و_غیر_حکم_در_مبداء_و_مقصد = 6,
        حکم_در_مقصد_و_غیر_حکم_در_مبداء_و_مقصد = 7,
    }
    public enum AgentType : System.Byte
    {
        Unknown = 0,
        مامور_عادی = 1,
        مامور_پاره_وقت = 2,
    }
    public enum MissionType : System.Byte
    {
        Unknown = 0,
        بدون_حفظ_پست_سازمانی = 1,
        با_حفظ_پست_سازمانی = 2,
    }
    public enum MissionRequestPaknaType : System.Byte
    {
        Unknown = 0,
        حکم_فرد_در_سامانه_بارگذاری_گردیده_است = 1,
        مغایرت_در_حکم_پاکنا = 2,
        قابل_بررسی_نمی_باشد = 3,
    }
    public enum PlaceDevelopmentType : System.Byte
    {
        Unknown = 0,
        سایر_مناطق = 1,
        مناطق_کمتر_توسعه_یافته = 2,
    }
    public enum CreationTicketType : System.Byte
    {
        Unknown = 0,
        کال_سنتر = 1,
        کاربر = 2,
    }
    public enum NumberOfReceivedDoseType : System.Byte
    {
        Unknown = 0,
        دوز_اول = 1,
        دوز_دوم = 2,
        دوز_سوم = 3,
        دوز_چهارم = 4,
        دوز_پنجم = 5,
        بدون_دوز = 20,
        در_انتظار_استعلام = 30,
    }
    public enum PositionUnitType : System.Byte
    {
        Unknown = 0,
        واحد_دارای_ذیحساب_مستقل = 1,
        امور_بخشی = 2,
        امور_تلفیق = 3,
    }
    public enum MainOrganType : System.Byte
    {
        Unknown = 0,
        سایر = 1,
        دستگاه_اصلی = 2,
    }
    public enum InsuranceStatusType : System.Byte
    {
        Unknown = 0,
        بیمه_درمان_تامین_اجتماعی = 1,
        بیمه_خدمات_درمانی = 2,
        سایر = 10,
    }
    public enum DepartmentWebServiceSaveType : System.Byte
    {
        Unknown = 0,
        امکان_ثبت_درخواست_از_طریق_وب_سرویس_توسط_دستگاه_های_والد_وجود_داشته_باشد = 1,
    }
    public enum SabnaPositionType : System.Byte
    {
        Unknown = 0,
        کارشناس_دستگاه_اجرایی = 20,
        بالاترین_مقام_منابع_انسانی_دستگاه_اجرایی = 30,
        بالاترین_مقام_دستگاه_اجرایی = 55,
        کارشناس_امور_جذب___بکارگیری_و_رشد = 60,
        رئیس_گروه_جذب___بکارگیری_و_رشد = 61,
        معاون_امور_جذب___بکارگیری_و_رشد = 62,
        رئیس_امور_جذب___بکارگیری_و_رشد = 63,
        معاون_سرمایه_انسانی_سازمان = 64,
        رئیس_سازمان = 65,
        نظارتی = 81,
        راهبر_ارشد = 100,
        راهبر = 101,
    }
    public enum CouncilPositionType : System.Byte
    {
        Unknown = 0,
        کارشناس_دستگاه_اجرایی = 10,
        کارشناس_دبیرخانه = 50,
        مدیر_دبیرخانه = 60,
        راهبر = 100,
    }
    public enum AmoozeshPositionType : System.Byte
    {
        Unknown = 0,
        کارشناس_دستگاه_اجرایی = 20,
        مدیر_امور_اداری____نوسازی = 30,
        بالاترین_مقام_دستگاه_اجرایی = 55,
        کارشناس_امور = 60,
        معاون_امور = 61,
        رئیس_امور = 62,
        معاون_سرمایه_انسانی_سازمان = 63,
        رئیس_سازمان = 64,
        نظارتی = 81,
        راهبر = 100,
    }
    public enum SinaPositionType : System.Byte
    {
        Unknown = 0,
        راهبر = 100,
    }
    public enum BinaPositionType : System.Byte
    {
        Unknown = 0,
        بازرس = 30,
        راهبر = 100,
    }
    public enum ReportingPositionType : System.Byte
    {
        Unknown = 0,
        کارشناس_دستگاه_اجرایی = 20,
        مدیر_امور_اداری____نوسازی = 30,
        بالاترین_مقام_دستگاه_اجرایی = 55,
        کارشناس_امور = 60,
        معاون_امور = 61,
        رئیس_امور = 62,
        معاون_سرمایه_انسانی_سازمان = 63,
        رئیس_سازمان = 64,
        نظارتی = 81,
        پاسخ_دهنده_تیکت = 82,
        راهبر = 100,
        رابط_تعریف_کننده_کاربران = 180,
    }
    public enum PositionSubTypeEnum : System.Byte
    {
        Unknown = 0,
        رده_یک = 1,
        رده_دو = 2,
    }
    public enum RegulationType : System.Byte
    {
        Unknown = 0,
        مشمول_قانون_مدیریت_خدمات_کشوری = 1,
        مشمول_قانون_اداری_و_استخدامی_سابق = 2,
        مشمول_قانون_نظام_هماهنگ_پرداخت = 3,
        مشمول_قوانین_و_مقررات_خاص = 4,
        مشمول_ماده_1_قانون_احکام_دائمی_برنامه_های_توسعه_کشور = 5,
        قوانین_و_مقررات_مربوط_به_قوه_قضاییه = 7,
        قوانین_و_مقررات_شرکت_های_دولتی = 8,
        قانون_استخدام_کشوری = 9,
        نهاد_عمومی_غیر_دولتی = 10,
        مشمول_قانون_کار = 11,
        قانون_رفع_موانع_تولید_رقابت_پذیر = 12,
    }
    public enum BudgetType : System.Byte
    {
        Unknown = 0,
        ملی = 1,
        استانی = 2,
        غیر_بودجه_ای = 3,
        شرکت_های_دولتی = 4,
    }
    public enum ElaboratedBudgetType : System.Byte
    {
        نامشخص = 0,
        ملی = 1,
        استانی = 2,
    }
    public enum TreasurySupervisionType : System.Byte
    {
        نامشخص = 0,
        هردو_ناظر = 1,
        سازمان_برنامه_ناظر_خزانه_غیرناظر = 2,
        هردو_غیر_ناظر = 3,
    }
    public enum UserDefinitionReferenceType : System.Byte
    {
        نامشخص = 0,
        سازمان_مدیریت_استان = 1,
        ستاد_دستگاه_مادر = 2,
        هردو = 3,
        فقط_رابط_تعریف_کننده_کاربران = 4,
    }
    public enum BoardOfTrusteesType : System.Byte
    {
        نامشخص = 0,
        هیئت_امنایی_است = 1,
    }
    public enum DynamicPermissionType : System.Byte
    {
        Unknown = 0,
        Organization_app__Announcement = 1,
        Pakna_pbl__Process = 31,
        Pakna_rpt__DynamicReportTemplate = 32,
        Pakna_rpt__DynamicReport = 33,
        Pakna_rpt__AffierForDepartment = 34,
        Estekhdam_shr__Share = 61,
        Estekhdam_rpt__DynamicReportTemplate = 62,
        Estekhdam_rpt__DynamicReport = 63,
        Estekhdam_rpt__OccasionalReport = 64,
        Estekhdam_shr__ExceptionDepartment = 65,
        Sakhtar_pbl__Process = 91,
        Sakhtar_rpt__DynamicReportTemplate = 92,
        Sakhtar_rpt__DynamicReport = 93,
        Salary_pbl__Process = 121,
        Salary_rpt__DynamicReportTemplate = 122,
        Salary_rpt__DynamicReport = 123,
        Salary_Tow_pbl__Process = 135,
        Salary_Tow_rpt__DynamicReportTemplate = 136,
        Salary_Tow_rpt__DynamicReport = 137,
        Amoozesh_pbl__Process = 151,
        Amoozesh_rpt__DynamicReportTemplate = 152,
        Amoozesh_rpt__DynamicReport = 153,
        Licence_pbl__Process = 181,
        Licence_rpt__DynamicReportTemplate = 182,
        Licence_rpt__DynamicReport = 183,
        Job_shr__Share = 201,
        Job_rpt__DynamicReportTemplate = 202,
        Job_rpt__DynamicReport = 203,
        Kanoon_rpt__DynamicReportEvaluator = 220,
        Kanoon_rpt__DynamicReportTemplate = 221,
        Kanoon_rpt__DynamicReport = 222,
        Reporting_pbl__Process = 231,
        Reporting_rpt__DynamicReportTemplate = 232,
        Reporting_rpt__DynamicReport = 233,
        Reporting_rpt__OccasionalReport = 234,
    }
    public enum ControllerType : System.Byte
    {
        نا_مشخص = 0,
        کنترلر_عادی = 1,
        کنترلر_وب_سرویس = 2,
    }
    public enum EstelamType : System.Byte
    {
        نا_مشخص = 0,
        نیاز_به_استعلام_ندارد = 1,
        نیاز_به_استعلام_دارد = 2,
    }
    public enum NeedsChartType : System.Byte
    {
        نا_مشخص = 0,
        نیاز_ندارد = 1,
        نیاز_دارد = 2,
    }
    public enum ArrangementTypeInSalary : System.Byte
    {
        نا_مشخص = 0,
        شرکت_____های_برق_منطقه_____ای = 1,
        شرکت_____های_آب_منطقه_____ای = 2,
        دانشگاه_____ها = 3,
        دانشکده_____ها = 4,
        پارک_____های_علم_و_فناوری = 5,
        پژوهشگاه_____ها_و_پژوهشکده_____ها = 6,
        شهرداری_کلان_شهر = 7,
        شهرداری_تهران = 8,
        سایر_شهرداری = 9,
        مدیریت_شعب = 10,
        ادارات_کل_استان = 11,
        نمایندگی_و_شعبه_استان = 12,
        واحد_____های_استانی = 13,
        مدیریت_درمان_استان = 14,
        شرکت_____های_استانی = 15,
        شرکت_مادر_تخصصی = 16,
        شرکت_____های_گاز_استان = 17,
    }
    public enum BriefNameType : System.Byte
    {
        نا_مشخص = 0,
        شرکت_____های_برق_منطقه_____ای = 1,
        شرکت_____های_آب_منطقه_____ای = 2,
        دانشگاه_____ها = 3,
        دانشکده_____ها = 4,
        پارک_____های_علم_و_فناوری = 5,
        پژوهشگاه_____ها_و_پژوهشکده_____ها = 6,
        شهرداری_کلان_شهر = 7,
        شهرداری_تهران = 8,
        سایر_شهرداری = 9,
        مدیریت_شعب = 10,
        ادارات_کل_استان = 11,
        نمایندگی_و_شعبه_استان = 12,
        واحد_____های_استانی = 13,
        مدیریت_درمان_استان = 14,
        شرکت_____های_استانی = 15,
        شرکت_مادر_تخصصی = 16,
        شرکت_____های_گاز_استان = 17,
    }
    public enum AmarEmpType : System.Byte
    {
        نا_مشخص = 0,
        رسمی = 1,
        پیمانی = 2,
        قرارداد_کار_معین_مشخص = 3,
        قرارداد_کارگری_موقت = 4,
        قرارداد_ساعتی = 5,
        کارگری_دائم = 6,
        امریه_سربازی = 7,
        شرکتی_پیمانکاری = 8,
        اشکال_دیگر_بکارگیری = 9,
        نیروی_طرحی = 10,
        یگان_حفاظت = 11,
        طرح_اعتبارات_عمرانی = 12,
        ماده_95_قانون_مدیریت_خدمات_کشوری = 13,
    }
    public enum SourceType : System.Byte
    {
        نا_مشخص = 0,
        استخدام_و_بکارگیری_نیروی_انسانی = 1,
        فرم_6 = 2,
        فرم_آمار = 3,
    }
    public enum StudentStatusEnum : System.Byte
    {
        Unknown = 0,
        درحال_تحصیل = 1,
        فارغ_التحصیل = 2,
    }
    public enum StudyingModeEnum : System.Byte
    {
        Unknown = 0,
        روزانه = 1,
        شبانه = 2,
    }
    public enum DynamicPermissionDetailType : System.Byte
    {
        Unknown = 0,
        ParentDepartment = 1,
        Department = 2,
        Province = 3,
        DepartmentType = 4,
        PositionType = 9,
        Position = 10,
        EstekhdamParentDepartment = 30,
        EstekhdamProvince = 31,
        EstekhdamOrganLawType = 32,
        EstekhdamEmploymentRegulationsType = 33,
        EstekhdamDepartmentType = 34,
        EstekhdamDepartmentBudgetType = 35,
        EstekhdamDepartmentRegulationType = 36,
        EstekhdamDepartmentSubType = 37,
        PaknaParentDepartment = 60,
        PaknaProvince = 61,
        PaknaOrganLawType = 62,
        PaknaEmploymentRegulationsType = 63,
        PaknaDepartmentType = 64,
        PaknaDepartmentBudgetType = 65,
        PaknaDepartmentRegulationType = 66,
        PaknaDepartmentSubType = 67,
    }
    public enum OrganLawType : System.Byte
    {
        Unknown = 0,
        مشمول_قانون_مدیریت_خدمات_کشوری = 1,
        غیر_مشمول_قانون_مدیریت_خدمات_کشوری = 2,
        ترکیبی = 3,
    }
    public enum EmploymentRegulationsType : System.Byte
    {
        Unknown = 0,
        مشمول_قانون_مدیریت_خدمات_کشوری = 1,
        تابع_ضوابط_و_مقررات_قانون_مدیریت_خدمات_کشوری = 2,
        مشمول_قانون_کار = 3,
        مشمول_آیین_نامه_استخدامی_هیات_امنایی_تابع_وزارت_علوم = 4,
        مشمول_آیین_نامه_استخدامی_هیات_امنایی_تابع_وزارت_بهداشت = 5,
        نهاد_عمومی_غیر_دولتی = 6,
        مشمول_آیین_نامه_استخدامی_فرهنگستان_های_کشور = 7,
        مشمول_قوانین_و_مقررات_خاص = 8,
        مشمول_مقررات_استخدامی_شهرداری_ها = 9,
        قوانین_و_مقررات_استخدامی_ترکیبی = 10,
        مشمول_قوانین_و_مقررات_خاص_قوه_مقننه = 11,
        مشمول_قانون_استخدام_کشوری = 12,
    }
    public enum LoginType : System.Byte
    {
        Unknown = 0,
        نام_کاربری_و_رمز_عبور = 1,
        تلفن_همراه_و_رمز_عبور = 2,
        تلفن_همراه_و_کد_امنیتی = 3,
        ایمیل_و_رمز_عبور = 4,
        ایمیل_و_کد_امنیتی = 5,
        نام_کاربری_و_رمز_عبور_و_کد_امنیتی = 6,
        Sso = 7,
        IndividualLogin = 8,
        QrLogin = 9,
        نام_کاربری_و_رمز_عبور_وب_سرویس = 15,
    }
    public enum ContactDetailType : System.Byte
    {
        Unknown = 0,
        تلفن = 1,
        موبایل = 2,
        نمابر = 3,
        ایمیل = 4,
        آدرس = 5,
        کد_پستی = 6,
    }
    public enum ClientType : System.Byte
    {
        Unknown = 0,
        JavaScript = 1,
        Native = 2,
    }
    public enum CommandType : System.Byte
    {
        Unknown = 0,
        App = 1,
        Menu = 2,
        Page = 3,
        State = 7,
        Tab = 10,
        Element = 20,
        Column = 30,
    }
    public enum AnnouncementType : System.Byte
    {
        Unknown = 0,
        اخبار = 1,
        اطلاعیه = 2,
        بخشنامه = 3,
        راهنما = 4,
    }
    public enum AnnouncementPriorityType : System.Byte
    {
        Unknown = 0,
        خیلی_زیاد = 1,
        زیاد = 2,
        متوسط = 3,
        پایین = 4,
    }
    public enum EnableState : System.Byte
    {
        Unknown = 0,
        غیر_فعال = 1,
        فعال = 2,
    }
    public enum OnlineState : System.Byte
    {
        Unknown = 0,
        آفلاین = 1,
        آنلاین = 2,
    }
    public enum ExpireState : System.Byte
    {
        Unknown = 0,
        منقضی_شده = 1,
        منقضی_نشده = 2,
    }
    public enum ArchivedType : System.Byte
    {
        Unknown = 0,
        NotArchived = 1,
        Archived = 2,
    }
    public enum OrganizationAttachmentType : System.Byte
    {
        Unknown = 0,
        فایل_پیوست_اعلان = 1,
        تصویر_اعلان = 2,
        تصویر_کاربر = 3,
        پیوست_تیکت = 4,
        پیوست_پیام = 5,
        پیوست_سوابق_جایگاه = 6,
        تصویر_کارت_ملی = 7,
        گواهی_امضای_دیجیتال = 8,
        پیوست_کاربر_وب_سرویس = 9,
    }
    public enum SalaryPositionType : System.Byte
    {
        Unknown = 0,
        کارشناس_امور_مالی_دستگاه = 10,
        بالاترین_مقام_مالی_دستگاه = 20,
        بالاترین_مقام_دستگاه = 30,
        کارشناس_امور_بخشی = 40,
        مدیر_امور_بخشی = 41,
        کارشناس_امور_تلفیق = 45,
        مدیر_امور_تلفیق = 46,
        کارشناس_متد = 47,
        گزارش_گیر = 50,
        گزارش_گیر_دستگاه_نظارتی = 51,
        پاسخ_دهنده_تیکت = 60,
        راهبر = 100,
        راهبر_ارشد = 101,
    }
    public enum PardakhtPositionType : System.Byte
    {
        Unknown = 0,
        کارشناس_امور_مالی_دستگاه = 10,
        بالاترین_مقام_مالی_دستگاه = 20,
        بالاترین_مقام_دستگاه = 30,
        کارشناس_سازمان_مدیریت_و_برنامه_ریزی_استان = 31,
        معاون_سازمان_مدیریت_و_برنامه_ریزی_استان = 32,
        رییس_سازمان_مدیریت_و_برنامه_ریزی_استان = 33,
        کارشناس_امور_استان_ها_و_توسعه_منطقه_ای = 35,
        معاون_امور_استان_ها_و_توسعه_منطقه_ای = 36,
        رییس_امور_استان_ها_و_توسعه_منطقه_ای = 37,
        کارشناس_امور_بخشی = 41,
        معاون_امور_بخشی = 45,
        رییس_امور_بخشی = 50,
        کارشناس_امور_هماهنگی_و_تلفیق_بودجه = 51,
        معاون_امور_هماهنگی_و_تلفیق_بودجه = 55,
        رییس_امور_هماهنگی_و_تلفیق_بودجه = 60,
        گزارش_گیر = 70,
        گزارش_گیر_دستگاه_نظارتی = 75,
        پاسخ_دهنده_تیکت = 80,
        کارشناس_متد = 85,
        راهبر = 100,
        راهبر_ارشد = 101,
    }
    public enum EstekhdamPositionType : System.Byte
    {
        Unknown = 0,
        کارگزین = 20,
        مدیر_کل_امور_اداری_یا_مدیر_کل_استان = 30,
        شهردار = 35,
        ذیحساب = 40,
        مدیر_کل_دفتر_امور_شهری_استانداری = 43,
        کارشناس_امور_شهرداری_ها__سازمان_شهرداری_های_کشور = 44,
        مدیر_کل_امور_شهرداری_ها__سازمان_شهرداری_های_کشور = 45,
        کارشناس_استخدام_استان = 49,
        بالاترین_مقام_استان = 50,
        بالاترین_مقام_ستاد = 55,
        کارشناس_استخدام_سازمان_اداری_و_استخدامی_کشور = 60,
        مسئول_صدور_شماره = 70,
        نظارتی = 81,
        صندوق_بازنشستگی = 90,
        راهبر_ارشد = 100,
        راهبر = 101,
        حکمرانی_داده_مبنا = 102,
        آمار_و_برنامه_ریزی_نیروی_انسانی = 115,
    }
    public enum JobPositionType : System.Byte
    {
        Unknown = 0,
        رابط_دستگاه_اجرایی = 10,
        کارشناس_مدیریت_مشاغل = 60,
        مسئول_تایید_نهایی = 70,
        نظارتی = 81,
        راهبر = 100,
    }
    public enum IsManagerSabteAsnadVaAmlakType : System.Byte
    {
        نامشخص = 0,
        هيئت_مدیره_است = 1,
        هيئت_مدیره_نیست = 2,
    }
    public enum SakhtarPositionType : System.Byte
    {
        _ = 0,
        رابط_استانی = 2,
        کارگزین = 4,
        رابط_دستگاه_اجرایی = 5,
        رابط_امور_شهری_و_روستایی_استانداری = 6,
        رابط_سازمان_شهرداری_____ها_و_دهیاری_____های_کشور = 7,
        بالاترین_مقام_منابع_انسانی = 9,
        بالاترین_مقام_تشکیلات_دستگاه_اجرایی = 10,
        کارشناس_معاونت_توسعه_مدیریت_و_سرمایه_انسانی_استان = 11,
        معاونت_توسعه_مدیریت_و_سرمایه_انسانی_استان = 12,
        بالاترین_مقام_مجاز_دستگاه_اجرایی = 15,
        معاون_نوسازی_اداری = 20,
        رئیس_امور_ساختار_____های_سازمانی = 25,
        معاون_امور_ساختار_____های_سازمانی = 30,
        رئیس_گروه_ساختار_____های_سازمانی = 35,
        کارشناس_ساختار_____های_سازمانی = 40,
        رئیس_سازمان_اداری_و_استخدامی_کشور = 45,
        مشاهده_کننده = 51,
        مسئول_دفتر_امور_ساختار_____های_سازمانی = 52,
        رابط_هیئت_ماده_9 = 53,
        رابط_ارزیابی_عملکرد = 54,
        ناظر = 55,
        رابط_امور_آمار___برنامه_ریزی_و_تامین_نیروی_انسانی = 56,
        رابط_امور_جبران_خدمات = 57,
        مشاور_رئیس_سازمان = 58,
        مشاور_معاون_سازمان = 59,
        شهردار = 60,
        کارشناس_دفتر_تحول_اداری_سازمان_شهرداری_____ها = 61,
        بالاترین_مقام_دفتر_تحول_اداری_سازمان_شهرداری_____ها = 62,
        رابط_دفتر_توسعه_حکمراني_داده_مبنا = 63,
        رابط_ناظر_سازمان_بازرسي_کل_کشور = 64,
        رابط_ناظر_ديوان_محاسبات = 65,
        رابط_امور_به_____کارگيري___جذب_و_رشد = 66,
        رابط_قوه_قضاييه = 67,
        رابط_مجلس_شوراي_اسلامي = 68,
        رابط_امور_فناوري_اطلاعات_و_امنيت_فضاي_مجازي = 69,
        رابط_مرکز_پژوهش_____هاي_مجلس = 70,
        رابط_ميزخدمت_سازمان_اداري_و_استخدامي_کشور = 71,
        رابط_طراحي_و_توسعه_سامانه_____هاي_امور_توسعه_دولت_هوشمند = 72,
        رابط_امور_استان_____هاي_سازمان_برنامه_و_بودجه = 73,
        رابط_امور_مديريت_مشاغل = 74,
        رابط_شرکت_پيمانکار_سامانه = 75,
        کاربر_مدير_يا_مشاور_سازمان = 76,
        معاون_نرم_افزار_امور_فناوري_اطلاعات = 77,
        رييس_امور_فناوري_اطلاعات = 78,
        ناظر_کارتابل = 90,
        راهبر_دوم = 99,
        راهبر = 100,
    }
    public enum OrganizationPositionType : System.Byte
    {
        _ = 0,
        رابط_مدیریت_اطلاعات_پایه = 50,
        معاونت_توسعه_مدیریت_و_سرمایه_انسانی_استان = 60,
        رابط_مدیریت_اطلاعات_پایه_ستاد = 100,
        فناوری_اطلاعات_ستاد = 101,
        رابط_شرکت_مشاور = 102,
    }
    public enum SurveyPositionType : System.Byte
    {
        _ = 0,
        کاربر_دستگاه_اجرایی = 10,
        کارشناس_میز_خدمت = 20,
        راهبر = 100,
    }
    public enum KanoonPositionType : System.Byte
    {
        Unknown = 0,
        کاربر_کانون = 85,
        کاربر_دستگاه_اجرایی = 87,
        کارشناس_ارشد_سازمان_اداری_استخدامی = 88,
        کارشناس_ستاد = 89,
        ناظر_سازمان_اداری_استخدامی = 90,
        ذینفع_تخصصی = 100,
        فناوری_اطلاعات_ستاد = 150,
        رابط_شرکت_مشاور = 200,
    }
    public enum DepartmentType : System.Byte
    {
        نامشخص = 0,
        دستگاه_اجرایی_ستادی = 1,
        دستگاه_اجرایی_استانی = 2,
        شوراهای_عالی_و_غیره = 3,
        گره_نمایشی = 10,
        کانون_دولتی = 101,
        کانون_خصوصی = 102,
        دولتی_سازمان_مدیریت_و_برنامه_ریزی_استان_ها = 103,
        دولتی_دستگاه_های_اجرایی_و_مؤسسات_آموزشی = 104,
        سازمان_مدیریت_صنعتی = 105,
    }
    public enum DepartmentSubType : System.Byte
    {
        نامشخص = 0,
        وزارت_خانه = 1,
        نهاد_عمومی_غیر_دولتی = 2,
        شرکت_دولتی = 3,
        موسسه_دولتی = 4,
    }
    public enum OrganType : System.Byte
    {
        نامشخص = 0,
        ستاد_سازمان_اداری_و_استخدامی_کشور = 1,
        سازمان_مدیریت_و_برنامه_ریزی_استان = 2,
        استانداری = 3,
        شهرداری = 4,
        بانک = 5,
        بیمه = 6,
        شرکت_پست = 7,
        سازمان_شهرداری_ها_و_دهیاری_های_کشور = 8,
        کادر_آموزشی_آموزش_و_پرورش = 9,
    }
    public enum UserType : System.Byte
    {
        Unknown = 0,
        کاربر_ستاد = 1,
        کاربر_دستگاه_اجرایی = 2,
    }
    public enum ApplicationStatus : System.Int32
    {
        Unknown = 0,
        فعال = 1,
        غیر_فعال = 2,
    }
    public enum PlaceType : System.Byte
    {
        Unknown = 0,
        کشور = 1,
        استان = 2,
        شهرستان = 3,
        بخش = 4,
        شهر = 5,
        دهستان = 6,
        روستا = 7,
        قاره = 8,
    }
    public enum PositionType : System.Byte
    {
        Unknown = 0,
        راهبر = 100,
        رابط_تعریف_کننده_کاربران = 180,
    }
    public enum PaknaPositionType : System.Byte
    {
        Unknown = 0,
        کارشناس_دستگاه_اجرایی = 20,
        مدیر_کل_امور_اداری = 30,
        ذیحساب = 40,
        معاونت_برنامه_و_بودجه_استان = 48,
        کارشناس_آمار_استان = 49,
        بالاترین_مقام_استان = 50,
        بالاترین_مقام_ستاد = 55,
        کارشناس_امور_آمار_و_برنامه_ریزی = 60,
        نظارتی = 81,
        معاون_امور = 82,
        کارشناس_میز_تشریح_دستگاه_اجرایی = 83,
        راهبر_ارشد = 100,
        راهبر = 101,
        هماهنگی_تخصیص_و_پرداخت = 110,
        برنامه_ریزی_و_تامین_نیروی_انسانی = 115,
    }
    public enum SendMessageType : System.Byte
    {
        Unknown = 0,
        Email = 1,
        Sms = 2,
    }
    public enum UserNotificationType : System.Byte
    {
        Unknown = 0,
        Email = 1,
        Sms = 2,
        Notification = 3,
    }
    public enum UserNotificationTemplate : System.Byte
    {
        Unknown = 0,
        ForgotPassword = 1,
        ResetPassword = 2,
        VerifyCellphone = 3,
        VerifyEmail = 4,
        UserAdded = 5,
        PasswordChanged = 6,
        UserInNewPosition = 7,
        SendForgotPasswordLinkByEmail = 8,
        CellPhoneSaved = 9,
        EducationalCertificatesSaved = 10,
        TicketTrackingCode = 11,
        LoginOTP = 12,
    }
    public enum SendMessageReasonType : System.Byte
    {
        Unknown = 0,
        ForgotPassword = 1,
        ResetPassword = 2,
        VerifyCellphone = 3,
        VerifyEmail = 4,
        UserAdded = 5,
        ActivateUser = 6,
    }
    public enum NotificationPriority : System.Byte
    {
        زیاد = 1,
        متوسط = 2,
        کم = 3,
    }
    public enum NotificationType : System.Byte
    {
        Unknown = 0,
        اخبار = 1,
        اطلاعیه_ها = 2,
    }
    public enum NotificationState : System.Byte
    {
        Unknown = 0,
        ارسال_نشده = 1,
        ارسال_شده = 2,
        آرشیو_شده = 3,
        حذف_شده = 4,
    }
    public enum NotificationSenderType : System.Byte
    {
        Unknown = 0,
        سامانه = 1,
        کاربر = 2,
    }
    public enum ApplicationSurveyQuestionType : System.Byte
    {
        Unknown = 0,
        بله_یا_خیر = 1,
        تک_انتخابی = 2,
        چند_انتخابی = 3,
        متن_کوتاه = 4,
        متن_بلند = 5,
    }
    public enum TicketState : System.Byte
    {
        Unknown = 0,
        باز_است = 1,
        بسته_شود = 2,
        در_دست_اقدام_می_باشد = 3,
    }
    public enum TicketReportState : System.Byte
    {
        Unknown = 0,
        باز = 1,
        بسته_شده = 2,
        در_دست_اقدام = 3,
    }
    public enum TicketPriority : System.Byte
    {
        Unknown = 0,
        زیاد = 1,
        متوسط = 2,
        کم = 3,
    }
    public enum TicketScore : System.Byte
    {
        Unknown = 0,
        خوب = 1,
        متوسط = 2,
        ضعیف = 3,
    }
    public enum StatType : System.Byte
    {
        Unknown = 0,
        تیکت_ها = 1,
        پیام_ها = 2,
    }
    public enum IsaargarType : System.Byte
    {
        Unknown = 0,
        نیست = 1,
        است = 2,
    }
    public enum MessageSendType : System.Byte
    {
        Unknown = 0,
        New_Message = 1,
        Reply = 2,
        Forward = 3,
    }
    public enum COFOG : System.Byte
    {
        نامشخص = 0,
        امور_دفاعی_و_امنیتی = 1,
        امور_قضایی = 2,
        امور_اقتصادی = 3,
        امور_محیط_زیست = 4,
        امور_مسکن___عمران_شهری_و_روستایی = 5,
        امور_سلامت = 6,
        امور_فرهنگ___تربیت_بدنی_و_گردشگری = 7,
        امور_آموزش_و_پژوهش = 8,
        امور_رفاه_اجتماعی = 9,
        امور_خدمات_عمومی = 10,
    }
    public enum CouncilType : System.Byte
    {
        شورا = 1,
        شورا_عالی = 2,
        کمیته = 3,
        هیأت = 4,
        کمیسیون = 5,
    }
    public enum TicketAnswerState : System.Byte
    {
        نامشخص = 0,
        جدید = 1,
        پاسخ_داده_شده = 2,
        پاسخ_داده_نشده = 3,
        بسته_شده = 4,
    }
    public enum IsDead : System.Byte
    {
        نامشخص = 0,
        در_قید_حیات = 1,
        فوت_شده = 2,
    }
    public enum SystemEnablement : System.Byte
    {
        نامشخص = 0,
        فعال_در_سامانه_حقوق_و_مزایا = 1,
        فعال_در_سامانه_مشاغل = 2,
        فعال_در_سامانه_استخدام = 3,
        فعال_در_سامانه_پاکنا = 4,
        فعال_در_سامانه_ساختار = 5,
        فعال_در_وب_سرویس_سامانه_استخدام = 6,
        فعال_در_وب_سرویس_سامانه_پاکنا = 7,
        فعال_در_وب_سرویس_سامانه_ساختار = 8,
        فعال_در_وب_سرویس_سامانه_مشاغل = 9,
        فعال_در_وب_سرویس_سامانه_حقوق_و_مزایا = 10,
        فعال_در_گزارش_سامانه_ساختار = 11,
        فعال_در_سامانه_خدمات = 12,
        فعال_در_سامانه_ارزیابی_و_عملکرد = 13,
        فعال_در_داشبورد_دانا = 14,
        فعال_در_سامانه_کانون_ارزیابی = 15,
        فعال_در_سامانه_بینا = 16,
    }
    public enum InquiryResultType : System.Byte
    {
        نامشخص = 0,
        استعلام_موفق_با_پاسخ = 1,
        استعلام_موفق_بدون_پاسخ = 2,
        استعلام_ناموفق = 3,
        خطا_داخلی = 4,
        خطا_در_اعتبار_سنجی = 5,
        ایجاد_درخواست_امضای_دیجیتال = 101,
        پاسخ_ناموفق_مرحله_اول = 102,
        پاسخ_موفق_بدون_پارامتر_مرحله_اول = 103,
        ارسال_کاربر_به_درگاه_امضای_دیجیتال = 104,
        خطا_ناشناخته_مرحله_اول = 105,
        پاسخ_ناموفق_مرحله_دوم = 106,
        پاسخ_موفق_بدون_پارامتر_مرحله_دوم = 107,
        خطا_ناشناخته_مرحله_دوم = 108,
        امضای_موفق = 109,
    }
    public enum WebServiceLocationType : System.Byte
    {
        Other = 0,
        Local = 1,
        Gsb = 2,
    }
    public enum MessageType : System.Byte
    {
        Other = 0,
        پاپ_آپ = 1,
    }
    public enum HasCellPhone : System.Byte
    {
        نامشخص = 0,
        شماره_تماس_دارد = 1,
        شماره_تماس_ندارد = 2,
    }
    public enum ElementType : System.Byte
    {
        نامشخص = 0,
        دکمه_شفافیت_دستگاه_____های_اجرایی = 1,
        دکمه_ثبت_تلفن_همراه_کارکنان = 2,
        دکمه_نظر_سنجی_عمومی_عملکرد_واحد_____ها = 3,
        دکمه_ثبت_مدارک_تحصیلی_کارکنان = 4,
        دکمه_قوانین_و_مقررات = 5,
    }
    public enum OperatingSystemType : System.Byte
    {
        unknown = 0,
        windows = 1,
        android = 2,
        ios = 3,
        linux = 4,
        mac = 5,
        blackberry_os = 6,
        سایر = 7,
    }
    public enum BrowserType : System.Byte
    {
        unknown = 0,
        firefox = 1,
        chrome = 2,
        opera = 3,
        internet_explorer = 4,
        سایر = 5,
    }
    public enum DeviceType : System.Byte
    {
        unknown = 0,
        mobile = 1,
        desktop = 2,
        smartphone = 3,
        tablet = 4,
        iPhone = 5,
        سایر = 6,
    }
    public enum DependentLPType : System.Int32
    {
        None = 0,
        شعبه = 1,
        داخلی_شعبه = 2,
        نمایندگی_دفتر = 3,
        حوزه = 4,
        تابعه_تشکیلاتی_ساختار = 5,
        مستقل_واحد = 6,
        عملیاتی_واحد = 7,
        مستقل = 8,
        تولیت_تحت = 9,
    }
    public enum State : System.Int32
    {
        None = 0,
        فعال = 1,
        غیرفعال = 2,
    }
    public enum FileExtension : System.Int32
    {
        None = 0,
        PDF = 1,
        TIFF = 2,
        JPG = 3,
        PNG = 4,
        DOC = 5,
        DOCX = 6,
        XLS = 7,
        XLSX = 8,
        TIF = 9,
        GIF = 10,
        JPEG = 11,
        BMP = 12,
    }
    public enum PersonType : System.Int32
    {
        None = 0,
        NaturalPerson = 1,
        Legal = 2,
    }
    public enum NationalityType : System.Int32
    {
        None = 0,
        Iranian = 1,
        Foreign = 2,
    }
    public enum SexType : System.Int32
    {
        None = 0,
        Female = 1,
        Male = 2,
    }
    public enum YesNo : System.Int32
    {
        None = 0,
        Yes = 1,
        No = 2,
    }
    public enum LogType : System.Byte
    {
        نامشخص = 0,
        لاگ_کاربران_سامانه = 1,
        لاگ_کاربران_وب_سرویس = 2,
    }
    public enum IsManager : System.Byte
    {
        نامشخص = 0,
        بله = 1,
        خیر = 2,
    }
    public enum HaveNoHave : System.Byte
    {
        نامشخص = 0,
        دارد = 1,
        ندارد = 2,
    }
    public enum LogStatus : System.Byte
    {
        نامشخص = 0,
        ورود_موفق = 1,
        خروج = 2,
        نام_کاربری_یا_کلمه_عبور_نادرست = 3,
        کد_امنیتی_نادرست = 4,
        استفاده_از_توکن_متفرقه = 5,
        امضای_دیجیتال_نادرست = 6,
        گواهی_دیجیتال_نامعتبر = 7,
        اطلاعات_امضای_دیجیتال_مغای_با_امضا = 8,
    }
    public enum BackupType : System.Byte
    {
        نامشخص = 0,
        Full = 1,
        Differential = 2,
        Transaction_Log = 3,
    }
    public enum JobStatus : System.Byte
    {
        نامشخص = 0,
        ناموفق = 1,
        موفق = 2,
    }
    public enum StepStatus : System.Byte
    {
        نامشخص = 0,
        ناموفق = 1,
        موفق = 2,
    }
    public enum SurveyType : System.Byte
    {
        نامشخص = 0,
        در_انتظار = 1,
        فعال = 2,
        بسته_شده = 3,
    }
    public enum SurveyOptionType : System.Byte
    {
        نامشخص = 0,
        بله__خیر = 1,
        موافقم__مخالفم = 2,
        کم__متوسط__زیاد = 3,
        خیلی_ضعیف__ضعیف__متوسط__خوب__عالی = 4,
        گزینه_متنی = 5,
    }
    public enum ActivityLogVerifyResult : System.Byte
    {
        Ok = 1,
        Excluded = 2,
        ActionBlocked = 3,
        UserBlocked = 4,
    }
    public enum SsoEnum : System.Byte
    {
        Login = 1,
        Logout = 2,
        ClosePopUp = 3,
        ShiftSsoLogin = 4,
        ReloadPage = 5,
    }
}
namespace Kama.Organization.Core.Model.Shahkar
{
    public class Request
    {
        public System.String serviceNumber { get; set; }

        public System.String identificationNo { get; set; }

        public System.String requestId { get; set; }

        public System.Int32 serviceType { get; set; }

        public System.Int32 identificationType { get; set; }

    }
    public class Response
    {
        public System.Boolean response { get; set; }

        public System.String requestId { get; set; }

        public System.String result { get; set; }

        public System.String comment { get; set; }

    }
    public class Shahkar
    {
        public System.Boolean Response { get; set; }

        public System.Boolean Result { get; set; }

        public System.String Comment { get; set; }

    }
    public class ShahkarVM
    {
        public System.String NationalCode { get; set; }

        public System.String PhoneNumber { get; set; }

    }
}
namespace Kama.Organization.Core.Model.SabteAsnadVaAmlakService
{
    public class SuspensionLegalNumber
    {
        public System.String Address { get; set; }

        public System.String MobileNumber { get; set; }

        public System.String NameDescPE { get; set; }

        public System.String PostCode { get; set; }

        public System.String RegisterDateSH { get; set; }

        public Kama.Organization.Core.Model.SabteAsnadVaAmlakService.TheCLPIApplicationType TheCLPIApplicationType { get; set; }

        public Kama.Organization.Core.Model.SabteAsnadVaAmlakService.TheCLPSpecialInfoOrg TheCLPSpecialInfoOrg { get; set; }

        public Kama.Organization.Core.Model.CLPILegalPersonType TheCLPILegalPersonType { get; set; }

        public IList<Kama.Organization.Core.Model.CLPLegalPersonReviewAttachList> TheCLPLegalPersonReviewAttachList { get; set; }

        public IList<Kama.Organization.Core.Model.CLPLegalPersonReviewPrsnList> TheClpSpecialInfoPersonList { get; set; }

        public IList<Kama.Organization.Core.Model.CLPLegalPersonReviewPrsnPstList> TheClpSpecialInfoPersonPostList { get; set; }

        public Kama.Organization.Core.Model.ParentNationalCode TheParentNationalCode { get; set; }

        public System.String letterNumber { get; set; }

        public System.String letterDate { get; set; }

    }
    public class TheCLPSpecialInfoOrg
    {
        public System.String Licensevalidityperiod { get; set; }

        public System.String Lastupdatedate { get; set; }

        public System.String Signatory { get; set; }

        public Kama.Organization.Core.Model.HaveNoHave BranchStatus { get; set; }

        public System.String ActivitySubject { get; set; }

    }
    public class TheCLPIApplicationType
    {
        public System.String Code { get; set; }

        public Kama.Organization.Core.Model.State State { get; set; }

        public System.String Title { get; set; }

    }
}
namespace Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService
{
    public class IsManagerResult
    {
        public Kama.Organization.Core.Model.IsManager IsManager { get; set; }

    }
    public class IsManagerVM
    {
        public System.String NationalCode { get; set; }

        public System.Guid? IndividualID { get; set; }

    }
    public class CLPLegalPersonReviewResult
    {
        public Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.Result Result { get; set; }

        public Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPersonReview TheCLPLegalPersonReview { get; set; }

    }
    public class Result
    {
        public System.Boolean Successful { get; set; }

        public System.String Message { get; set; }

        public System.String No { get; set; }

        public System.String Description { get; set; }

        public System.String Code { get; set; }

    }
    public class TheCLPLegalPerson
    {
        public System.String NationalCode { get; set; }

    }
    public class TheCLPLegalPersonReview
    {
        public System.String PursuitNumber { get; set; }

        public Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.TheCLPLegalPerson TheCLPLegalPerson { get; set; }

    }
    public class SuspensionLegalNumberResult
    {
        public Kama.Organization.Core.Model.Inquiry.SabteAsnadVaAmlakService.Result Result { get; set; }

        public System.String UniqueNo { get; set; }

    }
}
namespace Kama.Organization.Core.Model.Insurance
{
    public class Data
    {
        public Kama.Organization.Core.Model.TaaminSocialResponse taaminResponse { get; set; }

        public Kama.Organization.Core.Model.SalamatResponse salamatResponse { get; set; }

    }
}
