using System;
using System.Collections.Generic;
using Celeste.Mod;
using VectorHelper.Utils;

namespace VectorHelper
{
	public class VectorHelperSaveData : EverestModuleSaveData
	{
		// The variable dictionaries are here
		// Adding the data types to the dictionaries is done when loading a chapter in a save file that doesnt already have them
		public Dictionary<string, Dictionary<string, object>> Variables { get; set; } = new Dictionary<string, Dictionary<string, object>>();
		public Dictionary<string, Dictionary<string, object[]>> Arrays { get; set; } = new Dictionary<string, Dictionary<string, object[]>>();
		public Dictionary<string, Dictionary<string, List<object>>> Lists { get; set; } = new Dictionary<string, Dictionary<string, List<object>>>();
		public Dictionary<string, Dictionary<string, Dictionary<string, object>>> Dictionaries { get; set; } = new Dictionary<string, Dictionary<string, Dictionary<string, object>>>();

		// Set variables (Basically the main part of VectorHelper Variables)
		public void SetVariable(string VariableName, VHEnums.DataType DataType = VHEnums.DataType.String, VHEnums.VariableType Type = VHEnums.VariableType.Variable, string Value = "", string ArrayLength = "")
		{
			switch (Type)
			{
				case VHEnums.VariableType.Variable:
					
					break;
			}
		}
	}
}