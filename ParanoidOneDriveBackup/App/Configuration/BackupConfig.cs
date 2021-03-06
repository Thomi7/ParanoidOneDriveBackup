﻿using System.ComponentModel;

namespace ParanoidOneDriveBackup.App.Configuration
{
    [Description("Backup")]
    internal class BackupConfig
    {
        public string Path { get; set; }
        public int RemainMaximum { get; set; }
        public int MaxParallelDownloadTasks { get; set; }
        public ProgressReporting ProgressReporting { get; set; }
    }
}
