﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatchLoader
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            TbLinkDir.Text = Properties.Settings.Default.RemoteLinkRoot;
            TbRemoteBase.Text = Properties.Settings.Default.BaseLocation;
            TbRemoteDir.Text = Properties.Settings.Default.RemoteRoot;
            TbToRep.Text = Properties.Settings.Default.AddToRep;
            TbToPatch.Text = Properties.Settings.Default.AddToPatch;
            TbNotToRep.Text = Properties.Settings.Default.NotAddToRep;
            TbNotToPatch.Text = Properties.Settings.Default.NotAddToPatch;
            TbScriptsSubdir.Text = Properties.Settings.Default.ScriptsSubdir;
            TbInfaSubdir.Text = Properties.Settings.Default.InfaSubdir;
            TbRepStructureScripts.Text = Properties.Settings.Default.RepStructureScripts;
            TbRepStructureInfa.Text = Properties.Settings.Default.RepStructureInfa;
            TbInstallerPath.Text = Properties.Settings.Default.PatchInstallerPath;
            TbODHInstallerPath.Text = Properties.Settings.Default.PatchInstallerODHPath;
            TbSSPath.Text = Properties.Settings.Default.SSPath;
            TbCreateSTWFRegex.Text = Properties.Settings.Default.CreateSTWFRegex;
            TbSTWFFolder.Text = Properties.Settings.Default.STWFFolder;
            TbScenarioExclude.Text = Properties.Settings.Default.ScenarioExclude;
            TbDMFRSubstring.Text = Properties.Settings.Default.DMFRSubstring;
            TbDWH4DMSubstring.Text = Properties.Settings.Default.DWH4DMSubstring;
            TbPatchesRootDirDMFR.Text = Properties.Settings.Default.PatchesRootDirDMFR;
            TbPatchesRootDirDWH4DM.Text = Properties.Settings.Default.PatchesRootDirDWH4DM;
        }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Properties.Settings.Default.RemoteLinkRoot = TbLinkDir.Text;
            Properties.Settings.Default.BaseLocation = TbRemoteBase.Text;
            Properties.Settings.Default.RemoteRoot = TbRemoteDir.Text;
            Properties.Settings.Default.AddToRep = TbToRep.Text;
            Properties.Settings.Default.AddToPatch = TbToPatch.Text;
            Properties.Settings.Default.NotAddToRep = TbNotToRep.Text;
            Properties.Settings.Default.NotAddToPatch = TbNotToPatch.Text;
            Properties.Settings.Default.ScriptsSubdir = TbScriptsSubdir.Text;
            Properties.Settings.Default.InfaSubdir = TbInfaSubdir.Text;
            Properties.Settings.Default.RepStructureScripts = TbRepStructureScripts.Text;
            Properties.Settings.Default.RepStructureInfa = TbRepStructureInfa.Text;
            Properties.Settings.Default.PatchInstallerPath = TbInstallerPath.Text;
            Properties.Settings.Default.PatchInstallerODHPath = TbODHInstallerPath.Text;
            Properties.Settings.Default.SSPath = TbSSPath.Text;
            Properties.Settings.Default.CreateSTWFRegex = TbCreateSTWFRegex.Text;
            Properties.Settings.Default.STWFFolder = TbSTWFFolder.Text;
            Properties.Settings.Default.ScenarioExclude = TbScenarioExclude.Text;
            Properties.Settings.Default.DMFRSubstring = TbDMFRSubstring.Text;
            Properties.Settings.Default.DWH4DMSubstring = TbDWH4DMSubstring.Text;
            Properties.Settings.Default.PatchesRootDirDMFR = TbPatchesRootDirDMFR.Text;
            Properties.Settings.Default.PatchesRootDirDWH4DM = TbPatchesRootDirDWH4DM.Text;

            Properties.Settings.Default.Save();

            Close();
        }

        private void LbPatchesRootDir_Click(object sender, EventArgs e)
        {

        }
    }
}
