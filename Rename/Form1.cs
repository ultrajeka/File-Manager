using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rename
{
    public partial class MainForm : Form
    {
        string index, index2;

        public MainForm()
        {
            InitializeComponent();
            DriveTreeInit();

        }       
       
        private void MainForm_Load(object sender, EventArgs e)
        {                                  
            ShowInfoInListView(lwShowInfoWin1, @"D:\");
            ShowInfoInListView(lwShowInfoWin2, @"D:\");            
        }        
        
        //Переименовать Файл
        private void btnRename_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            RenameForm rf = new RenameForm();

            string path = lblPathWin1.Text;
            string oldName = lwShowInfoWin1.SelectedItems[0].Text; // тут 

            rf.tbNewName.Text = oldName;
            dr = rf.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string localPath = Path.Combine(path, lwShowInfoWin1.SelectedItems[0].Text); // и тут
                string newName = rf.tbNewName.Text;

                if (File.Exists(localPath))
                {
                    File.Move(localPath, Path.Combine(path, newName));
                    ShowInfoInListView(lwShowInfoWin1, path); 
                }
                else
                {
                    Directory.Move(localPath, Path.Combine(path, newName));
                    ShowInfoInListView(lwShowInfoWin1, path);
                }
            }
        }                        
        
        //Открыть файл или папку двойным кликом Win1
        private void lwShowInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DoubleTabForFiles(lwShowInfoWin1, lblPathWin1.Text);                       
        }
        
        //Открыть файл или папку двойным кликом Win2
        private void lwShowInfoWin2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DoubleTabForFiles(lwShowInfoWin2, lblPathWin2.Text);
        }
        
        //Кнопка Back Win1
        private void btnBackFolder_Click(object sender, EventArgs e)
        {
            string pathForBackFolder = lblPathWin1.Text;

            if (pathForBackFolder != Directory.GetDirectoryRoot(pathForBackFolder))
            {
                pathForBackFolder = Directory.GetParent(pathForBackFolder).ToString();
                ShowInfoInListView(lwShowInfoWin1 ,pathForBackFolder);
            }                     
        }
        
        //Кнопка Back Win2
        private void btnBackFolderWin2_Click(object sender, EventArgs e)
        {
            string pathForBackFolder = lblPathWin2.Text;

            if (pathForBackFolder != Directory.GetDirectoryRoot(pathForBackFolder))
            {
                pathForBackFolder = Directory.GetParent(pathForBackFolder).ToString();
                ShowInfoInListView(lwShowInfoWin2, pathForBackFolder);
            }
        }

        //Кнопка удалить
        private void btnDeleteFilesFolders_Click(object sender, EventArgs e)
        {            
            if (index !=  null)
            {
                DeleteFiles(lwShowInfoWin1, lblPathWin1.Text);
                index = null;

            }
            else if (index2 != null)
            {
                DeleteFiles(lwShowInfoWin2, lblPathWin2.Text);
                index2 = null;
            }
            ShowInfoInListView(lwShowInfoWin1, lblPathWin1.Text);
            ShowInfoInListView(lwShowInfoWin2, lblPathWin2.Text);
        }        
        
        //Открыть диск С Win2
        private void btnDir_C_Win2_Click(object sender, EventArgs e)
        {
            ShowInfoInListView(lwShowInfoWin2, @"C:\");
        }
        
        //Открыть диск D Win2
        private void btnDir_D_Win2_Click(object sender, EventArgs e)
        {
            ShowInfoInListView(lwShowInfoWin2, @"D:\");
        }

        //Открыть диск E Win2
        private void btnDir_E_Win2_Click(object sender, EventArgs e)
        {
            ShowInfoInListView(lwShowInfoWin2, @"E:\");            
        }

        //Метод Двойной клик по файлу
        void DoubleTabForFiles(ListView lv, string path)
        {
            string newPath = Path.Combine(path, lv.SelectedItems[0].Text);
            if (Path.GetExtension(newPath) == "")
            {
                ShowInfoInListView(lv, newPath);
                path = newPath;
            }
            else
            {
                Process.Start(newPath);
            }            
        }
        
        //Метод загрузки файлов
        ListView ShowInfoInListView(ListView lv, string path)
        {
            lv.Items.Clear();

            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] allFiles = di.GetFiles();

            foreach (var files in allFiles)
            {
                string ext = files.Extension;
                if (!imageList1.Images.Keys.Contains(ext))
                {
                    imageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(files.FullName));
                }
                int index = imageList1.Images.Keys.IndexOf(ext);
                ListViewItem item = new ListViewItem();
                item.Text = files.Name;
                item.ImageIndex = index;
                lv.Items.Add(item);
            }

            DirectoryInfo[] dirs = di.GetDirectories();
            foreach (var dir in dirs)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dir.Name;
                item.ImageIndex = 0;
                lv.Items.Add(item);

            }
            if (lv == lwShowInfoWin1)
                lblPathWin1.Text = path;
            else
                lblPathWin2.Text = path;
            lv.Sort();
            return lv;
        }

        //Метод удалить файл или папку
        void DeleteFiles(ListView lv, string path)
        {
            if (File.Exists(Path.Combine(path, lv.SelectedItems[0].Text)))
            {
                File.Delete(Path.Combine(path, lv.SelectedItems[0].Text));               
            }
            else
            {
                try
                {                   
                    Directory.Delete(Path.Combine(path, lv.SelectedItems[0].Text));
                }
                catch
                {                    
                    if (MessageBox.Show("Папка не пустая \nУдалить все файлы ?","", MessageBoxButtons.YesNo) == DialogResult.Yes)                    
                        Directory.Delete(Path.Combine(path, lv.SelectedItems[0].Text), true);                     
                }
            }
        }        

        public void DriveTreeInit()
        {
            string[] drivesArray = Directory.GetLogicalDrives();

            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            foreach (string s in drivesArray)
            {
                TreeNode drive = new TreeNode(s, 0, 0);
                treeView1.Nodes.Add(drive);    
                            
            }
            treeView1.EndUpdate();
        }

        private void lwShowInfoWin1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.lwShowInfoWin1.ListViewItemSorter = new ListViewColumnComparer(e.Column);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            string fullPath = selectedNode.FullPath;
            ShowInfoInListView(lwShowInfoWin1, fullPath);            
        }                
    }
}

