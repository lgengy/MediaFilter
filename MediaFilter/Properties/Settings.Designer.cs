﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaFilter.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int PluginCount {
            get {
                return ((int)(this["PluginCount"]));
            }
            set {
                this["PluginCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\")]
        public string ImportMediaLocation {
            get {
                return ((string)(this["ImportMediaLocation"]));
            }
            set {
                this["ImportMediaLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\")]
        public string ExportFilterLocation {
            get {
                return ((string)(this["ExportFilterLocation"]));
            }
            set {
                this["ExportFilterLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\")]
        public string ImportDivideLocation {
            get {
                return ((string)(this["ImportDivideLocation"]));
            }
            set {
                this["ImportDivideLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ToleranceStart_MediaDivide {
            get {
                return ((int)(this["ToleranceStart_MediaDivide"]));
            }
            set {
                this["ToleranceStart_MediaDivide"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int ToleranceEnd_MediaDivide {
            get {
                return ((int)(this["ToleranceEnd_MediaDivide"]));
            }
            set {
                this["ToleranceEnd_MediaDivide"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int IssueCount_MediaDivide {
            get {
                return ((int)(this["IssueCount_MediaDivide"]));
            }
            set {
                this["IssueCount_MediaDivide"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int FileCount_MediaDivide {
            get {
                return ((int)(this["FileCount_MediaDivide"]));
            }
            set {
                this["FileCount_MediaDivide"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\")]
        public string ExportDivideFileLocation {
            get {
                return ((string)(this["ExportDivideFileLocation"]));
            }
            set {
                this["ExportDivideFileLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int FileGap_MediaDivide {
            get {
                return ((int)(this["FileGap_MediaDivide"]));
            }
            set {
                this["FileGap_MediaDivide"] = value;
            }
        }
    }
}
