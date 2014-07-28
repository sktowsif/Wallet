﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Money_Tracker.Properties {
    
    
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
        [global::System.Configuration.DefaultSettingValueAttribute("Id|Name|Email|Password|Type|Country")]
        public string User_Cols {
            get {
                return ((string)(this["User_Cols"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.;Initial Catalog=MoneyManagenent;Integrated Security=True")]
        public string ConnectionString {
            get {
                return ((string)(this["ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"INSERT INTO [dbo].[User]
           ([Name]
           ,[Email]
           ,[Password]
           ,[Type]
           ,[Country])
     VALUES
           (Name=@Name
           ,Email=@Email
           ,Password=@Password
           ,Type=@Type
           ,Country=@Country)")]
        public string InsertUser {
            get {
                return ((string)(this["InsertUser"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Id|Name|Type")]
        public string Category_Cols {
            get {
                return ((string)(this["Category_Cols"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("INSERT INTO [Category] VALUES ([Name],[Type])")]
        public string Category_INSERT {
            get {
                return ((string)(this["Category_INSERT"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DELETE FROM [Category] WHERE Id=@Id")]
        public string Category_DELETE {
            get {
                return ((string)(this["Category_DELETE"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("User_Id|Expense|Date|Category_Id")]
        public string Expense_Cols {
            get {
                return ((string)(this["Expense_Cols"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("INSERT INTO [Expense] VALUES ([User_Id],[Expense],[Date],[Category_Id])")]
        public string Expense_INSERT {
            get {
                return ((string)(this["Expense_INSERT"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("User_Id|Expense|Date|Category_Id")]
        public string Income_Cols {
            get {
                return ((string)(this["Income_Cols"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("INSERT INTO [Income] VALUES ([User_Id],[Expense],[Date],[Category_Id])")]
        public string Income_INSERT {
            get {
                return ((string)(this["Income_INSERT"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("UPDATE [dbo].[User]\r\n   SET [Name] = @Name\r\n      ,[Email] = @Email\r\n      ,[Pass" +
            "word] = @Password\r\n      ,[Type] = @Type\r\n      ,[Country] = @Country\r\n WHERE Id" +
            "=@Id")]
        public string UpdateUser {
            get {
                return ((string)(this["UpdateUser"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DELETE FROM [dbo].[User]\r\n      WHERE Id=@Id")]
        public string DeleteUser {
            get {
                return ((string)(this["DeleteUser"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("INSERT INTO [dbo].[Country]\r\n           ([Name]\r\n           ,[Currency])\r\n     VA" +
            "LUES\r\n           (Name=@Name\r\n           ,Currency=@Currency)")]
        public string InsertCountry {
            get {
                return ((string)(this["InsertCountry"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("UPDATE [dbo].[Country]\r\n   SET [Name] = @Name\r\n      ,[Currency] = @Currency\r\n WH" +
            "ERE Id=@Id")]
        public string UpdateCountry {
            get {
                return ((string)(this["UpdateCountry"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DELETE FROM [dbo].[Country]\r\n      WHERE Id=@Id")]
        public string DeleteCountry {
            get {
                return ((string)(this["DeleteCountry"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Id|Name|")]
        public string Country_Cols {
            get {
                return ((string)(this["Country_Cols"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("User_id|Date|Expense|Income|Balance")]
        public string Balance_cols {
            get {
                return ((string)(this["Balance_cols"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string InsertBalance {
            get {
                return ((string)(this["InsertBalance"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SELECT [Id],[Name] FROM [Country]")]
        public string Country_SELECT {
            get {
                return ((string)(this["Country_SELECT"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("INSERT INTO [User] ([Name],[Gender],[Email],[Password],[Type],[Country]) VALUES (" +
            "@Name,@Gender,@Email,@Password,@Type,@Country)")]
        public string User_INSERT {
            get {
                return ((string)(this["User_INSERT"]));
            }
        }
    }
}