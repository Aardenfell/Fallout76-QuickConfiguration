﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Fo76ini.Mods
{
    /// <summary>
    /// Wrapper around the resource lists to function as a regular List.
    /// Implements ways to read and write to *.ini file.
    /// </summary>
    public class ResourceList : ICollection<string>
    {
        public static List<string> KnownLists = new List<string>() {
            "sResourceIndexFileList",
            "sResourceArchive2List",
            "sResourceArchiveMisc",        // <- haven't seen this before (apparently "can load any mod except for texture and animation mods")
            "sResourceStartUpArchiveList",
            "SResourceArchiveList",
            "SResourceArchiveList2",
            // "sResourceDataDirsFinal",
            //"SResourceArchiveMemoryCacheList"
        };

        public const string DefaultList = "sResourceArchive2List";

        public static string PreferredList {
            get
            {
                return Configuration.Mods.ResourceListName;
            }
        }



        private List<string> resourceList = new List<string>();

        public string ListName = PreferredList;

        public int Count => this.resourceList.Count;

        public bool IsReadOnly => false;


        /*
         * Constructor:
         */

        /// <summary>
        /// Creates a new ResourceList from a string.
        /// </summary>
        /// <param name="s">Resources, separated by a ','</param>
        public static ResourceList FromString(String s)
        {
            ResourceList list = new ResourceList();
            list.resourceList = ResourceList.ToList(s);
            return list;
        }

        /// <summary>
        /// Reads the Mods\resources.txt file and loads it's contents.
        /// </summary>
        /// <returns></returns>
        public static ResourceList FromTXT(String path)
        {
            ResourceList list = new ResourceList();
            list.LoadTXT(path);
            return list;
        }

        /// <summary>
        /// Reads the Mods\resources.txt file and loads it's contents.
        /// </summary>
        /// <returns></returns>
        public static ResourceList FromINI(String listName)
        {
            ResourceList list = new ResourceList();
            list.ListName = listName;
            list.LoadFromINI();
            return list;
        }

        public static ResourceList GetPreferredList()
        {
            return ResourceList.FromINI(
                PreferredList
            );
        }

        public static ResourceList GetResourceArchive2List()
        {
            return ResourceList.FromINI(
                "sResourceArchive2List"
            );
        }

        public static ResourceList GetResourceIndexFileList()
        {
            return ResourceList.FromINI(
                "sResourceIndexFileList"
            );
        }

        /// <summary>
        /// Creates an empty list.
        /// </summary>
        public ResourceList() { }

        /*
         * Converting from and to string:
         */

        private static List<string> ToList(string sResourceList)
        {
            return (new List<string>(sResourceList.Split(new char[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries))).Select(x => x.Trim()).Distinct().ToList();
        }

        private static string ToString(List<string> resourceList, string separator = ",")
        {
            return string.Join(separator, resourceList.Distinct());
        }

        public override string ToString()
        {
            return ResourceList.ToString(this.resourceList);
        }

        public string ToString(string separator)
        {
            return ResourceList.ToString(this.resourceList, separator);
        }

        /// <summary>
        /// Loads the resource list from the associated *.ini file.
        /// </summary>
        public void LoadFromINI()
        {
            this.resourceList = ResourceList.ToList(
                    IniFiles.F76Custom.GetString("Archive", ListName, "")
            );
        }

        /// <summary>
        /// Commits changes to the resource list for the associated *.ini file.
        /// </summary>
        public void CommitToINI()
        {
            // Remove lists to prevent duplicates:
            if ((new string[]{ "sResourceIndexFileList", "sResourceArchive2List" }).Contains(ListName))
            {
                IniFiles.F76Custom.Remove("Archive", "sResourceIndexFileList");
                IniFiles.F76Custom.Remove("Archive", "sResourceArchive2List");
            }

            // Write:
            if (Count > 0)
                IniFiles.F76Custom.Set("Archive", ListName, ToString());
            else
                IniFiles.F76Custom.Remove("Archive", ListName);

            IniFiles.F76Custom.Save();
        }


        /*
         * Writting to and reading from resources.txt:
         */

        /// <summary>
        /// Writes list to the Mods\resources.txt file.
        /// </summary>
        public void SaveTXT(String path)
        {
            File.WriteAllText(
                path,
                this.ToString()
            );
        }

        public void LoadTXT(String path)
        {
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                this.resourceList = ResourceList.ToList(text);
            }
            else
            {
                this.Clear();
            }
        }


        /*
         * Implementing ICollection interface:
         */

        public IEnumerator<string> GetEnumerator()
        {
            return this.resourceList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(string item)
        {
            this.resourceList.Add(item);
        }

        public void Clear()
        {
            this.resourceList.Clear();
        }

        public bool Contains(string item)
        {
            return this.resourceList.Contains(item);
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            this.resourceList.CopyTo(array, arrayIndex);
        }

        public bool Remove(string item)
        {
            return this.resourceList.Remove(item);
        }


        /*
         * Additional methods from List<T>:
         */

        /// <summary>
        /// Inserts an element into the list at the specified index.
        /// </summary>
        public void Insert(int index, string item)
        {
            this.resourceList.Insert(index, item);
        }

        /// <summary>
        /// Adds the elements of the specified list at the end of the resource list.
        /// </summary>
        public void AddRange(ResourceList list)
        {
            this.resourceList.AddRange(list.resourceList);
            Distinct();
        }

        /// <summary>
        /// Adds the elements of the specified list at the end of the resource list.
        /// </summary>
        public void AddRange(List<string> list)
        {
            this.resourceList.AddRange(list);
            Distinct();
        }


        /*
         * Utility methods:
         */

        /// <summary>
        /// Removes resources that aren't existing on disk.
        /// </summary>
        public void CleanUp(string gamePath)
        {
            string[] temp = new string[this.Count()];
            this.CopyTo(temp, 0);
            foreach (string ba2file in temp)
                if (!File.Exists(Path.Combine(gamePath, "Data", ba2file)))
                    this.Remove(ba2file);
        }

        public void ReplaceRange(ResourceList other)
        {
            this.resourceList.Clear();
            this.resourceList.AddRange(other);
        }

        private void Distinct()
        {
            this.resourceList = this.resourceList.Select(x => x.Trim()).Distinct().ToList();
        }
    }
}
