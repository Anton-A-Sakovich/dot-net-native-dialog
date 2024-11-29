using System;

namespace NativeDialogExample
{
    [Flags]
    internal enum TaskDialogStandardButton
    {
        Ok = 0x0001, // selected control return value IDOK
        Yes = 0x0002, // selected control return value IDYES
        No = 0x0004, // selected control return value IDNO
        Cancel = 0x0008, // selected control return value IDCANCEL
        Retry = 0x0010, // selected control return value IDRETRY
        Close = 0x0020,  // selected control return value IDCLOSE
    }
}
