//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
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
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\projectdb.mdf" +
            ";Integrated Security=True")]
        public string cn {
            get {
                return ((string)(this["cn"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\KIRYUSHA\\ONEDRIVE\\РА" +
            "БОЧИЙ СТОЛ\\WPFAPP1 — КОПИЯ\\PROJECTDB.MDF\";Integrated Security=True")]
        public string C__USERS_KIRYUSHA_ONEDRIVE_РАБОЧИЙ_СТОЛ_WPFAPP1___КОПИЯ_PROJECTDB_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_KIRYUSHA_ONEDRIVE_РАБОЧИЙ_СТОЛ_WPFAPP1___КОПИЯ_PROJECTDB_MDFConnectionSt" +
                    "ring"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\STUDENT\\DESKTOP\\WPFA" +
            "PP1 — КОПИЯ\\PROJECTDB.MDF\";Integrated Security=True")]
        public string C__USERS_STUDENT_DESKTOP_WPFAPP1___КОПИЯ_PROJECTDB_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_STUDENT_DESKTOP_WPFAPP1___КОПИЯ_PROJECTDB_MDFConnectionString"]));
            }
        }
    }
}
