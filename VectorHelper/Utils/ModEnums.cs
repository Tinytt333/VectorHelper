using System.Reflection;
using VectorHelper;

namespace VectorHelper.Utils
{
	public class VHEnums
	{
		/// <summary>
		/// List of data types that VectorHelper supports (Mainly for variable storage)
		/// </summary>
		public enum DataType
		{
			String, Char, SByte, Byte, Short, UShort, Int, UInt, Long, ULong, Float, Double, Decimal, Bool, Object, Vector2, Vector3, Vector4, Color, EntityData, Dynamic, Any
		}

		/// <summary>
		/// List of variable types that VectorHelper supports (Mainly for variable storage)
		/// </summary>
		public enum VariableType
		{
			Variable, Array, List, Dictionary
		}

		/// <summary>
		/// One time options (expanded from One Time bool)
		/// </summary>
		public enum OnlyOnceModes
		{
			False, Level, Session, SaveFile
		}

		public enum SaveModes
		{
			SaveData, Session
		}

		public enum TriggerModes
		{
			OnLevelStart, OnLevelEnd, OnPlayerEnter, OnPlayerLeave, OnUpdate
		}
	}
}