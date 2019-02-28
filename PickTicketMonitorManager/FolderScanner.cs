using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickTicketHandler {

    public class FolderScanner {
        
        //list of folder filepaths to be watched
        public ListBox watchedfolders_container;

        public FolderScanner(ListBox watchedfolders_container) {
            //constructor

            this.watchedfolders_container = watchedfolders_container;
        }

        public Dictionary<string, string> log_entries = new Dictionary<string, string>();

        public bool AddWatchedFolder(string filepath) {
            //adds a given filepath to this object's list of watched folders

            if( Directory.Exists(filepath) ) {

                foreach (object item in watchedfolders_container.Items) {

                    if (item.ToString() == filepath) {
                        MessageBox.Show("Error: Filepath already watched.", "Error", MessageBoxButtons.OK);
                        return false;
                    }

                }
                watchedfolders_container.Items.Add(filepath);
                watchedfolders_container.Refresh();
                return true;

            } else {
                MessageBox.Show("Error: Filepath invalid. Enter a valid filepath.", "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public void ScanAllFolders() {

            foreach (object item in watchedfolders_container.Items) {

                ScanFolder( item.ToString() );

            }
        }

        public void ScanFolder(string path) {

            DirectoryInfo d = new DirectoryInfo(path + "\\");
            FileInfo[] flist = d.GetFiles("*.pdf");

            string full_file_path, 
                        file_path, 
                        file_name, 
                        file_extension, 
                        file_name_cleaned, 
                        file_ID, 
                        warehouse_ID = "";

            bool iscopy;

            string from, to = "";

            string ID = "";

            Dictionary<string, string> originalIDs = new Dictionary<string, string>();
            Dictionary<string, string> duplicateIDs = new Dictionary<string, string>();


            foreach (var file in flist) {

                Console.WriteLine("===============");

                full_file_path      = file.FullName;
                Console.WriteLine("Full: " + full_file_path);

                file_path           = GetFilePath(full_file_path);
                Console.WriteLine("Path: " + file_path);

                file_name           = GetFileName(full_file_path);
                Console.WriteLine("Name: " + file_name);

                file_extension      = GetFileExtension(full_file_path);
                Console.WriteLine("Ext : " + file_extension);

                file_name_cleaned   = GetFileName_RemoveDuplicatePatterns(file_name);
                file_name_cleaned   = file_name_cleaned.Replace(file_extension, "");
                Console.WriteLine("-Dup: " + file_name_cleaned);

                file_ID             = GetFileID(file_name_cleaned);
                Console.WriteLine("F ID: " + file_ID);

                warehouse_ID        = GetWarehouseID(file_name_cleaned);
                Console.WriteLine("WhID: " + warehouse_ID);

                //is file a copy?
                iscopy = FileIsCopy( file_name );
                Console.WriteLine("Copy? " + iscopy.ToString() );

                if(iscopy) {
                    //if file is a copy
                    //put file in duplicateIDs Array

                    duplicateIDs.Add(full_file_path, file_ID);
                }

                else {

                    if (originalIDs.ContainsKey(file_ID) ) {
                        //file actually is a copy
                        //put file into duplicateIDs

                        duplicateIDs.Add(full_file_path, file_ID);

                    } else {
                        //file is not a copy
                        //put file in originalIDs Array

                        originalIDs.Add(file_ID, warehouse_ID);
                    }
                }
            }

            foreach (KeyValuePair<string, string> entry in duplicateIDs) {
                //do things
                from = entry.Key;
                ID = entry.Value;

                if (originalIDs.ContainsKey(ID)) {

                    to = originalIDs[ID].ToString();
                    to = Path.Combine(GetFilePath(from), to + "\\");

                    Console.WriteLine("Moving: " + from);
                    WriteToLog(from, "Moving: " + from);

                    Console.WriteLine("To:     " + to);
                    WriteToLog(from, "To:     " + to);

                    MoveFile(from, to);

                } else {
                    //file is invalid, move to invalid folder

                    to = Path.Combine(GetFilePath(from), "_InvalidFiles\\");
                    
                    Console.WriteLine("Moving: " + from);
                    WriteToLog(from, "Moving: " + from);
                    Console.WriteLine("To:     " + to);
                    WriteToLog(from, "To:     " + to);
                    MoveFile(from, to);
                }
            }

            Console.WriteLine("===============");            
            Console.WriteLine("======EOF======");
            Console.WriteLine("===============");
        }

        public string GetFilePath( string s ) {

            if(s.LastIndexOf("\\") > -1) {
                s = s.Substring(0, s.LastIndexOf("\\"));
            } else {

                s = "";
            }

            return s;
        }

        public string GetFileName(string s) {

            if (s.LastIndexOf("\\") > -1) {
                s = s.Substring(s.LastIndexOf("\\") + 1);
            }

            return s;
        }

        public string GetFileExtension(string s) {
            if( s.LastIndexOf(".") > -1 ) {
                s = s.Substring(s.LastIndexOf("."));
            } else {

                s = "";
            }
            return s;
        }

        public string GetFileName_RemoveDuplicatePatterns(string s) {

            while (s.LastIndexOf("Copy of ") > -1) {
                s = s.Replace("Copy of ", "");
            }

            while (s.LastIndexOf(" - Copy ") > -1) {
                s = s.Replace(" - Copy ", "");
            }

            while (s.LastIndexOf(" - Copy") > -1) {
                s = s.Replace(" - Copy", "");
            }

            while (s.LastIndexOf("- Copy ") > -1) {
                s = s.Replace("- Copy ", "");
            }

            while (s.LastIndexOf("- Copy") > -1) {
                s = s.Replace("- Copy", "");
            }

            while ( s.IndexOf(" (") > 0 && s.IndexOf(")") > -1 ) {
                s = s.Substring(0, s.IndexOf(" ("));
            }

            while (s.IndexOf("(") > 0 && s.IndexOf(")") > -1) {
                s = s.Substring(0, s.IndexOf("("));
            }

            return s;
        }

        public string GetFileID(string s) {
            
            if(s.LastIndexOf(" ") > -1) {
                s = s.Substring(s.LastIndexOf(" ") + 1, s.Length - s.LastIndexOf(" ") - 1);
            }
            
            return s;
        }

        public string GetWarehouseID(string s) {   
            if (s.IndexOf(" ") > -1) {
                s = s.Substring(0, s.IndexOf(" "));
            } else {

                s = "";

            }

            return s;
        }

        public bool FileIsCopy(string s) {
            
            int i = s.Length;            

            if( s.Length > GetFileName_RemoveDuplicatePatterns(s).Length ) {

                return true;
            }

            return false;
        }

        public void MoveFile(string filepath, string destination) {
            //moves a full filepath string 
            //from "C:\...\fromlocation\file.txt" 
            //to   "C:\...\destination\"
            
            if( Directory.Exists(GetFilePath(destination)) == false ) {
                //destination directory doesn't exist
                //make it
                System.IO.Directory.CreateDirectory(destination);
            }

            System.IO.File.Move(filepath, destination + GetFileName(filepath));            
        }

        public void WriteToLog(string watchedfolder, string error_text) {

            string s = "";
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            
            if ( log_entries.ContainsKey(watchedfolder) ) {

                s = log_entries[watchedfolder];

                log_entries.Remove(watchedfolder);
                log_entries.Add(watchedfolder, s + "\n" + timestamp + " : " + error_text);

            } else {

                log_entries.Add(watchedfolder, timestamp + " : " + error_text);
            }
        }

        public string GetLogEntry(string watchedfolder) {

            if (log_entries.ContainsKey(watchedfolder) ) {

                return log_entries[watchedfolder].ToString();
            }

            return "";
        }
    }
}
