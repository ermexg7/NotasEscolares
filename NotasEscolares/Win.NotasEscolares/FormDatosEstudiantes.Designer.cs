namespace Win.NotasEscolares
{
    partial class FormDatosEstudiantes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreEncargadoLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label telefonoEncargadoLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label seccionLabel;
            System.Windows.Forms.Label correoElectronicoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label gradoIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosEstudiantes));
            System.Windows.Forms.Label identidadLabel;
            this.listaEstudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaEstudiantesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaEstudiantesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreEncargadoTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.telefonoEncargadoTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.seccionTextBox = new System.Windows.Forms.TextBox();
            this.correoElectronicoTextBox = new System.Windows.Forms.TextBox();
            this.gradosBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaGradosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradoIdComboBox = new System.Windows.Forms.ComboBox();
            this.identidadTextBox = new System.Windows.Forms.TextBox();
            apellidosLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreEncargadoLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            telefonoEncargadoLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            seccionLabel = new System.Windows.Forms.Label();
            correoElectronicoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            gradoIdLabel = new System.Windows.Forms.Label();
            identidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingNavigator)).BeginInit();
            this.listaEstudiantesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaGradosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(54, 141);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 1;
            apellidosLabel.Text = "Apellidos:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(401, 140);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 3;
            direccionLabel.Text = "Direccion:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(54, 89);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // listaEstudiantesBindingSource
            // 
            this.listaEstudiantesBindingSource.DataSource = typeof(BL.NotasEscolares.Estudiante);
            // 
            // nombreEncargadoLabel
            // 
            nombreEncargadoLabel.AutoSize = true;
            nombreEncargadoLabel.Location = new System.Drawing.Point(401, 88);
            nombreEncargadoLabel.Name = "nombreEncargadoLabel";
            nombreEncargadoLabel.Size = new System.Drawing.Size(102, 13);
            nombreEncargadoLabel.TabIndex = 9;
            nombreEncargadoLabel.Text = "Nombre Encargado:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(54, 115);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 11;
            nombresLabel.Text = "Nombres:";
            // 
            // telefonoEncargadoLabel
            // 
            telefonoEncargadoLabel.AutoSize = true;
            telefonoEncargadoLabel.Location = new System.Drawing.Point(401, 111);
            telefonoEncargadoLabel.Name = "telefonoEncargadoLabel";
            telefonoEncargadoLabel.Size = new System.Drawing.Size(107, 13);
            telefonoEncargadoLabel.TabIndex = 13;
            telefonoEncargadoLabel.Text = "Telefono Encargado:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(54, 170);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 15;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // seccionLabel
            // 
            seccionLabel.AutoSize = true;
            seccionLabel.Location = new System.Drawing.Point(57, 246);
            seccionLabel.Name = "seccionLabel";
            seccionLabel.Size = new System.Drawing.Size(49, 13);
            seccionLabel.TabIndex = 17;
            seccionLabel.Text = "Seccion:";
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.Location = new System.Drawing.Point(401, 169);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(97, 13);
            correoElectronicoLabel.TabIndex = 21;
            correoElectronicoLabel.Text = "Correo Electronico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(435, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(139, 13);
            label1.TabIndex = 23;
            label1.Text = "DATOS DEL ENCARGADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(133, 40);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(140, 13);
            label2.TabIndex = 24;
            label2.Text = "DATOS DEL ESTUDIANTE";
            // 
            // gradoIdLabel
            // 
            gradoIdLabel.AutoSize = true;
            gradoIdLabel.Location = new System.Drawing.Point(57, 219);
            gradoIdLabel.Name = "gradoIdLabel";
            gradoIdLabel.Size = new System.Drawing.Size(39, 13);
            gradoIdLabel.TabIndex = 24;
            gradoIdLabel.Text = "Grado:";
            // 
            // listaEstudiantesBindingNavigator
            // 
            this.listaEstudiantesBindingNavigator.AddNewItem = null;
            this.listaEstudiantesBindingNavigator.BindingSource = this.listaEstudiantesBindingSource;
            this.listaEstudiantesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaEstudiantesBindingNavigator.DeleteItem = null;
            this.listaEstudiantesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaEstudiantesBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaEstudiantesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaEstudiantesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaEstudiantesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaEstudiantesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaEstudiantesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaEstudiantesBindingNavigator.Name = "listaEstudiantesBindingNavigator";
            this.listaEstudiantesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaEstudiantesBindingNavigator.Size = new System.Drawing.Size(669, 25);
            this.listaEstudiantesBindingNavigator.TabIndex = 0;
            this.listaEstudiantesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaEstudiantesBindingNavigatorSaveItem
            // 
            this.listaEstudiantesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaEstudiantesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaEstudiantesBindingNavigatorSaveItem.Image")));
            this.listaEstudiantesBindingNavigatorSaveItem.Name = "listaEstudiantesBindingNavigatorSaveItem";
            this.listaEstudiantesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaEstudiantesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaEstudiantesBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaEstudiantesBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(167, 138);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidosTextBox.TabIndex = 2;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(514, 137);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 4;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(167, 86);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // nombreEncargadoTextBox
            // 
            this.nombreEncargadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "NombreEncargado", true));
            this.nombreEncargadoTextBox.Location = new System.Drawing.Point(514, 82);
            this.nombreEncargadoTextBox.Name = "nombreEncargadoTextBox";
            this.nombreEncargadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreEncargadoTextBox.TabIndex = 10;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(167, 112);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombresTextBox.TabIndex = 12;
            // 
            // telefonoEncargadoTextBox
            // 
            this.telefonoEncargadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "TelefonoEncargado", true));
            this.telefonoEncargadoTextBox.Location = new System.Drawing.Point(514, 108);
            this.telefonoEncargadoTextBox.Name = "telefonoEncargadoTextBox";
            this.telefonoEncargadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoEncargadoTextBox.TabIndex = 14;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaEstudiantesBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(167, 164);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 16;
            this.fechaNacimientoDateTimePicker.ValueChanged += new System.EventHandler(this.fechaNacimientoDateTimePicker_ValueChanged);
            // 
            // seccionTextBox
            // 
            this.seccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Seccion", true));
            this.seccionTextBox.Location = new System.Drawing.Point(167, 243);
            this.seccionTextBox.Name = "seccionTextBox";
            this.seccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.seccionTextBox.TabIndex = 18;
            // 
            // correoElectronicoTextBox
            // 
            this.correoElectronicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "CorreoElectronico", true));
            this.correoElectronicoTextBox.Location = new System.Drawing.Point(514, 166);
            this.correoElectronicoTextBox.Name = "correoElectronicoTextBox";
            this.correoElectronicoTextBox.Size = new System.Drawing.Size(100, 20);
            this.correoElectronicoTextBox.TabIndex = 22;
            // 
            // gradosBLBindingSource
            // 
            this.gradosBLBindingSource.DataSource = typeof(BL.NotasEscolares.GradosBL);
            // 
            // listaGradosBindingSource
            // 
            this.listaGradosBindingSource.DataMember = "ListaGrados";
            this.listaGradosBindingSource.DataSource = this.gradosBLBindingSource;
            // 
            // gradoIdComboBox
            // 
            this.gradoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaEstudiantesBindingSource, "GradoId", true));
            this.gradoIdComboBox.DataSource = this.listaGradosBindingSource;
            this.gradoIdComboBox.DisplayMember = "Descripcion";
            this.gradoIdComboBox.FormattingEnabled = true;
            this.gradoIdComboBox.Location = new System.Drawing.Point(167, 216);
            this.gradoIdComboBox.Name = "gradoIdComboBox";
            this.gradoIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.gradoIdComboBox.TabIndex = 25;
            this.gradoIdComboBox.ValueMember = "Id";
            // 
            // identidadLabel
            // 
            identidadLabel.AutoSize = true;
            identidadLabel.Location = new System.Drawing.Point(57, 195);
            identidadLabel.Name = "identidadLabel";
            identidadLabel.Size = new System.Drawing.Size(54, 13);
            identidadLabel.TabIndex = 25;
            identidadLabel.Text = "Identidad:";
            // 
            // identidadTextBox
            // 
            this.identidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEstudiantesBindingSource, "Identidad", true));
            this.identidadTextBox.Location = new System.Drawing.Point(167, 190);
            this.identidadTextBox.Name = "identidadTextBox";
            this.identidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.identidadTextBox.TabIndex = 26;
            // 
            // FormDatosEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 313);
            this.Controls.Add(identidadLabel);
            this.Controls.Add(this.identidadTextBox);
            this.Controls.Add(gradoIdLabel);
            this.Controls.Add(this.gradoIdComboBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(correoElectronicoLabel);
            this.Controls.Add(this.correoElectronicoTextBox);
            this.Controls.Add(seccionLabel);
            this.Controls.Add(this.seccionTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreEncargadoLabel);
            this.Controls.Add(this.nombreEncargadoTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(telefonoEncargadoLabel);
            this.Controls.Add(this.telefonoEncargadoTextBox);
            this.Controls.Add(this.listaEstudiantesBindingNavigator);
            this.Name = "FormDatosEstudiantes";
            this.Text = "Datos De Estudiantes";
            this.Load += new System.EventHandler(this.FormDatosEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstudiantesBindingNavigator)).EndInit();
            this.listaEstudiantesBindingNavigator.ResumeLayout(false);
            this.listaEstudiantesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaGradosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaEstudiantesBindingSource;
        private System.Windows.Forms.BindingNavigator listaEstudiantesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaEstudiantesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreEncargadoTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox telefonoEncargadoTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox seccionTextBox;
        private System.Windows.Forms.TextBox correoElectronicoTextBox;
        private System.Windows.Forms.BindingSource gradosBLBindingSource;
        private System.Windows.Forms.BindingSource listaGradosBindingSource;
        private System.Windows.Forms.ComboBox gradoIdComboBox;
        private System.Windows.Forms.TextBox identidadTextBox;
    }
}