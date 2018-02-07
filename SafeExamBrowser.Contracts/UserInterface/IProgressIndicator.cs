﻿/*
 * Copyright (c) 2018 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using SafeExamBrowser.Contracts.I18n;

namespace SafeExamBrowser.Contracts.UserInterface
{
	public interface IProgressIndicator
	{
		/// <summary>
		/// Updates the progress value according to the specified amount.
		/// </summary>
		void Progress(int amount = 1);

		/// <summary>
		/// Regresses the progress value according to the specified amount.
		/// </summary>
		void Regress(int amount = 1);

		/// <summary>
		/// Sets the style of the progress indicator to indeterminate (<c>Progress</c> and <c>Regress</c> won't have any effect when called).
		/// </summary>
		void SetIndeterminate();

		/// <summary>
		/// Sets the maximum progress value.
		/// </summary>
		void SetMaxValue(int max);

		/// <summary>
		/// Sets the current progress value.
		/// </summary>
		void SetValue(int value);

		/// <summary>
		/// Updates the status text. If the busy flag is set, an animation will be shown to indicate a long-running operation.
		/// </summary>
		void UpdateText(TextKey key, bool showBusyIndication = false);
	}
}