﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace sol_git_jen
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the sol_git_jenRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    [RepositoryFolder("ddb19f9e-7fd9-486c-bfc0-cdcc0c7df752")]
    public partial class sol_git_jenRepository : RepoGenBaseFolder
    {
        static sol_git_jenRepository instance = new sol_git_jenRepository();
        sol_git_jenRepositoryFolders.KeyPromptFormAppFolder _keypromptform;

        /// <summary>
        /// Gets the singleton class instance representing the sol_git_jenRepository element repository.
        /// </summary>
        [RepositoryFolder("ddb19f9e-7fd9-486c-bfc0-cdcc0c7df752")]
        public static sol_git_jenRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public sol_git_jenRepository() 
            : base("sol_git_jenRepository", "/", null, 0, false, "ddb19f9e-7fd9-486c-bfc0-cdcc0c7df752", ".\\RepositoryImages\\sol_git_jenRepositoryddb19f9e.rximgres")
        {
            _keypromptform = new sol_git_jenRepositoryFolders.KeyPromptFormAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("ddb19f9e-7fd9-486c-bfc0-cdcc0c7df752")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The KeyPromptForm folder.
        /// </summary>
        [RepositoryFolder("7ed300b3-67ab-49e7-96a3-cc8504231e21")]
        public virtual sol_git_jenRepositoryFolders.KeyPromptFormAppFolder KeyPromptForm
        {
            get { return _keypromptform; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    public partial class sol_git_jenRepositoryFolders
    {
        /// <summary>
        /// The KeyPromptFormAppFolder folder.
        /// </summary>
        [RepositoryFolder("7ed300b3-67ab-49e7-96a3-cc8504231e21")]
        public partial class KeyPromptFormAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new KeyPromptForm  folder.
            /// </summary>
            public KeyPromptFormAppFolder(RepoGenBaseFolder parentFolder) :
                    base("KeyPromptForm", "/form[@controlname='KeyPromptForm']", parentFolder, 30000, null, true, "7ed300b3-67ab-49e7-96a3-cc8504231e21", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7ed300b3-67ab-49e7-96a3-cc8504231e21")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("7ed300b3-67ab-49e7-96a3-cc8504231e21")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}