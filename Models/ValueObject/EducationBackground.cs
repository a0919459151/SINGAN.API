namespace SINGAN.API.Models.ValueObject;

public class EducationBackground
{
    public string? Degree { get; set; }            // 學歷
    public string? School { get; set; }            // 學校
    public string? Department { get; set; }        // 科系
    public string? DayNight { get; set; }          // 日/夜校
    public DatePeriod? StartPeriod { get; set; }      // 開始就學的年份和月份
    public DatePeriod? EndPeriod { get; set; }        // 結束就學的年份和月份
    public string? StudyStatus { get; set; }       // 就學狀態
    public string? Honors { get; set; }            // 曾獲特殊榮譽
}