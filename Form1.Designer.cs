namespace Record
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnStartRecording_Click = new System.Windows.Forms.Button();
            this.BtnStopRecording_Click = new System.Windows.Forms.Button();
            this.BtnStartPlayback_Click = new System.Windows.Forms.Button();
            this.BtnStopPlayback_Click = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_sobre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStartRecording_Click
            // 
            this.BtnStartRecording_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStartRecording_Click.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartRecording_Click.Location = new System.Drawing.Point(0, -1);
            this.BtnStartRecording_Click.Name = "BtnStartRecording_Click";
            this.BtnStartRecording_Click.Size = new System.Drawing.Size(189, 130);
            this.BtnStartRecording_Click.TabIndex = 0;
            this.BtnStartRecording_Click.Text = "Gravar";
            this.BtnStartRecording_Click.UseVisualStyleBackColor = true;
            this.BtnStartRecording_Click.Click += new System.EventHandler(this.BtnStartRecording_Click_Click);
            // 
            // BtnStopRecording_Click
            // 
            this.BtnStopRecording_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStopRecording_Click.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.BtnStopRecording_Click.Location = new System.Drawing.Point(195, -1);
            this.BtnStopRecording_Click.Name = "BtnStopRecording_Click";
            this.BtnStopRecording_Click.Size = new System.Drawing.Size(189, 130);
            this.BtnStopRecording_Click.TabIndex = 1;
            this.BtnStopRecording_Click.Text = "Parar de Gravar";
            this.BtnStopRecording_Click.UseVisualStyleBackColor = true;
            this.BtnStopRecording_Click.Click += new System.EventHandler(this.BtnStopRecording_Click_Click);
            // 
            // BtnStartPlayback_Click
            // 
            this.BtnStartPlayback_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStartPlayback_Click.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.BtnStartPlayback_Click.Location = new System.Drawing.Point(390, -1);
            this.BtnStartPlayback_Click.Name = "BtnStartPlayback_Click";
            this.BtnStartPlayback_Click.Size = new System.Drawing.Size(189, 130);
            this.BtnStartPlayback_Click.TabIndex = 2;
            this.BtnStartPlayback_Click.Text = "Reproduzir";
            this.BtnStartPlayback_Click.UseVisualStyleBackColor = true;
            this.BtnStartPlayback_Click.Click += new System.EventHandler(this.BtnStartPlayback_Click_Click);
            // 
            // BtnStopPlayback_Click
            // 
            this.BtnStopPlayback_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStopPlayback_Click.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.BtnStopPlayback_Click.Location = new System.Drawing.Point(585, -1);
            this.BtnStopPlayback_Click.Name = "BtnStopPlayback_Click";
            this.BtnStopPlayback_Click.Size = new System.Drawing.Size(189, 130);
            this.BtnStopPlayback_Click.TabIndex = 3;
            this.BtnStopPlayback_Click.Text = "Parar de Reproduzir";
            this.BtnStopPlayback_Click.UseVisualStyleBackColor = true;
            this.BtnStopPlayback_Click.Click += new System.EventHandler(this.BtnStopPlayback_Click_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_sobre
            // 
            this.btn_sobre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_sobre.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.btn_sobre.Location = new System.Drawing.Point(0, 134);
            this.btn_sobre.Name = "btn_sobre";
            this.btn_sobre.Size = new System.Drawing.Size(772, 49);
            this.btn_sobre.TabIndex = 4;
            this.btn_sobre.Text = "Sobre o programa";
            this.btn_sobre.UseVisualStyleBackColor = true;
            this.btn_sobre.Click += new System.EventHandler(this.btn_sobre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(772, 183);
            this.Controls.Add(this.btn_sobre);
            this.Controls.Add(this.BtnStopPlayback_Click);
            this.Controls.Add(this.BtnStartPlayback_Click);
            this.Controls.Add(this.BtnStopRecording_Click);
            this.Controls.Add(this.BtnStartRecording_Click);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gravador de Audio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStartRecording_Click;
        private System.Windows.Forms.Button BtnStopRecording_Click;
        private System.Windows.Forms.Button BtnStartPlayback_Click;
        private System.Windows.Forms.Button BtnStopPlayback_Click;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_sobre;
    }
}

