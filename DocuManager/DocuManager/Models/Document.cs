using System;
namespace DocuManager.Models
{
    public class Document
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string TypeIcon { get; set; }
        public string PreviewImage { get; set; }
        public DateTime UploadDateTime { get; set; }
        public int DownloadCount { get; set; }
        public int Id { get; set; }
    }
}

