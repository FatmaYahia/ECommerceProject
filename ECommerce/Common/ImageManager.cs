using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ImageManager
    {
        public readonly string webRootPath;
        public ImageManager(string webRootPath) {
            this.webRootPath = webRootPath;
        }
        public async Task<string> UploadImageAsync(string DomainName,IFormFile file,string FolderUpload)
        {
            string fileName = file.FileName;
            string folderPath = Path.Combine(webRootPath, FolderUpload);
            string FullFilePath=Path.Combine(folderPath,fileName);
            using(FileStream localfile=File.OpenWrite(FullFilePath))
            using (Stream uploadedFile=file.OpenReadStream())
            {
                await uploadedFile.CopyToAsync(localfile);
            }
            string imgPath = DomainName + "/" + FolderUpload + "/" + fileName;
            return fileName;
        }
    }
}
