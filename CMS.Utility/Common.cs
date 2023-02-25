using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Utility
{
    public class Common
    {
        public const string UserID = "UserID ";
       

        // Status ....
       
        public static class Messages
        {
            public static string InvalidUserCredentials = @"Invalid User Credentials !!!";
            public static string RecordsSavedSuccessfully = @"Record(s) Saved Successfully !!!";
            public static string RecordsUpdatedSuccessfully = @"Record(s) Updated Successfully !!!";
            public static string NoRecordsfound = @"No Record(s) Found !!!";
            public static string FailedToSaveRecords = @"Failed To Save Record(s) !!!";
            public static string FailedToUpdatedRecords = @"Failed To Update Record(s) !!!";
            public static string SessionIsExpiredPleaseLoginAgain = @"Session Is Expired Please Login Again !!!";
            public static string RecordDeletedSuccessfully = @"Record deleted successfully ...!";
            public static string FailedToDeletedTryAgain = @"Failed To Deleted Try Again ...!";
            public static string FailedToLoadTryAgain = @"Failed To Load Try Again ...!";
            public static string Success = @"Success ...!";
            public static string QueryIsEmpty = @"Query Is Empty ...!";
            public static string ModelIsNull = @"Model Is Null ...!";
            public static string MissingCoursePleaseMeetAdmin = @"Few Courses are missing for this Academic Year Please Meet Admin with Your Course Code";
            public static string LedgersAreNotMapped = @"Ledgers Are Not Mapped , Please meet exam registration committee";
            public static string CoursesAreNotAlloted = @"Courses Are Not Allotted";
            public const string PleaseConfigureMessageSetting = "Please Configure Message Setting !!!";
            public const string NoMobileNumbersAvailable = "No Mobile Numbers Available !!!";
            public const string LowMessageLimit = "Low Message Limit !!!";
            public static string RequestTimeOut = @"Sorry for the inconvenience, Time out error , Please Close your browser and register again.";
            public static string AccountNotAvailable = @"Sorry for the inconvenience,Account is not available.";
            public static string LedgersAreMapped = @"Ledgers Are Mapped Already !!!.";
            public static string PleaseConfigureExamHeads = @"PleaseConfigureExamHeads !.\n Please meet admin for more information ";
            public static string UserAccountNotCreated = @"UserAccount is not created!";
            public static string RecordsExistAlready = @"Record(s) Are Exist Already!.";
            public static string MobileNumberExistAlready = @"Mobile Number Exist Already!.";
            public static string InvalidInput = @"Invalid Input!";
        }
       
        public static class COLOR
        {
            public const string GREEN = "GREEN";
            public const string RED = "RED";
            public const string YELLOW = "YELLOW";
            public const string AQUA = "AQUA";
            public const string NORMAL = "NORMAL";
        }
       
        public static class ErrorMessage
        {
            public static string Unauthorized = "Unathorized Access !!!";
            #region Informational Error Messages
            public static string Continue = "Continue";
            public static string SwitchingProtocols = "Switching Protocols";
            public static string Processing = "Processing";
            #endregion
            #region Success Messages
            public static string Ok = "OK";
            public static string Created = "Created";
            public static string Accepted = "Accepted";
            public static string NonAuthoritativeInformation = "Non-authoritative Information";
            public static string NoContent = "No Content";
            public static string ResetContent = "Reset Content";
            public static string PartialContent = "Partial Content";
            public static string MultiStatus = "Multi-Status";
            public static string AlreadyReported = "Already Reported";
            public static string IMUsed = "IM Used";
            #endregion
            #region Redirectional Error Messages
            public const string MultipleChoices = "Multiple Choices";
            public const string MovedPermanently = "Moved Permanently";
            public const string Found = "Found";
            public const string SeeOther = "See Other";
            public const string NotModified = "Not Modified";
            public const string UseProxy = "Use Proxy";
            public const string TemporaryRedirect = "Temporary Redirect";
            public const string PermanentRedirect = "Permanent Redirect";
            #endregion
            #region Client Error Messages
            public static string BadRequest = "Bad Request";
            //public static string Unauthorized = "Unauthorized";
            public static string PaymentRequired = "Payment Required";
            public static string Forbidden = "Forbidden";
            public static string NotFound = "Not Found";
            public static string MethodNotAllowed = "Method Not Allowed";
            public static string NotAcceptable = "Not Acceptable";
            public static string ProxyAuthenticationRequired = "Proxy Authentication Required";
            public static string RequestTimeout = "Request Timeout";
            public static string Conflict = "Conflict";
            public static string Gone = "Gone";
            public static string LengthRequired = "Length Required";
            public static string PreconditionFailed = "Precondition Failed";
            public static string PayloadTooLarge = "PayloadTooLarge";
            public static string RequestURITooLong = "Request-URI Too Long";
            public static string UnsupportedMediaType = "Unsupported Media Type";
            public static string RequestedRangeNotSatisfiable = "Requested Range Not Satisfiable";
            public static string ExpectationFailed = "Expectation Failed";
            public static string ImATeapot = "I'm a teapot";
            public static string MisdirectedRequest = "Misdirected Request";
            public static string UnprocessableEntity = "Unprocessable Entity";
            public static string Locked = "Locked";
            public static string FailedDependency = "Failed Dependency";
            public static string UpgradeRequired = "Upgrade Required";
            public static string PreconditionRequired = "Precondition Required";
            public static string TooManyRequests = "Too Many Requests";
            public static string RequestHeaderFieldsTooLarge = "Request Header Fields Too Large";
            public static string ConnectionClosedWithoutResponse = "Connection Closed Without Response";
            public static string UnavailableForLegalReasons = "Unavailable For Legal Reasons";
            public static string ClientClosedRequest = "Client Closed Request";
            #endregion
            #region Server Error Messages
            public static string InternalServerError = "Internal Server Error";
            public static string NotImplemented = "Not Implemented";
            public static string BadGateway = " Bad Gateway";
            public static string ServiceUnavailable = "Service Unavailable";
            public static string GatewayTimeout = "Gateway Timeout";
            public static string HTTPVersionNotSupported = "HTTP Version Not Supported";
            public static string VariantAlsoNegotiates = "Variant Also Negotiates";
            public static string InsufficientStorage = "Insufficient Storage";
            public static string LoopDetected = "Loop Detected";
            public static string NotExtended = "Not Extended";
            public static string NetworkAuthenticationRequired = "Network Authentication Required";
            public static string NetworkConnectTimeoutError = "Network Connect Timeout Error";
            #endregion
        }
        public static class ErrorCode
        {
            #region Informational Error Codes
            public static string Continue = "100";
            public static string SwitchingProtocols = "101";
            public static string Processing = "102";
            #endregion
            #region Success Codes
            public static string Ok = "200";
            public static string Created = "201";
            public static string Accepted = "202";
            public static string NonAuthoritativeInformation = "203";
            public static string NoContent = "204";
            public static string ResetContent = "205";
            public static string PartialContent = "206";
            public static string MultiStatus = "207";
            public static string AlreadyReported = "208";
            public static string IMUsed = "226";
            #endregion
            #region Redirectional Error Codes
            public const string MultipleChoices = "300";
            public const string MovedPermanently = "301";
            public const string Found = "302";
            public const string SeeOther = "303";
            public const string NotModified = "304";
            public const string UseProxy = "305";
            public const string TemporaryRedirect = "307";
            public const string PermanentRedirect = "308";
            #endregion
            #region Client Error Codes
            public static string BadRequest = "400";
            public static string Unauthorized = "401";
            public static string PaymentRequired = "402";
            public static string Forbidden = "403";
            public static string NotFound = "404";
            public static string MethodNotAllowed = "405";
            public static string NotAcceptable = "406";
            public static string ProxyAuthenticationRequired = "407";
            public static string RequestTimeout = "408";
            public static string Conflict = "409";
            public static string Gone = "410";
            public static string LengthRequired = "411";
            public static string PreconditionFailed = "412";
            public static string PayloadTooLarge = "413";
            public static string RequestURITooLong = "414";
            public static string UnsupportedMediaType = "415";
            public static string RequestedRangeNotSatisfiable = "416";
            public static string ExpectationFailed = "417";
            public static string ImATeapot = "418";
            public static string MisdirectedRequest = "421";
            public static string UnprocessableEntity = "422";
            public static string Locked = "423";
            public static string FailedDependency = "424";
            public static string UpgradeRequired = "426";
            public static string PreconditionRequired = "428";
            public static string TooManyRequests = "429";
            public static string RequestHeaderFieldsTooLarge = "431";
            public static string ConnectionClosedWithoutResponse = "444";
            public static string UnavailableForLegalReasons = "451";
            public static string ClientClosedRequest = "499";
            #endregion
            #region Server Error Codes
            public static string InternalServerError = "500";
            public static string NotImplemented = "501";
            public static string BadGateway = "502";
            public static string ServiceUnavailable = "503";
            public static string GatewayTimeout = "504";
            public static string HTTPVersionNotSupported = "505";
            public static string VariantAlsoNegotiates = "506";
            public static string InsufficientStorage = "507";
            public static string LoopDetected = "508";
            public static string NotExtended = "510";
            public static string NetworkAuthenticationRequired = "511";
            public static string NetworkConnectTimeoutError = "599";
            #endregion
        }
        

        public static class Formats
        {
            public static string TimeFormat = "HH:mm:ss";
            public static string dd_MM_yyyy = "dd-MM-yyyy";
            public static string MM_dd_yyyy = "MM-dd-yyyy";
            public static string yyyy_MM_dd = "yyyy-MM-dd";
            //public static string TimeFormat = "HH:mm:ss";
            //public static string TimeFormat = "HH:mm:ss";
            //public static string TimeFormat = "HH:mm:ss";


        }
        
        public static class style
        {
            public static string alert_danger = "<div class='alert alert-danger alert-dismissable'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>×</button>{0}</div> ";
            public static string alert_sucess = "<div class='alert alert-success alert-dismissable'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>×</button>{0}</div> ";
            public static string alert_info = "<div class='alert alert-info alert-dismissable'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>×</button>{0}</div> ";
            public static string alert_warning = "<div class='alert alert-warning alert-dismissable'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>×</button>{0}</div> ";
            public static string display_none = "none ";
            public static string display_block = "block ";
        }
       
        public abstract class URLPages
        {
            //public static string ApplicationVirtualPath
            //{
            //    get { return HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath; }
            //}

            //Route config key Name


            public static string SERVER_PATH = AppDomain.CurrentDomain.BaseDirectory + "\\ ";
            public static string STORE_PATH = @"AttachMents\Store\{0}\ ";
            public static string STORE_PATHMobile = @"AttachMents\Store\ ";
            public static string PROFILE_PATH = @"AttachMents\Profile\ ";
            public static string PROMOTION_PATH = @"AttachMents\PromotionImages\ ";
            public static string ADVERTISEMENT_PATH = @"AttachMents\AdvertisementImages\ ";
            public static string PRODUCTIMAGES_PATH = @"AttachMents\ProductImages\ ";
            public static string CLEARANCE_PATH = @"AttachMents\ClearanceImages\ ";
            public static string BANNER_PATH = @"AttachMents\BannerImages\ ";
            public static string CATALOG_PATH = @"AttachMents\CatalogImages\ ";
            public static string STUDENT_IMGAE_PATH = @"Image\AUXM\StudentImages\";
            public static string STAFF_IMGAE_PATH = @"Image\HCC\StaffImages\";
            public static string HALL_IMAGE = @"Image\HCC\HallImages\";
            public static string STUDENT_HOSTEL_PATH = @"Image\HCC\Hostel\";
            public static string ACTIVITY_IMAGE_PATH = @"Reports\ActivityImages\";
            public static string ACTIVITY_FILE_PATH = @"Reports\ActivityFiles\";
            public static string GRIEVANCEATTACHMENTPOST_FILE_PATH = @"Grievance\GrievanceAttachmentFiles\POST\";
            public static string GRIEVANCEATTACHMENTREPLY_FILE_PATH = @"Grievance\GrievanceAttachmentFiles\REPLY\";
            public static string LIBRARY_MEMBER_IMAGE_PATH = @"Image\HCC\LibraryMemberImages\";
            public static string ALUMNAE_MEMBER_IMAGE_PATH = @"Image\HCC\AlumnaeMemberImages\";
            public static string EXAM_PHOTOCOPY_IMAGE_PATH = @"Image\HCC\PhotoCopyImagesImages\";
            public static string ALUMNAE_PASSEDOUT_IMAGE_PATH = @"Image\HCC\AlumnaePassedoutImages\";
            public static string IQAC_IMAGE_PATH = @"\Image\SJC\IQAC_Uploads\";
            public static string STAFF_SIGN_PATH = @"Image\HCC\StaffSignImages\";
            public static string EXAM_ANSWER_PATH = @"Image\HCC\ExamAnswers\";
            public static string EXAM_STUDENT_LOG = @"Image\HCC\ExamStudentLog\";
            public static string FILE_PATH = @"Image\HCC\StudentImages\";


        }
        public static class MainMenu
        {
            public static string[] Dashboard = { "DSB" };
            public static string[] VirtualStore = { "VST_CAT", "VST_PRD", "VST_CAL", "VST_BNR", "VST_OFF", "VST_ADV", "VST_PRT", "VST_CLS" };
            public static string[] Administration = { "ADM_UD", "ADM_UR", "ADM_SD", "ADM_SS" };
            public static string[] Transaction = { "TRN_TUP", "TRN_WAL", "TRN_BH", "TRN_EAR" };
            public static string[] Notifications = { "NTF_ND", "NTF_MD", "NTF_IF", "NTF_MF" };
            public static string[] Service = { "RSE_RS" };
            public static string[] Reports = { "RPT_R1", "RPT_R2", "RPT_R3" };
        }
       
        /// <summary>
        /// This class contain error log table fields
        /// </summary>
        public class ErrorLog
        {
            public const string TBL_NAME = "TBL_NAME ";
            public const string LOG_ID = "LOG_ID ";
            public const string ERR_METHOD = "ERR_METHOD ";
            public const string CLASS_NAME = "CLASS_NAME ";
            public const string LINE_NO = "LINE_NO ";
            public const string USER_NAME = "USER_NAME ";
            public const string USER_ROLE = "USER_ROLE ";
            public const string DATE_TIME = "DATE_TIME ";
            public const string ERR_SOURCE = "ERR_SOURCE ";
            public const string TARGET_SITE = "TARGET_SITE ";
            public const string MESSAGE = "MESSAGE ";
            public const string STACK_TRACE = "STACK_TRACE ";

        }

        public static class Optimization
        {
            //Product optimization
            public static Int64 PRODUCTMAXSIZE = 500;// maaximum kb for optimization
            public static Int64 PRODUCTMAXWIDTH = 800;
            public static Int64 PRODUCTMAXHEIGHT = 600;

            //Banner optimization
            public static Int64 BANNERMAXSIZE = 512;
            public static Int64 BANNERMAXWIDTH = 1200;
            public static Int64 BANNERMAXHEIGHT = 480;
            //Catelog optimization
            public static Int64 CATELOGMAXSIZE = 512;
            public static Int64 CATELOGMAXWIDTH = 800;
            public static Int64 CATELOGMAXHEIGHT = 200;
            //Advertisment optimization
            public static Int64 ADVERTISMENTMAXSIZE = 512;
            public static Int64 ADVERTISMENTMAXWIDTH = 1200;
            public static Int64 ADVERTISMENTMAXHEIGHT = 480;

        }

     
       
        public static class SESSION_VARIABLES
        {
            // public static string sConnectionString = "CONNECTIONSTRING";

            public const string USER_ID = "USER_ID";
            public const string USERNAME = "USERNAME";
            public const string USER_TYPE = "USER_TYPE";
            public const string USER_NAME = "USER_NAME";
            public const string USER_ROLE_NAME = "USER_ROLE_NAME";
            public const string USER_ROLE_ID = "USER_ROLE_ID";
            public const string MENU_ITEMS = "MENU_ITEMS";
            public const string ACADEMIC_YEAR = "ACADEMIC_YEAR";
            public const string CUR_ACADEMIC_YEAR = "CUR_ACADEMIC_YEAR";
            public const string ACADEMIC_YEAR_NAME = "ACADEMIC_YEAR_NAME";
            public const string CLASS_ID = "CLASS_ID";
            public const string FBCLASS_ID = "FBCLASS_ID";
            public const string DEPARTMENT_ID = "DEPARTMENT_ID";
            public const string COURSE_CODE = "COURSE_CODE";
            public const string USER_INFO = "USER_INFO";
            public const string SHIFT_ID = "SHIFT_ID";
            public const string CLASS_NAME = "CLASS_NAME";
            public const string PHOTO_PATH = "PHOTO_PATH";
            public const string USER_CODE = "USER_CODE";
            public const string COLLEGE_INFO = "COLLEGE_INFO";
            public const string COURSE_ID = "COURSE_ID";
            public const string PHOTO = "PHOTO";
            public const string SEMESTER_ID = "SEMESTER_ID";
            public const string STAFF_ID = "STAFF_ID";
            public const string LAST_INSERT_ID = "LAST_INSERT_ID";
            public const string TABLE_PRIMARY_ID = "TABLE_PRIMARY_ID";
            public const string STUDENT_ID = "STUDENT_ID";
            public const string ACADEMIC_YEAR_ID = "ACADEMIC_YEAR_ID";
            public const string COURSE_ROOT_ID = "COURSE_ROOT_ID";
            public const string CLSCRSSTF_ID = "CLSCRSSTF_ID";
            public const string FACULTY_ID = "FACULTY_ID";
            public const string COURSE_TYPE_ID = "COURSE_TYPE_ID";
            public const string PROGRAMME_ID = "PROGRAMME_ID";
            public const string PROGRAMME_GROUP_ID = "PROGRAMME_GROUP_ID";
            public const string DEGREE_ID = "DEGREE_ID";
            public const string SETTINGS_ID = "SETTINGS_ID";
            public const string ALLOTMENT_ID = "ALLOTMENT_ID";
            public const string REGISTRATION_ID = "REGISTRATION_ID";
            public const string DAY_ORDER = "DAY_ORDER";
            public const string DAY_ORDER_DATE = "DAY_ORDER_DATE";
            public const string ACTIVE_SEMESTER_FOR_STAFF = "ACTIVE_SEMESTER_FOR_STAFF";
            public const string ACTIVE_SEMESTER_FOR_STUDENT = "ACTIVE_SEMESTER_FOR_STUDENT";
            public const string SETTING_ID = "SETTING_ID";
            public const string DEPARTMENT_TEMPLATE_ID = "DEPARTMENT_TEMPLATE_ID";
            public const string TT_TEMP_ID = "TT_TEMP_ID";
            public const string ACTIVE_SEMESTER_TYPE = "ACTIVE_SEMESTER_TYPE";
            public const string PAYMENT_RESPONSE = "PAYMENT_RESPONSE";
            public const string IS_HOLIDAY = "IS_HOLIDAY";
            public const string COLLEGE_DETAILS = "COLLEGE_DETAILS";
            public const string OTP = "OTP";
            public const string ADMITTED_BATCH = "ADMITTED_BATCH";
            public const string CLASS_LEVEL = "CLASS_LEVEL";
            public const string FEEDBACK_ID = "FEEDBACK_ID";
            public const string ACTION_NAME = "ACTION_NAME";
            public const string CONTROLLER_NAME = "CONTROLLER_NAME";

            public const string EMAIL = "EMAIL";
            //public const string CONNECTION_STRING = "CONNECTION_STRING";
            //public const string HEADING1 = "HEADING1";
            //public const string HEADING2 = "HEADING2";
            //public const string SCHOOL_ID = "SCHOOL_ID";
            //public const string SCHOOL_CODE = "SCHOOL_CODE";
            //public const string LOGO_PATH = "LOGO_PATH";
            //public const string ACADEMIC_YEAR = "ACADEMIC_YEAR";
            //public const string ACADEMIC_YEAR_ID = "ACADEMIC_YEAR_ID";

        }

        public static class USER_TYPE
        {
            public const string TEACHING_STAFF = "1";
            public const string NON_TEACHING_STAFF = "2";
            public const string STUDENT = "3";
            public const string EXTERNAL = "4";
        }



       

       
        public static class USER_INFO
        {
            public const string EMPLOYEE_CODE = "ADMISSION_NO";
           
        }
       
        public static class USER_ROLES
        {
            public const string ADMIN = "ADMIN";
            public const string SUPERADMIN = "SUPER ADMIN";
            public const string EMPLOYEE = "EMPLOYEE";
           
        }
       
        public static class MENU_ITEMS
        {
            public const string MENU_ID = "MENU_ID";
            public const string MENU_NAME = "MENU_NAME";
            public const string PARENT_ID = "PARENT_ID";
            public const string CONTROLLER = "CONTROLLER";
            public const string ACTION = "ACTION";
            public const string IS_ACTIVE = "IS_ACTIVE";
            public const string IS_DELETED = "IS_DELETED";
        }

        public static class USER_ACCOUNT
        {
            public const string USER_ACCOUNT_ID = "USER_ACCOUNT_ID";
            public const string USERNAME = "USERNAME";
            public const string PASSWORD = "PASSWORD";
            public const string USER_TYPE = "USER_TYPE";
            public const string USER_TYPE_ID = "USER_TYPE_ID";
            public const string NAME = "NAME";
            public const string EMAIL = "EMAIL";
            public const string MOBILE = "MOBILE";
            public const string LAST_LOGIN = "LAST_LOGIN";
            public const string IS_DELETED = "IS_DELETED";
            public const string IS_ACTIVE = "IS_ACTIVE";
            public const string USER_ID = "USER_ID";
            public const string ROLE = "ROLE";
            public const string PHOTO = "PHOTO";
            public const string CATEGORY = "CATEGORY";
            public const string CONTROLLER_NAME = "CONTROLLER_NAME";
            public const string ACTION_NAME = "ACTION_NAME";


        }
        public static class USER_ROLES_RIGHTS
        {
            public const string USER_RIGHTS_ID = "USER_RIGHTS_ID";
            public const string MENU_ITEM_ID = "MENU_ITEM_ID";
            public const string MODIFY = "MODIFY";
            public const string ROLE_ID = "ROLE_ID";
            public const string ROLE_NAME = "ROLE_NAME";
            public const string IS_ACTIVE = "IS_ACTIVE";
            public const string IS_DELETED = "IS_DELETED";

            // Extra 
            public const string USER_ID = "USER_ID";
            public const string USER_TYPE = "USER_TYPE";
            public const string ACADEMIC_YEAR = "ACADEMIC_YEAR";
        }

     

      
        public static class MODULES
        {
            public const string MODULES_ID = "MODULES_ID";
            public const string MODULE_NAME = "MODULE_NAME";
            public const string IS_DELETED = "IS_DELETED";
            public const string STYLE = "STYLE";
            public const string HAS_SUB = "HAS_SUB";
        }
        
        public class SUB_REQUIREMENT
        {
            public const string REQUIREMENT_ID = "REQUIREMENT_ID";
            public const string REQUIREMENT_NAME = "REQUIREMENT_NAME";
            public const string IS_LOCKED = "IS_LOCKED";
        }




    }
}
