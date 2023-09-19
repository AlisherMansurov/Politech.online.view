using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Politech.DAL.Model
{
    public class Client
    {
        public Client():this(0)
        {
        }
        public Client(int Id):this(Id, DateTime.Now)
        {
        }
        public Client(int Id, DateTime CreateDate)
            :this(Id, CreateDate, "")
        {
        }
        public Client(int Id, DateTime CreateDate, string PathToImage)
        {
            this.Id = Id;
            this.CreateDate = CreateDate;
            this.PathToImage = PathToImage;
        }

        int age;
        public int Id { get; set; }
        //public int id
        //{
        //    get { 
        //        return id; 
        //    }
        //    set { 
        //        if (value < 0) {
        //            id = 0;
        //        } 
        //        else {
        //            id = value;
        //        } 
        //    }

        //}
        public DateTime CreateDate { get;  set; } = DateTime.Now;
        public string Fname {
            get; 
            set;
        }
        public string Sname {
            get;
            set;
        }
        public string Lname {
            get;
            set;
        }
        public string FullName { 
            get
            {
                return string.Format("{0} {1} {2}",
                    Fname, Sname, Lname);
            } 
        }
        public string ShortName
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Lname))
                    return string.Format("{0} {1}. {2}.",
                        Fname, Sname[0], Lname[0]);
                else
                    return string.Format("{0} {1}.",
                        Fname, Sname[0]);

            }
        }
        public int Sex { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Dob {
            get;
            set;
        }
        public int Age { 
            get
            {
                return DateTime.Now.Year - Dob.Year;
            }
            set
            {

            }
        }
        public string PathToImage { get; set; }
        public Address Address { get; set; }
        public Accaunt[] Accaunts { get; set; }
    }
}
