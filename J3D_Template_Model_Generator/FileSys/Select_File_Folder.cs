﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace J3D_Template_Model_Generator.FileSys
{
    class Select_File_Folder
    {
        public static string Folder_Select() {
            //FolderBrowserDialogクラスのインスタンスを作成
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //上部に表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください。";
            //ルートフォルダを指定する
            //デフォルトでDesktop
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            //最初に選択するフォルダを指定する
            //RootFolder以下にあるフォルダである必要がある
            fbd.SelectedPath = @"c:\";
            //ユーザーが新しいフォルダを作成できるようにする
            //デフォルトでTrue
            fbd.ShowNewFolderButton = true;
            //ダイアログを表示する
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //選択されたフォルダを表示する
                return fbd.SelectedPath;
            }
            else { 
                return Properties.Resources.DefaultPath;
            }

        }
    }
}
