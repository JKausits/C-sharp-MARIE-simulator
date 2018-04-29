namespace Marie_Simulator
{
    public class Instruction {
        public int Operand { get; set; }
        public Opcode Opcode { get; set; }
        public Instruction()
        {

        }

        public Instruction(Opcode opcode)
        {
            Opcode = opcode;
        }

        public Instruction(Opcode opcode, int operand) : this(opcode)
        {
            Operand = operand;
        }

        
    }
}
