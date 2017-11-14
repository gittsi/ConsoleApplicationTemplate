using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationTemplate.Repository.Dto
{
    public class TestDataDto
    {
        public int _Id { get; set; }
        public bool _BoolData { get; set; }
        public string _StringData { get; set; }
        public List<string> _StringsData { get; set; }
    }
}
