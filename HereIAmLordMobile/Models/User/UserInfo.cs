using Newtonsoft.Json;


namespace HereIAmLordMobile.Models.User
{
    public class UserInfo
    {
        [JsonProperty("sub")]
        public string UserId { get; set; }

        [JsonProperty("bday")]
        public string Bday { get; set; }

        [JsonProperty("name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_verified")]
        public bool EmailVerified { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("phone_number_verified")]
        public bool PhoneNumberVerified { get; set; }

    }
}
