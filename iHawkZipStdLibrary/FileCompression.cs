using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using ICSharpCode.SharpZipLib.Zip;

namespace iHawkZipStdLibrary
{
    /// <summary>
    /// （obsolete）文件压缩、解压缩
    /// </summary>
    public class FileCompression
    {
        #region 加密、压缩文件

        /// <summary>
        /// 压缩文件
        /// </summary>
        /// <param name="fileNames">要打包的文件列表</param>
        /// <param name="gzipFileName">目标文件名</param>
        /// <param name="compressionLevel">压缩品质级别（0~9）</param>
        /// <param name="sleepTimer">休眠时间（单位毫秒）</param>
        public static void Compress(List<FileInfo> fileNames, string gzipFileName, int compressionLevel, int sleepTimer)
        {
            var s = new ZipOutputStream(File.Create(gzipFileName));
            try
            {
                s.SetLevel(compressionLevel); //0 - store only to 9 - means best compression   
                foreach (FileInfo file in fileNames)
                {
                    FileStream fs;
                    try
                    {
                        fs = file.OpenRead();
                    }
                    catch
                    {
                        continue;
                    }

                    //将文件分批读入缓冲区
                    var data = new byte[2048];
                    int size = 2048;
                    var entry = new ZipEntry(Path.GetFileName(file.Name))
                    {DateTime = (file.CreationTime > file.LastWriteTime ? file.LastWriteTime : file.CreationTime)};
                    s.PutNextEntry(entry);
                    while (true)
                    {
                        size = fs.Read(data, 0, size);
                        if (size <= 0) break;
                        s.Write(data, 0, size);
                    }
                    fs.Close();
                    file.Delete();
                    Thread.Sleep(sleepTimer);
                }
            }
            finally
            {
                s.Flush();
                s.Finish();
                s.Close();
            }
        }

        #endregion

        #region 解密、解压缩文件

        /// <summary>   
        /// 解压缩文件   
        /// </summary>   
        /// <param name="gzipFile">压缩包文件名</param>   
        /// <param name="targetPath">解压缩目标路径</param>          
        public static void Decompress(string gzipFile, string targetPath)
        {
            if (!Directory.Exists(targetPath)) Directory.CreateDirectory(targetPath); //生成解压目录
            if (targetPath.Last() != '\\') targetPath += "\\";
            var data = new byte[2048];
            using (var s = new ZipInputStream(File.OpenRead(gzipFile)))
            {
                ZipEntry theEntry;
                while ((theEntry = s.GetNextEntry()) != null)
                {
                    if (theEntry.IsDirectory)
                    {
                        // 该结点是目录   
                        if (!Directory.Exists(targetPath + theEntry.Name))
                            Directory.CreateDirectory(targetPath + theEntry.Name);
                    }
                    else
                    {
                        if (theEntry.Name != String.Empty)
                        {
                            //解压文件到指定的目录   
                            using (FileStream streamWriter = File.Create(targetPath + theEntry.Name))
                            {
                                while (true)
                                {
                                    int size = s.Read(data, 0, data.Length);
                                    if (size <= 0) break;
                                    streamWriter.Write(data, 0, size);
                                }
                                streamWriter.Close();
                            }
                        }
                    }
                }
                s.Close();
            }
        }

        #endregion
    }
}
