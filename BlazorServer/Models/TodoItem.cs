namespace BlazorServer.Models;

/// <summary>
/// Model for a todo item.
/// </summary>
public sealed class TodoItem
{
    public TodoItem() { }

    /// <summary>
    /// The title of the todo, which may not exist.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Whether the todo is complete.
    /// </summary>
    public bool IsDone { get; set; }
}
