using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_CreateExcelResume
{
    public partial class CreateExcelResume : Form
    {
        public CreateExcelResume()
        {
            InitializeComponent();
        }

        private Image img;

        //选择图片按钮
        private void btn_selectImage_Click(object sender, EventArgs e)
        {
            //需要返回的是地址
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "图片(*.jpg)|*.jpg";    //限定只能使用.jpg文件
            openFile.InitialDirectory = Environment.CurrentDirectory;   //默认当前文件夹
            DialogResult result = openFile.ShowDialog();    //打开文件夹

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                img = Image.FromFile(openFile.FileName);
                SerializeObjectToString serializeTo = new SerializeObjectToString();
                string img_String = serializeTo.SerializeObject(img);   //将图片序列化
                img = (Image)serializeTo.DeserializeObject(img_String); //反序列化回来， 这个可以不用的，方便以后扩展
                this.pictureBox1.Image = img;
                this.pictureBox1.Visible = true;
                //this.pictureBox1.Image.
            }
        }


        //生成按钮
        private void btn_MakeIt_Click(object sender, EventArgs e)
        {
            //【1】定义Excel工作簿对象
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            //【2】获取简历模板的位置
            string excelBookPath = Environment.CurrentDirectory + "\\StudentInfo.xls";
            //【3】将工作簿加载到工作簿集合
            excelApp.Workbooks.Add(excelBookPath);
            //【4】获取要使用的工作表
            Microsoft.Office.Interop.Excel.Worksheet sheet = excelApp.Worksheets[1];

            if (img == null)
            {
                MessageBox.Show("图片还没插入", "没有图片", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                //【5】加载进Excel
                string imagePath = Environment.CurrentDirectory + "\\temp.jpg";
                if (File.Exists(imagePath)) //有这个文件就删掉
                {
                    File.Delete(imagePath);
                }
                else
                {
                    img.Save(imagePath);    //将文件保存到系统目录
                    //加载到Excel（通过坐标确定位置）
                    sheet.Shapes.AddPicture(imagePath, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue, 10, 50, 90, 100);
                    File.Delete(imagePath); //删除暂时生成的图片
                }

                sheet.Cells[4, 4] = this.txtId.Text;
                sheet.Cells[4, 6] = this.txt_Name.Text;
                sheet.Cells[4, 8] = this.txt_Class.Text;
                sheet.Cells[6, 4] = this.txt_Class.Text;
                sheet.Cells[6, 6] = this.txt_Tel.Text;
                sheet.Cells[8, 4] = this.txt_Add.Text;

                sheet.Cells[14, 1] = this.txt_Other.Text;


                //【6】显示预览
                excelApp.Visible = true;
                //excelApp.Sheets.PrintPreview(true); //如果要打印就调用这个


                //【7】释放创建的excel
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                excelApp = null;    //置空
            }
            
        }
    }
}
