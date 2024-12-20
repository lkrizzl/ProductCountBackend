﻿using Domain.Core.PrimitiveTypes;

namespace Domain.Users.UserNames;

internal class UserNameErrors
{
    public static Error TooLong = new Error(
            "UserName.TooLong", "The username is too long.");

    public static Error InvalidFormat = new Error(
        "UserName.InvalidFormat", "The username contains unacceptable symbols.");
}
