﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presentacion.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
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
        [global::System.Configuration.DefaultSettingValueAttribute(@"Data Source=ADRIAN-PC\SQLEXPRESS;Persist Security Info=True;User ID=sa;Password=s12345*workstation id=BDORION.mssql.somee.com;packet size=4096;user id=SQLORION;pwd=A1042447888*;data source=BDORION.mssql.somee.com;persist security info=False;initial catalog=BDORION")]
        public string ConnectionString {
            get {
                return ((string)(this["ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("workstation id=BDORION.mssql.somee.com;packet size=4096;user id=SQLORION;pwd=A104" +
            "2447888*;data source=BDORION.mssql.somee.com;persist security info=False;initial" +
            " catalog=BDORION")]
        public string BDORIONConnectionString {
            get {
                return ((string)(this["BDORIONConnectionString"]));
            }
        }
    }
}
