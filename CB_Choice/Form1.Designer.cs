namespace CB_Choice
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
            this.cbList = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbList
            // 
            this.cbList.BackColor = System.Drawing.Color.Plum;
            this.cbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbList.FormattingEnabled = true;
            this.cbList.Location = new System.Drawing.Point(53, 23);
            this.cbList.Name = "cbList";
            this.cbList.Size = new System.Drawing.Size(206, 20);
            this.cbList.TabIndex = 0;
            this.cbList.SelectedIndexChanged += new System.EventHandler(this.CbList_SelectedIndexChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("조선일보명조", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(50, 103);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(89, 16);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "선택 결과 : ";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleName = "추가";
            this.btnAdd.BackColor = System.Drawing.Color.Salmon;
            this.btnAdd.Font = new System.Drawing.Font("조선일보명조", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(265, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 21);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(53, 60);
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(206, 21);
            this.txtList.TabIndex = 4;
            this.txtList.TextChanged += new System.EventHandler(this.TxtList_TextChanged);
            this.txtList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtList_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(369, 146);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cbList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "메뉴 선택 추가";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbList;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtList;
    }
}

