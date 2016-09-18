using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
namespace WindowsFormsApplication1
{
    class AddRecording
    {
        public string date { get; set; }
        public string fileName { get; set; }
        public string fileSize { get; set; }
        public byte[]  fileData { get; set; }
        public string fileClass { get; set; } 
      
        public AddRecording(string date, string fileName, string fileSize, byte[] fileDate, string fileClass)
        {
            this.date = date;
            this.fileName = fileName;
            this.fileSize = fileSize;
            this.fileData = fileData;
            this.fileClass = fileClass;
        }
    }
}
