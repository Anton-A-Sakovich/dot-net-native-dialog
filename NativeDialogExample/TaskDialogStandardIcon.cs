namespace NativeDialogExample
{
    internal enum TaskDialogStandardIcon
    {
        None = 0,
        Information = ushort.MaxValue - 2,
        Warning = ushort.MaxValue,
        Error = ushort.MaxValue - 1,
        Shield = ushort.MaxValue - 3,
        ShieldBlueBar = ushort.MaxValue - 4,
        ShieldGrayBar = ushort.MaxValue - 8,
        ShieldWarningYellowBar = ushort.MaxValue - 5,
        ShieldErrorRedBar = ushort.MaxValue - 6,
        ShieldSuccessGreenBar = ushort.MaxValue - 7,
    }
}
