﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ultimate.mailer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SettingLicenseSerial {
            get {
                return ((string)(this["SettingLicenseSerial"]));
            }
            set {
                this["SettingLicenseSerial"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SettingProjectBackup {
            get {
                return ((bool)(this["SettingProjectBackup"]));
            }
            set {
                this["SettingProjectBackup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SettingServersCertificate {
            get {
                return ((bool)(this["SettingServersCertificate"]));
            }
            set {
                this["SettingServersCertificate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int SettingServersReportsValidity {
            get {
                return ((int)(this["SettingServersReportsValidity"]));
            }
            set {
                this["SettingServersReportsValidity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int SettingServersReportsInterval {
            get {
                return ((int)(this["SettingServersReportsInterval"]));
            }
            set {
                this["SettingServersReportsInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int SettingRecipientsValidationLevel {
            get {
                return ((int)(this["SettingRecipientsValidationLevel"]));
            }
            set {
                this["SettingRecipientsValidationLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SettingRecipientsValidationLevelRole {
            get {
                return ((bool)(this["SettingRecipientsValidationLevelRole"]));
            }
            set {
                this["SettingRecipientsValidationLevelRole"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SettingRecipientsValidationLevelDisposable {
            get {
                return ((bool)(this["SettingRecipientsValidationLevelDisposable"]));
            }
            set {
                this["SettingRecipientsValidationLevelDisposable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SettingServersAuthentication {
            get {
                return ((bool)(this["SettingServersAuthentication"]));
            }
            set {
                this["SettingServersAuthentication"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60000")]
        public int SettingProxiesValidationTimeout {
            get {
                return ((int)(this["SettingProxiesValidationTimeout"]));
            }
            set {
                this["SettingProxiesValidationTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60000")]
        public int SettingRecipientsValidationTimeout {
            get {
                return ((int)(this["SettingRecipientsValidationTimeout"]));
            }
            set {
                this["SettingRecipientsValidationTimeout"] = value;
            }
        }
    }
}