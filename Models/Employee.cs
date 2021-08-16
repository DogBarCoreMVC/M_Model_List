using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//ทำงานร่วมกับ Display
using System.Linq;
using System.Threading.Tasks;

namespace M_Model_List.Models
{
    public class Employee
    {
        [Display(Name = "รหัสพนักงาน")]//ทำการเปลี่ยนชื่อ field ที่แสดง
        public int CodeEmployee { get; set; }

        [Display(Name = "ชื่อจริง - นามสกุล")]
        public string FullName { get; set; }

        [Display(Name = "เบอร์โทรศัพท์")]
        public string TelePhone { get; set; }

        [Display(Name = "เมล์")]
        public string Mail { get; set; }
    }
}
