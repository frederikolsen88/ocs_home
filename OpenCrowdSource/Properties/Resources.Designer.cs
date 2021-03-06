﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenCrowdSource.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenCrowdSource.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream alarm {
            get {
                return ResourceManager.GetStream("alarm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap background {
            get {
                object obj = ResourceManager.GetObject("background", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon BSD_walking {
            get {
                object obj = ResourceManager.GetObject("BSD_walking", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream card {
            get {
                return ResourceManager.GetStream("card", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap card_front {
            get {
                object obj = ResourceManager.GetObject("card_front", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap characters {
            get {
                object obj = ResourceManager.GetObject("characters", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot; ?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;
        ///    xmlns:vc=&quot;http://www.w3.org/2007/XMLSchema-versioning&quot; vc:minVersion=&quot;1.1&quot;&gt; 
        ///
        ///	&lt;xs:attribute name=&quot;id&quot; type=&quot;xs:integer&quot;/&gt;
        ///	&lt;xs:attribute name=&quot;name&quot; type=&quot;xs:string&quot;/&gt;
        ///	
        ///	&lt;xs:element name=&quot;deck&quot;&gt;
        ///		&lt;xs:complexType&gt;
        ///			&lt;xs:choice maxOccurs=&quot;unbounded&quot;&gt;
        ///				&lt;xs:element name=&quot;character&quot; minOccurs=&quot;1&quot; maxOccurs=&quot;unbounded&quot;&gt;
        ///					&lt;xs:complexType&gt;
        ///		 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string deckSchema {
            get {
                return ResourceManager.GetString("deckSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;deck name=&quot;OCS S1 deck&quot;&gt;
        ///  &lt;location id=&quot;1&quot;&gt;
        ///    &lt;value&gt;from Las Vegas&lt;/value&gt;
        ///    &lt;played&gt;0&lt;/played&gt;
        ///  &lt;/location&gt;
        ///  &lt;location id=&quot;2&quot;&gt;
        ///    &lt;value&gt;from Boston&lt;/value&gt;
        ///    &lt;played&gt;0&lt;/played&gt;
        ///  &lt;/location&gt;
        ///  &lt;modifier id=&quot;3&quot;&gt;
        ///    &lt;value&gt;with a plunger&lt;/value&gt;
        ///    &lt;played&gt;0&lt;/played&gt;
        ///  &lt;/modifier&gt;
        ///  &lt;minorTwist id=&quot;4&quot;&gt;
        ///    &lt;value&gt;You know Loom? Do something like that.&lt;/value&gt;
        ///    &lt;played&gt;0&lt;/played&gt;
        ///  &lt;/minorTwist&gt;
        ///  &lt;majorTwist id=&quot;5&quot;&gt;
        ///    &lt;value&gt;Guys, the accountant called and I&apos;m in shit. T [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string defaultDeck {
            get {
                return ResourceManager.GetString("defaultDeck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream fail {
            get {
                return ResourceManager.GetStream("fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to                     GNU GENERAL PUBLIC LICENSE
        ///                       Version 3, 29 June 2007
        ///
        /// Copyright (C) 2007 Free Software Foundation, Inc. &lt;http://fsf.org/&gt;
        /// Everyone is permitted to copy and distribute verbatim copies
        /// of this license document, but changing it is not allowed.
        ///
        ///                            Preamble
        ///
        ///  The GNU General Public License is a free, copyleft license for
        ///software and other kinds of works.
        ///
        ///  The licenses for most software and other practical works are designed
        ///to take away yo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string gpl_3_0 {
            get {
                return ResourceManager.GetString("gpl_3_0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream honk {
            get {
                return ResourceManager.GetStream("honk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap locations {
            get {
                object obj = ResourceManager.GetObject("locations", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap major_twist {
            get {
                object obj = ResourceManager.GetObject("major_twist", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap minor_twist {
            get {
                object obj = ResourceManager.GetObject("minor_twist", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap modifiers {
            get {
                object obj = ResourceManager.GetObject("modifiers", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ocs_header {
            get {
                object obj = ResourceManager.GetObject("ocs_header", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to / -------------------------------- \
        ///| OPEN CROWD SOURCE - HOME EDITION |
        ///\ -------------------------------- /
        ///            Version 1.0
        ///
        ///Table of contents
        ///
        ///1. What have I downloaded? What is this? SWEET JESUS HELP ME
        ///
        ///2. Rules of the game
        ///     2.1 The cards
        ///     2.2 The twists
        ///     2.3 Resetting decks
        ///
        ///3. Creating custom decks
        ///     3.1 Anatomy of a deck XML
        ///          3.1.1 Adding cards
        ///          3.1.2 Adding twists
        ///     3.2 How to play custom decks
        ///
        ///4. Credits
        ///
        ///
        ///
        ///1. What have I downlo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string readme {
            get {
                return ResourceManager.GetString("readme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] Retroville_NC {
            get {
                object obj = ResourceManager.GetObject("Retroville_NC", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap tasks {
            get {
                object obj = ResourceManager.GetObject("tasks", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;deck name=&quot;Template&quot;&gt;
        ///  &lt;location id=&quot;1&quot;&gt;
        ///    &lt;value&gt;This is a location&lt;/value&gt;
        ///    &lt;played&gt;1&lt;/played&gt;
        ///  &lt;/location&gt;
        ///  &lt;modifier id=&quot;2&quot;&gt;
        ///    &lt;value&gt;This is a modifier&lt;/value&gt;
        ///    &lt;played&gt;1&lt;/played&gt;
        ///  &lt;/modifier&gt;
        ///  &lt;character id=&quot;3&quot;&gt;
        ///    &lt;value&gt;This is a character&lt;/value&gt;
        ///    &lt;played&gt;1&lt;/played&gt;
        ///  &lt;/character&gt;
        ///  &lt;task id=&quot;4&quot;&gt;
        ///    &lt;value&gt;This is a task&lt;/value&gt;
        ///    &lt;played&gt;1&lt;/played&gt;
        ///  &lt;/task&gt;
        ///  &lt;minorTwist id=&quot;5&quot;&gt;
        ///    &lt;value&gt;This is a minor twist which will occur approx. halfway through the  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string template {
            get {
                return ResourceManager.GetString("template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] TrashHand {
            get {
                object obj = ResourceManager.GetObject("TrashHand", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
