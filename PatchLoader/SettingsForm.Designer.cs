﻿namespace PatchLoader
{
    partial class SettingsForm
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
            this.LbRemoteBase = new System.Windows.Forms.Label();
            this.TbRemoteBase = new System.Windows.Forms.TextBox();
            this.TbRemoteDir = new System.Windows.Forms.TextBox();
            this.LbRemoteDir = new System.Windows.Forms.Label();
            this.LbLinkDir = new System.Windows.Forms.Label();
            this.TbLinkDir = new System.Windows.Forms.TextBox();
            this.BtSubmit = new System.Windows.Forms.Button();
            this.LbToRep = new System.Windows.Forms.Label();
            this.TbToRep = new System.Windows.Forms.TextBox();
            this.TbToPatch = new System.Windows.Forms.TextBox();
            this.LbToPatch = new System.Windows.Forms.Label();
            this.TbNotToPatch = new System.Windows.Forms.TextBox();
            this.LbNotToPatch = new System.Windows.Forms.Label();
            this.TbNotToRep = new System.Windows.Forms.TextBox();
            this.LbNotToRep = new System.Windows.Forms.Label();
            this.LbRepStructureScripts = new System.Windows.Forms.Label();
            this.TbRepStructureScripts = new System.Windows.Forms.TextBox();
            this.TbRepStructureInfa = new System.Windows.Forms.TextBox();
            this.LbRepStructureInfa = new System.Windows.Forms.Label();
            this.TbScriptsSubdir = new System.Windows.Forms.TextBox();
            this.LbScriptsSubdir = new System.Windows.Forms.Label();
            this.TbInfaSubdir = new System.Windows.Forms.TextBox();
            this.LbInfaSubdir = new System.Windows.Forms.Label();
            this.TbInstallerPath = new System.Windows.Forms.TextBox();
            this.LbInstallerPath = new System.Windows.Forms.Label();
            this.TbSSPath = new System.Windows.Forms.TextBox();
            this.LbSSPath = new System.Windows.Forms.Label();
            this.TbCreateSTWFRegex = new System.Windows.Forms.TextBox();
            this.LbCreateSTWFRegex = new System.Windows.Forms.Label();
            this.TbSTWFFolder = new System.Windows.Forms.TextBox();
            this.LbSTWFFolder = new System.Windows.Forms.Label();
            this.TbODHInstallerPath = new System.Windows.Forms.TextBox();
            this.LbODHInstallerPath = new System.Windows.Forms.Label();
            this.TbScenarioExclude = new System.Windows.Forms.TextBox();
            this.LbScenarioExclude = new System.Windows.Forms.Label();
            this.TbDMFRSubstring = new System.Windows.Forms.TextBox();
            this.LbDMFRSubstring = new System.Windows.Forms.Label();
            this.TbDWH4DMSubstring = new System.Windows.Forms.TextBox();
            this.LbDWH4DMSubstring = new System.Windows.Forms.Label();
            this.TbPatchesRootDirDMFR = new System.Windows.Forms.TextBox();
            this.LbPatchesRootDirDMFR = new System.Windows.Forms.Label();
            this.TbPatchesRootDirDWH4DM = new System.Windows.Forms.TextBox();
            this.LbPatchesRootDirDWH4DM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbRemoteBase
            // 
            this.LbRemoteBase.AutoSize = true;
            this.LbRemoteBase.Location = new System.Drawing.Point(12, 12);
            this.LbRemoteBase.Name = "LbRemoteBase";
            this.LbRemoteBase.Size = new System.Drawing.Size(56, 13);
            this.LbRemoteBase.TabIndex = 0;
            this.LbRemoteBase.Text = "База VSS";
            // 
            // TbRemoteBase
            // 
            this.TbRemoteBase.Location = new System.Drawing.Point(134, 9);
            this.TbRemoteBase.Name = "TbRemoteBase";
            this.TbRemoteBase.Size = new System.Drawing.Size(197, 20);
            this.TbRemoteBase.TabIndex = 1;
            // 
            // TbRemoteDir
            // 
            this.TbRemoteDir.Location = new System.Drawing.Point(134, 35);
            this.TbRemoteDir.Name = "TbRemoteDir";
            this.TbRemoteDir.Size = new System.Drawing.Size(197, 20);
            this.TbRemoteDir.TabIndex = 3;
            // 
            // LbRemoteDir
            // 
            this.LbRemoteDir.AutoSize = true;
            this.LbRemoteDir.Location = new System.Drawing.Point(12, 38);
            this.LbRemoteDir.Name = "LbRemoteDir";
            this.LbRemoteDir.Size = new System.Drawing.Size(107, 13);
            this.LbRemoteDir.TabIndex = 2;
            this.LbRemoteDir.Text = "Папка репозитория";
            // 
            // LbLinkDir
            // 
            this.LbLinkDir.AutoSize = true;
            this.LbLinkDir.Location = new System.Drawing.Point(344, 64);
            this.LbLinkDir.Name = "LbLinkDir";
            this.LbLinkDir.Size = new System.Drawing.Size(93, 13);
            this.LbLinkDir.TabIndex = 20;
            this.LbLinkDir.Text = "Папка с патчами";
            // 
            // TbLinkDir
            // 
            this.TbLinkDir.Location = new System.Drawing.Point(466, 61);
            this.TbLinkDir.Name = "TbLinkDir";
            this.TbLinkDir.Size = new System.Drawing.Size(197, 20);
            this.TbLinkDir.TabIndex = 21;
            // 
            // BtSubmit
            // 
            this.BtSubmit.Location = new System.Drawing.Point(12, 497);
            this.BtSubmit.Name = "BtSubmit";
            this.BtSubmit.Size = new System.Drawing.Size(657, 35);
            this.BtSubmit.TabIndex = 34;
            this.BtSubmit.Text = "Применить";
            this.BtSubmit.UseVisualStyleBackColor = true;
            this.BtSubmit.Click += new System.EventHandler(this.BtSubmit_Click);
            // 
            // LbToRep
            // 
            this.LbToRep.AutoSize = true;
            this.LbToRep.Location = new System.Drawing.Point(12, 90);
            this.LbToRep.MaximumSize = new System.Drawing.Size(130, 0);
            this.LbToRep.Name = "LbToRep";
            this.LbToRep.Size = new System.Drawing.Size(112, 39);
            this.LbToRep.TabIndex = 8;
            this.LbToRep.Text = "Добавлять в общую папку (регулярное выражение)";
            // 
            // TbToRep
            // 
            this.TbToRep.Location = new System.Drawing.Point(134, 90);
            this.TbToRep.Multiline = true;
            this.TbToRep.Name = "TbToRep";
            this.TbToRep.Size = new System.Drawing.Size(197, 52);
            this.TbToRep.TabIndex = 9;
            // 
            // TbToPatch
            // 
            this.TbToPatch.Location = new System.Drawing.Point(134, 148);
            this.TbToPatch.Multiline = true;
            this.TbToPatch.Name = "TbToPatch";
            this.TbToPatch.Size = new System.Drawing.Size(197, 52);
            this.TbToPatch.TabIndex = 11;
            // 
            // LbToPatch
            // 
            this.LbToPatch.AutoSize = true;
            this.LbToPatch.Location = new System.Drawing.Point(12, 148);
            this.LbToPatch.MaximumSize = new System.Drawing.Size(120, 0);
            this.LbToPatch.Name = "LbToPatch";
            this.LbToPatch.Size = new System.Drawing.Size(100, 39);
            this.LbToPatch.TabIndex = 10;
            this.LbToPatch.Text = "Добавлять в патч (регулярное выражение)";
            // 
            // TbNotToPatch
            // 
            this.TbNotToPatch.Location = new System.Drawing.Point(466, 174);
            this.TbNotToPatch.Multiline = true;
            this.TbNotToPatch.Name = "TbNotToPatch";
            this.TbNotToPatch.Size = new System.Drawing.Size(197, 52);
            this.TbNotToPatch.TabIndex = 27;
            // 
            // LbNotToPatch
            // 
            this.LbNotToPatch.AutoSize = true;
            this.LbNotToPatch.Location = new System.Drawing.Point(344, 174);
            this.LbNotToPatch.MaximumSize = new System.Drawing.Size(120, 0);
            this.LbNotToPatch.Name = "LbNotToPatch";
            this.LbNotToPatch.Size = new System.Drawing.Size(114, 39);
            this.LbNotToPatch.TabIndex = 26;
            this.LbNotToPatch.Text = "Не добавлять в патч (регулярное выражение)";
            // 
            // TbNotToRep
            // 
            this.TbNotToRep.Location = new System.Drawing.Point(466, 116);
            this.TbNotToRep.Multiline = true;
            this.TbNotToRep.Name = "TbNotToRep";
            this.TbNotToRep.Size = new System.Drawing.Size(197, 52);
            this.TbNotToRep.TabIndex = 25;
            // 
            // LbNotToRep
            // 
            this.LbNotToRep.AutoSize = true;
            this.LbNotToRep.Location = new System.Drawing.Point(344, 116);
            this.LbNotToRep.MaximumSize = new System.Drawing.Size(130, 0);
            this.LbNotToRep.Name = "LbNotToRep";
            this.LbNotToRep.Size = new System.Drawing.Size(126, 39);
            this.LbNotToRep.TabIndex = 24;
            this.LbNotToRep.Text = "Не добавлять в общую папку (регулярное выражение)";
            // 
            // LbRepStructureScripts
            // 
            this.LbRepStructureScripts.AutoSize = true;
            this.LbRepStructureScripts.Location = new System.Drawing.Point(12, 206);
            this.LbRepStructureScripts.MaximumSize = new System.Drawing.Size(130, 0);
            this.LbRepStructureScripts.Name = "LbRepStructureScripts";
            this.LbRepStructureScripts.Size = new System.Drawing.Size(103, 39);
            this.LbRepStructureScripts.TabIndex = 12;
            this.LbRepStructureScripts.Text = "Структура папок в репозитории для скриптов";
            // 
            // TbRepStructureScripts
            // 
            this.TbRepStructureScripts.Location = new System.Drawing.Point(134, 206);
            this.TbRepStructureScripts.Multiline = true;
            this.TbRepStructureScripts.Name = "TbRepStructureScripts";
            this.TbRepStructureScripts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbRepStructureScripts.Size = new System.Drawing.Size(197, 65);
            this.TbRepStructureScripts.TabIndex = 13;
            // 
            // TbRepStructureInfa
            // 
            this.TbRepStructureInfa.Location = new System.Drawing.Point(466, 232);
            this.TbRepStructureInfa.Multiline = true;
            this.TbRepStructureInfa.Name = "TbRepStructureInfa";
            this.TbRepStructureInfa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbRepStructureInfa.Size = new System.Drawing.Size(197, 65);
            this.TbRepStructureInfa.TabIndex = 29;
            // 
            // LbRepStructureInfa
            // 
            this.LbRepStructureInfa.AutoSize = true;
            this.LbRepStructureInfa.Location = new System.Drawing.Point(344, 232);
            this.LbRepStructureInfa.MaximumSize = new System.Drawing.Size(130, 0);
            this.LbRepStructureInfa.Name = "LbRepStructureInfa";
            this.LbRepStructureInfa.Size = new System.Drawing.Size(103, 39);
            this.LbRepStructureInfa.TabIndex = 28;
            this.LbRepStructureInfa.Text = "Структура папок в репозитории для информатики";
            // 
            // TbScriptsSubdir
            // 
            this.TbScriptsSubdir.Location = new System.Drawing.Point(69, 64);
            this.TbScriptsSubdir.Name = "TbScriptsSubdir";
            this.TbScriptsSubdir.Size = new System.Drawing.Size(86, 20);
            this.TbScriptsSubdir.TabIndex = 5;
            // 
            // LbScriptsSubdir
            // 
            this.LbScriptsSubdir.AutoSize = true;
            this.LbScriptsSubdir.Location = new System.Drawing.Point(12, 67);
            this.LbScriptsSubdir.Name = "LbScriptsSubdir";
            this.LbScriptsSubdir.Size = new System.Drawing.Size(51, 13);
            this.LbScriptsSubdir.TabIndex = 4;
            this.LbScriptsSubdir.Text = "Скрипты";
            // 
            // TbInfaSubdir
            // 
            this.TbInfaSubdir.Location = new System.Drawing.Point(245, 64);
            this.TbInfaSubdir.Name = "TbInfaSubdir";
            this.TbInfaSubdir.Size = new System.Drawing.Size(86, 20);
            this.TbInfaSubdir.TabIndex = 7;
            // 
            // LbInfaSubdir
            // 
            this.LbInfaSubdir.AutoSize = true;
            this.LbInfaSubdir.Location = new System.Drawing.Point(161, 67);
            this.LbInfaSubdir.Name = "LbInfaSubdir";
            this.LbInfaSubdir.Size = new System.Drawing.Size(78, 13);
            this.LbInfaSubdir.TabIndex = 6;
            this.LbInfaSubdir.Text = "Информатика";
            // 
            // TbInstallerPath
            // 
            this.TbInstallerPath.Location = new System.Drawing.Point(466, 9);
            this.TbInstallerPath.Name = "TbInstallerPath";
            this.TbInstallerPath.Size = new System.Drawing.Size(197, 20);
            this.TbInstallerPath.TabIndex = 17;
            // 
            // LbInstallerPath
            // 
            this.LbInstallerPath.AutoSize = true;
            this.LbInstallerPath.Location = new System.Drawing.Point(344, 12);
            this.LbInstallerPath.Name = "LbInstallerPath";
            this.LbInstallerPath.Size = new System.Drawing.Size(113, 13);
            this.LbInstallerPath.TabIndex = 16;
            this.LbInstallerPath.Text = "Путь до PatchInstaller";
            // 
            // TbSSPath
            // 
            this.TbSSPath.Location = new System.Drawing.Point(466, 86);
            this.TbSSPath.Name = "TbSSPath";
            this.TbSSPath.Size = new System.Drawing.Size(197, 20);
            this.TbSSPath.TabIndex = 23;
            // 
            // LbSSPath
            // 
            this.LbSSPath.AutoSize = true;
            this.LbSSPath.Location = new System.Drawing.Point(344, 89);
            this.LbSSPath.Name = "LbSSPath";
            this.LbSSPath.Size = new System.Drawing.Size(79, 13);
            this.LbSSPath.TabIndex = 22;
            this.LbSSPath.Text = "Путь до ss.exe";
            // 
            // TbCreateSTWFRegex
            // 
            this.TbCreateSTWFRegex.Location = new System.Drawing.Point(347, 352);
            this.TbCreateSTWFRegex.Name = "TbCreateSTWFRegex";
            this.TbCreateSTWFRegex.Size = new System.Drawing.Size(316, 20);
            this.TbCreateSTWFRegex.TabIndex = 33;
            // 
            // LbCreateSTWFRegex
            // 
            this.LbCreateSTWFRegex.AutoSize = true;
            this.LbCreateSTWFRegex.Location = new System.Drawing.Point(344, 336);
            this.LbCreateSTWFRegex.Name = "LbCreateSTWFRegex";
            this.LbCreateSTWFRegex.Size = new System.Drawing.Size(319, 13);
            this.LbCreateSTWFRegex.TabIndex = 32;
            this.LbCreateSTWFRegex.Text = "Создавать stwf (маска файла потока регулярное выражение)";
            // 
            // TbSTWFFolder
            // 
            this.TbSTWFFolder.Location = new System.Drawing.Point(15, 352);
            this.TbSTWFFolder.Name = "TbSTWFFolder";
            this.TbSTWFFolder.Size = new System.Drawing.Size(316, 20);
            this.TbSTWFFolder.TabIndex = 31;
            // 
            // LbSTWFFolder
            // 
            this.LbSTWFFolder.AutoSize = true;
            this.LbSTWFFolder.Location = new System.Drawing.Point(12, 336);
            this.LbSTWFFolder.Name = "LbSTWFFolder";
            this.LbSTWFFolder.Size = new System.Drawing.Size(128, 13);
            this.LbSTWFFolder.TabIndex = 30;
            this.LbSTWFFolder.Text = "Папка с треш-потоками";
            // 
            // TbODHInstallerPath
            // 
            this.TbODHInstallerPath.Location = new System.Drawing.Point(466, 35);
            this.TbODHInstallerPath.Name = "TbODHInstallerPath";
            this.TbODHInstallerPath.Size = new System.Drawing.Size(197, 20);
            this.TbODHInstallerPath.TabIndex = 19;
            // 
            // LbODHInstallerPath
            // 
            this.LbODHInstallerPath.AutoSize = true;
            this.LbODHInstallerPath.Location = new System.Drawing.Point(344, 38);
            this.LbODHInstallerPath.Name = "LbODHInstallerPath";
            this.LbODHInstallerPath.Size = new System.Drawing.Size(98, 13);
            this.LbODHInstallerPath.TabIndex = 18;
            this.LbODHInstallerPath.Text = "ODH PatchInstaller";
            // 
            // TbScenarioExclude
            // 
            this.TbScenarioExclude.Location = new System.Drawing.Point(134, 277);
            this.TbScenarioExclude.Multiline = true;
            this.TbScenarioExclude.Name = "TbScenarioExclude";
            this.TbScenarioExclude.Size = new System.Drawing.Size(197, 45);
            this.TbScenarioExclude.TabIndex = 15;
            // 
            // LbScenarioExclude
            // 
            this.LbScenarioExclude.AutoSize = true;
            this.LbScenarioExclude.Location = new System.Drawing.Point(12, 280);
            this.LbScenarioExclude.MaximumSize = new System.Drawing.Size(130, 0);
            this.LbScenarioExclude.Name = "LbScenarioExclude";
            this.LbScenarioExclude.Size = new System.Drawing.Size(122, 39);
            this.LbScenarioExclude.TabIndex = 14;
            this.LbScenarioExclude.Text = "Не добавлять в сценарий (регулярное выражение)";
            // 
            // TbDMFRSubstring
            // 
            this.TbDMFRSubstring.Location = new System.Drawing.Point(188, 381);
            this.TbDMFRSubstring.Name = "TbDMFRSubstring";
            this.TbDMFRSubstring.Size = new System.Drawing.Size(143, 20);
            this.TbDMFRSubstring.TabIndex = 36;
            // 
            // LbDMFRSubstring
            // 
            this.LbDMFRSubstring.AutoSize = true;
            this.LbDMFRSubstring.Location = new System.Drawing.Point(12, 384);
            this.LbDMFRSubstring.Name = "LbDMFRSubstring";
            this.LbDMFRSubstring.Size = new System.Drawing.Size(156, 13);
            this.LbDMFRSubstring.TabIndex = 35;
            this.LbDMFRSubstring.Text = "Подстрока для поиска DMFR";
            // 
            // TbDWH4DMSubstring
            // 
            this.TbDWH4DMSubstring.Location = new System.Drawing.Point(520, 381);
            this.TbDWH4DMSubstring.Name = "TbDWH4DMSubstring";
            this.TbDWH4DMSubstring.Size = new System.Drawing.Size(143, 20);
            this.TbDWH4DMSubstring.TabIndex = 38;
            // 
            // LbDWH4DMSubstring
            // 
            this.LbDWH4DMSubstring.AutoSize = true;
            this.LbDWH4DMSubstring.Location = new System.Drawing.Point(344, 384);
            this.LbDWH4DMSubstring.Name = "LbDWH4DMSubstring";
            this.LbDWH4DMSubstring.Size = new System.Drawing.Size(175, 13);
            this.LbDWH4DMSubstring.TabIndex = 37;
            this.LbDWH4DMSubstring.Text = "Подстрока для поиска DWH4DM";
            // 
            // TbPatchesRootDirDMFR
            // 
            this.TbPatchesRootDirDMFR.Location = new System.Drawing.Point(134, 407);
            this.TbPatchesRootDirDMFR.Multiline = true;
            this.TbPatchesRootDirDMFR.Name = "TbPatchesRootDirDMFR";
            this.TbPatchesRootDirDMFR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbPatchesRootDirDMFR.Size = new System.Drawing.Size(197, 65);
            this.TbPatchesRootDirDMFR.TabIndex = 40;
            // 
            // LbPatchesRootDirDMFR
            // 
            this.LbPatchesRootDirDMFR.AutoSize = true;
            this.LbPatchesRootDirDMFR.Location = new System.Drawing.Point(12, 407);
            this.LbPatchesRootDirDMFR.MaximumSize = new System.Drawing.Size(130, 0);
            this.LbPatchesRootDirDMFR.Name = "LbPatchesRootDirDMFR";
            this.LbPatchesRootDirDMFR.Size = new System.Drawing.Size(102, 26);
            this.LbPatchesRootDirDMFR.TabIndex = 39;
            this.LbPatchesRootDirDMFR.Text = "Папки для поиска патчей DMFR";
            this.LbPatchesRootDirDMFR.Click += new System.EventHandler(this.LbPatchesRootDir_Click);
            // 
            // TbPatchesRootDirDWH4DM
            // 
            this.TbPatchesRootDirDWH4DM.Location = new System.Drawing.Point(466, 407);
            this.TbPatchesRootDirDWH4DM.Multiline = true;
            this.TbPatchesRootDirDWH4DM.Name = "TbPatchesRootDirDWH4DM";
            this.TbPatchesRootDirDWH4DM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbPatchesRootDirDWH4DM.Size = new System.Drawing.Size(197, 65);
            this.TbPatchesRootDirDWH4DM.TabIndex = 42;
            // 
            // LbPatchesRootDirDWH4DM
            // 
            this.LbPatchesRootDirDWH4DM.AutoSize = true;
            this.LbPatchesRootDirDWH4DM.Location = new System.Drawing.Point(344, 407);
            this.LbPatchesRootDirDWH4DM.MaximumSize = new System.Drawing.Size(130, 0);
            this.LbPatchesRootDirDWH4DM.Name = "LbPatchesRootDirDWH4DM";
            this.LbPatchesRootDirDWH4DM.Size = new System.Drawing.Size(102, 26);
            this.LbPatchesRootDirDWH4DM.TabIndex = 41;
            this.LbPatchesRootDirDWH4DM.Text = "Папки для поиска патчей DWH4DM";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 544);
            this.Controls.Add(this.TbPatchesRootDirDWH4DM);
            this.Controls.Add(this.LbPatchesRootDirDWH4DM);
            this.Controls.Add(this.TbPatchesRootDirDMFR);
            this.Controls.Add(this.LbPatchesRootDirDMFR);
            this.Controls.Add(this.TbDWH4DMSubstring);
            this.Controls.Add(this.LbDWH4DMSubstring);
            this.Controls.Add(this.TbDMFRSubstring);
            this.Controls.Add(this.LbDMFRSubstring);
            this.Controls.Add(this.TbScenarioExclude);
            this.Controls.Add(this.LbScenarioExclude);
            this.Controls.Add(this.TbODHInstallerPath);
            this.Controls.Add(this.LbODHInstallerPath);
            this.Controls.Add(this.TbSTWFFolder);
            this.Controls.Add(this.LbSTWFFolder);
            this.Controls.Add(this.TbCreateSTWFRegex);
            this.Controls.Add(this.LbCreateSTWFRegex);
            this.Controls.Add(this.TbSSPath);
            this.Controls.Add(this.LbSSPath);
            this.Controls.Add(this.TbInstallerPath);
            this.Controls.Add(this.LbInstallerPath);
            this.Controls.Add(this.TbInfaSubdir);
            this.Controls.Add(this.LbInfaSubdir);
            this.Controls.Add(this.TbScriptsSubdir);
            this.Controls.Add(this.LbScriptsSubdir);
            this.Controls.Add(this.TbRepStructureInfa);
            this.Controls.Add(this.LbRepStructureInfa);
            this.Controls.Add(this.TbRepStructureScripts);
            this.Controls.Add(this.LbRepStructureScripts);
            this.Controls.Add(this.TbNotToPatch);
            this.Controls.Add(this.LbNotToPatch);
            this.Controls.Add(this.TbNotToRep);
            this.Controls.Add(this.LbNotToRep);
            this.Controls.Add(this.TbToPatch);
            this.Controls.Add(this.LbToPatch);
            this.Controls.Add(this.TbToRep);
            this.Controls.Add(this.LbToRep);
            this.Controls.Add(this.BtSubmit);
            this.Controls.Add(this.TbLinkDir);
            this.Controls.Add(this.LbLinkDir);
            this.Controls.Add(this.TbRemoteDir);
            this.Controls.Add(this.LbRemoteDir);
            this.Controls.Add(this.TbRemoteBase);
            this.Controls.Add(this.LbRemoteBase);
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbRemoteBase;
        private System.Windows.Forms.TextBox TbRemoteBase;
        private System.Windows.Forms.TextBox TbRemoteDir;
        private System.Windows.Forms.Label LbRemoteDir;
        private System.Windows.Forms.Label LbLinkDir;
        private System.Windows.Forms.TextBox TbLinkDir;
        private System.Windows.Forms.Button BtSubmit;
        private System.Windows.Forms.Label LbToRep;
        private System.Windows.Forms.TextBox TbToRep;
        private System.Windows.Forms.TextBox TbToPatch;
        private System.Windows.Forms.Label LbToPatch;
        private System.Windows.Forms.TextBox TbNotToPatch;
        private System.Windows.Forms.Label LbNotToPatch;
        private System.Windows.Forms.TextBox TbNotToRep;
        private System.Windows.Forms.Label LbNotToRep;
        private System.Windows.Forms.Label LbRepStructureScripts;
        private System.Windows.Forms.TextBox TbRepStructureScripts;
        private System.Windows.Forms.TextBox TbRepStructureInfa;
        private System.Windows.Forms.Label LbRepStructureInfa;
        private System.Windows.Forms.TextBox TbScriptsSubdir;
        private System.Windows.Forms.Label LbScriptsSubdir;
        private System.Windows.Forms.TextBox TbInfaSubdir;
        private System.Windows.Forms.Label LbInfaSubdir;
        private System.Windows.Forms.TextBox TbInstallerPath;
        private System.Windows.Forms.Label LbInstallerPath;
        private System.Windows.Forms.TextBox TbSSPath;
        private System.Windows.Forms.Label LbSSPath;
        private System.Windows.Forms.TextBox TbCreateSTWFRegex;
        private System.Windows.Forms.Label LbCreateSTWFRegex;
        private System.Windows.Forms.TextBox TbSTWFFolder;
        private System.Windows.Forms.Label LbSTWFFolder;
        private System.Windows.Forms.TextBox TbODHInstallerPath;
        private System.Windows.Forms.Label LbODHInstallerPath;
        private System.Windows.Forms.TextBox TbScenarioExclude;
        private System.Windows.Forms.Label LbScenarioExclude;
        private System.Windows.Forms.TextBox TbDMFRSubstring;
        private System.Windows.Forms.Label LbDMFRSubstring;
        private System.Windows.Forms.TextBox TbDWH4DMSubstring;
        private System.Windows.Forms.Label LbDWH4DMSubstring;
        private System.Windows.Forms.TextBox TbPatchesRootDirDMFR;
        private System.Windows.Forms.Label LbPatchesRootDirDMFR;
        private System.Windows.Forms.TextBox TbPatchesRootDirDWH4DM;
        private System.Windows.Forms.Label LbPatchesRootDirDWH4DM;
    }
}