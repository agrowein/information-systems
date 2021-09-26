namespace Task_3
{
    public class Engine
    {
        private string name;

        public Engine(string name) {
            this.name = name;
        }

        public override string ToString() {
            return this.name;
        }
    }
}