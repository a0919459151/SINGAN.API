namespace SINGAN.API.Models.ValueObject;

public class Contact
{
    public string? Name { get; set; }              // 聯絡人姓名
    public string? MobilePhone { get; set; }       // 聯絡人手機號碼
    public string? Relationship { get; set; }      // 聯絡人關係
    public string? Address { get; set; }           // 聯絡人地址
}