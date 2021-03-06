﻿using System;

namespace CommandStructural {
	class Invoker {
		private Command _command;

		public void SetCommand(Command command) {
			this._command = command;
		}

		public void ExecuteCommand() {
			_command.Execute();
		}
	}
}