using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KShootMania_Skin_Manager
{
    public class Skin_result
    {
        /// <summary>
        /// Assets that this skin setup is missing. If this list is empty, the skin combination includes every asset and should work fine.
        /// </summary>
        public string[] missing_assets { get; private set; }

        /// <summary>
        /// The skin at this point in the array and all the skins before it in the array are not necessary to include all the asssts. If this is -1, all the skins are necessary.
        /// </summary>
        public int unnecessary_skins { get; private set; }

        #region result
        /// <summary>
        /// The three results of a check of the current skin
        /// </summary>
        public enum CheckResult
        {
            /// <summary>
            /// No issues with the skin
            /// </summary>
            Good,
            /// <summary>
            /// The skin will work, but some improvements could be made
            /// </summary>
            Warning,
            /// <summary>
            /// This skin will not work
            /// </summary>
            Error
        }

        /// <summary>
        /// The result of the skin check
        /// </summary>
        public CheckResult result { get; private set; }
        #endregion

        #region errors
        /// <summary>
        /// The various errors the skin can have
        /// </summary>
        public enum SkinErrors
        {
            /// <summary>
            /// The skin is missing elements
            /// </summary>
            Missing_elements = 0
        }

        /// <summary>
        /// The errors in the skin
        /// </summary>
        public SkinErrors[] errors { get; private set; }
        #endregion

        #region warnings
        /// <summary>
        /// The various warnings a skin can have
        /// </summary>
        public enum SkinWarnings
        {
            /// <summary>
            /// The skin has some skins that don't need to be used
            /// </summary>
            Unneeded_skins = 0
        }

        /// <summary>
        /// The warnings the skin has
        /// </summary>
        public SkinWarnings[] warnings { get; private set; }
        #endregion

        public Skin_result(string[] skin_setup)
        {
            List<SkinErrors> _errors = new List<SkinErrors>();
            List<SkinWarnings> _warnings = new List<SkinWarnings>();

            #region Missing skin elements & Unnecessary skins
            List<string> missing = Directory.GetFiles(CommonData.SkinDir + '\\' + CommonData.DefaultSkinName, "*", SearchOption.AllDirectories).ToList();
            int unnecessary = -1;

            for (int i = skin_setup.Length - 1; i >= 0; i--)
            {
                if (missing.Count == 0)
                {
                    unnecessary = i;
                    break;
                }
                else
                    foreach (string item in Directory.GetFiles(CommonData.SkinDir + "\\" + skin_setup[i], "*", SearchOption.AllDirectories))
                        if (missing.Contains(item))
                            missing.Remove(item);
            }

            missing_assets = missing.ToArray();
            unnecessary_skins = unnecessary;

            if (missing.Count > 0)
                _errors.Add(SkinErrors.Missing_elements);
            if (unnecessary != -1)
                _warnings.Add(SkinWarnings.Unneeded_skins);
            #endregion

            #region errors, warnings & result
            errors = _errors.ToArray();
            warnings = _warnings.ToArray();

            if (errors.Length > 0)
                result = CheckResult.Error;
            else if (warnings.Length > 0)
                result = CheckResult.Warning;
            else
                result = CheckResult.Good;
            #endregion
        }
    }
}
