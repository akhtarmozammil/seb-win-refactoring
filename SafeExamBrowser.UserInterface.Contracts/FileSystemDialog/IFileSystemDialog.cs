﻿/*
 * Copyright (c) 2020 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using SafeExamBrowser.UserInterface.Contracts.Windows;

namespace SafeExamBrowser.UserInterface.Contracts.FileSystemDialog
{
	public interface IFileSystemDialog
	{
		/// <summary>
		/// Shows the dialog to the user. If a parent window is specified, the dialog is rendered modally for the given parent.
		/// </summary>
		FileSystemDialogResult Show(IWindow parent = null);
	}
}
