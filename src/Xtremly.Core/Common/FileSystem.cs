using System;
using System.IO;
using System.Linq;

namespace Xtremly.Core
{
    public static class FileSystem
    {
        public static readonly CurrentFolder Current = new();
        public static readonly DesktopFolder Desktop = new();
        public static readonly ProgramsFolder Programs = new();
        public static readonly MyDocumentsFolder MyDocuments = new();
        public static readonly PersonalFolder Personal = new();
        public static readonly FavoritesFolder Favorites = new();
        public static readonly StartupFolder Startup = new();
        public static readonly RecentFolder Recent = new();
        public static readonly SendToFolder SendTo = new();
        public static readonly StartMenuFolder StartMenu = new();
        public static readonly MyMusicFolder MyMusic = new();
        public static readonly MyVideosFolder MyVideos = new();
        public static readonly DesktopDirectoryFolder DesktopDirectory = new();
        public static readonly MyComputerFolder MyComputer = new();
        public static readonly NetworkShortcutsFolder NetworkShortcuts = new();
        public static readonly FontsFolder Fonts = new();
        public static readonly TemplatesFolder Templates = new();
        public static readonly CommonStartMenuFolder CommonStartMenu = new();
        public static readonly CommonProgramsFolder CommonPrograms = new();
        public static readonly CommonStartupFolder CommonStartup = new();
        public static readonly CommonDesktopDirectoryFolder CommonDesktopDirectory = new();
        public static readonly ApplicationDataFolder ApplicationData = new();
        public static readonly PrinterShortcutsFolder PrinterShortcuts = new();
        public static readonly LocalApplicationDataFolder LocalApplicationData = new();
        public static readonly InternetCacheFolder InternetCache = new();
        public static readonly CookiesFolder Cookies = new();
        public static readonly HistoryFolder History = new();
        public static readonly CommonApplicationDataFolder CommonApplicationData = new();
        public static readonly WindowsFolder Windows = new();
        public static readonly SystemFolder System = new();
        public static readonly ProgramFilesFolder ProgramFiles = new();
        public static readonly MyPicturesFolder MyPictures = new();
        public static readonly UserProfileFolder UserProfile = new();
        public static readonly SystemX86Folder SystemX86 = new();
        public static readonly ProgramFilesX86Folder ProgramFilesX86 = new();
        public static readonly CommonProgramFilesFolder CommonProgramFiles = new();
        public static readonly CommonProgramFilesX86Folder CommonProgramFilesX86 = new();
        public static readonly CommonTemplatesFolder CommonTemplates = new();
        public static readonly CommonDocumentsFolder CommonDocuments = new();
        public static readonly CommonAdminToolsFolder CommonAdminTools = new();
        public static readonly AdminToolsFolder AdminTools = new();
        public static readonly CommonMusicFolder CommonMusic = new();
        public static readonly CommonPicturesFolder CommonPictures = new();
        public static readonly CommonVideosFolder CommonVideos = new();
        public static readonly ResourcesFolder Resources = new();
        public static readonly LocalizedResourcesFolder LocalizedResources = new();
        public static readonly CommonOemLinksFolder CommonOemLinks = new();
        public static readonly CDBurningFolder CDBurning = new();


    }
    public readonly struct CurrentFolder
    {
        public override string ToString()
        {
            return Environment.CurrentDirectory;
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CurrentFolder currentFolder)
        {
            return currentFolder.ToString();
        }
    }
    public readonly struct DesktopFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(DesktopFolder desktopFolder)
        {
            return desktopFolder.ToString();
        }
    }
    public readonly struct ProgramsFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Programs);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());

            /* 项目“Xtremly.Core (net48)”的未合并的更改
            在此之前:
                    public static explicit operator string(ProgramsFolder programsFolder) => programsFolder.ToString();
            在此之后:
                    public static explicit operator string(ProgramsFolder programsFolder)
                    {
                        return programsFolder.ToString();
            */

            /* 项目“Xtremly.Core (net451)”的未合并的更改
            在此之前:
                    public static explicit operator string(ProgramsFolder programsFolder) => programsFolder.ToString();
            在此之后:
                    public static explicit operator string(ProgramsFolder programsFolder)
                    {
                        return programsFolder.ToString();
            */

            /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
            在此之前:
                    public static explicit operator string(ProgramsFolder programsFolder) => programsFolder.ToString();
            在此之后:
                    public static explicit operator string(ProgramsFolder programsFolder)
                    {
                        return programsFolder.ToString();
            */

            /* 项目“Xtremly.Core (net6.0)”的未合并的更改
            在此之前:
                    public static explicit operator string(ProgramsFolder programsFolder) => programsFolder.ToString();
            在此之后:
                    public static explicit operator string(ProgramsFolder programsFolder)
                    {
                        return programsFolder.ToString();
            */

            /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
            在此之前:
                    public static explicit operator string(ProgramsFolder programsFolder) => programsFolder.ToString();
            在此之后:
                    public static explicit operator string(ProgramsFolder programsFolder)
                    {
                        return programsFolder.ToString();
            */

            /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
            在此之前:
                    public static explicit operator string(ProgramsFolder programsFolder) => programsFolder.ToString();
            在此之后:
                    public static explicit operator string(ProgramsFolder programsFolder)
                    {
                        return programsFolder.ToString();
            */

            /* 项目“Xtremly.Core (net7.0)”的未合并的更改
            在此之前:
                    public static explicit operator string(ProgramsFolder programsFolder) => programsFolder.ToString();
            在此之后:
                    public static explicit operator string(ProgramsFolder programsFolder)
                    {
                        return programsFolder.ToString();
            */
        }

        public static explicit operator string(ProgramsFolder programsFolder)
        {
            return programsFolder.ToString();
        }
    }
    public readonly struct MyDocumentsFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyDocumentsFolder myDocumentsFolder) => myDocumentsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyDocumentsFolder myDocumentsFolder)
                {
                    return myDocumentsFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyDocumentsFolder myDocumentsFolder) => myDocumentsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyDocumentsFolder myDocumentsFolder)
                {
                    return myDocumentsFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyDocumentsFolder myDocumentsFolder) => myDocumentsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyDocumentsFolder myDocumentsFolder)
                {
                    return myDocumentsFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyDocumentsFolder myDocumentsFolder) => myDocumentsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyDocumentsFolder myDocumentsFolder)
                {
                    return myDocumentsFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyDocumentsFolder myDocumentsFolder) => myDocumentsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyDocumentsFolder myDocumentsFolder)
                {
                    return myDocumentsFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyDocumentsFolder myDocumentsFolder) => myDocumentsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyDocumentsFolder myDocumentsFolder)
                {
                    return myDocumentsFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyDocumentsFolder myDocumentsFolder) => myDocumentsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyDocumentsFolder myDocumentsFolder)
                {
                    return myDocumentsFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(MyDocumentsFolder myDocumentsFolder)
        {
            return myDocumentsFolder.ToString();
        }
    }
    public readonly struct PersonalFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(PersonalFolder personalFolder) => personalFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(PersonalFolder personalFolder)
                {
                    return personalFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(PersonalFolder personalFolder) => personalFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(PersonalFolder personalFolder)
                {
                    return personalFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(PersonalFolder personalFolder) => personalFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(PersonalFolder personalFolder)
                {
                    return personalFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(PersonalFolder personalFolder) => personalFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(PersonalFolder personalFolder)
                {
                    return personalFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(PersonalFolder personalFolder) => personalFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(PersonalFolder personalFolder)
                {
                    return personalFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(PersonalFolder personalFolder) => personalFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(PersonalFolder personalFolder)
                {
                    return personalFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(PersonalFolder personalFolder) => personalFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(PersonalFolder personalFolder)
                {
                    return personalFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(PersonalFolder personalFolder)
        {
            return personalFolder.ToString();
        }
    }
    public readonly struct FavoritesFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(FavoritesFolder favoritesFolder) => favoritesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(FavoritesFolder favoritesFolder)
                {
                    return favoritesFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(FavoritesFolder favoritesFolder) => favoritesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(FavoritesFolder favoritesFolder)
                {
                    return favoritesFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(FavoritesFolder favoritesFolder) => favoritesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(FavoritesFolder favoritesFolder)
                {
                    return favoritesFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(FavoritesFolder favoritesFolder) => favoritesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(FavoritesFolder favoritesFolder)
                {
                    return favoritesFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(FavoritesFolder favoritesFolder) => favoritesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(FavoritesFolder favoritesFolder)
                {
                    return favoritesFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(FavoritesFolder favoritesFolder) => favoritesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(FavoritesFolder favoritesFolder)
                {
                    return favoritesFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(FavoritesFolder favoritesFolder) => favoritesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(FavoritesFolder favoritesFolder)
                {
                    return favoritesFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(FavoritesFolder favoritesFolder)
        {
            return favoritesFolder.ToString();
        }
    }
    public readonly struct StartupFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(StartupFolder startupFolder) => startupFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(StartupFolder startupFolder)
                {
                    return startupFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(StartupFolder startupFolder) => startupFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(StartupFolder startupFolder)
                {
                    return startupFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(StartupFolder startupFolder) => startupFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(StartupFolder startupFolder)
                {
                    return startupFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(StartupFolder startupFolder) => startupFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(StartupFolder startupFolder)
                {
                    return startupFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(StartupFolder startupFolder) => startupFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(StartupFolder startupFolder)
                {
                    return startupFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(StartupFolder startupFolder) => startupFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(StartupFolder startupFolder)
                {
                    return startupFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(StartupFolder startupFolder) => startupFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(StartupFolder startupFolder)
                {
                    return startupFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Startup);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(StartupFolder startupFolder)
        {
            return startupFolder.ToString();
        }
    }
    public readonly struct RecentFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(RecentFolder recentFolder) => recentFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(RecentFolder recentFolder)
                {
                    return recentFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(RecentFolder recentFolder) => recentFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(RecentFolder recentFolder)
                {
                    return recentFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(RecentFolder recentFolder) => recentFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(RecentFolder recentFolder)
                {
                    return recentFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(RecentFolder recentFolder) => recentFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(RecentFolder recentFolder)
                {
                    return recentFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(RecentFolder recentFolder) => recentFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(RecentFolder recentFolder)
                {
                    return recentFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(RecentFolder recentFolder) => recentFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(RecentFolder recentFolder)
                {
                    return recentFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(RecentFolder recentFolder) => recentFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(RecentFolder recentFolder)
                {
                    return recentFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Recent);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(RecentFolder recentFolder)
        {
            return recentFolder.ToString();
        }
    }
    public readonly struct SendToFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SendToFolder sendToFolder) => sendToFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SendToFolder sendToFolder)
                {
                    return sendToFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SendToFolder sendToFolder) => sendToFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SendToFolder sendToFolder)
                {
                    return sendToFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SendToFolder sendToFolder) => sendToFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SendToFolder sendToFolder)
                {
                    return sendToFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SendToFolder sendToFolder) => sendToFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SendToFolder sendToFolder)
                {
                    return sendToFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SendToFolder sendToFolder) => sendToFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SendToFolder sendToFolder)
                {
                    return sendToFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SendToFolder sendToFolder) => sendToFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SendToFolder sendToFolder)
                {
                    return sendToFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SendToFolder sendToFolder) => sendToFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SendToFolder sendToFolder)
                {
                    return sendToFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(SendToFolder sendToFolder)
        {
            return sendToFolder.ToString();
        }
    }
    public readonly struct StartMenuFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(StartMenuFolder startMenuFolder)
        {
            return startMenuFolder.ToString();
        }
    }
    public readonly struct MyMusicFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(MyMusicFolder myMusicFolder)
        {
            return myMusicFolder.ToString();
        }
    }
    public readonly struct MyVideosFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(MyVideosFolder myVideosFolder)
        {
            return myVideosFolder.ToString();
        }
    }
    public readonly struct DesktopDirectoryFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(DesktopDirectoryFolder desktopDirectoryFolder)
        {
            return desktopDirectoryFolder.ToString();
        }
    }
    public readonly struct MyComputerFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(MyComputerFolder myComputerFolder)
        {
            return myComputerFolder.ToString();
        }
    }
    public readonly struct NetworkShortcutsFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.NetworkShortcuts);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(NetworkShortcutsFolder networkShortcutsFolder)
        {
            return networkShortcutsFolder.ToString();
        }
    }
    public readonly struct FontsFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());

            /* 项目“Xtremly.Core (net48)”的未合并的更改
            在此之前:
                    public static explicit operator string(FontsFolder fontsFolder) => fontsFolder.ToString();
            在此之后:
                    public static explicit operator string(FontsFolder fontsFolder)
                    {
                        return fontsFolder.ToString();
            */

            /* 项目“Xtremly.Core (net451)”的未合并的更改
            在此之前:
                    public static explicit operator string(FontsFolder fontsFolder) => fontsFolder.ToString();
            在此之后:
                    public static explicit operator string(FontsFolder fontsFolder)
                    {
                        return fontsFolder.ToString();
            */

            /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
            在此之前:
                    public static explicit operator string(FontsFolder fontsFolder) => fontsFolder.ToString();
            在此之后:
                    public static explicit operator string(FontsFolder fontsFolder)
                    {
                        return fontsFolder.ToString();
            */

            /* 项目“Xtremly.Core (net6.0)”的未合并的更改
            在此之前:
                    public static explicit operator string(FontsFolder fontsFolder) => fontsFolder.ToString();
            在此之后:
                    public static explicit operator string(FontsFolder fontsFolder)
                    {
                        return fontsFolder.ToString();
            */

            /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
            在此之前:
                    public static explicit operator string(FontsFolder fontsFolder) => fontsFolder.ToString();
            在此之后:
                    public static explicit operator string(FontsFolder fontsFolder)
                    {
                        return fontsFolder.ToString();
            */

            /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
            在此之前:
                    public static explicit operator string(FontsFolder fontsFolder) => fontsFolder.ToString();
            在此之后:
                    public static explicit operator string(FontsFolder fontsFolder)
                    {
                        return fontsFolder.ToString();
            */

            /* 项目“Xtremly.Core (net7.0)”的未合并的更改
            在此之前:
                    public static explicit operator string(FontsFolder fontsFolder) => fontsFolder.ToString();
            在此之后:
                    public static explicit operator string(FontsFolder fontsFolder)
                    {
                        return fontsFolder.ToString();
            */
        }

        public static explicit operator string(FontsFolder fontsFolder)
        {
            return fontsFolder.ToString();
        }
    }
    public readonly struct TemplatesFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(TemplatesFolder templatesFolder) => templatesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(TemplatesFolder templatesFolder)
                {
                    return templatesFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(TemplatesFolder templatesFolder) => templatesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(TemplatesFolder templatesFolder)
                {
                    return templatesFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(TemplatesFolder templatesFolder) => templatesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(TemplatesFolder templatesFolder)
                {
                    return templatesFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(TemplatesFolder templatesFolder) => templatesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(TemplatesFolder templatesFolder)
                {
                    return templatesFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(TemplatesFolder templatesFolder) => templatesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(TemplatesFolder templatesFolder)
                {
                    return templatesFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(TemplatesFolder templatesFolder) => templatesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(TemplatesFolder templatesFolder)
                {
                    return templatesFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(TemplatesFolder templatesFolder) => templatesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Templates);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(TemplatesFolder templatesFolder)
                {
                    return templatesFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Templates);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(TemplatesFolder templatesFolder)
        {
            return templatesFolder.ToString();
        }
    }
    public readonly struct CommonStartMenuFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartMenuFolder commonStartMenuFolder) => commonStartMenuFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartMenuFolder commonStartMenuFolder)
                {
                    return commonStartMenuFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartMenuFolder commonStartMenuFolder) => commonStartMenuFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartMenuFolder commonStartMenuFolder)
                {
                    return commonStartMenuFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartMenuFolder commonStartMenuFolder) => commonStartMenuFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartMenuFolder commonStartMenuFolder)
                {
                    return commonStartMenuFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartMenuFolder commonStartMenuFolder) => commonStartMenuFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartMenuFolder commonStartMenuFolder)
                {
                    return commonStartMenuFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartMenuFolder commonStartMenuFolder) => commonStartMenuFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartMenuFolder commonStartMenuFolder)
                {
                    return commonStartMenuFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartMenuFolder commonStartMenuFolder) => commonStartMenuFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartMenuFolder commonStartMenuFolder)
                {
                    return commonStartMenuFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartMenuFolder commonStartMenuFolder) => commonStartMenuFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartMenuFolder commonStartMenuFolder)
                {
                    return commonStartMenuFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CommonStartMenuFolder commonStartMenuFolder)
        {
            return commonStartMenuFolder.ToString();
        }
    }
    public readonly struct CommonProgramsFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonProgramsFolder commonProgramsFolder) => commonProgramsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonProgramsFolder commonProgramsFolder)
                {
                    return commonProgramsFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonProgramsFolder commonProgramsFolder) => commonProgramsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonProgramsFolder commonProgramsFolder)
                {
                    return commonProgramsFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonProgramsFolder commonProgramsFolder) => commonProgramsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonProgramsFolder commonProgramsFolder)
                {
                    return commonProgramsFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonProgramsFolder commonProgramsFolder) => commonProgramsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonProgramsFolder commonProgramsFolder)
                {
                    return commonProgramsFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonProgramsFolder commonProgramsFolder) => commonProgramsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonProgramsFolder commonProgramsFolder)
                {
                    return commonProgramsFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonProgramsFolder commonProgramsFolder) => commonProgramsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonProgramsFolder commonProgramsFolder)
                {
                    return commonProgramsFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonProgramsFolder commonProgramsFolder) => commonProgramsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonProgramsFolder commonProgramsFolder)
                {
                    return commonProgramsFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CommonProgramsFolder commonProgramsFolder)
        {
            return commonProgramsFolder.ToString();
        }
    }
    public readonly struct CommonStartupFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartupFolder commonStartupFolder) => commonStartupFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartupFolder commonStartupFolder)
                {
                    return commonStartupFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartupFolder commonStartupFolder) => commonStartupFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartupFolder commonStartupFolder)
                {
                    return commonStartupFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartupFolder commonStartupFolder) => commonStartupFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartupFolder commonStartupFolder)
                {
                    return commonStartupFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartupFolder commonStartupFolder) => commonStartupFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartupFolder commonStartupFolder)
                {
                    return commonStartupFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartupFolder commonStartupFolder) => commonStartupFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartupFolder commonStartupFolder)
                {
                    return commonStartupFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartupFolder commonStartupFolder) => commonStartupFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartupFolder commonStartupFolder)
                {
                    return commonStartupFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartupFolder commonStartupFolder) => commonStartupFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonStartupFolder commonStartupFolder)
                {
                    return commonStartupFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CommonStartupFolder commonStartupFolder)
        {
            return commonStartupFolder.ToString();
        }
    }
    public readonly struct CommonDesktopDirectoryFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonDesktopDirectoryFolder commonDesktopDirectoryFolder) => commonDesktopDirectoryFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonDesktopDirectoryFolder commonDesktopDirectoryFolder)
                {
                    return commonDesktopDirectoryFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonDesktopDirectoryFolder commonDesktopDirectoryFolder) => commonDesktopDirectoryFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonDesktopDirectoryFolder commonDesktopDirectoryFolder)
                {
                    return commonDesktopDirectoryFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonDesktopDirectoryFolder commonDesktopDirectoryFolder) => commonDesktopDirectoryFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonDesktopDirectoryFolder commonDesktopDirectoryFolder)
                {
                    return commonDesktopDirectoryFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonDesktopDirectoryFolder commonDesktopDirectoryFolder) => commonDesktopDirectoryFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonDesktopDirectoryFolder commonDesktopDirectoryFolder)
                {
                    return commonDesktopDirectoryFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonDesktopDirectoryFolder commonDesktopDirectoryFolder) => commonDesktopDirectoryFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonDesktopDirectoryFolder commonDesktopDirectoryFolder)
                {
                    return commonDesktopDirectoryFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonDesktopDirectoryFolder commonDesktopDirectoryFolder) => commonDesktopDirectoryFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonDesktopDirectoryFolder commonDesktopDirectoryFolder)
                {
                    return commonDesktopDirectoryFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonDesktopDirectoryFolder commonDesktopDirectoryFolder) => commonDesktopDirectoryFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonDesktopDirectoryFolder commonDesktopDirectoryFolder)
                {
                    return commonDesktopDirectoryFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CommonDesktopDirectoryFolder commonDesktopDirectoryFolder)
        {
            return commonDesktopDirectoryFolder.ToString();
        }
    }
    public readonly struct ApplicationDataFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ApplicationDataFolder applicationDataFolder) => applicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ApplicationDataFolder applicationDataFolder)
                {
                    return applicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ApplicationDataFolder applicationDataFolder) => applicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ApplicationDataFolder applicationDataFolder)
                {
                    return applicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ApplicationDataFolder applicationDataFolder) => applicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ApplicationDataFolder applicationDataFolder)
                {
                    return applicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ApplicationDataFolder applicationDataFolder) => applicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ApplicationDataFolder applicationDataFolder)
                {
                    return applicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ApplicationDataFolder applicationDataFolder) => applicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ApplicationDataFolder applicationDataFolder)
                {
                    return applicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ApplicationDataFolder applicationDataFolder) => applicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ApplicationDataFolder applicationDataFolder)
                {
                    return applicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ApplicationDataFolder applicationDataFolder) => applicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ApplicationDataFolder applicationDataFolder)
                {
                    return applicationDataFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(ApplicationDataFolder applicationDataFolder)
        {
            return applicationDataFolder.ToString();
        }
    }
    public readonly struct PrinterShortcutsFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.PrinterShortcuts);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());

            /* 项目“Xtremly.Core (net48)”的未合并的更改
            在此之前:
                    public static explicit operator string(PrinterShortcutsFolder printerShortcutsFolder) => printerShortcutsFolder.ToString();
            在此之后:
                    public static explicit operator string(PrinterShortcutsFolder printerShortcutsFolder)
                    {
                        return printerShortcutsFolder.ToString();
            */

            /* 项目“Xtremly.Core (net451)”的未合并的更改
            在此之前:
                    public static explicit operator string(PrinterShortcutsFolder printerShortcutsFolder) => printerShortcutsFolder.ToString();
            在此之后:
                    public static explicit operator string(PrinterShortcutsFolder printerShortcutsFolder)
                    {
                        return printerShortcutsFolder.ToString();
            */

            /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
            在此之前:
                    public static explicit operator string(PrinterShortcutsFolder printerShortcutsFolder) => printerShortcutsFolder.ToString();
            在此之后:
                    public static explicit operator string(PrinterShortcutsFolder printerShortcutsFolder)
                    {
                        return printerShortcutsFolder.ToString();
            */

            /* 项目“Xtremly.Core (net6.0)”的未合并的更改
            在此之前:
                    public static explicit operator string(PrinterShortcutsFolder printerShortcutsFolder) => printerShortcutsFolder.ToString();
            在此之后:
                    public static explicit operator string(PrinterShortcutsFolder printerShortcutsFolder)
                    {
                        return printerShortcutsFolder.ToString();
            */

            /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
            在此之前:
                    public static explicit operator string(PrinterShortcutsFolder printerShortcutsFolder) => printerShortcutsFolder.ToString();
            在此之后:
                    public static explicit operator string(PrinterShortcutsFolder printerShortcutsFolder)
                    {
                        return printerShortcutsFolder.ToString();
            */

            /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
            在此之前:
                    public static explicit operator string(PrinterShortcutsFolder printerShortcutsFolder) => printerShortcutsFolder.ToString();
            在此之后:
                    public static explicit operator string(PrinterShortcutsFolder printerShortcutsFolder)
                    {
                        return printerShortcutsFolder.ToString();
            */

            /* 项目“Xtremly.Core (net7.0)”的未合并的更改
            在此之前:
                    public static explicit operator string(PrinterShortcutsFolder printerShortcutsFolder) => printerShortcutsFolder.ToString();
            在此之后:
                    public static explicit operator string(PrinterShortcutsFolder printerShortcutsFolder)
                    {
                        return printerShortcutsFolder.ToString();
            */
        }

        public static explicit operator string(PrinterShortcutsFolder printerShortcutsFolder)
        {
            return printerShortcutsFolder.ToString();
        }
    }
    public readonly struct LocalApplicationDataFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(LocalApplicationDataFolder localApplicationDataFolder) => localApplicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(LocalApplicationDataFolder localApplicationDataFolder)
                {
                    return localApplicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(LocalApplicationDataFolder localApplicationDataFolder) => localApplicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(LocalApplicationDataFolder localApplicationDataFolder)
                {
                    return localApplicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(LocalApplicationDataFolder localApplicationDataFolder) => localApplicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(LocalApplicationDataFolder localApplicationDataFolder)
                {
                    return localApplicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(LocalApplicationDataFolder localApplicationDataFolder) => localApplicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(LocalApplicationDataFolder localApplicationDataFolder)
                {
                    return localApplicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(LocalApplicationDataFolder localApplicationDataFolder) => localApplicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(LocalApplicationDataFolder localApplicationDataFolder)
                {
                    return localApplicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(LocalApplicationDataFolder localApplicationDataFolder) => localApplicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(LocalApplicationDataFolder localApplicationDataFolder)
                {
                    return localApplicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(LocalApplicationDataFolder localApplicationDataFolder) => localApplicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(LocalApplicationDataFolder localApplicationDataFolder)
                {
                    return localApplicationDataFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(LocalApplicationDataFolder localApplicationDataFolder)
        {
            return localApplicationDataFolder.ToString();
        }
    }
    public readonly struct InternetCacheFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(InternetCacheFolder internetCacheFolder) => internetCacheFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(InternetCacheFolder internetCacheFolder)
                {
                    return internetCacheFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(InternetCacheFolder internetCacheFolder) => internetCacheFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(InternetCacheFolder internetCacheFolder)
                {
                    return internetCacheFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(InternetCacheFolder internetCacheFolder) => internetCacheFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(InternetCacheFolder internetCacheFolder)
                {
                    return internetCacheFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(InternetCacheFolder internetCacheFolder) => internetCacheFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(InternetCacheFolder internetCacheFolder)
                {
                    return internetCacheFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(InternetCacheFolder internetCacheFolder) => internetCacheFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(InternetCacheFolder internetCacheFolder)
                {
                    return internetCacheFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(InternetCacheFolder internetCacheFolder) => internetCacheFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(InternetCacheFolder internetCacheFolder)
                {
                    return internetCacheFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(InternetCacheFolder internetCacheFolder) => internetCacheFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(InternetCacheFolder internetCacheFolder)
                {
                    return internetCacheFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(InternetCacheFolder internetCacheFolder)
        {
            return internetCacheFolder.ToString();
        }
    }
    public readonly struct CookiesFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CookiesFolder cookiesFolder) => cookiesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CookiesFolder cookiesFolder)
                {
                    return cookiesFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CookiesFolder cookiesFolder) => cookiesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CookiesFolder cookiesFolder)
                {
                    return cookiesFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CookiesFolder cookiesFolder) => cookiesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CookiesFolder cookiesFolder)
                {
                    return cookiesFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CookiesFolder cookiesFolder) => cookiesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CookiesFolder cookiesFolder)
                {
                    return cookiesFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CookiesFolder cookiesFolder) => cookiesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CookiesFolder cookiesFolder)
                {
                    return cookiesFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CookiesFolder cookiesFolder) => cookiesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CookiesFolder cookiesFolder)
                {
                    return cookiesFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CookiesFolder cookiesFolder) => cookiesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CookiesFolder cookiesFolder)
                {
                    return cookiesFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CookiesFolder cookiesFolder)
        {
            return cookiesFolder.ToString();
        }
    }
    public readonly struct HistoryFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.History);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(HistoryFolder historyFolder) => historyFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.History);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(HistoryFolder historyFolder)
                {
                    return historyFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.History);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(HistoryFolder historyFolder) => historyFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.History);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(HistoryFolder historyFolder)
                {
                    return historyFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.History);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(HistoryFolder historyFolder) => historyFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.History);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(HistoryFolder historyFolder)
                {
                    return historyFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.History);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(HistoryFolder historyFolder) => historyFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.History);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(HistoryFolder historyFolder)
                {
                    return historyFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.History);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(HistoryFolder historyFolder) => historyFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.History);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(HistoryFolder historyFolder)
                {
                    return historyFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.History);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(HistoryFolder historyFolder) => historyFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.History);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(HistoryFolder historyFolder)
                {
                    return historyFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.History);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(HistoryFolder historyFolder) => historyFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.History);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(HistoryFolder historyFolder)
                {
                    return historyFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.History);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(HistoryFolder historyFolder)
        {
            return historyFolder.ToString();
        }
    }
    public readonly struct CommonApplicationDataFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonApplicationDataFolder commonApplicationDataFolder) => commonApplicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonApplicationDataFolder commonApplicationDataFolder)
                {
                    return commonApplicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonApplicationDataFolder commonApplicationDataFolder) => commonApplicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonApplicationDataFolder commonApplicationDataFolder)
                {
                    return commonApplicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonApplicationDataFolder commonApplicationDataFolder) => commonApplicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonApplicationDataFolder commonApplicationDataFolder)
                {
                    return commonApplicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonApplicationDataFolder commonApplicationDataFolder) => commonApplicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonApplicationDataFolder commonApplicationDataFolder)
                {
                    return commonApplicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonApplicationDataFolder commonApplicationDataFolder) => commonApplicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonApplicationDataFolder commonApplicationDataFolder)
                {
                    return commonApplicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonApplicationDataFolder commonApplicationDataFolder) => commonApplicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonApplicationDataFolder commonApplicationDataFolder)
                {
                    return commonApplicationDataFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonApplicationDataFolder commonApplicationDataFolder) => commonApplicationDataFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(CommonApplicationDataFolder commonApplicationDataFolder)
                {
                    return commonApplicationDataFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CommonApplicationDataFolder commonApplicationDataFolder)
        {
            return commonApplicationDataFolder.ToString();
        }
    }
    public readonly struct WindowsFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(WindowsFolder windowsFolder) => windowsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(WindowsFolder windowsFolder)
                {
                    return windowsFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(WindowsFolder windowsFolder) => windowsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(WindowsFolder windowsFolder)
                {
                    return windowsFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(WindowsFolder windowsFolder) => windowsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(WindowsFolder windowsFolder)
                {
                    return windowsFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(WindowsFolder windowsFolder) => windowsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(WindowsFolder windowsFolder)
                {
                    return windowsFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(WindowsFolder windowsFolder) => windowsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(WindowsFolder windowsFolder)
                {
                    return windowsFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(WindowsFolder windowsFolder) => windowsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(WindowsFolder windowsFolder)
                {
                    return windowsFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(WindowsFolder windowsFolder) => windowsFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(WindowsFolder windowsFolder)
                {
                    return windowsFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Windows);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(WindowsFolder windowsFolder)
        {
            return windowsFolder.ToString();
        }
    }
    public readonly struct SystemFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.System);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemFolder systemFolder) => systemFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.System);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemFolder systemFolder)
                {
                    return systemFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.System);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemFolder systemFolder) => systemFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.System);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemFolder systemFolder)
                {
                    return systemFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.System);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemFolder systemFolder) => systemFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.System);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemFolder systemFolder)
                {
                    return systemFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.System);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemFolder systemFolder) => systemFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.System);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemFolder systemFolder)
                {
                    return systemFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.System);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemFolder systemFolder) => systemFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.System);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemFolder systemFolder)
                {
                    return systemFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.System);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemFolder systemFolder) => systemFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.System);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemFolder systemFolder)
                {
                    return systemFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.System);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemFolder systemFolder) => systemFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.System);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemFolder systemFolder)
                {
                    return systemFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.System);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(SystemFolder systemFolder)
        {
            return systemFolder.ToString();
        }
    }
    public readonly struct ProgramFilesFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesFolder programFilesFolder) => programFilesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesFolder programFilesFolder)
                {
                    return programFilesFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesFolder programFilesFolder) => programFilesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesFolder programFilesFolder)
                {
                    return programFilesFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesFolder programFilesFolder) => programFilesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesFolder programFilesFolder)
                {
                    return programFilesFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesFolder programFilesFolder) => programFilesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesFolder programFilesFolder)
                {
                    return programFilesFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesFolder programFilesFolder) => programFilesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesFolder programFilesFolder)
                {
                    return programFilesFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesFolder programFilesFolder) => programFilesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesFolder programFilesFolder)
                {
                    return programFilesFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesFolder programFilesFolder) => programFilesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesFolder programFilesFolder)
                {
                    return programFilesFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(ProgramFilesFolder programFilesFolder)
        {
            return programFilesFolder.ToString();
        }
    }
    public readonly struct MyPicturesFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyPicturesFolder myPicturesFolder) => myPicturesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyPicturesFolder myPicturesFolder)
                {
                    return myPicturesFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyPicturesFolder myPicturesFolder) => myPicturesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyPicturesFolder myPicturesFolder)
                {
                    return myPicturesFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyPicturesFolder myPicturesFolder) => myPicturesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyPicturesFolder myPicturesFolder)
                {
                    return myPicturesFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyPicturesFolder myPicturesFolder) => myPicturesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyPicturesFolder myPicturesFolder)
                {
                    return myPicturesFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyPicturesFolder myPicturesFolder) => myPicturesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyPicturesFolder myPicturesFolder)
                {
                    return myPicturesFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyPicturesFolder myPicturesFolder) => myPicturesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyPicturesFolder myPicturesFolder)
                {
                    return myPicturesFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyPicturesFolder myPicturesFolder) => myPicturesFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(MyPicturesFolder myPicturesFolder)
                {
                    return myPicturesFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(MyPicturesFolder myPicturesFolder)
        {
            return myPicturesFolder.ToString();
        }
    }
    public readonly struct UserProfileFolder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(UserProfileFolder userProfileFolder) => userProfileFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(UserProfileFolder userProfileFolder)
                {
                    return userProfileFolder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(UserProfileFolder userProfileFolder) => userProfileFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(UserProfileFolder userProfileFolder)
                {
                    return userProfileFolder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(UserProfileFolder userProfileFolder) => userProfileFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(UserProfileFolder userProfileFolder)
                {
                    return userProfileFolder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(UserProfileFolder userProfileFolder) => userProfileFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(UserProfileFolder userProfileFolder)
                {
                    return userProfileFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(UserProfileFolder userProfileFolder) => userProfileFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(UserProfileFolder userProfileFolder)
                {
                    return userProfileFolder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(UserProfileFolder userProfileFolder) => userProfileFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(UserProfileFolder userProfileFolder)
                {
                    return userProfileFolder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(UserProfileFolder userProfileFolder) => userProfileFolder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(UserProfileFolder userProfileFolder)
                {
                    return userProfileFolder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(UserProfileFolder userProfileFolder)
        {
            return userProfileFolder.ToString();
        }
    }
    public readonly struct SystemX86Folder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemX86Folder systemX86Folder) => systemX86Folder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemX86Folder systemX86Folder)
                {
                    return systemX86Folder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemX86Folder systemX86Folder) => systemX86Folder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemX86Folder systemX86Folder)
                {
                    return systemX86Folder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemX86Folder systemX86Folder) => systemX86Folder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemX86Folder systemX86Folder)
                {
                    return systemX86Folder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemX86Folder systemX86Folder) => systemX86Folder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemX86Folder systemX86Folder)
                {
                    return systemX86Folder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemX86Folder systemX86Folder) => systemX86Folder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemX86Folder systemX86Folder)
                {
                    return systemX86Folder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemX86Folder systemX86Folder) => systemX86Folder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemX86Folder systemX86Folder)
                {
                    return systemX86Folder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemX86Folder systemX86Folder) => systemX86Folder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(SystemX86Folder systemX86Folder)
                {
                    return systemX86Folder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(SystemX86Folder systemX86Folder)
        {
            return systemX86Folder.ToString();
        }
    }
    public readonly struct ProgramFilesX86Folder
    {

        /* 项目“Xtremly.Core (net48)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesX86Folder programFilesX86Folder) => programFilesX86Folder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesX86Folder programFilesX86Folder)
                {
                    return programFilesX86Folder.ToString();
        */

        /* 项目“Xtremly.Core (net451)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesX86Folder programFilesX86Folder) => programFilesX86Folder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesX86Folder programFilesX86Folder)
                {
                    return programFilesX86Folder.ToString();
        */

        /* 项目“Xtremly.Core (netcoreapp3.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesX86Folder programFilesX86Folder) => programFilesX86Folder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesX86Folder programFilesX86Folder)
                {
                    return programFilesX86Folder.ToString();
        */

        /* 项目“Xtremly.Core (net6.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesX86Folder programFilesX86Folder) => programFilesX86Folder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesX86Folder programFilesX86Folder)
                {
                    return programFilesX86Folder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesX86Folder programFilesX86Folder) => programFilesX86Folder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesX86Folder programFilesX86Folder)
                {
                    return programFilesX86Folder.ToString();
        */

        /* 项目“Xtremly.Core (netstandard2.1)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesX86Folder programFilesX86Folder) => programFilesX86Folder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesX86Folder programFilesX86Folder)
                {
                    return programFilesX86Folder.ToString();
        */

        /* 项目“Xtremly.Core (net7.0)”的未合并的更改
        在此之前:
                public override string ToString() => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                public string Combine(params string[] paths) => Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesX86Folder programFilesX86Folder) => programFilesX86Folder.ToString();
        在此之后:
                public override string ToString()
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                public string Combine(params string[] paths)
                {
                    return Path.Combine(new[] { this.ToString() }.Concat(paths).ToArray());
                public static explicit operator string(ProgramFilesX86Folder programFilesX86Folder)
                {
                    return programFilesX86Folder.ToString();
        */
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(ProgramFilesX86Folder programFilesX86Folder)
        {
            return programFilesX86Folder.ToString();
        }
    }
    public readonly struct CommonProgramFilesFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CommonProgramFilesFolder commonProgramFilesFolder)
        {
            return commonProgramFilesFolder.ToString();
        }
    }
    public readonly struct CommonProgramFilesX86Folder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CommonProgramFilesX86Folder commonProgramFilesX86Folder)
        {
            return commonProgramFilesX86Folder.ToString();
        }
    }
    public readonly struct CommonTemplatesFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonTemplates);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CommonTemplatesFolder commonTemplatesFolder)
        {
            return commonTemplatesFolder.ToString();
        }
    }
    public readonly struct CommonDocumentsFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CommonDocumentsFolder commonDocumentsFolder)
        {
            return commonDocumentsFolder.ToString();
        }
    }
    public readonly struct CommonAdminToolsFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonAdminTools);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CommonAdminToolsFolder commonAdminToolsFolder)
        {
            return commonAdminToolsFolder.ToString();
        }
    }
    public readonly struct AdminToolsFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.AdminTools);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(AdminToolsFolder adminToolsFolder)
        {
            return adminToolsFolder.ToString();
        }
    }
    public readonly struct CommonMusicFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CommonMusicFolder commonMusicFolder)
        {
            return commonMusicFolder.ToString();
        }
    }
    public readonly struct CommonPicturesFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CommonPicturesFolder commonPicturesFolder)
        {
            return commonPicturesFolder.ToString();
        }
    }
    public readonly struct CommonVideosFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CommonVideosFolder commonVideosFolder)
        {
            return commonVideosFolder.ToString();
        }
    }
    public readonly struct ResourcesFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Resources);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(ResourcesFolder resourcesFolder)
        {
            return resourcesFolder.ToString();
        }
    }
    public readonly struct LocalizedResourcesFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.LocalizedResources);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(LocalizedResourcesFolder localizedResourcesFolder)
        {
            return localizedResourcesFolder.ToString();
        }
    }
    public readonly struct CommonOemLinksFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonOemLinks);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CommonOemLinksFolder commonOemLinksFolder)
        {
            return commonOemLinksFolder.ToString();
        }
    }
    public readonly struct CDBurningFolder
    {
        public override string ToString()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CDBurning);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(new[] { ToString() }.Concat(paths).ToArray());
        }

        public static explicit operator string(CDBurningFolder cDBurningFolder)
        {
            return cDBurningFolder.ToString();
        }
    }
}
