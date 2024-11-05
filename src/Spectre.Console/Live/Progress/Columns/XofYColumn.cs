namespace Spectre.Console;

/// <summary>
/// A column showing progress in the form of "x / y".
/// </summary>
public sealed class XofYColumn : ProgressColumn
{
    /// <inheritdoc/>
    public override IRenderable Render(
        RenderOptions options,
        ProgressTask task,
        TimeSpan deltaTime)
    {
        var color = task.IsFinished ? "green" : "grey";
        return new Markup($"[{color}]{task.Value}/{task.MaxValue}[/]");
    }
}