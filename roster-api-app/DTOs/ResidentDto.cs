namespace roster_api_app.DTOs;

public class ResidentDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;
    public string Building { get; set; } = string.Empty;
    public string CleaningFrequency { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public int? UnitId { get; set; }
    public string? UnitName { get; set; }
    public int? ApartmentId { get; set; }
    public string? ApartmentName { get; set; }
    public string AssignmentType { get; set; } = string.Empty;
    public string AssignmentName { get; set; } = string.Empty;
}
