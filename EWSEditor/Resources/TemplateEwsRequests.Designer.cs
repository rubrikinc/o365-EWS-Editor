﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EWSEditor.Resources {
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
    internal class TemplateEwsRequests {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TemplateEwsRequests() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EWSEditor.Resources.TemplateEwsRequests", typeof(TemplateEwsRequests).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;soap:Envelope xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot;
        ///      xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;
        ///      xmlns:soap=&quot;http://schemas.xmlsoap.org/soap/envelope/&quot;
        ///      xmlns:t=&quot;http://schemas.microsoft.com/exchange/services/2006/types&quot;
        ///      xmlns:m=&quot;http://schemas.microsoft.com/exchange/services/2006/messages&quot;&gt;
        ///  &lt;soap:Header&gt;
        ///    &lt;t:RequestServerVersion Version=&quot;##RequestServerVersion##&quot;/&gt;
        ///  &lt;/soap:Header&gt;
        ///  &lt;soap:Body&gt;
        ///    &lt;m:ExportItem [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExportItems {
            get {
                return ResourceManager.GetString("ExportItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;soap:Envelope xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot;
        ///      xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;
        ///      xmlns:soap=&quot;http://schemas.xmlsoap.org/soap/envelope/&quot;
        ///      xmlns:t=&quot;http://schemas.microsoft.com/exchange/services/2006/types&quot;
        ///      xmlns:m=&quot;http://schemas.microsoft.com/exchange/services/2006/messages&quot;&gt;
        ///  &lt;soap:Header&gt;
        ///      &lt;t:RequestServerVersion Version=&quot;##RequestServerVersion##&quot;/&gt;
        ///      &lt;ExchangeImpersonation xmlns=&quot;http://schem [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExportItems_ImpersonateBySmtp {
            get {
                return ResourceManager.GetString("ExportItems_ImpersonateBySmtp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;soap:Envelope xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot;
        ///        xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;
        ///        xmlns:soap=&quot;http://schemas.xmlsoap.org/soap/envelope/&quot;
        ///        xmlns:t=&quot;http://schemas.microsoft.com/exchange/services/2006/types&quot;&gt;
        ///  &lt;soap:Header&gt;
        ///    &lt;t:RequestServerVersion Version=&quot;##RequestServerVersion##&quot; /&gt;
        ///  &lt;/soap:Header&gt;
        ///  &lt;soap:Body&gt;
        ///    &lt;GetMailTips xmlns=&quot;http://schemas.microsoft.com/exchange/services/2006/messages&quot;&gt;
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetMailTips {
            get {
                return ResourceManager.GetString("GetMailTips", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;soap:Envelope xmlns:a=&quot;http://schemas.microsoft.com/exchange/2010/Autodiscover&quot; xmlns:wsa=&quot;http://www.w3.org/2005/08/addressing&quot; xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xmlns:soap=&quot;http://schemas.xmlsoap.org/soap/envelope/&quot;&gt;
        ///  &lt;soap:Header&gt;
        ///    &lt;a:RequestedServerVersion&gt;##ExchangeVersion##&lt;/a:RequestedServerVersion&gt;
        ///    &lt;wsa:Action&gt;http://schemas.microsoft.com/exchange/2010/Autodiscover/Autodiscover/GetUserSettings&lt;/wsa:Action&gt;
        ///    &lt;wsa:To&gt;##AutoDis [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GroupingInformationTemplateRequest {
            get {
                return ResourceManager.GetString("GroupingInformationTemplateRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;soap:Envelope 
        ///        xmlns:soap=&quot;http://schemas.xmlsoap.org/soap/envelope/&quot; 
        ///        xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; 
        ///       xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///&lt;soap:Header&gt;
        ///    &lt;RequestServerVersion Version=&quot;##RequestServerVersion##&quot; xmlns=&quot;http://schemas.microsoft.com/exchange/services/2006/types&quot; /&gt;
        ///&lt;/soap:Header&gt;
        ///&lt;soap:Body&gt;
        ///    &lt;UploadItems xmlns=&quot;http://schemas.microsoft.com/exchange/services/2006/messages&quot;&gt;
        ///        &lt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UploadItems_CreateNew {
            get {
                return ResourceManager.GetString("UploadItems_CreateNew", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;soap:Envelope 
        ///        xmlns:soap=&quot;http://schemas.xmlsoap.org/soap/envelope/&quot; 
        ///        xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; 
        ///       xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///&lt;soap:Header&gt;
        ///    &lt;RequestServerVersion Version=&quot;##RequestServerVersion##&quot; xmlns=&quot;http://schemas.microsoft.com/exchange/services/2006/types&quot; /&gt;
        ///    &lt;ExchangeImpersonation xmlns=&quot;http://schemas.microsoft.com/exchange/services/2006/types&quot;&gt;
        ///      &lt;ConnectingSID&gt;
        ///         [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UploadItems_CreateNew_ImpersonateBySmtp {
            get {
                return ResourceManager.GetString("UploadItems_CreateNew_ImpersonateBySmtp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;soap:Envelope 
        ///        xmlns:soap=&quot;http://schemas.xmlsoap.org/soap/envelope/&quot; 
        ///        xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; 
        ///       xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///&lt;soap:Header&gt;
        ///    &lt;RequestServerVersion Version=&quot;##RequestServerVersion##&quot; xmlns=&quot;http://schemas.microsoft.com/exchange/services/2006/types&quot; /&gt;
        ///&lt;/soap:Header&gt;
        ///&lt;soap:Body&gt;
        ///    &lt;UploadItems xmlns=&quot;http://schemas.microsoft.com/exchange/services/2006/messages&quot;&gt;
        ///        &lt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UploadItems_Update {
            get {
                return ResourceManager.GetString("UploadItems_Update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;soap:Envelope 
        ///        xmlns:soap=&quot;http://schemas.xmlsoap.org/soap/envelope/&quot; 
        ///        xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; 
        ///       xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///&lt;soap:Header&gt;
        ///    &lt;RequestServerVersion Version=&quot;##RequestServerVersion##&quot; xmlns=&quot;http://schemas.microsoft.com/exchange/services/2006/types&quot; /&gt;
        ///      &lt;ExchangeImpersonation xmlns=&quot;http://schemas.microsoft.com/exchange/services/2006/types&quot;&gt;
        ///        &lt;ConnectingSID&gt;
        ///     [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UploadItems_Update_ImpersonateBySmtp {
            get {
                return ResourceManager.GetString("UploadItems_Update_ImpersonateBySmtp", resourceCulture);
            }
        }
    }
}
