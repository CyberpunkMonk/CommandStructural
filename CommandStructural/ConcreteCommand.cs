using System;

namespace CommandStructural {
	class ConcreteCommand:Command {
		//C'tor
		public ConcreteCommand(Receiver receiver) : base(receiver) { }
		public override void Execute() {
			receiver.Action();
		}
	}
}