using System.Security.Cryptography.X509Certificates;
using System.Text.Unicode;

namespace TeamR.Domain.Entities.Account;

public enum UserColumn
{
    Id = 1,
    Name = 2,
    LastName = 3,
    Sex = 4,
    Birthday = 5,
    Mobile = 6,
    Address = 7,
    Latitude = 8,
    Longitude = 9,
    Altitude = 10,
    CreateDate = 11,
    ModifiedDate = 12,
    ModifyUserId = 13,
    IsActive = 14,
    IsDeleted = 15
}