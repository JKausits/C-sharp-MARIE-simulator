namespace Marie_Simulator
{
    public class Symbol : Instruction{
        public string Label { get; set; }
        public Symbol()
        {

        }

        public Symbol(Opcode opcode, int operand, string label) : base(opcode, operand)
        {
            Label = label;
        }
    }
}
