using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructures
{
    public class FileProcessor
    {
        public FileProcessor()
        {

        }
        
        public void CreateFile()
        {
            using (FileStream fs = File.Create(@"C:\OriginalFile.txt"))
            {
                for (int i = 0; i < 100000000; i++)
                {
                    AddText(fs, i + " This is some text");
                    AddText(fs, " \r\n" + i + " and this is on a new line");
                }
            }
        }

        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }


        public void SplitFile(string inputFile = "C:\\OriginalFile.txt")
        {
            List<string> Packets = new List<string>();
            int nNoofFiles = 0;

            try
            {
                FileStream fs = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
                double fileSize = (double)fs.Length / 1024;
                nNoofFiles = (int)Math.Ceiling(fileSize / (1000 * 1000));
                int SizeofEachFile = (int)Math.Ceiling((double)fs.Length / nNoofFiles);

                for (int i = 0; i < nNoofFiles; i++)
                {
                    string baseFileName = Path.GetFileNameWithoutExtension(inputFile);
                    string Extension = Path.GetExtension(inputFile);

                    FileStream outputFile = new FileStream(Path.GetDirectoryName(inputFile) + "\\" + baseFileName + "." +
                        i.ToString().PadLeft(5, Convert.ToChar("0")) + Extension + ".tmp", FileMode.Create, FileAccess.Write);

                    var mergeFolder = Path.GetDirectoryName(inputFile);

                    int bytesRead = 0;
                    byte[] buffer = new byte[SizeofEachFile];

                    if ((bytesRead = fs.Read(buffer, 0, SizeofEachFile)) > 0)
                    {
                        outputFile.Write(buffer, 0, bytesRead);
                        //outp.Write(buffer, 0, BytesRead);

                        string packet = baseFileName + "." + i.ToString().PadLeft(3, Convert.ToChar("0")) + Extension.ToString();
                        Packets.Add(packet);
                    }

                    outputFile.Close();

                }
                fs.Close();
            }
            catch (Exception Ex)
            {
                throw new ArgumentException(Ex.Message);
            }
        }

        public bool MergeFile(string inputfoldername1)
        {
            bool Output = false;

            try
            {
                string[] tmpfiles = Directory.GetFiles(inputfoldername1, "*.tmp");

                FileStream outPutFile = null;
                string PrevFileName = "";

                foreach (string tempFile in tmpfiles)
                {
                    string fileName = Path.GetFileNameWithoutExtension(tempFile);
                    string baseFileName = fileName.Substring(0, fileName.IndexOf(Convert.ToChar(".")));
                    string extension = Path.GetExtension(fileName);

                    if (!PrevFileName.Equals(baseFileName))
                    {
                        if (outPutFile != null)
                        {
                            outPutFile.Flush();
                            outPutFile.Close();
                        }
                        outPutFile = new FileStream("D:\\" + "\\" + baseFileName + extension, FileMode.OpenOrCreate, FileAccess.Write);

                    }

                    int bytesRead = 0;
                    byte[] buffer = new byte[1024];
                    FileStream inputTempFile = new FileStream(tempFile, FileMode.OpenOrCreate, FileAccess.Read);

                    while ((bytesRead = inputTempFile.Read(buffer, 0, 1024)) > 0)
                        outPutFile.Write(buffer, 0, bytesRead);

                    inputTempFile.Close();
                    File.Delete(tempFile);
                    PrevFileName = baseFileName;

                }

                outPutFile.Close();
            }
            catch
            {

            }

            return Output;

        }
    }
}
