namespace NativeDialogExample;

internal class Program
{
    private static void Main(string[] args)
    {
        if (NativeDialog.ShowYesNoDialog("Title", "A question.", "A comment."))
            NativeDialog.ShowOkDialog("Title", "Yes");
        else
            NativeDialog.ShowOkDialog("Title", "No");
    }
}
