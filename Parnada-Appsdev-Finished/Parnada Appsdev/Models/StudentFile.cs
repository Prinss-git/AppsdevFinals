using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

public class StudentFile
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public long STFSTUDID { get; set; } // Student's ID Number

    private string _lastName;
    private string _firstName;
    private string _middleName;
    private string _course;

    [Required]
    [StringLength(15)]
    public string STFSTUDLNAME
    {
        get => _lastName;
        set => _lastName = ToTitleCase(value);
    } // Last Name

    [Required]
    [StringLength(15)]
    public string STFSTUDFNAME
    {
        get => _firstName;
        set => _firstName = ToTitleCase(value);
    } // First Name

    [StringLength(15)]
    public string STFSTUDMNAME
    {
        get => _middleName;
        set => _middleName = ToTitleCase(value);
    } // Middle Name

    [Required]
    [StringLength(10)]
    public string STFSTUDCOURSE
    {
        get => _course;
        set => _course = value?.ToUpper() ?? "";
    } // Course

    [Required]
    public int STFSTUDYEAR { get; set; } // Year Level

    [Required]
    [StringLength(15)]
    [EnumDataType(typeof(StudentRemarks))]
    public string STFSTUDREMARKS { get; set; } // Remarks

    [Required]
    [StringLength(8)]
    [EnumDataType(typeof(StudentStatus))]
    public string STFSTUDSTATUS { get; set; } // Status

    // Convert string to Title Case
    private string ToTitleCase(string input)
    {
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input?.ToLower() ?? "");
    }
}

// Enums for validation
public enum StudentRemarks
{
    Shiftee,
    Transferee,
    New,
    Old,
    CrossEnrollee,
    Returnee
}

public enum StudentStatus
{
    Active,
    Inactive
}
