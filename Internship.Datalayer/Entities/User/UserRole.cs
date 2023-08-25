using System.ComponentModel.DataAnnotations;

namespace Internship.Datalayer.Entities.User;

public class UserRole
{
    public UserRole()
    {
        
    }
    
    [Key]
    public long UR_Id { get; set; }
    //FK---> Which User
    public long UserId { get; set; }
    //FK---> Which Role
    public long RoleId { get; set; }


    #region Relations

    public virtual User User { get; set; }
    public virtual Role Role { get; set; }

    #endregion
}