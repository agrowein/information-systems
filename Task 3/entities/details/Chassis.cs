namespace Task_3
{
    public class Chassis
    {
        private string name;

        public Chassis(string name) {
            this.name = name;
        }

        public override string ToString() {
            return this.name;
        }
    }
}