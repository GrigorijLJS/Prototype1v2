namespace Prototype1v1
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.activitiesTab = new System.Windows.Forms.TabPage();
            this.SaveActivityButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inputAcitityIDTextBox = new System.Windows.Forms.TextBox();
            this.addedActivitiesLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errorsTab = new System.Windows.Forms.TabPage();
            this.customErrorThresholdsTextBox = new System.Windows.Forms.TextBox();
            this.customErrorIDTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.errorsDropDown = new System.Windows.Forms.ComboBox();
            this.saveDefaultErrorsButton = new System.Windows.Forms.Button();
            this.customErrorSaveButton = new System.Windows.Forms.Button();
            this.implementationThresholdsTextBox = new System.Windows.Forms.TextBox();
            this.classifyingThresholdsTextBox = new System.Windows.Forms.TextBox();
            this.recognitionThresholdsTextBox = new System.Windows.Forms.TextBox();
            this.implementationIDTextBox = new System.Windows.Forms.TextBox();
            this.classifyingIDTextBox = new System.Windows.Forms.TextBox();
            this.recognitionIDTextBox = new System.Windows.Forms.TextBox();
            this.recallIDTextBox = new System.Windows.Forms.TextBox();
            this.recallThresholdsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeTab = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.saveTimeThresholdButton = new System.Windows.Forms.Button();
            this.timeDropDown = new System.Windows.Forms.ComboBox();
            this.secsTextBox = new System.Windows.Forms.TextBox();
            this.minsTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.scoreTab = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.gameScoreButton = new System.Windows.Forms.Button();
            this.gameScoreTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.historyTable = new System.Windows.Forms.DataGridView();
            this.finishTab = new System.Windows.Forms.TabPage();
            this.saveExitButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.acitivityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thresholdsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.activitiesTab.SuspendLayout();
            this.errorsTab.SuspendLayout();
            this.timeTab.SuspendLayout();
            this.scoreTab.SuspendLayout();
            this.historyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).BeginInit();
            this.finishTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.activitiesTab);
            this.tabControl1.Controls.Add(this.errorsTab);
            this.tabControl1.Controls.Add(this.timeTab);
            this.tabControl1.Controls.Add(this.scoreTab);
            this.tabControl1.Controls.Add(this.historyTab);
            this.tabControl1.Controls.Add(this.finishTab);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // activitiesTab
            // 
            this.activitiesTab.Controls.Add(this.SaveActivityButton);
            this.activitiesTab.Controls.Add(this.button2);
            this.activitiesTab.Controls.Add(this.inputAcitityIDTextBox);
            this.activitiesTab.Controls.Add(this.addedActivitiesLabel);
            this.activitiesTab.Controls.Add(this.label11);
            this.activitiesTab.Controls.Add(this.label8);
            this.activitiesTab.Controls.Add(this.label9);
            this.activitiesTab.Location = new System.Drawing.Point(4, 22);
            this.activitiesTab.Name = "activitiesTab";
            this.activitiesTab.Size = new System.Drawing.Size(625, 346);
            this.activitiesTab.TabIndex = 3;
            this.activitiesTab.Text = "Game Activities";
            this.activitiesTab.UseVisualStyleBackColor = true;
            // 
            // SaveActivityButton
            // 
            this.SaveActivityButton.Location = new System.Drawing.Point(343, 64);
            this.SaveActivityButton.Name = "SaveActivityButton";
            this.SaveActivityButton.Size = new System.Drawing.Size(139, 23);
            this.SaveActivityButton.TabIndex = 9;
            this.SaveActivityButton.Text = "Save game activity";
            this.SaveActivityButton.UseVisualStyleBackColor = true;
            this.SaveActivityButton.Click += new System.EventHandler(this.SaveActivityButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add another type of error";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // inputAcitityIDTextBox
            // 
            this.inputAcitityIDTextBox.Location = new System.Drawing.Point(181, 64);
            this.inputAcitityIDTextBox.Name = "inputAcitityIDTextBox";
            this.inputAcitityIDTextBox.Size = new System.Drawing.Size(117, 20);
            this.inputAcitityIDTextBox.TabIndex = 8;
            // 
            // addedActivitiesLabel
            // 
            this.addedActivitiesLabel.AutoSize = true;
            this.addedActivitiesLabel.BackColor = System.Drawing.Color.Silver;
            this.addedActivitiesLabel.Location = new System.Drawing.Point(208, 185);
            this.addedActivitiesLabel.Name = "addedActivitiesLabel";
            this.addedActivitiesLabel.Size = new System.Drawing.Size(33, 13);
            this.addedActivitiesLabel.TabIndex = 6;
            this.addedActivitiesLabel.Text = "None";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Added game activities:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Game activity identifier:";
            this.toolTip.SetToolTip(this.label8, "It\'s alive!");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Game activity";
            // 
            // errorsTab
            // 
            this.errorsTab.Controls.Add(this.customErrorThresholdsTextBox);
            this.errorsTab.Controls.Add(this.customErrorIDTextBox);
            this.errorsTab.Controls.Add(this.label12);
            this.errorsTab.Controls.Add(this.errorsDropDown);
            this.errorsTab.Controls.Add(this.saveDefaultErrorsButton);
            this.errorsTab.Controls.Add(this.customErrorSaveButton);
            this.errorsTab.Controls.Add(this.implementationThresholdsTextBox);
            this.errorsTab.Controls.Add(this.classifyingThresholdsTextBox);
            this.errorsTab.Controls.Add(this.recognitionThresholdsTextBox);
            this.errorsTab.Controls.Add(this.implementationIDTextBox);
            this.errorsTab.Controls.Add(this.classifyingIDTextBox);
            this.errorsTab.Controls.Add(this.recognitionIDTextBox);
            this.errorsTab.Controls.Add(this.recallIDTextBox);
            this.errorsTab.Controls.Add(this.recallThresholdsTextBox);
            this.errorsTab.Controls.Add(this.label4);
            this.errorsTab.Controls.Add(this.label3);
            this.errorsTab.Controls.Add(this.label2);
            this.errorsTab.Controls.Add(this.label7);
            this.errorsTab.Controls.Add(this.label6);
            this.errorsTab.Controls.Add(this.label10);
            this.errorsTab.Controls.Add(this.label5);
            this.errorsTab.Controls.Add(this.label1);
            this.errorsTab.Location = new System.Drawing.Point(4, 22);
            this.errorsTab.Name = "errorsTab";
            this.errorsTab.Size = new System.Drawing.Size(625, 346);
            this.errorsTab.TabIndex = 0;
            this.errorsTab.Text = "Errors";
            this.errorsTab.UseVisualStyleBackColor = true;
            // 
            // customErrorThresholdsTextBox
            // 
            this.customErrorThresholdsTextBox.Location = new System.Drawing.Point(290, 278);
            this.customErrorThresholdsTextBox.Name = "customErrorThresholdsTextBox";
            this.customErrorThresholdsTextBox.Size = new System.Drawing.Size(265, 20);
            this.customErrorThresholdsTextBox.TabIndex = 9;
            // 
            // customErrorIDTextBox
            // 
            this.customErrorIDTextBox.Location = new System.Drawing.Point(126, 278);
            this.customErrorIDTextBox.Name = "customErrorIDTextBox";
            this.customErrorIDTextBox.Size = new System.Drawing.Size(117, 20);
            this.customErrorIDTextBox.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Custom error";
            // 
            // errorsDropDown
            // 
            this.errorsDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errorsDropDown.FormattingEnabled = true;
            this.errorsDropDown.Location = new System.Drawing.Point(156, 15);
            this.errorsDropDown.Name = "errorsDropDown";
            this.errorsDropDown.Size = new System.Drawing.Size(121, 21);
            this.errorsDropDown.TabIndex = 6;
            // 
            // saveDefaultErrorsButton
            // 
            this.saveDefaultErrorsButton.Location = new System.Drawing.Point(192, 239);
            this.saveDefaultErrorsButton.Name = "saveDefaultErrorsButton";
            this.saveDefaultErrorsButton.Size = new System.Drawing.Size(139, 23);
            this.saveDefaultErrorsButton.TabIndex = 5;
            this.saveDefaultErrorsButton.Text = "Save the data";
            this.saveDefaultErrorsButton.UseVisualStyleBackColor = true;
            this.saveDefaultErrorsButton.Click += new System.EventHandler(this.saveDefaultErrorsButton_Click);
            // 
            // customErrorSaveButton
            // 
            this.customErrorSaveButton.Location = new System.Drawing.Point(192, 304);
            this.customErrorSaveButton.Name = "customErrorSaveButton";
            this.customErrorSaveButton.Size = new System.Drawing.Size(139, 23);
            this.customErrorSaveButton.TabIndex = 5;
            this.customErrorSaveButton.Text = "Save a custom error type";
            this.customErrorSaveButton.UseVisualStyleBackColor = true;
            this.customErrorSaveButton.Click += new System.EventHandler(this.customErrorSaveButton_Click);
            // 
            // implementationThresholdsTextBox
            // 
            this.implementationThresholdsTextBox.Location = new System.Drawing.Point(289, 213);
            this.implementationThresholdsTextBox.Name = "implementationThresholdsTextBox";
            this.implementationThresholdsTextBox.Size = new System.Drawing.Size(265, 20);
            this.implementationThresholdsTextBox.TabIndex = 4;
            // 
            // classifyingThresholdsTextBox
            // 
            this.classifyingThresholdsTextBox.Location = new System.Drawing.Point(290, 173);
            this.classifyingThresholdsTextBox.Name = "classifyingThresholdsTextBox";
            this.classifyingThresholdsTextBox.Size = new System.Drawing.Size(265, 20);
            this.classifyingThresholdsTextBox.TabIndex = 4;
            // 
            // recognitionThresholdsTextBox
            // 
            this.recognitionThresholdsTextBox.Location = new System.Drawing.Point(290, 126);
            this.recognitionThresholdsTextBox.Name = "recognitionThresholdsTextBox";
            this.recognitionThresholdsTextBox.Size = new System.Drawing.Size(265, 20);
            this.recognitionThresholdsTextBox.TabIndex = 4;
            // 
            // implementationIDTextBox
            // 
            this.implementationIDTextBox.Location = new System.Drawing.Point(125, 213);
            this.implementationIDTextBox.Name = "implementationIDTextBox";
            this.implementationIDTextBox.Size = new System.Drawing.Size(117, 20);
            this.implementationIDTextBox.TabIndex = 4;
            // 
            // classifyingIDTextBox
            // 
            this.classifyingIDTextBox.Location = new System.Drawing.Point(126, 173);
            this.classifyingIDTextBox.Name = "classifyingIDTextBox";
            this.classifyingIDTextBox.Size = new System.Drawing.Size(117, 20);
            this.classifyingIDTextBox.TabIndex = 4;
            // 
            // recognitionIDTextBox
            // 
            this.recognitionIDTextBox.Location = new System.Drawing.Point(126, 126);
            this.recognitionIDTextBox.Name = "recognitionIDTextBox";
            this.recognitionIDTextBox.Size = new System.Drawing.Size(117, 20);
            this.recognitionIDTextBox.TabIndex = 4;
            // 
            // recallIDTextBox
            // 
            this.recallIDTextBox.Location = new System.Drawing.Point(126, 81);
            this.recallIDTextBox.Name = "recallIDTextBox";
            this.recallIDTextBox.Size = new System.Drawing.Size(117, 20);
            this.recallIDTextBox.TabIndex = 4;
            // 
            // recallThresholdsTextBox
            // 
            this.recallThresholdsTextBox.Location = new System.Drawing.Point(290, 81);
            this.recallThresholdsTextBox.Name = "recallThresholdsTextBox";
            this.recallThresholdsTextBox.Size = new System.Drawing.Size(265, 20);
            this.recallThresholdsTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Error in implementing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Error with classifying";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Error in recognizing";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thresholds:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Identifier/name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Possible game activities:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Types of errors:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Error in recall";
            // 
            // timeTab
            // 
            this.timeTab.Controls.Add(this.label15);
            this.timeTab.Controls.Add(this.label19);
            this.timeTab.Controls.Add(this.saveTimeThresholdButton);
            this.timeTab.Controls.Add(this.timeDropDown);
            this.timeTab.Controls.Add(this.secsTextBox);
            this.timeTab.Controls.Add(this.minsTextBox);
            this.timeTab.Controls.Add(this.label18);
            this.timeTab.Controls.Add(this.hoursTextBox);
            this.timeTab.Controls.Add(this.label17);
            this.timeTab.Controls.Add(this.label13);
            this.timeTab.Controls.Add(this.label14);
            this.timeTab.Controls.Add(this.label16);
            this.timeTab.Location = new System.Drawing.Point(4, 22);
            this.timeTab.Name = "timeTab";
            this.timeTab.Size = new System.Drawing.Size(625, 346);
            this.timeTab.TabIndex = 1;
            this.timeTab.Text = "Time-on-activity";
            this.timeTab.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(185, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "None";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(36, 220);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(340, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Added game activities: (!!!or in new tab where everything can be listed)";
            // 
            // saveTimeThresholdButton
            // 
            this.saveTimeThresholdButton.Location = new System.Drawing.Point(191, 146);
            this.saveTimeThresholdButton.Name = "saveTimeThresholdButton";
            this.saveTimeThresholdButton.Size = new System.Drawing.Size(192, 23);
            this.saveTimeThresholdButton.TabIndex = 15;
            this.saveTimeThresholdButton.Text = "Save this time-on-activity threshold";
            this.saveTimeThresholdButton.UseVisualStyleBackColor = true;
            this.saveTimeThresholdButton.Click += new System.EventHandler(this.saveTimeThresholdButton_Click);
            // 
            // timeDropDown
            // 
            this.timeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeDropDown.FormattingEnabled = true;
            this.timeDropDown.Location = new System.Drawing.Point(156, 15);
            this.timeDropDown.Name = "timeDropDown";
            this.timeDropDown.Size = new System.Drawing.Size(121, 21);
            this.timeDropDown.TabIndex = 14;
            // 
            // secsTextBox
            // 
            this.secsTextBox.Location = new System.Drawing.Point(343, 92);
            this.secsTextBox.Name = "secsTextBox";
            this.secsTextBox.Size = new System.Drawing.Size(67, 20);
            this.secsTextBox.TabIndex = 12;
            // 
            // minsTextBox
            // 
            this.minsTextBox.Location = new System.Drawing.Point(254, 92);
            this.minsTextBox.Name = "minsTextBox";
            this.minsTextBox.Size = new System.Drawing.Size(67, 20);
            this.minsTextBox.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(354, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Seconds";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(162, 92);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(67, 20);
            this.hoursTextBox.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(265, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Minutes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(173, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Hours";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Possible game activities:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Time-on-activity thresholds";
            // 
            // scoreTab
            // 
            this.scoreTab.Controls.Add(this.label22);
            this.scoreTab.Controls.Add(this.label20);
            this.scoreTab.Controls.Add(this.gameScoreButton);
            this.scoreTab.Controls.Add(this.gameScoreTextBox);
            this.scoreTab.Controls.Add(this.label21);
            this.scoreTab.Location = new System.Drawing.Point(4, 22);
            this.scoreTab.Name = "scoreTab";
            this.scoreTab.Size = new System.Drawing.Size(625, 346);
            this.scoreTab.TabIndex = 2;
            this.scoreTab.Text = "Game score";
            this.scoreTab.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(142, 167);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(340, 13);
            this.label22.TabIndex = 27;
            this.label22.Text = "Added game activities: (!!!or in new tab where everything can be listed)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Silver;
            this.label20.Location = new System.Drawing.Point(163, 154);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "None";
            // 
            // gameScoreButton
            // 
            this.gameScoreButton.Location = new System.Drawing.Point(289, 81);
            this.gameScoreButton.Name = "gameScoreButton";
            this.gameScoreButton.Size = new System.Drawing.Size(192, 23);
            this.gameScoreButton.TabIndex = 25;
            this.gameScoreButton.Text = "Save this game score threshold";
            this.gameScoreButton.UseVisualStyleBackColor = true;
            this.gameScoreButton.Click += new System.EventHandler(this.gameScoreButton_Click);
            // 
            // gameScoreTextBox
            // 
            this.gameScoreTextBox.Location = new System.Drawing.Point(167, 81);
            this.gameScoreTextBox.Name = "gameScoreTextBox";
            this.gameScoreTextBox.Size = new System.Drawing.Size(67, 20);
            this.gameScoreTextBox.TabIndex = 23;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 84);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Game score threshold";
            // 
            // historyTab
            // 
            this.historyTab.Controls.Add(this.historyTable);
            this.historyTab.Location = new System.Drawing.Point(4, 22);
            this.historyTab.Name = "historyTab";
            this.historyTab.Size = new System.Drawing.Size(625, 346);
            this.historyTab.TabIndex = 4;
            this.historyTab.Text = "History";
            this.historyTab.UseVisualStyleBackColor = true;
            // 
            // historyTable
            // 
            this.historyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.acitivityColumn,
            this.nameColumn,
            this.typeColumn,
            this.thresholdsColumn});
            this.historyTable.Location = new System.Drawing.Point(18, 20);
            this.historyTable.Name = "historyTable";
            this.historyTable.Size = new System.Drawing.Size(579, 221);
            this.historyTable.TabIndex = 0;
            // 
            // finishTab
            // 
            this.finishTab.Controls.Add(this.saveExitButton);
            this.finishTab.Location = new System.Drawing.Point(4, 22);
            this.finishTab.Name = "finishTab";
            this.finishTab.Size = new System.Drawing.Size(625, 346);
            this.finishTab.TabIndex = 5;
            this.finishTab.Text = "Finish and store data";
            this.finishTab.UseVisualStyleBackColor = true;
            // 
            // saveExitButton
            // 
            this.saveExitButton.Location = new System.Drawing.Point(243, 162);
            this.saveExitButton.Name = "saveExitButton";
            this.saveExitButton.Size = new System.Drawing.Size(139, 23);
            this.saveExitButton.TabIndex = 10;
            this.saveExitButton.Text = "Save and exit";
            this.saveExitButton.UseVisualStyleBackColor = true;
            this.saveExitButton.Click += new System.EventHandler(this.saveExitButton_Click);
            // 
            // acitivityColumn
            // 
            this.acitivityColumn.HeaderText = "GAME ACTIVITY";
            this.acitivityColumn.Name = "acitivityColumn";
            this.acitivityColumn.ReadOnly = true;
            this.acitivityColumn.Width = 180;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "NAME";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "TYPE";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            // 
            // thresholdsColumn
            // 
            this.thresholdsColumn.HeaderText = "THRESHOLDS";
            this.thresholdsColumn.Name = "thresholdsColumn";
            this.thresholdsColumn.ReadOnly = true;
            this.thresholdsColumn.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 397);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.activitiesTab.ResumeLayout(false);
            this.activitiesTab.PerformLayout();
            this.errorsTab.ResumeLayout(false);
            this.errorsTab.PerformLayout();
            this.timeTab.ResumeLayout(false);
            this.timeTab.PerformLayout();
            this.scoreTab.ResumeLayout(false);
            this.scoreTab.PerformLayout();
            this.historyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).EndInit();
            this.finishTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage errorsTab;
        private System.Windows.Forms.TabPage timeTab;
        private System.Windows.Forms.TabPage scoreTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recallThresholdsTextBox;
        private System.Windows.Forms.TextBox implementationThresholdsTextBox;
        private System.Windows.Forms.TextBox classifyingThresholdsTextBox;
        private System.Windows.Forms.TextBox recognitionThresholdsTextBox;
        private System.Windows.Forms.Button customErrorSaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox implementationIDTextBox;
        private System.Windows.Forms.TextBox classifyingIDTextBox;
        private System.Windows.Forms.TextBox recognitionIDTextBox;
        private System.Windows.Forms.TextBox recallIDTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox errorsDropDown;
        private System.Windows.Forms.TabPage activitiesTab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputAcitityIDTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SaveActivityButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label addedActivitiesLabel;
        private System.Windows.Forms.ComboBox timeDropDown;
        private System.Windows.Forms.TextBox secsTextBox;
        private System.Windows.Forms.TextBox minsTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button saveTimeThresholdButton;
        private System.Windows.Forms.Button gameScoreButton;
        private System.Windows.Forms.TextBox gameScoreTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button saveDefaultErrorsButton;
        private System.Windows.Forms.TextBox customErrorThresholdsTextBox;
        private System.Windows.Forms.TextBox customErrorIDTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.DataGridView historyTable;
        private System.Windows.Forms.TabPage finishTab;
        private System.Windows.Forms.Button saveExitButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn acitivityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thresholdsColumn;
    }
}