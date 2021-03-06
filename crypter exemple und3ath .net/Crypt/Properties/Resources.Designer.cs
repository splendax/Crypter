﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.261
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crypt.Properties {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
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
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Crypt.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
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
        ///   Recherche une chaîne localisée semblable à  public static byte[] DexDecrypt(byte[] plain, string Key)
        ///        {
        ///            byte[] key = System.Text.Encoding.ASCII.GetBytes(Key);
        ///            for (int round = 4; round &gt;= 0; round--)
        ///            {
        ///                for (int i = 0; i &lt; plain.Length; i++)
        ///                {
        ///                    for (int k = 0; k &lt; key.Length; k++) plain[i] = (byte)(plain[i] ^ ((((key[k] &lt;&lt; round) ^ k) + i)));
        ///                    plain[i] = (byte)(plain[i] ^ key[i % key.Length]);
        ///                }
        ///            }
        ///   [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string Dex {
            get {
                return ResourceManager.GetString("Dex", resourceCulture);
            }
        }
        
        internal static System.Drawing.Icon key_kgpg_icone_5557 {
            get {
                object obj = ResourceManager.GetObject("key_kgpg_icone_5557", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à public static byte[] RC4EncryptDecrypt(byte[] bytes, string Key)
        ///{
        ///byte[] key = System.Text.Encoding.ASCII.GetBytes(Key);
        ///byte[] s = new byte[256];
        ///byte[] k = new byte[256];
        ///byte temp;
        ///int i, j;
        /// 
        ///for (i = 0; i &lt; 256; i++)
        ///{
        ///s[i] = (byte)i;
        ///k[i] = key[i % key.GetLength(0)];
        ///}
        /// 
        ///j = 0;
        ///for (i = 0; i &lt; 256; i++)
        ///{
        ///j = (j + s[i] + k[i]) % 256;
        ///temp = s[i];
        ///s[i] = s[j];
        ///s[j] = temp;
        ///}
        /// 
        ///i = j = 0;
        ///for (int x = 0; x &lt; bytes.GetLength(0); x++)
        ///{
        ///i = (i + 1) % 256;
        ///j = (j + s[i]) % 256;        /// [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string Rc4 {
            get {
                return ResourceManager.GetString("Rc4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à         public static byte[] RijndaelDecrypt(byte[] bytes, string Key)
        ///        {
        ///            Rijndael rijndael = Rijndael.Create();
        ///            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(Key,
        ///                new byte[] { 0x26, 0xdc, 0xff, 0x00, 0xad, 0xed, 0x7a, 0xee, 0xc5, 0xfe, 0x07, 0xaf, 0x4d, 0x08, 0x22, 0x3c });
        ///            rijndael.Key = pdb.GetBytes(32);
        ///            rijndael.IV = pdb.GetBytes(16);
        ///            MemoryStream memoryStream = new MemoryStream();
        ///            CryptoStream crypt [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string Rijndael {
            get {
                return ResourceManager.GetString("Rijndael", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à     using System;
        ///	using System.IO;
        ///    using System.Diagnostics;
        ///    using System.Windows.Forms;
        ///	using System.Security.Cryptography;
        ///	using System.Text;  
        ///	using System.Resources;
        ///	using System.Reflection;
        ///
        ///
        /////|[assembly: AssemblyTitle(&quot;title&quot;)]
        /////|[assembly: AssemblyDescription(&quot;description&quot;)]
        /////|[assembly: AssemblyCompany(&quot;company&quot;)]
        /////|[assembly: AssemblyProduct(&quot;product&quot;)]
        /////|[assembly: AssemblyCopyright(&quot;copyright&quot;)]
        /////|[assembly: AssemblyTrademark(&quot;trademark&quot;)]
        /////|[assembly: Assembly [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string Source {
            get {
                return ResourceManager.GetString("Source", resourceCulture);
            }
        }
    }
}
