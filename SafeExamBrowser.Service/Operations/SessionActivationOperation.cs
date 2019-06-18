﻿/*
 * Copyright (c) 2019 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using SafeExamBrowser.Contracts.Core.OperationModel;
using SafeExamBrowser.Contracts.Logging;

namespace SafeExamBrowser.Service.Operations
{
	internal class SessionActivationOperation : SessionOperation
	{
		private ILogger logger;

		public SessionActivationOperation(ILogger logger, SessionContext sessionContext) : base(sessionContext)
		{
			this.logger = logger;
		}

		public override OperationResult Perform()
		{
			var success = Context.EventWaitHandle.Set();

			if (success)
			{
				logger.Info("Successfully informed runtime about new session activation.");
			}
			else
			{
				logger.Error("Failed to inform runtime about new session activation!");
			}

			return success ? OperationResult.Success : OperationResult.Failed;
		}

		public override OperationResult Revert()
		{
			return OperationResult.Success;
		}
	}
}
