namespace SINGAN.API.Models.Entities;

public class Applicant
{
    public int Id { get; set; }
    public string? AppliedPosition { get; set; }                 // 應徵職務
    public string? ChineseName { get; set; }                     // 中文姓名
    public string? EnglishName { get; set; }                     // 英文姓名
    public string? Gender { get; set; }                           // 性別
    public string? IdentificationNumber { get; set; }             // 身分證字號
    public DateTime? DateOfBirth { get; set; }                   // 出生日期
    public int Age { get; set; }                                // 年齡
    public string? BloodType { get; set; }                       // 血型
    public string? Email { get; set; }                            // 電子郵件
    public int Height { get; set; }                              // 身高
    public int Weight { get; set; }                              // 體重
    public string? Birthplace { get; set; }                       // 籍貫/出生地
    public string? HouseholdAddress { get; set; }                // 戶籍地址
    public string? MailingAddress { get; set; }                   // 通訊地址
    public string? MobilePhone { get; set; }                      // 手機號碼
    public string? HomePhone { get; set; }                        // 室內電話
    public string? MilitaryService { get; set; }                  // 兵役狀況
    public ICollection<string>? DriverLicenses { get; set; }      // 駕照
    public Contact? EmergencyContact { get; set; }                // 緊急聯絡人資訊
    public ICollection<EducationBackground>? EducationBackgrounds { get; set; }  // 教育背景列表
    public Thesis? Thesis { get; set; }                                           // 論文
    public ICollection<WorkExperience>? WorkExperiences { get; set; }            // 工作經歷列表
}
