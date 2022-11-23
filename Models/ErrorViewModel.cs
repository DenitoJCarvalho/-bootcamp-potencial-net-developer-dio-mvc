namespace bootcamp_potencial_net_developer_dio_mvc.Models;

public class ErrorViewModel
{
  public string? RequestId { get; set; } = String.Empty;

  public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
