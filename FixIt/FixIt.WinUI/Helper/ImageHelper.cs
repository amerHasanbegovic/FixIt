using System.Drawing;
using System.IO;

namespace FixIt.WinUI.Helper
{
    public class ImageHelper
    {
        public static Image FromByteToImage(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }
        public static byte[] FromImageToByte(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
