using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Web.UI.WebControls;
using System.Data;

namespace Maticsoft.Common
{
    public class PagePublic
    {
        public PagePublic()
		{
		}

        # region // txtFileToDataSet txt文本转成DataSet

        /// <summary>
        /// 将文件中的txt，转换成DataSet
        /// </summary>
        /// <param name="Path">Txt文本</param>
        /// <param name="strSplit">电话分割符</param>
        /// <returns></returns>
        public static DataSet txtFileToDataSet(string Path,char strSplit)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Temp");

            FileStream fs = File.Open(Path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            dt.Columns.Add(new DataColumn("phone", typeof(string)));

            string strRead;
            bool flag = true;

            while (flag)
            {
                strRead = sr.ReadLine();

                if (!string.IsNullOrEmpty(strRead))
                {
                    string[] aryVale = strRead.Split(strSplit);

                    for (int k = 0; k < aryVale.Length; k++)
                    {
                        if (!aryVale.Equals(""))
                        {
                            DataRow dr = dt.NewRow();
                            dr["phone"] = aryVale[k];
                            if (PageValidate.IsPhone(dr["phone"].ToString()) || PageValidate.IsMobilePhone(dr["phone"].ToString()))
                            {
                                dt.Rows.Add(dr);
                            }
                        }
                    }
                }
                else
                {
                    flag = false;
                }
            }

            ds.Tables.Add(dt);
            return ds;
        }

        # endregion

        # region // getUpFilePath 上传文件到服务器目录

        /// <summary>
        /// 上传文件到目录
        /// </summary>
        /// <param name="fuFile">上传控件</param>
        /// <param name="serverPath">物理目录</param>
        /// <param name="tempPath">虚拟目录</param>
        /// <param name="typed">类型 1真实 0虚拟</param>
        /// <returns>路径</returns>
        public static string getUpFilePath(FileUpload fuFile, string serverPath, string tempPath, int typed)
        {
            // 新文件名
            string strFileName = "";

            // 创建目录
            if (!Directory.Exists(serverPath))
            {
                Directory.CreateDirectory(serverPath);
            }
            // 控件当中是否包含文件
            if (fuFile.HasFile)
            {
                // 首先取到上载文件的原始名称
                string fileName = fuFile.FileName;
                // 新文件名
                strFileName = PagePublic.getNewFileName(fileName, fuFile.PostedFile.ContentLength);
                //检查文件是否重名，如果重名则改名后再保存文件
                if (File.Exists(serverPath + strFileName))
                {
                    strFileName = PagePublic.getNewFileName(fileName, fuFile.PostedFile.ContentLength);
                }
                // 上传
                fuFile.SaveAs(serverPath + strFileName);
            }
            // 返回路径名
            if (typed == 0)
            {
                return tempPath + strFileName;
            }
            return serverPath + strFileName;
        }

        # endregion

        # region // getNewFileName 产生一个随机的文件名

        /// <summary>
        /// 产生一个随机的新文件名
        /// </summary>
        /// <param name="FileName">原文件名</param>
        /// <param name="length">原文件大小</param>
        /// <returns></returns>
        public static string getNewFileName(string FileName, int length)
        {
            //跟据文件名产生一个由时间+随机数组成的一个新的文件名 
            string newfilename = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString()
            + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString()
            + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString()
            + DateTime.Now.Millisecond.ToString()
            + length
            + PagePublic.getRandomString(4)
            + FileName.Substring(FileName.LastIndexOf("."), FileName.Length - FileName.LastIndexOf("."));
            return newfilename;
        }

        # endregion

        # region // getRandomString 生成指定长度的随机数字

        /// <summary>
        /// 生成指定长度的随机数字
        /// </summary>
        /// <param name="StrLength">随机数的长度</param>
        /// <returns></returns>
        public static string getRandomString(int StrLength)
        {
            Random ran = new Random();
            string str = "";
            int i = 0;
            do
            {
                int num = (int)(ran.NextDouble() * 122);
                if (num > 47)
                {
                    if (!(((num > 57) & (num < 65)) | ((num > 90) & (num < 97))))
                    {
                        str = str + Convert.ToChar(num);
                        i++;
                    }
                }
            }
            while (i < StrLength);
            return str;
        }

        # endregion
    }
}
