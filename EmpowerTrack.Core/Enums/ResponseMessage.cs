using System.ComponentModel;

namespace EmpowerTrack.Core.Enums
{
    public enum ResponseMessage
    {
        [Description("Data retrieved successfully.")]
        DataRetrievedSuccessfully,

        [Description("Failed to retrieve data.")]
        DataFailedToRetrieve,

        [Description("Insert operation was successful.")]
        InsertSuccessful,

        [Description("Insert operation failed.")]
        InsertFailed,

        [Description("Update operation was successful.")]
        UpdateSuccessful,

        [Description("Update operation failed.")]
        UpdateFailed,

        [Description("Delete operation was successful.")]
        DeleteSuccessful,

        [Description("Delete operation failed.")]
        DeleteFailed,

        [Description("Username is Wrong")]
        UserNameWrong,

        [Description("Password is wrong")]
        PasswordWrong,

        [Description("Login Succesfully done!!")]
        LoginSuccess
    }

    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = field?.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                 .FirstOrDefault() as DescriptionAttribute;
            return attribute?.Description ?? value.ToString();
        }
    }

}
