using System.Runtime.Serialization;

namespace DaanV2.DND {
	public partial class AbilityScores {
		/// <summary>Gets or sets the Strength ability score</summary>
		[DataMember] 
		public AbilityScore Strength { get => this._Strength; set => this._Strength = value; }

		/// <summary>Gets or sets the Constitution ability score</summary>
		[DataMember]
		public AbilityScore Constitution { get => this._Constitution; set => this._Constitution = value; }

		/// <summary>Gets or sets the Dexterity ability score</summary>
		[DataMember]
		public AbilityScore Dexterity { get => this._Dexterity; set => this._Dexterity = value; }

		/// <summary>Gets or sets the Intelligence ability score</summary>
		[DataMember]
		public AbilityScore Intelligence { get => this._Intelligence; set => this._Intelligence = value; }

		/// <summary>Gets or sets the Wisdom ability score</summary>
		[DataMember]
		public AbilityScore Wisdom { get => this._Wisdom; set => this._Wisdom = value; }

		/// <summary>Gets or sets the Charisma ability score</summary>
		[DataMember]
		public AbilityScore Charisma { get => this._Charisma; set => this._Charisma = value; }

	}
}
