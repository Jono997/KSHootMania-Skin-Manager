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
                "To install KShootMania Skin Manager, first, run the installer and select where you want KShootMania to install to, along with a zip file of KShootMania along with if you want to install a new copy of KSM for KShootMania Skin Manager, or tie it to a preexisting copy.\n" + 
                "Do note that if you want to install KShootMania Skin Manager for all users, or not have a misspelt uninstall shortcut in the start menu, you will need to run the installer as an administrator. To do so, right click on the installer and select \"Run as administrator\".\n" +
                "NOTE: If you want to move the installation location, you must uninstall KShootMania Skin Manager first. To do so, see \"Uninstallation\".",

                "Portable installation (NOT PROPERLY IMPLEMENTED YET)",
                "To create a portable installation of KShootMania Skin Manager for use on a flash drive or some other use, first, install KShootMania Skin Manager as normal, but you must choose to create a dedicated copy of KShootMania and install to just your user.\n" +
                @"Afterwards, press the windows key and r at the same time and enter ""regedit"". From there, navigate to ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Uninstall\KShootMania Skin Manager"" and delete the ""KShootMania Skin Manager"" folder." + "\n" +
                @"After that, press windows+r again and type ""%appdata"". From there, navigate to ""Microsoft\Windows\Start Menu\Programs\Startup"" and delete the ""KShootMania Skin Manager"" shortcut." + "\n" +
                "Following that, right click your taskbar or press CTRL+ALT+Delete and select \"Task Manager\". From there, find the process named \"KShootMania Skin Manager (32 bit)\", right click it and select \"End task\".\n" +
                "If you didn't install KShootMania Skin Manager to where you would be using it, cut and paste the installation from where you installed it to where you intend to use it.\n" + 
                "Open \"Install.xml\" with a text editor and look for the line that says \"<KShootManiaInstallLocation>\" and change the text inbetween the first > and the second < to just say \"kshootmania\". It should already say that at the end, but you need that end bit to be all that's there.\n" +
                "KShootMania Skin Manager should now work portably.",

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
                "Afterwards, go into KShootMania Skin Manager, open the file \"Install.xml\" and find the line starting with \"<KShootManiaInstallLocation>\". Replace the directory listed after the '>' with the new directory you put KShootMania in.\n" +
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
                "Firstly, go into KShootMania Skin Manager's directory and back up the skins folder, settings.ini and Install.xml.\n" +
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
