using Task_3;

namespace Task_3
{
    public class Airplane : Flyable {
        private string name;
        private Engine engine;
        private Chassis chassis;
        private Wings wings;

        private string route;
        private string currAirport = "Аэропорт города Воронеж";

        public Airplane(string name, Engine engine, Chassis chassis, Wings wings) {
            this.name = name;
            this.engine = engine;
            this.chassis = chassis;
            this.wings = wings;
        }

        public void Fly() {
            if (this.engine == null || this.chassis == null || this.wings == null) {
                throw new System.Exception("Самолет не готов к полету!");
            } else if (this.route == "" || this.route == null) {
                throw new System.Exception("Не указан маршрут полета!");
            } else if (this.route == this.currAirport) {
                throw new System.Exception("Самолет находится в этом аэропорте!");
            } else {
                System.Console.WriteLine("Самолет летит из " + this.currAirport + " в " + this.route);
                this.currAirport = this.route;
                this.route = null;
            }
        }

        public string ViewRoute() {
            if (this.route == null) {
                return this.currAirport;
            }
            return this.currAirport + "-" + this.route;
        }
        
        public void SetRoute(string route) {
            this.route = route;
        }

        public override string ToString() {
            return $@"Самолет: {this.name}
            Двигатель: {this.engine.ToString()}
            Крылья: {this.wings.ToString()}
            Шасси: {this.chassis.ToString()}
            Маршрут: {this.currAirport} - {this.route}";
        }
    }
}