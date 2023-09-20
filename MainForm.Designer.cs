namespace MicrosoftActivationToolkit
{
    partial class MainForm
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
            checkActivationStatusButton = new Button();
            uninstallProductKeyButton = new Button();
            installProductKeyButton = new Button();
            kmsServerTextBox = new TextBox();
            setKMSServerButton = new Button();
            removeKMSServerButton = new Button();
            productKeyTextBox = new TextBox();
            activateButton = new Button();
            consoleTextBox = new TextBox();
            exitButton = new Button();
            startOverButton = new Button();
            productSelectionComboBox = new ComboBox();
            productVersionComboBoxLabel = new Label();
            SuspendLayout();
            // 
            // checkActivationStatusButton
            // 
            checkActivationStatusButton.Location = new Point(432, 679);
            checkActivationStatusButton.Name = "checkActivationStatusButton";
            checkActivationStatusButton.Size = new Size(200, 30);
            checkActivationStatusButton.TabIndex = 0;
            checkActivationStatusButton.Text = "Check Activation Status";
            checkActivationStatusButton.UseVisualStyleBackColor = true;
            checkActivationStatusButton.Click += checkActivationStatusButton_Click;
            // 
            // uninstallProductKeyButton
            // 
            uninstallProductKeyButton.Location = new Point(794, 44);
            uninstallProductKeyButton.Name = "uninstallProductKeyButton";
            uninstallProductKeyButton.Size = new Size(200, 30);
            uninstallProductKeyButton.TabIndex = 3;
            uninstallProductKeyButton.Text = "Uninstall Product Key";
            uninstallProductKeyButton.UseVisualStyleBackColor = true;
            uninstallProductKeyButton.Click += uninstallProductKeyButton_Click;
            // 
            // installProductKeyButton
            // 
            installProductKeyButton.Location = new Point(588, 44);
            installProductKeyButton.Name = "installProductKeyButton";
            installProductKeyButton.Size = new Size(200, 30);
            installProductKeyButton.TabIndex = 4;
            installProductKeyButton.Text = "Install Product Key";
            installProductKeyButton.UseVisualStyleBackColor = true;
            installProductKeyButton.Click += installProductKeyButton_Click;
            // 
            // kmsServerTextBox
            // 
            kmsServerTextBox.Location = new Point(176, 12);
            kmsServerTextBox.Name = "kmsServerTextBox";
            kmsServerTextBox.Size = new Size(406, 27);
            kmsServerTextBox.TabIndex = 5;
            // 
            // setKMSServerButton
            // 
            setKMSServerButton.Location = new Point(588, 10);
            setKMSServerButton.Name = "setKMSServerButton";
            setKMSServerButton.Size = new Size(200, 30);
            setKMSServerButton.TabIndex = 6;
            setKMSServerButton.Text = "Set KMS Server";
            setKMSServerButton.UseVisualStyleBackColor = true;
            setKMSServerButton.Click += setKMSServerButton_Click;
            // 
            // removeKMSServerButton
            // 
            removeKMSServerButton.Location = new Point(794, 10);
            removeKMSServerButton.Name = "removeKMSServerButton";
            removeKMSServerButton.Size = new Size(200, 30);
            removeKMSServerButton.TabIndex = 7;
            removeKMSServerButton.Text = "Remove KMS Server";
            removeKMSServerButton.UseVisualStyleBackColor = true;
            removeKMSServerButton.Click += removeKMSServerButton_Click;
            // 
            // productKeyTextBox
            // 
            productKeyTextBox.Location = new Point(176, 45);
            productKeyTextBox.Name = "productKeyTextBox";
            productKeyTextBox.Size = new Size(406, 27);
            productKeyTextBox.TabIndex = 8;
            // 
            // activateButton
            // 
            activateButton.Location = new Point(638, 679);
            activateButton.Name = "activateButton";
            activateButton.Size = new Size(200, 30);
            activateButton.TabIndex = 9;
            activateButton.Text = "Activate Windows";
            activateButton.UseVisualStyleBackColor = true;
            activateButton.Click += activateButton_Click;
            // 
            // consoleTextBox
            // 
            consoleTextBox.BackColor = Color.FromArgb(64, 64, 64);
            consoleTextBox.ForeColor = Color.FromArgb(0, 192, 0);
            consoleTextBox.Location = new Point(12, 80);
            consoleTextBox.Multiline = true;
            consoleTextBox.Name = "consoleTextBox";
            consoleTextBox.ReadOnly = true;
            consoleTextBox.ScrollBars = ScrollBars.Vertical;
            consoleTextBox.Size = new Size(982, 591);
            consoleTextBox.TabIndex = 10;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(844, 679);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 30);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // startOverButton
            // 
            startOverButton.Location = new Point(276, 679);
            startOverButton.Name = "startOverButton";
            startOverButton.Size = new Size(150, 30);
            startOverButton.TabIndex = 13;
            startOverButton.Text = "Start Over";
            startOverButton.UseVisualStyleBackColor = true;
            startOverButton.Click += startOverButton_Click;
            // 
            // productSelectionComboBox
            // 
            productSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productSelectionComboBox.Enabled = false;
            productSelectionComboBox.FormattingEnabled = true;
            productSelectionComboBox.Items.AddRange(new object[] { "None Selected", "Windows 10", "Windows 11", "Office 2016", "Office 2019", "Office 2022" });
            productSelectionComboBox.Location = new Point(12, 44);
            productSelectionComboBox.Name = "productSelectionComboBox";
            productSelectionComboBox.Size = new Size(158, 28);
            productSelectionComboBox.TabIndex = 14;
            // 
            // productVersionComboBoxLabel
            // 
            productVersionComboBoxLabel.AutoSize = true;
            productVersionComboBoxLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            productVersionComboBoxLabel.Location = new Point(12, 12);
            productVersionComboBoxLabel.Name = "productVersionComboBoxLabel";
            productVersionComboBoxLabel.Size = new Size(138, 23);
            productVersionComboBoxLabel.TabIndex = 15;
            productVersionComboBoxLabel.Text = "Select a Product:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(productVersionComboBoxLabel);
            Controls.Add(productSelectionComboBox);
            Controls.Add(startOverButton);
            Controls.Add(exitButton);
            Controls.Add(consoleTextBox);
            Controls.Add(activateButton);
            Controls.Add(productKeyTextBox);
            Controls.Add(removeKMSServerButton);
            Controls.Add(setKMSServerButton);
            Controls.Add(kmsServerTextBox);
            Controls.Add(installProductKeyButton);
            Controls.Add(uninstallProductKeyButton);
            Controls.Add(checkActivationStatusButton);
            MaximumSize = new Size(1024, 768);
            MinimumSize = new Size(1024, 768);
            Name = "MainForm";
            Text = "Microsoft Activation Toolkit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region My custom initializations

        private string system32FolderPath = null;
        private string slmgrFilePath = null;
        private string lineDivider = "============================================================" + Environment.NewLine;
        private string kmsServerPatternRegex = "^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$|^(?!-)[A-Za-z0-9-]{1,63}(?<!-)$";
        private string winProductKeyPatternRegex = "^[A-HJ-NP-TV-Z0-9]{5}-[A-HJ-NP-TV-Z0-9]{5}-[A-HJ-NP-TV-Z0-9]{5}-[A-HJ-NP-TV-Z0-9]{5}-[A-HJ-NP-TV-Z0-9]{5}$";

        private void CustomInitialization()
        {
            if (isRunningWithElevatedPrivilege())
            {
                setKMSServerButton.TabStop = false;
                removeKMSServerButton.TabStop = false;
                installProductKeyButton.TabStop = false;
                uninstallProductKeyButton.TabStop = false;
                startOverButton.TabStop = false;
                checkActivationStatusButton.TabStop = false;
                activateButton.TabStop = false;
                exitButton.TabStop = false;

                productSelectionComboBox.SelectedIndex = 0;

                //Retrieve slmgr.vbs file path:
                system32FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
                slmgrFilePath = System.IO.Path.Combine(system32FolderPath, "slmgr.vbs");
            }
            else
            {
                MessageBox.Show("This tool requires elevated privilege for all functions to perform properly.", "Elevated Privilege Required!");
            }

        }

        #endregion

        private Button checkActivationStatusButton;
        private Button uninstallProductKeyButton;
        private Button installProductKeyButton;
        private TextBox kmsServerTextBox;
        private Button setKMSServerButton;
        private Button removeKMSServerButton;
        private TextBox productKeyTextBox;
        private Button activateButton;
        private TextBox consoleTextBox;
        private Button exitButton;
        private Button startOverButton;
        private ComboBox productSelectionComboBox;
        private Label productVersionComboBoxLabel;
    }
}