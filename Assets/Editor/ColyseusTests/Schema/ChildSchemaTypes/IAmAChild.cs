// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 1.0.0-alpha.42
// 

using Colyseus.Schema;

namespace SchemaTest.ChildSchemaTypes {
	public class IAmAChild : Schema {
		[Type(0, "number")]
		public float x = default(float);

		[Type(1, "number")]
		public float y = default(float);
	}
}
