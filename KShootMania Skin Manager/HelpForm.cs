using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATEM;
using System.Diagnostics;

namespace KShootMania_Skin_Manager
{
    /// <summary>
    /// A form that displays help information for the user to read
    /// </summary>
    public partial class HelpForm : Form
    {
        /// <summary>
        /// The help topics that can be read by the user
        /// </summary>
        private static Dictionary<string, string> topics;

        /// <summary>
        /// The destination of the link on the current help page
        /// </summary>
        private static string link;

        public HelpForm()
        {
            topics = new Dictionary<string, string>();
            topics.AddRange(
                #region Topics
                "What is KShootMania?",
                "KShootMania is a rhythm game that consists of notes along numerous lanes of a track that the player must hit when they reach the bottom of the track.\n" +
                "There are four lanes which white (BT) object travel down. Orange (FX) objects also travel down either the two lefthand or two righthand lanes and cause a distortion to the song when successfully hit.\n" +
                "Laser objects will also travel down the screen, moving left and right in various patterns, to which the player must move indicators to line up with them.\n" +
                @"KShootMania can be downloaded at \L[http://www.kshootmania.com]http://www.kshootmania.com/\/L",

                "What is KShootMania Skin Manager",
                "KShootMania Skin Manager is a utility that automates replacement of textures and audio files or \"skins\" for KShootMania.\n",

                "Installation",
                "You must already have KShootMania installed on your computer and have the zip file for KShootMania. If you deleted it, you'll have to redownload them again.\n" +
                "To install KShootMania Skin Manager, create a folder you would like to install KShootMania Skin Manager to and put \"KShootMania Skin Manager.exe\" in the folder.\n" +
                "Afterwards, run KShootMania Skin Manager.exe and go through the installation process.\n" +
                "NOTE: If you want to move the installation location, you must uninstall KShootMania Skin Manager first. To do so, see \"Uninstallation\".",

                "How to use KShootMania Skin Manager",
                "After installing KShootMania Skin Manager, while KShootMania is running, a button labelled \"Change skin\" will appear in the top-right corner. Clicking on it will open KShootMania Skin Manager.\n" +
                "From there, you'll two lists of skins, one of the left and one on the right. The one on the left is your complete list of skins you have installed and the one on the right is the list of skins you have loaded.\n" +
                "Your loaded skins all have different \"priorities\" and are ordered from lowest to highest priority. You can reorder the skin priorities with the increase and decrease higherarchy buttons.\n" +
                "Once you're done configuring your skin(s) to how you like them, click the \"Save\" button and KShootMania Skin Manager will replace the skin elements and reopen KShootMania.",

                "Skin hierarchy",
                "KShootMania Skin Manager works by loading multiple skins at once. These skins most likely will contains some of the same assets as each other. For this reason, your loaded skins will be organised in a heirarchy. If two skins share the same kind of asset, the asset from the skin higher in the heirarchy is used.\n" +
                "To avoid any issues with missing assets, it is recommended that you always have the default skin loaded at the bottom of the heirarchy.",

                "Moving KShootMania after installation",
                "If you want to move KShootMania after installing KShootMania Skin Manager, you must do a little more than just moving the folder.\n" +
                "It is recommended that you screenshot or write these instructions down as the process will prevent you from accessing this help while moving KShootMania.\n" +
                "First, right click your taskbar or press CTRL+ALT+Delete and select \"Task Manager\". From there, find the process named \"KShootMania Skin Manager (32 bit)\", right click it and select \"End task\".\n" +
                "Then, move KShootMania to where you want to put it.\n" +
                "Afterwards, go into KShootMania Skin Manager, open the file \"settings.ini\" and find the line starting with \"KSMDir\". Replace the directory listed after the '=' with the new directory you put KShootMania in.\n" +
                "Now, restart your computer and KShootMania Skin Manager should work with the new directory.",

                "Uninstalling KShootMania Skin Manager",
                "It is recommended that you screenshot or write these instructions down as the process will prevent you from accessing this help during and after uninstallation.\n" +
                "First, right click your taskbar or press CTRL+ALT+Delete and select \"Task Manager\". From there, find the process named \"KShootMania Skin Manager (32 bit)\", right click it and select \"End task\".\n" +
                @"Afterwards, if you installed KShootMania Skin Manager for your specific account, go to ""C:\Users\" + Environment.UserName + @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup"", or if you installed to all users, ""C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp"". Within the folder, you will find a shortcut to KShootMania Skin Manager. Delete it." + "\n" +
                "After that, delete the KShootMania Skin Manager folder. KShootMania Skin Manager is now fully uninstalled.",

                "Moving KShootMania Skin Manager after installation",
                "KShootMania Skin Manager can't be moved directly, but there are two hypothetical ways to move the program's install location.\n" +
                "It is recommended that you screenshot or write your perfered method's instructions down as both processes will prevent you from accessing this help during while moving KShooMania Skin Manager.\n" +
                "\n" +
                "METHOD 1:\n" +
                "Firstly, go into KShootMania Skin Manager's directory and back up the skins folder and settings.ini.\n" +
                "After that, uninstall KShootMania Skin Manager and reinstall it to the new location.\n" +
                "Then, go into Task Manager and end the KShootMania Skin Manager process like you did during the uninstallation.\n" +
                "Copy the skins folder and settings.ini file from the backup into the new installation of KShootMania Skin Manager.\n" +
                "Now, restart your computer and KShootMania Skin Manager should now work from within the new directory.\n" +
                "\n" +
                "METHOD 2:\n" +
                "First, right click your taskbar or press CTRL + ALT + Delete and select \"Task Manager\". From there, find the process named \"KShootMania Skin Manager (32 bit)\", right click it and select \"End task\".\n" +
                @"Afterwards, if you installed KShootMania Skin Manager for your specific account, go to ""C:\Users\" + Environment.UserName + @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup"", or if you installed to all users, ""C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp"". Within the folder, you will find a shortcut to KShootMania Skin Manager. Delete it, but leave the window open for later." + "\n" +
                "After that, move the KShootMania Skin Manager folder, right click \"KShootMania Skin Manager.exe\", mouse down to \"Send to\" and select \"Desktop (create shortcut)\".\n" +
                "Finally, copy the shortcut into the folder you left open and restart your computer. KShootMania Skin Manager should now work from within the new directory.",

                "Installing additional skins",
                "To install more skins to KShootMania Skin Manager, go to where you installed KShootMania Skin manager and extract the skin to the skins folder.\n" +
                "Keep in mind that the skin's file structure needs to be organised a certain way. See the default skin KShootMania Skin Manager generates for reference.",

                "Settings",
                "There are some settings in KShootMania Skin Manager that you can alter. There are two ways you can do this.\n" + 
                "The standard way to edit settings is to open up the change skin window and click the settings button. From there, you can edit a good number of the settings in this window, but it's not guaranteed that you'll be able to edit every setting from within the settings window.\n" + 
                "The other way is to edit the settings.ini file directly. To edit it, go into KShootMania Skin Manager's directory and open the settings.ini file. In there, you can change all of the settings that KShootMania allows you to change.",

                "Settings.ini breakdown",
                "A breakdown of each setting of the settings.ini file\n" +
                "KSMDir: The location of where the user has KShootMania. Don't change this outside of moving KShootMania. See \"Moving KShootMania after installation\" for how to do that.\n" +
                "TopPriorityOnTop: The way skins in the current skin configuration are organised in the change skin window. If this is \"true\", skins higher in the hierarchy will appear higher in the list. If this is \"false\", skins lower in the hierarchy will appear higher in the list.\n" +
                "ChangeSkinButtonPosition: The corner the change skin button will appear in when KShootMania is running. 0: Top-left corner. 1: Top-right corner. 2: Bottom-left corner. 3: Bottom-right corner."
                #endregion
                );
            InitializeComponent();
        }

        /// <summary>
        /// Display the help page and set the link to the link specified in the help page
        /// </summary>
        private void TopicsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (topics.ContainsKey(e.Node.Name))
            {
                string text = topics[e.Node.Name];
                string[] link_info = text.Split("\\L[", "]", "\\/L");
                int start = 0;
                int length = 0;
                // text part 1, link, link text (text part 2), text part 3
                if (link_info.Length == 4)
                {
                    start = link_info[0].Length;
                    length = link_info[2].Length;
                    text = new string[] { link_info[0], link_info[2], link_info[3] }.Stitch();
                    link = link_info[1];
                }

                TopicLabel.Text = text;
                TopicLabel.LinkArea = new LinkArea(start, length);
            }
            else
            {
                TopicLabel.Text = "";
                TopicLabel.LinkArea = new LinkArea();
            }
        }

        /// <summary>
        /// Open the link in the help page
        /// </summary>
        private void TopicLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(link);
        }
    }
}
