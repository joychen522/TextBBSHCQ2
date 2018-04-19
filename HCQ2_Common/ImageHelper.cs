using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace HCQ2_Common
{
    /// <summary>
    ///  图片压缩算法
    /// </summary>
    public class ImageHelper
    {
        /// <summary>
        ///  指定缩放类型（枚举）
        /// </summary>
        public enum ImageCompressType
        {
            //***指定高宽缩放（可能变形）
            Wh = 0,
            //***指定宽，高按比例
            W = 1,
            //***指定高，宽按比例
            H = 2,
            //***指定高宽裁减（不变形）
            Cut = 3,
            //***不指定，使用原始
            N = 4
        }
        /// <summary>
        ///  无损压缩图片
        /// </summary>
        /// <param name="sFile">原图片路径</param>
        /// <param name="dFile">压缩后保存位置</param>
        /// <param name="height">高度</param>
        /// <param name="width">宽度</param>
        /// <param name="flag">压缩质量 1-100</param>
        /// <param name="type">压缩缩放类型</param>
        /// <param name="deal">当新路径和原始路径相同时是否删除原始图片，默认删除，不删除则新文件名称加1</param>
        /// <returns></returns>
        public static bool CompressImage(string sFile, string dFile, int height, int width, int flag, ImageCompressType type, bool deal = true)
        {
            string newFile = dFile;
            if (sFile.Equals(dFile))
                //新路径和原始路径相同时处理
                dFile = dFile.Split('.')[0] + "1" + dFile.Split('.')[1];
            Image iSource = Image.FromFile(sFile);
            ImageFormat tFormat = iSource.RawFormat;

            //****缩放后的宽度和高度
            int towidth = width;
            int toheight = height;

            int x = 0; int y = 0;
            int ow = iSource.Width; int oh = iSource.Height;
            #region 判断类别
            switch (type)
            {
                case ImageCompressType.N://***原始高宽
                    {
                        towidth = ow;
                        toheight = oh;
                    }
                    break;
                case ImageCompressType.Wh://指定高宽缩放（可能变形）
                    {

                    }
                    break;
                case ImageCompressType.W://指定宽，高按比例
                    {
                        toheight = iSource.Height * width / iSource.Width;
                    }
                    break;
                case ImageCompressType.H://指定高，宽按比例
                    {
                        towidth = iSource.Width * height / iSource.Height;
                    }
                    break;
                case ImageCompressType.Cut://指定高宽裁减（不变形）
                    {
                        if (iSource.Width / (double)iSource.Height > towidth / (double)toheight)
                        {
                            ow = iSource.Height * towidth / toheight;
                            y = 0;
                            x = (iSource.Width - ow) / 2;
                        }
                        else
                        {
                            oh = iSource.Width * height / towidth;
                            x = 0;
                            y = (iSource.Height - oh) / 2;
                        }
                    }
                    break;
            }
            #endregion
            var ob = new Bitmap(towidth, toheight);
            Graphics g = Graphics.FromImage(ob);
            g.Clear(Color.WhiteSmoke);
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(iSource, new Rectangle(x, y, towidth, toheight),
                new Rectangle(0, 0, iSource.Width, iSource.Height),
                GraphicsUnit.Pixel);
            g.Dispose();
            //以下代码为保存图片时，设置压缩质量
            var ep = new EncoderParameters();
            var qy = new long[1];
            qy[0] = flag;//设置压缩的比例1-100
            var eParam = new EncoderParameter(Encoder.Quality, qy);
            ep.Param[0] = eParam; 
            try
            {
                ImageCodecInfo[] arrayIci = ImageCodecInfo.GetImageEncoders();
                ImageCodecInfo jpegIcIinfo = arrayIci.FirstOrDefault(t => t.FormatDescription.Equals("JPEG"));
                //如若路径相同是否删除原始文件
                if (sFile.Equals(dFile) && deal && File.Exists(sFile))
                    File.Delete(sFile);
                if (jpegIcIinfo != null)
                    ob.Save(dFile, jpegIcIinfo, ep);//dFile是压缩后的新路径
                else
                    ob.Save(dFile, tFormat);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                eParam.Dispose();
                ep.Dispose();
                iSource.Dispose();
                ob.Dispose();
                if (sFile.Equals(newFile) && deal)
                {
                    //删除原始文件
                    if (File.Exists(sFile))
                        File.Delete(sFile);
                    //更新新文件名称
                    if (File.Exists(dFile))
                        File.Move(dFile, newFile);
                }
            }
        }

        /// <summary>
        /// 把一张图片（png bmp jpeg bmp gif）转换为byte数组
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static byte[] ImageToBytes(string imageUrl)
        {
            Image image = Image.FromFile(@imageUrl);
            ImageFormat format = image.RawFormat;
            using (MemoryStream ms = new MemoryStream())
            {
                if (format.Equals(ImageFormat.Jpeg))
                {
                    image.Save(ms, ImageFormat.Jpeg);
                }
                else if (format.Equals(ImageFormat.Png))
                {
                    image.Save(ms, ImageFormat.Png);
                }
                else if (format.Equals(ImageFormat.Bmp))
                {
                    image.Save(ms, ImageFormat.Bmp);
                }
                else if (format.Equals(ImageFormat.Gif))
                {
                    image.Save(ms, ImageFormat.Gif);
                }
                else if (format.Equals(ImageFormat.Icon))
                {
                    image.Save(ms, ImageFormat.Icon);
                }
                var buffer = new byte[ms.Length];
                //Image.Save()会改变MemoryStream的Position，需要重新Seek到Begin
                ms.Seek(0, SeekOrigin.Begin);
                ms.Read(buffer, 0, buffer.Length);
                image.Dispose();
                return buffer;
            }
        }

        /// <summary>
        /// byte数组转换为Image对象
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static Image BytesToImage(byte[] buffer)
        {
            MemoryStream ms = new MemoryStream(buffer);
            Image image = System.Drawing.Image.FromStream(ms);
            return image;
        }

        /// <summary>
        /// 从图片byte数组得到对应图片的格式，生成一张图片保存到磁盘上。
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static string CreateImageFromBytes(string path,string fileName, byte[] buffer)
        {
            string file = fileName;
            try
            {
                Image image = BytesToImage(buffer);
                ImageFormat format = image.RawFormat;
                if (format.Equals(ImageFormat.Jpeg))
                {
                    file += ".jpeg";
                }
                else if (format.Equals(ImageFormat.Png))
                {
                    file += ".png";
                }
                else if (format.Equals(ImageFormat.Bmp))
                {
                    file += ".bmp";
                }
                else if (format.Equals(ImageFormat.Gif))
                {
                    file += ".gif";
                }
                else if (format.Equals(ImageFormat.Icon))
                {
                    file += ".icon";
                }
                System.IO.FileInfo info = new System.IO.FileInfo(path + "/" + file);
                System.IO.Directory.CreateDirectory(info.Directory.FullName);
                File.WriteAllBytes(path + "/" + file, buffer);
            }
            catch
            {
                
            }
            return file;
        }

        /// <summary>
        ///  将Base64字符串转换为图片
        /// </summary>
        /// <param name="base64"></param>
        /// <returns></returns>
        public static Image Base64ToImage(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            MemoryStream memStream = new MemoryStream(bytes);
            BinaryFormatter binFormatter = new BinaryFormatter();
            Image img = (Image)binFormatter.Deserialize(memStream);
            return img;
        }
    }
}
