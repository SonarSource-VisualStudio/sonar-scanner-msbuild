﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SonarScanner.Integration.Tasks.IntegrationTests.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SonarScanner.Integration.Tasks.IntegrationTests.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&apos;1.0&apos; encoding=&apos;utf-8&apos;?&gt;
        ///&lt;Project ToolsVersion=&apos;Current&apos; xmlns=&apos;http://schemas.microsoft.com/developer/msbuild/2003&apos;&gt;
        ///
        ///  &lt;Target Name=&apos;CaptureValues&apos; AfterTargets=&apos;{0}&apos;&gt;
        ///    &lt;Message Importance=&apos;high&apos; Text=&apos;CAPTURE::PROPERTY::TargetDir::$(TargetDir)&apos; /&gt;
        ///    &lt;Message Importance=&apos;high&apos; Text=&apos;CAPTURE::PROPERTY::TargetFileName::$(TargetFileName)&apos; /&gt;
        ///    &lt;Message Importance=&apos;high&apos; Text=&apos;CAPTURE::PROPERTY::ErrorLog::$(ErrorLog)&apos; /&gt;
        ///    &lt;Message Importance=&apos;high&apos; Text=&apos;CAPTURE::PROPERTY::Proje [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CaptureDataTargetsFileTemplate {
            get {
                return ResourceManager.GetString("CaptureDataTargetsFileTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Project Sdk=&apos;Microsoft.NET.Sdk&apos;&gt;
        ///
        ///  &lt;!-- Test-specific XML snippet --&gt;
        ///  {0}
        ///
        ///  &lt;!-- Boilerplate --&gt;
        ///  &lt;PropertyGroup&gt;
        ///    &lt;ProjectGuid&gt;{1}&lt;/ProjectGuid&gt;
        ///    &lt;SonarQubeTempPath&gt;c:\dummy\path&lt;/SonarQubeTempPath&gt;
        ///    &lt;SonarQubeOutputPath&gt;c:\dummy\path&lt;/SonarQubeOutputPath&gt;
        ///    &lt;SonarQubeConfigPath&gt;{4}&lt;/SonarQubeConfigPath&gt;
        ///    &lt;SonarQubeBuildTasksAssemblyFile&gt;{2}&lt;/SonarQubeBuildTasksAssemblyFile&gt;
        ///  &lt;/PropertyGroup&gt;
        ///
        ///  &lt;!-- We need to write out the properties we want to check later --&gt;
        ///  &lt;Targe [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CategoriseProjectTestTemplate {
            get {
                return ResourceManager.GetString("CategoriseProjectTestTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&apos;1.0&apos; encoding=&apos;utf-8&apos;?&gt;
        ///&lt;Project ToolsVersion=&apos;Current&apos; xmlns=&apos;http://schemas.microsoft.com/developer/msbuild/2003&apos;&gt;
        ///
        ///  &lt;!-- Test-specific data --&gt;
        ///  TEST_SPECIFIC_XML
        ///
        ///  &lt;!-- Boilerplate --&gt;
        ///  &lt;PropertyGroup&gt;
        ///    &lt;ImportByWildcardBeforeMicrosoftCommonTargets&gt;false&lt;/ImportByWildcardBeforeMicrosoftCommonTargets&gt;
        ///    &lt;ImportByWildcardAfterMicrosoftCommonTargets&gt;false&lt;/ImportByWildcardAfterMicrosoftCommonTargets&gt;
        ///    &lt;ImportUserLocationsByWildcardBeforeMicrosoftCommonTargets&gt;false&lt;/Imp [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ImportBeforeTargetTestsTemplate {
            get {
                return ResourceManager.GetString("ImportBeforeTargetTestsTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&apos;1.0&apos; encoding=&apos;utf-8&apos;?&gt;
        ///&lt;Project ToolsVersion=&apos;Current&apos; xmlns=&apos;http://schemas.microsoft.com/developer/msbuild/2003&apos;&gt;
        ///
        ///  &lt;!-- Boilerplate --&gt;
        ///  &lt;!-- All of these boilerplate properties can be overridden by setting the value again in the test-specific XML snippet --&gt;
        ///  &lt;PropertyGroup&gt;
        ///    &lt;ImportByWildcardBeforeMicrosoftCommonTargets&gt;false&lt;/ImportByWildcardBeforeMicrosoftCommonTargets&gt;
        ///    &lt;ImportByWildcardAfterMicrosoftCommonTargets&gt;false&lt;/ImportByWildcardAfterMicrosoftCommonTargets&gt;
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TargetTestsProjectTemplate {
            get {
                return ResourceManager.GetString("TargetTestsProjectTemplate", resourceCulture);
            }
        }
    }
}
