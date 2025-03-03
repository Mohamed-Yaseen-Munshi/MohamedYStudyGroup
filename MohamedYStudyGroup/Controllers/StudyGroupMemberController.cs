using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MohamedYStudyGroup.Controllers
{
    public class StudyGroupMemberController : Controller
    {
        // GET: StudyGroupMember
        public ActionResult Index()
        {
            List<StudyGroupMember> students = new List<StudyGroupMember>
            {
                new StudyGroupMember
                {
                    StudentNo = "u24594394",
                    Name = "Mohamed Yaseen",
                    surname = "Munshi",
                    email = "u24594394@gmail.com"
                },

                new StudyGroupMember
                {
                    StudentNo = " u12345678",
                    Name = " Adam",
                    surname = "Smith",
                    email = "u12345678@gmail.com"
                },

                new StudyGroupMember
                {
                    StudentNo = " u87654321",
                    Name = "Sarah",
                    surname = " Johnson",
                    email = " u87654321@gmail.com"
                },

                new StudyGroupMember
                {
                    StudentNo = "u11223344",
                    Name = "David",
                    surname = "Brown",
                    email = "u11223344@gmail.com"
                },

                new StudyGroupMember
                {
                    StudentNo = "u99887766",
                    Name = " Emily",
                    surname = "Davis",
                    email = "u99887766@gmail.com"
                },
            };
            return View(students);
        }
    }
}