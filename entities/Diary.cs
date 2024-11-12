using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCleanCode.entities
{
    public class Diary
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<DiaryNotes> DiaryEntries { get; set; } = new();
    }
    public class DiaryNotes
    {
        public int Id { get; set; }
        public string Note { get; set; } = string.Empty;
    }
}
