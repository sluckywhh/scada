﻿/*
 * Copyright 2018 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : Administrator
 * Summary  : Common data of the application
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2018
 * Modified : 2018
 */

using System.Text;
using Utils;

namespace Scada.Admin.App.Code
{
    /// <summary>
    /// Common data of the application.
    /// <para>Общие данные приложения.</para>
    /// </summary>
    public sealed class AppData
    {
        /// <summary>
        /// Short name of the application error log file.
        /// </summary>
        private const string ErrFileName = "ScadaAdmin.err";


        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public AppData()
        {
            AppDirs = new AppDirs();
            ErrLog = new Log(Log.Formats.Full);
        }


        /// <summary>
        /// Gets the application directories.
        /// </summary>
        public AppDirs AppDirs { get; private set; }

        /// <summary>
        /// Gets the application error log.
        /// </summary>
        public Log ErrLog { get; private set; }


        /// <summary>
        /// Initializes the common data.
        /// </summary>
        public void Init(string exeDir)
        {
            AppDirs.Init(exeDir);

            ErrLog.FileName = AppDirs.LogDir + ErrFileName;
            ErrLog.Encoding = Encoding.UTF8;
        }

        /// <summary>
        /// Makes finalization steps.
        /// </summary>
        public void FinalizeApp()
        {
        }
    }
}