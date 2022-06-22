using System.Collections.Generic;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

namespace iHawkZipStdLibrary
{
    /// <summary>
    /// 文件压缩器
    /// </summary>
    public class MyCompresser
    {
        /// <summary>
        /// 压缩zip缓存
        /// </summary>
        /// <param name="fileNames">压缩文件列表</param>
        /// <returns>zip缓存</returns>
        public byte[] CompressZipBuffer(List<string> fileNames)
        {
            byte[] buf;
            using (var ms = new MemoryStream())
            {
                using (var zip = ZipFile.Create(ms))
                {
                    zip.BeginUpdate();
                    zip.NameTransform = new MyNameTransform(); //通过这个名称格式化器，可以将里面的文件名进行一些处理。默认情况下，会自动根据文件的路径在zip中创建有关的文件夹。

                    foreach (string fileName in fileNames) if (!string.IsNullOrWhiteSpace(fileName) && File.Exists(fileName)) zip.Add(fileName);
                    zip.CommitUpdate();

                    buf = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(buf, 0, buf.Length);
                }
                ms.Close();
            }
            return buf;
        }
    }
}
