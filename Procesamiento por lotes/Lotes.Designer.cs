namespace Procesamiento_por_lotes
{
    partial class Lotes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lotes));
            this.add_process = new System.Windows.Forms.Button();
            this.wait_lot_label = new System.Windows.Forms.Label();
            this.lot_label = new System.Windows.Forms.Label();
            this.execute_groupbox = new System.Windows.Forms.GroupBox();
            this.tr_label = new System.Windows.Forms.Label();
            this.tt_label = new System.Windows.Forms.Label();
            this.tme_label = new System.Windows.Forms.Label();
            this.op_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.end_lot_label = new System.Windows.Forms.Label();
            this.crono_label = new System.Windows.Forms.Label();
            this.execute_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.time_label = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.state = new System.Windows.Forms.Label();
            this.execute_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_process
            // 
            this.add_process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add_process.Location = new System.Drawing.Point(136, 17);
            this.add_process.Name = "add_process";
            this.add_process.Size = new System.Drawing.Size(76, 39);
            this.add_process.TabIndex = 0;
            this.add_process.Text = "Agregar Procesos";
            this.add_process.UseVisualStyleBackColor = false;
            this.add_process.Click += new System.EventHandler(this.add_process_Click);
            // 
            // wait_lot_label
            // 
            this.wait_lot_label.AutoSize = true;
            this.wait_lot_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wait_lot_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wait_lot_label.Location = new System.Drawing.Point(12, 108);
            this.wait_lot_label.Name = "wait_lot_label";
            this.wait_lot_label.Size = new System.Drawing.Size(142, 13);
            this.wait_lot_label.TabIndex = 1;
            this.wait_lot_label.Text = "Número de lotes pendientes:";
            // 
            // lot_label
            // 
            this.lot_label.AutoSize = true;
            this.lot_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lot_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lot_label.Location = new System.Drawing.Point(12, 139);
            this.lot_label.Name = "lot_label";
            this.lot_label.Size = new System.Drawing.Size(63, 13);
            this.lot_label.TabIndex = 2;
            this.lot_label.Text = "Lote actual:";
            // 
            // execute_groupbox
            // 
            this.execute_groupbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.execute_groupbox.Controls.Add(this.tr_label);
            this.execute_groupbox.Controls.Add(this.tt_label);
            this.execute_groupbox.Controls.Add(this.tme_label);
            this.execute_groupbox.Controls.Add(this.op_label);
            this.execute_groupbox.Controls.Add(this.id_label);
            this.execute_groupbox.Location = new System.Drawing.Point(363, 108);
            this.execute_groupbox.Name = "execute_groupbox";
            this.execute_groupbox.Size = new System.Drawing.Size(190, 201);
            this.execute_groupbox.TabIndex = 3;
            this.execute_groupbox.TabStop = false;
            this.execute_groupbox.Text = "Proceso en ejecución";
            // 
            // tr_label
            // 
            this.tr_label.AutoSize = true;
            this.tr_label.Location = new System.Drawing.Point(15, 170);
            this.tr_label.Name = "tr_label";
            this.tr_label.Size = new System.Drawing.Size(91, 13);
            this.tr_label.TabIndex = 5;
            this.tr_label.Text = "Tiempo Restante:";
            // 
            // tt_label
            // 
            this.tt_label.AutoSize = true;
            this.tt_label.Location = new System.Drawing.Point(12, 134);
            this.tt_label.Name = "tt_label";
            this.tt_label.Size = new System.Drawing.Size(107, 13);
            this.tt_label.TabIndex = 4;
            this.tt_label.Text = "Tiempo Transcurrido:";
            // 
            // tme_label
            // 
            this.tme_label.AutoSize = true;
            this.tme_label.Location = new System.Drawing.Point(12, 101);
            this.tme_label.Name = "tme_label";
            this.tme_label.Size = new System.Drawing.Size(130, 13);
            this.tme_label.TabIndex = 3;
            this.tme_label.Text = "Tiempo Máximo Estimado:";
            // 
            // op_label
            // 
            this.op_label.AutoSize = true;
            this.op_label.Location = new System.Drawing.Point(15, 65);
            this.op_label.Name = "op_label";
            this.op_label.Size = new System.Drawing.Size(59, 13);
            this.op_label.TabIndex = 2;
            this.op_label.Text = "Operación:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(15, 31);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(21, 13);
            this.id_label.TabIndex = 1;
            this.id_label.Text = "ID:";
            // 
            // end_lot_label
            // 
            this.end_lot_label.AutoSize = true;
            this.end_lot_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.end_lot_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.end_lot_label.Location = new System.Drawing.Point(556, 82);
            this.end_lot_label.Name = "end_lot_label";
            this.end_lot_label.Size = new System.Drawing.Size(108, 13);
            this.end_lot_label.TabIndex = 4;
            this.end_lot_label.Text = "Procesos terminados:";
            // 
            // crono_label
            // 
            this.crono_label.AutoSize = true;
            this.crono_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.crono_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.crono_label.Location = new System.Drawing.Point(520, 12);
            this.crono_label.Name = "crono_label";
            this.crono_label.Size = new System.Drawing.Size(110, 13);
            this.crono_label.TabIndex = 5;
            this.crono_label.Text = "Tiempo Transcurrido: ";
            // 
            // execute_btn
            // 
            this.execute_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.execute_btn.Location = new System.Drawing.Point(17, 17);
            this.execute_btn.Name = "execute_btn";
            this.execute_btn.Size = new System.Drawing.Size(76, 35);
            this.execute_btn.TabIndex = 6;
            this.execute_btn.Text = "Cargar lote";
            this.execute_btn.UseVisualStyleBackColor = false;
            this.execute_btn.Click += new System.EventHandler(this.execute_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TME,
            this.TT});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 136);
            this.dataGridView1.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // TME
            // 
            this.TME.HeaderText = "TME";
            this.TME.Name = "TME";
            // 
            // TT
            // 
            this.TT.HeaderText = "TR";
            this.TT.Name = "TT";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Operacion,
            this.Resultado,
            this.Lote});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.Location = new System.Drawing.Point(559, 108);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(441, 354);
            this.dataGridView2.TabIndex = 8;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            // 
            // Operacion
            // 
            this.Operacion.HeaderText = "Operación";
            this.Operacion.Name = "Operacion";
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.Name = "Resultado";
            // 
            // Lote
            // 
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Yellow;
            this.start.Location = new System.Drawing.Point(114, 17);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(78, 35);
            this.start.TabIndex = 9;
            this.start.Text = "Iniciar";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.time_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.time_label.Location = new System.Drawing.Point(636, 12);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(13, 13);
            this.time_label.TabIndex = 10;
            this.time_label.Text = "0";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Red;
            this.reset.Location = new System.Drawing.Point(852, 12);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(80, 48);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reiniciar";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(6, 28);
            this.cantidad.MaxLength = 3;
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(96, 20);
            this.cantidad.TabIndex = 12;
            this.cantidad.Text = "1";
            this.cantidad.TextChanged += new System.EventHandler(this.cantidad_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cantidad);
            this.groupBox1.Controls.Add(this.add_process);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 64);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Nuevos Lotes";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.execute_btn);
            this.groupBox2.Controls.Add(this.start);
            this.groupBox2.Location = new System.Drawing.Point(264, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 64);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ejecutar";
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192))))); 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(495, 57);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(0, 13);
            this.state.TabIndex = 15;
            // 
            // Lotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1012, 445);
            this.Controls.Add(this.state);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.crono_label);
            this.Controls.Add(this.end_lot_label);
            this.Controls.Add(this.execute_groupbox);
            this.Controls.Add(this.lot_label);
            this.Controls.Add(this.wait_lot_label);
            this.KeyPreview = true;
            this.Name = "Lotes";
            this.Text = "Procesamiento por Lotes";
            this.Load += new System.EventHandler(this.Lotes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lotes_KeyDown);
            this.execute_groupbox.ResumeLayout(false);
            this.execute_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_process;
        private System.Windows.Forms.Label wait_lot_label;
        private System.Windows.Forms.Label lot_label;
        private System.Windows.Forms.GroupBox execute_groupbox;
        private System.Windows.Forms.Label tr_label;
        private System.Windows.Forms.Label tt_label;
        private System.Windows.Forms.Label tme_label;
        private System.Windows.Forms.Label op_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label end_lot_label;
        private System.Windows.Forms.Label crono_label;
        private System.Windows.Forms.Button execute_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.Label state;
    }
}

