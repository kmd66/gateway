using System.Collections.Generic;

namespace Kama.ApiManagement.Core;

public interface IRequestInfo : AppCore.IRequestInfo
{
    Dictionary<string, string> AuthorizationClaims { get; }

    byte? UserType { get; }

    byte? PositionType { get; }

    byte? DepartmentType { get; }

    byte? PositionSubType { get; }
}
