namespace SINGAN.API.Models.ValueObject;

public class Thesis
{
    public string? Title { get; set; }           // 題目
    public DateTime? PublicationTime { get; set; }    // 發表時間
    public string? Advisor { get; set; }        // 指導教授
}
