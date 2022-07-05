
namespace UI.Desktop.Forms
{
    partial class ViewGestionPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewGestionPedidos));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnDesactivar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnActivar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgvPedidos = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PedidoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEstimadoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtBuscar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnBuscar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.chkSeleccionar = new Bunifu.UI.WinForms.BunifuCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "ESTADO";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(596, 57);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(173, 20);
            this.txtEstado.TabIndex = 48;
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.AllowAnimations = true;
            this.btnDesactivar.AllowMouseEffects = true;
            this.btnDesactivar.AllowToggling = false;
            this.btnDesactivar.AnimationSpeed = 200;
            this.btnDesactivar.AutoGenerateColors = false;
            this.btnDesactivar.AutoRoundBorders = false;
            this.btnDesactivar.AutoSizeLeftIcon = true;
            this.btnDesactivar.AutoSizeRightIcon = true;
            this.btnDesactivar.BackColor = System.Drawing.Color.Transparent;
            this.btnDesactivar.BackColor1 = System.Drawing.Color.Gray;
            this.btnDesactivar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDesactivar.BackgroundImage")));
            this.btnDesactivar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDesactivar.ButtonText = "Desaprobar";
            this.btnDesactivar.ButtonTextMarginLeft = 0;
            this.btnDesactivar.ColorContrastOnClick = 45;
            this.btnDesactivar.ColorContrastOnHover = 45;
            this.btnDesactivar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDesactivar.CustomizableEdges = borderEdges1;
            this.btnDesactivar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDesactivar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDesactivar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDesactivar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDesactivar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDesactivar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDesactivar.ForeColor = System.Drawing.Color.White;
            this.btnDesactivar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesactivar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDesactivar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDesactivar.IconMarginLeft = 11;
            this.btnDesactivar.IconPadding = 10;
            this.btnDesactivar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesactivar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDesactivar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDesactivar.IconSize = 25;
            this.btnDesactivar.IdleBorderColor = System.Drawing.Color.Gray;
            this.btnDesactivar.IdleBorderRadius = 20;
            this.btnDesactivar.IdleBorderThickness = 1;
            this.btnDesactivar.IdleFillColor = System.Drawing.Color.Gray;
            this.btnDesactivar.IdleIconLeftImage = null;
            this.btnDesactivar.IdleIconRightImage = null;
            this.btnDesactivar.IndicateFocus = false;
            this.btnDesactivar.Location = new System.Drawing.Point(686, 423);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDesactivar.OnDisabledState.BorderRadius = 20;
            this.btnDesactivar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDesactivar.OnDisabledState.BorderThickness = 1;
            this.btnDesactivar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDesactivar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDesactivar.OnDisabledState.IconLeftImage = null;
            this.btnDesactivar.OnDisabledState.IconRightImage = null;
            this.btnDesactivar.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnDesactivar.onHoverState.BorderRadius = 20;
            this.btnDesactivar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDesactivar.onHoverState.BorderThickness = 1;
            this.btnDesactivar.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btnDesactivar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDesactivar.onHoverState.IconLeftImage = null;
            this.btnDesactivar.onHoverState.IconRightImage = null;
            this.btnDesactivar.OnIdleState.BorderColor = System.Drawing.Color.Gray;
            this.btnDesactivar.OnIdleState.BorderRadius = 20;
            this.btnDesactivar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDesactivar.OnIdleState.BorderThickness = 1;
            this.btnDesactivar.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.btnDesactivar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDesactivar.OnIdleState.IconLeftImage = null;
            this.btnDesactivar.OnIdleState.IconRightImage = null;
            this.btnDesactivar.OnPressedState.BorderColor = System.Drawing.Color.Gray;
            this.btnDesactivar.OnPressedState.BorderRadius = 20;
            this.btnDesactivar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDesactivar.OnPressedState.BorderThickness = 1;
            this.btnDesactivar.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.btnDesactivar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDesactivar.OnPressedState.IconLeftImage = null;
            this.btnDesactivar.OnPressedState.IconRightImage = null;
            this.btnDesactivar.Size = new System.Drawing.Size(95, 29);
            this.btnDesactivar.TabIndex = 47;
            this.btnDesactivar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDesactivar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDesactivar.TextMarginLeft = 0;
            this.btnDesactivar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDesactivar.UseDefaultRadiusAndThickness = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.AllowAnimations = true;
            this.btnActivar.AllowMouseEffects = true;
            this.btnActivar.AllowToggling = false;
            this.btnActivar.AnimationSpeed = 200;
            this.btnActivar.AutoGenerateColors = false;
            this.btnActivar.AutoRoundBorders = false;
            this.btnActivar.AutoSizeLeftIcon = true;
            this.btnActivar.AutoSizeRightIcon = true;
            this.btnActivar.BackColor = System.Drawing.Color.Transparent;
            this.btnActivar.BackColor1 = System.Drawing.Color.Gray;
            this.btnActivar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActivar.BackgroundImage")));
            this.btnActivar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActivar.ButtonText = "Aprobar";
            this.btnActivar.ButtonTextMarginLeft = 0;
            this.btnActivar.ColorContrastOnClick = 45;
            this.btnActivar.ColorContrastOnHover = 45;
            this.btnActivar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnActivar.CustomizableEdges = borderEdges2;
            this.btnActivar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnActivar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnActivar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnActivar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnActivar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnActivar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnActivar.ForeColor = System.Drawing.Color.White;
            this.btnActivar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnActivar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnActivar.IconMarginLeft = 11;
            this.btnActivar.IconPadding = 10;
            this.btnActivar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnActivar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnActivar.IconSize = 25;
            this.btnActivar.IdleBorderColor = System.Drawing.Color.Gray;
            this.btnActivar.IdleBorderRadius = 20;
            this.btnActivar.IdleBorderThickness = 1;
            this.btnActivar.IdleFillColor = System.Drawing.Color.Gray;
            this.btnActivar.IdleIconLeftImage = null;
            this.btnActivar.IdleIconRightImage = null;
            this.btnActivar.IndicateFocus = false;
            this.btnActivar.Location = new System.Drawing.Point(584, 423);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnActivar.OnDisabledState.BorderRadius = 20;
            this.btnActivar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActivar.OnDisabledState.BorderThickness = 1;
            this.btnActivar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnActivar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnActivar.OnDisabledState.IconLeftImage = null;
            this.btnActivar.OnDisabledState.IconRightImage = null;
            this.btnActivar.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnActivar.onHoverState.BorderRadius = 20;
            this.btnActivar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActivar.onHoverState.BorderThickness = 1;
            this.btnActivar.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btnActivar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnActivar.onHoverState.IconLeftImage = null;
            this.btnActivar.onHoverState.IconRightImage = null;
            this.btnActivar.OnIdleState.BorderColor = System.Drawing.Color.Gray;
            this.btnActivar.OnIdleState.BorderRadius = 20;
            this.btnActivar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActivar.OnIdleState.BorderThickness = 1;
            this.btnActivar.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.btnActivar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnActivar.OnIdleState.IconLeftImage = null;
            this.btnActivar.OnIdleState.IconRightImage = null;
            this.btnActivar.OnPressedState.BorderColor = System.Drawing.Color.Gray;
            this.btnActivar.OnPressedState.BorderRadius = 20;
            this.btnActivar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActivar.OnPressedState.BorderThickness = 1;
            this.btnActivar.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.btnActivar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnActivar.OnPressedState.IconLeftImage = null;
            this.btnActivar.OnPressedState.IconRightImage = null;
            this.btnActivar.Size = new System.Drawing.Size(95, 29);
            this.btnActivar.TabIndex = 46;
            this.btnActivar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActivar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnActivar.TextMarginLeft = 0;
            this.btnActivar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnActivar.UseDefaultRadiusAndThickness = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowCustomTheming = false;
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToResizeColumns = false;
            this.dgvPedidos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.ColumnHeadersHeight = 40;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.ID_PedidoE,
            this.NombreE,
            this.TotalEstimadoE,
            this.FechaE});
            this.dgvPedidos.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvPedidos.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPedidos.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPedidos.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvPedidos.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPedidos.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvPedidos.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvPedidos.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvPedidos.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvPedidos.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPedidos.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgvPedidos.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPedidos.CurrentTheme.Name = null;
            this.dgvPedidos.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvPedidos.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPedidos.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPedidos.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvPedidos.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvPedidos.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvPedidos.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvPedidos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPedidos.Location = new System.Drawing.Point(14, 129);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 40;
            this.dgvPedidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(753, 288);
            this.dgvPedidos.TabIndex = 45;
            this.dgvPedidos.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.FillWeight = 50F;
            this.Seleccionar.HeaderText = "Marcar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            // 
            // ID_PedidoE
            // 
            this.ID_PedidoE.FillWeight = 70F;
            this.ID_PedidoE.HeaderText = "ID Pedido";
            this.ID_PedidoE.MinimumWidth = 6;
            this.ID_PedidoE.Name = "ID_PedidoE";
            // 
            // NombreE
            // 
            this.NombreE.FillWeight = 110.4028F;
            this.NombreE.HeaderText = "Nombres";
            this.NombreE.MinimumWidth = 6;
            this.NombreE.Name = "NombreE";
            // 
            // TotalEstimadoE
            // 
            this.TotalEstimadoE.FillWeight = 137.3481F;
            this.TotalEstimadoE.HeaderText = "Total Estimado";
            this.TotalEstimadoE.MinimumWidth = 6;
            this.TotalEstimadoE.Name = "TotalEstimadoE";
            // 
            // FechaE
            // 
            this.FechaE.FillWeight = 89.25281F;
            this.FechaE.HeaderText = "Fecha";
            this.FechaE.MinimumWidth = 6;
            this.FechaE.Name = "FechaE";
            // 
            // label1
            // 
            this.label1.AllowParentOverrides = false;
            this.label1.AutoEllipsis = false;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.CursorType = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(296, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "Gestion de Pedidos";
            this.label1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.label1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AcceptsReturn = false;
            this.txtBuscar.AcceptsTab = false;
            this.txtBuscar.AnimationSpeed = 200;
            this.txtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtBuscar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBuscar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBuscar.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBuscar.BorderRadius = 1;
            this.txtBuscar.BorderThickness = 1;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.FillColor = System.Drawing.Color.White;
            this.txtBuscar.HideSelection = true;
            this.txtBuscar.IconLeft = null;
            this.txtBuscar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.IconPadding = 10;
            this.txtBuscar.IconRight = null;
            this.txtBuscar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(14, 80);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBuscar.Modified = false;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.OnIdleState = stateProperties4;
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBuscar.PlaceholderText = "Enter text";
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(260, 25);
            this.txtBuscar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBuscar.TabIndex = 43;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.TextMarginBottom = 0;
            this.txtBuscar.TextMarginLeft = 3;
            this.txtBuscar.TextMarginTop = 0;
            this.txtBuscar.TextPlaceholder = "Enter text";
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.WordWrap = true;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ActiveImage = null;
            this.btnBuscar.AllowAnimations = true;
            this.btnBuscar.AllowBuffering = false;
            this.btnBuscar.AllowToggling = false;
            this.btnBuscar.AllowZooming = true;
            this.btnBuscar.AllowZoomingOnFocus = false;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.ErrorImage")));
            this.btnBuscar.FadeWhenInactive = false;
            this.btnBuscar.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageActive = null;
            this.btnBuscar.ImageLocation = null;
            this.btnBuscar.ImageMargin = 0;
            this.btnBuscar.ImageSize = new System.Drawing.Size(34, 34);
            this.btnBuscar.ImageZoomSize = new System.Drawing.Size(35, 35);
            this.btnBuscar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.InitialImage")));
            this.btnBuscar.Location = new System.Drawing.Point(296, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0;
            this.btnBuscar.ShowActiveImage = true;
            this.btnBuscar.ShowCursorChanges = true;
            this.btnBuscar.ShowImageBorders = false;
            this.btnBuscar.ShowSizeMarkers = false;
            this.btnBuscar.Size = new System.Drawing.Size(35, 35);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.ToolTipText = "";
            this.btnBuscar.WaitOnLoad = false;
            this.btnBuscar.Zoom = 0;
            this.btnBuscar.ZoomSpeed = 10;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AllowBindingControlAnimation = true;
            this.chkSeleccionar.AllowBindingControlColorChanges = false;
            this.chkSeleccionar.AllowBindingControlLocation = true;
            this.chkSeleccionar.AllowCheckBoxAnimation = false;
            this.chkSeleccionar.AllowCheckmarkAnimation = true;
            this.chkSeleccionar.AllowOnHoverStates = true;
            this.chkSeleccionar.AutoCheck = true;
            this.chkSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.chkSeleccionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkSeleccionar.BackgroundImage")));
            this.chkSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkSeleccionar.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkSeleccionar.BorderRadius = 12;
            this.chkSeleccionar.Checked = true;
            this.chkSeleccionar.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.chkSeleccionar.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkSeleccionar.CustomCheckmarkImage = null;
            this.chkSeleccionar.Location = new System.Drawing.Point(14, 430);
            this.chkSeleccionar.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.OnCheck.BorderColor = System.Drawing.Color.Gray;
            this.chkSeleccionar.OnCheck.BorderRadius = 12;
            this.chkSeleccionar.OnCheck.BorderThickness = 2;
            this.chkSeleccionar.OnCheck.CheckBoxColor = System.Drawing.Color.Gray;
            this.chkSeleccionar.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkSeleccionar.OnCheck.CheckmarkThickness = 2;
            this.chkSeleccionar.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkSeleccionar.OnDisable.BorderRadius = 12;
            this.chkSeleccionar.OnDisable.BorderThickness = 2;
            this.chkSeleccionar.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkSeleccionar.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkSeleccionar.OnDisable.CheckmarkThickness = 2;
            this.chkSeleccionar.OnHoverChecked.BorderColor = System.Drawing.Color.Gray;
            this.chkSeleccionar.OnHoverChecked.BorderRadius = 12;
            this.chkSeleccionar.OnHoverChecked.BorderThickness = 2;
            this.chkSeleccionar.OnHoverChecked.CheckBoxColor = System.Drawing.Color.Gray;
            this.chkSeleccionar.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chkSeleccionar.OnHoverChecked.CheckmarkThickness = 2;
            this.chkSeleccionar.OnHoverUnchecked.BorderColor = System.Drawing.Color.Gray;
            this.chkSeleccionar.OnHoverUnchecked.BorderRadius = 12;
            this.chkSeleccionar.OnHoverUnchecked.BorderThickness = 1;
            this.chkSeleccionar.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkSeleccionar.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.chkSeleccionar.OnUncheck.BorderRadius = 12;
            this.chkSeleccionar.OnUncheck.BorderThickness = 1;
            this.chkSeleccionar.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkSeleccionar.Size = new System.Drawing.Size(21, 21);
            this.chkSeleccionar.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkSeleccionar.TabIndex = 50;
            this.chkSeleccionar.ThreeState = false;
            this.chkSeleccionar.ToolTipText = null;
            this.chkSeleccionar.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.chkSeleccionar_CheckedChanged);
            // 
            // ViewGestionPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 463);
            this.Controls.Add(this.chkSeleccionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewGestionPedidos";
            this.Text = "ViewGestionPedidos";
            this.Load += new System.EventHandler(this.ViewGestionPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstado;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDesactivar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnActivar;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PedidoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEstimadoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaE;
        private Bunifu.UI.WinForms.BunifuLabel label1;
        private Bunifu.UI.WinForms.BunifuTextBox txtBuscar;
        private Bunifu.UI.WinForms.BunifuImageButton btnBuscar;
        private Bunifu.UI.WinForms.BunifuCheckBox chkSeleccionar;
    }
}