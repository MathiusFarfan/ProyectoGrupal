
namespace UI.Desktop.Forms
{
    partial class ViewAgregarDetalleFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAgregarDetalleFactura));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPedidos = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ID_PedidoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEstimadoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.btnAgregarDetalles = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgvDetallePedido = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ID_Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedido)).BeginInit();
            this.SuspendLayout();
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
            this.dgvPedidos.Location = new System.Drawing.Point(1, 11);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 40;
            this.dgvPedidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(498, 162);
            this.dgvPedidos.TabIndex = 47;
            this.dgvPedidos.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            //this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentClick);
            this.dgvPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellDoubleClick);
            // 
            // ID_PedidoE
            // 
            this.ID_PedidoE.FillWeight = 70F;
            this.ID_PedidoE.HeaderText = "ID Pedido";
            this.ID_PedidoE.MinimumWidth = 6;
            this.ID_PedidoE.Name = "ID_PedidoE";
            this.ID_PedidoE.ReadOnly = true;
            // 
            // NombreE
            // 
            this.NombreE.FillWeight = 110.4028F;
            this.NombreE.HeaderText = "Nombres";
            this.NombreE.MinimumWidth = 6;
            this.NombreE.Name = "NombreE";
            this.NombreE.ReadOnly = true;
            // 
            // TotalEstimadoE
            // 
            this.TotalEstimadoE.FillWeight = 137.3481F;
            this.TotalEstimadoE.HeaderText = "Total Estimado";
            this.TotalEstimadoE.MinimumWidth = 6;
            this.TotalEstimadoE.Name = "TotalEstimadoE";
            this.TotalEstimadoE.ReadOnly = true;
            // 
            // FechaE
            // 
            this.FechaE.FillWeight = 89.25281F;
            this.FechaE.HeaderText = "Fecha";
            this.FechaE.MinimumWidth = 6;
            this.FechaE.Name = "FechaE";
            this.FechaE.ReadOnly = true;
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.Color.Black;
            this.Calendar.Location = new System.Drawing.Point(498, 12);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 56;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelected);
            // 
            // btnAgregarDetalles
            // 
            this.btnAgregarDetalles.AllowAnimations = true;
            this.btnAgregarDetalles.AllowMouseEffects = true;
            this.btnAgregarDetalles.AllowToggling = false;
            this.btnAgregarDetalles.AnimationSpeed = 200;
            this.btnAgregarDetalles.AutoGenerateColors = false;
            this.btnAgregarDetalles.AutoRoundBorders = false;
            this.btnAgregarDetalles.AutoSizeLeftIcon = true;
            this.btnAgregarDetalles.AutoSizeRightIcon = true;
            this.btnAgregarDetalles.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDetalles.BackColor1 = System.Drawing.Color.Gray;
            this.btnAgregarDetalles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarDetalles.BackgroundImage")));
            this.btnAgregarDetalles.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarDetalles.ButtonText = "Agregar Detalles a Factura";
            this.btnAgregarDetalles.ButtonTextMarginLeft = 0;
            this.btnAgregarDetalles.ColorContrastOnClick = 45;
            this.btnAgregarDetalles.ColorContrastOnHover = 45;
            this.btnAgregarDetalles.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAgregarDetalles.CustomizableEdges = borderEdges1;
            this.btnAgregarDetalles.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarDetalles.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarDetalles.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarDetalles.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarDetalles.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAgregarDetalles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarDetalles.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDetalles.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDetalles.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarDetalles.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAgregarDetalles.IconMarginLeft = 11;
            this.btnAgregarDetalles.IconPadding = 10;
            this.btnAgregarDetalles.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarDetalles.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarDetalles.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAgregarDetalles.IconSize = 25;
            this.btnAgregarDetalles.IdleBorderColor = System.Drawing.Color.Black;
            this.btnAgregarDetalles.IdleBorderRadius = 1;
            this.btnAgregarDetalles.IdleBorderThickness = 1;
            this.btnAgregarDetalles.IdleFillColor = System.Drawing.Color.Gray;
            this.btnAgregarDetalles.IdleIconLeftImage = null;
            this.btnAgregarDetalles.IdleIconRightImage = null;
            this.btnAgregarDetalles.IndicateFocus = false;
            this.btnAgregarDetalles.Location = new System.Drawing.Point(2, 356);
            this.btnAgregarDetalles.Name = "btnAgregarDetalles";
            this.btnAgregarDetalles.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarDetalles.OnDisabledState.BorderRadius = 1;
            this.btnAgregarDetalles.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarDetalles.OnDisabledState.BorderThickness = 1;
            this.btnAgregarDetalles.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarDetalles.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarDetalles.OnDisabledState.IconLeftImage = null;
            this.btnAgregarDetalles.OnDisabledState.IconRightImage = null;
            this.btnAgregarDetalles.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarDetalles.onHoverState.BorderRadius = 1;
            this.btnAgregarDetalles.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarDetalles.onHoverState.BorderThickness = 1;
            this.btnAgregarDetalles.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.btnAgregarDetalles.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDetalles.onHoverState.IconLeftImage = null;
            this.btnAgregarDetalles.onHoverState.IconRightImage = null;
            this.btnAgregarDetalles.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarDetalles.OnIdleState.BorderRadius = 1;
            this.btnAgregarDetalles.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarDetalles.OnIdleState.BorderThickness = 1;
            this.btnAgregarDetalles.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.btnAgregarDetalles.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDetalles.OnIdleState.IconLeftImage = null;
            this.btnAgregarDetalles.OnIdleState.IconRightImage = null;
            this.btnAgregarDetalles.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarDetalles.OnPressedState.BorderRadius = 1;
            this.btnAgregarDetalles.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarDetalles.OnPressedState.BorderThickness = 1;
            this.btnAgregarDetalles.OnPressedState.FillColor = System.Drawing.Color.Silver;
            this.btnAgregarDetalles.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDetalles.OnPressedState.IconLeftImage = null;
            this.btnAgregarDetalles.OnPressedState.IconRightImage = null;
            this.btnAgregarDetalles.Size = new System.Drawing.Size(159, 28);
            this.btnAgregarDetalles.TabIndex = 65;
            this.btnAgregarDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarDetalles.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarDetalles.TextMarginLeft = 0;
            this.btnAgregarDetalles.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAgregarDetalles.UseDefaultRadiusAndThickness = true;
            this.btnAgregarDetalles.Click += new System.EventHandler(this.btnAgregarDetalles_Click);
            // 
            // dgvDetallePedido
            // 
            this.dgvDetallePedido.AllowCustomTheming = false;
            this.dgvDetallePedido.AllowUserToAddRows = false;
            this.dgvDetallePedido.AllowUserToDeleteRows = false;
            this.dgvDetallePedido.AllowUserToResizeColumns = false;
            this.dgvDetallePedido.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgvDetallePedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetallePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallePedido.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDetallePedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetallePedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetallePedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetallePedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetallePedido.ColumnHeadersHeight = 40;
            this.dgvDetallePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Material,
            this.DNIE,
            this.dataGridViewTextBoxColumn1,
            this.DireccionE,
            this.ApellidoE});
            this.dgvDetallePedido.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvDetallePedido.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDetallePedido.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetallePedido.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvDetallePedido.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDetallePedido.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvDetallePedido.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvDetallePedido.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvDetallePedido.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDetallePedido.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetallePedido.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgvDetallePedido.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetallePedido.CurrentTheme.Name = null;
            this.dgvDetallePedido.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvDetallePedido.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDetallePedido.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetallePedido.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvDetallePedido.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetallePedido.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetallePedido.EnableHeadersVisualStyles = false;
            this.dgvDetallePedido.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvDetallePedido.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvDetallePedido.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDetallePedido.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDetallePedido.Location = new System.Drawing.Point(2, 183);
            this.dgvDetallePedido.Name = "dgvDetallePedido";
            this.dgvDetallePedido.RowHeadersVisible = false;
            this.dgvDetallePedido.RowTemplate.Height = 40;
            this.dgvDetallePedido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDetallePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallePedido.Size = new System.Drawing.Size(723, 167);
            this.dgvDetallePedido.TabIndex = 73;
            this.dgvDetallePedido.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // ID_Material
            // 
            this.ID_Material.FillWeight = 103.7759F;
            this.ID_Material.HeaderText = "ID Material";
            this.ID_Material.Name = "ID_Material";
            // 
            // DNIE
            // 
            this.DNIE.FillWeight = 89.25281F;
            this.DNIE.HeaderText = "Nombre";
            this.DNIE.Name = "DNIE";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 110.4028F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // DireccionE
            // 
            this.DireccionE.FillWeight = 137.3481F;
            this.DireccionE.HeaderText = "Precio Unitario";
            this.DireccionE.Name = "DireccionE";
            // 
            // ApellidoE
            // 
            this.ApellidoE.FillWeight = 153.7886F;
            this.ApellidoE.HeaderText = "Subtotal";
            this.ApellidoE.Name = "ApellidoE";
            // 
            // ViewAgregarDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 384);
            this.Controls.Add(this.dgvDetallePedido);
            this.Controls.Add(this.btnAgregarDetalles);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.dgvPedidos);
            this.Name = "ViewAgregarDetalleFactura";
            this.Text = "ViewAgregarDetalleFactura";
            this.Load += new System.EventHandler(this.ViewAgregarDetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PedidoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEstimadoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaE;
        private System.Windows.Forms.MonthCalendar Calendar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAgregarDetalles;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDetallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoE;
    }
}