using System;

namespace NativeDialogExample
{
    internal class UnexpectedDialogResultException : ApplicationException
    {
        public UnexpectedDialogResultException(
            TaskDialogResult dialogResult,
            string? message = null)
            : base(message ?? "Unexpected value of TaskDialogResult encountered.")
        {
            DialogResult = dialogResult;
        }

        public TaskDialogResult DialogResult { get; }
    }
}
