#region
/*************************************************************************************
     * CLR 版本：       4.0.30319.34011
     * 类 名 称：       PhotoUtil
     * 机器名称：       JASON_PC
     * 命名空间：       PhotoCompress
     * 文 件 名：       PhotoUtil
     * 创建时间：       2015/05/29 17:37:22
     * 计算机名：       Administrator
     * 作    者：       Jason.Yang(yangxing1002@gmail.com)
     * 说    明： 
     * 修改时间：
     * 修 改 人：
**************************************************************************************/
#endregion
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoCompress
{
  public  class PhotoUtil
    {

      public static void SaveAs(Image img, string dest, long quality)
        {
            if (quality > 100 || quality < 1)
            {
                quality = 85;
            }
            EncoderParameters para = new EncoderParameters();
            para.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            String extension = new FileInfo(dest).Extension;
            ImageCodecInfo info = GetImageCodecInfoByExtension(extension);
            if (info != null)
            {
                img.Save(dest, info, para);
            }
            else
            {
                throw new Exception("Unrecognized  format");

            }
        }

        public static void ResizeImage(ref Image image, int expectDestWidth, int expectDestHeight, bool padding)
        {
            PropertyItem[] exif = image.PropertyItems;
            int targetWidth = 0;
            int targetHeight = 0;
            double srcHWRate = (double)image.Width / (double)image.Height;
            double expectHWRate = (double)expectDestWidth / (double)expectDestHeight;
            if (srcHWRate > expectHWRate)
            {
                targetWidth = expectDestWidth;
                targetHeight = System.Convert.ToInt32(Math.Round(expectDestWidth / srcHWRate, 0));
            }
            else
            {
                targetHeight = expectDestHeight;
                targetWidth = System.Convert.ToInt32(Math.Round(expectDestHeight * srcHWRate, 0));
            }

            Image bitmap = null;
            if (!padding)
            {
                bitmap = new Bitmap(targetWidth, targetHeight);
            }
            else
            {
                bitmap = new Bitmap(expectDestWidth, expectDestHeight);
            }
            Graphics g = Graphics.FromImage(bitmap);
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawImage(image, new Rectangle(0, 0, bitmap.Width, bitmap.Height), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            foreach (PropertyItem i in exif)
            {
                if (i.Id == 40962)
                {
                    i.Value = BitConverter.GetBytes(targetWidth);
                }
                else if (i.Id == 40963)
                {
                    i.Value = BitConverter.GetBytes(targetHeight);
                }
                bitmap.SetPropertyItem(i);
            }
            g.Dispose();
            image.Dispose();
            image = bitmap;
        }

        //private static string ReadConfig(String Section, String Key, String defaultValue)
        //{
        //    if (File.Exists(configFile))
        //    {
        //        StringBuilder temp = new StringBuilder(1024);
        //        GetPrivateProfileString(Section, Key, String.Empty, temp, 1024, new FileInfo(configFile).FullName);
        //        if (!String.IsNullOrEmpty(temp.ToString()))
        //        {
        //            return temp.ToString();
        //        }
        //        else
        //        {
        //            return defaultValue;
        //        }
        //    }
        //    else
        //    {
        //        return defaultValue;
        //    }
        //}

        public static void RotateImage(Image img)
        {
            PropertyItem[] exif = img.PropertyItems;
            byte orientation = 0;
            foreach (PropertyItem i in exif)
            {
                if (i.Id == 274)
                {
                    orientation = i.Value[0];
                    i.Value[0] = 1;
                    img.SetPropertyItem(i);
                }
            }

            switch (orientation)
            {
                case 2:
                    img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;
                case 3:
                    img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case 4:
                    img.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    break;
                case 5:
                    img.RotateFlip(RotateFlipType.Rotate90FlipX);
                    break;
                case 6:
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 7:
                    img.RotateFlip(RotateFlipType.Rotate270FlipX);
                    break;
                case 8:
                    img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                default:
                    break;
            }
            foreach (PropertyItem i in exif)
            {
                if (i.Id == 40962)
                {
                    i.Value = BitConverter.GetBytes(img.Width);
                }
                else if (i.Id == 40963)
                {
                    i.Value = BitConverter.GetBytes(img.Height);
                }
            }
        }

        private static ImageCodecInfo GetImageCodecInfoByExtension(String extension)
        {
            ImageCodecInfo[] list = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo i in list)
            {
                if (i.FilenameExtension.ToLower().Contains(extension.ToLower()))
                {
                    return i;
                }
            }
            return null;
        }
    }
}
