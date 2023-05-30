using System;

namespace BehsaApp.Web.Modules.Support.About
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string ProvinceName { get; set; }
    }
}
