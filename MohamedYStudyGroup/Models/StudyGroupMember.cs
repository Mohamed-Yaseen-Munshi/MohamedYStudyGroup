using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MohamedYStudyGroup
{
    public class StudyGroupMember
    {
        [DisplayName("STUDENT NUMBER")]
        public string StudentNo { get; set; }
        [DisplayName("NAME")]
        public string Name { get; set; }
        [DisplayName("SURNAME")]
        public string surname { get; set; }
        [DisplayName("EMAIL ADDRESS")]
        public string email { get; set; }
    }
}