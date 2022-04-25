using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Calendar_with_Notepad
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }

        Random random = new Random();
        public string RandomColor
        {
            get
            {
                return String.Format("#{0:X6}", random.Next(0x1000000));
            }
        }
    }

}
