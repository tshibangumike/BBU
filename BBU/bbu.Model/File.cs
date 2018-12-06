using System;
namespace bbu.Model
{
    public class File
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public int Size { get; set; }
        public string FileContent { get; set; }
    }
}
                
