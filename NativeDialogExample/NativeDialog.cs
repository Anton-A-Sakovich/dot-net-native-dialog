using System;
using System.Runtime.InteropServices;

namespace NativeDialogExample
{
    internal static class NativeDialog
    {
        [DllImport("Comctl32.dll", EntryPoint = "TaskDialog", CharSet = CharSet.Unicode, ExactSpelling = true)]
        private static extern int TaskDialog(
            nint hwndOwner,
            nint hInstance,
            string pszWindowTitle,
            string pszMainInstruction,
            string? pszContent,
            TaskDialogStandardButton dwCommonButtons,
            TaskDialogStandardIcon pszIcon,
            ref TaskDialogResult pnButton);

        public static bool ShowYesNoDialog(string title, string mainText, string? extraText = null)
        {
            var buttons = TaskDialogStandardButton.Yes | TaskDialogStandardButton.No;
            var icon = TaskDialogStandardIcon.Information;

            var dialogResult = ShowDialog(title, mainText, buttons, icon, extraText);

            return dialogResult switch
            {
                TaskDialogResult.Yes => true,
                TaskDialogResult.No => false,
                _ => throw new UnexpectedDialogResultException(dialogResult)
            };
        }

        public static void ShowOkDialog(string title, string mainText, string? extraText = null)
        {
            var buttons = TaskDialogStandardButton.Ok;
            var icon = TaskDialogStandardIcon.Information;

            var dialogResult = ShowDialog(title, mainText, buttons, icon, extraText);

            if (dialogResult != TaskDialogResult.Ok)
                throw new UnexpectedDialogResultException(dialogResult);
        }

        private static TaskDialogResult ShowDialog(
            string title,
            string mainText,
            TaskDialogStandardButton buttons,
            TaskDialogStandardIcon icon,
            string? extraText = null)
        {
            var dialogResult = TaskDialogResult.Failure;
            var hResult = TaskDialog(nint.Zero, nint.Zero, title, mainText, extraText, buttons, icon, ref dialogResult);

            if (hResult != 0)
                throw new ApplicationException { HResult = hResult };

            return dialogResult;
        }
    }
}
