namespace CNCMaps.MapLogic {
	public class AircraftObject : NamedObject, OwnableObject {
		public AircraftObject(string owner, string name, short health, short direction) {
			Owner = owner;
			Name = name;
			Health = health;
			Direction = direction;
		}

		public short Health { get; set; }
		public short Direction { get; set; }
		public string Owner { get; set; }
	}
}