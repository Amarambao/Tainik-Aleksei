namespace Homework__8
{
    public static class PhoneHelper
    {
        //375296989522 посмотреть размер инта
        public static bool IsPhoneValid(string phoneNumber) =>
            phoneNumber.Length == 12 && phoneNumber.StartsWith("375") && long.TryParse(phoneNumber, out long buffer);
    }
}
