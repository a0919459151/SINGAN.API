namespace SINGAN.API.Models.ValueObject;

public class WorkExperience
{
    public string? Company { get; set; }           // 公司
    public string? Department { get; set; }        // 部門
    public string? Position { get; set; }          // 職稱
    public string? Supervisor { get; set; }        // 主管
    public string? JobDescription { get; set; }    // 工作內容
    public DatePeriod? StartPeriod { get; set; }      // 工作開始的年份和月份
    public DatePeriod? EndPeriod { get; set; }        // 工作結束的年份和月份
    public decimal Salary { get; set; }           // 年薪
    public string? ReasonForLeaving { get; set; }  // 離職原因
}