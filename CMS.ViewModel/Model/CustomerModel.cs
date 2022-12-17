using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CMS.ViewModel.Model
{
    public class CustomerModel
    {
        [Key]
        public string STUDENT_ID { get; set; }
        [Required(ErrorMessage = "First name is required !!!")]
        [Display(Name = "FIRST NAME")]
        [StringLength(maximumLength: 40, ErrorMessage = "First name should be minimum 3 and maximum 40", MinimumLength = 3)]
        public string FIRST_NAME { get; set; }
        [Display(Name = "LAST NAME")]
        public string LAST_NAME { get; set; }
        [Display(Name = "GENDER")]
        public string GENDER_ID { get; set; }
        [Display(Name = "COURSE")]
        public string COURSE_ID { get; set; }
        [Display(Name = "DEPARTMENT")]
        public string DEPARTMENT_ID { get; set; }
        [Display(Name = "DOB")]

        public string DOB { get; set; }

        [Display(Name = "E-MAIL")]
        public string EMAIL { get; set; }
        [Display(Name = "BLOOD GROUP")]
        public string BLOOD_GROUP_ID { get; set; }
        [Display(Name = "PLACE OF BIRTH")]
        public string BIRTH_PLACE { get; set; }
        [Display(Name = "RELIGION")]
        public string RELIGION_ID { get; set; }
        [Display(Name = "MOBILE")]
        public string STUDENT_MOBILE { get; set; }
        [Display(Name = "ADMISSION DATE")]
        public string ADMISSION_DATE { get; set; }
        public string STATUS { get; set; }
        public string APPLICATION_NO { get; set; }
        [Display(Name = "REGISTER NO")]
        public string REGISTER_NO { get; set; }
        [Display(Name = "BATCH")]
        public string BATCH_ID { get; set; }
        public string GRADUCATE_YEAR { get; set; }
        [Display(Name = "PERMANENT ADDRESS")]
        public string PERMANENT_ADDRESS { get; set; }
        [Display(Name = "PERMANENT ADDRESS")]

        public string PRESENT_ADDRESS { get; set; }
        [Display(Name = "COUNTRY")]

        public string COUNTRY { get; set; }
        [Display(Name = "STATE")]

        public string STATE { get; set; }
        [Display(Name = "CITY")]

        public string CITY { get; set; }
        public string PINCODE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        [Display(Name = "FATHER'S NAME")]

        public string FATHER_NAME { get; set; }
        [Display(Name = "MOTHER'S NAME")]

        public string MOTHER_NAME { get; set; }
        [Display(Name = "GUARDIAN'S NAME")]

        public string GUARDIAN_NAME { get; set; }
        [Display(Name = "IS GUARDIAN AVAILABLE?")]

        public string IS_GUARDIAN_AVAILABLE { get; set; }
        [Display(Name = "FATHER'S MOBILE NO")]

        public string FATHER_MOBILE { get; set; }
        [Display(Name = "MOTHER'S MOBILE NO")]

        public string MOTHER_MOBILE { get; set; }
        [Display(Name = "GAURDIAN'S MOBILE NO ")]

        public string GUARDIAN_MOBILE { get; set; }
        [Display(Name = "FATHER'S E-MAIL")]

        public string FARTHER_EMAIL { get; set; }
        [Display(Name = "MOTHER'S E-MAIL")]

        public string MOTHER_EMAIL { get; set; }
        [Display(Name = "GUARDIAN'S E-MAIL")]

        public string GUARDIAN_EMAIL { get; set; }
        [Display(Name = "IS STUDENT FIRST LEARNER ?")]

        public string IS_FIRST_LEARNER { get; set; }
        [Display(Name = "IS PHYSICALLY CHALLENGED ?")]

        public string IS_PHYSICALLY_CHALLENGED { get; set; }
        [Display(Name = "ANNUAL INCOME")]
        public string ANNUAL_INCOME { get; set; }
        [Display(Name = "PREVIOUS SCHOOL/COLLEGE")]

        public string LAST_STUDIED_SCHOOL { get; set; }
        public string ADMITTED_COURSE { get; set; }
        [Display(Name = "PERSONAL MARKS OF IDENTIFICATION")]

        public string PERSONAL_MARK1 { get; set; }
        [Display(Name = "PERSONAL MARKS OF IDENTIFICATION")]

        public string PERSONAL_MARK2 { get; set; }
        public string LEAVING_DATE { get; set; }
        public string LEAVING_REASON { get; set; }
        public string TC_ISSUED_DATE { get; set; }
        [Display(Name = "CONDUCT AND CHARACTER")]
        public string CONDUCT_INFO { get; set; }
        [Display(Name = "IMAGE")]
        public string IMG_PATH { get; set; }
        public string FINGER_PRINT { get; set; }
        public string IS_DELETED { get; set; }
        public string ADMINSSION_NO { get; set; }
        [Display(Name = "ROLL NO")]
        public string ROLL_NO { get; set; }
        [Display(Name = "COURSE TYPE")]
        public string COURSE_TYPE { get; set; }
        public string ADMISSION_NO { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string CASTE { get; set; }
        public string OCCUPATION_NAME { get; set; }
        public  string STU_MOBILENO { get; set; }
        public string RELIGION { get; set; }

        public string GENDER_NAME { get; set; }

        public string BLOOD_GROUP_NAME { get; set; }
        public string COMMUNITY { get; set; }
        public string MOTHER_TONGUE_NAME { get; set; }
        public string IDENTIFICATION_MARK1 { get; set; }
        public string IDENTIFICATION_MARK2 { get; set; }
        public string NATIONALITY_NAME { get; set; }
        public string ADMITTED_CLASS { get; set; }
        public string CLASS_NAME { get; set; }
        public string PROGRAMME_NAME { get; set; }
        public string ADDRESS { get; set; }

        public string C_DOOR_DETAIL { get; set; }
        public string C_STREET { get; set; }
        public string C_VILLAGE_AREA { get; set; }
        public string C_POST_PLACE_TOWN { get; set; }
        public string C_TALUK { get; set; }
        public string C_CITY { get; set; }
        
        public string C_PINCODE { get; set; }
        public string C_DISTRICT { get; set; }
        public string COUNTRY_NAME { get; set; }

        public string LAST_STUDIED_PLACE { get; set; }
        public SelectList TestList { get; set; }

    }
    public class ListStudents
    {
        public string STUDENT_ID { get; set; }
        public string ROLL_NO { get; set; }
        public string ADMISSION_NO { get; set; }
        public string FIRST_NAME { get; set; }
        public string DEPARTMENT { get; set; }
        public string GENDER { get; set; }
        public string SHIFT_NAME { get; set; }
        public string CLASS_NAME { get; set; }
        public string IS_LEFT { get; set; }
        public string REGISTER_NO { get; set; }
        public string PROGRAMME_NAME { get; set; }
        public string BATCH { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CLASS_ID { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string RFID { get; set; }
        public string PHOTO { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }
        public string SEMESTER_ID { get; set; }
        public string STATUS { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string FATHER_NAME { get; set; }
        public string ADDRESS { get; set; }
        public string STU_MOBILENO { get; set; }
        public string RUN_NUMBER { get; set; }
        public string ATTENDANCE_PERCENTAGE { get; set; }
        public string STUDENT_COUNT { get; set; }
        public string EXAM_SETTING_ID { get; set; } 
        public string FOLIO_NUMBER { get; set; }  
        public string FOLIO_ID { get; set; }
        public string CERTIFICATE_TYPE { get; set; }
        public string BATCH_ID { get; set; }
        public string APPLICATION_TYPE { get; set; }
        public string DUMMY_REGISTER_NO { get; set; }
        public string DUMMY_REGISTER_NUMBER { get; set; }
        public string AUTO_GENERATE_NUMBERS_ID { get; set; }
        

        public string S_CLASS_ID { get; set; }
        public string CLASS { get; set; }
        public string SHIFT { get; set; }
        public string PROGRAMME_MODE { get; set; }
        public string TAMIL_NAME { get; set; }
        public string LEAVING_CLASS { get; set; }
        public string LEAVING_YEAR { get; set; }
        public string IS_COMPLETED { get; set; }
        public string IS_DISCONTINUED { get; set; }
        public string LEAVING_REASON { get; set; }
        public string LEAVIN_GDATE { get; set; }
        public string READMITTED_CLASS { get; set; }
        public string EXAM_DEFALTER_ID { get; set; }
        public string EXAM_NAME { get; set; }
        public string BEGIN_YEAR { get; set; }
        public string EXPIRED_YEAR { get; set; }
        public string CERTIFICATE_NAME { get; set; }
        public string CERTIFICATE1 { get; set; }
        public string CERTIFICATE2 { get; set; }
        public string G_NUMBER { get; set; }
        public string CERTIFICATE_DATE { get; set; }
        public string HSC_TC_NUMBER { get; set; }

        


        public string FR_OCCUPATION { get; set; }
        public string LAST_SCHOOL_OR_COLLEGE { get; set; }
        public string LAST_STUDIED_PLACE { get; set; }
        public string ADMISSION_DATE { get; set; }


    }
    public class AcademicDetails
    {
        public string RegisterNo { get; set; }
        public string RollNo { get; set; }
        public string URollNo { get; set; }
        public string AdmissionNo { get; set; }
        public string AdmissionDate { get; set; }
        public string AdmittedClass { get; set; }
        public string sRegisterDate { get; set; }
        public string Remarks { get; set; }
        public string TCSerialNo { get; set; }
        public string Class { get; set; }
        public string Department { get; set; }
        public string Program { get; set; }
        public string Batch { get; set; }
        public string Shift { get; set; }
        public string Stu_Email { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string STUDENT_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string STU_CLASS_ID { get; set; }
        public string Role { get; set; }
        public string UserType { get; set; }
        public string IsLeft { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string PROGRAMME_MODE { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string PHOTO { get; set; }
        public string CurrentBatch { get; set; }
    }
    public class IF_STUDENT_EXITS
    {
        public string STUDENT_ID { get; set; }
    }
    public class HOSTEL_STUDENT_INFO_COPY
    {
        public string STU_HOSTEL_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string HOSTEL_ID { get; set; }
        public string BLOCK_ID { get; set; }
        public string ROOM_NO { get; set; }
        public string COT_NO { get; set; }
        public string BLOCK_INCHARGE { get; set; }
        public string ADMITTED_YEAR { get; set; }
        public string ADMITTED_DATE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_LEFT { get; set; }
        public string IS_DELETED { get; set; }
        public string FIRST_NAME { get; set; }
        public string ROLL_NO { get; set; }
        public string REGISTER_NO { get; set; }
        public string CLASS_CODE { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string SHIFT_NAME { get; set; }
        public string PROGRAMME_MODE { get; set; }
    }
    // Privious Qualification ..
    public class PriviousQualification
    {
        public string LSchool { get; set; }
        public string LStudied { get; set; }
        public string ExamPassed { get; set; }
        public string LstudiedClass { get; set; }
    }
    // Address Details ...
    public class StudentAddress
    {
        public string CDoorDetail { get; set; }

        public string CStreet { get; set; }

        public string CVillage { get; set; }

        public string CPostPlace { get; set; }

        public string CTaluk { get; set; }

        public string CCity { get; set; }

        public string CDistrict { get; set; }

        public string Cpincode { get; set; }

        public string CCountry { get; set; }

        public string PDoorDetails { get; set; }

        public string PStreet { get; set; }

        public string PVillage { get; set; }

        public string PPostPlace { get; set; }

        public string PTaluk { get; set; }

        public string PCity { get; set; }

        public string PDistrict { get; set; }

        public string PPincode { get; set; }

        public string PCountry { get; set; }
    }

    // Student Parents Details...
    public class ParentsDetails
    {
        public string FatherName { get; set; }

        public string FDateOfBirth { get; set; }

        public string MotherName { get; set; }

        public string MDateOfBirth { get; set; }

        public string fBusinessContact { get; set; }

        public string FMobile { get; set; }

        public string FPassport { get; set; }

        public string mBusinessContact { get; set; }

        public string MMobile { get; set; }

        public string MPassport { get; set; }

        public string FPhoto { get; set; }

        public string MPhoto { get; set; }

        public string FIncome { get; set; }

        public string MIncome { get; set; }

        public string FDateOfExpire { get; set; }

        public string MDateOfExpire { get; set; }

        public string FEmail { get; set; }

        public string MEmail { get; set; }

        public string FOccupation { get; set; }

        public string FEducation { get; set; }

        public string MOccupation { get; set; }

        public string MEducation { get; set; }

        public string FNationality { get; set; }

        public string MNationality { get; set; }
    }

    // Student personal Info
    public class StudentPersonal
    {

        public string firstName { get; set; }

        public string LastName { get; set; }

        public string Caste { get; set; }

        public string DateOfBirth { get; set; }

        public string AnnulIncome { get; set; }

        public string ResidencyNo { get; set; }

        public string PossportNo { get; set; }

        public string PhotoPath { get; set; }

        public string VisaIssueDate { get; set; }

        public string VisaExpiryDate { get; set; }

        public string VisaSponser { get; set; }

        public string VisaNumber { get; set; }

        public string Identity1 { get; set; }

        public string Identity2 { get; set; }

        public string HomePhone { get; set; }

        public string AadharNumber { get; set; }

        public string StuMobileNo { get; set; }

        public string PlaceOfBirth { get; set; }

        public string MaritalStatus { get; set; }

        public string Gender { get; set; }

        public string Community { get; set; }

        public string MotherTongue { get; set; }

        public string SecondLanguage { get; set; }

        public string BloodGroup { get; set; }

        public string Religion { get; set; }

        public string Nationality { get; set; }

        public string ModeOfTransport { get; set; }

        public string SpokenLanguage { get; set; }

        public string FirstLanguage { get; set; }

        public string SpecillyAblled { get; set; }

        public string ResidencyType { get; set; }
        public string Role { get; set; }
        public string UserType { get; set; }
        public string Tamilname { get; set; }
    }
    // Student Activity ..
    public class StudentActivity
    {
        public string PostHeld { get; set; }
        public string ActivityId { get; set; }

        public string InitiativeShown { get; set; }

        public string Participation { get; set; }

        public string DateFrom { get; set; }

        public string DateTo { get; set; }

        public string ExtraActivity { get; set; }

        public string positionObtained { get; set; }

        public string StuActivity { get; set; }

        public string ActivityImg1 { get; set; }

        public string ActivityImg2 { get; set; }

        public string ActivityImg3 { get; set; }
    }
    // Stuudent  Certificate ...
    public class StudentCertificate
    {
        //public string CERTIFICATE_ID { get; set; }
        //public string STUDENT_ID { get; set; }

        public string CertificateNo { get; set; }
        public string CeretificateID { get; set; }

        public string RecieveDate { get; set; }

        public string GivenDate { get; set; }

        public string Archive { get; set; }

        public string Purpose { get; set; }

        public string RegisterNo { get; set; }

        public string CertificateName { get; set; }
    }
    // Student Courses ...
    public class StudentCourses
    {
        public string program { get; set; }
        public string Class { get; set; }
        public string Part { get; set; }
        public string MainSubject { get; set; }
        public string Allied1 { get; set; }
        public string Allied2 { get; set; }
        public string Allied3 { get; set; }
        public string Allied4 { get; set; }
        public string Elective1 { get; set; }
        public string Elective2 { get; set; }
        public string Elective3 { get; set; }
        public string Elective4 { get; set; }
        public string SplSub { get; set; }
    }
    // Account Info
    public class StudentAccountInfo
    {
        public string AccountNo { get; set; }

        public string IfscCode { get; set; }

        public string MicrCode { get; set; }
    }
    // Student Counseling ...
    public class StudentCounseling
    {
        public string CounsellingId { get; set; }
        public string Dateofcounseling { get; set; }

        public string Duration { get; set; }

        public string Remarks { get; set; }

        public string Commands { get; set; }

        public string Batch { get; set; }
    }
    // Student Incident ..
    public class StudentIncident
    {
        public string IncidentId { get; set; }
        public string DateOfIncident { get; set; }
        public string TimeOfIncident { get; set; }
        public string PlaceOfIncident { get; set; }
        public string FirstAidDone { get; set; }
        public string InformedToParents { get; set; }
        public string DateInformed { get; set; }
        public string IncidentDetails { get; set; }
    }

    // Student Sibling .....
    public class StudentSibling
    {
        public string SiblingId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string InstituteName { get; set; }
        public string Program { get; set; }
        public string Qualification { get; set; }
        public string Employed { get; set; }
        public string DateofBirth { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public string MonthlyIncome { get; set; }
        public string ProgName { get; set; }
        public string Is_Same_Collage { get; set; }
    }

    // Student Talents ...
    public class StudentTalents
    {
        public string TalentsId { get; set; }
        public string Date { get; set; }
        public string TalentArea { get; set; }
        public string TalentActivityType { get; set; }
        public string TalentDiscription { get; set; }
        public string Status { get; set; }
        public string Grade { get; set; }
        public string Remarks { get; set; }
    }

    // Student College History ....
    public class StudentClgHistry
    {
        public string SchoolName { get; set; }
        public string Grade { get; set; }
        public string EntryDate { get; set; }
        public string ExitDate { get; set; }
        public string Age { get; set; }
        public string AcademicLevels { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string OfficialWebsite { get; set; }
        public string Curriculum { get; set; }
        public string Reasonforwidthdrawel { get; set; }
        public string LastAttendenceDate { get; set; }
    }

    // Student IssueEtc ...
    public class StudentIssueEtc
    {
        public string sTCIssueId { get; set; }
        public string TCproduceNumber { get; set; }
        public string TCProduceDate { get; set; }
        public string TCIssueNumber { get; set; }
        public string TCIssueDate { get; set; }
    }

    // Student Achievements ...
    public class StudentAchievements
    {
        public string Achievements { get; set; }
        public string Class { get; set; }
        public string Date { get; set; }
        public string ImgPath { get; set; }
        public string Activity { get; set; }
    }

    // Student Medical ...
    public class StudentMedical
    {
        public string sMedicalId { get; set; }
        public string Allergies { get; set; }
        public string DocterNote { get; set; }
        public string MedicalDate { get; set; }
        public string MedicalCondition { get; set; }
        public string Vaccination { get; set; }
    }

    // Student Orivious Qualification ..
    public class StudentPriviousQualification
    {
        [Display(Name = "Privious School/College")]
        public string LAST_SCHOOL_OR_COLLEGE { get; set; }
        [Display(Name = "Privious Studied Place")]
        public string LAST_STUDIED_PLACE { get; set; }
        [Display(Name = "Exam Passed")]
        public SelectList EXAM_PASSED { get; set; }
        [Display(Name = "Privious Studied Class")]
        public string LAST_STUDIED_CLASS { get; set; }

    }

    // TransferCertificate ...
    public class StudentTransferCertificate
    {
        public string StudentId { get; set; }
        public string SerialNo { get; set; }
        public string AdmissionNo { get; set; }
        [Display(Name = "1. a) Name of the College")]
        public string CollegeName { get; set; }
        public string ClassId { get; set; }
        [Display(Name = " b) Name of the District")]
        public string DistrictName { get; set; }
        [Display(Name = "2. Name of the student(in BLOCK LETTERS) as entered in +2 or equivalent certificate")]
        public string StudentName { get; set; }
        [Display(Name = "3. Name of the Parent / Guardian")]
        public string ParentName { get; set; }
        public string Guardian { get; set; }
        [Display(Name = "4. Nationality and Religion")]
        public string Nationality { get; set; }
        public string NationalityId { get; set; }
        public string Religion { get; set; }
        public string ReligionId { get; set; }
        [Display(Name = "5. Caste and Community")]
        public string Caste { get; set; }
        public string Community { get; set; }
        public string CommunityId { get; set; }
        [Display(Name = "6. Sex")]
        public string Sex { get; set; }
        public string SexId { get; set; }
        [Display(Name = "7. Date of Birth(in figures & words) as entered in Admission Register")]
        public string DateOfBirth { get; set; }
        [Display(Name = "8. Personal Marks of Identification")]
        public string IdentificationMark1 { get; set; }
        public string IdentificationMark2 { get; set; }
        [Display(Name = "9. Date of Admission & Class which is admitted")]
        public string AdmissionDate { get; set; }
        public string AdmittedClass { get; set; }
        [Display(Name = "10. a) Class at the time of leaving")]
        public string LeavingTime { get; set; }
        [Display(Name = "b) Courses Offered - Main")]
        public string MainCourse { get; set; }
        [Display(Name = "Allied")]
        public string AlliedCourse { get; set; }
        [Display(Name = "11. Whether the student has paid all the fees due to the College")]
        public string FeesPaid { get; set; }
        [Display(Name = "12. Whether the student was in receipt of any scholarship or any educational concessions")]
        public string StuScholarship { get; set; }
        [Display(Name = "13. Date on which the student left the College")]
        public string LeavingDate { get; set; }
        [Display(Name = "14. The Student's Contact and Character")]
        public string Conduct { get; set; }
        [Display(Name = "15. Date on which appication for Transfer Certificate was made by the sudent")]
        public string StuTCApplyDate { get; set; }
        [Display(Name = "16. Date of the Transfer Certificate")]
        public string TCIssueDate { get; set; }
        [Display(Name = "17. Course of Study")]
        public string AcademicYears { get; set; }
        public string AcademicYear { get; set; }
        public string ClassesStudied { get; set; }
        public string FirstLanguage { get; set; }
        public string DateToWords { get; set; }
        public string CertificateId { get; set; }
        public string sResult { get; set; }
        public string MediumofInstruction { get; set; }
        public string SchoolOrCollege { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string beginyear { get; set; }
        public string endyear { get; set; }
        public string department { get; set; }
        public string CLASS_YEAR { get; set; }

    }

    // TreansferCertificate ..
    public class UpdateTransferCertirficate
    {
        public string CERTIFICATE_ID { get; set; }
        public string SERIAL_NO { get; set; }
        public string ADMISSION_NO { get; set; }
        public string STUDENT_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string GENDER { get; set; }
        public string RELIGION { get; set; }
        public string NATIONALITY { get; set; }
        public string CASTE { get; set; }
        public string COMMUNITY { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string ADMITTED_CLASS { get; set; }
        public string IDENTIFICATION_MARK1 { get; set; }
        public string IDENTIFICATION_MARK2 { get; set; }
        public string MAIN_COURSE { get; set; }
        public string ALLIED { get; set; }
        public string FEE_PAID { get; set; }
        public string SCHOLAR_SHIP { get; set; }
        public string LEAVING_DATE { get; set; }
        public string REASON_FOR_LEAVING { get; set; }
        public string LEAVING_CLASS { get; set; }
        public string CONDUCT { get; set; }
        public string TC_APPLIED_DATE { get; set; }
        public string TC_GIVEN_DATE { get; set; }
        public string FATHER_NAME { get; set; }
        public string GUARDIAN_NAME { get; set; }
        public string ACADEMIC_YEARS { get; set; }
        public string CLASSES_STUDEIED { get; set; }
        public string FIRST_LANGUAGE { get; set; }
        public string DATETOWORDS { get; set; }
    }

    // Conduct Certificate ..
    public class StudentConductCertificate
    {
        [Display(Name = "Program")]
        public string ProgramId { get; set; }
        [Display(Name = "Class")]
        public string ClassId { get; set; }
        [Display(Name = "Student")]
        public string StudentId { get; set; }
    }

    // Course Certificate ..
    public class StudentCourseCertificate
    {
        [Display(Name = "Program")]
        public string ProgramId { get; set; }
        [Display(Name = "Class")]
        public string ClassId { get; set; }
        [Display(Name = "Student")]
        public string StudentId { get; set; }
    }

    // Bonafide Certificate ..
    public class StudentBonafideCertificate
    {
        public string ProgramId { get; set; }
        public string ClassId { get; set; }
        public string StudentId { get; set; }
    }

    // DAY ORDER CALENDER
    public class DayOrderCalender
    {
        public string DAY_ID { get; set; }
        public string DAY_ORDER_ID { get; set; }
        public string DAY_TYPE { get; set; }
        public string DAY_ORDER { get; set; }
        public string DAY_ORDER_MONTH { get; set; }
        public string IS_HOLIDAY { get; set; }
        public string IS_DELETED { get; set; }
        public string COLOR { get; set; }
        public string DAY_ORDER_DATE { get; set; }
        public string DAY_ORDER_END_DATE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }

    }
    // Fetch Events ...
    public class FETCH_CALENDER_EVENTS
    {
        public string EVENT_ID { get; set; }
        public string DAY_ID { get; set; }
        public string DAY_ORDER_ID { get; set; }
        public string SYEAR { get; set; }
        public string SMONTH { get; set; }
        public string SDAY { get; set; }
        public string EYEAR { get; set; }
        public string EMONTH { get; set; }
        public string EDAY { get; set; }
        public string DAY_ORDER { get; set; }
        public string RESPONSIBLE_STUDENT { get; set; }
        public string RESPONSIBLE_STAFF { get; set; }
        public string ACCESS_CATEGORY { get; set; }
        public string VISIBILITY_TYPE { get; set; }
        public string COLOR { get; set; }
        public string IS_HOLIDAY { get; set; }
        public string STAFF_ID { get; set; }
    }
    public class CALENDER_EVENTS
    {
        //Event Get By Single Query
        public string EVENT_ID { get; set; }
        public string EVENT_NAME { get; set; }
        public string DAY_ID { get; set; }
        public string EVENT_END_DATE { get; set; }
        public string EVENT_START_DATE { get; set; }
        public string EVENT_TYPE { get; set; }
        public string DAY_ORDER { get; set; }
        public string EVENT_DESCRIPTION { get; set; }
        public string EVENT_DEPARTMENT { get; set; }
        public string USER_ID { get; set; }
        public string RESPONSIBLE_STAFF { get; set; }
        public string RESPONSIBLE_STUDENT { get; set; }
        public string EVENT_REPORT { get; set; }
        public string EVENT_PARTICIPANTS { get; set; }
        public string EVENT_STATUS { get; set; }
        public string EVENT_BUDGET { get; set; }
        public string AMOUNT_SPENT { get; set; }
        public string HOLIDAY_TYPE { get; set; }
        public string DAY_ORDER_MONTH { get; set; }
        public string IS_HOLIDAY { get; set; }
        public string COLOR { get; set; }
        public string STAFF_CATEGORY { get; set; }
        public string ACCESS_VISIBILITY { get; set; }
        public string VIEW_MANAGE { get; set; }
        public string STAFF_ID { get; set; }
    }

    // Fetch Student/Staff
    public class FetchStudnetOrStaff
    {
        public string STUDENT_ID { get; set; }
        public string STAFF_ID { get; set; }
    }
    // Calender ..
    public class Calender
    {
        public string CALENDER_ID { get; set; }
        public string EVENT_TITLE { get; set; }
        public string SYEAR { get; set; }
        public string SMONTH { get; set; }
        public string SDAY { get; set; }
        public string EYEAR { get; set; }
        public string EMONTH { get; set; }
        public string EDAY { get; set; }
        public string DESCRIPTION { get; set; }
        //public string IS_ACTIVE{ get; set; }
        //public string IS_DELETED{ get; set; }
        public string COLOR { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
    /// <summary>
    /// Student UI Class
    /// </summary>
    // Academic Details ...
    public class StuAcadamicInfo
    {
        [Display(Name = "Register No")]
        public string REGISTER_NO { get; set; }
        [Display(Name = "Roll No")]
        public string ROLL_NO { get; set; }
        [Display(Name = "Examination Roll No")]
        public string UNIVERSITY_ROLLNO { get; set; }
        [Display(Name = "Student E-Mail")]
        public string STU_EMAIL { get; set; }
        [Display(Name = "Admission No")]
        public string ADMINSSION_NO { get; set; }
        [Display(Name = "Admission Date")]
        public string ADMISSIONDATE { get; set; }
        [Display(Name = "Admitted Class")]
        public SelectList ADMITTED_CLASS { get; set; }
        [Display(Name = "Register Date")]
        public string STUDENTREGISTEREDDATE { get; set; }
        [Display(Name = "Remarks")]
        public string REMARKS { get; set; }
        [Display(Name = "TC Serial No")]
        public string TC_SERIAL_NUMBER { get; set; }
        [Display(Name = "Class")]
        public SelectList CLASS_ID { get; set; }
        [Display(Name = "Department")]
        public SelectList DEPT_ID { get; set; }
        [Display(Name = "Program")]
        public SelectList PROGRAM_ID { get; set; }
        [Display(Name = "Batch")]
        public SelectList BATCH { get; set; }
        [Display(Name = "Academic Mentor")]
        public SelectList ACADEMIC_MENTOR { get; set; }
        [Display(Name = "Shift")]
        public SelectList SHIFT { get; set; }
        public SelectList Role { get; set; }
        public SelectList UserType { get; set; }
        [Display(Name = "Is Left")]
        public string IsLeft { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
    }

    // Personal Details ...
    public class StuPersonalInfo
    {
        public string STUDENT_ID { get; set; }
        [Display(Name = "First Name")]
        public string FIRSTNAME { get; set; }
        [Display(Name = "Last Name")]
        public string LASTNAME { get; set; }
        [Display(Name = "Tamil Name")]
        public string TAMILNAME { get; set; }
        [Display(Name = "Caste")]
        public string CASTE { get; set; }
        [Display(Name = "Date Of Birth")]
        public string DATEOFBIRTH { get; set; }
        [Display(Name = "Annual Income")]
        public string ANNUALINCOME { get; set; }
        [Display(Name = "Residence No")]
        public string RESIDENCENO { get; set; }
        [Display(Name = "Passport No")]
        public string PASSPORTNUMBER { get; set; }
        [Display(Name = "Photo")]
        public string PHOTOPATH { get; set; }
        [Display(Name = "Role")]
        public SelectList Role { get; set; }
        [Display(Name = "User Type")]
        public SelectList UserType { get; set; }
        [Display(Name = "Visa Issue Date")]
        public string VISAISSUEDATE { get; set; }
        [Display(Name = "Visa Expiry Date")]
        public string VISAEXPIRYDATE { get; set; }
        [Display(Name = "Visa Sponsor")]
        public string VISASPONSOR { get; set; }
        [Display(Name = "Visa No")]
        public string VISANUMBER { get; set; }
        [Display(Name = "Identification Mark1")]
        public string IDENTIFICATIONMARK1 { get; set; }
        [Display(Name = "Identification Mark2")]
        public string IDENTIFICATIONMARK2 { get; set; }
        [Display(Name = "Contact Number")]
        public string HOMEPHONE { get; set; }
        [Display(Name = "Aadhar No")]
        public string AADHARNUMBER { get; set; }
        [Display(Name = "Student Mobile No")]
        public string STUMOBILENO { get; set; }
        [Display(Name = "Place Of Birth")]
        public string PLACEOFBIRTH { get; set; }
        [Display(Name = "Marital Status")]
        public SelectList MARITALSTATUS { get; set; }
        [Display(Name = "Gender")]
        public SelectList GENDERID { get; set; }
        [Display(Name = "Community")]
        public SelectList COMMUNITY { get; set; }
        [Display(Name = "Mother Tongue")]
        public SelectList MOTHERTONGUE { get; set; }
        [Display(Name = "Second Language")]
        public SelectList SECONDLANGUAGE { get; set; }
        [Display(Name = "Blood Group")]
        public SelectList BLOODGROUP { get; set; }
        [Display(Name = "Religion")]
        public SelectList RELIGION { get; set; }
        [Display(Name = "Nationality")]
        public SelectList NATIONALITY { get; set; }
        [Display(Name = "Mode OF Transport")]
        public SelectList MODEOFTRANSPORT { get; set; }
        [Display(Name = "Spoken Language")]
        public SelectList SPOKENLANGUAGE { get; set; }
        [Display(Name = "First Language")]
        public SelectList FIRSTLANGUAGE { get; set; }
        [Display(Name = "Specially Abled")]
        public SelectList SPECIALLYABLED { get; set; }
        [Display(Name = "Residency Type")]
        public SelectList RESIDENCYTYPE { get; set; }
        public string TYPE { get; set; }
        public string FREQUENCY { get; set; }
    }

    // Parents Details ...
    public class StuParentsInfo
    {
        [Display(Name = "Father's Name")]
        public string FATHER_NAME { get; set; }
        [Display(Name = "Date Of Birth")]
        public string FDATEOFBIRTH { get; set; }
        [Display(Name = "Mother's Name")]
        public string MOTHER_NAME { get; set; }
        [Display(Name = "Date Of Birth")]
        public string MDATEOFBIRTH { get; set; }
        [Display(Name = "Office Contact")]
        public string FR_BUSINESS_PHONE { get; set; }
        [Display(Name = "Contact Number")]
        public string FR_MOBILE { get; set; }
        [Display(Name = "Father's Passport No")]
        public string FR_PASSPORT_NUMBER { get; set; }
        [Display(Name = "Office Contact")]
        public string MO_BUSINESS_PHONE { get; set; }
        [Display(Name = "Contact Number")]
        public string MO_MOBILE { get; set; }
        [Display(Name = "Passport No")]
        public string MO_PASSPORT_NUMBER { get; set; }
        [Display(Name = "Father's Photo")]
        public string FATHER_PHOTO { get; set; }
        [Display(Name = "Mother's Photo")]
        public string MOTHER_PHOTO { get; set; }
        [Display(Name = "FATHER'S BUSINESS POST BOX")]
        public string FR_BUSINESS_PO_BOX { get; set; }
        [Display(Name = "MOTHER'S BUSINESS POST BOX")]
        public string MO_BUSINESS_PO_BOX { get; set; }

        [Display(Name = "Annual Income")]
        public string FR_INCOME { get; set; }
        [Display(Name = "Annual Income")]
        public string MO_INCOME { get; set; }
        [Display(Name = "Date Of Expiry")]
        public string FRDATEOFEXPIRY { get; set; }
        [Display(Name = "Date Of Expiry")]
        public string MODATEOFEXPIRY { get; set; }

        [Display(Name = "Father's Email")]
        public string FR_EMAIL { get; set; }
        [Display(Name = "Mother's Email")]
        public string MO_EMAIL { get; set; }
        [Display(Name = "Father's Occupation")]
        public SelectList FR_OCCUPATION { get; set; }
        [Display(Name = "Father's Education")]
        public SelectList FR_EDUCATION { get; set; }
        [Display(Name = "Mother's Occupation")]
        public SelectList MO_OCCUPATION { get; set; }
        [Display(Name = "Mother's Education")]
        public SelectList MO_EDUCATION { get; set; }
        [Display(Name = "Father's Nationality")]
        public SelectList FR_NATIONALITY { get; set; }
        [Display(Name = "Mother's Nationality")]
        public SelectList MO_NATIONALITY { get; set; }
    }

    // Address Details ..
    public class StuAddressInfo
    {
        [Display(Name = "Door Details")]
        public string C_DOOR_DETAIL { get; set; }
        [Display(Name = "Street")]
        public string C_STREET { get; set; }
        [Display(Name = "Village")]
        public string C_VILLAGE_AREA { get; set; }
        [Display(Name = "Post Area")]
        public string C_POST_PLACE_TOWN { get; set; }
        [Display(Name = "Taulk")]
        public string C_TAULK { get; set; }
        [Display(Name = "City")]
        public string C_CITY { get; set; }
        [Display(Name = "District")]
        public String C_DISTRICT { get; set; }
        [Display(Name = "PinCode")]
        public string C_PINCODE { get; set; }
        [Display(Name = "Country")]
        public SelectList C_COUNTRY { get; set; }
        [Display(Name = "Door Details")]
        public string P_DOOR_DETAIL { get; set; }
        [Display(Name = "Street")]
        public string P_STREET { get; set; }
        [Display(Name = "Village")]
        public string P_VILLAGE_AREA { get; set; }
        [Display(Name = "Post Area")]
        public string P_POST_PLACE_TOWN { get; set; }
        [Display(Name = "Taluk")]
        public string P_TAULK { get; set; }
        [Display(Name = "City")]
        public string P_CITY { get; set; }
        [Display(Name = "District")]
        public string P_DISTRICT { get; set; }
        [Display(Name = "PinCode")]
        public string P_PINCODE { get; set; }
        [Display(Name = "Country")]
        public SelectList P_COUNTRY { get; set; }
    }

    // Activities Details ..
    public class StuActivitiesInfo
    {
        [Display(Name = "Post Held")]
        public string POST_HELD { get; set; }
        [Display(Name = "Initiative Shown")]
        public string INITIATIVE_SHOWN { get; set; }
        [Display(Name = "Participation")]
        public string PARTICIPATION { get; set; }
        [Display(Name = "Date From")]
        public string DATE_FROM { get; set; }
        [Display(Name = "Date To")]
        public string DATE_TO { get; set; }
        [Display(Name = "Extra Activity")]
        public string EXTRA_ACTIVITY { get; set; }
        [Display(Name = "Position Obtained")]
        public string POSITION_OBTAINED { get; set; }
        [Display(Name = "Activity")]
        public SelectList ACTIVITY { get; set; }
        [Display(Name = "Activity Image 1")]
        public string ACTIVITY_IMAGE1 { get; set; }
        [Display(Name = "Activity Image 2")]
        public string ACTIVITY_IMAGE2 { get; set; }
        [Display(Name = "Activity Image 3")]
        public string ACTIVITY_IMAGE3 { get; set; }
    }

    // Certificate Details ...
    public class StuCertificateInfo
    {
        [Display(Name = "CERTIFICATE NUMBER")]
        public string CERTIFICATE_NO { get; set; }
        [Display(Name = "RECEIVED DATE")]
        public string RECEIVEDDATE { get; set; }
        [Display(Name = "GIVEN DATE")]
        public string GIVENDATE { get; set; }
        [Display(Name = "ARCHIVE")]
        public SelectList ARCHIVE { get; set; }
        [Display(Name = "PURPOSE")]
        public string PURPOSE { get; set; }
        [Display(Name = "REGISTER NUMBER")]
        public string REGISTER_NUMBER { get; set; }
        [Display(Name = "CERTIFICATE NAME")]
        public string CERTIFICATE_NAME { get; set; }
    }

    // Account Details ...
    public class StuAccountInfo
    {
        [Display(Name = "Account No")]
        public string ACCOUNT_NO { get; set; }
        [Display(Name = "Ifsc Code")]
        public string IFSC_CODE { get; set; }
        [Display(Name = "Micr Code")]
        public string MICR_CODE { get; set; }
    }

    //Counselling Details ...
    public class StuCounsellingInfo
    {
        [Display(Name = "Date of Counseling")]
        public string DOC { get; set; }
        [Display(Name = "Duration")]
        public string DURATION { get; set; }
        [Display(Name = "Remarks")]
        public string CREMARKS { get; set; }
        [Display(Name = "Comments")]
        public string COMMENTS { get; set; }
        [Display(Name = "Batch")]
        public SelectList CBATCH { get; set; }
    }

    // Incident Details ..
    public class StuIncidentInfo
    {
        [Display(Name = "Date Of Incident")]
        public string DATEOFINCIDENT { get; set; }
        [Display(Name = "Time Of Incident")]
        public string TIME_OF_INCIDENT { get; set; }
        [Display(Name = "Place Of Incident")]
        public string PLACE_OF_INCIDENT { get; set; }
        [Display(Name = "FirstAid Done")]
        public string FIRST_AID_DONE { get; set; }
        [Display(Name = "Informed To Parents")]
        public SelectList INFORMED_TO_PARENTS { get; set; }
        [Display(Name = "Date Of Informed")]
        public string DATEINFORMED { get; set; }
        [Display(Name = "Incident Details")]
        public string INCIDENT_DETAILS { get; set; }
    }

    // Sibling Details ...
    public class StuSiblingInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Institute_Name { get; set; }
        public SelectList Program { get; set; }
        public string Qualification { get; set; }
        public SelectList Employed { get; set; }
        public string DateofBirth { get; set; }
        [Display(Name = "Gender")]
        public SelectList Gender { get; set; }
        public SelectList Occupation { get; set; }
        public string Monthly_Income { get; set; }
        public string ProgName { get; set; }
        public SelectList Is_Same_Collage { get; set; }
    }

    // Talents Detais .,,
    public class StuTalentsInfo
    {
        public string Date { get; set; }
        [Display(Name = "Talent Area")]
        public SelectList TalentArea { get; set; }
        [Display(Name = "Talent Activity Type")]
        public SelectList TalentActivityType { get; set; }
        [Display(Name = "Talent Discription")]
        public string TalentDiscription { get; set; }
        public string Status { get; set; }
        public SelectList Grade { get; set; }
        public string Remarks { get; set; }
    }

    // College History Details ..
    public class StuClgHistoryInfo
    {
        [Display(Name = "School Name")]
        public string SchoolName { get; set; }
        [Display(Name = "Grade")]
        public SelectList CGrade { get; set; }
        [Display(Name = "Entry Date")]
        public string EntryDate { get; set; }
        [Display(Name = "Exit Date")]
        public string ExitDate { get; set; }
        [Display(Name = "Age")]
        public int CAge { get; set; }
        [Display(Name = "Academic Levels")]
        public string AcademicLevels { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "Country")]
        public SelectList Country { get; set; }
        [Display(Name = "Official Website")]
        public string OfficialWebsite { get; set; }
        [Display(Name = "Curriculum")]
        public string Curriculum { get; set; }
        [Display(Name = "Reason For Widthdrawel")]
        public string Reasonforwidthdrawel { get; set; }
        [Display(Name = "Last Attendentce Date")]
        public string LastAttendenceDate { get; set; }
    }

    // Tc issue etc Details ...
    public class TcIssueEtcInfo
    {
        [Display(Name = "TC Produce Number")]
        public string TCproduceNumber { get; set; }
        [Display(Name = "TC Produce Date")]
        public string TCProduceDate { get; set; }
        [Display(Name = "TC Issue Number")]
        public string TCIssueNumber { get; set; }
        [Display(Name = "TC Produce Date")]
        public string TCIssueDate { get; set; }
    }

    // Achivement Details ...
    public class StuAchivementInfo
    {
        [Display(Name = "Achievements")]
        public string ACHIEVEMENTS { get; set; }
        [Display(Name = "Class")]
        public SelectList ACLASSID { get; set; }
        [Display(Name = "Date")]
        public string DATE { get; set; }
        [Display(Name = "Img Path")]
        public string IMAGE_PATH { get; set; }
        [Display(Name = "Activity")]
        public SelectList AACTIVITY { get; set; }
    }

    // Medical Details ....
    public class StuMedicalInfo
    {
        public string Allergies { get; set; }
        public string DocterNote { get; set; }
        public string MedicalDate { get; set; }
        public string MedicalCondition { get; set; }
        public string Vaccination { get; set; }
    }

    // TransferCertificate ...
    public class TransferCertificate
    {
        public SelectList ProgrammeMode { get; set; }
        [Display(Name = "Apllication Type")]
        public SelectList ClassLevel { get; set; }
        [Display(Name = "Department")]
        public SelectList Department { get; set; }
        [Display(Name = "Program")]
        public SelectList ProgramName { get; set; }
        [Display(Name = "Class")]
        public SelectList ClassName { get; set; }
        [Display(Name = "Shift")]
        public SelectList ShiftList { get; set; }
        [Display(Name = "Student")]
        public SelectList StuName { get; set; }
        public string SerialNo { get; set; }
        public string AdmissionNo { get; set; }
        [Display(Name = "1. a) Name of the College")]
        public string CollegeName { get; set; }
        [Display(Name = " b) Name of the District")]
        public string DistrictName { get; set; }
        [Display(Name = "2. Name of the student(in BLOCK LETTERS) as entered in +2 or equivalent certificate")]
        public string StudentName { get; set; }
        [Display(Name = "3. Name of the Parent / Guardian")]
        public string ParentName { get; set; }
        public string Guardian { get; set; }
        [Display(Name = "4. Nationality and Religion")]
        public SelectList Nationality { get; set; }
        public SelectList Religion { get; set; }
        [Display(Name = "5. Caste and Community")]
        public string Caste { get; set; }
        public SelectList Community { get; set; }
        [Display(Name = "6. Sex")]
        public SelectList Sex { get; set; }
        [Display(Name = "7. Date of Birth(in figures & words) as entered in Admission Register")]
        public string DateOfBirth { get; set; }
        public string DateToWords { get; set; }
        [Display(Name = "8. Personal Marks of Identification")]
        public string IdentificationMark1 { get; set; }
        public string IdentificationMark2 { get; set; }
        [Display(Name = "9. Date of Admission & Class which is admitted")]
        public string AdmissionDate { get; set; }
        public string AdmittedClass { get; set; }
        [Display(Name = "10. a) Class at the time of leaving")]
        public string LeavingTime { get; set; }
        [Display(Name = "b) Courses Offered - Main")]
        public string MainCourse { get; set; }
        [Display(Name = "Allied")]
        public string AlliedCourse { get; set; }
        public string AlliedCourse2 { get; set; }
        [Display(Name = "11. Whether the student haas paid all the fees due to the College")]
        public SelectList FeesPaid { get; set; }
        [Display(Name = "12. Whether the student was in receipt of any scholarship or any educational concessions")]
        public SelectList StuScholarship { get; set; }
        [Display(Name = "13. Whether undergone Medical Inspection ?")]
        public SelectList MedicalInspection { get; set; }
        [Display(Name = "14. Date on which the student left the College")]
        public string LeavingDate { get; set; }
        [Display(Name = "15. The Student's Contact and Character")]
        public SelectList Conduct { get; set; }
        [Display(Name = "16. Date on which appication for Transfer Certificate was made by the sudent")]
        public string StuTCApplyDate { get; set; }
        [Display(Name = "17. Date of the Transfer Certificate")]
        public string TCIssueDate { get; set; }
        [Display(Name = "Academic Years")]
        public string AcademicYears { get; set; }
        [Display(Name = "Class Studied")]
        public string ClassesStudied { get; set; }
        [Display(Name = "First Language")]
        public string FirstLanguage { get; set; }
        [Display(Name = "Academic Year")]
        public SelectList AcademicYear { get; set; }
        [Display(Name = "Medium of Instruction")]
        public string MediumofInstruction { get; set; }
        [Display(Name = "School Or College")]
        public string SchoolOrCollege { get; set; }
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        public SelectList Admission_No { get; set; }
        public string nation { get; set; }
        public string religi { get; set; }
        public string gender { get; set; }
        public string comm { get; set; }
        public string IncompleteSerialNo { get; set; }
        [Display(Name = "Mother Tongue")]
        public SelectList Mothertongue { get; set; }
        public SelectList FatherOccupation { get; set; }
        public SelectList ClassYear { get; set; }
        public SelectList UniversityList { get; set; }
        public string CertificateNumber1 { get; set; }
        public string CertificateNumber2 { get; set; }
        public string CertificateNumber3 { get; set; }
        public string CertificateDate { get; set; }
        public string LastStudied { get; set; }
        public string LastStudiedPlace { get; set; }
        [Display(Name = "HSC TC Number & Date")]
        public string HSCTCNumber { get; set; }
        public string HSCTCDate { get; set; }
        public SelectList ApplicationType { get; set; }
        public string CommunityNumber { get; set; }
        public string AnnualIncome { get; set; }



    }
    public class TRANSFERCERTIFICATE
    {
        public string CERTIFICATE_ID { get; set; }
        public string ADMISSION_NO { get; set; }
        public string SERIAL_NO { get; set; }
        public string STUDENT_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string GENDER { get; set; }
        public string RELIGION { get; set; }
        public string NATIONALITY { get; set; }
        public string CASTE { get; set; }
        public string COMMUNITY { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string ADMITTED_CLASS { get; set; }
        public string IDENTIFICATION_MARK1 { get; set; }
        public string IDENTIFICATION_MARK2 { get; set; }
        public string MAIN_COURSE { get; set; }
        public string ALLIED { get; set; }
        public string FEE_PAID { get; set; }
        public string SCHOLAR_SHIP { get; set; }
        public string LEAVING_DATE { get; set; }
        public string LEAVING_CLASS { get; set; }
        public string CONDUCT { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string TC_APPLIED_DATE { get; set; }
        public string TC_GIVEN_DATE { get; set; }
        public string CLASSES_STUDEIED { get; set; }
        public string FIRST_LANGUAGE { get; set; }
        public string COURSE_OF_STUDY { get; set; }
        public string DATETOWORDS { get; set; }
        public string REASON_FOR_LEAVING { get; set; }
        public string ROLL_NO { get; set; }
        public string ACADEMIC_YEARS { get; set; }
        public string FATHER_NAME { get; set; }
        public string ADMITTED_DATE { get; set; }
        public string GUARDIAN_NAME { get; set; }


    }

    // Conduct Certificate ..
    public class ConductCertificate
    {
        [Display(Name = "Shift")]
        public SelectList ShiftList { get; set; }
        [Display(Name = "Program")]
        public SelectList ProgramId { get; set; }
        [Display(Name = "Class")]
        public SelectList ClassId { get; set; }
        [Display(Name = "Student")]
        public SelectList StudentId { get; set; }
        [Display(Name = "Academic Year")]
        public SelectList AcademicYear { get; set; }
    }

    // Course Certificate ..
    public class CourseCertificate
    {
        [Display(Name = "Shift")]
        public SelectList ShiftList { get; set; }
        [Display(Name = "Program")]
        public SelectList ProgramId { get; set; }
        [Display(Name = "Class")]
        public SelectList ClassId { get; set; }
        [Display(Name = "Student")]
        public SelectList StudentId { get; set; }
        public SelectList AcademicYear { get; set; }
    }

    // Bonafide Certificate ..
    public class BonafideCertificate
    {
        [Display(Name = "Roll No")]
        public string ROLL_NO { get; set; }
        [Display(Name = "Name")]
        public string NAME { get; set; }
        [Display(Name = "Class")]
        public string CLASS { get; set; }
        [Display(Name = "Father Name")]
        public string FATHER_NAME { get; set; }
        [Display(Name = "During Year")]
        public string DURING_YEAR { get; set; }
        public string BONAFIDE_ID { get; set; }
        public string Student_Id { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string sResult { get; set; }
    }

    // Student Details ...
    public class StudentInfo
    {
        // Student List Details ..
        public string STUDENTID { get; set; }
        public string ROLLNO { get; set; }
        public string FIRSTNAME { get; set; }
        public string DEPTID { get; set; }
        public string GENDER { get; set; }
        public string SHIFTID { get; set; }
        public string CLASS_NAME { get; set; }
        public string IS_LEFT { get; set; }
        public string PHOTO { get; set; }



        // Student Courses ...
        [Display(Name = "Program Name")]
        public SelectList PROGRAMID { get; set; }
        [Display(Name = "Class")]
        public SelectList CLASSID { get; set; }
        [Display(Name = "Part")]
        public SelectList PART { get; set; }
        [Display(Name = "Main Subject")]
        public string MAIN_SUBJECT { get; set; }
        [Display(Name = "Allied1")]
        public string ALLIED1 { get; set; }
        [Display(Name = "Allied2")]
        public string ALLIED2 { get; set; }
        [Display(Name = "Allied3")]
        public string ALLIED3 { get; set; }
        [Display(Name = "Allied4")]
        public string ALLIED4 { get; set; }
        [Display(Name = "Elecctive1")]
        public string ELECTIVE1 { get; set; }
        [Display(Name = "Elecctive2")]
        public string ELECTIVE2 { get; set; }
        [Display(Name = "Elecctive3")]
        public string ELECTIVE3 { get; set; }
        [Display(Name = "Elecctive4")]
        public string ELECTIVE4 { get; set; }
        [Display(Name = "Special Subject")]
        public string SPECIAL_SUBJECT { get; set; }


        // Student Report Template
        public string REPORT_ID { get; set; }
        public string MODULE { get; set; }
        public string CREATED_BY { get; set; }
        public string CREATED_ON { get; set; }
        public string REPORT_NAME { get; set; }
        public string FIELD_LIST { get; set; }
        public string CONDITION { get; set; }
        public string ORDER_BY_FIELD { get; set; }
        public string GROUP_BY_FIELD { get; set; }
        public string STATISSTIC_FIELD { get; set; }
        public string COUNT_FIELD { get; set; }
        public string COUNT_CAPTION { get; set; }

        // Student Leave Letter ...
        public string LEAVE_LETTER_TITLE { get; set; }
        public string LEAVE_LETTER_FORMAT { get; set; }
        public string LETTER_FOR { get; set; }

        public string RUN_NUMBER { get; set; }
    }

    // Student Sibling ....
    public class STU_SIBLING
    {
        public string SIBLING_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string NAME { get; set; }
        public string AGE { get; set; }
        public string INSTITUTE_NAME { get; set; }
        public string PROGRAM { get; set; }
        public string IS_DELETED { get; set; }
        public string QUALIFICATION { get; set; }
        public string EMPLOYED { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string GENDER { get; set; }
        public string OCCUPATION { get; set; }
        public string MONTHLY_INCOME { get; set; }
        public string PROGNAME { get; set; }
        public string IS_SAME_COLLEGE { get; set; }
    }
   
    public class STU_RELATIONS
    {
        public string RELATION_ID { get; set; }
        public string RELATION_NAME { get; set; }
        public string STUDENT_ID { get; set; }
        public string RELATION_SHIP { get; set; }
        public string OCCUPATION { get; set; }
        public string INCOME { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string RELATION { get; set; }
    }

    // GET ACADEMIC YEAR ..
    public class GET_ACADEMIC_YEAR_BY_ID
    {
        public string STUDENT_ID { get; set; }
        public string ACADEMIC_YEAR_ID { get; set; }
        public string AC_YEAR { get; set; }
        public string SEMESTER { get; set; }
        public string IS_ACTIVE { get; set; }
        public string RESULT { get; set; }
    }

    public class Get_Allied_Subjects
    {
        public string COURSE_CODE { get; set; }
        public string COURSE_TITLE { get; set; }
        public string CLASS_ID { get; set; }
        public string IS_ALLIED_SUBJECT { get; set; }
    }

    #region Student Promotion
    public class JsonStudentPromotionList
    {
        public List<StudentPromotionList> StudentPromotionList { get; set; }
    }
    public class StudentPromotionList
    {
        public string SHIFT { get; set; }
        public string CLASS_ID { get; set; }
        public string cCLASS_ID { get; set; }
        public string pCLASS_ID { get; set; }
        public string CLASS_CODE { get; set; }
        public string CLASS_NAME { get; set; }
        public string COURSE_INFO_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string DEPARTMENT { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string ROLL_NO { get; set; }
        public string FIRST_NAME { get; set; }
        public string STU_CLASS_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string cACADEMIC_YEAR { get; set; }
        public string pACADEMIC_YEAR { get; set; }
        public string ACADEMIC_YEAR_ID { get; set; }
        public string PROGRAMME { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string cPROGRAMME { get; set; }
        public string tPROGRAMME { get; set; }
        public string CLASS_YEAR { get; set; }
        public string CLASS_LEVEL { get; set; }
        public string BATCH { get; set; }

    }
    #endregion

    #region Stu Course Info
    public class JsonStuCourseInfo
    {
        public List<Stu_Course_Info> SelectedStudentList { get; set; }
    }
    public class Stu_Course_Info
    {
        public string COURSE_INFO_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string ROLL_NO { get; set; }
        public string FIRST_NAME { get; set; }
        public string COURSE_ID { get; set; }
        public string SEMESTER { get; set; }
        public string COURSE_TITLE { get; set; }
        public string SHIFT { get; set; }
        public string S_CLASS_ID { get; set; }
        public string PROGRAMME { get; set; }
        public string BATCH { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string DAY_ORDER_MONTH { get; set; }
        public string STAFF_ID { get; set; }
        public string STAFF_NAME { get; set; }
        public string PROGRAMME_MODE { get; set; }
        public string SET_ID { get; set; }
    }
    #endregion

    #region ASSIGNMENT SUBMISSION
    public class ASSIGNMENT_SUBMISSION
    {
        public string ASS_SUBMISSION_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string CLASS_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string ASSIGNMENT_ID { get; set; }
        public string ASSIGNMENT_NAME { get; set; }
        public string FILE_PATH { get; set; }
        public string SUBMITTED_DATE { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string STAFF_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string FIRST_NAME { get; set; }
        public string ROLL_NO { get; set; }
    }
    #endregion


    public class MAJOR_WISE_ALLIED_COURSES
    {
        public string MAJOR_ID { get; set; }
        public string MAJOR { get; set; }
        public string ALLIED1 { get; set; }
        public string ALLIED2 { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_ACTIVE { get; set; }
    }

    // Table Fileds ....
    public class STU_PERSONAL_INFO
    {
        public string TYPE { get; set; }
        public string STUDENT_ID { get; set; }
        public string ADMISSION_NO { get; set; }
        public string CLASS_NAME { get; set; }
        public string COURSE { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string ADMITTED_CLASS { get; set; }
        public string DEPT_ID { get; set; }
        public string PROGRAM_ID { get; set; }
        public string GENDER { get; set; }
        public string SHIFT_ID { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string MOTHER_TONGUE { get; set; }
        public string SECOND_LANGUAGE { get; set; }
        public string BLOOD_GROUP { get; set; }
        public string RELIGION { get; set; }
        public string PLACE_OF_BIRTH { get; set; }
        public string NATIONALITY { get; set; }
        public string MODE_OF_TRANSPORT { get; set; }
        public string LEAVIN_GDATE { get; set; }
        public string LEAVING_YEAR { get; set; }
        public string LEAVING_CLASS { get; set; }
        public string REASON_FOR_LEAVING { get; set; }
        public string FATHER_NAME { get; set; }
        public string FR_OCCUPATION { get; set; }
        public string FATHER_EDUCATION { get; set; }
        public string MOTHER_NAME { get; set; }
        public string MO_OCCUPATION { get; set; }
        public string MOTHER_EDUCATION { get; set; }
        public string ANNUAL_INCOME { get; set; }
        public string IS_DELETED { get; set; }
        public string RESIDENCE_NO { get; set; }
        public string PASSPORT_Number { get; set; }
        public string DATE_OF_EXPIRY { get; set; }
        public string COUNTRY_OF_ISSUE { get; set; }
        public string PHOTO { get; set; }
        public string FR_NATIONALITY { get; set; }
        public string FR_EMPLOYER { get; set; }
        public string FR_BUSINESS_PHONE { get; set; }
        public string FR_MOBILE { get; set; }
        public string FR_PASSPORT_number { get; set; }
        public string FR_COUNTR_YOF_ISSUE { get; set; }
        public string MO_NATIONALITY { get; set; }
        public string MO_EMPLOYER { get; set; }
        public string MO_BUSINESS_PHONE { get; set; }
        public string MO_MOBILE { get; set; }
        public string MO_PASSPORT_number { get; set; }
        public string MO_COUNTRY_OF_ISSUE { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string STU_PASSPORT_IMAGE1 { get; set; }
        public string SPOKEN_LANGUAGE { get; set; }
        public string STU_PASSPORT_IMAGE2 { get; set; }
        public string STU_PASSPORT_IMAGE3 { get; set; }
        public string FATHER_PHOTO { get; set; }
        public string MOTHER_PHOTO { get; set; }
        public string UPLOAD_FLAG { get; set; }
        public string FIRST_LANGUAGE { get; set; }
        public string ISSUED_DATE { get; set; }
        public string VISA_ISSUED_DATE { get; set; }
        public string VISA_EXPIRY_DATE { get; set; }
        public string REG_STATUS { get; set; }
        public string CER_ISSUED_DATE { get; set; }
        public string COUNTRY_OF_BIRTH { get; set; }
        public string MINISTRY_CHECK { get; set; }
        public string VISA_SPONSOR { get; set; }
        public string VISA_Number { get; set; }
        public string SIBLING { get; set; }
        public string FR_BUSINESS_PO_BOX { get; set; }
        public string MO_BUSINESS_PO_BOX { get; set; }
        public string APPROVED_DATE { get; set; }
        public string COMMUNITY { get; set; }
        public string CASTE { get; set; }
        public string F_DATE_OF_BIRTH { get; set; }
        public string M_DATE_OF_BIRTH { get; set; }
        public string GUARDIAN_NAME { get; set; }
        public string G_CONTACT_NO { get; set; }
        public string IS_DOWNLOADED { get; set; }
        public string DOWNLOAD_TIME { get; set; }
        public string SMS_TYPE { get; set; }
        public string STUDENT_REGISTERDED_DATE { get; set; }
        public string SIBLING_ID { get; set; }
        public string USER_TYPE { get; set; }
        public string FR_INCOME { get; set; }
        public string MO_INCOME { get; set; }
        public string SPECIALLY_ABLED { get; set; }
        public string DISADVANTAGED_GROUP { get; set; }
        public string CERTIFICATE1 { get; set; }
        public string CERTIFICATE2 { get; set; }
        public string CERTIFICATE3 { get; set; }
        public string CERTIFICATE_DATE { get; set; }
        public string IS_UPDATED { get; set; }
        public string ANNIVERSARY_DATE { get; set; }
        public string REGISTER_NO { get; set; }
        public string ROLL_NO { get; set; }
        public string CLASS_ID { get; set; }
        public string MO_DATE_OF_EXPIRY { get; set; }
        public string FR_DATE_OF_EXPIRY { get; set; }
        public string IS_FRETA_STAFF { get; set; }
        public string IS_MOETA_STAFF { get; set; }
        public string FR_EMAIL { get; set; }
        public string MO_EMAIL { get; set; }
        public string UNIVERSITY_ROLLNO { get; set; }
        public string UNIVERSITY_ID { get; set; }
        public string STU_MOBILENO { get; set; }
        public string STU_EMAILID { get; set; }
        public string BATCH { get; set; }
        public string CURRENT_BATCH { get; set; }
        public string DEFICIENCY_LEVEL { get; set; }
        public string DEFICIENCY_TYPE { get; set; }
        public string RESIDENCY_TYPE { get; set; }
        public string EXTENSION_ACTIVITY { get; set; }
        public string ACADEMIC_MENTOR { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string IFSC_CODE { get; set; }
        public string MICR_CODE { get; set; }
        public string IDENTIFICATION_MARK1 { get; set; }
        public string IDENTIFICATION_MARK2 { get; set; }
        public string HOME_PHONE { get; set; }
        public string UPDATE_CR_FLAG { get; set; }
        public string TC_APPLIED_DATE { get; set; }
        public string TC_GIVEN_DATE { get; set; }
        public string IS_DISCONTINUED { get; set; }
        public string IS_COMPLETED { get; set; }
        public string ID_ISSUE_DATE { get; set; }
        public string ID_VALID_FROM { get; set; }
        public string ID_VALID_TO { get; set; }
        public string LAST_SCHOOL_OR_COLLEGE { get; set; }
        public string LAST_STUDIED_PLACE { get; set; }
        public string SUB_GROUP { get; set; }
        public string LAST_UPDATE_TIME { get; set; }
        public string TEMP_ID { get; set; }
        public string EXAM_PASSED { get; set; }
        public string MARITAL_STATUS { get; set; }
        public string HAILING_FROM { get; set; }
        public string REMARKS { get; set; }
        public string LAST_STUDIED_CLASS { get; set; }
        public string MOBILE { get; set; }
        public string SCHOLARSHIP { get; set; }
        public string MEDICAL_INSPECTION { get; set; }
        public string MOTHER_TONGUE_NAME { get; set; }
        public string OCCUPATION_NAME { get; set; }
        public string CLASS_LEVEL { get; set; }
        public string EXAM_SETTING { get; set; }

        public string REPORT_DATE { get; set; }
        public string TC_SERIAL_NO { get; set; }
        public string AADHAR_NUMBER { get; set; }
        public string IS_LEFT { get; set; }
        public string CONDUCT { get; set; }
        public string PROGRAMME_MODE { get; set; }
        public string TALENT { get; set; }
        public string IS_RELATION { get; set; }
        public string ROLE { get; set; }
        public string COURSE_TITLE { get; set; }
        public string REGISTRATION_ID { get; set; }
        public string DEPARTMENT { get; set; }
        public string SELECTED { get; set; }
        public string SET_ID { get; set; }
        public string PROGRAMME_NAME { get; set; }
        public string BOID_NUMBER { get; set; }
        public string RFID { get; set; }
        public string TEXT2 { get; set; }
        public string TEXT3 { get; set; }
        public string CLASS_CODE { get; set; }
        public string BIOD_NUMBER { get; set; }
        public string SHIFT_NAME { get; set; }
        public string ENTRY_ID { get; set; }
        public string BAR_CODE { get; set; }
        public string ADDRESS { get; set; }
        public string PROGRAMME_CODE { get; set; }

        public string MAJOR { get; set; }
        public string ALLIED_1 { get; set; }
        public string ALLIED_2 { get; set; }
        public string PART_1_LANGUAGE { get; set; }
        public string MEDIUM_OF_INSTRUCTION { get; set; }
        public string TOTAL_MARK { get; set; }
        public string EX_SERVICE_MAN { get; set; }
        public string IS_ANDAMAN_ORIGIN { get; set; }
        public string IS_SPORTS { get; set; }
        public string TOTAL_MARK_OBTAINED { get; set; }
        public string CUT_OF_MARK { get; set; }
        public string YEAR_OF_PASSING { get; set; }
        public string MARK_SHEET_NO { get; set; }
        public string QUALIFICATION { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string C_DOOR_DETAIL { get; set; }
        public string C_STREET { get; set; }
        public string C_POST_PLACE_TOWN { get; set; }
        public string C_TALUK { get; set; }
        public string C_CITY { get; set; }
        public string C_DISTRICT { get; set; }
        public string C_PINCODE { get; set; }
        public string MONTH_OF_PASSING { get; set; }
        public string Q_REGISTER_NO { get; set; }

        public string AGE { get; set; }
        public string YEAR_OF_JOIN { get; set; }
        public string TAMIL_NAME { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string SHIFT { get; set; }
        public string FEE_PAID { get; set; }
        public string APPTYPE_ID { get; set; }
        public string MAIN_COURSE { get; set; }
        public string PAR_I_LANGUAGE { get; set; }
        public string SPECIALIZATION { get; set; }
        public string DURATION { get; set; }
        public string DEBIT { get; set; }
        public string CREDIT { get; set; }
        public string EXAM_DEFALTER_ID { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string COURSE_ID { get; set; }
        public string EXAM_NAME { get; set; }
        public string HSC_TC_NUMBER { get; set; }
        public string HSC_TC_DATE { get; set; }
        public string COMMUNITY_NUMBER { get; set; }
        

    }
    public class STU_CLASS
    {
        public string STU_CLASS_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string CLASS_ID { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string BATCH { get; set; }
        public string SEMESTER { get; set; }
        public string IS_DELETED { get; set; }
        public string EXAM_SETTING_ID { get; set; }
        public string ENTRY_ID { get; set; }
    }
    public class STU_ACTIVITIES
    {
        public string ACTIVITY_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string POST_HELD { get; set; }
        public string INITIATIVE_SHOWN { get; set; }
        public string PARTICIPATION { get; set; }
        public string DATE_FROM { get; set; }
        public string DATE_TO { get; set; }
        public string EXTRA_ACTIVITY { get; set; }
        public string POSITION_OBTAINED { get; set; }
        public string IS_DELETED { get; set; }
        public string ACTIVITY { get; set; }
        public string ACTIVITY_IMAGE1 { get; set; }
        public string ACTIVITY_IMAGE2 { get; set; }
        public string ACTIVITY_IMAGE3 { get; set; }
    }
    public class STU_CERTIFICATE
    {
        public string CERTIFICATE_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string CERTIFICATE_NO { get; set; }
        public string RECEIVED_DATE { get; set; }
        public string GIVEN_DATE { get; set; }
        public string ARCHIVE { get; set; }
        public string PURPOSE { get; set; }
        public string REGISTER_NUMBER { get; set; }
        public string CERTIFICATE_NAME { get; set; }
        public string IS_DELETED { get; set; }
        public string ACHIEVEMENT_NAME { get; set; }

    }

    public class STU_TRANSFER_CERTIFICATE
    {
        public string CERTIFICATE_ID { get; set; }
        public string SERIAL_NO { get; set; }
        public string ADMISSION_NO { get; set; }
        public string ROLL_NO { get; set; }
        public string STUDENT_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string GENDER { get; set; }
        public string GENDER_ID { get; set; }
        public string RELIGION { get; set; }
        public string RELIGION_ID { get; set; }
        public string NATIONALITY { get; set; }
        public string NATIONALITY_ID { get; set; }
        public string CASTE { get; set; }
        public string PROGRAM_ID { get; set; }        
        public string COMMUNITY { get; set; }
        public string COMMUNITY_ID { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string ADMITTED_DATE { get; set; }
        public string ADMITTED_CLASS { get; set; }
        public string IDENTIFICATION_MARK1 { get; set; }
        public string IDENTIFICATION_MARK2 { get; set; }
        public string MAIN_COURSE { get; set; }
        public string ALLIED { get; set; }
        public string FEE_PAID { get; set; }
        public string SCHOLAR_SHIP { get; set; }
        public string LEAVING_DATE { get; set; }
        public string REASON_FOR_LEAVING { get; set; }
        public string LEAVING_CLASS { get; set; }
        public string CONDUCT { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string TC_APPLIED_DATE { get; set; }
        public string TC_GIVEN_DATE { get; set; }
        public string FATHER_NAME { get; set; }
        public string GUARDIAN_NAME { get; set; }
        public string ACADEMIC_YEARS { get; set; }
        public string CLASSES_STUDEIED { get; set; }
        public string FIRST_LANGUAGE { get; set; }
        public string DATETOWORDS { get; set; }
        public string CONTACT_NO { get; set; }
        public string ADDRESS { get; set; }
        public string MEDIUM_OF_INSTRUCTION { get; set; }
        public string STUDIED_FROM { get; set; }
        public string PRINCIPAL_SIGN { get; set; }
        public string BATCH { get; set; }
        public string APPTYPE_ID { get; set; }
        public string PROGRAMME_MODE { get; set; }
        public string SHIFT { get; set; }
        public string FR_OCCUPATION { get; set; }
        public string ANNUAL_INCOME { get; set; }

    }
    public class StudentCourse
    {
        public string STUDENT_ID { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string BATCH { get; set; }
        public string CLASS_ID { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string COURSE_ID { get; set; }
        public string COURSE_TITLE { get; set; }
        public string TOTAL { get; set; }
        public string SEMESTER_ID { get; set; }
        public string RESULT { get; set; }
        public string IS_COMPULSORY { get; set; }
    }

    public class STU_LEAVE_REQUEST
    {
        public string LEAVE_REQUEST_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string SUBJECT { get; set; }
        public string REASON { get; set; }
        public string REQUEST_DATE { get; set; }
        public string DATE_FROM { get; set; }
        public string DATE_TO { get; set; }
        public string APPROVE_BY { get; set; }
        public string APPROVED_DATE { get; set; }
        public string APPROVED_BY { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string STATUS { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_ACTIVE { get; set; }
        public string ROLL_NO { get; set; }
        public string NAME { get; set; }
        public string STATUS_NAME { get; set; }
        public string CLASS_ID { get; set; }



    }

    public class CORRECTION_IMAGES
    {
        public string STUDENT_ID { get; set; }
        public string CLASS_NAME { get; set; }
        public string ROLL_NO { get; set; }
        public string REGISTER_NO { get; set; }
        public string ADMISSION_NO { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string SHIFT_NAME { get; set; }
        public string PROGRAMME_NAME { get; set; }
        public string NAME { get; set; }
        public string PHOTO { get; set; }
    }
    public class STUDENT_INFORMATION_FORSTAFF
    {
        public string STUDENT_ID { get; set; }
        public string ROLL_NO { get; set; }
        public string REGISTER_NO { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string FATHER_NAME { get; set; }
        public string FR_OCCUPATION { get; set; }
        public string MOTHER_NAME { get; set; }
        public string MO_OCCUPATION { get; set; }
        public string PHOTO { get; set; }
        public string FR_MOBILE { get; set; }
        public string MO_MOBILE { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string STU_MOBILENO { get; set; }
        public string STU_EMAILID { get; set; }
        public string AADHAR_NUMBER { get; set; }
        public string C_DOOR_DETAIL { get; set; }
        public string C_STREET { get; set; }
        public string C_VILLAGE_AREA { get; set; }
        public string C_POST_PLACE_TOWN { get; set; }
        public string C_TALUK { get; set; }
        public string C_CITY { get; set; }
        public string C_DISTRICT { get; set; }
        public string C_PINCODE { get; set; }
        public string C_PHONENO { get; set; }
        public string C_COUNTRY { get; set; }
        public string P_DOOR_DETAIL { get; set; }
        public string P_STREET { get; set; }
        public string P_VILLAGE_AREA { get; set; }
        public string P_POST_PLACE_TOWN { get; set; }
        public string P_TALUK { get; set; }
        public string P_CITY { get; set; }
        public string P_DISTRICT { get; set; }
        public string P_PINCODE { get; set; }
        public string P_PHONENO { get; set; }
        public string P_COUNTRY { get; set; }
    }
    public class STU_REPORT_FIELDS
    {
        public string FIELD_ID { get; set; }
        public string FIELD { get; set; }
        public string FIELD_ALIAS { get; set; }
        public string FIELD_TABLE { get; set; }
        public string FEILD_ORDER { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }
    public class STU_REPORT_FOR_OFFICE
    {
        public string STUDENT_ID { get; set; }
        public string STUDENT_NAME { get; set; }
        public string ROLL_NO { get; set; }
        public string REGISTER_NO { get; set; }
        public string ADMISSION_NO { get; set; }
        public string CLASS { get; set; }
        public string PROGRAMME { get; set; }
        public string DEPARTMENT { get; set; }
        public string PROGRAMME_MODE { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string YEAR { get; set; }
        public string DEGREE { get; set; }
        public string FATHER_NAME { get; set; }
        public string MOTHER_NAME { get; set; }
        public string FATHER_OCCUPATION { get; set; }
        public string MOTHER_OCCUPATION { get; set; }
        public string BLOOD_GROUP { get; set; }
        public string ANNUAL_INCOME { get; set; }
        public string RELIGION { get; set; }
        public string NATION { get; set; }
        public string FATHER_MOBILE { get; set; }
        public string AADHAR_NUMBER { get; set; }
        public string STUDENT_MOBILE { get; set; }
        public string COMMUNITY { get; set; }
        public string CASTE { get; set; }
    }

    public class STU_ADMISSION_REGISTER
    {
        public string REGISTER_ID { get; set; }
        public string SERIAL_NO { get; set; }
        public string ROLL_NO { get; set; }
        public string ADMISSION_NO { get; set; }
        public string STUDENT_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string GENDER { get; set; }
        public string RELIGION { get; set; }
        public string RELIGION_ID { get; set; }
        public string NATIONALITY { get; set; }
        public string NATIONALITY_ID { get; set; }
        public string CASTE { get; set; }
        public string COMMUNITY { get; set; }
        public string COMMUNITY_ID { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string ADMITTED_CLASS { get; set; }
        public string IDENTIFICATION_MARK1 { get; set; }
        public string IDENTIFICATION_MARK2 { get; set; }
        public string MAIN_COURSE { get; set; }
        public string ALLIED { get; set; }
        public string FEE_PAID { get; set; }
        public string SCHOLAR_SHIP { get; set; }
        public string LEAVING_DATE { get; set; }
        public string REASON_FOR_LEAVING { get; set; }
        public string LEAVING_CLASS { get; set; }
        public string CONDUCT { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string TC_APPLIED_DATE { get; set; }
        public string TC_GIVEN_DATE { get; set; }
        public string FATHER_NAME { get; set; }
        public string GUARDIAN_NAME { get; set; }
        public string ACADEMIC_YEARS { get; set; }
        public string CLASSES_STUDEIED { get; set; }
        public string FIRST_LANGUAGE { get; set; }
        public string DATETOWORDS { get; set; }
        public string MEDIUM_OF_INSTRUCTION { get; set; }
        public string STUDIED_FROM { get; set; }
        public string CONTACT_NO { get; set; }
        public string ADDRESS { get; set; }
       
    }

    public class REPORT_FIELDS_FORCASTEWISE
    {
        public string ACADEMIC_YEAR { get; set; }
        public string PROGRAMME_MODE { get; set; }
        public string SHIFT { get; set; }
        public string PROGRAMME_NAME { get; set; }
        public string PROGRAMME_ID { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string COMMUNITY_NAME { get; set; }
        public string COMMUNITY { get; set; }
        public string COUNT { get; set; }

    }
    public class CASTEREPORT_DETAILS_FORPROGRAMME
    {
        public string TOTAL { get; set; }
        public string PROGRAMME_NAME { get; set; }
        public string SC { get; set; }
        public string ST { get; set; }
        public string OBC { get; set; }
        public string OTHERS { get; set; }
    }
    public class CASTEREPORT_DETAILS_FORSTUDENTS
    {
        public string PROGRAMME_NAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string COMMUNITY { get; set; }
    }
    public class CASTEREPORT_DETAILS_FORCOMMUNITY
    {
        public string COMMUNITY { get; set; }
        public string COUNT { get; set; }
    }

    public class CONVOCATION_APPLICATION_REGISTER
    {
        public string CENTER_NO { get; set; }
        public string CONVOC_APP_REGISTER_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string TAMIL_NAME { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string GENDER { get; set; }
        public string RELIGION { get; set; }
        public string COMMUNITY { get; set; }
        public string CASTE { get; set; }
        public string MOTHER_NAME { get; set; }
        public string PHOTO { get; set; }
        public string PROGRAMME_GROUP_ID { get; set; }
        public string P_DOOR_DEATAIL { get; set; }
        public string P_STREET { get; set; }
        public string P_VILLAGE_AREA { get; set; }
        public string P_POST_PLACE_TOWN { get; set; }
        public string P_TALUK { get; set; }
        public string P_CITY { get; set; }
        public string P_DISTRICT { get; set; }
        public string P_PINCODE { get; set; }
        public string P_STATE { get; set; }
        public string P_CONUNTRY { get; set; }
        public string BATCH { get; set; }
        public string FATHER_NAME { get; set; }
        public string STUDENT_MOBILE_NO { get; set; }
        public string PARENT_MOBILE { get; set; }
        public string EMAIL_ID { get; set; }
        public string AADHAR_NO { get; set; }
        public string YEAR_OF_JOIN { get; set; }
        public string YEAR_OF_PASSING { get; set; }
        public string IS_DISABLED { get; set; }
        public string REGISTER_DATE { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_ACTIVE { get; set; }
        public string C_PHONENO { get; set; }
        public string ADDRESS_ID { get; set; }
        public string RELIGION_NAME { get; set; }
        public string ROLL_NO { get; set; }
        public string COMMUNITY_NAME { get; set; }
        public string GENDER_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string PROGRAMME_NAME { get; set; }
        public string REGISTER_NO { get; set; }
        public string COUNTRY_NAME { get; set; }
        public string STATE_NAME { get; set; }
        public string TAMIL_NAME1 { get; set; }
        public string DOA { get; set; }
        public string AMOUNT { get; set; }


    }
    public class STU_LEAVE_APPLY
    {
        public string LEAVE_APPLY_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string FIRST_NAME { get; set; }

        public string ROLL_NO { get; set; }
        public string STATUS { get; set; }
        public string STATUS_ID { get; set; }

        public string LEAVE_TYPE_ID { get; set; }
        public string LEAVE_TYPE { get; set; }
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public string FILE_PATH { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string CLASS_NAME { get; set; }
        public string ATTENDANCE_PERCENTAGE { get; set; }
        public string PHOTO { get; set; }
        public string STAFF_ID { get; set; }
        public string STAFF_CODE { get; set; }
        public string REGISTER_NO { get; set; }



    }
    public class SUP_LEAVE_STATUS
    {
        public string LEAVE_STATUS_ID { get; set; }
        public string LEAVE_STATUS { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }

    public class SUP_LEAVE_TYPE
    {
        public string LEAVE_TYPE_ID { get; set; }
        public string LEAVE_TYPE { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }

    }
    public class STU_CERTIFICATE_APPLY
    {
        public string APPLY_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string ROLL_NO { get; set; }
        public string HEAD_ID { get; set; }
        public string HEAD { get; set; }
        public string FEE_MAINHEAD_ID { get; set; }
        public string APPLY_DATE { get; set; }
        public string ISSUE_DATE { get; set; }
        public string STATUS { get; set; }
        public string IS_PAID { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
        public string ACADEMIC_YEAR { get; set; }

        public string APPROVED_DATE { get; set; }
        public string APPROVER { get; set; }

        public string FREQUENCY_ID { get; set; }

        public string IS_APPROVED { get; set; }
        public string FIRST_NAME { get; set; }

        public string REGISTER_NO { get; set; }
        public string CLASS_NAME { get; set; }
        public string CLASS_ID { get; set; }
        public string STATUS_NAME { get; set; }
        public string DEBIT { get; set; }

        public string PROGRAMME_NAME { get; set; }
        public string FATHER_NAME { get; set; }
        public string ACADEMIC_NAME { get; set; }
        public string BEGIN_YEAR { get; set; }
        public string END_YEAR { get; set; }

    }
    public class SUP_CERTIFICATE_STATUS
    {
        public string STATUS_ID { get; set; }
        public string STATUS_NAME { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }
    }

    public class OTHERS_AAROGYA_SETUAPP_DOWNLOAD
    {
        public string ID { get; set; }
        public string USER_ID { get; set; }
        public string ROLE_ID { get; set; }
        public string STAUS { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string IS_ACTIVE { get; set; }
        public string IS_DELETED { get; set; }

    }


    public class STU_JSON_FIELD
    {
        public List<STU_CERTIFICATE_APPLY> LiCertificateApply { get; set; }
      
    }


    public class STU_MANDATORY_FIELDS
    {
        public string STU_MANDATORY_ID { get; set; }
        public string MANDATORY_FIELDS { get; set; }
        public string VISIBILE_NAME { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_ACTIVE { get; set; }
    }

    public class SUP_FIELDS
    {
        public string FIELD_ID { get; set; }
        public string FIELD_NAME { get; set; }
        public string ALICE_NAME { get; set; }
        public string PROPERTY_NAME { get; set; }
    }
    public class JSON_STU_PERSONAL_INFO
    {
        public List<STU_PERSONAL_INFO> STU_INFO { get; set; }
        public List<CUSTOMER_PERSONAL_INFO> SEMESTER_MARK { get; set; }

    }

    public class STUDENT_ID_CORRECTION
    {
        public string STU_CORRECTION_ID { get; set; }
        public string STUDENT_ID { get; set; }
        public string ROLL_NO { get; set; }
        public string FIRST_NAME { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string BLOOD_GROUP { get; set; }
        public string CASTE { get; set; }
        public string COMMUNITY_ID { get; set; }
        public string RELIGION { get; set; }
        public string STUDENT_MOBILE { get; set; }
        public string PARENT_MOBILE { get; set; }
        public string ADDRESS { get; set; }
        public string PINCODE { get; set; }
        public string STUDENT_PHOTO { get; set; }
        public string UPDATED_TIME { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_UPDATED { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string BOID_NUMBER { get; set; }
        public string FATHER_NAME { get; set; }
        public string MOTHER_NAME { get; set; }
         public string CLASS_NAME { get; set; }
    }

    public class STAFF_ID_CORRECTION
    {
        public string STU_CORRECTION_ID { get; set; }
        public string STAFF_ID { get; set; }
        public string STAFF_CODE { get; set; }
        public string FIRST_NAME { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string BLOOD_GROUP { get; set; }
        public string BLOOD_GROUP_NAME { get; set; }
        public string CASTE { get; set; }
        public string COMMUNITY_ID { get; set; }
        public string COMMUNITY { get; set; }
        public string RELIGION { get; set; }
        public string STAFF_MOBILE { get; set; }
        public string PARENT_MOBILE { get; set; }
        public string ADDRESS { get; set; }
        public string PINCODE { get; set; }
        public string STAFF_PHOTO { get; set; }
        public string UPDATED_TIME { get; set; }
        public string IS_DELETED { get; set; }
        public string IS_UPDATED { get; set; }
        public string ACADEMIC_YEAR { get; set; }
        public string BOID_NUMBER { get; set; }
        public string FATHER_NAME { get; set; }
        public string MOTHER_NAME { get; set; }
        public string CLASS_NAME { get; set; }
    }
}
