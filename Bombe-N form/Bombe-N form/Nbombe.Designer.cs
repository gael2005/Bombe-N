namespace Bombe_N_form
{
    partial class NBomb
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            b_name = new TextBox();
            bomb_label = new Label();
            name_label = new Label();
            type_label = new Label();
            b_type = new ComboBox();
            plane_label = new Label();
            origin_label = new Label();
            p_type = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            p_name = new TextBox();
            population_label = new Label();
            label4 = new Label();
            c_name = new TextBox();
            data = new ListView();
            label5 = new Label();
            p_b_amount = new NumericUpDown();
            b_amount_label = new Label();
            c_amount = new NumericUpDown();
            create = new Button();
            pa_location_label = new Label();
            pa_name_label = new Label();
            pa_name = new TextBox();
            passager_label = new Label();
            pa_location = new TextBox();
            p_pa_amount = new NumericUpDown();
            pa_amount_label = new Label();
            add = new Button();
            replace = new Button();
            ((System.ComponentModel.ISupportInitialize)p_b_amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c_amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p_pa_amount).BeginInit();
            SuspendLayout();
            // 
            // b_name
            // 
            b_name.Location = new Point(103, 82);
            b_name.Name = "b_name";
            b_name.Size = new Size(150, 31);
            b_name.TabIndex = 0;
            b_name.TextChanged += b_name_TextChanged;
            // 
            // bomb_label
            // 
            bomb_label.AutoSize = true;
            bomb_label.Location = new Point(38, 33);
            bomb_label.Name = "bomb_label";
            bomb_label.Size = new Size(124, 25);
            bomb_label.TabIndex = 1;
            bomb_label.Text = "Nuclear Bomb";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(38, 85);
            name_label.Name = "name_label";
            name_label.Size = new Size(59, 25);
            name_label.TabIndex = 2;
            name_label.Text = "Name";
            // 
            // type_label
            // 
            type_label.AutoSize = true;
            type_label.Location = new Point(38, 135);
            type_label.Name = "type_label";
            type_label.Size = new Size(49, 25);
            type_label.TabIndex = 3;
            type_label.Text = "Type";
            // 
            // b_type
            // 
            b_type.FormattingEnabled = true;
            b_type.Items.AddRange(new object[] { "W80", "W81", "W84", "B53", "B61", "MARK-36", "XW-46", "XW-51", "UGM-133" });
            b_type.Location = new Point(103, 132);
            b_type.Name = "b_type";
            b_type.Size = new Size(182, 33);
            b_type.TabIndex = 4;
            b_type.SelectedIndexChanged += b_type_SelectedIndexChanged;
            // 
            // plane_label
            // 
            plane_label.AutoSize = true;
            plane_label.Location = new Point(354, 33);
            plane_label.Name = "plane_label";
            plane_label.Size = new Size(54, 25);
            plane_label.TabIndex = 5;
            plane_label.Text = "Plane";
            // 
            // origin_label
            // 
            origin_label.AutoSize = true;
            origin_label.Location = new Point(38, 253);
            origin_label.Name = "origin_label";
            origin_label.Size = new Size(129, 25);
            origin_label.TabIndex = 7;
            origin_label.Text = "Origin Country";
            // 
            // p_type
            // 
            p_type.FormattingEnabled = true;
            p_type.Items.AddRange(new object[] { "W80", "W81", "W84", "B53", "B61", "MARK-36", "XW-46", "XW-51", "UGM-133" });
            p_type.Location = new Point(447, 132);
            p_type.Name = "p_type";
            p_type.Size = new Size(182, 33);
            p_type.TabIndex = 11;
            p_type.SelectedIndexChanged += p_type_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 135);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 10;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 85);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // p_name
            // 
            p_name.Location = new Point(447, 82);
            p_name.Name = "p_name";
            p_name.Size = new Size(150, 31);
            p_name.TabIndex = 8;
            p_name.TextChanged += p_name_TextChanged;
            // 
            // population_label
            // 
            population_label.AutoSize = true;
            population_label.Location = new Point(38, 353);
            population_label.Name = "population_label";
            population_label.Size = new Size(97, 25);
            population_label.TabIndex = 14;
            population_label.Text = "Population";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 303);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 13;
            label4.Text = "Name";
            // 
            // c_name
            // 
            c_name.Location = new Point(141, 300);
            c_name.Name = "c_name";
            c_name.Size = new Size(150, 31);
            c_name.TabIndex = 12;
            c_name.TextChanged += c_name_TextChanged;
            // 
            // data
            // 
            data.Location = new Point(354, 303);
            data.Name = "data";
            data.Size = new Size(1019, 117);
            data.TabIndex = 16;
            data.UseCompatibleStateImageBehavior = false;
            data.SelectedIndexChanged += data_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(352, 253);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 17;
            label5.Text = "Plane";
            // 
            // p_b_amount
            // 
            p_b_amount.Location = new Point(780, 83);
            p_b_amount.Name = "p_b_amount";
            p_b_amount.Size = new Size(180, 31);
            p_b_amount.TabIndex = 18;
            p_b_amount.ValueChanged += p_b_amount_ValueChanged;
            // 
            // b_amount_label
            // 
            b_amount_label.AutoSize = true;
            b_amount_label.Location = new Point(674, 85);
            b_amount_label.Name = "b_amount_label";
            b_amount_label.Size = new Size(89, 25);
            b_amount_label.TabIndex = 19;
            b_amount_label.Text = "B amount";
            // 
            // c_amount
            // 
            c_amount.Location = new Point(141, 347);
            c_amount.Name = "c_amount";
            c_amount.Size = new Size(180, 31);
            c_amount.TabIndex = 20;
            c_amount.ValueChanged += c_amount_ValueChanged;
            // 
            // create
            // 
            create.Location = new Point(38, 404);
            create.Name = "create";
            create.Size = new Size(112, 34);
            create.TabIndex = 21;
            create.Text = "Create";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // pa_location_label
            // 
            pa_location_label.AutoSize = true;
            pa_location_label.Location = new Point(1036, 137);
            pa_location_label.Name = "pa_location_label";
            pa_location_label.Size = new Size(100, 25);
            pa_location_label.TabIndex = 28;
            pa_location_label.Text = "Pa_location";
            // 
            // pa_name_label
            // 
            pa_name_label.AutoSize = true;
            pa_name_label.Location = new Point(1036, 85);
            pa_name_label.Name = "pa_name_label";
            pa_name_label.Size = new Size(59, 25);
            pa_name_label.TabIndex = 24;
            pa_name_label.Text = "Name";
            // 
            // pa_name
            // 
            pa_name.Location = new Point(1142, 82);
            pa_name.Name = "pa_name";
            pa_name.Size = new Size(150, 31);
            pa_name.TabIndex = 23;
            pa_name.TextChanged += pa_name_TextChanged;
            // 
            // passager_label
            // 
            passager_label.AutoSize = true;
            passager_label.Location = new Point(1038, 33);
            passager_label.Name = "passager_label";
            passager_label.Size = new Size(81, 25);
            passager_label.TabIndex = 22;
            passager_label.Text = "Passager";
            // 
            // pa_location
            // 
            pa_location.Location = new Point(1142, 134);
            pa_location.Name = "pa_location";
            pa_location.Size = new Size(150, 31);
            pa_location.TabIndex = 29;
            pa_location.TextChanged += pa_location_TextChanged;
            // 
            // p_pa_amount
            // 
            p_pa_amount.Location = new Point(780, 131);
            p_pa_amount.Name = "p_pa_amount";
            p_pa_amount.Size = new Size(180, 31);
            p_pa_amount.TabIndex = 30;
            p_pa_amount.ValueChanged += p_pa_amount_ValueChanged;
            // 
            // pa_amount_label
            // 
            pa_amount_label.AutoSize = true;
            pa_amount_label.Location = new Point(674, 132);
            pa_amount_label.Name = "pa_amount_label";
            pa_amount_label.Size = new Size(100, 25);
            pa_amount_label.TabIndex = 31;
            pa_amount_label.Text = "Pa Amount";
            // 
            // add
            // 
            add.Location = new Point(1038, 197);
            add.Name = "add";
            add.Size = new Size(112, 34);
            add.TabIndex = 32;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // replace
            // 
            replace.Location = new Point(1169, 197);
            replace.Name = "replace";
            replace.Size = new Size(112, 34);
            replace.TabIndex = 33;
            replace.Text = "REPLACE";
            replace.UseVisualStyleBackColor = true;
            replace.Click += replace_Click;
            // 
            // NBomb
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 450);
            Controls.Add(replace);
            Controls.Add(add);
            Controls.Add(pa_amount_label);
            Controls.Add(p_pa_amount);
            Controls.Add(pa_location);
            Controls.Add(pa_location_label);
            Controls.Add(pa_name_label);
            Controls.Add(pa_name);
            Controls.Add(passager_label);
            Controls.Add(create);
            Controls.Add(c_amount);
            Controls.Add(b_amount_label);
            Controls.Add(p_b_amount);
            Controls.Add(label5);
            Controls.Add(data);
            Controls.Add(population_label);
            Controls.Add(label4);
            Controls.Add(c_name);
            Controls.Add(p_type);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(p_name);
            Controls.Add(origin_label);
            Controls.Add(plane_label);
            Controls.Add(b_type);
            Controls.Add(type_label);
            Controls.Add(name_label);
            Controls.Add(bomb_label);
            Controls.Add(b_name);
            Name = "NBomb";
            Text = "N-Bombe";
            ((System.ComponentModel.ISupportInitialize)p_b_amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)c_amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)p_pa_amount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox b_name;
        private Label bomb_label;
        private Label name_label;
        private Label type_label;
        private ComboBox b_type;
        private Label plane_label;
        private Label origin_label;
        private ComboBox p_type;
        private Label label1;
        private Label label2;
        private TextBox p_name;
        private Label population_label;
        private Label label4;
        private TextBox c_name;
        private ListView data;
        private Label label5;
        private NumericUpDown p_b_amount;
        private Label b_amount_label;
        private NumericUpDown c_amount;
        private Button create;
        private Label pa_location_label;
        private Label pa_name_label;
        private TextBox pa_name;
        private Label passager_label;
        private TextBox pa_location;
        private NumericUpDown p_pa_amount;
        private Label pa_amount_label;
        private Button add;
        private Button replace;
    }
}