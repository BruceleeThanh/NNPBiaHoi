using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;

namespace BussinessLogic {
    public partial class ConvertImage {

        public byte[] ConvertImagePathToByte(string imagePath) {
            try {
                byte[] data = null;
                FileInfo aFileInfo = new FileInfo(imagePath);
                long amountOfData = aFileInfo.Length;
                FileStream aFileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                BinaryReader aBinaryReader = new BinaryReader(aFileStream);
                data = aBinaryReader.ReadBytes((int)amountOfData);
                return data;
            }
            catch(Exception ex) {
                throw new Exception("ConvertImage.ConvertImagePathToByte: " + ex.ToString());
            }
        }

        public Image ConvertByteToImage(byte[] image) {
            try {
                Image aImage;
                using(MemoryStream aMemoryStream = new MemoryStream(image, 0, image.Length)) {
                    aMemoryStream.Write(image, 0, image.Length);
                    aImage = Image.FromStream(aMemoryStream, true);
                }
                return aImage;
            }
            catch(Exception ex) {
                throw new Exception("ConvertImage.ConvertImagePathToByte: " + ex.ToString());
            }
        }

    }
}
