﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddingNewProductInATable {
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
    internal class GlobalConstants {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GlobalConstants() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AddingNewProductInATable.GlobalConstants", typeof(GlobalConstants).Assembly);
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
        ///   Looks up a localized string similar to 1.
        /// </summary>
        internal static string CategoryId {
            get {
                return ResourceManager.GetString("CategoryId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Products VALUES (@name, @supplierId, @categoryId, @quantityPerUnit, @unitPrice, @unitsInStock, @unitsInOrder, @reorderLevel, @discontinued).
        /// </summary>
        internal static string CommandInsert {
            get {
                return ResourceManager.GetString("CommandInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT @@IDENTITY.
        /// </summary>
        internal static string CommandSelectIdentity {
            get {
                return ResourceManager.GetString("CommandSelectIdentity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1.
        /// </summary>
        internal static string Discontinued {
            get {
                return ResourceManager.GetString("Discontinued", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New ProductID: {0}.
        /// </summary>
        internal static string NewProductId {
            get {
                return ResourceManager.GetString("NewProductId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Xylitol.
        /// </summary>
        internal static string ProductName {
            get {
                return ResourceManager.GetString("ProductName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 20 boxes x 10 bags.
        /// </summary>
        internal static string QuantityPerUnit {
            get {
                return ResourceManager.GetString("QuantityPerUnit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 10.
        /// </summary>
        internal static string ReorderLevel {
            get {
                return ResourceManager.GetString("ReorderLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1.
        /// </summary>
        internal static string SupplierId {
            get {
                return ResourceManager.GetString("SupplierId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 15.00.
        /// </summary>
        internal static string UnitPrice {
            get {
                return ResourceManager.GetString("UnitPrice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 27.
        /// </summary>
        internal static string UnitsInOrder {
            get {
                return ResourceManager.GetString("UnitsInOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 100.
        /// </summary>
        internal static string UnitsInStock {
            get {
                return ResourceManager.GetString("UnitsInStock", resourceCulture);
            }
        }
    }
}
