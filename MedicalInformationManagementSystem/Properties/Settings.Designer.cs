﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicalInformationManagementSystem.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
<<<<<<< HEAD
<<<<<<< HEAD
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=SUNNY-ALPHA;Initial Catalog=Giberson;Integrated Security=True;")]
=======
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=SUNNY-ALPHA;Initial Catalog=Giberson;Integrated Security=True")]
>>>>>>> parent of c999842... Revert "Final Commit"
=======
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=SUNNY-ALPHA;Initial Catalog=Giberson;Integrated Security=True;")]
>>>>>>> 744a4185bbf9337525e17e2bb4860eefc6a8289c
        public string GibersonConnectionString {
            get {
                return ((string)(this["GibersonConnectionString"]));
            }
        }
    }
}
