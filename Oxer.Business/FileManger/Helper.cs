using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxer.Business.FileManger
{
    public static class Helper
    {
        public static string SaveFile(this IFormFile file,string rootPath,string folderName)
        {
            string filename=file.FileName.Length>64?
                file.FileName.Substring(file.FileName.Length-64,64):file.FileName;
            filename = Guid.NewGuid().ToString() + filename;
            string path=Path.Combine(rootPath,folderName,filename);
            using(FileStream stream=new FileStream(path,FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return filename;
        }
        public static void DeleteFile(string rootPath,string folderName, string ImageUrl)
        {
            string deletepath=Path.Combine(rootPath,folderName,ImageUrl);
            if (File.Exists(deletepath))
            {
                File.Delete(deletepath);
            }
        }
    }
}
