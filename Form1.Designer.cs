
namespace _7zip_example
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_select = new System.Windows.Forms.Button();
            this.txt_folder = new System.Windows.Forms.TextBox();
            this.btn_zip = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.list_folders = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(12, 12);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(114, 23);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "select folder";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // txt_folder
            // 
            this.txt_folder.Location = new System.Drawing.Point(132, 14);
            this.txt_folder.Name = "txt_folder";
            this.txt_folder.Size = new System.Drawing.Size(301, 21);
            this.txt_folder.TabIndex = 1;
            // 
            // btn_zip
            // 
            this.btn_zip.Location = new System.Drawing.Point(12, 71);
            this.btn_zip.Name = "btn_zip";
            this.btn_zip.Size = new System.Drawing.Size(75, 23);
            this.btn_zip.TabIndex = 2;
            this.btn_zip.Text = "to 7zip";
            this.btn_zip.UseVisualStyleBackColor = true;
            this.btn_zip.Click += new System.EventHandler(this.btn_zip_Click);
            // 
            // list_folders
            // 
            this.list_folders.FormattingEnabled = true;
            this.list_folders.ItemHeight = 12;
            this.list_folders.Location = new System.Drawing.Point(439, 14);
            this.list_folders.Name = "list_folders";
            this.list_folders.Size = new System.Drawing.Size(349, 400);
            this.list_folders.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_folders);
            this.Controls.Add(this.btn_zip);
            this.Controls.Add(this.txt_folder);
            this.Controls.Add(this.btn_select);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.TextBox txt_folder;
        private System.Windows.Forms.Button btn_zip;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox list_folders;
    }
}

