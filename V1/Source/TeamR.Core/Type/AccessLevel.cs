namespace TeamR.Core.Type;

[Flags]
public enum AccessLevel
{
    None = 0,

    Read = 1,

    Create = 2,

    Update = 4,

    Delete = 8,

    Approve = 16,

    Manage = 32,

    FullAccess =
        Read |
        Create |
        Update |
        Delete |
        Approve |
        Manage
}