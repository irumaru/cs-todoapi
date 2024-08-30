// アプリのモデルを定義する

public class Todo
{
  public int Id { get; set; }
  public string? Name { get; set; } /* ?はnullを許容する */
  public bool IsComplate { get; set; }
}
