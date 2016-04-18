using System.Reflection;
using System.Runtime.InteropServices;
using log4net.Config;

[assembly: XmlConfigurator(ConfigFile = "NewAppUI.log4net.cfg.xml", Watch = true)]
//Company shipping the assembly

[assembly: AssemblyCompany("%ASM_COMPANY%")]

//Friendly name for the assembly

[assembly: AssemblyTitle("%ASM_PRODUCT% Service Manager User Interface")]

//Short description of the assembly

[assembly:
    AssemblyDescription(
        "%ASM_PRODUCT% Service Manager.  This is a user interface help starting or stopping the Service and manage service settings."
        )]
[assembly: AssemblyConfiguration("")]

//Product Name

[assembly: AssemblyProduct("%ASM_PRODUCT%")]

//Copyright information

[assembly: AssemblyCopyright("Copyright %ASM_COMPANY% © %YEAR%")]

//Enumeration indicating the target culture for the assembly

[assembly: AssemblyCulture("")]

//

[assembly: ComVisible(false)]

//Version number expressed as a string

[assembly: AssemblyVersion("1.0.*")]
//[assembly: AssemblyFileVersion("1.0.0.0")]