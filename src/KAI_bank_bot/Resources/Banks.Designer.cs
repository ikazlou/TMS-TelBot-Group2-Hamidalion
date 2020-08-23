﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KAI_bank_bot.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Banks {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Banks() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KAI_bank_bot.Resources.Banks", typeof(Banks).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to parse information - {0}.
        /// </summary>
        public static string ErrorMessage {
            get {
                return ResourceManager.GetString("ErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /banks.
        /// </summary>
        public static string Link {
            get {
                return ResourceManager.GetString("Link", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Курсы основных валют в банках Минска на данный момент (источник - MyFin.by)\n.
        /// </summary>
        public static string Message {
            get {
                return ResourceManager.GetString("Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://myfin.by/currency/minsk.
        /// </summary>
        public static string MyFinURL {
            get {
                return ResourceManager.GetString("MyFinURL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .//tr/td/span.
        /// </summary>
        public static string Path {
            get {
                return ResourceManager.GetString("Path", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to !.
        /// </summary>
        public static string Separator {
            get {
                return ResourceManager.GetString("Separator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;b&gt;Банк                          USD                           EUR                           RUB                           EUR to USD          &lt;/b&gt;\n
        ///&lt;i&gt;                                  покупка   продажа  покупка   продажа покупка   продажа  покупка   продажа&lt;/i&gt;.
        /// </summary>
        public static string TableHeader {
            get {
                return ResourceManager.GetString("TableHeader", resourceCulture);
            }
        }
    }
}