using System.Collections.Generic;

namespace Umbraco.Core.IO
{
    public interface IIOHelper
    {

        string BackOfficePath { get; }

        char DirSepChar { get; }
        string FindFile(string virtualPath);
        string ResolveVirtualUrl(string path);
        string ResolveUrl(string virtualPath);
        Attempt<string> TryResolveUrl(string virtualPath);
        string MapPath(string path);


        /// <summary>
        /// Verifies that the current filepath matches a directory where the user is allowed to edit a file.
        /// </summary>
        /// <param name="filePath">The filepath to validate.</param>
        /// <param name="validDir">The valid directory.</param>
        /// <returns>A value indicating whether the filepath is valid.</returns>
        bool VerifyEditPath(string filePath, string validDir);

        /// <summary>
        /// Verifies that the current filepath matches one of several directories where the user is allowed to edit a file.
        /// </summary>
        /// <param name="filePath">The filepath to validate.</param>
        /// <param name="validDirs">The valid directories.</param>
        /// <returns>A value indicating whether the filepath is valid.</returns>
        bool VerifyEditPath(string filePath, IEnumerable<string> validDirs);

        /// <summary>
        /// Verifies that the current filepath has one of several authorized extensions.
        /// </summary>
        /// <param name="filePath">The filepath to validate.</param>
        /// <param name="validFileExtensions">The valid extensions.</param>
        /// <returns>A value indicating whether the filepath is valid.</returns>
        bool VerifyFileExtension(string filePath, IEnumerable<string> validFileExtensions);

        bool PathStartsWith(string path, string root, char separator);

        void EnsurePathExists(string path);

        /// <summary>
        /// Get properly formatted relative path from an existing absolute or relative path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        string GetRelativePath(string path);

        /// <summary>
        /// Gets the root path of the application
        /// </summary>
        /// <remarks>
        /// In most cases this will be an empty string which indicates the app is not running in a virtual directory.
        /// This is NOT a physical path.
        /// </remarks>
        string Root
        {
            get;
            set; //Only required for unit tests
        }

    }
}