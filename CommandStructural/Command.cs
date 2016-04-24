using System;

namespace CommandStructural {
	abstract class Command {
		protected Receiver receiver;
		//C'tor
		public Command(Receiver receiver) { this.receiver = receiver; }
		public abstract void Execute();
	}
}