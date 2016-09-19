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
        public DateTime dateAdded { get; set; }
        public string fileName { get; set; }
        public long fileSize { get; set; }
        public byte[]  fileData { get; set; }
        public string fileClass { get; set; } 
      
        public AddRecording(DateTime dateAdded, string fileName, long fileSize, byte[] fileData, string fileClass)
        {
            this.dateAdded = dateAdded;
            this.fileName = fileName;
            this.fileSize = fileSize;
            this.fileData = fileData;
            this.fileClass = fileClass;
        }
    }
}
