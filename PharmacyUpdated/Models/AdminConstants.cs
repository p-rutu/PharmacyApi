using System.Collections.Generic;

namespace PharmacyUpdated.Models
{
    public class AdminConstants
    {
        public static List<Admin> _admin = new List<Admin>()
        {
            new Admin(){AdminName="admin1",Contact="1234567891",emailId="admin1@gmail.com",password="admin1",Role="administrator" },
            new Admin(){AdminName="admin2",Contact="1234567895",emailId="admin2@gmail.com",password="admin2",Role="User"},
            new Admin(){AdminName="Rutuja",Contact="1234567890",emailId="rutujarp00@gmail.com",password="Pass@123",Role="administrator"}
        };
    }
}
